namespace FLiRCap
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnFindFLiRAx8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.btnGetTempSpot = new System.Windows.Forms.Button();
            this.timGetImage = new System.Windows.Forms.Timer(this.components);
            this.chkAutoGetImage = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.timReLogin = new System.Windows.Forms.Timer(this.components);
            this.radFusion = new System.Windows.Forms.RadioButton();
            this.radVisual = new System.Windows.Forms.RadioButton();
            this.radIR = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSnap = new System.Windows.Forms.Button();
            this.chkTorch = new System.Windows.Forms.CheckBox();
            this.timTemp = new System.Windows.Forms.Timer(this.components);
            this.chkAutoGetTemp = new System.Windows.Forms.CheckBox();
            this.lblLogInStatus = new System.Windows.Forms.Label();
            this.lblReLoginStatus = new System.Windows.Forms.Label();
            this.lblGetImageSec = new System.Windows.Forms.Label();
            this.chkSpot1 = new System.Windows.Forms.CheckBox();
            this.chkSpot6 = new System.Windows.Forms.CheckBox();
            this.chkSpot5 = new System.Windows.Forms.CheckBox();
            this.chkSpot4 = new System.Windows.Forms.CheckBox();
            this.chkSpot3 = new System.Windows.Forms.CheckBox();
            this.chkSpot2 = new System.Windows.Forms.CheckBox();
            this.lblSpot1 = new System.Windows.Forms.Label();
            this.lblMoveSpotTime = new System.Windows.Forms.Label();
            this.txtGetID = new System.Windows.Forms.TextBox();
            this.txtGetY = new System.Windows.Forms.TextBox();
            this.txtGetX = new System.Windows.Forms.TextBox();
            this.lblSpotId = new System.Windows.Forms.Label();
            this.lblSpotY = new System.Windows.Forms.Label();
            this.lblSpotX = new System.Windows.Forms.Label();
            this.btnMoveSpot = new System.Windows.Forms.Button();
            this.lblConnectCIP = new System.Windows.Forms.Label();
            this.lblSpotTemp1 = new System.Windows.Forms.Label();
            this.lblGetTempTime = new System.Windows.Forms.Label();
            this.btnMoveSpotAll = new System.Windows.Forms.Button();
            this.btnUpdateSpot = new System.Windows.Forms.Button();
            this.lblGetStateTime = new System.Windows.Forms.Label();
            this.lblSpot6 = new System.Windows.Forms.Label();
            this.lblSpot5 = new System.Windows.Forms.Label();
            this.lblSpot4 = new System.Windows.Forms.Label();
            this.lblSpot3 = new System.Windows.Forms.Label();
            this.lblSpot2 = new System.Windows.Forms.Label();
            this.lblSpotTemp5 = new System.Windows.Forms.Label();
            this.lblSpotTemp4 = new System.Windows.Forms.Label();
            this.lblSpotTemp3 = new System.Windows.Forms.Label();
            this.lblSpotTemp2 = new System.Windows.Forms.Label();
            this.lblSpotTemp6 = new System.Windows.Forms.Label();
            this.chkFreeze = new System.Windows.Forms.CheckBox();
            this.lblSnapStatus = new System.Windows.Forms.Label();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.btnSaveView = new System.Windows.Forms.Button();
            this.lblSaveView = new System.Windows.Forms.Label();
            this.txtSpot1X = new System.Windows.Forms.TextBox();
            this.txtSpot1Y = new System.Windows.Forms.TextBox();
            this.txtSpot6Y = new System.Windows.Forms.TextBox();
            this.txtSpot6X = new System.Windows.Forms.TextBox();
            this.txtSpot5Y = new System.Windows.Forms.TextBox();
            this.txtSpot5X = new System.Windows.Forms.TextBox();
            this.txtSpot4Y = new System.Windows.Forms.TextBox();
            this.txtSpot4X = new System.Windows.Forms.TextBox();
            this.txtSpot3Y = new System.Windows.Forms.TextBox();
            this.txtSpot3X = new System.Windows.Forms.TextBox();
            this.txtSpot2Y = new System.Windows.Forms.TextBox();
            this.txtSpot2X = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGetTempCamera = new System.Windows.Forms.Button();
            this.lblCameraTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindFLiRAx8
            // 
            this.btnFindFLiRAx8.Location = new System.Drawing.Point(23, 24);
            this.btnFindFLiRAx8.Name = "btnFindFLiRAx8";
            this.btnFindFLiRAx8.Size = new System.Drawing.Size(117, 47);
            this.btnFindFLiRAx8.TabIndex = 0;
            this.btnFindFLiRAx8.Text = "Find FLiR Ax8";
            this.btnFindFLiRAx8.UseVisualStyleBackColor = true;
            this.btnFindFLiRAx8.Click += new System.EventHandler(this.btnFindFLiRAx8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(342, 81);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "192.168.0.173";
            // 
            // btnGetImage
            // 
            this.btnGetImage.Location = new System.Drawing.Point(23, 145);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(117, 47);
            this.btnGetImage.TabIndex = 2;
            this.btnGetImage.Text = "Get Image";
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // picCamera
            // 
            this.picCamera.BackColor = System.Drawing.Color.White;
            this.picCamera.Location = new System.Drawing.Point(155, 145);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(640, 480);
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCamera.TabIndex = 3;
            this.picCamera.TabStop = false;
            this.picCamera.Paint += new System.Windows.Forms.PaintEventHandler(this.picCamera_Paint);
            this.picCamera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCamera_MouseDown);
            this.picCamera.MouseLeave += new System.EventHandler(this.picCamera_MouseLeave);
            this.picCamera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCamera_MouseMove);
            this.picCamera.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCamera_MouseUp);
            // 
            // btnGetTempSpot
            // 
            this.btnGetTempSpot.Location = new System.Drawing.Point(812, 145);
            this.btnGetTempSpot.Name = "btnGetTempSpot";
            this.btnGetTempSpot.Size = new System.Drawing.Size(117, 47);
            this.btnGetTempSpot.TabIndex = 4;
            this.btnGetTempSpot.Text = "Get Temp(Spot)";
            this.btnGetTempSpot.UseVisualStyleBackColor = true;
            this.btnGetTempSpot.Click += new System.EventHandler(this.btnGetTempSpot_Click);
            // 
            // timGetImage
            // 
            this.timGetImage.Enabled = true;
            this.timGetImage.Interval = 33;
            this.timGetImage.Tick += new System.EventHandler(this.timGetImage_Tick);
            // 
            // chkAutoGetImage
            // 
            this.chkAutoGetImage.AutoSize = true;
            this.chkAutoGetImage.Location = new System.Drawing.Point(23, 198);
            this.chkAutoGetImage.Name = "chkAutoGetImage";
            this.chkAutoGetImage.Size = new System.Drawing.Size(111, 16);
            this.chkAutoGetImage.TabIndex = 5;
            this.chkAutoGetImage.Text = "Auto Get Image";
            this.chkAutoGetImage.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(17, 425);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 47);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // timReLogin
            // 
            this.timReLogin.Enabled = true;
            this.timReLogin.Interval = 5000;
            this.timReLogin.Tick += new System.EventHandler(this.timReLogin_Tick);
            // 
            // radFusion
            // 
            this.radFusion.AutoSize = true;
            this.radFusion.Location = new System.Drawing.Point(20, 26);
            this.radFusion.Name = "radFusion";
            this.radFusion.Size = new System.Drawing.Size(67, 16);
            this.radFusion.TabIndex = 10;
            this.radFusion.Text = "FUSION";
            this.radFusion.UseVisualStyleBackColor = true;
            this.radFusion.CheckedChanged += new System.EventHandler(this.radFusion_CheckedChanged);
            // 
            // radVisual
            // 
            this.radVisual.AutoSize = true;
            this.radVisual.Checked = true;
            this.radVisual.Location = new System.Drawing.Point(19, 48);
            this.radVisual.Name = "radVisual";
            this.radVisual.Size = new System.Drawing.Size(65, 16);
            this.radVisual.TabIndex = 11;
            this.radVisual.TabStop = true;
            this.radVisual.Text = "VISUAL";
            this.radVisual.UseVisualStyleBackColor = true;
            this.radVisual.CheckedChanged += new System.EventHandler(this.radVisual_CheckedChanged);
            // 
            // radIR
            // 
            this.radIR.AutoSize = true;
            this.radIR.Location = new System.Drawing.Point(19, 70);
            this.radIR.Name = "radIR";
            this.radIR.Size = new System.Drawing.Size(34, 16);
            this.radIR.TabIndex = 12;
            this.radIR.Text = "IR";
            this.radIR.UseVisualStyleBackColor = true;
            this.radIR.CheckedChanged += new System.EventHandler(this.radIR_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radFusion);
            this.panel1.Controls.Add(this.radIR);
            this.panel1.Controls.Add(this.radVisual);
            this.panel1.Location = new System.Drawing.Point(23, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 113);
            this.panel1.TabIndex = 13;
            // 
            // btnSnap
            // 
            this.btnSnap.Location = new System.Drawing.Point(812, 247);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(117, 47);
            this.btnSnap.TabIndex = 14;
            this.btnSnap.Text = "SnapShot";
            this.btnSnap.UseVisualStyleBackColor = true;
            this.btnSnap.Click += new System.EventHandler(this.btnSnap_Click);
            // 
            // chkTorch
            // 
            this.chkTorch.AutoSize = true;
            this.chkTorch.Location = new System.Drawing.Point(24, 275);
            this.chkTorch.Name = "chkTorch";
            this.chkTorch.Size = new System.Drawing.Size(57, 16);
            this.chkTorch.TabIndex = 15;
            this.chkTorch.Text = "Torch";
            this.chkTorch.UseVisualStyleBackColor = true;
            this.chkTorch.CheckedChanged += new System.EventHandler(this.chkTorch_CheckedChanged);
            // 
            // timTemp
            // 
            this.timTemp.Enabled = true;
            this.timTemp.Interval = 111;
            this.timTemp.Tick += new System.EventHandler(this.timTemp_Tick);
            // 
            // chkAutoGetTemp
            // 
            this.chkAutoGetTemp.AutoSize = true;
            this.chkAutoGetTemp.Location = new System.Drawing.Point(818, 198);
            this.chkAutoGetTemp.Name = "chkAutoGetTemp";
            this.chkAutoGetTemp.Size = new System.Drawing.Size(109, 16);
            this.chkAutoGetTemp.TabIndex = 18;
            this.chkAutoGetTemp.Text = "Auto Get Temp";
            this.chkAutoGetTemp.UseVisualStyleBackColor = true;
            // 
            // lblLogInStatus
            // 
            this.lblLogInStatus.AutoSize = true;
            this.lblLogInStatus.Location = new System.Drawing.Point(21, 475);
            this.lblLogInStatus.Name = "lblLogInStatus";
            this.lblLogInStatus.Size = new System.Drawing.Size(81, 12);
            this.lblLogInStatus.TabIndex = 19;
            this.lblLogInStatus.Text = "로그아웃 상태";
            // 
            // lblReLoginStatus
            // 
            this.lblReLoginStatus.AutoSize = true;
            this.lblReLoginStatus.Location = new System.Drawing.Point(21, 631);
            this.lblReLoginStatus.Name = "lblReLoginStatus";
            this.lblReLoginStatus.Size = new System.Drawing.Size(29, 12);
            this.lblReLoginStatus.TabIndex = 20;
            this.lblReLoginStatus.Text = "****";
            // 
            // lblGetImageSec
            // 
            this.lblGetImageSec.AutoSize = true;
            this.lblGetImageSec.Location = new System.Drawing.Point(22, 249);
            this.lblGetImageSec.Name = "lblGetImageSec";
            this.lblGetImageSec.Size = new System.Drawing.Size(29, 12);
            this.lblGetImageSec.TabIndex = 21;
            this.lblGetImageSec.Text = "****";
            // 
            // chkSpot1
            // 
            this.chkSpot1.AutoSize = true;
            this.chkSpot1.Location = new System.Drawing.Point(4, 22);
            this.chkSpot1.Name = "chkSpot1";
            this.chkSpot1.Size = new System.Drawing.Size(55, 16);
            this.chkSpot1.TabIndex = 22;
            this.chkSpot1.Tag = "1";
            this.chkSpot1.Text = "Spot1";
            this.chkSpot1.UseVisualStyleBackColor = true;
            this.chkSpot1.CheckedChanged += new System.EventHandler(this.chkSpot1_CheckedChanged);
            this.chkSpot1.CheckStateChanged += new System.EventHandler(this.chkSpot_CheckedChanged);
            // 
            // chkSpot6
            // 
            this.chkSpot6.AutoSize = true;
            this.chkSpot6.Location = new System.Drawing.Point(4, 132);
            this.chkSpot6.Name = "chkSpot6";
            this.chkSpot6.Size = new System.Drawing.Size(55, 16);
            this.chkSpot6.TabIndex = 23;
            this.chkSpot6.Tag = "6";
            this.chkSpot6.Text = "Spot6";
            this.chkSpot6.UseVisualStyleBackColor = true;
            this.chkSpot6.CheckStateChanged += new System.EventHandler(this.chkSpot_CheckedChanged);
            // 
            // chkSpot5
            // 
            this.chkSpot5.AutoSize = true;
            this.chkSpot5.Location = new System.Drawing.Point(4, 110);
            this.chkSpot5.Name = "chkSpot5";
            this.chkSpot5.Size = new System.Drawing.Size(55, 16);
            this.chkSpot5.TabIndex = 24;
            this.chkSpot5.Tag = "5";
            this.chkSpot5.Text = "Spot5";
            this.chkSpot5.UseVisualStyleBackColor = true;
            this.chkSpot5.CheckStateChanged += new System.EventHandler(this.chkSpot_CheckedChanged);
            // 
            // chkSpot4
            // 
            this.chkSpot4.AutoSize = true;
            this.chkSpot4.Location = new System.Drawing.Point(4, 88);
            this.chkSpot4.Name = "chkSpot4";
            this.chkSpot4.Size = new System.Drawing.Size(55, 16);
            this.chkSpot4.TabIndex = 25;
            this.chkSpot4.Tag = "4";
            this.chkSpot4.Text = "Spot4";
            this.chkSpot4.UseVisualStyleBackColor = true;
            this.chkSpot4.CheckStateChanged += new System.EventHandler(this.chkSpot_CheckedChanged);
            // 
            // chkSpot3
            // 
            this.chkSpot3.AutoSize = true;
            this.chkSpot3.Location = new System.Drawing.Point(4, 66);
            this.chkSpot3.Name = "chkSpot3";
            this.chkSpot3.Size = new System.Drawing.Size(55, 16);
            this.chkSpot3.TabIndex = 26;
            this.chkSpot3.Tag = "3";
            this.chkSpot3.Text = "Spot3";
            this.chkSpot3.UseVisualStyleBackColor = true;
            this.chkSpot3.CheckStateChanged += new System.EventHandler(this.chkSpot_CheckedChanged);
            // 
            // chkSpot2
            // 
            this.chkSpot2.AutoSize = true;
            this.chkSpot2.Location = new System.Drawing.Point(4, 44);
            this.chkSpot2.Name = "chkSpot2";
            this.chkSpot2.Size = new System.Drawing.Size(55, 16);
            this.chkSpot2.TabIndex = 27;
            this.chkSpot2.Tag = "2";
            this.chkSpot2.Text = "Spot2";
            this.chkSpot2.UseVisualStyleBackColor = true;
            this.chkSpot2.CheckStateChanged += new System.EventHandler(this.chkSpot_CheckedChanged);
            // 
            // lblSpot1
            // 
            this.lblSpot1.AutoSize = true;
            this.lblSpot1.Location = new System.Drawing.Point(80, 23);
            this.lblSpot1.Name = "lblSpot1";
            this.lblSpot1.Size = new System.Drawing.Size(48, 12);
            this.lblSpot1.TabIndex = 29;
            this.lblSpot1.Text = "Spot1 : ";
            // 
            // lblMoveSpotTime
            // 
            this.lblMoveSpotTime.AutoSize = true;
            this.lblMoveSpotTime.Location = new System.Drawing.Point(1040, 288);
            this.lblMoveSpotTime.Name = "lblMoveSpotTime";
            this.lblMoveSpotTime.Size = new System.Drawing.Size(122, 12);
            this.lblMoveSpotTime.TabIndex = 35;
            this.lblMoveSpotTime.Text = "Spot 위치 조정 시간 :";
            // 
            // txtGetID
            // 
            this.txtGetID.Location = new System.Drawing.Point(1011, 318);
            this.txtGetID.Name = "txtGetID";
            this.txtGetID.Size = new System.Drawing.Size(81, 21);
            this.txtGetID.TabIndex = 37;
            // 
            // txtGetY
            // 
            this.txtGetY.Location = new System.Drawing.Point(1221, 318);
            this.txtGetY.Name = "txtGetY";
            this.txtGetY.Size = new System.Drawing.Size(81, 21);
            this.txtGetY.TabIndex = 38;
            // 
            // txtGetX
            // 
            this.txtGetX.Location = new System.Drawing.Point(1118, 318);
            this.txtGetX.Name = "txtGetX";
            this.txtGetX.Size = new System.Drawing.Size(81, 21);
            this.txtGetX.TabIndex = 39;
            // 
            // lblSpotId
            // 
            this.lblSpotId.AutoSize = true;
            this.lblSpotId.Location = new System.Drawing.Point(1045, 351);
            this.lblSpotId.Name = "lblSpotId";
            this.lblSpotId.Size = new System.Drawing.Size(16, 12);
            this.lblSpotId.TabIndex = 40;
            this.lblSpotId.Text = "ID";
            // 
            // lblSpotY
            // 
            this.lblSpotY.AutoSize = true;
            this.lblSpotY.Location = new System.Drawing.Point(1257, 351);
            this.lblSpotY.Name = "lblSpotY";
            this.lblSpotY.Size = new System.Drawing.Size(13, 12);
            this.lblSpotY.TabIndex = 41;
            this.lblSpotY.Text = "Y";
            // 
            // lblSpotX
            // 
            this.lblSpotX.AutoSize = true;
            this.lblSpotX.Location = new System.Drawing.Point(1154, 351);
            this.lblSpotX.Name = "lblSpotX";
            this.lblSpotX.Size = new System.Drawing.Size(13, 12);
            this.lblSpotX.TabIndex = 42;
            this.lblSpotX.Text = "X";
            // 
            // btnMoveSpot
            // 
            this.btnMoveSpot.Location = new System.Drawing.Point(1106, 366);
            this.btnMoveSpot.Name = "btnMoveSpot";
            this.btnMoveSpot.Size = new System.Drawing.Size(105, 42);
            this.btnMoveSpot.TabIndex = 43;
            this.btnMoveSpot.Text = "Move Spot";
            this.btnMoveSpot.UseVisualStyleBackColor = true;
            this.btnMoveSpot.Click += new System.EventHandler(this.btnMoveSpot_Click);
            // 
            // lblConnectCIP
            // 
            this.lblConnectCIP.AutoSize = true;
            this.lblConnectCIP.Location = new System.Drawing.Point(22, 580);
            this.lblConnectCIP.Name = "lblConnectCIP";
            this.lblConnectCIP.Size = new System.Drawing.Size(29, 12);
            this.lblConnectCIP.TabIndex = 44;
            this.lblConnectCIP.Text = "****";
            // 
            // lblSpotTemp1
            // 
            this.lblSpotTemp1.AutoSize = true;
            this.lblSpotTemp1.Location = new System.Drawing.Point(360, 26);
            this.lblSpotTemp1.Name = "lblSpotTemp1";
            this.lblSpotTemp1.Size = new System.Drawing.Size(72, 12);
            this.lblSpotTemp1.TabIndex = 45;
            this.lblSpotTemp1.Text = "Spot1 온도 :";
            // 
            // lblGetTempTime
            // 
            this.lblGetTempTime.AutoSize = true;
            this.lblGetTempTime.Location = new System.Drawing.Point(360, 6);
            this.lblGetTempTime.Name = "lblGetTempTime";
            this.lblGetTempTime.Size = new System.Drawing.Size(93, 12);
            this.lblGetTempTime.TabIndex = 46;
            this.lblGetTempTime.Text = "온도 측정 시간 :";
            // 
            // btnMoveSpotAll
            // 
            this.btnMoveSpotAll.Location = new System.Drawing.Point(1217, 368);
            this.btnMoveSpotAll.Name = "btnMoveSpotAll";
            this.btnMoveSpotAll.Size = new System.Drawing.Size(105, 42);
            this.btnMoveSpotAll.TabIndex = 47;
            this.btnMoveSpotAll.Text = "Move Spot All";
            this.btnMoveSpotAll.UseVisualStyleBackColor = true;
            this.btnMoveSpotAll.Click += new System.EventHandler(this.btnMoveSpotAll_Click);
            // 
            // btnUpdateSpot
            // 
            this.btnUpdateSpot.Location = new System.Drawing.Point(818, 601);
            this.btnUpdateSpot.Name = "btnUpdateSpot";
            this.btnUpdateSpot.Size = new System.Drawing.Size(105, 42);
            this.btnUpdateSpot.TabIndex = 48;
            this.btnUpdateSpot.Text = "Update Spot";
            this.btnUpdateSpot.UseVisualStyleBackColor = true;
            this.btnUpdateSpot.Click += new System.EventHandler(this.btnUpdateSpot_Click);
            // 
            // lblGetStateTime
            // 
            this.lblGetStateTime.AutoSize = true;
            this.lblGetStateTime.Location = new System.Drawing.Point(943, 631);
            this.lblGetStateTime.Name = "lblGetStateTime";
            this.lblGetStateTime.Size = new System.Drawing.Size(122, 12);
            this.lblGetStateTime.TabIndex = 49;
            this.lblGetStateTime.Text = "Spot 상태 획득 시간 :";
            // 
            // lblSpot6
            // 
            this.lblSpot6.AutoSize = true;
            this.lblSpot6.Location = new System.Drawing.Point(80, 133);
            this.lblSpot6.Name = "lblSpot6";
            this.lblSpot6.Size = new System.Drawing.Size(48, 12);
            this.lblSpot6.TabIndex = 50;
            this.lblSpot6.Text = "Spot6 : ";
            // 
            // lblSpot5
            // 
            this.lblSpot5.AutoSize = true;
            this.lblSpot5.Location = new System.Drawing.Point(80, 111);
            this.lblSpot5.Name = "lblSpot5";
            this.lblSpot5.Size = new System.Drawing.Size(48, 12);
            this.lblSpot5.TabIndex = 51;
            this.lblSpot5.Text = "Spot5 : ";
            // 
            // lblSpot4
            // 
            this.lblSpot4.AutoSize = true;
            this.lblSpot4.Location = new System.Drawing.Point(80, 89);
            this.lblSpot4.Name = "lblSpot4";
            this.lblSpot4.Size = new System.Drawing.Size(48, 12);
            this.lblSpot4.TabIndex = 52;
            this.lblSpot4.Text = "Spot4 : ";
            // 
            // lblSpot3
            // 
            this.lblSpot3.AutoSize = true;
            this.lblSpot3.Location = new System.Drawing.Point(80, 67);
            this.lblSpot3.Name = "lblSpot3";
            this.lblSpot3.Size = new System.Drawing.Size(48, 12);
            this.lblSpot3.TabIndex = 53;
            this.lblSpot3.Text = "Spot3 : ";
            // 
            // lblSpot2
            // 
            this.lblSpot2.AutoSize = true;
            this.lblSpot2.Location = new System.Drawing.Point(80, 44);
            this.lblSpot2.Name = "lblSpot2";
            this.lblSpot2.Size = new System.Drawing.Size(48, 12);
            this.lblSpot2.TabIndex = 54;
            this.lblSpot2.Text = "Spot2 : ";
            // 
            // lblSpotTemp5
            // 
            this.lblSpotTemp5.AutoSize = true;
            this.lblSpotTemp5.Location = new System.Drawing.Point(360, 116);
            this.lblSpotTemp5.Name = "lblSpotTemp5";
            this.lblSpotTemp5.Size = new System.Drawing.Size(72, 12);
            this.lblSpotTemp5.TabIndex = 55;
            this.lblSpotTemp5.Text = "Spot5 온도 :";
            // 
            // lblSpotTemp4
            // 
            this.lblSpotTemp4.AutoSize = true;
            this.lblSpotTemp4.Location = new System.Drawing.Point(360, 92);
            this.lblSpotTemp4.Name = "lblSpotTemp4";
            this.lblSpotTemp4.Size = new System.Drawing.Size(72, 12);
            this.lblSpotTemp4.TabIndex = 56;
            this.lblSpotTemp4.Text = "Spot4 온도 :";
            // 
            // lblSpotTemp3
            // 
            this.lblSpotTemp3.AutoSize = true;
            this.lblSpotTemp3.Location = new System.Drawing.Point(360, 70);
            this.lblSpotTemp3.Name = "lblSpotTemp3";
            this.lblSpotTemp3.Size = new System.Drawing.Size(72, 12);
            this.lblSpotTemp3.TabIndex = 57;
            this.lblSpotTemp3.Text = "Spot3 온도 :";
            // 
            // lblSpotTemp2
            // 
            this.lblSpotTemp2.AutoSize = true;
            this.lblSpotTemp2.Location = new System.Drawing.Point(360, 48);
            this.lblSpotTemp2.Name = "lblSpotTemp2";
            this.lblSpotTemp2.Size = new System.Drawing.Size(72, 12);
            this.lblSpotTemp2.TabIndex = 58;
            this.lblSpotTemp2.Text = "Spot2 온도 :";
            // 
            // lblSpotTemp6
            // 
            this.lblSpotTemp6.AutoSize = true;
            this.lblSpotTemp6.Location = new System.Drawing.Point(360, 136);
            this.lblSpotTemp6.Name = "lblSpotTemp6";
            this.lblSpotTemp6.Size = new System.Drawing.Size(72, 12);
            this.lblSpotTemp6.TabIndex = 59;
            this.lblSpotTemp6.Text = "Spot6 온도 :";
            // 
            // chkFreeze
            // 
            this.chkFreeze.AutoSize = true;
            this.chkFreeze.Location = new System.Drawing.Point(23, 220);
            this.chkFreeze.Name = "chkFreeze";
            this.chkFreeze.Size = new System.Drawing.Size(63, 16);
            this.chkFreeze.TabIndex = 60;
            this.chkFreeze.Text = "Freeze";
            this.chkFreeze.UseVisualStyleBackColor = true;
            this.chkFreeze.CheckedChanged += new System.EventHandler(this.chkFreeze_CheckedChanged);
            // 
            // lblSnapStatus
            // 
            this.lblSnapStatus.AutoSize = true;
            this.lblSnapStatus.Location = new System.Drawing.Point(816, 297);
            this.lblSnapStatus.Name = "lblSnapStatus";
            this.lblSnapStatus.Size = new System.Drawing.Size(29, 12);
            this.lblSnapStatus.TabIndex = 61;
            this.lblSnapStatus.Text = "****";
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Location = new System.Drawing.Point(740, 639);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(63, 16);
            this.chkHidden.TabIndex = 62;
            this.chkHidden.Tag = "1";
            this.chkHidden.Text = "Hidden";
            this.chkHidden.UseVisualStyleBackColor = true;
            this.chkHidden.CheckedChanged += new System.EventHandler(this.chkHidden_CheckedChanged);
            // 
            // btnSaveView
            // 
            this.btnSaveView.Location = new System.Drawing.Point(812, 336);
            this.btnSaveView.Name = "btnSaveView";
            this.btnSaveView.Size = new System.Drawing.Size(117, 47);
            this.btnSaveView.TabIndex = 63;
            this.btnSaveView.Text = "SaveView";
            this.btnSaveView.UseVisualStyleBackColor = true;
            this.btnSaveView.Click += new System.EventHandler(this.btnSaveView_Click);
            // 
            // lblSaveView
            // 
            this.lblSaveView.AutoSize = true;
            this.lblSaveView.Location = new System.Drawing.Point(816, 386);
            this.lblSaveView.Name = "lblSaveView";
            this.lblSaveView.Size = new System.Drawing.Size(29, 12);
            this.lblSaveView.TabIndex = 64;
            this.lblSaveView.Text = "****";
            // 
            // txtSpot1X
            // 
            this.txtSpot1X.Location = new System.Drawing.Point(13, 7);
            this.txtSpot1X.Name = "txtSpot1X";
            this.txtSpot1X.Size = new System.Drawing.Size(81, 21);
            this.txtSpot1X.TabIndex = 65;
            // 
            // txtSpot1Y
            // 
            this.txtSpot1Y.Location = new System.Drawing.Point(108, 7);
            this.txtSpot1Y.Name = "txtSpot1Y";
            this.txtSpot1Y.Size = new System.Drawing.Size(81, 21);
            this.txtSpot1Y.TabIndex = 66;
            // 
            // txtSpot6Y
            // 
            this.txtSpot6Y.Location = new System.Drawing.Point(108, 197);
            this.txtSpot6Y.Name = "txtSpot6Y";
            this.txtSpot6Y.Size = new System.Drawing.Size(81, 21);
            this.txtSpot6Y.TabIndex = 68;
            // 
            // txtSpot6X
            // 
            this.txtSpot6X.Location = new System.Drawing.Point(13, 197);
            this.txtSpot6X.Name = "txtSpot6X";
            this.txtSpot6X.Size = new System.Drawing.Size(81, 21);
            this.txtSpot6X.TabIndex = 67;
            // 
            // txtSpot5Y
            // 
            this.txtSpot5Y.Location = new System.Drawing.Point(108, 155);
            this.txtSpot5Y.Name = "txtSpot5Y";
            this.txtSpot5Y.Size = new System.Drawing.Size(81, 21);
            this.txtSpot5Y.TabIndex = 70;
            // 
            // txtSpot5X
            // 
            this.txtSpot5X.Location = new System.Drawing.Point(13, 155);
            this.txtSpot5X.Name = "txtSpot5X";
            this.txtSpot5X.Size = new System.Drawing.Size(81, 21);
            this.txtSpot5X.TabIndex = 69;
            // 
            // txtSpot4Y
            // 
            this.txtSpot4Y.Location = new System.Drawing.Point(108, 116);
            this.txtSpot4Y.Name = "txtSpot4Y";
            this.txtSpot4Y.Size = new System.Drawing.Size(81, 21);
            this.txtSpot4Y.TabIndex = 72;
            // 
            // txtSpot4X
            // 
            this.txtSpot4X.Location = new System.Drawing.Point(13, 116);
            this.txtSpot4X.Name = "txtSpot4X";
            this.txtSpot4X.Size = new System.Drawing.Size(81, 21);
            this.txtSpot4X.TabIndex = 71;
            // 
            // txtSpot3Y
            // 
            this.txtSpot3Y.Location = new System.Drawing.Point(108, 77);
            this.txtSpot3Y.Name = "txtSpot3Y";
            this.txtSpot3Y.Size = new System.Drawing.Size(81, 21);
            this.txtSpot3Y.TabIndex = 74;
            // 
            // txtSpot3X
            // 
            this.txtSpot3X.Location = new System.Drawing.Point(13, 77);
            this.txtSpot3X.Name = "txtSpot3X";
            this.txtSpot3X.Size = new System.Drawing.Size(81, 21);
            this.txtSpot3X.TabIndex = 73;
            // 
            // txtSpot2Y
            // 
            this.txtSpot2Y.Location = new System.Drawing.Point(108, 41);
            this.txtSpot2Y.Name = "txtSpot2Y";
            this.txtSpot2Y.Size = new System.Drawing.Size(81, 21);
            this.txtSpot2Y.TabIndex = 76;
            // 
            // txtSpot2X
            // 
            this.txtSpot2X.Location = new System.Drawing.Point(13, 41);
            this.txtSpot2X.Name = "txtSpot2X";
            this.txtSpot2X.Size = new System.Drawing.Size(81, 21);
            this.txtSpot2X.TabIndex = 75;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSpot2Y);
            this.panel2.Controls.Add(this.txtSpot2X);
            this.panel2.Controls.Add(this.txtSpot3Y);
            this.panel2.Controls.Add(this.txtSpot3X);
            this.panel2.Controls.Add(this.txtSpot4Y);
            this.panel2.Controls.Add(this.txtSpot4X);
            this.panel2.Controls.Add(this.txtSpot5Y);
            this.panel2.Controls.Add(this.txtSpot5X);
            this.panel2.Controls.Add(this.txtSpot6Y);
            this.panel2.Controls.Add(this.txtSpot6X);
            this.panel2.Controls.Add(this.txtSpot1Y);
            this.panel2.Controls.Add(this.txtSpot1X);
            this.panel2.Location = new System.Drawing.Point(1106, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 232);
            this.panel2.TabIndex = 77;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblSpotTemp6);
            this.panel3.Controls.Add(this.lblSpotTemp2);
            this.panel3.Controls.Add(this.lblSpotTemp3);
            this.panel3.Controls.Add(this.lblSpotTemp4);
            this.panel3.Controls.Add(this.lblSpotTemp5);
            this.panel3.Controls.Add(this.lblSpot2);
            this.panel3.Controls.Add(this.lblSpot3);
            this.panel3.Controls.Add(this.lblSpot4);
            this.panel3.Controls.Add(this.lblSpot5);
            this.panel3.Controls.Add(this.lblSpot6);
            this.panel3.Controls.Add(this.lblGetTempTime);
            this.panel3.Controls.Add(this.lblSpotTemp1);
            this.panel3.Controls.Add(this.lblSpot1);
            this.panel3.Controls.Add(this.chkSpot2);
            this.panel3.Controls.Add(this.chkSpot3);
            this.panel3.Controls.Add(this.chkSpot4);
            this.panel3.Controls.Add(this.chkSpot5);
            this.panel3.Controls.Add(this.chkSpot6);
            this.panel3.Controls.Add(this.chkSpot1);
            this.panel3.Location = new System.Drawing.Point(816, 419);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 160);
            this.panel3.TabIndex = 78;
            // 
            // btnGetTempCamera
            // 
            this.btnGetTempCamera.Location = new System.Drawing.Point(936, 145);
            this.btnGetTempCamera.Name = "btnGetTempCamera";
            this.btnGetTempCamera.Size = new System.Drawing.Size(129, 47);
            this.btnGetTempCamera.TabIndex = 79;
            this.btnGetTempCamera.Text = "Get Temp(Camera)";
            this.btnGetTempCamera.UseVisualStyleBackColor = true;
            this.btnGetTempCamera.Click += new System.EventHandler(this.btnGetTempCamera_Click);
            // 
            // lblCameraTemp
            // 
            this.lblCameraTemp.AutoSize = true;
            this.lblCameraTemp.Location = new System.Drawing.Point(943, 199);
            this.lblCameraTemp.Name = "lblCameraTemp";
            this.lblCameraTemp.Size = new System.Drawing.Size(77, 12);
            this.lblCameraTemp.TabIndex = 60;
            this.lblCameraTemp.Text = "카메라 온도 :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 667);
            this.Controls.Add(this.lblCameraTemp);
            this.Controls.Add(this.btnGetTempCamera);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSaveView);
            this.Controls.Add(this.btnSaveView);
            this.Controls.Add(this.chkHidden);
            this.Controls.Add(this.lblSnapStatus);
            this.Controls.Add(this.chkFreeze);
            this.Controls.Add(this.lblGetStateTime);
            this.Controls.Add(this.btnUpdateSpot);
            this.Controls.Add(this.btnMoveSpotAll);
            this.Controls.Add(this.lblConnectCIP);
            this.Controls.Add(this.btnMoveSpot);
            this.Controls.Add(this.lblSpotX);
            this.Controls.Add(this.lblSpotY);
            this.Controls.Add(this.lblSpotId);
            this.Controls.Add(this.txtGetX);
            this.Controls.Add(this.txtGetY);
            this.Controls.Add(this.txtGetID);
            this.Controls.Add(this.lblMoveSpotTime);
            this.Controls.Add(this.lblGetImageSec);
            this.Controls.Add(this.lblReLoginStatus);
            this.Controls.Add(this.lblLogInStatus);
            this.Controls.Add(this.chkAutoGetTemp);
            this.Controls.Add(this.chkTorch);
            this.Controls.Add(this.btnSnap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkAutoGetImage);
            this.Controls.Add(this.btnGetTempSpot);
            this.Controls.Add(this.picCamera);
            this.Controls.Add(this.btnGetImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFindFLiRAx8);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindFLiRAx8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGetImage;
        public System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Button btnGetTempSpot;
        private System.Windows.Forms.Timer timGetImage;
        private System.Windows.Forms.CheckBox chkAutoGetImage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer timReLogin;
        private System.Windows.Forms.RadioButton radFusion;
        private System.Windows.Forms.RadioButton radVisual;
        private System.Windows.Forms.RadioButton radIR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSnap;
        private System.Windows.Forms.CheckBox chkTorch;
        private System.Windows.Forms.Timer timTemp;
        private System.Windows.Forms.CheckBox chkAutoGetTemp;
        private System.Windows.Forms.Label lblLogInStatus;
        private System.Windows.Forms.Label lblReLoginStatus;
        private System.Windows.Forms.Label lblGetImageSec;
        private System.Windows.Forms.CheckBox chkSpot1;
        private System.Windows.Forms.CheckBox chkSpot6;
        private System.Windows.Forms.CheckBox chkSpot5;
        private System.Windows.Forms.CheckBox chkSpot4;
        private System.Windows.Forms.CheckBox chkSpot3;
        private System.Windows.Forms.CheckBox chkSpot2;
        private System.Windows.Forms.Label lblSpot1;
        private System.Windows.Forms.Label lblMoveSpotTime;
        private System.Windows.Forms.TextBox txtGetID;
        private System.Windows.Forms.TextBox txtGetY;
        private System.Windows.Forms.TextBox txtGetX;
        private System.Windows.Forms.Label lblSpotId;
        private System.Windows.Forms.Label lblSpotY;
        private System.Windows.Forms.Label lblSpotX;
        private System.Windows.Forms.Button btnMoveSpot;
        private System.Windows.Forms.Label lblConnectCIP;
        private System.Windows.Forms.Label lblSpotTemp1;
        private System.Windows.Forms.Label lblGetTempTime;
        private System.Windows.Forms.Button btnMoveSpotAll;
        private System.Windows.Forms.Button btnUpdateSpot;
        private System.Windows.Forms.Label lblGetStateTime;
        private System.Windows.Forms.Label lblSpot6;
        private System.Windows.Forms.Label lblSpot5;
        private System.Windows.Forms.Label lblSpot4;
        private System.Windows.Forms.Label lblSpot3;
        private System.Windows.Forms.Label lblSpot2;
        private System.Windows.Forms.Label lblSpotTemp5;
        private System.Windows.Forms.Label lblSpotTemp4;
        private System.Windows.Forms.Label lblSpotTemp3;
        private System.Windows.Forms.Label lblSpotTemp2;
        private System.Windows.Forms.Label lblSpotTemp6;
        private System.Windows.Forms.CheckBox chkFreeze;
        private System.Windows.Forms.Label lblSnapStatus;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.Button btnSaveView;
        private System.Windows.Forms.Label lblSaveView;
        private System.Windows.Forms.TextBox txtSpot1X;
        private System.Windows.Forms.TextBox txtSpot1Y;
        private System.Windows.Forms.TextBox txtSpot6Y;
        private System.Windows.Forms.TextBox txtSpot6X;
        private System.Windows.Forms.TextBox txtSpot5Y;
        private System.Windows.Forms.TextBox txtSpot5X;
        private System.Windows.Forms.TextBox txtSpot4Y;
        private System.Windows.Forms.TextBox txtSpot4X;
        private System.Windows.Forms.TextBox txtSpot3Y;
        private System.Windows.Forms.TextBox txtSpot3X;
        private System.Windows.Forms.TextBox txtSpot2Y;
        private System.Windows.Forms.TextBox txtSpot2X;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGetTempCamera;
        private System.Windows.Forms.Label lblCameraTemp;
    }
}

