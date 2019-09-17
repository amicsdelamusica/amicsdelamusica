namespace AmicsDeLaMusica.Src.Partner
{
    partial class PartnerList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerList));
            this.DGVPartners = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsibleMusician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPartnerName = new System.Windows.Forms.TextBox();
            this.TBResponsibleMusician = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPartners)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPartners
            // 
            this.DGVPartners.AllowUserToAddRows = false;
            this.DGVPartners.AllowUserToResizeColumns = false;
            this.DGVPartners.AllowUserToResizeRows = false;
            this.DGVPartners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPartners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPartners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PartnerName,
            this.City,
            this.Street,
            this.StreetNumber,
            this.ResponsibleMusician});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPartners.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVPartners.Location = new System.Drawing.Point(12, 138);
            this.DGVPartners.Name = "DGVPartners";
            this.DGVPartners.ReadOnly = true;
            this.DGVPartners.RowHeadersVisible = false;
            this.DGVPartners.RowTemplate.Height = 24;
            this.DGVPartners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPartners.Size = new System.Drawing.Size(1117, 411);
            this.DGVPartners.TabIndex = 0;
            this.DGVPartners.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPartners_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 5;
            // 
            // PartnerName
            // 
            this.PartnerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.PartnerName.DataPropertyName = "PartnerName";
            this.PartnerName.HeaderText = "Soci";
            this.PartnerName.Name = "PartnerName";
            this.PartnerName.ReadOnly = true;
            this.PartnerName.Width = 5;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Ciutat";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 5;
            // 
            // Street
            // 
            this.Street.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Street.DataPropertyName = "Street";
            this.Street.HeaderText = "Carrer";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            this.Street.Width = 5;
            // 
            // StreetNumber
            // 
            this.StreetNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.StreetNumber.DataPropertyName = "StreetNumber";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.StreetNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.StreetNumber.HeaderText = "Nº";
            this.StreetNumber.Name = "StreetNumber";
            this.StreetNumber.ReadOnly = true;
            this.StreetNumber.Width = 5;
            // 
            // ResponsibleMusician
            // 
            this.ResponsibleMusician.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ResponsibleMusician.DataPropertyName = "ResponsibleMusician";
            this.ResponsibleMusician.HeaderText = "Responsable";
            this.ResponsibleMusician.Name = "ResponsibleMusician";
            this.ResponsibleMusician.ReadOnly = true;
            this.ResponsibleMusician.Width = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1117, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "LLISTAT DE SOCIS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInsert.Image = ((System.Drawing.Image)(resources.GetObject("ButtonInsert.Image")));
            this.ButtonInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonInsert.Location = new System.Drawing.Point(974, 555);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(155, 48);
            this.ButtonInsert.TabIndex = 2;
            this.ButtonInsert.Text = "AFEGIR";
            this.ButtonInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUpdate.Image")));
            this.ButtonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUpdate.Location = new System.Drawing.Point(813, 555);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(155, 48);
            this.ButtonUpdate.TabIndex = 3;
            this.ButtonUpdate.Text = "MODIFICAR";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.Image")));
            this.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDelete.Location = new System.Drawing.Point(652, 555);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(155, 48);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "ELIMINAR";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(12, 555);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(155, 48);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "EIXIR";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom:";
            // 
            // TBPartnerName
            // 
            this.TBPartnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPartnerName.Location = new System.Drawing.Point(67, 86);
            this.TBPartnerName.Name = "TBPartnerName";
            this.TBPartnerName.Size = new System.Drawing.Size(349, 27);
            this.TBPartnerName.TabIndex = 7;
            // 
            // TBResponsibleMusician
            // 
            this.TBResponsibleMusician.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBResponsibleMusician.Location = new System.Drawing.Point(545, 86);
            this.TBResponsibleMusician.Name = "TBResponsibleMusician";
            this.TBResponsibleMusician.Size = new System.Drawing.Size(349, 27);
            this.TBResponsibleMusician.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Responsable:";
            // 
            // ButtonFind
            // 
            this.ButtonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFind.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFind.Image")));
            this.ButtonFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonFind.Location = new System.Drawing.Point(974, 75);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(155, 48);
            this.ButtonFind.TabIndex = 10;
            this.ButtonFind.Text = "AFEGIR";
            this.ButtonFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonFind.UseVisualStyleBackColor = true;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // PartnerList
            // 
            this.AcceptButton = this.ButtonFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonExit;
            this.ClientSize = new System.Drawing.Size(1141, 615);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.TBResponsibleMusician);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBPartnerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVPartners);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartnerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llistat de socis";
            this.Load += new System.EventHandler(this.PartnerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPartners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPartners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponsibleMusician;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPartnerName;
        private System.Windows.Forms.TextBox TBResponsibleMusician;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonFind;
    }
}