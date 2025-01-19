namespace Exam
{
    partial class DetailedQuestion
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
            this.pbDetails = new System.Windows.Forms.PictureBox();
            this.tbDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDetails
            // 
            this.pbDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbDetails.Location = new System.Drawing.Point(51, 63);
            this.pbDetails.Name = "pbDetails";
            this.pbDetails.Size = new System.Drawing.Size(1355, 623);
            this.pbDetails.TabIndex = 0;
            this.pbDetails.TabStop = false;
            // 
            // tbDetails
            // 
            this.tbDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDetails.Enabled = false;
            this.tbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetails.Location = new System.Drawing.Point(51, 688);
            this.tbDetails.Multiline = true;
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.ReadOnly = true;
            this.tbDetails.Size = new System.Drawing.Size(1355, 198);
            this.tbDetails.TabIndex = 1;
            // 
            // DetailedQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 932);
            this.Controls.Add(this.tbDetails);
            this.Controls.Add(this.pbDetails);
            this.Name = "DetailedQuestion";
            this.Text = "Détails";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DetailedQuestion_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDetails;
        private System.Windows.Forms.TextBox tbDetails;
    }
}