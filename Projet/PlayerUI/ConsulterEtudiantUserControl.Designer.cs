namespace PlayerUI
{
    partial class ConsulterEtudiantUserControl
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
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.layoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButtonCréerAdmin = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaShadowPanel1.Controls.Add(this.gunaLineTextBox1);
            this.gunaShadowPanel1.Controls.Add(this.gunaComboBox1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(37, 13);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 5;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(441, 48);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filière";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::PlayerUI.Properties.Resources.iconSearch_removebg_preview;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(388, 10);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(39, 25);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 2;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            this.gunaCirclePictureBox1.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click);
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.Animated = true;
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(188, 7);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(171, 26);
            this.gunaLineTextBox1.TabIndex = 1;
            this.gunaLineTextBox1.Text = "CNE";
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.White;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(44, 8);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(91, 23);
            this.gunaComboBox1.TabIndex = 0;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // layoutpanel
            // 
            this.layoutpanel.AutoScroll = true;
            this.layoutpanel.Location = new System.Drawing.Point(36, 63);
            this.layoutpanel.Margin = new System.Windows.Forms.Padding(0);
            this.layoutpanel.Name = "layoutpanel";
            this.layoutpanel.Size = new System.Drawing.Size(454, 333);
            this.layoutpanel.TabIndex = 1;
            // 
            // iconButtonCréerAdmin
            // 
            this.iconButtonCréerAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.iconButtonCréerAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCréerAdmin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCréerAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCréerAdmin.ForeColor = System.Drawing.Color.White;
            this.iconButtonCréerAdmin.IconChar = FontAwesome.Sharp.IconChar.Indent;
            this.iconButtonCréerAdmin.IconColor = System.Drawing.Color.White;
            this.iconButtonCréerAdmin.IconSize = 30;
            this.iconButtonCréerAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCréerAdmin.Location = new System.Drawing.Point(36, 414);
            this.iconButtonCréerAdmin.Name = "iconButtonCréerAdmin";
            this.iconButtonCréerAdmin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonCréerAdmin.Rotation = 0D;
            this.iconButtonCréerAdmin.Size = new System.Drawing.Size(216, 40);
            this.iconButtonCréerAdmin.TabIndex = 39;
            this.iconButtonCréerAdmin.Text = "Importer liste des étudiants";
            this.iconButtonCréerAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCréerAdmin.UseVisualStyleBackColor = false;
            this.iconButtonCréerAdmin.Click += new System.EventHandler(this.iconButtonCréerAdmin_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(274, 414);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(216, 40);
            this.iconButton1.TabIndex = 40;
            this.iconButton1.Text = "Exporter liste des étudiants";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ConsulterEtudiantUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButtonCréerAdmin);
            this.Controls.Add(this.layoutpanel);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "ConsulterEtudiantUserControl";
            this.Size = new System.Drawing.Size(520, 468);
            this.Load += new System.EventHandler(this.ConsulterEtudiantUserControl_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.FlowLayoutPanel layoutpanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonCréerAdmin;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
