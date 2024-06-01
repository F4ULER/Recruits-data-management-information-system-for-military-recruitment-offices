
namespace MeoIS
{
    partial class MainForm
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
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.labelEnterReg = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.dataGVLitTable = new System.Windows.Forms.DataGridView();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelRectal = new System.Windows.Forms.Label();
            this.labelChangeMilitaryRegistrationOffice = new System.Windows.Forms.Label();
            this.pictureOptions = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.tBChangePass = new System.Windows.Forms.TextBox();
            this.tBChangeEmail = new System.Windows.Forms.TextBox();
            this.tBCangePhone = new System.Windows.Forms.TextBox();
            this.labelChageEmail = new System.Windows.Forms.Label();
            this.labelChangePhone = new System.Windows.Forms.Label();
            this.labelChangePass = new System.Windows.Forms.Label();
            this.buttonChangeUserAccont = new System.Windows.Forms.Button();
            this.tabControlMenuServices = new System.Windows.Forms.TabControl();
            this.tPReg = new System.Windows.Forms.TabPage();
            this.buttonOldEnlistmentOffice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBNewAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBEnlistmentOfficeWhereRegistered = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tPMed = new System.Windows.Forms.TabPage();
            this.tPChange = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLitTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.tabControlMenuServices.SuspendLayout();
            this.tPReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBSearch
            // 
            this.tBSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBSearch.Location = new System.Drawing.Point(908, 12);
            this.tBSearch.Multiline = true;
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(233, 30);
            this.tBSearch.TabIndex = 5;
            // 
            // labelEnterReg
            // 
            this.labelEnterReg.AutoSize = true;
            this.labelEnterReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEnterReg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnterReg.Location = new System.Drawing.Point(12, 464);
            this.labelEnterReg.Name = "labelEnterReg";
            this.labelEnterReg.Size = new System.Drawing.Size(163, 22);
            this.labelEnterReg.TabIndex = 7;
            this.labelEnterReg.Text = "Вход/Регистрация";
            this.labelEnterReg.Visible = false;
            this.labelEnterReg.Click += new System.EventHandler(this.labelEnterReg_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.Location = new System.Drawing.Point(12, 498);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(63, 22);
            this.labelExit.TabIndex = 8;
            this.labelExit.Text = "Выход";
            this.labelExit.Visible = false;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // dataGVLitTable
            // 
            this.dataGVLitTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVLitTable.Location = new System.Drawing.Point(272, 84);
            this.dataGVLitTable.Name = "dataGVLitTable";
            this.dataGVLitTable.RowHeadersWidth = 51;
            this.dataGVLitTable.RowTemplate.Height = 24;
            this.dataGVLitTable.Size = new System.Drawing.Size(713, 489);
            this.dataGVLitTable.TabIndex = 10;
            this.dataGVLitTable.Visible = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(10, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(54, 33);
            this.labelWelcome.TabIndex = 11;
            this.labelWelcome.Text = "test";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(13, 66);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(77, 17);
            this.labelCategory.TabIndex = 12;
            this.labelCategory.Text = "Категория";
            // 
            // labelRectal
            // 
            this.labelRectal.AutoSize = true;
            this.labelRectal.Location = new System.Drawing.Point(12, 112);
            this.labelRectal.Name = "labelRectal";
            this.labelRectal.Size = new System.Drawing.Size(129, 17);
            this.labelRectal.TabIndex = 13;
            this.labelRectal.Text = "Военкомат города";
            // 
            // labelChangeMilitaryRegistrationOffice
            // 
            this.labelChangeMilitaryRegistrationOffice.AutoSize = true;
            this.labelChangeMilitaryRegistrationOffice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChangeMilitaryRegistrationOffice.Location = new System.Drawing.Point(12, 139);
            this.labelChangeMilitaryRegistrationOffice.Name = "labelChangeMilitaryRegistrationOffice";
            this.labelChangeMilitaryRegistrationOffice.Size = new System.Drawing.Size(134, 17);
            this.labelChangeMilitaryRegistrationOffice.TabIndex = 14;
            this.labelChangeMilitaryRegistrationOffice.Text = "(Смена военкомат)";
            this.labelChangeMilitaryRegistrationOffice.Click += new System.EventHandler(this.labelChangeMilitaryRegistrationOffice_Click);
            // 
            // pictureOptions
            // 
            this.pictureOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureOptions.Image = global::MeoIS.Properties.Resources.options;
            this.pictureOptions.Location = new System.Drawing.Point(15, 455);
            this.pictureOptions.Name = "pictureOptions";
            this.pictureOptions.Size = new System.Drawing.Size(40, 40);
            this.pictureOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOptions.TabIndex = 17;
            this.pictureOptions.TabStop = false;
            this.pictureOptions.Click += new System.EventHandler(this.pictureOptions_Click);
            // 
            // picSearch
            // 
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.Image = global::MeoIS.Properties.Resources.search;
            this.picSearch.Location = new System.Drawing.Point(1147, 2);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(40, 40);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 6;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // tBChangePass
            // 
            this.tBChangePass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBChangePass.Location = new System.Drawing.Point(15, 373);
            this.tBChangePass.Multiline = true;
            this.tBChangePass.Name = "tBChangePass";
            this.tBChangePass.Size = new System.Drawing.Size(188, 30);
            this.tBChangePass.TabIndex = 18;
            this.tBChangePass.Visible = false;
            // 
            // tBChangeEmail
            // 
            this.tBChangeEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBChangeEmail.Location = new System.Drawing.Point(12, 255);
            this.tBChangeEmail.Multiline = true;
            this.tBChangeEmail.Name = "tBChangeEmail";
            this.tBChangeEmail.Size = new System.Drawing.Size(188, 30);
            this.tBChangeEmail.TabIndex = 19;
            this.tBChangeEmail.Visible = false;
            // 
            // tBCangePhone
            // 
            this.tBCangePhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBCangePhone.Location = new System.Drawing.Point(15, 310);
            this.tBCangePhone.Multiline = true;
            this.tBCangePhone.Name = "tBCangePhone";
            this.tBCangePhone.Size = new System.Drawing.Size(188, 30);
            this.tBCangePhone.TabIndex = 20;
            this.tBCangePhone.Visible = false;
            // 
            // labelChageEmail
            // 
            this.labelChageEmail.AutoSize = true;
            this.labelChageEmail.Location = new System.Drawing.Point(13, 235);
            this.labelChageEmail.Name = "labelChageEmail";
            this.labelChageEmail.Size = new System.Drawing.Size(137, 17);
            this.labelChageEmail.TabIndex = 21;
            this.labelChageEmail.Text = "Изменить эл. почту";
            this.labelChageEmail.Visible = false;
            // 
            // labelChangePhone
            // 
            this.labelChangePhone.AutoSize = true;
            this.labelChangePhone.Location = new System.Drawing.Point(18, 290);
            this.labelChangePhone.Name = "labelChangePhone";
            this.labelChangePhone.Size = new System.Drawing.Size(134, 17);
            this.labelChangePhone.TabIndex = 22;
            this.labelChangePhone.Text = "Изменить телефон";
            this.labelChangePhone.Visible = false;
            // 
            // labelChangePass
            // 
            this.labelChangePass.AutoSize = true;
            this.labelChangePass.Location = new System.Drawing.Point(13, 353);
            this.labelChangePass.Name = "labelChangePass";
            this.labelChangePass.Size = new System.Drawing.Size(123, 17);
            this.labelChangePass.TabIndex = 23;
            this.labelChangePass.Text = "Изменить пароль";
            this.labelChangePass.Visible = false;
            // 
            // buttonChangeUserAccont
            // 
            this.buttonChangeUserAccont.Location = new System.Drawing.Point(39, 409);
            this.buttonChangeUserAccont.Name = "buttonChangeUserAccont";
            this.buttonChangeUserAccont.Size = new System.Drawing.Size(92, 30);
            this.buttonChangeUserAccont.TabIndex = 24;
            this.buttonChangeUserAccont.Text = "Сохранить";
            this.buttonChangeUserAccont.UseVisualStyleBackColor = true;
            this.buttonChangeUserAccont.Visible = false;
            this.buttonChangeUserAccont.Click += new System.EventHandler(this.buttonChangeUserAccont_Click);
            // 
            // tabControlMenuServices
            // 
            this.tabControlMenuServices.Controls.Add(this.tPReg);
            this.tabControlMenuServices.Controls.Add(this.tPMed);
            this.tabControlMenuServices.Controls.Add(this.tPChange);
            this.tabControlMenuServices.Location = new System.Drawing.Point(224, 66);
            this.tabControlMenuServices.Name = "tabControlMenuServices";
            this.tabControlMenuServices.SelectedIndex = 0;
            this.tabControlMenuServices.Size = new System.Drawing.Size(908, 460);
            this.tabControlMenuServices.TabIndex = 25;
            // 
            // tPReg
            // 
            this.tPReg.Controls.Add(this.buttonOldEnlistmentOffice);
            this.tPReg.Controls.Add(this.label3);
            this.tPReg.Controls.Add(this.tBNewAddress);
            this.tPReg.Controls.Add(this.label2);
            this.tPReg.Controls.Add(this.tBEnlistmentOfficeWhereRegistered);
            this.tPReg.Controls.Add(this.label1);
            this.tPReg.Location = new System.Drawing.Point(4, 25);
            this.tPReg.Name = "tPReg";
            this.tPReg.Padding = new System.Windows.Forms.Padding(3);
            this.tPReg.Size = new System.Drawing.Size(900, 431);
            this.tPReg.TabIndex = 0;
            this.tPReg.Text = "Постановка на учет";
            this.tPReg.UseVisualStyleBackColor = true;
            // 
            // buttonOldEnlistmentOffice
            // 
            this.buttonOldEnlistmentOffice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOldEnlistmentOffice.Location = new System.Drawing.Point(385, 252);
            this.buttonOldEnlistmentOffice.Name = "buttonOldEnlistmentOffice";
            this.buttonOldEnlistmentOffice.Size = new System.Drawing.Size(165, 54);
            this.buttonOldEnlistmentOffice.TabIndex = 30;
            this.buttonOldEnlistmentOffice.Text = "Встать на учет";
            this.buttonOldEnlistmentOffice.UseVisualStyleBackColor = true;
            this.buttonOldEnlistmentOffice.Click += new System.EventHandler(this.buttonOldEnlistmentOffice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(483, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Новый адрес фактического проживания\r\n";
            // 
            // tBNewAddress
            // 
            this.tBNewAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBNewAddress.Location = new System.Drawing.Point(536, 182);
            this.tBNewAddress.Multiline = true;
            this.tBNewAddress.Name = "tBNewAddress";
            this.tBNewAddress.Size = new System.Drawing.Size(237, 27);
            this.tBNewAddress.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(115, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 44);
            this.label2.TabIndex = 27;
            this.label2.Text = "Военкомат, в котором вы состоите\r\n на учете на данный момент";
            // 
            // tBEnlistmentOfficeWhereRegistered
            // 
            this.tBEnlistmentOfficeWhereRegistered.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBEnlistmentOfficeWhereRegistered.Location = new System.Drawing.Point(130, 182);
            this.tBEnlistmentOfficeWhereRegistered.Multiline = true;
            this.tBEnlistmentOfficeWhereRegistered.Name = "tBEnlistmentOfficeWhereRegistered";
            this.tBEnlistmentOfficeWhereRegistered.Size = new System.Drawing.Size(261, 27);
            this.tBEnlistmentOfficeWhereRegistered.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(173, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Постановка и снятие с учета";
            // 
            // tPMed
            // 
            this.tPMed.Location = new System.Drawing.Point(4, 25);
            this.tPMed.Name = "tPMed";
            this.tPMed.Padding = new System.Windows.Forms.Padding(3);
            this.tPMed.Size = new System.Drawing.Size(1194, 573);
            this.tPMed.TabIndex = 1;
            this.tPMed.Text = "Медицинский осмотр";
            this.tPMed.UseVisualStyleBackColor = true;
            // 
            // tPChange
            // 
            this.tPChange.Location = new System.Drawing.Point(4, 25);
            this.tPChange.Name = "tPChange";
            this.tPChange.Padding = new System.Windows.Forms.Padding(3);
            this.tPChange.Size = new System.Drawing.Size(1194, 573);
            this.tPChange.TabIndex = 2;
            this.tPChange.Text = "Смена места учебы/работы";
            this.tPChange.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 604);
            this.Controls.Add(this.tabControlMenuServices);
            this.Controls.Add(this.buttonChangeUserAccont);
            this.Controls.Add(this.labelChangePass);
            this.Controls.Add(this.labelChangePhone);
            this.Controls.Add(this.labelChageEmail);
            this.Controls.Add(this.tBCangePhone);
            this.Controls.Add(this.tBChangeEmail);
            this.Controls.Add(this.tBChangePass);
            this.Controls.Add(this.pictureOptions);
            this.Controls.Add(this.labelChangeMilitaryRegistrationOffice);
            this.Controls.Add(this.labelRectal);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelEnterReg);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.dataGVLitTable);
            this.Name = "MainForm";
            this.Text = "MeoIS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLitTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.tabControlMenuServices.ResumeLayout(false);
            this.tPReg.ResumeLayout(false);
            this.tPReg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Label labelExit;
        public System.Windows.Forms.DataGridView dataGVLitTable;
        public System.Windows.Forms.Label labelEnterReg;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelRectal;
        private System.Windows.Forms.Label labelChangeMilitaryRegistrationOffice;
        private System.Windows.Forms.PictureBox pictureOptions;
        private System.Windows.Forms.TextBox tBChangePass;
        private System.Windows.Forms.TextBox tBChangeEmail;
        private System.Windows.Forms.TextBox tBCangePhone;
        private System.Windows.Forms.Label labelChageEmail;
        private System.Windows.Forms.Label labelChangePhone;
        private System.Windows.Forms.Label labelChangePass;
        private System.Windows.Forms.Button buttonChangeUserAccont;
        private System.Windows.Forms.TabControl tabControlMenuServices;
        private System.Windows.Forms.TabPage tPReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBEnlistmentOfficeWhereRegistered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tPMed;
        private System.Windows.Forms.TabPage tPChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBNewAddress;
        private System.Windows.Forms.Button buttonOldEnlistmentOffice;
    }
}

