namespace PlayerUI
{
    partial class profUserControl
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
            this.passbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox3 = new Guna.UI.WinForms.GunaLineTextBox();
            this.loginbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox5 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonCréerAdmin = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.Color.White;
            this.passbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passbox.LineColor = System.Drawing.Color.Gainsboro;
            this.passbox.Location = new System.Drawing.Point(168, 182);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '*';
            this.passbox.SelectedText = "";
            this.passbox.Size = new System.Drawing.Size(200, 30);
            this.passbox.TabIndex = 36;
            this.passbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLineTextBox3
            // 
            this.gunaLineTextBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox3.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox3.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox3.Location = new System.Drawing.Point(34, 182);
            this.gunaLineTextBox3.Name = "gunaLineTextBox3";
            this.gunaLineTextBox3.PasswordChar = '\0';
            this.gunaLineTextBox3.ReadOnly = true;
            this.gunaLineTextBox3.SelectedText = "";
            this.gunaLineTextBox3.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox3.TabIndex = 35;
            this.gunaLineTextBox3.Text = "mot de passe : ";
            // 
            // loginbox
            // 
            this.loginbox.BackColor = System.Drawing.Color.White;
            this.loginbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.loginbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginbox.LineColor = System.Drawing.Color.Gainsboro;
            this.loginbox.Location = new System.Drawing.Point(168, 114);
            this.loginbox.Name = "loginbox";
            this.loginbox.PasswordChar = '\0';
            this.loginbox.ReadOnly = true;
            this.loginbox.SelectedText = "";
            this.loginbox.Size = new System.Drawing.Size(200, 30);
            this.loginbox.TabIndex = 34;
            this.loginbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLineTextBox5
            // 
            this.gunaLineTextBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox5.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox5.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox5.Location = new System.Drawing.Point(34, 114);
            this.gunaLineTextBox5.Name = "gunaLineTextBox5";
            this.gunaLineTextBox5.PasswordChar = '\0';
            this.gunaLineTextBox5.ReadOnly = true;
            this.gunaLineTextBox5.SelectedText = "";
            this.gunaLineTextBox5.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox5.TabIndex = 33;
            this.gunaLineTextBox5.Text = "Login : ";
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(34, 53);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.ReadOnly = true;
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox1.TabIndex = 32;
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
            this.gunaComboBox2.Location = new System.Drawing.Point(168, 57);
            this.gunaComboBox2.Name = "gunaComboBox2";
            this.gunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox2.Size = new System.Drawing.Size(200, 26);
            this.gunaComboBox2.TabIndex = 31;
            this.gunaComboBox2.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox2_SelectedIndexChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(168, 286);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(200, 40);
            this.iconButton1.TabIndex = 30;
            this.iconButton1.Text = "Associer un compte";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.iconButtonCréerAdmin.Location = new System.Drawing.Point(168, 332);
            this.iconButtonCréerAdmin.Name = "iconButtonCréerAdmin";
            this.iconButtonCréerAdmin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonCréerAdmin.Rotation = 0D;
            this.iconButtonCréerAdmin.Size = new System.Drawing.Size(200, 40);
            this.iconButtonCréerAdmin.TabIndex = 37;
            this.iconButtonCréerAdmin.Text = "Créer un professeur";
            this.iconButtonCréerAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCréerAdmin.UseVisualStyleBackColor = false;
            this.iconButtonCréerAdmin.Click += new System.EventHandler(this.iconButtonCréerAdmin_Click);
            // 
            // profUserControl
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
            this.Controls.Add(this.iconButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "profUserControl";
            this.Size = new System.Drawing.Size(520, 410);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox passbox;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox3;
        private Guna.UI.WinForms.GunaLineTextBox loginbox;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox5;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButtonCréerAdmin;
    }
}
