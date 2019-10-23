namespace CreditManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SignOut = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbMoodle = new System.Windows.Forms.PictureBox();
            this.pbNeptun = new System.Windows.Forms.PictureBox();
            this.BtnSetup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnCalendar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAverages = new Bunifu.Framework.UI.BunifuFlatButton();
            this.viewPointer = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDiagram = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAddSubject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addNewSubject1 = new CreditManager.AddNewSubject();
            this.mainUserControl2 = new CreditManager.MainUserControl();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoodle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeptun)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.addNewSubject1);
            this.bunifuGradientPanel1.Controls.Add(this.mainUserControl2);
            this.bunifuGradientPanel1.Controls.Add(this.SignOut);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(700, 450);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // SignOut
            // 
            this.SignOut.AutoSize = true;
            this.SignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.SignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignOut.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.SignOut.Location = new System.Drawing.Point(651, 34);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(46, 14);
            this.SignOut.TabIndex = 11;
            this.SignOut.Text = "Sign out";
            this.SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.pbMoodle);
            this.panel2.Controls.Add(this.pbNeptun);
            this.panel2.Controls.Add(this.BtnSetup);
            this.panel2.Controls.Add(this.BtnCalendar);
            this.panel2.Controls.Add(this.BtnAverages);
            this.panel2.Controls.Add(this.viewPointer);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.lblSchoolName);
            this.panel2.Controls.Add(this.lblWelcomeName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnDiagram);
            this.panel2.Controls.Add(this.BtnAddSubject);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 420);
            this.panel2.TabIndex = 7;
            // 
            // pbMoodle
            // 
            this.pbMoodle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMoodle.Image = global::CreditManager.Properties.Resources.duf_logo;
            this.pbMoodle.Location = new System.Drawing.Point(138, 386);
            this.pbMoodle.Name = "pbMoodle";
            this.pbMoodle.Size = new System.Drawing.Size(22, 22);
            this.pbMoodle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMoodle.TabIndex = 25;
            this.pbMoodle.TabStop = false;
            this.pbMoodle.Click += new System.EventHandler(this.pbMoodle_Click);
            // 
            // pbNeptun
            // 
            this.pbNeptun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNeptun.Image = global::CreditManager.Properties.Resources.icon;
            this.pbNeptun.Location = new System.Drawing.Point(101, 386);
            this.pbNeptun.Name = "pbNeptun";
            this.pbNeptun.Size = new System.Drawing.Size(22, 22);
            this.pbNeptun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNeptun.TabIndex = 24;
            this.pbNeptun.TabStop = false;
            this.pbNeptun.Click += new System.EventHandler(this.pbNeptun_Click);
            // 
            // BtnSetup
            // 
            this.BtnSetup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSetup.BorderRadius = 0;
            this.BtnSetup.ButtonText = "   Setup";
            this.BtnSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetup.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSetup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSetup.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSetup.Iconimage = global::CreditManager.Properties.Resources.settings_50px;
            this.BtnSetup.Iconimage_right = null;
            this.BtnSetup.Iconimage_right_Selected = null;
            this.BtnSetup.Iconimage_Selected = null;
            this.BtnSetup.IconMarginLeft = 0;
            this.BtnSetup.IconMarginRight = 0;
            this.BtnSetup.IconRightVisible = true;
            this.BtnSetup.IconRightZoom = 0D;
            this.BtnSetup.IconVisible = true;
            this.BtnSetup.IconZoom = 42D;
            this.BtnSetup.IsTab = false;
            this.BtnSetup.Location = new System.Drawing.Point(0, 265);
            this.BtnSetup.Name = "BtnSetup";
            this.BtnSetup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnSetup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.BtnSetup.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSetup.selected = false;
            this.BtnSetup.Size = new System.Drawing.Size(160, 30);
            this.BtnSetup.TabIndex = 23;
            this.BtnSetup.Text = "   Setup";
            this.BtnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSetup.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.BtnSetup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetup.Click += new System.EventHandler(this.BtnSetup_Click);
            // 
            // BtnCalendar
            // 
            this.BtnCalendar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCalendar.BorderRadius = 0;
            this.BtnCalendar.ButtonText = "   Calendar";
            this.BtnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalendar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCalendar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnCalendar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCalendar.Iconimage = global::CreditManager.Properties.Resources.calendar_26px;
            this.BtnCalendar.Iconimage_right = null;
            this.BtnCalendar.Iconimage_right_Selected = null;
            this.BtnCalendar.Iconimage_Selected = null;
            this.BtnCalendar.IconMarginLeft = 0;
            this.BtnCalendar.IconMarginRight = 0;
            this.BtnCalendar.IconRightVisible = true;
            this.BtnCalendar.IconRightZoom = 0D;
            this.BtnCalendar.IconVisible = true;
            this.BtnCalendar.IconZoom = 42D;
            this.BtnCalendar.IsTab = false;
            this.BtnCalendar.Location = new System.Drawing.Point(0, 229);
            this.BtnCalendar.Name = "BtnCalendar";
            this.BtnCalendar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnCalendar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.BtnCalendar.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCalendar.selected = false;
            this.BtnCalendar.Size = new System.Drawing.Size(160, 30);
            this.BtnCalendar.TabIndex = 22;
            this.BtnCalendar.Text = "   Calendar";
            this.BtnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalendar.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.BtnCalendar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalendar.Click += new System.EventHandler(this.BtnCalendar_Click);
            // 
            // BtnAverages
            // 
            this.BtnAverages.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnAverages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnAverages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAverages.BorderRadius = 0;
            this.BtnAverages.ButtonText = "   Averages";
            this.BtnAverages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAverages.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAverages.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAverages.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAverages.Iconimage = global::CreditManager.Properties.Resources.average_value_80px;
            this.BtnAverages.Iconimage_right = null;
            this.BtnAverages.Iconimage_right_Selected = null;
            this.BtnAverages.Iconimage_Selected = null;
            this.BtnAverages.IconMarginLeft = 0;
            this.BtnAverages.IconMarginRight = 0;
            this.BtnAverages.IconRightVisible = true;
            this.BtnAverages.IconRightZoom = 0D;
            this.BtnAverages.IconVisible = true;
            this.BtnAverages.IconZoom = 47D;
            this.BtnAverages.IsTab = false;
            this.BtnAverages.Location = new System.Drawing.Point(0, 193);
            this.BtnAverages.Name = "BtnAverages";
            this.BtnAverages.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnAverages.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.BtnAverages.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAverages.selected = false;
            this.BtnAverages.Size = new System.Drawing.Size(160, 30);
            this.BtnAverages.TabIndex = 21;
            this.BtnAverages.Text = "   Averages";
            this.BtnAverages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAverages.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.BtnAverages.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAverages.Click += new System.EventHandler(this.BtnAverages_Click);
            // 
            // viewPointer
            // 
            this.viewPointer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.viewPointer.Location = new System.Drawing.Point(160, 121);
            this.viewPointer.Name = "viewPointer";
            this.viewPointer.Size = new System.Drawing.Size(5, 29);
            this.viewPointer.TabIndex = 20;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(170, 25);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(3, 370);
            this.bunifuSeparator1.TabIndex = 19;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSchoolName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblSchoolName.Location = new System.Drawing.Point(5, 90);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(61, 19);
            this.lblSchoolName.TabIndex = 12;
            this.lblSchoolName.Text = "?School";
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcomeName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblWelcomeName.Location = new System.Drawing.Point(109, 32);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(53, 23);
            this.lblWelcomeName.TabIndex = 11;
            this.lblWelcomeName.Text = "Name";
            this.lblWelcomeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(58, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome back";
            // 
            // BtnDiagram
            // 
            this.BtnDiagram.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnDiagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDiagram.BorderRadius = 0;
            this.BtnDiagram.ButtonText = "   Diagram";
            this.BtnDiagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDiagram.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDiagram.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDiagram.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDiagram.Iconimage = global::CreditManager.Properties.Resources.bullish_26px;
            this.BtnDiagram.Iconimage_right = null;
            this.BtnDiagram.Iconimage_right_Selected = null;
            this.BtnDiagram.Iconimage_Selected = null;
            this.BtnDiagram.IconMarginLeft = 0;
            this.BtnDiagram.IconMarginRight = 0;
            this.BtnDiagram.IconRightVisible = true;
            this.BtnDiagram.IconRightZoom = 0D;
            this.BtnDiagram.IconVisible = true;
            this.BtnDiagram.IconZoom = 42D;
            this.BtnDiagram.IsTab = false;
            this.BtnDiagram.Location = new System.Drawing.Point(0, 157);
            this.BtnDiagram.Name = "BtnDiagram";
            this.BtnDiagram.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnDiagram.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.BtnDiagram.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDiagram.selected = false;
            this.BtnDiagram.Size = new System.Drawing.Size(160, 30);
            this.BtnDiagram.TabIndex = 8;
            this.BtnDiagram.Text = "   Diagram";
            this.BtnDiagram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDiagram.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.BtnDiagram.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiagram.Click += new System.EventHandler(this.BtnDiagram_Click);
            // 
            // BtnAddSubject
            // 
            this.BtnAddSubject.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnAddSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddSubject.BorderRadius = 0;
            this.BtnAddSubject.ButtonText = "   Add new Subject";
            this.BtnAddSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddSubject.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAddSubject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAddSubject.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAddSubject.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAddSubject.Iconimage")));
            this.BtnAddSubject.Iconimage_right = null;
            this.BtnAddSubject.Iconimage_right_Selected = null;
            this.BtnAddSubject.Iconimage_Selected = null;
            this.BtnAddSubject.IconMarginLeft = 0;
            this.BtnAddSubject.IconMarginRight = 0;
            this.BtnAddSubject.IconRightVisible = true;
            this.BtnAddSubject.IconRightZoom = 0D;
            this.BtnAddSubject.IconVisible = true;
            this.BtnAddSubject.IconZoom = 45D;
            this.BtnAddSubject.IsTab = false;
            this.BtnAddSubject.Location = new System.Drawing.Point(0, 121);
            this.BtnAddSubject.Name = "BtnAddSubject";
            this.BtnAddSubject.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnAddSubject.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.BtnAddSubject.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAddSubject.selected = false;
            this.BtnAddSubject.Size = new System.Drawing.Size(160, 30);
            this.BtnAddSubject.TabIndex = 7;
            this.BtnAddSubject.Text = "   Add new Subject";
            this.BtnAddSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddSubject.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.BtnAddSubject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddSubject.Click += new System.EventHandler(this.BtnAddSubject_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 30);
            this.panel1.TabIndex = 6;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Image = global::CreditManager.Properties.Resources.horizontal_line_filled_50px;
            this.Minimize.Location = new System.Drawing.Point(645, 14);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(17, 17);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 3;
            this.Minimize.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = global::CreditManager.Properties.Resources.delete_sign_filled_50px;
            this.Exit.Location = new System.Drawing.Point(675, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(17, 17);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Credit Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CreditManager.Properties.Resources.student_center_30px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // addNewSubject1
            // 
            this.addNewSubject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.addNewSubject1.Location = new System.Drawing.Point(171, 51);
            this.addNewSubject1.Name = "addNewSubject1";
            this.addNewSubject1.Size = new System.Drawing.Size(526, 399);
            this.addNewSubject1.TabIndex = 13;
            // 
            // mainUserControl2
            // 
            this.mainUserControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.mainUserControl2.Location = new System.Drawing.Point(171, 51);
            this.mainUserControl2.Name = "mainUserControl2";
            this.mainUserControl2.Size = new System.Drawing.Size(529, 399);
            this.mainUserControl2.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1610, 380);
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoodle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeptun)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDiagram;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAddSubject;
        private System.Windows.Forms.Label lblWelcomeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSchoolName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel viewPointer;
        private AddNewSubject addNewSubject1;
        private MainUserControl mainUserControl2;
        private System.Windows.Forms.Label SignOut;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSetup;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCalendar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAverages;
        private System.Windows.Forms.PictureBox pbMoodle;
        private System.Windows.Forms.PictureBox pbNeptun;
    }
}

