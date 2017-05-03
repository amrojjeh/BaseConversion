namespace BaseConverter
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblConvertedNum = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(88, 110);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(63, 28);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(129, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblConvertedNum
            // 
            this.lblConvertedNum.AutoSize = true;
            this.lblConvertedNum.Location = new System.Drawing.Point(76, 188);
            this.lblConvertedNum.Name = "lblConvertedNum";
            this.lblConvertedNum.Size = new System.Drawing.Size(96, 13);
            this.lblConvertedNum.TabIndex = 4;
            this.lblConvertedNum.Text = "Converted Number";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(63, 68);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(126, 20);
            this.txtBase.TabIndex = 5;
            this.txtBase.Text = "Enter Base less than 11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblConvertedNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblConvertedNum;
        private System.Windows.Forms.TextBox txtBase;
    }
}

