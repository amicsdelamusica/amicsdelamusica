namespace AmicsDeLaMusica.Src.Partner
{
    partial class FormReportPartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportPartner));
            this.label1 = new System.Windows.Forms.Label();
            this.TBLetterPath = new System.Windows.Forms.TextBox();
            this.ButtonBrowseLetter = new System.Windows.Forms.Button();
            this.OFDLetter = new System.Windows.Forms.OpenFileDialog();
            this.ButtonReward = new System.Windows.Forms.Button();
            this.ButtonPartnerReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPDueDate = new System.Windows.Forms.DateTimePicker();
            this.ButtonBrowseOutput = new System.Windows.Forms.Button();
            this.TBOutputPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.FBDOutput = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carta per als socis";
            // 
            // TBLetterPath
            // 
            this.TBLetterPath.Location = new System.Drawing.Point(169, 18);
            this.TBLetterPath.Name = "TBLetterPath";
            this.TBLetterPath.Size = new System.Drawing.Size(389, 23);
            this.TBLetterPath.TabIndex = 1;
            // 
            // ButtonBrowseLetter
            // 
            this.ButtonBrowseLetter.Location = new System.Drawing.Point(564, 18);
            this.ButtonBrowseLetter.Name = "ButtonBrowseLetter";
            this.ButtonBrowseLetter.Size = new System.Drawing.Size(108, 27);
            this.ButtonBrowseLetter.TabIndex = 2;
            this.ButtonBrowseLetter.Text = "Examinar...";
            this.ButtonBrowseLetter.UseVisualStyleBackColor = true;
            this.ButtonBrowseLetter.Click += new System.EventHandler(this.ButtonBrowseLetter_Click);
            // 
            // OFDLetter
            // 
            this.OFDLetter.FileName = "CARTASOCIS";
            this.OFDLetter.Filter = "Arxius PDF|*.pdf";
            // 
            // ButtonReward
            // 
            this.ButtonReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReward.Image = ((System.Drawing.Image)(resources.GetObject("ButtonReward.Image")));
            this.ButtonReward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReward.Location = new System.Drawing.Point(12, 118);
            this.ButtonReward.Name = "ButtonReward";
            this.ButtonReward.Size = new System.Drawing.Size(216, 48);
            this.ButtonReward.TabIndex = 3;
            this.ButtonReward.Text = "LLISTAT SORTEIG";
            this.ButtonReward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonReward.UseVisualStyleBackColor = true;
            this.ButtonReward.Click += new System.EventHandler(this.ButtonReward_Click);
            // 
            // ButtonPartnerReport
            // 
            this.ButtonPartnerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPartnerReport.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPartnerReport.Image")));
            this.ButtonPartnerReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPartnerReport.Location = new System.Drawing.Point(413, 118);
            this.ButtonPartnerReport.Name = "ButtonPartnerReport";
            this.ButtonPartnerReport.Size = new System.Drawing.Size(259, 48);
            this.ButtonPartnerReport.TabIndex = 4;
            this.ButtonPartnerReport.Text = "DOCUMENTACIÓ SOCIS";
            this.ButtonPartnerReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonPartnerReport.UseVisualStyleBackColor = true;
            this.ButtonPartnerReport.Click += new System.EventHandler(this.ButtonPartnerReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data límit";
            // 
            // DTPDueDate
            // 
            this.DTPDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDueDate.Location = new System.Drawing.Point(169, 52);
            this.DTPDueDate.Name = "DTPDueDate";
            this.DTPDueDate.Size = new System.Drawing.Size(180, 23);
            this.DTPDueDate.TabIndex = 6;
            // 
            // ButtonBrowseOutput
            // 
            this.ButtonBrowseOutput.Location = new System.Drawing.Point(564, 85);
            this.ButtonBrowseOutput.Name = "ButtonBrowseOutput";
            this.ButtonBrowseOutput.Size = new System.Drawing.Size(108, 27);
            this.ButtonBrowseOutput.TabIndex = 9;
            this.ButtonBrowseOutput.Text = "Examinar...";
            this.ButtonBrowseOutput.UseVisualStyleBackColor = true;
            this.ButtonBrowseOutput.Click += new System.EventHandler(this.ButtonBrowseOutput_Click);
            // 
            // TBOutputPath
            // 
            this.TBOutputPath.Location = new System.Drawing.Point(169, 85);
            this.TBOutputPath.Name = "TBOutputPath";
            this.TBOutputPath.Size = new System.Drawing.Size(389, 23);
            this.TBOutputPath.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Guardar en";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Import";
            // 
            // NumericAmount
            // 
            this.NumericAmount.DecimalPlaces = 2;
            this.NumericAmount.Location = new System.Drawing.Point(417, 52);
            this.NumericAmount.Name = "NumericAmount";
            this.NumericAmount.Size = new System.Drawing.Size(82, 23);
            this.NumericAmount.TabIndex = 11;
            this.NumericAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericAmount.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Euros";
            // 
            // FormReportPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 175);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumericAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonBrowseOutput);
            this.Controls.Add(this.TBOutputPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTPDueDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonPartnerReport);
            this.Controls.Add(this.ButtonReward);
            this.Controls.Add(this.ButtonBrowseLetter);
            this.Controls.Add(this.TBLetterPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormReportPartner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documents";
            this.Load += new System.EventHandler(this.FormReportPartner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBLetterPath;
        private System.Windows.Forms.Button ButtonBrowseLetter;
        private System.Windows.Forms.OpenFileDialog OFDLetter;
        private System.Windows.Forms.Button ButtonReward;
        private System.Windows.Forms.Button ButtonPartnerReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPDueDate;
        private System.Windows.Forms.Button ButtonBrowseOutput;
        private System.Windows.Forms.TextBox TBOutputPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog FBDOutput;
    }
}