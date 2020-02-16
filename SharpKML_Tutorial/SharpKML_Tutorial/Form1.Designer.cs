namespace SharpKML_Tutorial
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.sideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureMaximizade = new System.Windows.Forms.PictureBox();
            this.pictureMinimizade = new System.Windows.Forms.PictureBox();
            this.pictureMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuSideBar = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelShowMap = new System.Windows.Forms.Panel();
            this.animationSideBar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animationSideBarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.panelSideBar.SuspendLayout();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSideBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelShowMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelSideBar.Controls.Add(this.sideBar);
            this.animationSideBarBack.SetDecoration(this.panelSideBar, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBar.SetDecoration(this.panelSideBar, BunifuAnimatorNS.DecorationType.None);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 54);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(240, 557);
            this.panelSideBar.TabIndex = 0;
            // 
            // sideBar
            // 
            this.sideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sideBar.BackgroundImage")));
            this.sideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideBar.Controls.Add(this.bunifuFlatButton3);
            this.sideBar.Controls.Add(this.bunifuFlatButton2);
            this.sideBar.Controls.Add(this.bunifuFlatButton1);
            this.sideBar.Controls.Add(this.bunifuSeparator1);
            this.sideBar.Controls.Add(this.pictureBoxLogo);
            this.animationSideBarBack.SetDecoration(this.sideBar, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBar.SetDecoration(this.sideBar, BunifuAnimatorNS.DecorationType.None);
            this.sideBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.sideBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.sideBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.sideBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.sideBar.Location = new System.Drawing.Point(8, 3);
            this.sideBar.Name = "sideBar";
            this.sideBar.Quality = 10;
            this.sideBar.Size = new System.Drawing.Size(225, 546);
            this.sideBar.TabIndex = 0;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "     ДОБАВИТЬ ТОЧКУ";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationSideBarBack.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBar.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Dusha V5", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 225);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(217, 50);
            this.bunifuFlatButton3.TabIndex = 2;
            this.bunifuFlatButton3.Text = "     ДОБАВИТЬ ТОЧКУ";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Dusha V5", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     ДОБАВИТЬ ПУТЬ";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationSideBarBack.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBar.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Dusha V5", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(3, 169);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(217, 50);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "     ДОБАВИТЬ ПУТЬ";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Dusha V5", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     ДОБАВИТЬ ТОЧКУ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationSideBarBack.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBar.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Dusha V5", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 55D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 113);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(217, 50);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "     ДОБАВИТЬ ТОЧКУ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Dusha V5", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.animationSideBarBack.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBar.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 85);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(217, 22);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.animationSideBar.SetDecoration(this.pictureBoxLogo, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBarBack.SetDecoration(this.pictureBoxLogo, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(58, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(91, 73);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTop.BackgroundImage")));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.pictureMaximizade);
            this.panelTop.Controls.Add(this.pictureMinimizade);
            this.panelTop.Controls.Add(this.pictureMaximizar);
            this.panelTop.Controls.Add(this.pictureExit);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.menuSideBar);
            this.animationSideBarBack.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBar.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelTop.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelTop.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelTop.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Quality = 10;
            this.panelTop.Size = new System.Drawing.Size(973, 54);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseUp);
            // 
            // pictureMaximizade
            // 
            this.pictureMaximizade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMaximizade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.animationSideBar.SetDecoration(this.pictureMaximizade, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBarBack.SetDecoration(this.pictureMaximizade, BunifuAnimatorNS.DecorationType.None);
            this.pictureMaximizade.Image = ((System.Drawing.Image)(resources.GetObject("pictureMaximizade.Image")));
            this.pictureMaximizade.Location = new System.Drawing.Point(895, 12);
            this.pictureMaximizade.Name = "pictureMaximizade";
            this.pictureMaximizade.Size = new System.Drawing.Size(25, 25);
            this.pictureMaximizade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMaximizade.TabIndex = 6;
            this.pictureMaximizade.TabStop = false;
            this.pictureMaximizade.Click += new System.EventHandler(this.PictureMaximizade_Click);
            // 
            // pictureMinimizade
            // 
            this.pictureMinimizade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimizade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.animationSideBar.SetDecoration(this.pictureMinimizade, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBarBack.SetDecoration(this.pictureMinimizade, BunifuAnimatorNS.DecorationType.None);
            this.pictureMinimizade.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimizade.Image")));
            this.pictureMinimizade.Location = new System.Drawing.Point(859, 12);
            this.pictureMinimizade.Name = "pictureMinimizade";
            this.pictureMinimizade.Size = new System.Drawing.Size(25, 25);
            this.pictureMinimizade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimizade.TabIndex = 5;
            this.pictureMinimizade.TabStop = false;
            this.pictureMinimizade.Click += new System.EventHandler(this.PictureMinimizade_Click);
            // 
            // pictureMaximizar
            // 
            this.pictureMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.animationSideBar.SetDecoration(this.pictureMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBarBack.SetDecoration(this.pictureMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.pictureMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureMaximizar.Image")));
            this.pictureMaximizar.Location = new System.Drawing.Point(895, 12);
            this.pictureMaximizar.Name = "pictureMaximizar";
            this.pictureMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pictureMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMaximizar.TabIndex = 4;
            this.pictureMaximizar.TabStop = false;
            this.pictureMaximizar.Visible = false;
            this.pictureMaximizar.Click += new System.EventHandler(this.PictureMaximizar_Click);
            // 
            // pictureExit
            // 
            this.pictureExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.animationSideBar.SetDecoration(this.pictureExit, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBarBack.SetDecoration(this.pictureExit, BunifuAnimatorNS.DecorationType.None);
            this.pictureExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureExit.Image")));
            this.pictureExit.Location = new System.Drawing.Point(931, 12);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(25, 25);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit.TabIndex = 3;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.animationSideBar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Dusha V5", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "МЕНЮ";
            // 
            // menuSideBar
            // 
            this.menuSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.animationSideBar.SetDecoration(this.menuSideBar, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBarBack.SetDecoration(this.menuSideBar, BunifuAnimatorNS.DecorationType.None);
            this.menuSideBar.Image = ((System.Drawing.Image)(resources.GetObject("menuSideBar.Image")));
            this.menuSideBar.Location = new System.Drawing.Point(20, 12);
            this.menuSideBar.Name = "menuSideBar";
            this.menuSideBar.Size = new System.Drawing.Size(30, 30);
            this.menuSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuSideBar.TabIndex = 1;
            this.menuSideBar.TabStop = false;
            this.menuSideBar.Click += new System.EventHandler(this.MenuSideBar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.sideBar;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.panelShowMap);
            this.animationSideBarBack.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(240, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 557);
            this.panel1.TabIndex = 1;
            // 
            // panelShowMap
            // 
            this.panelShowMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelShowMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelShowMap.Controls.Add(this.gMapControl1);
            this.animationSideBarBack.SetDecoration(this.panelShowMap, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBar.SetDecoration(this.panelShowMap, BunifuAnimatorNS.DecorationType.None);
            this.panelShowMap.Location = new System.Drawing.Point(16, 3);
            this.panelShowMap.Name = "panelShowMap";
            this.panelShowMap.Size = new System.Drawing.Size(700, 546);
            this.panelShowMap.TabIndex = 0;
            // 
            // animationSideBar
            // 
            this.animationSideBar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.animationSideBar.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.animationSideBar.DefaultAnimation = animation2;
            this.animationSideBar.Interval = 5;
            this.animationSideBar.TimeStep = 0.03F;
            // 
            // animationSideBarBack
            // 
            this.animationSideBarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animationSideBarBack.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animationSideBarBack.DefaultAnimation = animation1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.panelShowMap;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.animationSideBarBack.SetDecoration(this.gMapControl1, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBar.SetDecoration(this.gMapControl1, BunifuAnimatorNS.DecorationType.None);
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(3, 3);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(694, 539);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelTop);
            this.animationSideBar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animationSideBarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideBar.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSideBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelShowMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelTop;
        private System.Windows.Forms.PictureBox menuSideBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureMinimizade;
        private System.Windows.Forms.PictureBox pictureMaximizar;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.PictureBox pictureMaximizade;
        private System.Windows.Forms.Panel panelSideBar;
        private Bunifu.Framework.UI.BunifuGradientPanel sideBar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Panel panel1;
        private BunifuAnimatorNS.BunifuTransition animationSideBarBack;
        private BunifuAnimatorNS.BunifuTransition animationSideBar;
        private System.Windows.Forms.Panel panelShowMap;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}

