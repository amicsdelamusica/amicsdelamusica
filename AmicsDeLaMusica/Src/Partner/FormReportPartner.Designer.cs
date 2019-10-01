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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carta per als socis";
            // 
            // TBLetterPath
            // 
            this.TBLetterPath.Location = new System.Drawing.Point(169, 18);
            this.TBLetterPath.Name = "TBLetterPath";
            this.TBLetterPath.Size = new System.Drawing.Size(389, 27);
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
            this.OFDLetter.FileName = "openFileDialog1";
            // 
            // ButtonReward
            // 
            this.ButtonReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReward.Image = ((System.Drawing.Image)(resources.GetObject("ButtonReward.Image")));
            this.ButtonReward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReward.Location = new System.Drawing.Point(16, 62);
            this.ButtonReward.Name = "ButtonReward";
            this.ButtonReward.Size = new System.Drawing.Size(216, 48);
            this.ButtonReward.TabIndex = 3;
            this.ButtonReward.Text = "LLISTAT SORTEIG";
            this.ButtonReward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonReward.UseVisualStyleBackColor = true;
            // 
            // ButtonPartnerReport
            // 
            this.ButtonPartnerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPartnerReport.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPartnerReport.Image")));
            this.ButtonPartnerReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPartnerReport.Location = new System.Drawing.Point(413, 62);
            this.ButtonPartnerReport.Name = "ButtonPartnerReport";
            this.ButtonPartnerReport.Size = new System.Drawing.Size(259, 48);
            this.ButtonPartnerReport.TabIndex = 4;
            this.ButtonPartnerReport.Text = "DOCUMENTACIÓ SOCIS";
            this.ButtonPartnerReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonPartnerReport.UseVisualStyleBackColor = true;
            this.ButtonPartnerReport.Click += new System.EventHandler(this.ButtonPartnerReport_Click);
            // 
            // FormReportPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 124);
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
    }
}