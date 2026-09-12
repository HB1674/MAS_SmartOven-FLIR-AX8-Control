using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sres.Net.EEIP;
using System.Drawing.Drawing2D;


namespace FLiRCap
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }

        private bool timTempUse = false;
        private bool timReloginUse = false;
        private Ax8CIPProp _ax8Cip = new Ax8CIPProp();
        private Ax8HttpImage _ax8HttpClient;

        // Device connection information is omitted in the public repository.
        private const string AX8_IP = "YOUR_FLIR_AX8_IP";
        private const string AX8_USERNAME = "YOUR_USERNAME";
        private const string AX8_PASSWORD = "YOUR_PASSWORD";

        private void FrmMain_Load(object sender, EventArgs e)
        {
            chkSpot1.Tag = 1;
            chkSpot2.Tag = 2;
            chkSpot3.Tag = 3;
            chkSpot4.Tag = 4;
            chkSpot5.Tag = 5;
            chkSpot6.Tag = 6;
        }

        private void btnFindFLiRAx8_Click(object sender, EventArgs e)
        {
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false; // 로그인 후 버튼 비활성화
            lblLogInStatus.Text = "로그인 중 ...";

            Stopwatch sw = Stopwatch.StartNew();
            try
            {
                _ax8HttpClient = new Ax8HttpImage("http://" + AX8_IP, AX8_USERNAME, AX8_PASSWORD);
                await _ax8HttpClient.LoginAsync();

                sw.Stop();
                string st_dtime = string.Format("{0:0.00}", (double)sw.ElapsedMilliseconds / 1000.0);

                try
                {
                    // 1) CIP 연결
                    await _ax8Cip.ConnectAsync(AX8_IP);

                    // 2) 장치 식별(제품명) 확인
                    string name = await _ax8Cip.ReadProductNameAsync();

                    lblConnectCIP.Text = "CIP 연결 성공";

                }
                catch
                {
                    _ax8Cip.Disconnect();
                    lblConnectCIP.Text = "CIP 연결 실패";
                }

                try
                {
                    await _ax8Cip.SetFreezeAsync(false);
                    _ax8Cip.InitSpotCache(1, 6);                 // Spot 캐시 ID 범위 초기화
                    btnUpdateSpot.PerformClick();
                    await _ax8HttpClient.SetImageModeAsync("VISUAL");
                    await Task.Delay(300);               // 장치 내부 파이프 안정화(권장)
                }
                catch (Exception ex)
                {
                    Console.WriteLine("set fusion failed: " + ex.Message);
                }

                timTempUse = true;
                timReloginUse = true;

                lblLogInStatus.Text = "로그인!! " + st_dtime;
            }
            catch
            {
                sw.Stop();
                string st_dtime = string.Format("{0:0.00}", (double)sw.ElapsedMilliseconds / 1000.0);
                lblLogInStatus.Text = "로그인 실패! " + st_dtime;
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        private async void timReLogin_Tick(object sender, EventArgs e)
        {
            if (timReloginUse == false) return;
            if (_ax8HttpClient == null) return;

            lblReLoginStatus.Text = "재로그인 중 ...";

            try
            {
                bool success = await _ax8HttpClient.TryReloginAsync();
                lblReLoginStatus.Text = success ? "재로그인 완료" : "재로그인 보류";
            }
            catch (Exception ex)
            {
                Console.WriteLine("relogin failed: " + ex.Message);
                lblReLoginStatus.Text = "재로그인 실패";
            }
        }

        private async void btnGetImage_Click(object sender, EventArgs e)
        {
            if (_ax8HttpClient == null) return; // 아직 로그인/초기화 전

            Stopwatch sw = Stopwatch.StartNew();
            try
            {
                Bitmap bmp = await _ax8HttpClient.GetImageOnceAsync();
                if (bmp == null)
                {
                    // fetchGate에 걸렸거나 로그인 상태가 아니면 null 가능
                    lblGetImageSec.Text = "Error";
                    return;
                }

                // 안전한 스왑 + 이전 이미지 해제
                Image old = picCamera.Image;
                picCamera.Image = bmp;
                old?.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetImage unknown error: " + ex.Message);
            }
            finally
            {
                sw.Stop();
                lblGetImageSec.Text = string.Format("{0:0.000}", sw.Elapsed.TotalSeconds);
            }
        }

        private void timGetImage_Tick(object sender, EventArgs e)
        {
            if (chkAutoGetImage.Checked == false) return;
            if (_ax8HttpClient == null) return;
            btnGetImage.PerformClick();
        }

        private async void radFusion_CheckedChanged(object sender, EventArgs e)
        {
            if (_ax8HttpClient == null || !((RadioButton)sender).Checked) return;
            await _ax8HttpClient.SetImageModeAsync("FUSION");
            picCamera.Invalidate();
        }

        private async void radVisual_CheckedChanged(object sender, EventArgs e)
        {
            if (_ax8HttpClient == null || !((RadioButton)sender).Checked) return;
            await _ax8HttpClient.SetImageModeAsync("VISUAL");
            picCamera.Invalidate();
        }

        private async void radIR_CheckedChanged(object sender, EventArgs e)
        {
            if (_ax8HttpClient == null || !((RadioButton)sender).Checked) return;
            await _ax8HttpClient.SetImageModeAsync("IR");
            picCamera.Invalidate();
        }

        private async void btnSnap_Click(object sender, EventArgs e)
        {
            if (btnSnap.Enabled == false) return;
            if (_ax8HttpClient == null) return;
            btnSnap.Enabled = false;
            try
            {
                await _ax8HttpClient.SaveSnapshotAsync();
                // 성공 메시지 표시
                lblSnapStatus.Text = "스냅샷 성공!";
            }
            catch (Exception ex)
            {
                Console.WriteLine("스냅샷 실패: " + ex.Message);
            }
            finally
            {
                // 2초 뒤 다시 원래 상태로 복원
                _ = Task.Run(async () =>
                {
                    await Task.Delay(2000); // 2초 대기
                    if (lblSnapStatus.InvokeRequired)
                        lblSnapStatus.BeginInvoke((Action)(() => lblSnapStatus.Text = "****"));
                    else
                        lblSnapStatus.Text = "****";
                });
                btnSnap.Enabled = true;
            }
        }

        private async void chkTorch_CheckedChanged(object sender, EventArgs e)
        {
            if (_ax8HttpClient == null) return;
            bool on = ((CheckBox)sender).Checked;
            try
            {
                await _ax8HttpClient.SetTorchAsync(on);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Torch 설정 실패: " + ex.Message);
                // 실패 시 UI 롤백
                ((CheckBox)sender).Checked = !on;
            }
        }

        private async void btnGetTempSpot_Click(object sender, EventArgs e)
        {

            Stopwatch sw = Stopwatch.StartNew();
            try
            {
                // CIP 연결이 안 되어 있으면 먼저 연결 (이미 연결이면 내부에서 바로 return)
                await _ax8Cip.ConnectAsync(AX8_IP);

                await _ax8Cip.RefreshAllTempsIntoCacheAsync();

                Ax8CIPProp.SpotState[] basics = _ax8Cip.Spots;

                foreach (Ax8CIPProp.SpotState s in basics)
                {
                    Label lbl = this.Controls.Find($"lblSpotTemp{s.Id}", true).FirstOrDefault() as Label;
                    CheckBox chk = this.Controls.Find($"chkSpot{s.Id}", true).FirstOrDefault() as CheckBox;

                    if (lbl == null || chk == null) continue;
                    // 체크박스가 있으면 그 상태를, 없으면 Spot의 Active 속성을 신뢰
                    bool isOn = (chk != null) ? chk.Checked : s.Active;

                    if (isOn)
                        lbl.Text = $"Spot{s.Id} 온도 : {s.Celsius:F1} °C";
                    else
                        lbl.Text = $"Spot{s.Id} Active : False";
                }
                
                sw.Stop();
                lblGetTempTime.Text = "온도 측정 시간 : " + sw.ElapsedMilliseconds.ToString() + "ms";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Spot 온도 읽기 실패: " + ex.Message);
            }
        }

        private async void btnGetTempCamera_Click(object sender, EventArgs e)
        {
            try
            {
                float? tempC = await _ax8Cip.ReadInternalCameraTempC();
                lblCameraTemp.Text = $"카메라 온도 : {tempC:F1} °C";
            }
            catch (OperationCanceledException)
            {
                lblCameraTemp.Text = $"Core Temp 읽기 타임 아웃";
            }
            catch (Exception ex)
            {
                lblCameraTemp.Text = "Core Temp 읽기 오류: " + ex.Message;
            }

        }


        private bool _tempPollBusy = false;
        private void timTemp_Tick(object sender, EventArgs e)
        {
            if (_ax8Cip == null) return;
            if (chkAutoGetTemp.Checked == false) return;
            if (timTempUse == false) return;

            _tempPollBusy = true;
            try
            {
                btnGetTempSpot.PerformClick();
                btnGetTempCamera.PerformClick();
            }
            finally
            {
                _tempPollBusy = false;
            }
        }

        
        // 체크 박스 이벤트
        private bool _updatingSpotChecks = false; // UI ↔ 서버 간 동기화 중일 때 플래그
        // spot active 활성/비활성 변경
        private async void chkSpot_CheckedChanged(object sender, EventArgs e)
        {
            if (_updatingSpotChecks == true) return;
            if (_ax8Cip == null || _ax8Cip.IsConnected == false) return;

            CheckBox chk = sender as CheckBox;
            if (chk == null) return;
            if (!(chk.Tag is int spotId)) return; // Tag에 Spot ID가 들어있어야 함

            try
            {
                await _ax8Cip.SetSpotActiveAndCacheAsync(spotId, chk.Checked);
                Ax8CIPProp.SpotState basics = _ax8Cip.GetSpotFromCache(spotId);
                Label lbl = this.Controls.Find($"lblSpot{spotId}", true).FirstOrDefault() as Label;
                if (lbl != null)
                {
                    Point viewPt = Ax8CIPProp.SensorToView(new Point(basics.X, basics.Y), picCamera.Width, picCamera.Height);
                    lbl.Text = $"Spot {basics.Id} : Active={basics.Active}, X={viewPt.X}, Y={viewPt.Y}";
                    // 성공 시 별도 처리 없음 (UI가 곧 진실)
                }
            }
            catch (Exception ex)
            {
                // 실패 시 체크 되돌림
                _updatingSpotChecks = true;
                try
                {
                    chk.Checked = !chk.Checked;
                }
                finally { _updatingSpotChecks = false; }

                Console.Write($"Spot {spotId} 활성화 변경 실패: {ex.Message}");
            }
        }
              
        private async void btnMoveSpot_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            try
            {
                int spotId = int.Parse(txtGetID.Text);   // TextBox에서 Spot ID 입력
                int x = int.Parse(txtGetX.Text);         // X 좌표 입력
                int y = int.Parse(txtGetY.Text);         // Y 좌표 입력

                Point sensorPt = Ax8CIPProp.ViewToSensor(new Point(x, y), picCamera.Width, picCamera.Height);

                await _ax8Cip.MoveSpotAndCacheAsync(spotId, sensorPt.X, sensorPt.Y);
                Ax8CIPProp.SpotState basics = _ax8Cip.GetSpotFromCache(spotId);
                
                Label lbl = this.Controls.Find($"lblSpot{spotId}", true).FirstOrDefault() as Label;                
                if(lbl != null)
                {
                    Point viewPt = Ax8CIPProp.SensorToView(new Point(basics.X, basics.Y), picCamera.Width, picCamera.Height);
                    lbl.Text = $"Spot {basics.Id} : Active={basics.Active}, X={x}({viewPt.X}), Y={y}({viewPt.Y})";
                }

                sw.Stop();
                lblMoveSpotTime.Text = "Spot 위치 조정 시간 : " + sw.ElapsedMilliseconds.ToString() + "ms";


                Console.Write(
                    $"Spot {spotId} 위치 이동 완료 → ({x}, {y})");

                picCamera.Invalidate();

            }
            catch (Exception ex)
            {
                Console.WriteLine( "Spot 이동 실패: " + ex.Message);
            }

        }
       
        private async void btnMoveSpotAll_Click(object sender, EventArgs e)
        {
            btnMoveSpotAll.Enabled = false;
            Stopwatch sw = Stopwatch.StartNew();
            try
            {
                int[] xs = new int[] { Convert.ToInt32(txtSpot1X.Text), Convert.ToInt32(txtSpot2X.Text), Convert.ToInt32(txtSpot3X.Text), Convert.ToInt32(txtSpot4X.Text), Convert.ToInt32(txtSpot5X.Text), Convert.ToInt32(txtSpot6X.Text) };
                int[] ys = new int[] { Convert.ToInt32(txtSpot1Y.Text), Convert.ToInt32(txtSpot2Y.Text), Convert.ToInt32(txtSpot3Y.Text), Convert.ToInt32(txtSpot4Y.Text), Convert.ToInt32(txtSpot5Y.Text), Convert.ToInt32(txtSpot6Y.Text) };
                int[] ids = new[] { 1, 2, 3, 4, 5, 6 };  // 필요 시 1..6

                // 2) 각 Spot별로 View→Sensor 변환
                var targets = new List<(int id, int x, int y)>(ids.Length);
                for (int i = 0; i < ids.Length; i++)
                {

                    Point viewPt = ClampToClient(new Point(xs[i], ys[i]));
                    Point sensorPt = Ax8CIPProp.ViewToSensor(viewPt, picCamera.Width, picCamera.Height);

                    targets.Add((ids[i], sensorPt.X, sensorPt.Y));
                }

                await _ax8Cip.MoveSpotsAndCacheAsync(targets);
                Ax8CIPProp.SpotState[] basics = _ax8Cip.Spots;

                foreach (Ax8CIPProp.SpotState s in basics)
                {
                    Point viewPt = Ax8CIPProp.SensorToView(new Point(s.X, s.Y), picCamera.Width, picCamera.Height);
                    Label lbl = this.Controls.Find($"lblSpot{s.Id}", true).FirstOrDefault() as Label;
                    if (lbl != null)
                    {
                        lbl.Text = $"Spot {s.Id} : Active={s.Active}, X={xs[s.Id-1]}({viewPt.X}), Y={ys[s.Id - 1]}({viewPt.Y})";
                    }
                }

                sw.Stop();

                lblMoveSpotTime.Text = "다중 Spot 위치 조정 시간 : " + sw.ElapsedMilliseconds.ToString() + "ms";

                Console.Write("모든 Spot 위치 이동 완료", "CIP");

                picCamera.Invalidate();

            }
            catch (Exception ex)
            {
                sw.Stop();
                lblMoveSpotTime.Text = $"오류 (elapsed {sw.ElapsedMilliseconds} ms)";
                Console.WriteLine("다중 이동 실패: " + ex.Message);
            }
            finally
            {
                btnMoveSpotAll.Enabled = true;
            }
        }

        private async void btnUpdateSpot_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            try
            {
                await _ax8Cip.RefreshAllSpotBasicsAsync();
                Ax8CIPProp.SpotState[] basics = _ax8Cip.Spots;

                _updatingSpotChecks = true;   // ★ 이벤트 재진입 방지 시작
                try
                {
                    foreach (Ax8CIPProp.SpotState s in basics)
                    {
                        Point viewPt = Ax8CIPProp.SensorToView(new Point(s.X, s.Y), picCamera.Width, picCamera.Height);

                        // 라벨 갱신 (이름 규칙: lblSpot1 ~ lblSpot6)
                        Label lbl = this.Controls.Find($"lblSpot{s.Id}", true).FirstOrDefault() as Label;
                        if (lbl != null)
                        {
                            lbl.Text = $"Spot {s.Id} : Active={s.Active}, X={viewPt.X}, Y={viewPt.Y}";
                        }
                        // 체크박스 찾기 (Tag에 Spot ID를 심어둔 경우)
                        CheckBox ctrl = this.Controls.Find($"chkSpot{s.Id}", true).FirstOrDefault() as CheckBox;
                        if (ctrl != null)
                        {
                            ctrl.Checked = s.Active;
                        }
                    }
                }
                finally
                {
                    _updatingSpotChecks = false;  // ★ 이벤트 재진입 방지 끝
                }

                sw.Stop();
                lblGetStateTime.Text = $"일괄 정보 읽기 (온도 제외) {sw.ElapsedMilliseconds}ms";
                picCamera.Invalidate();
            }
            catch (Exception ex)
            {
                lblSpot1.Text = "Read failed: " + ex.Message;
            }
        }

        // Freeze/Live 변경
        private bool _updatingFreeze = false;
        private async void chkFreeze_CheckedChanged(object sender, EventArgs e)
        {
            if (_updatingFreeze) return;
            if (_ax8Cip == null || _ax8Cip.IsConnected == false) return;

            CheckBox chk = sender as CheckBox;
            if (chk == null) return;

            try
            {
                await _ax8Cip.SetFreezeAsync(chk.Checked);
            }
            catch (Exception ex)
            {
                // 실패 시 체크 상태 롤백
                _updatingFreeze = true;
                try { chk.Checked = !chk.Checked; }
                finally { _updatingFreeze = false; }

                Console.WriteLine("Freeze 설정 실패: " + ex.Message);
            }
            picCamera.Invalidate();
        }

        // Picturebox bitmap 저장
        private void btnSaveView_Click(object sender, EventArgs e)
        {
            if (picCamera.Image == null) return;
            btnSaveView.Enabled = false;
            try
            {
                picCamera.Refresh();
                using (Bitmap bmp = new Bitmap(picCamera.ClientSize.Width, picCamera.ClientSize.Height,
                                            System.Drawing.Imaging.PixelFormat.Format32bppArgb))
                {
                    // PictureBox에 보이는 이미지 + Paint에서 그린 오버레이까지 포함되어 캡처됨
                    picCamera.DrawToBitmap(bmp, picCamera.ClientRectangle);

                    string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Snapshots");
                    Directory.CreateDirectory(dir);
                    string name = "VIEW_" + DateTime.Now.ToString("yyyyMMdd_HHmmss_fff") + ".png";
                    string path = Path.Combine(dir, name);

                    // 오버레이 포함 화면 캡처는 PNG 권장(무손실, BMP보다 용량 작음)
                    bmp.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                }

                lblSaveView.Text = "화면 저장 성공!";
            }
            catch (Exception ex)
            {
                lblSaveView.Text = "화면 저장 실패";
                Console.WriteLine("SaveView failed: " + ex.Message);
            }

            finally
            {
                // 2초 뒤 다시 원래 상태로 복원
                _ = Task.Run(async () =>
                {
                    await Task.Delay(2000); // 2초 대기
                    if (lblSaveView.InvokeRequired)
                        lblSaveView.BeginInvoke((Action)(() => lblSaveView.Text = "****"));
                    else
                        lblSaveView.Text = "****";
                });

                btnSaveView.Enabled = true;
            }
        }

        // Picturebox Spot 위치 시각적 확인 여부
        private void chkHidden_CheckedChanged(object sender, EventArgs e)
        {
            if (_ax8HttpClient == null) return;
            if (_ax8HttpClient == null) return;
            picCamera.Invalidate();
        }

        // 그리기 관련 함수
        private int? _dragSpotId = null;
        private Point _dragCurrentView;   // 화면 좌표(픽셀)
        private bool _isDragging = false;
        private Point ClampToClient(Point p)
        {
            int x = Math.Max(0, Math.Min(picCamera.Width - 1, p.X));
            int y = Math.Max(0, Math.Min(picCamera.Height - 1, p.Y));
            return new Point(x, y);
        }
        private void picCamera_Paint(object sender, PaintEventArgs e)
        {
            if (picCamera.Image == null) return;
            if (_ax8HttpClient == null) return;
            if (_ax8Cip == null) return;
            if (chkHidden.Checked) return;

            Graphics g = e.Graphics;
            Ax8CIPProp.SpotState[] basics = _ax8Cip.Spots;
            if (basics == null || basics.Length == 0) return;

            int midX = picCamera.Width / 2;     // 기준: 가로 중앙
            int r = 6;                          // 점 반경

            foreach (Ax8CIPProp.SpotState s in basics)
            {
                CheckBox chk = this.Controls.Find($"chkSpot{s.Id}", true).FirstOrDefault() as CheckBox;
                if (chk == null) continue;
                if(chk.Checked == false) continue;

                // 드래그 중이고 대상 Spot이면 마우스 좌표로 그리기
                bool isDraggingThis = _isDragging && _dragSpotId.HasValue && s.Id == _dragSpotId.Value;
                Point pos = isDraggingThis
                           ? _dragCurrentView
                           : Ax8CIPProp.SensorToView(new Point(s.X, s.Y), picCamera.Width, picCamera.Height);


                Brush fill = isDraggingThis ? Brushes.Orange : Brushes.Lime;   // 드래그 중이면 색상 구분
                Pen pen = isDraggingThis ? Pens.DarkOrange : Pens.Black;
                g.FillEllipse(fill, pos.X - r, pos.Y - r, r * 2, r * 2);
                g.DrawEllipse(pen, pos.X - r, pos.Y - r, r * 2, r * 2);

                string label = $"#{s.Id} {s.Celsius:F1}°C";
                using (Font f = new Font(this.Font.FontFamily, this.Font.Size + 1, this.Font.Style))
                {
                    // 1) 여분 패딩 없이 정확한 텍스트 폭 측정
                    Size sz = TextRenderer.MeasureText(
                        label, f, new Size(int.MaxValue, int.MaxValue),
                        TextFormatFlags.NoPadding
                    );

                    float labelX, labelY = pos.Y - r - 2;

                    if (pos.X < midX)
                    {
                        // 왼쪽 스팟 → 라벨 오른쪽
                        labelX = pos.X + r + 2;
                    }
                    else
                    {
                        // 오른쪽 스팟 → 라벨 왼쪽 (정확 폭만큼)
                        labelX = pos.X - r - 2 - sz.Width;
                    }

                    // 2) 텍스트 그리기 (NoPadding, NoClipping)
                    TextRenderer.DrawText(
                        e.Graphics, label, f, new Point((int)labelX, (int)labelY),
                        Color.White, TextFormatFlags.NoPadding | TextFormatFlags.NoClipping
                    );
                }
            }
        }

        private void picCamera_MouseDown(object sender, MouseEventArgs e)
        {
            if (picCamera.Image == null || _ax8Cip == null) return;
            if (e.Button != MouseButtons.Left) return;

            var spots = _ax8Cip.Spots ?? Array.Empty<Ax8CIPProp.SpotState>();
            int hitR = 8;

            foreach (var s in spots)
            {
                var chk = this.Controls.Find($"chkSpot{s.Id}", true).FirstOrDefault() as CheckBox;
                if (chk == null || !chk.Checked) continue;

                Point v = Ax8CIPProp.SensorToView(new Point(s.X, s.Y), picCamera.Width, picCamera.Height);
                int dx = v.X - e.X, dy = v.Y - e.Y;
                if (dx * dx + dy * dy <= hitR * hitR)
                {
                    _dragSpotId = s.Id;
                    _isDragging = true;
                    _dragCurrentView = ClampToClient(e.Location);
                    picCamera.Capture = true;           // ★ 바깥에서 놓아도 MouseUp을 받도록
                    picCamera.Invalidate();
                    break;
                }
            }
        }

        private void picCamera_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDragging || _dragSpotId == null) return;

            _dragCurrentView = ClampToClient(e.Location);  // ★ 경계 내로 고정
            picCamera.Invalidate();
        }

        private async void picCamera_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_isDragging || _dragSpotId == null) { picCamera.Capture = false; return; }

            // ★ await 전 로컬 복사로 널러블 레이스 방지
            int id = _dragSpotId.Value;

            // ★ 마지막 위치도 클램프해서 가장자리 스냅
            Point clamped = ClampToClient(_dragCurrentView);
            Point sensor = Ax8CIPProp.ViewToSensor(clamped, picCamera.Width, picCamera.Height);

            Label lbl = this.Controls.Find($"lblSpot{id}", true).FirstOrDefault() as Label;

            try
            {
                await _ax8Cip.MoveSpotAndCacheAsync(id, sensor.X, sensor.Y);
                var basics = _ax8Cip.GetSpotFromCache(id);

                if (lbl != null)
                {
                    Point viewPt = Ax8CIPProp.SensorToView(new Point(basics.X, basics.Y), picCamera.Width, picCamera.Height);
                    lbl.Text = $"Spot {basics.Id} : Active={basics.Active}, " +
                               $"X={clamped.X}({viewPt.X}), Y={clamped.Y}({viewPt.Y})";
                }
            }
            catch (Exception ex)
            {
                if (lbl != null) lbl.Text = "ERROR";
                Console.WriteLine("Commit failed: " + ex.Message);
            }
            finally
            {
                picCamera.Capture = false; // ★ 캡처 해제
                _isDragging = false;
                _dragSpotId = null;
                picCamera.Invalidate();
            }
        }

        private void picCamera_MouseLeave(object sender, EventArgs e)
        {
            if (!picCamera.Capture && _isDragging)
            {
                _isDragging = false;
                _dragSpotId = null;
                picCamera.Invalidate();
                picCamera.Cursor = Cursors.Default;
            }
        }

        private void chkSpot1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
