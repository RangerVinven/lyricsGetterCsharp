
namespace lyricsGetter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.songAndArtistTxt = new System.Windows.Forms.TextBox();
            this.getLyricsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.directoryTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // songAndArtistTxt
            // 
            this.songAndArtistTxt.Location = new System.Drawing.Point(105, 73);
            this.songAndArtistTxt.Multiline = true;
            this.songAndArtistTxt.Name = "songAndArtistTxt";
            this.songAndArtistTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.songAndArtistTxt.Size = new System.Drawing.Size(256, 316);
            this.songAndArtistTxt.TabIndex = 0;
            // 
            // getLyricsBtn
            // 
            this.getLyricsBtn.Location = new System.Drawing.Point(498, 211);
            this.getLyricsBtn.Name = "getLyricsBtn";
            this.getLyricsBtn.Size = new System.Drawing.Size(75, 23);
            this.getLyricsBtn.TabIndex = 2;
            this.getLyricsBtn.Text = "Get Lyrics";
            this.getLyricsBtn.UseVisualStyleBackColor = true;
            this.getLyricsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Song Name and Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save Directory";
            // 
            // directoryTxt
            // 
            this.directoryTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.directoryTxt.Location = new System.Drawing.Point(423, 73);
            this.directoryTxt.Name = "directoryTxt";
            this.directoryTxt.Size = new System.Drawing.Size(245, 20);
            this.directoryTxt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directoryTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getLyricsBtn);
            this.Controls.Add(this.songAndArtistTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lyrics Getter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox songAndArtistTxt;
        private System.Windows.Forms.Button getLyricsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox directoryTxt;
    }
}

