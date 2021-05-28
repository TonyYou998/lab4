
namespace lab4
{
    partial class SourceHTMLShow
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
            this.src_txt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // src_txt
            // 
            this.src_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.src_txt.Location = new System.Drawing.Point(12, 58);
            this.src_txt.Name = "src_txt";
            this.src_txt.Size = new System.Drawing.Size(1255, 677);
            this.src_txt.TabIndex = 0;
            this.src_txt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source code";
            // 
            // SourceHTMLShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 747);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.src_txt);
            this.Name = "SourceHTMLShow";
            this.Text = "SourceHTMLShow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox src_txt;
        private System.Windows.Forms.Label label1;
    }
}