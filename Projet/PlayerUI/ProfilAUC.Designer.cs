namespace PlayerUI
{
    partial class ProfilAUC
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.idlabel = new System.Windows.Forms.Label();
            this.emailbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.iconButtonModifierAdmin = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Controls.Add(this.idlabel);
            this.gunaPanel1.Controls.Add(this.gunaCirclePictureBox2);
            this.gunaPanel1.Controls.Add(this.emailbox);
            this.gunaPanel1.Controls.Add(this.iconButtonModifierAdmin);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(178, 177);
            this.gunaPanel1.TabIndex = 2;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.idlabel.Location = new System.Drawing.Point(3, 0);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(35, 13);
            this.idlabel.TabIndex = 9;
            this.idlabel.Text = "label1";
            // 
            // emailbox
            // 
            this.emailbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.emailbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.emailbox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.emailbox.ForeColor = System.Drawing.Color.White;
            this.emailbox.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.emailbox.Location = new System.Drawing.Point(-1, 120);
            this.emailbox.Name = "emailbox";
            this.emailbox.PasswordChar = '\0';
            this.emailbox.ReadOnly = true;
            this.emailbox.SelectedText = "";
            this.emailbox.Size = new System.Drawing.Size(178, 30);
            this.emailbox.TabIndex = 7;
            this.emailbox.Text = "login@gmail.com";
            this.emailbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.Image = global::PlayerUI.Properties.Resources.tux_png_24;
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(32, 11);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(108, 107);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox2.TabIndex = 8;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            this.gunaCirclePictureBox2.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // iconButtonModifierAdmin
            // 
            this.iconButtonModifierAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonModifierAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonModifierAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonModifierAdmin.FlatAppearance.BorderSize = 0;
            this.iconButtonModifierAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonModifierAdmin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonModifierAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonModifierAdmin.ForeColor = System.Drawing.Color.Black;
            this.iconButtonModifierAdmin.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonModifierAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.iconButtonModifierAdmin.IconSize = 26;
            this.iconButtonModifierAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonModifierAdmin.Location = new System.Drawing.Point(0, 148);
            this.iconButtonModifierAdmin.Name = "iconButtonModifierAdmin";
            this.iconButtonModifierAdmin.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.iconButtonModifierAdmin.Rotation = 0D;
            this.iconButtonModifierAdmin.Size = new System.Drawing.Size(176, 27);
            this.iconButtonModifierAdmin.TabIndex = 5;
            this.iconButtonModifierAdmin.Text = "Supprimer";
            this.iconButtonModifierAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonModifierAdmin.UseVisualStyleBackColor = false;
            this.iconButtonModifierAdmin.Click += new System.EventHandler(this.iconButtonModifierAdmin_Click);
            // 
            // ProfilAUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel1);
            this.Name = "ProfilAUC";
            this.Size = new System.Drawing.Size(179, 178);
            this.Load += new System.EventHandler(this.ProfilAUC_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private Guna.UI.WinForms.GunaLineTextBox emailbox;
        private FontAwesome.Sharp.IconButton iconButtonModifierAdmin;
        private System.Windows.Forms.Label idlabel;
    }
}
