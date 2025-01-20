
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
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
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelAuth = new System.Windows.Forms.Label();
            this.tBAge = new System.Windows.Forms.TextBox();
            this.labelExit = new System.Windows.Forms.Label();
            this.cBCategory = new System.Windows.Forms.ComboBox();
            this.cBDistrict = new System.Windows.Forms.ComboBox();
            this.tBAddress = new System.Windows.Forms.TextBox();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBDocNumber
            // 
            this.tBDocNumber.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBDocNumber.Location = new System.Drawing.Point(78, 101);
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
            this.buttonReg.Image = ((System.Drawing.Image)(resources.GetObject("buttonReg.Image")));
            this.buttonReg.Location = new System.Drawing.Point(78, 443);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(349, 76);
            this.buttonReg.TabIndex = 13;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Visible = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonRegReg_Click);
            // 
            // tBLastName
            // 
            this.tBLastName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBLastName.Location = new System.Drawing.Point(78, 111);
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
            this.tBPatronymic.Location = new System.Drawing.Point(78, 222);
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
            this.tBPass.Location = new System.Drawing.Point(78, 182);
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
            this.tBEmail.Location = new System.Drawing.Point(78, 180);
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
            this.tBNameUser.Location = new System.Drawing.Point(78, 165);
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
            this.tBPhone.Location = new System.Drawing.Point(78, 121);
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
            this.labelGender.Location = new System.Drawing.Point(146, 329);
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
            this.rBM.Location = new System.Drawing.Point(239, 327);
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
            this.rBF.Location = new System.Drawing.Point(300, 327);
            this.rBF.Name = "rBF";
            this.rBF.Size = new System.Drawing.Size(55, 33);
            this.rBF.TabIndex = 6;
            this.rBF.Text = "Ж";
            this.rBF.UseVisualStyleBackColor = true;
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonContinue.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.Image = ((System.Drawing.Image)(resources.GetObject("buttonContinue.Image")));
            this.buttonContinue.Location = new System.Drawing.Point(272, 371);
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
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(110, 371);
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
            this.labelAuth.Image = ((System.Drawing.Image)(resources.GetObject("labelAuth.Image")));
            this.labelAuth.Location = new System.Drawing.Point(101, 11);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(348, 68);
            this.labelAuth.TabIndex = 2814;
            this.labelAuth.Text = "Регистрация";
            // 
            // tBAge
            // 
            this.tBAge.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBAge.Location = new System.Drawing.Point(78, 283);
            this.tBAge.Multiline = true;
            this.tBAge.Name = "tBAge";
            this.tBAge.Size = new System.Drawing.Size(398, 38);
            this.tBAge.TabIndex = 2815;
            this.tBAge.Enter += new System.EventHandler(this.tBAge_Enter);
            this.tBAge.Leave += new System.EventHandler(this.tBAge_Leave);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.Image = ((System.Drawing.Image)(resources.GetObject("labelExit.Image")));
            this.labelExit.Location = new System.Drawing.Point(9, 497);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(63, 22);
            this.labelExit.TabIndex = 2816;
            this.labelExit.Text = "Выход";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // cBCategory
            // 
            this.cBCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "А1",
            "А2",
            "А3",
            "А4",
            "Б1",
            "Б2",
            "Б3",
            "Б4",
            "В",
            "Г",
            "Д"});
            this.cBCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCategory.FormattingEnabled = true;
            this.cBCategory.Items.AddRange(new object[] {
            "А1",
            "А2",
            "А3",
            "А4",
            "Б1",
            "Б2",
            "Б3",
            "Б4",
            "В",
            "Д",
            "Г"});
            this.cBCategory.Location = new System.Drawing.Point(300, 294);
            this.cBCategory.Name = "cBCategory";
            this.cBCategory.Size = new System.Drawing.Size(176, 24);
            this.cBCategory.TabIndex = 2817;
            this.cBCategory.Visible = false;
            // 
            // cBDistrict
            // 
            this.cBDistrict.AutoCompleteCustomSource.AddRange(new string[] {
            "Колпинского и Пушкинского районов",
            "Кронштадтского и Курортного районов",
            "Адмиралтейского и Кировского районов",
            "Василеостровского района",
            "Выборгского района",
            "Калининского района",
            "Красногвардейского района",
            "Красносельского района",
            "Московского района",
            "Невского района",
            "Петроградского района",
            "Петродворцового района",
            "Приморского района",
            "Фрунзенского района",
            "Центрального района"});
            this.cBDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDistrict.FormattingEnabled = true;
            this.cBDistrict.Items.AddRange(new object[] {
            "Колпинский и Пушкинский",
            "Кронштадтский и Курортный",
            "Адмиралтейский и Кировский",
            "Василеостровский",
            "Выборгский",
            "Калининский",
            "Красногвардейский",
            "Красносельский",
            "Московский",
            "Невский",
            "Петроградский",
            "Петродворцовый",
            "Приморский",
            "Фрунзенский",
            "Центральный"});
            this.cBDistrict.Location = new System.Drawing.Point(185, 263);
            this.cBDistrict.Name = "cBDistrict";
            this.cBDistrict.Size = new System.Drawing.Size(291, 24);
            this.cBDistrict.TabIndex = 2817;
            // 
            // tBAddress
            // 
            this.tBAddress.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBAddress.Location = new System.Drawing.Point(78, 226);
            this.tBAddress.Multiline = true;
            this.tBAddress.Name = "tBAddress";
            this.tBAddress.Size = new System.Drawing.Size(398, 38);
            this.tBAddress.TabIndex = 10;
            this.tBAddress.Visible = false;
            this.tBAddress.Enter += new System.EventHandler(this.tBAddress_Enter);
            this.tBAddress.Leave += new System.EventHandler(this.tBAddress_Leave);
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDistrict.Location = new System.Drawing.Point(86, 259);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(76, 28);
            this.labelDistrict.TabIndex = 20;
            this.labelDistrict.Text = "Район";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(47, 290);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(233, 28);
            this.labelCategory.TabIndex = 20;
            this.labelCategory.Text = "Категория годности";
            this.labelCategory.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 543);
            this.Controls.Add(this.cBDistrict);
            this.Controls.Add(this.cBCategory);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.tBAge);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.rBF);
            this.Controls.Add(this.rBM);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelDistrict);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.tBPhone);
            this.Controls.Add(this.tBNameUser);
            this.Controls.Add(this.tBAddress);
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
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.TextBox tBAge;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.ComboBox cBCategory;
        private System.Windows.Forms.ComboBox cBDistrict;
        private System.Windows.Forms.TextBox tBAddress;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.Label labelCategory;
    }
}