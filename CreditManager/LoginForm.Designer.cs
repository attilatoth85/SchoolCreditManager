namespace CreditManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SignInButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.RegisterButton = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(50, 117);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.UserNameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(50, 157);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(122, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CreditManager.Properties.Resources.paper_plane_40px;
            this.pictureBox4.Location = new System.Drawing.Point(174, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CreditManager.Properties.Resources.forgot_password_16px;
            this.pictureBox3.Location = new System.Drawing.Point(150, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CreditManager.Properties.Resources.lock_2_50px;
            this.pictureBox2.Location = new System.Drawing.Point(21, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CreditManager.Properties.Resources.gender_neutral_user_32px;
            this.pictureBox1.Location = new System.Drawing.Point(19, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(80, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // SignInButton
            // 
            this.SignInButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SignInButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignInButton.BorderRadius = 0;
            this.SignInButton.ButtonText = "Sign in";
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.DisabledColor = System.Drawing.Color.Gray;
            this.SignInButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SignInButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("SignInButton.Iconimage")));
            this.SignInButton.Iconimage_right = null;
            this.SignInButton.Iconimage_right_Selected = null;
            this.SignInButton.Iconimage_Selected = null;
            this.SignInButton.IconMarginLeft = 0;
            this.SignInButton.IconMarginRight = 0;
            this.SignInButton.IconRightVisible = true;
            this.SignInButton.IconRightZoom = 0D;
            this.SignInButton.IconVisible = false;
            this.SignInButton.IconZoom = 90D;
            this.SignInButton.IsTab = false;
            this.SignInButton.Location = new System.Drawing.Point(50, 241);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Normalcolor = System.Drawing.Color.MediumSeaGreen;
            this.SignInButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SignInButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SignInButton.selected = false;
            this.SignInButton.Size = new System.Drawing.Size(120, 27);
            this.SignInButton.TabIndex = 7;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignInButton.Textcolor = System.Drawing.Color.White;
            this.SignInButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.RegisterButton.BackColor = System.Drawing.Color.SteelBlue;
            this.RegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegisterButton.BorderRadius = 0;
            this.RegisterButton.ButtonText = "Register";
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.DisabledColor = System.Drawing.Color.Gray;
            this.RegisterButton.Iconcolor = System.Drawing.Color.Transparent;
            this.RegisterButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("RegisterButton.Iconimage")));
            this.RegisterButton.Iconimage_right = null;
            this.RegisterButton.Iconimage_right_Selected = null;
            this.RegisterButton.Iconimage_Selected = null;
            this.RegisterButton.IconMarginLeft = 0;
            this.RegisterButton.IconMarginRight = 0;
            this.RegisterButton.IconRightVisible = true;
            this.RegisterButton.IconRightZoom = 0D;
            this.RegisterButton.IconVisible = false;
            this.RegisterButton.IconZoom = 90D;
            this.RegisterButton.IsTab = false;
            this.RegisterButton.Location = new System.Drawing.Point(50, 294);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Normalcolor = System.Drawing.Color.SteelBlue;
            this.RegisterButton.OnHovercolor = System.Drawing.SystemColors.MenuHighlight;
            this.RegisterButton.OnHoverTextColor = System.Drawing.Color.White;
            this.RegisterButton.selected = false;
            this.RegisterButton.Size = new System.Drawing.Size(120, 27);
            this.RegisterButton.TabIndex = 8;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterButton.Textcolor = System.Drawing.Color.White;
            this.RegisterButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(220, 350);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton SignInButton;
        private Bunifu.Framework.UI.BunifuFlatButton RegisterButton;
    }
}