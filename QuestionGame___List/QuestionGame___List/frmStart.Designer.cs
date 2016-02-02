namespace QuestionGame___List
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.btnPlay = new System.Windows.Forms.Button();
            this.wmpTheme = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wmpTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnPlay.Location = new System.Drawing.Point(152, 183);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(173, 51);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Click To Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // wmpTheme
            // 
            this.wmpTheme.Enabled = true;
            this.wmpTheme.Location = new System.Drawing.Point(12, 230);
            this.wmpTheme.Name = "wmpTheme";
            this.wmpTheme.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpTheme.OcxState")));
            this.wmpTheme.Size = new System.Drawing.Size(33, 33);
            this.wmpTheme.TabIndex = 1;
            this.wmpTheme.Visible = false;
            this.wmpTheme.Enter += new System.EventHandler(this.wmpTheme_Enter);
            // 
            // frmStart
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.wmpTheme);
            this.Controls.Add(this.btnPlay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Name = "frmStart";
            this.Text = "Welcome To The Question Game";
            this.Activated += new System.EventHandler(this.frmStart_Activated);
            this.Load += new System.EventHandler(this.frmStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpTheme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private AxWMPLib.AxWindowsMediaPlayer wmpTheme;

    }
}

