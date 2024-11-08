namespace FormRegistration
{
    partial class FrmFileName
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
            this.textFileName = new System.Windows.Forms.TextBox();
            this.btnokay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(285, 172);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(244, 20);
            this.textFileName.TabIndex = 5;
            // 
            // btnokay
            // 
            this.btnokay.Location = new System.Drawing.Point(345, 231);
            this.btnokay.Name = "btnokay";
            this.btnokay.Size = new System.Drawing.Size(117, 29);
            this.btnokay.TabIndex = 4;
            this.btnokay.Text = "Okay";
            this.btnokay.UseVisualStyleBackColor = true;
            this.btnokay.Click += new System.EventHandler(this.btnokay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(290, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter File Name:";
            // 
            // FrmFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.btnokay);
            this.Controls.Add(this.label1);
            this.Name = "FrmFileName";
            this.Text = "FrmFileName";
            this.Load += new System.EventHandler(this.FrmFileName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Button btnokay;
        private System.Windows.Forms.Label label1;
    }
}