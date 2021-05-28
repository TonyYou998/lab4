
namespace lab4
{
    partial class Downloader
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
            this.progress = new System.Windows.Forms.ProgressBar();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 12);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(834, 31);
            this.progress.TabIndex = 0;
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(15, 60);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(831, 528);
            this.Log.TabIndex = 2;
            this.Log.Text = "";
            // 
            // Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 600);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.progress);
            this.Name = "Downloader";
            this.Text = "Downloader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.RichTextBox Log;
    }
}