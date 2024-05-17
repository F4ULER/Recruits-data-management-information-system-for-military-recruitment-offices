
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
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.labelEnterReg = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.dataGVLitTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLitTable)).BeginInit();
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
            // labelEnterReg
            // 
            this.labelEnterReg.AutoSize = true;
            this.labelEnterReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEnterReg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnterReg.Location = new System.Drawing.Point(12, 9);
            this.labelEnterReg.Name = "labelEnterReg";
            this.labelEnterReg.Size = new System.Drawing.Size(163, 22);
            this.labelEnterReg.TabIndex = 7;
            this.labelEnterReg.Text = "Вход/Регистрация";
            this.labelEnterReg.Click += new System.EventHandler(this.labelEnterReg_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.Location = new System.Drawing.Point(12, 43);
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
            this.dataGVLitTable.Location = new System.Drawing.Point(277, 112);
            this.dataGVLitTable.Name = "dataGVLitTable";
            this.dataGVLitTable.RowHeadersWidth = 51;
            this.dataGVLitTable.RowTemplate.Height = 24;
            this.dataGVLitTable.Size = new System.Drawing.Size(696, 306);
            this.dataGVLitTable.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 604);
            this.Controls.Add(this.dataGVLitTable);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelEnterReg);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.tBSearch);
            this.Name = "MainForm";
            this.Text = "MeoIS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLitTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Label labelEnterReg;
        private System.Windows.Forms.Label labelExit;
        public System.Windows.Forms.DataGridView dataGVLitTable;
    }
}

