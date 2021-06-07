
namespace lab4
{
    partial class bai3
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
            this.button_GET = new System.Windows.Forms.Button();
            this.RichTextBox_URL = new System.Windows.Forms.RichTextBox();
            this.RichTextBox_Content = new System.Windows.Forms.RichTextBox();
            this.RichTextBox_Dir = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_GET
            // 
            this.button_GET.Location = new System.Drawing.Point(601, 27);
            this.button_GET.Name = "button_GET";
            this.button_GET.Size = new System.Drawing.Size(126, 76);
            this.button_GET.TabIndex = 0;
            this.button_GET.Text = "GET";
            this.button_GET.UseVisualStyleBackColor = true;
            this.button_GET.Click += new System.EventHandler(this.button_GET_Click);
            // 
            // RichTextBox_URL
            // 
            this.RichTextBox_URL.Location = new System.Drawing.Point(12, 27);
            this.RichTextBox_URL.Multiline = false;
            this.RichTextBox_URL.Name = "RichTextBox_URL";
            this.RichTextBox_URL.Size = new System.Drawing.Size(553, 28);
            this.RichTextBox_URL.TabIndex = 1;
            this.RichTextBox_URL.Text = "";
            // 
            // RichTextBox_Content
            // 
            this.RichTextBox_Content.Location = new System.Drawing.Point(12, 120);
            this.RichTextBox_Content.Name = "RichTextBox_Content";
            this.RichTextBox_Content.ReadOnly = true;
            this.RichTextBox_Content.Size = new System.Drawing.Size(715, 301);
            this.RichTextBox_Content.TabIndex = 2;
            this.RichTextBox_Content.Text = "";
            // 
            // RichTextBox_Dir
            // 
            this.RichTextBox_Dir.Location = new System.Drawing.Point(12, 75);
            this.RichTextBox_Dir.Multiline = false;
            this.RichTextBox_Dir.Name = "RichTextBox_Dir";
            this.RichTextBox_Dir.Size = new System.Drawing.Size(553, 28);
            this.RichTextBox_Dir.TabIndex = 3;
            this.RichTextBox_Dir.Text = "";
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.RichTextBox_Dir);
            this.Controls.Add(this.RichTextBox_Content);
            this.Controls.Add(this.RichTextBox_URL);
            this.Controls.Add(this.button_GET);
            this.Name = "Bai03";
            this.Text = "Bài 03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_GET;
        private System.Windows.Forms.RichTextBox RichTextBox_URL;
        private System.Windows.Forms.RichTextBox RichTextBox_Content;
        private System.Windows.Forms.RichTextBox RichTextBox_Dir;
    }
}