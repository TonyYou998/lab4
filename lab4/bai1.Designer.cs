
namespace lab4
{
    partial class bai1
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
            this.URLBar = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // URLBar
            // 
            this.URLBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.URLBar.Location = new System.Drawing.Point(12, 9);
            this.URLBar.Name = "URLBar";
            this.URLBar.Size = new System.Drawing.Size(726, 30);
            this.URLBar.TabIndex = 4;
            this.URLBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.URLBar.TextChanged += new System.EventHandler(this.URLBar_TextChanged);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(771, 9);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(149, 30);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(984, 465);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 576);
            this.Controls.Add(this.URLBar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnGet);
            this.Name = "bai1";
            this.Text = "bai1";
            this.Load += new System.EventHandler(this.bai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLBar;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}