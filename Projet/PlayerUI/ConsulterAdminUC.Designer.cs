namespace PlayerUI
{
    partial class ConsulterAdminUC
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // layoutpanel
            // 
            this.layoutpanel.AutoScroll = true;
            this.layoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutpanel.Location = new System.Drawing.Point(0, 0);
            this.layoutpanel.Margin = new System.Windows.Forms.Padding(0);
            this.layoutpanel.Name = "layoutpanel";
            this.layoutpanel.Size = new System.Drawing.Size(715, 511);
            this.layoutpanel.TabIndex = 0;
            // 
            // ConsulterAdminUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutpanel);
            this.Name = "ConsulterAdminUC";
            this.Size = new System.Drawing.Size(715, 511);
            this.Load += new System.EventHandler(this.ConsulterAdminUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutpanel;
    }
}
