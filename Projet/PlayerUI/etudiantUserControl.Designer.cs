namespace PlayerUI
{
    partial class etudiantUserControl
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
            this.iconButtonCréerEtudiant = new FontAwesome.Sharp.IconButton();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLineTextBox7 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            this.loginbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox5 = new Guna.UI.WinForms.GunaLineTextBox();
            this.passbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox3 = new Guna.UI.WinForms.GunaLineTextBox();
            this.iconButtonCréerAdmin = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // iconButtonCréerEtudiant
            // 
            this.iconButtonCréerEtudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.iconButtonCréerEtudiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCréerEtudiant.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCréerEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCréerEtudiant.ForeColor = System.Drawing.Color.White;
            this.iconButtonCréerEtudiant.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonCréerEtudiant.IconColor = System.Drawing.Color.White;
            this.iconButtonCréerEtudiant.IconSize = 30;
            this.iconButtonCréerEtudiant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCréerEtudiant.Location = new System.Drawing.Point(169, 300);
            this.iconButtonCréerEtudiant.Name = "iconButtonCréerEtudiant";
            this.iconButtonCréerEtudiant.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonCréerEtudiant.Rotation = 0D;
            this.iconButtonCréerEtudiant.Size = new System.Drawing.Size(200, 40);
            this.iconButtonCréerEtudiant.TabIndex = 21;
            this.iconButtonCréerEtudiant.Text = "Associer un compte";
            this.iconButtonCréerEtudiant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCréerEtudiant.UseVisualStyleBackColor = false;
            this.iconButtonCréerEtudiant.Click += new System.EventHandler(this.iconButtonCréerEtudiant_Click);
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(169, 39);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(200, 26);
            this.gunaComboBox1.TabIndex = 22;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged_1);
            // 
            // gunaLineTextBox7
            // 
            this.gunaLineTextBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox7.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox7.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox7.Location = new System.Drawing.Point(35, 35);
            this.gunaLineTextBox7.Name = "gunaLineTextBox7";
            this.gunaLineTextBox7.PasswordChar = '\0';
            this.gunaLineTextBox7.ReadOnly = true;
            this.gunaLineTextBox7.SelectedText = "";
            this.gunaLineTextBox7.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox7.TabIndex = 23;
            this.gunaLineTextBox7.Text = "Filière : ";
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(35, 103);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.ReadOnly = true;
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox1.TabIndex = 25;
            this.gunaLineTextBox1.Text = "Nom complet : ";
            // 
            // gunaComboBox2
            // 
            this.gunaComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox2.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox2.FormattingEnabled = true;
            this.gunaComboBox2.Location = new System.Drawing.Point(169, 107);
            this.gunaComboBox2.Name = "gunaComboBox2";
            this.gunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox2.Size = new System.Drawing.Size(200, 26);
            this.gunaComboBox2.TabIndex = 24;
            this.gunaComboBox2.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // loginbox
            // 
            this.loginbox.BackColor = System.Drawing.Color.White;
            this.loginbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.loginbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginbox.LineColor = System.Drawing.Color.Gainsboro;
            this.loginbox.Location = new System.Drawing.Point(169, 164);
            this.loginbox.Name = "loginbox";
            this.loginbox.PasswordChar = '\0';
            this.loginbox.ReadOnly = true;
            this.loginbox.SelectedText = "";
            this.loginbox.Size = new System.Drawing.Size(200, 30);
            this.loginbox.TabIndex = 27;
            this.loginbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginbox.TextChanged += new System.EventHandler(this.TextBoxEtudiantnom_TextChanged);
            // 
            // gunaLineTextBox5
            // 
            this.gunaLineTextBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox5.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox5.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox5.Location = new System.Drawing.Point(35, 164);
            this.gunaLineTextBox5.Name = "gunaLineTextBox5";
            this.gunaLineTextBox5.PasswordChar = '\0';
            this.gunaLineTextBox5.ReadOnly = true;
            this.gunaLineTextBox5.SelectedText = "";
            this.gunaLineTextBox5.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox5.TabIndex = 26;
            this.gunaLineTextBox5.Text = "Login : ";
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.Color.White;
            this.passbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passbox.LineColor = System.Drawing.Color.Gainsboro;
            this.passbox.Location = new System.Drawing.Point(169, 232);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '*';
            this.passbox.SelectedText = "";
            this.passbox.Size = new System.Drawing.Size(200, 30);
            this.passbox.TabIndex = 29;
            this.passbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLineTextBox3
            // 
            this.gunaLineTextBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox3.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox3.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox3.Location = new System.Drawing.Point(35, 232);
            this.gunaLineTextBox3.Name = "gunaLineTextBox3";
            this.gunaLineTextBox3.PasswordChar = '\0';
            this.gunaLineTextBox3.ReadOnly = true;
            this.gunaLineTextBox3.SelectedText = "";
            this.gunaLineTextBox3.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox3.TabIndex = 28;
            this.gunaLineTextBox3.Text = "mot de passe : ";
            // 
            // iconButtonCréerAdmin
            // 
            this.iconButtonCréerAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.iconButtonCréerAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCréerAdmin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCréerAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCréerAdmin.ForeColor = System.Drawing.Color.White;
            this.iconButtonCréerAdmin.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonCréerAdmin.IconColor = System.Drawing.Color.White;
            this.iconButtonCréerAdmin.IconSize = 30;
            this.iconButtonCréerAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCréerAdmin.Location = new System.Drawing.Point(169, 346);
            this.iconButtonCréerAdmin.Name = "iconButtonCréerAdmin";
            this.iconButtonCréerAdmin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonCréerAdmin.Rotation = 0D;
            this.iconButtonCréerAdmin.Size = new System.Drawing.Size(200, 40);
            this.iconButtonCréerAdmin.TabIndex = 38;
            this.iconButtonCréerAdmin.Text = "Créer un étudiant";
            this.iconButtonCréerAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCréerAdmin.UseVisualStyleBackColor = false;
            this.iconButtonCréerAdmin.Click += new System.EventHandler(this.iconButtonCréerAdmin_Click);
            // 
            // etudiantUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconButtonCréerAdmin);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.gunaLineTextBox3);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.gunaLineTextBox5);
            this.Controls.Add(this.gunaLineTextBox1);
            this.Controls.Add(this.gunaComboBox2);
            this.Controls.Add(this.gunaLineTextBox7);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.iconButtonCréerEtudiant);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "etudiantUserControl";
            this.Size = new System.Drawing.Size(520, 410);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonCréerEtudiant;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox7;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox2;
        private Guna.UI.WinForms.GunaLineTextBox loginbox;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox5;
        private Guna.UI.WinForms.GunaLineTextBox passbox;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox3;
        private FontAwesome.Sharp.IconButton iconButtonCréerAdmin;
    }
}
