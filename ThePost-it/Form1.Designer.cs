namespace ThePost_it
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.itButton = new System.Windows.Forms.RadioButton();
            this.cursorButton = new System.Windows.Forms.RadioButton();
            this.panelDisigner = new ThePost_it.PanelDisigner();
            this.menu.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1251, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.itButton);
            this.panel.Controls.Add(this.cursorButton);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(45, 472);
            this.panel.TabIndex = 1;
            // 
            // itButton
            // 
            this.itButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.itButton.AutoSize = true;
            this.itButton.BackColor = System.Drawing.Color.Transparent;
            this.itButton.Image = global::ThePost_it.Properties.Resources.postit;
            this.itButton.Location = new System.Drawing.Point(3, 49);
            this.itButton.Name = "itButton";
            this.itButton.Size = new System.Drawing.Size(40, 40);
            this.itButton.TabIndex = 3;
            this.itButton.TabStop = true;
            this.itButton.UseVisualStyleBackColor = false;
            this.itButton.CheckedChanged += new System.EventHandler(this.itButton_CheckedChanged);
            // 
            // cursorButton
            // 
            this.cursorButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.cursorButton.AutoSize = true;
            this.cursorButton.BackColor = System.Drawing.Color.Transparent;
            this.cursorButton.Image = global::ThePost_it.Properties.Resources.arrow;
            this.cursorButton.Location = new System.Drawing.Point(3, 3);
            this.cursorButton.Name = "cursorButton";
            this.cursorButton.Size = new System.Drawing.Size(40, 40);
            this.cursorButton.TabIndex = 2;
            this.cursorButton.TabStop = true;
            this.cursorButton.UseVisualStyleBackColor = false;
            this.cursorButton.CheckedChanged += new System.EventHandler(this.cursorButton_CheckedChanged);
            // 
            // panelDisigner
            // 
            this.panelDisigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisigner.Location = new System.Drawing.Point(45, 24);
            this.panelDisigner.Name = "panelDisigner";
            this.panelDisigner.Size = new System.Drawing.Size(1206, 472);
            this.panelDisigner.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 496);
            this.Controls.Add(this.panelDisigner);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RadioButton cursorButton;
        private System.Windows.Forms.RadioButton itButton;
        private PanelDisigner panelDisigner;
    }
}

