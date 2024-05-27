
namespace MeoIS
{
    partial class AuthenticationForm
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
            this.buttonAuthEnter = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.picturePass = new System.Windows.Forms.PictureBox();
            this.labelAuth = new System.Windows.Forms.Label();
            this.buttonWithoutReg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePass)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAuthEnter
            // 
            this.buttonAuthEnter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAuthEnter.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthEnter.Location = new System.Drawing.Point(191, 342);
            this.buttonAuthEnter.Name = "buttonAuthEnter";
            this.buttonAuthEnter.Size = new System.Drawing.Size(138, 76);
            this.buttonAuthEnter.TabIndex = 3;
            this.buttonAuthEnter.Text = "Вход";
            this.buttonAuthEnter.UseVisualStyleBackColor = false;
            this.buttonAuthEnter.Click += new System.EventHandler(this.buttonAuthEnter_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReg.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(105, 444);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(318, 76);
            this.buttonReg.TabIndex = 4;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(120, 162);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(354, 38);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(120, 269);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(354, 38);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.Enter += new System.EventHandler(this.textBoxPass_Enter);
            this.textBoxPass.Leave += new System.EventHandler(this.textBoxPass_Leave);
            // 
            // pictureUser
            // 
            this.pictureUser.Image = global::MeoIS.Properties.Resources.user;
            this.pictureUser.Location = new System.Drawing.Point(19, 144);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(72, 69);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 4;
            this.pictureUser.TabStop = false;
            // 
            // picturePass
            // 
            this.picturePass.Image = global::MeoIS.Properties.Resources.pass_close;
            this.picturePass.Location = new System.Drawing.Point(19, 246);
            this.picturePass.Name = "picturePass";
            this.picturePass.Size = new System.Drawing.Size(72, 69);
            this.picturePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePass.TabIndex = 5;
            this.picturePass.TabStop = false;
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuth.Location = new System.Drawing.Point(75, 21);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(417, 68);
            this.labelAuth.TabIndex = 6;
            this.labelAuth.Text = "Вход в систему";
            // 
            // buttonWithoutReg
            // 
            this.buttonWithoutReg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWithoutReg.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWithoutReg.Location = new System.Drawing.Point(182, 526);
            this.buttonWithoutReg.Name = "buttonWithoutReg";
            this.buttonWithoutReg.Size = new System.Drawing.Size(166, 85);
            this.buttonWithoutReg.TabIndex = 7;
            this.buttonWithoutReg.Text = "Продолжить без регистрации";
            this.buttonWithoutReg.UseVisualStyleBackColor = false;
            this.buttonWithoutReg.Click += new System.EventHandler(this.buttonWithoutReg_Click);
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(542, 623);
            this.Controls.Add(this.buttonWithoutReg);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.picturePass);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonAuthEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthenticationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthenticationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAuthEnter;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.PictureBox picturePass;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Button buttonWithoutReg;
    }
}