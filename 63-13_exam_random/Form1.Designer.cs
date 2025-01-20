namespace Exam
{
    partial class Form1
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
            this.btnLancer = new System.Windows.Forms.Button();
            this.gbChoix1 = new System.Windows.Forms.GroupBox();
            this.pbChoix1 = new System.Windows.Forms.PictureBox();
            this.btnChoix1 = new System.Windows.Forms.Button();
            this.tbDesc1 = new System.Windows.Forms.TextBox();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblChoix1 = new System.Windows.Forms.Label();
            this.gbChoix2 = new System.Windows.Forms.GroupBox();
            this.pbChoix2 = new System.Windows.Forms.PictureBox();
            this.btnChoix2 = new System.Windows.Forms.Button();
            this.tbDesc2 = new System.Windows.Forms.TextBox();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblChoix2 = new System.Windows.Forms.Label();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbChoix1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoix1)).BeginInit();
            this.gbChoix2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoix2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLancer
            // 
            this.btnLancer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancer.Location = new System.Drawing.Point(551, 1078);
            this.btnLancer.Margin = new System.Windows.Forms.Padding(4);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(587, 79);
            this.btnLancer.TabIndex = 0;
            this.btnLancer.Text = "Lancer";
            this.btnLancer.UseVisualStyleBackColor = true;
            this.btnLancer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLancer_MouseClick);
            // 
            // gbChoix1
            // 
            this.gbChoix1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbChoix1.Controls.Add(this.pbChoix1);
            this.gbChoix1.Controls.Add(this.btnChoix1);
            this.gbChoix1.Controls.Add(this.tbDesc1);
            this.gbChoix1.Controls.Add(this.lblTitle1);
            this.gbChoix1.Controls.Add(this.lblChoix1);
            this.gbChoix1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChoix1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gbChoix1.Location = new System.Drawing.Point(16, 2);
            this.gbChoix1.Margin = new System.Windows.Forms.Padding(4);
            this.gbChoix1.Name = "gbChoix1";
            this.gbChoix1.Padding = new System.Windows.Forms.Padding(4);
            this.gbChoix1.Size = new System.Drawing.Size(787, 1017);
            this.gbChoix1.TabIndex = 1;
            this.gbChoix1.TabStop = false;
            this.gbChoix1.Text = "Choix 1";
            // 
            // pbChoix1
            // 
            this.pbChoix1.Location = new System.Drawing.Point(28, 571);
            this.pbChoix1.Margin = new System.Windows.Forms.Padding(4);
            this.pbChoix1.Name = "pbChoix1";
            this.pbChoix1.Size = new System.Drawing.Size(721, 362);
            this.pbChoix1.TabIndex = 4;
            this.pbChoix1.TabStop = false;
            this.pbChoix1.Click += new System.EventHandler(this.pbChoix1_Click);
            // 
            // btnChoix1
            // 
            this.btnChoix1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoix1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnChoix1.Location = new System.Drawing.Point(288, 972);
            this.btnChoix1.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoix1.Name = "btnChoix1";
            this.btnChoix1.Size = new System.Drawing.Size(160, 37);
            this.btnChoix1.TabIndex = 3;
            this.btnChoix1.Text = "Selectionner";
            this.btnChoix1.UseVisualStyleBackColor = true;
            this.btnChoix1.Click += new System.EventHandler(this.btnChoix1_Click);
            // 
            // tbDesc1
            // 
            this.tbDesc1.Enabled = false;
            this.tbDesc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc1.Location = new System.Drawing.Point(28, 393);
            this.tbDesc1.Margin = new System.Windows.Forms.Padding(4);
            this.tbDesc1.Multiline = true;
            this.tbDesc1.Name = "tbDesc1";
            this.tbDesc1.ReadOnly = true;
            this.tbDesc1.Size = new System.Drawing.Size(720, 146);
            this.tbDesc1.TabIndex = 2;
            this.tbDesc1.TextChanged += new System.EventHandler(this.tbDesc1_TextChanged);
            this.tbDesc1.DoubleClick += new System.EventHandler(this.tbDesc1_DoubleClick);
            // 
            // lblTitle1
            // 
            this.lblTitle1.Location = new System.Drawing.Point(28, 332);
            this.lblTitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(721, 38);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "--";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChoix1
            // 
            this.lblChoix1.Font = new System.Drawing.Font("Segoe UI Semibold", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoix1.Location = new System.Drawing.Point(28, 54);
            this.lblChoix1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoix1.Name = "lblChoix1";
            this.lblChoix1.Size = new System.Drawing.Size(721, 295);
            this.lblChoix1.TabIndex = 0;
            this.lblChoix1.Text = "--";
            this.lblChoix1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChoix1.Click += new System.EventHandler(this.label1_Click);
            this.lblChoix1.MouseEnter += new System.EventHandler(this.lblChoix1_MouseEnter);
            this.lblChoix1.MouseLeave += new System.EventHandler(this.lblChoix1_MouseLeave);
            // 
            // gbChoix2
            // 
            this.gbChoix2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gbChoix2.Controls.Add(this.pbChoix2);
            this.gbChoix2.Controls.Add(this.btnChoix2);
            this.gbChoix2.Controls.Add(this.tbDesc2);
            this.gbChoix2.Controls.Add(this.lblTitle2);
            this.gbChoix2.Controls.Add(this.lblChoix2);
            this.gbChoix2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChoix2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gbChoix2.Location = new System.Drawing.Point(903, 2);
            this.gbChoix2.Margin = new System.Windows.Forms.Padding(4);
            this.gbChoix2.Name = "gbChoix2";
            this.gbChoix2.Padding = new System.Windows.Forms.Padding(4);
            this.gbChoix2.Size = new System.Drawing.Size(771, 1017);
            this.gbChoix2.TabIndex = 2;
            this.gbChoix2.TabStop = false;
            this.gbChoix2.Text = "Choix2";
            // 
            // pbChoix2
            // 
            this.pbChoix2.Location = new System.Drawing.Point(39, 571);
            this.pbChoix2.Margin = new System.Windows.Forms.Padding(4);
            this.pbChoix2.Name = "pbChoix2";
            this.pbChoix2.Size = new System.Drawing.Size(704, 362);
            this.pbChoix2.TabIndex = 4;
            this.pbChoix2.TabStop = false;
            this.pbChoix2.Click += new System.EventHandler(this.pbChoix2_Click);
            // 
            // btnChoix2
            // 
            this.btnChoix2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoix2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnChoix2.Location = new System.Drawing.Point(284, 972);
            this.btnChoix2.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoix2.Name = "btnChoix2";
            this.btnChoix2.Size = new System.Drawing.Size(160, 37);
            this.btnChoix2.TabIndex = 3;
            this.btnChoix2.Text = "Selectionner";
            this.btnChoix2.UseVisualStyleBackColor = true;
            this.btnChoix2.Click += new System.EventHandler(this.btnChoix2_Click);
            // 
            // tbDesc2
            // 
            this.tbDesc2.Enabled = false;
            this.tbDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc2.Location = new System.Drawing.Point(39, 393);
            this.tbDesc2.Margin = new System.Windows.Forms.Padding(4);
            this.tbDesc2.Multiline = true;
            this.tbDesc2.Name = "tbDesc2";
            this.tbDesc2.ReadOnly = true;
            this.tbDesc2.Size = new System.Drawing.Size(703, 146);
            this.tbDesc2.TabIndex = 2;
            this.tbDesc2.TextChanged += new System.EventHandler(this.tbDesc2_TextChanged);
            this.tbDesc2.DoubleClick += new System.EventHandler(this.tbDesc2_DoubleClick);
            // 
            // lblTitle2
            // 
            this.lblTitle2.Location = new System.Drawing.Point(39, 332);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(704, 38);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "--";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChoix2
            // 
            this.lblChoix2.Font = new System.Drawing.Font("Segoe UI Semibold", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoix2.Location = new System.Drawing.Point(47, 54);
            this.lblChoix2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoix2.Name = "lblChoix2";
            this.lblChoix2.Size = new System.Drawing.Size(696, 295);
            this.lblChoix2.TabIndex = 0;
            this.lblChoix2.Text = "--";
            this.lblChoix2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChoix2.Click += new System.EventHandler(this.lblChoix2_Click);
            this.lblChoix2.MouseEnter += new System.EventHandler(this.lblChoix2_MouseEnter);
            this.lblChoix2.MouseLeave += new System.EventHandler(this.lblChoix2_MouseLeave);
            // 
            // lblQuestions
            // 
            this.lblQuestions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblQuestions.Location = new System.Drawing.Point(61, 1145);
            this.lblQuestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(341, 28);
            this.lblQuestions.TabIndex = 3;
            this.lblQuestions.Text = "  ";
            this.lblQuestions.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(-1, 1143);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1977, 1170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.gbChoix2);
            this.Controls.Add(this.gbChoix1);
            this.Controls.Add(this.btnLancer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "63-13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gbChoix1.ResumeLayout(false);
            this.gbChoix1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoix1)).EndInit();
            this.gbChoix2.ResumeLayout(false);
            this.gbChoix2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoix2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.GroupBox gbChoix1;
        private System.Windows.Forms.GroupBox gbChoix2;
        private System.Windows.Forms.Label lblChoix1;
        private System.Windows.Forms.Label lblChoix2;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TextBox tbDesc1;
        private System.Windows.Forms.TextBox tbDesc2;
        private System.Windows.Forms.Button btnChoix1;
        private System.Windows.Forms.Button btnChoix2;
        private System.Windows.Forms.PictureBox pbChoix1;
        private System.Windows.Forms.PictureBox pbChoix2;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Button button1;
    }
}

