namespace ThePost_it
{
    partial class PostitEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostitEditor));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMode = new System.Windows.Forms.Panel();
            this.postItButton = new System.Windows.Forms.RadioButton();
            this.cursorButton = new System.Windows.Forms.RadioButton();
            this.panelDesigner = new ThePost_it.PanelDesigner();
            this.menu.SuspendLayout();
            this.panelMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem});
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
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // panelMode
            // 
            this.panelMode.Controls.Add(this.postItButton);
            this.panelMode.Controls.Add(this.cursorButton);
            this.panelMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMode.Location = new System.Drawing.Point(0, 24);
            this.panelMode.Name = "panelMode";
            this.panelMode.Size = new System.Drawing.Size(45, 472);
            this.panelMode.TabIndex = 1;
            // 
            // postItButton
            // 
            this.postItButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.postItButton.AutoSize = true;
            this.postItButton.BackColor = System.Drawing.Color.Transparent;
            this.postItButton.Image = global::ThePost_it.Properties.Resources.postit;
            this.postItButton.Location = new System.Drawing.Point(3, 49);
            this.postItButton.Name = "postItButton";
            this.postItButton.Size = new System.Drawing.Size(40, 40);
            this.postItButton.TabIndex = 3;
            this.postItButton.TabStop = true;
            this.postItButton.UseVisualStyleBackColor = false;
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
            // 
            // panelDesigner
            // 
            this.panelDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesigner.Location = new System.Drawing.Point(45, 24);
            this.panelDesigner.Name = "panelDesigner";
            this.panelDesigner.Size = new System.Drawing.Size(1206, 472);
            this.panelDesigner.TabIndex = 2;
            // 
            // PostitEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 496);
            this.Controls.Add(this.panelDesigner);
            this.Controls.Add(this.panelMode);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "PostitEditor";
            this.Text = "Post-It editor";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelMode.ResumeLayout(false);
            this.panelMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menu;
        public System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        public System.Windows.Forms.Panel panelMode;
        public System.Windows.Forms.RadioButton cursorButton;
        public System.Windows.Forms.RadioButton postItButton;
        public PanelDesigner panelDesigner;
        public System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}

