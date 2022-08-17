namespace Printing_App
{
    partial class frmShow
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPrintCharge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(65, 73);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 22);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPrintCharge
            // 
            this.lblPrintCharge.AutoSize = true;
            this.lblPrintCharge.Location = new System.Drawing.Point(70, 33);
            this.lblPrintCharge.Name = "lblPrintCharge";
            this.lblPrintCharge.Size = new System.Drawing.Size(72, 13);
            this.lblPrintCharge.TabIndex = 2;
            this.lblPrintCharge.Text = "lblPrintCharge";
            this.lblPrintCharge.Click += new System.EventHandler(this.lblPrintCharge_Click);
            // 
            // frmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 148);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPrintCharge);
            this.Name = "frmShow";
            this.Text = "frmShow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblPrintCharge;
    }
}