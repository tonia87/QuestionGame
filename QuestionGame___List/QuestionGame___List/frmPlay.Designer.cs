namespace QuestionGame___List
{
    partial class frmPlay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlay));
            this.btnGetNext = new System.Windows.Forms.Button();
            this.cbxDifficulty = new System.Windows.Forms.ComboBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.wmpGameResponse = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbxTimer = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpGameResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetNext
            // 
            this.btnGetNext.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnGetNext.Location = new System.Drawing.Point(554, 369);
            this.btnGetNext.Name = "btnGetNext";
            this.btnGetNext.Size = new System.Drawing.Size(158, 36);
            this.btnGetNext.TabIndex = 0;
            this.btnGetNext.Text = "Επόμενο -->";
            this.btnGetNext.UseVisualStyleBackColor = true;
            this.btnGetNext.Click += new System.EventHandler(this.btnGetNext_Click);
            // 
            // cbxDifficulty
            // 
            this.cbxDifficulty.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbxDifficulty.FormattingEnabled = true;
            this.cbxDifficulty.Location = new System.Drawing.Point(12, 25);
            this.cbxDifficulty.Name = "cbxDifficulty";
            this.cbxDifficulty.Size = new System.Drawing.Size(121, 26);
            this.cbxDifficulty.TabIndex = 1;
            // 
            // cbxType
            // 
            this.cbxType.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(12, 75);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 26);
            this.cbxType.TabIndex = 2;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn1.Location = new System.Drawing.Point(53, 166);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 50);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn2.Location = new System.Drawing.Point(313, 166);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 50);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn3.Location = new System.Drawing.Point(53, 262);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 50);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn4.Location = new System.Drawing.Point(313, 262);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(150, 50);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "button4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblLevel.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblLevel.Location = new System.Drawing.Point(9, 6);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(61, 16);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "ΕΠΙΠΕΔΟ";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.BackColor = System.Drawing.Color.Transparent;
            this.lblTheme.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTheme.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTheme.Location = new System.Drawing.Point(9, 54);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(98, 16);
            this.lblTheme.TabIndex = 8;
            this.lblTheme.Text = "ΘΕΜΑΤΟΛΟΓΙΑ";
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.BackColor = System.Drawing.Color.Transparent;
            this.lblQuote.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblQuote.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblQuote.Location = new System.Drawing.Point(16, 125);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(66, 26);
            this.lblQuote.TabIndex = 9;
            this.lblQuote.Text = "label3";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMessage.Location = new System.Drawing.Point(30, 381);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(58, 26);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "label4";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoEllipsis = true;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTotal.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotal.Location = new System.Drawing.Point(172, 75);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 18);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "label5";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScore.AutoEllipsis = true;
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblScore.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblScore.Location = new System.Drawing.Point(551, 75);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(44, 18);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "label6";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(166, 25);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(546, 41);
            this.pgb.TabIndex = 13;
            // 
            // wmpGameResponse
            // 
            this.wmpGameResponse.Enabled = true;
            this.wmpGameResponse.Location = new System.Drawing.Point(679, 330);
            this.wmpGameResponse.Name = "wmpGameResponse";
            this.wmpGameResponse.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpGameResponse.OcxState")));
            this.wmpGameResponse.Size = new System.Drawing.Size(33, 33);
            this.wmpGameResponse.TabIndex = 14;
            this.wmpGameResponse.Visible = false;
            // 
            // pbxTimer
            // 
            this.pbxTimer.Location = new System.Drawing.Point(554, 166);
            this.pbxTimer.Name = "pbxTimer";
            this.pbxTimer.Size = new System.Drawing.Size(138, 119);
            this.pbxTimer.TabIndex = 15;
            this.pbxTimer.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Black;
            this.lblTimer.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(618, 229);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(74, 56);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = ":30";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 1000;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnHelp.ForeColor = System.Drawing.Color.Red;
            this.btnHelp.Location = new System.Drawing.Point(554, 288);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(138, 23);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.Text = "Hint";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmPlay
            // 
            this.AcceptButton = this.btnGetNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 417);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pbxTimer);
            this.Controls.Add(this.wmpGameResponse);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.cbxDifficulty);
            this.Controls.Add(this.btnGetNext);
            this.Name = "frmPlay";
            this.Text = "Game Running";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlay_FormClosing);
            this.Load += new System.EventHandler(this.frmPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpGameResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetNext;
        private System.Windows.Forms.ComboBox cbxDifficulty;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ProgressBar pgb;
        private AxWMPLib.AxWindowsMediaPlayer wmpGameResponse;
        private System.Windows.Forms.PictureBox pbxTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Button btnHelp;
    }
}