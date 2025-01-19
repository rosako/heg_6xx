namespace Exam
{
    partial class QuestionListForm
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
            this.lbEnabled = new System.Windows.Forms.ListBox();
            this.lbDisabled = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEnabled
            // 
            this.lbEnabled.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnabled.FormattingEnabled = true;
            this.lbEnabled.ItemHeight = 23;
            this.lbEnabled.Location = new System.Drawing.Point(12, 52);
            this.lbEnabled.Name = "lbEnabled";
            this.lbEnabled.Size = new System.Drawing.Size(1050, 234);
            this.lbEnabled.TabIndex = 0;
            // 
            // lbDisabled
            // 
            this.lbDisabled.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisabled.FormattingEnabled = true;
            this.lbDisabled.ItemHeight = 23;
            this.lbDisabled.Location = new System.Drawing.Point(12, 347);
            this.lbDisabled.Name = "lbDisabled";
            this.lbDisabled.Size = new System.Drawing.Size(1050, 234);
            this.lbDisabled.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Questions disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Questions passées";
            // 
            // QuestionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 625);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDisabled);
            this.Controls.Add(this.lbEnabled);
            this.Name = "QuestionListForm";
            this.Text = "Liste de questions";
            this.Load += new System.EventHandler(this.QuestionListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuestionListForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEnabled;
        private System.Windows.Forms.ListBox lbDisabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}