
namespace MeoIS
{
    partial class TEST
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
            this.labelWelcome2 = new System.Windows.Forms.Label();
            this.labelWelcome3 = new System.Windows.Forms.Label();
            this.labelWelcome1 = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.buttonFirstReg = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.dGView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome2
            // 
            this.labelWelcome2.AutoSize = true;
            this.labelWelcome2.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome2.Location = new System.Drawing.Point(101, 210);
            this.labelWelcome2.Name = "labelWelcome2";
            this.labelWelcome2.Size = new System.Drawing.Size(991, 49);
            this.labelWelcome2.TabIndex = 0;
            this.labelWelcome2.Text = " в информационную систему военкоматов России!";
            this.labelWelcome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWelcome3
            // 
            this.labelWelcome3.AutoSize = true;
            this.labelWelcome3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome3.Location = new System.Drawing.Point(57, 341);
            this.labelWelcome3.Name = "labelWelcome3";
            this.labelWelcome3.Size = new System.Drawing.Size(1146, 70);
            this.labelWelcome3.TabIndex = 1;
            this.labelWelcome3.Text = "Здесь Вы сможете в любое время ознакомиться с интересующей Вас информацией, \r\nа т" +
    "акже после регистрации будет доступен весь функционал системы";
            this.labelWelcome3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWelcome1
            // 
            this.labelWelcome1.AutoSize = true;
            this.labelWelcome1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome1.Location = new System.Drawing.Point(358, 132);
            this.labelWelcome1.Name = "labelWelcome1";
            this.labelWelcome1.Size = new System.Drawing.Size(546, 67);
            this.labelWelcome1.TabIndex = 2;
            this.labelWelcome1.Text = "Добро пожаловать\r\n";
            this.labelWelcome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLine.Location = new System.Drawing.Point(166, 261);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(880, 49);
            this.labelLine.TabIndex = 3;
            this.labelLine.Text = "_______________________________________";
            this.labelLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFirstReg
            // 
            this.buttonFirstReg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFirstReg.Location = new System.Drawing.Point(485, 520);
            this.buttonFirstReg.Name = "buttonFirstReg";
            this.buttonFirstReg.Size = new System.Drawing.Size(265, 58);
            this.buttonFirstReg.TabIndex = 4;
            this.buttonFirstReg.Text = "Зарегистрироваться";
            this.buttonFirstReg.UseVisualStyleBackColor = true;
            this.buttonFirstReg.Click += new System.EventHandler(this.buttonFirstReg_Click);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(27, 341);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(146, 36);
            this.button.TabIndex = 5;
            this.button.Text = "тест";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.buttonStat_Click);
            // 
            // dGView
            // 
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Location = new System.Drawing.Point(425, 12);
            this.dGView.Name = "dGView";
            this.dGView.RowHeadersWidth = 51;
            this.dGView.RowTemplate.Height = 24;
            this.dGView.Size = new System.Drawing.Size(778, 459);
            this.dGView.TabIndex = 6;
            // 
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 603);
            this.Controls.Add(this.button);
            this.Controls.Add(this.dGView);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelWelcome1);
            this.Controls.Add(this.labelWelcome3);
            this.Controls.Add(this.labelWelcome2);
            this.Controls.Add(this.buttonFirstReg);
            this.Name = "TEST";
            this.Text = "TEST";
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome2;
        private System.Windows.Forms.Label labelWelcome3;
        private System.Windows.Forms.Label labelWelcome1;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Button buttonFirstReg;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DataGridView dGView;
    }
}