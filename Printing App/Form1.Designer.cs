namespace Printing_App
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnNewWindow = new System.Windows.Forms.Button();
            this.lboxColour = new System.Windows.Forms.ListBox();
            this.lboxResult = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbTerms = new System.Windows.Forms.CheckBox();
            this.tbStudentNum = new System.Windows.Forms.TextBox();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(368, 72);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(100, 30);
            this.btnProcess.TabIndex = 31;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnNewWindow
            // 
            this.btnNewWindow.Location = new System.Drawing.Point(368, 111);
            this.btnNewWindow.Name = "btnNewWindow";
            this.btnNewWindow.Size = new System.Drawing.Size(100, 54);
            this.btnNewWindow.TabIndex = 30;
            this.btnNewWindow.Text = "Total in a new window";
            this.btnNewWindow.UseVisualStyleBackColor = true;
            this.btnNewWindow.Click += new System.EventHandler(this.btnNewWindow_Click);
            // 
            // lboxColour
            // 
            this.lboxColour.FormattingEnabled = true;
            this.lboxColour.Location = new System.Drawing.Point(155, 203);
            this.lboxColour.Name = "lboxColour";
            this.lboxColour.Size = new System.Drawing.Size(108, 82);
            this.lboxColour.TabIndex = 29;
            // 
            // lboxResult
            // 
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.Location = new System.Drawing.Point(519, 74);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(195, 225);
            this.lboxResult.TabIndex = 28;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(368, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(368, 171);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbTerms
            // 
            this.cbTerms.AutoSize = true;
            this.cbTerms.Location = new System.Drawing.Point(155, 313);
            this.cbTerms.Name = "cbTerms";
            this.cbTerms.Size = new System.Drawing.Size(177, 17);
            this.cbTerms.TabIndex = 25;
            this.cbTerms.Text = "I have read the terms conditions";
            this.cbTerms.UseVisualStyleBackColor = true;
            this.cbTerms.CheckedChanged += new System.EventHandler(this.cbTerms_CheckedChanged);
            // 
            // tbStudentNum
            // 
            this.tbStudentNum.Location = new System.Drawing.Point(155, 113);
            this.tbStudentNum.Name = "tbStudentNum";
            this.tbStudentNum.Size = new System.Drawing.Size(108, 20);
            this.tbStudentNum.TabIndex = 24;
            // 
            // tbPages
            // 
            this.tbPages.Location = new System.Drawing.Point(155, 151);
            this.tbPages.Name = "tbPages";
            this.tbPages.Size = new System.Drawing.Size(108, 20);
            this.tbPages.TabIndex = 23;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(155, 78);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(108, 20);
            this.tbSurname.TabIndex = 22;
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Location = new System.Drawing.Point(33, 120);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(87, 13);
            this.lblStudentNum.TabIndex = 21;
            this.lblStudentNum.Text = "Student Number:";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(33, 155);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(66, 13);
            this.lblPages.TabIndex = 20;
            this.lblPages.Text = "Nr. of Pages";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(33, 189);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(40, 13);
            this.lblColour.TabIndex = 19;
            this.lblColour.Text = "Colour:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(33, 85);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 18;
            this.lblSurname.Text = "Surname:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(206, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 29);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Printing App";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 408);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnNewWindow);
            this.Controls.Add(this.lboxColour);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbTerms);
            this.Controls.Add(this.tbStudentNum);
            this.Controls.Add(this.tbPages);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lblStudentNum);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Printing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnNewWindow;
        private System.Windows.Forms.ListBox lboxColour;
        private System.Windows.Forms.ListBox lboxResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbTerms;
        private System.Windows.Forms.TextBox tbStudentNum;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblStudentNum;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

