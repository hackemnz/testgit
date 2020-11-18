
namespace testgit
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
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NumberoneTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NumberLabel.Location = new System.Drawing.Point(27, 43);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(196, 26);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "Enter First Number";
            this.NumberLabel.Click += new System.EventHandler(this.NumberLabel_Click);
            // 
            // NumberoneTextBox
            // 
            this.NumberoneTextBox.Location = new System.Drawing.Point(476, 64);
            this.NumberoneTextBox.Name = "NumberoneTextBox";
            this.NumberoneTextBox.Size = new System.Drawing.Size(235, 20);
            this.NumberoneTextBox.TabIndex = 1;
            this.NumberoneTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 469);
            this.Controls.Add(this.NumberoneTextBox);
            this.Controls.Add(this.NumberLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox NumberoneTextBox;
    }
}

