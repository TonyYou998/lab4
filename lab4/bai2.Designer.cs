
namespace lab4
{
    partial class bai2
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
            this.btnPost = new System.Windows.Forms.Button();
            this.htmlRes = new System.Windows.Forms.RichTextBox();
            this.messBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // URLBar
            // 
            this.URLBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.URLBar.Location = new System.Drawing.Point(12, 12);
            this.URLBar.Name = "URLBar";
            this.URLBar.Size = new System.Drawing.Size(760, 30);
            this.URLBar.TabIndex = 5;
            this.URLBar.Text = "http://www.contoso.com/PostAccepter.aspx";
            this.URLBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(812, 12);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(141, 75);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // htmlRes
            // 
            this.htmlRes.Location = new System.Drawing.Point(11, 122);
            this.htmlRes.Name = "htmlRes";
            this.htmlRes.Size = new System.Drawing.Size(961, 449);
            this.htmlRes.TabIndex = 7;
            this.htmlRes.Text = "";
            // 
            // messBox
            // 
            this.messBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.messBox.Location = new System.Drawing.Point(11, 57);
            this.messBox.Name = "messBox";
            this.messBox.Size = new System.Drawing.Size(760, 30);
            this.messBox.TabIndex = 8;
            this.messBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 594);
            this.Controls.Add(this.messBox);
            this.Controls.Add(this.htmlRes);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.URLBar);
            this.Name = "bai2";
            this.Text = "bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLBar;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.RichTextBox htmlRes;
        private System.Windows.Forms.TextBox messBox;
    }
}