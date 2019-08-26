namespace AmicsDeLaMusica
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPartners = new System.Windows.Forms.Button();
            this.buttonMusicians = new System.Windows.Forms.Button();
            this.buttonCollaborator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AmicsDeLaMusica.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPartners
            // 
            this.buttonPartners.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPartners.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPartners.Location = new System.Drawing.Point(12, 487);
            this.buttonPartners.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPartners.Name = "buttonPartners";
            this.buttonPartners.Size = new System.Drawing.Size(455, 64);
            this.buttonPartners.TabIndex = 1;
            this.buttonPartners.Text = "SOCIS";
            this.buttonPartners.UseVisualStyleBackColor = true;
            this.buttonPartners.Click += new System.EventHandler(this.buttonPartners_Click);
            // 
            // buttonMusicians
            // 
            this.buttonMusicians.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMusicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusicians.Location = new System.Drawing.Point(12, 417);
            this.buttonMusicians.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMusicians.Name = "buttonMusicians";
            this.buttonMusicians.Size = new System.Drawing.Size(455, 64);
            this.buttonMusicians.TabIndex = 2;
            this.buttonMusicians.Text = "MÚSICS";
            this.buttonMusicians.UseVisualStyleBackColor = true;
            this.buttonMusicians.Click += new System.EventHandler(this.buttonMusicians_Click);
            // 
            // buttonCollaborator
            // 
            this.buttonCollaborator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCollaborator.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCollaborator.Location = new System.Drawing.Point(12, 557);
            this.buttonCollaborator.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCollaborator.Name = "buttonCollaborator";
            this.buttonCollaborator.Size = new System.Drawing.Size(455, 64);
            this.buttonCollaborator.TabIndex = 3;
            this.buttonCollaborator.Text = "COL·LABORADORS";
            this.buttonCollaborator.UseVisualStyleBackColor = true;
            this.buttonCollaborator.Click += new System.EventHandler(this.buttonCollaborator_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 633);
            this.Controls.Add(this.buttonCollaborator);
            this.Controls.Add(this.buttonMusicians);
            this.Controls.Add(this.buttonPartners);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A.C. Amics de la Música";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPartners;
        private System.Windows.Forms.Button buttonMusicians;
        private System.Windows.Forms.Button buttonCollaborator;
    }
}