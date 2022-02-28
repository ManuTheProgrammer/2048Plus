
namespace _2048plus
{
    partial class FrmGioco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGioco));
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.flpGriglia = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGame = new System.Windows.Forms.Button();
            this.lblScoreAttuale = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.btnSCOREBOARD = new System.Windows.Forms.Button();
            this.btnModalità = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Orange;
            this.lblHighScore.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighScore.Location = new System.Drawing.Point(22, 22);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(119, 25);
            this.lblHighScore.TabIndex = 0;
            this.lblHighScore.Text = "High Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Orange;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(147, 22);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(32, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "xx";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(203, 22);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(0, 15);
            this.lblMode.TabIndex = 2;
            // 
            // flpGriglia
            // 
            this.flpGriglia.Location = new System.Drawing.Point(22, 125);
            this.flpGriglia.Name = "flpGriglia";
            this.flpGriglia.Size = new System.Drawing.Size(400, 400);
            this.flpGriglia.TabIndex = 3;
            this.flpGriglia.Paint += new System.Windows.Forms.PaintEventHandler(this.flpGriglia_Paint);
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGame.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGame.Location = new System.Drawing.Point(306, 45);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(116, 58);
            this.btnGame.TabIndex = 4;
            this.btnGame.Text = "New Game";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            this.btnGame.MouseEnter += new System.EventHandler(this.btnGame_MouseEnter);
            this.btnGame.MouseLeave += new System.EventHandler(this.btnGame_MouseLeave);
            // 
            // lblScoreAttuale
            // 
            this.lblScoreAttuale.AutoSize = true;
            this.lblScoreAttuale.BackColor = System.Drawing.Color.Orange;
            this.lblScoreAttuale.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScoreAttuale.Location = new System.Drawing.Point(22, 61);
            this.lblScoreAttuale.Name = "lblScoreAttuale";
            this.lblScoreAttuale.Size = new System.Drawing.Size(69, 25);
            this.lblScoreAttuale.TabIndex = 5;
            this.lblScoreAttuale.Text = "Score:";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Orange;
            this.lblScore2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore2.Location = new System.Drawing.Point(97, 61);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(32, 25);
            this.lblScore2.TabIndex = 6;
            this.lblScore2.Text = "xx";
            // 
            // btnSCOREBOARD
            // 
            this.btnSCOREBOARD.BackColor = System.Drawing.Color.Orange;
            this.btnSCOREBOARD.Enabled = false;
            this.btnSCOREBOARD.ForeColor = System.Drawing.Color.Orange;
            this.btnSCOREBOARD.Location = new System.Drawing.Point(12, 12);
            this.btnSCOREBOARD.Name = "btnSCOREBOARD";
            this.btnSCOREBOARD.Size = new System.Drawing.Size(233, 90);
            this.btnSCOREBOARD.TabIndex = 7;
            this.btnSCOREBOARD.UseVisualStyleBackColor = false;
            // 
            // btnModalità
            // 
            this.btnModalità.Enabled = false;
            this.btnModalità.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModalità.Location = new System.Drawing.Point(279, 12);
            this.btnModalità.Name = "btnModalità";
            this.btnModalità.Size = new System.Drawing.Size(143, 35);
            this.btnModalità.TabIndex = 8;
            this.btnModalità.Text = "xx";
            this.btnModalità.UseVisualStyleBackColor = true;
            // 
            // FrmGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(444, 561);
            this.Controls.Add(this.btnModalità);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScoreAttuale);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.flpGriglia);
            this.Controls.Add(this.btnSCOREBOARD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(460, 600);
            this.MinimumSize = new System.Drawing.Size(460, 600);
            this.Name = "FrmGioco";
            this.Text = "2048+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGioco_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGioco_FormClosed);
            this.Load += new System.EventHandler(this.FrmGioco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMode;
        public System.Windows.Forms.FlowLayoutPanel flpGriglia;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Label lblScoreAttuale;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Button btnSCOREBOARD;
        private System.Windows.Forms.Button btnModalità;
    }
}