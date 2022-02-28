
namespace _2048plus
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblGioco = new System.Windows.Forms.Label();
            this.lblCreatore = new System.Windows.Forms.Label();
            this.btnFacile = new System.Windows.Forms.Button();
            this.lblGioca = new System.Windows.Forms.Label();
            this.btnMedio = new System.Windows.Forms.Button();
            this.btnDifficile = new System.Windows.Forms.Button();
            this.stpBarra = new System.Windows.Forms.StatusStrip();
            this.tlsManuale = new System.Windows.Forms.ToolStripDropDownButton();
            this.comeGiocareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsInfo = new System.Windows.Forms.ToolStripDropDownButton();
            this.infoCreatoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoAPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHardcore = new System.Windows.Forms.Button();
            this.stpBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGioco
            // 
            this.lblGioco.AutoSize = true;
            this.lblGioco.BackColor = System.Drawing.Color.Transparent;
            this.lblGioco.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGioco.ForeColor = System.Drawing.Color.Orange;
            this.lblGioco.Location = new System.Drawing.Point(2, 39);
            this.lblGioco.Name = "lblGioco";
            this.lblGioco.Size = new System.Drawing.Size(137, 49);
            this.lblGioco.TabIndex = 0;
            this.lblGioco.Text = "2048+";
            // 
            // lblCreatore
            // 
            this.lblCreatore.AutoSize = true;
            this.lblCreatore.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatore.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreatore.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblCreatore.Location = new System.Drawing.Point(33, 88);
            this.lblCreatore.Name = "lblCreatore";
            this.lblCreatore.Size = new System.Drawing.Size(128, 18);
            this.lblCreatore.TabIndex = 1;
            this.lblCreatore.Text = "by Singh Sukhpreet";
            this.lblCreatore.Click += new System.EventHandler(this.lblCreatore_Click);
            // 
            // btnFacile
            // 
            this.btnFacile.BackColor = System.Drawing.Color.Gold;
            this.btnFacile.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFacile.ForeColor = System.Drawing.Color.Black;
            this.btnFacile.Location = new System.Drawing.Point(33, 187);
            this.btnFacile.Name = "btnFacile";
            this.btnFacile.Size = new System.Drawing.Size(201, 55);
            this.btnFacile.TabIndex = 2;
            this.btnFacile.Text = "FACILE";
            this.btnFacile.UseVisualStyleBackColor = false;
            this.btnFacile.Click += new System.EventHandler(this.btnFacile_Click);
            this.btnFacile.MouseEnter += new System.EventHandler(this.btnFacile_MouseEnter);
            this.btnFacile.MouseLeave += new System.EventHandler(this.btnFacile_MouseLeave);
            // 
            // lblGioca
            // 
            this.lblGioca.AutoSize = true;
            this.lblGioca.BackColor = System.Drawing.Color.Transparent;
            this.lblGioca.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGioca.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblGioca.Location = new System.Drawing.Point(12, 138);
            this.lblGioca.Name = "lblGioca";
            this.lblGioca.Size = new System.Drawing.Size(141, 46);
            this.lblGioca.TabIndex = 3;
            this.lblGioca.Text = "GIOCA!";
            // 
            // btnMedio
            // 
            this.btnMedio.BackColor = System.Drawing.Color.Orange;
            this.btnMedio.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedio.ForeColor = System.Drawing.Color.Black;
            this.btnMedio.Location = new System.Drawing.Point(91, 248);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(201, 55);
            this.btnMedio.TabIndex = 4;
            this.btnMedio.Text = "MEDIO";
            this.btnMedio.UseVisualStyleBackColor = false;
            this.btnMedio.Click += new System.EventHandler(this.btnMedio_Click);
            this.btnMedio.MouseEnter += new System.EventHandler(this.btnMedio_MouseEnter);
            this.btnMedio.MouseLeave += new System.EventHandler(this.btnMedio_MouseLeave);
            this.btnMedio.MouseHover += new System.EventHandler(this.btnMedio_MouseHover);
            // 
            // btnDifficile
            // 
            this.btnDifficile.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDifficile.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDifficile.ForeColor = System.Drawing.Color.Black;
            this.btnDifficile.Location = new System.Drawing.Point(177, 309);
            this.btnDifficile.Name = "btnDifficile";
            this.btnDifficile.Size = new System.Drawing.Size(201, 55);
            this.btnDifficile.TabIndex = 5;
            this.btnDifficile.Text = "DIFFICILE";
            this.btnDifficile.UseVisualStyleBackColor = false;
            this.btnDifficile.Click += new System.EventHandler(this.btnDifficile_Click);
            this.btnDifficile.MouseEnter += new System.EventHandler(this.btnDifficile_MouseEnter);
            this.btnDifficile.MouseLeave += new System.EventHandler(this.btnDifficile_MouseLeave);
            // 
            // stpBarra
            // 
            this.stpBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsManuale,
            this.tlsInfo});
            this.stpBarra.Location = new System.Drawing.Point(0, 464);
            this.stpBarra.Name = "stpBarra";
            this.stpBarra.Size = new System.Drawing.Size(615, 22);
            this.stpBarra.TabIndex = 6;
            this.stpBarra.Text = "statusStrip1";
            // 
            // tlsManuale
            // 
            this.tlsManuale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsManuale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comeGiocareToolStripMenuItem});
            this.tlsManuale.Image = ((System.Drawing.Image)(resources.GetObject("tlsManuale.Image")));
            this.tlsManuale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsManuale.Name = "tlsManuale";
            this.tlsManuale.Size = new System.Drawing.Size(29, 20);
            this.tlsManuale.Text = "toolStripDropDownButton1";
            // 
            // comeGiocareToolStripMenuItem
            // 
            this.comeGiocareToolStripMenuItem.Name = "comeGiocareToolStripMenuItem";
            this.comeGiocareToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.comeGiocareToolStripMenuItem.Text = "Come si gioca?";
            this.comeGiocareToolStripMenuItem.Click += new System.EventHandler(this.comeGiocareToolStripMenuItem_Click);
            // 
            // tlsInfo
            // 
            this.tlsInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoCreatoreToolStripMenuItem,
            this.infoAPPToolStripMenuItem});
            this.tlsInfo.Image = ((System.Drawing.Image)(resources.GetObject("tlsInfo.Image")));
            this.tlsInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsInfo.Name = "tlsInfo";
            this.tlsInfo.Size = new System.Drawing.Size(29, 20);
            this.tlsInfo.Text = "toolStripDropDownButton2";
            // 
            // infoCreatoreToolStripMenuItem
            // 
            this.infoCreatoreToolStripMenuItem.Name = "infoCreatoreToolStripMenuItem";
            this.infoCreatoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoCreatoreToolStripMenuItem.Text = "Info Creatore";
            this.infoCreatoreToolStripMenuItem.Click += new System.EventHandler(this.infoCreatoreToolStripMenuItem_Click);
            // 
            // infoAPPToolStripMenuItem
            // 
            this.infoAPPToolStripMenuItem.Name = "infoAPPToolStripMenuItem";
            this.infoAPPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoAPPToolStripMenuItem.Text = "Info APP";
            this.infoAPPToolStripMenuItem.Click += new System.EventHandler(this.infoAPPToolStripMenuItem_Click);
            // 
            // btnHardcore
            // 
            this.btnHardcore.BackColor = System.Drawing.Color.Black;
            this.btnHardcore.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHardcore.ForeColor = System.Drawing.Color.White;
            this.btnHardcore.Location = new System.Drawing.Point(262, 370);
            this.btnHardcore.Name = "btnHardcore";
            this.btnHardcore.Size = new System.Drawing.Size(201, 55);
            this.btnHardcore.TabIndex = 8;
            this.btnHardcore.Text = "HARDCORE";
            this.btnHardcore.UseVisualStyleBackColor = false;
            this.btnHardcore.Click += new System.EventHandler(this.button1_Click);
            this.btnHardcore.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnHardcore.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(615, 486);
            this.Controls.Add(this.btnHardcore);
            this.Controls.Add(this.stpBarra);
            this.Controls.Add(this.btnDifficile);
            this.Controls.Add(this.btnMedio);
            this.Controls.Add(this.lblGioca);
            this.Controls.Add(this.btnFacile);
            this.Controls.Add(this.lblCreatore);
            this.Controls.Add(this.lblGioco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(631, 525);
            this.MinimumSize = new System.Drawing.Size(631, 525);
            this.Name = "FrmMain";
            this.Text = "2048+";
            this.stpBarra.ResumeLayout(false);
            this.stpBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGioco;
        private System.Windows.Forms.Label lblCreatore;
        private System.Windows.Forms.Button btnFacile;
        private System.Windows.Forms.Label lblGioca;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Button btnDifficile;
        private System.Windows.Forms.StatusStrip stpBarra;
        private System.Windows.Forms.Button btnHardcore;
        private System.Windows.Forms.ToolStripDropDownButton tlsManuale;
        private System.Windows.Forms.ToolStripDropDownButton tlsInfo;
        private System.Windows.Forms.ToolStripMenuItem comeGiocareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoCreatoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoAPPToolStripMenuItem;
    }
}

