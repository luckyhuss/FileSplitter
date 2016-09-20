namespace FileSplitter
{
    partial class FormMain
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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.numericUpDownLineNo = new System.Windows.Forms.NumericUpDown();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineNo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 12);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(446, 80);
            this.textBoxMessage.TabIndex = 0;
            // 
            // buttonSplit
            // 
            this.buttonSplit.Location = new System.Drawing.Point(383, 115);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(75, 23);
            this.buttonSplit.TabIndex = 1;
            this.buttonSplit.Text = "Split";
            this.buttonSplit.UseVisualStyleBackColor = true;
            this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click);
            // 
            // numericUpDownLineNo
            // 
            this.numericUpDownLineNo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLineNo.Location = new System.Drawing.Point(257, 118);
            this.numericUpDownLineNo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownLineNo.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLineNo.Name = "numericUpDownLineNo";
            this.numericUpDownLineNo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLineNo.TabIndex = 2;
            this.numericUpDownLineNo.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(176, 115);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse ..";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(12, 117);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.ReadOnly = true;
            this.textBoxFilename.Size = new System.Drawing.Size(158, 20);
            this.textBoxFilename.TabIndex = 4;
            this.textBoxFilename.Text = "-- no file --";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 212);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.numericUpDownLineNo);
            this.Controls.Add(this.buttonSplit);
            this.Controls.Add(this.textBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "File Splitter by Lines";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSplit;
        private System.Windows.Forms.NumericUpDown numericUpDownLineNo;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxFilename;
    }
}

