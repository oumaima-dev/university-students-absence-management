namespace PlayerUI
{
    partial class JustificationEncoursUC
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
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.iconButton12 = new FontAwesome.Sharp.IconButton();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutpanel
            // 
            this.layoutpanel.AutoScroll = true;
            this.layoutpanel.Location = new System.Drawing.Point(12, 62);
            this.layoutpanel.Margin = new System.Windows.Forms.Padding(0);
            this.layoutpanel.Name = "layoutpanel";
            this.layoutpanel.Size = new System.Drawing.Size(475, 333);
            this.layoutpanel.TabIndex = 3;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.iconButton12);
            this.gunaShadowPanel1.Controls.Add(this.guna2ComboBox1);
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(13, 12);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 5;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(474, 48);
            this.gunaShadowPanel1.TabIndex = 2;
            // 
            // iconButton12
            // 
            this.iconButton12.BackColor = System.Drawing.SystemColors.Window;
            this.iconButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton12.FlatAppearance.BorderSize = 0;
            this.iconButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton12.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton12.ForeColor = System.Drawing.Color.Black;
            this.iconButton12.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.iconButton12.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.iconButton12.IconSize = 26;
            this.iconButton12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton12.Location = new System.Drawing.Point(430, 10);
            this.iconButton12.Name = "iconButton12";
            this.iconButton12.Rotation = 0D;
            this.iconButton12.Size = new System.Drawing.Size(32, 26);
            this.iconButton12.TabIndex = 6;
            this.iconButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton12.UseVisualStyleBackColor = false;
            this.iconButton12.Click += new System.EventHandler(this.iconButton12_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(72, 5);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(206, 36);
            this.guna2ComboBox1.TabIndex = 5;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filiére";
            // 
            // JustificationEncoursUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutpanel);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "JustificationEncoursUC";
            this.Size = new System.Drawing.Size(520, 410);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutpanel;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private FontAwesome.Sharp.IconButton iconButton12;
    }
}
