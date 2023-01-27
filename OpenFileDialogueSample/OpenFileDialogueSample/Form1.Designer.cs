namespace OpenFileDialogueSample
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PhotoGallary = new System.Windows.Forms.FlowLayoutPanel();
            this.BrowseMultipleButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PhotoGallary
            // 
            this.PhotoGallary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PhotoGallary.Location = new System.Drawing.Point(13, 112);
            this.PhotoGallary.Margin = new System.Windows.Forms.Padding(4);
            this.PhotoGallary.Name = "PhotoGallary";
            this.PhotoGallary.Size = new System.Drawing.Size(660, 314);
            this.PhotoGallary.TabIndex = 7;
            // 
            // BrowseMultipleButton
            // 
            this.BrowseMultipleButton.Location = new System.Drawing.Point(500, 64);
            this.BrowseMultipleButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseMultipleButton.Name = "BrowseMultipleButton";
            this.BrowseMultipleButton.Size = new System.Drawing.Size(173, 33);
            this.BrowseMultipleButton.TabIndex = 6;
            this.BrowseMultipleButton.Text = "Browse Multiple Files";
            this.BrowseMultipleButton.UseVisualStyleBackColor = true;
            this.BrowseMultipleButton.Click += new System.EventHandler(this.BrowseMultipleButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 22);
            this.textBox1.TabIndex = 5;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(500, 24);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(173, 33);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 451);
            this.Controls.Add(this.PhotoGallary);
            this.Controls.Add(this.BrowseMultipleButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BrowseButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel PhotoGallary;
        private System.Windows.Forms.Button BrowseMultipleButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BrowseButton;
    }
}

