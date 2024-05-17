
namespace MeoIS
{
    partial class RegistrationForm
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
            this.tBDocNumber = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.tBLastName = new System.Windows.Forms.TextBox();
            this.tBPatronymic = new System.Windows.Forms.TextBox();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.tBNameUser = new System.Windows.Forms.TextBox();
            this.tBPhone = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.rBM = new System.Windows.Forms.RadioButton();
            this.rBF = new System.Windows.Forms.RadioButton();
            this.tBCategory = new System.Windows.Forms.TextBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelAuth = new System.Windows.Forms.Label();
            this.tBAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tBDocNumber
            // 
            this.tBDocNumber.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBDocNumber.Location = new System.Drawing.Point(71, 108);
            this.tBDocNumber.Multiline = true;
            this.tBDocNumber.Name = "tBDocNumber";
            this.tBDocNumber.Size = new System.Drawing.Size(398, 38);
            this.tBDocNumber.TabIndex = 1;
            this.tBDocNumber.Enter += new System.EventHandler(this.tBDocNumber_Enter);
            this.tBDocNumber.Leave += new System.EventHandler(this.tBDocNumber_Leave);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReg.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(80, 469);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(349, 76);
            this.buttonReg.TabIndex = 13;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonRegReg_Click);
            // 
            // tBLastName
            // 
            this.tBLastName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBLastName.Location = new System.Drawing.Point(71, 188);
            this.tBLastName.Multiline = true;
            this.tBLastName.Name = "tBLastName";
            this.tBLastName.Size = new System.Drawing.Size(398, 38);
            this.tBLastName.TabIndex = 3;
            this.tBLastName.Enter += new System.EventHandler(this.tBLastName_Enter);
            this.tBLastName.Leave += new System.EventHandler(this.tBLastName_Leave);
            // 
            // tBPatronymic
            // 
            this.tBPatronymic.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBPatronymic.Location = new System.Drawing.Point(71, 269);
            this.tBPatronymic.Multiline = true;
            this.tBPatronymic.Name = "tBPatronymic";
            this.tBPatronymic.Size = new System.Drawing.Size(398, 38);
            this.tBPatronymic.TabIndex = 4;
            this.tBPatronymic.Enter += new System.EventHandler(this.tBPatronymic_Enter);
            this.tBPatronymic.Leave += new System.EventHandler(this.tBPatronymic_Leave);
            // 
            // tBPass
            // 
            this.tBPass.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBPass.Location = new System.Drawing.Point(71, 209);
            this.tBPass.Multiline = true;
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(398, 38);
            this.tBPass.TabIndex = 12;
            this.tBPass.Enter += new System.EventHandler(this.tBPass_Enter);
            this.tBPass.Leave += new System.EventHandler(this.tBPass_Leave);
            // 
            // tBEmail
            // 
            this.tBEmail.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBEmail.Location = new System.Drawing.Point(71, 199);
            this.tBEmail.Multiline = true;
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(398, 38);
            this.tBEmail.TabIndex = 10;
            this.tBEmail.Enter += new System.EventHandler(this.tBEmail_Enter);
            this.tBEmail.Leave += new System.EventHandler(this.tBEmail_Leave);
            // 
            // tBNameUser
            // 
            this.tBNameUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBNameUser.Location = new System.Drawing.Point(71, 100);
            this.tBNameUser.Multiline = true;
            this.tBNameUser.Name = "tBNameUser";
            this.tBNameUser.Size = new System.Drawing.Size(398, 38);
            this.tBNameUser.TabIndex = 2;
            this.tBNameUser.Enter += new System.EventHandler(this.tBNameUser_Enter);
            this.tBNameUser.Leave += new System.EventHandler(this.tBNameUser_Leave);
            // 
            // tBPhone
            // 
            this.tBPhone.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBPhone.Location = new System.Drawing.Point(71, 108);
            this.tBPhone.Multiline = true;
            this.tBPhone.Name = "tBPhone";
            this.tBPhone.Size = new System.Drawing.Size(398, 38);
            this.tBPhone.TabIndex = 9;
            this.tBPhone.Enter += new System.EventHandler(this.tBPhone_Enter);
            this.tBPhone.Leave += new System.EventHandler(this.tBPhone_Leave);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(143, 337);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(54, 28);
            this.labelGender.TabIndex = 20;
            this.labelGender.Text = "Пол";
            // 
            // rBM
            // 
            this.rBM.AutoSize = true;
            this.rBM.Checked = true;
            this.rBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBM.Location = new System.Drawing.Point(246, 337);
            this.rBM.Name = "rBM";
            this.rBM.Size = new System.Drawing.Size(54, 33);
            this.rBM.TabIndex = 5;
            this.rBM.TabStop = true;
            this.rBM.Text = "M";
            this.rBM.UseVisualStyleBackColor = true;
            // 
            // rBF
            // 
            this.rBF.AutoSize = true;
            this.rBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBF.Location = new System.Drawing.Point(307, 337);
            this.rBF.Name = "rBF";
            this.rBF.Size = new System.Drawing.Size(55, 33);
            this.rBF.TabIndex = 6;
            this.rBF.Text = "Ж";
            this.rBF.UseVisualStyleBackColor = true;
            // 
            // tBCategory
            // 
            this.tBCategory.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBCategory.Location = new System.Drawing.Point(71, 296);
            this.tBCategory.Multiline = true;
            this.tBCategory.Name = "tBCategory";
            this.tBCategory.Size = new System.Drawing.Size(398, 38);
            this.tBCategory.TabIndex = 2811;
            this.tBCategory.Enter += new System.EventHandler(this.tBStatus_Enter);
            this.tBCategory.Leave += new System.EventHandler(this.tBStatus_Leave);
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonContinue.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.Location = new System.Drawing.Point(274, 397);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(120, 66);
            this.buttonContinue.TabIndex = 2812;
            this.buttonContinue.Text = "Далее";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(112, 397);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 66);
            this.buttonBack.TabIndex = 2813;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuth.Location = new System.Drawing.Point(91, 9);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(348, 68);
            this.labelAuth.TabIndex = 2814;
            this.labelAuth.Text = "Регистрация";
            // 
            // tBAge
            // 
            this.tBAge.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBAge.Location = new System.Drawing.Point(71, 313);
            this.tBAge.Multiline = true;
            this.tBAge.Name = "tBAge";
            this.tBAge.Size = new System.Drawing.Size(398, 38);
            this.tBAge.TabIndex = 2815;
            this.tBAge.Enter += new System.EventHandler(this.tBAge_Enter);
            this.tBAge.Leave += new System.EventHandler(this.tBAge_Leave);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 565);
            this.Controls.Add(this.tBAge);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.tBCategory);
            this.Controls.Add(this.rBF);
            this.Controls.Add(this.rBM);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.tBPhone);
            this.Controls.Add(this.tBNameUser);
            this.Controls.Add(this.tBEmail);
            this.Controls.Add(this.tBPass);
            this.Controls.Add(this.tBPatronymic);
            this.Controls.Add(this.tBLastName);
            this.Controls.Add(this.tBDocNumber);
            this.Controls.Add(this.buttonReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBDocNumber;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox tBLastName;
        private System.Windows.Forms.TextBox tBPatronymic;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.TextBox tBNameUser;
        private System.Windows.Forms.TextBox tBPhone;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RadioButton rBM;
        private System.Windows.Forms.RadioButton rBF;
        private System.Windows.Forms.TextBox tBCategory;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.TextBox tBAge;
    }
}