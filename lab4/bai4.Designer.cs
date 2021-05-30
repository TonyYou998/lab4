
namespace lab4
{
    partial class bai4
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Sourcebtn = new System.Windows.Forms.Button();
            this.URLBar = new System.Windows.Forms.TextBox();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.Gobtn = new System.Windows.Forms.Button();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WebBrowser, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.976744F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.02325F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1372, 761);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Sourcebtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.URLBar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DownloadBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Gobtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1366, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Sourcebtn
            // 
            this.Sourcebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sourcebtn.Location = new System.Drawing.Point(1269, 3);
            this.Sourcebtn.Name = "Sourcebtn";
            this.Sourcebtn.Size = new System.Drawing.Size(88, 29);
            this.Sourcebtn.TabIndex = 2;
            this.Sourcebtn.Text = "Source";
            this.Sourcebtn.UseVisualStyleBackColor = true;
            this.Sourcebtn.Click += new System.EventHandler(this.Sourcebtn_Click);
            // 
            // URLBar
            // 
            this.URLBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.URLBar.Location = new System.Drawing.Point(3, 3);
            this.URLBar.Name = "URLBar";
            this.URLBar.Size = new System.Drawing.Size(1090, 30);
            this.URLBar.TabIndex = 3;
            this.URLBar.Text = "http://google.com";
            this.URLBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.URLBar.TextChanged += new System.EventHandler(this.URLBar_TextChanged);
            this.URLBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlbar_enter);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadBtn.Location = new System.Drawing.Point(1169, 3);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(75, 29);
            this.DownloadBtn.TabIndex = 1;
            this.DownloadBtn.Text = "Down";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // Gobtn
            // 
            this.Gobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gobtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gobtn.Location = new System.Drawing.Point(1099, 3);
            this.Gobtn.Name = "Gobtn";
            this.Gobtn.Size = new System.Drawing.Size(47, 32);
            this.Gobtn.TabIndex = 0;
            this.Gobtn.Text = "Go";
            this.Gobtn.UseVisualStyleBackColor = true;
            this.Gobtn.Click += new System.EventHandler(this.Gobtn_Click);
            // 
            // WebBrowser
            // 
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(3, 56);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(1366, 702);
            this.WebBrowser.TabIndex = 1;
            // 
            // bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "bai4";
            this.Text = "bai4";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Gobtn;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.Button Sourcebtn;
        private System.Windows.Forms.TextBox URLBar;
        private System.Windows.Forms.WebBrowser WebBrowser;
    }
}