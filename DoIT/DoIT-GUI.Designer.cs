namespace DoIT
{
    partial class DoIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoIT));
            this.shocker = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.shocker)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shocker
            // 
            this.shocker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shocker.Enabled = true;
            this.shocker.Location = new System.Drawing.Point(12, 27);
            this.shocker.Name = "shocker";
            this.shocker.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("shocker.OcxState")));
            this.shocker.Size = new System.Drawing.Size(653, 327);
            this.shocker.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeVideoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changeVideoToolStripMenuItem
            // 
            this.changeVideoToolStripMenuItem.Name = "changeVideoToolStripMenuItem";
            this.changeVideoToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.changeVideoToolStripMenuItem.Text = "Change Video";
            this.changeVideoToolStripMenuItem.Click += new System.EventHandler(this.clicked);
            // 
            // DoIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 351);
            this.Controls.Add(this.shocker);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(693, 390);
            this.Name = "DoIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoIT";
            ((System.ComponentModel.ISupportInitialize)(this.shocker)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash shocker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeVideoToolStripMenuItem;
    }
}

