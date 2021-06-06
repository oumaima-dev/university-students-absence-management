namespace PlayerUI
{
    partial class AjouterAdminUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterAdminUserControl));
            this.dateNaissanceAdmin = new Guna.UI.WinForms.GunaDateTimePicker();
            this.TextBoxAdmineNom = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBoxAdminPrenom = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBoxAdminemail = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBoxAdminTelephone = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBoxAdminCin = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox6 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox5 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox4 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox3 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox2 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.iconButtonCréerAdmin = new FontAwesome.Sharp.IconButton();
            this.CirclePictureBoxAdmin = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.gunaLineTextBox7 = new Guna.UI.WinForms.GunaLineTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNaissanceAdmin
            // 
            this.dateNaissanceAdmin.BaseColor = System.Drawing.Color.White;
            this.dateNaissanceAdmin.BorderColor = System.Drawing.Color.Silver;
            this.dateNaissanceAdmin.CustomFormat = null;
            this.dateNaissanceAdmin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateNaissanceAdmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNaissanceAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNaissanceAdmin.ForeColor = System.Drawing.Color.Black;
            this.dateNaissanceAdmin.Location = new System.Drawing.Point(238, 254);
            this.dateNaissanceAdmin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNaissanceAdmin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNaissanceAdmin.Name = "dateNaissanceAdmin";
            this.dateNaissanceAdmin.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateNaissanceAdmin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNaissanceAdmin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dateNaissanceAdmin.OnPressedColor = System.Drawing.Color.Black;
            this.dateNaissanceAdmin.Size = new System.Drawing.Size(200, 30);
            this.dateNaissanceAdmin.TabIndex = 49;
            this.dateNaissanceAdmin.Text = "mardi 9 juin 2020";
            this.dateNaissanceAdmin.Value = new System.DateTime(2020, 6, 9, 16, 2, 50, 783);
            // 
            // TextBoxAdmineNom
            // 
            this.TextBoxAdmineNom.BackColor = System.Drawing.Color.White;
            this.TextBoxAdmineNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAdmineNom.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxAdmineNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAdmineNom.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBoxAdmineNom.Location = new System.Drawing.Point(238, 185);
            this.TextBoxAdmineNom.Name = "TextBoxAdmineNom";
            this.TextBoxAdmineNom.PasswordChar = '\0';
            this.TextBoxAdmineNom.SelectedText = "";
            this.TextBoxAdmineNom.Size = new System.Drawing.Size(200, 30);
            this.TextBoxAdmineNom.TabIndex = 48;
            this.TextBoxAdmineNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxAdmineNom.TextChanged += new System.EventHandler(this.gunaLineTextBox16_TextChanged);
            // 
            // TextBoxAdminPrenom
            // 
            this.TextBoxAdminPrenom.BackColor = System.Drawing.Color.White;
            this.TextBoxAdminPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAdminPrenom.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxAdminPrenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAdminPrenom.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBoxAdminPrenom.Location = new System.Drawing.Point(238, 220);
            this.TextBoxAdminPrenom.Name = "TextBoxAdminPrenom";
            this.TextBoxAdminPrenom.PasswordChar = '\0';
            this.TextBoxAdminPrenom.SelectedText = "";
            this.TextBoxAdminPrenom.Size = new System.Drawing.Size(200, 30);
            this.TextBoxAdminPrenom.TabIndex = 47;
            this.TextBoxAdminPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxAdminPrenom.TextChanged += new System.EventHandler(this.gunaLineTextBox15_TextChanged);
            // 
            // TextBoxAdminemail
            // 
            this.TextBoxAdminemail.BackColor = System.Drawing.Color.White;
            this.TextBoxAdminemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAdminemail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxAdminemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAdminemail.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBoxAdminemail.Location = new System.Drawing.Point(238, 290);
            this.TextBoxAdminemail.Name = "TextBoxAdminemail";
            this.TextBoxAdminemail.PasswordChar = '\0';
            this.TextBoxAdminemail.SelectedText = "";
            this.TextBoxAdminemail.Size = new System.Drawing.Size(200, 30);
            this.TextBoxAdminemail.TabIndex = 46;
            this.TextBoxAdminemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAdminTelephone
            // 
            this.TextBoxAdminTelephone.BackColor = System.Drawing.Color.White;
            this.TextBoxAdminTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAdminTelephone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxAdminTelephone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAdminTelephone.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBoxAdminTelephone.Location = new System.Drawing.Point(238, 325);
            this.TextBoxAdminTelephone.Name = "TextBoxAdminTelephone";
            this.TextBoxAdminTelephone.PasswordChar = '\0';
            this.TextBoxAdminTelephone.SelectedText = "";
            this.TextBoxAdminTelephone.Size = new System.Drawing.Size(200, 30);
            this.TextBoxAdminTelephone.TabIndex = 45;
            this.TextBoxAdminTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAdminCin
            // 
            this.TextBoxAdminCin.BackColor = System.Drawing.Color.White;
            this.TextBoxAdminCin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAdminCin.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxAdminCin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAdminCin.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBoxAdminCin.Location = new System.Drawing.Point(238, 151);
            this.TextBoxAdminCin.Name = "TextBoxAdminCin";
            this.TextBoxAdminCin.PasswordChar = '\0';
            this.TextBoxAdminCin.SelectedText = "";
            this.TextBoxAdminCin.Size = new System.Drawing.Size(200, 30);
            this.TextBoxAdminCin.TabIndex = 44;
            this.TextBoxAdminCin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLineTextBox6
            // 
            this.gunaLineTextBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox6.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox6.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox6.Location = new System.Drawing.Point(54, 325);
            this.gunaLineTextBox6.Name = "gunaLineTextBox6";
            this.gunaLineTextBox6.PasswordChar = '\0';
            this.gunaLineTextBox6.ReadOnly = true;
            this.gunaLineTextBox6.SelectedText = "";
            this.gunaLineTextBox6.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox6.TabIndex = 42;
            this.gunaLineTextBox6.Text = "Téléphone : ";
            // 
            // gunaLineTextBox5
            // 
            this.gunaLineTextBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox5.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox5.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox5.Location = new System.Drawing.Point(54, 185);
            this.gunaLineTextBox5.Name = "gunaLineTextBox5";
            this.gunaLineTextBox5.PasswordChar = '\0';
            this.gunaLineTextBox5.ReadOnly = true;
            this.gunaLineTextBox5.SelectedText = "";
            this.gunaLineTextBox5.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox5.TabIndex = 41;
            this.gunaLineTextBox5.Text = "Nom : ";
            // 
            // gunaLineTextBox4
            // 
            this.gunaLineTextBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox4.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox4.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox4.Location = new System.Drawing.Point(54, 220);
            this.gunaLineTextBox4.Name = "gunaLineTextBox4";
            this.gunaLineTextBox4.PasswordChar = '\0';
            this.gunaLineTextBox4.ReadOnly = true;
            this.gunaLineTextBox4.SelectedText = "";
            this.gunaLineTextBox4.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox4.TabIndex = 40;
            this.gunaLineTextBox4.Text = "Prénom : ";
            // 
            // gunaLineTextBox3
            // 
            this.gunaLineTextBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox3.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox3.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox3.Location = new System.Drawing.Point(54, 255);
            this.gunaLineTextBox3.Name = "gunaLineTextBox3";
            this.gunaLineTextBox3.PasswordChar = '\0';
            this.gunaLineTextBox3.ReadOnly = true;
            this.gunaLineTextBox3.SelectedText = "";
            this.gunaLineTextBox3.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox3.TabIndex = 39;
            this.gunaLineTextBox3.Text = "Date Naissance : ";
            // 
            // gunaLineTextBox2
            // 
            this.gunaLineTextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox2.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox2.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox2.Location = new System.Drawing.Point(54, 290);
            this.gunaLineTextBox2.Name = "gunaLineTextBox2";
            this.gunaLineTextBox2.PasswordChar = '\0';
            this.gunaLineTextBox2.ReadOnly = true;
            this.gunaLineTextBox2.SelectedText = "";
            this.gunaLineTextBox2.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox2.TabIndex = 38;
            this.gunaLineTextBox2.Text = "Email : ";
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(54, 151);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.ReadOnly = true;
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox1.TabIndex = 37;
            this.gunaLineTextBox1.Text = "CIN :";
            // 
            // iconButtonCréerAdmin
            // 
            this.iconButtonCréerAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.iconButtonCréerAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCréerAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCréerAdmin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCréerAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCréerAdmin.ForeColor = System.Drawing.Color.White;
            this.iconButtonCréerAdmin.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonCréerAdmin.IconColor = System.Drawing.Color.White;
            this.iconButtonCréerAdmin.IconSize = 30;
            this.iconButtonCréerAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCréerAdmin.Location = new System.Drawing.Point(247, 477);
            this.iconButtonCréerAdmin.Name = "iconButtonCréerAdmin";
            this.iconButtonCréerAdmin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonCréerAdmin.Rotation = 0D;
            this.iconButtonCréerAdmin.Size = new System.Drawing.Size(184, 40);
            this.iconButtonCréerAdmin.TabIndex = 50;
            this.iconButtonCréerAdmin.Text = "Ajouter";
            this.iconButtonCréerAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCréerAdmin.UseVisualStyleBackColor = false;
            this.iconButtonCréerAdmin.Click += new System.EventHandler(this.iconButtonCréerAdmin_Click);
            // 
            // CirclePictureBoxAdmin
            // 
            this.CirclePictureBoxAdmin.BaseColor = System.Drawing.Color.White;
            this.CirclePictureBoxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("CirclePictureBoxAdmin.Image")));
            this.CirclePictureBoxAdmin.Location = new System.Drawing.Point(238, 379);
            this.CirclePictureBoxAdmin.Name = "CirclePictureBoxAdmin";
            this.CirclePictureBoxAdmin.Size = new System.Drawing.Size(62, 54);
            this.CirclePictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CirclePictureBoxAdmin.TabIndex = 52;
            this.CirclePictureBoxAdmin.TabStop = false;
            this.CirclePictureBoxAdmin.UseTransfarantBackground = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(84)))), ((int)(((byte)(163)))));
            this.iconButton1.IconSize = 23;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(313, 379);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(31, 26);
            this.iconButton1.TabIndex = 51;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // gunaLineTextBox7
            // 
            this.gunaLineTextBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox7.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox7.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox7.Location = new System.Drawing.Point(54, 379);
            this.gunaLineTextBox7.Name = "gunaLineTextBox7";
            this.gunaLineTextBox7.PasswordChar = '\0';
            this.gunaLineTextBox7.ReadOnly = true;
            this.gunaLineTextBox7.SelectedText = "";
            this.gunaLineTextBox7.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox7.TabIndex = 53;
            this.gunaLineTextBox7.Text = "Image : ";
            // 
            // AjouterAdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLineTextBox7);
            this.Controls.Add(this.CirclePictureBoxAdmin);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButtonCréerAdmin);
            this.Controls.Add(this.dateNaissanceAdmin);
            this.Controls.Add(this.TextBoxAdmineNom);
            this.Controls.Add(this.TextBoxAdminPrenom);
            this.Controls.Add(this.TextBoxAdminemail);
            this.Controls.Add(this.TextBoxAdminTelephone);
            this.Controls.Add(this.TextBoxAdminCin);
            this.Controls.Add(this.gunaLineTextBox6);
            this.Controls.Add(this.gunaLineTextBox5);
            this.Controls.Add(this.gunaLineTextBox4);
            this.Controls.Add(this.gunaLineTextBox3);
            this.Controls.Add(this.gunaLineTextBox2);
            this.Controls.Add(this.gunaLineTextBox1);
            this.Name = "AjouterAdminUserControl";
            this.Size = new System.Drawing.Size(535, 563);
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDateTimePicker dateNaissanceAdmin;
        private Guna.UI.WinForms.GunaLineTextBox TextBoxAdmineNom;
        private Guna.UI.WinForms.GunaLineTextBox TextBoxAdminPrenom;
        private Guna.UI.WinForms.GunaLineTextBox TextBoxAdminemail;
        private Guna.UI.WinForms.GunaLineTextBox TextBoxAdminTelephone;
        private Guna.UI.WinForms.GunaLineTextBox TextBoxAdminCin;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox6;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox5;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox4;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox3;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox2;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private FontAwesome.Sharp.IconButton iconButtonCréerAdmin;
        private Guna.UI.WinForms.GunaCirclePictureBox CirclePictureBoxAdmin;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox7;
    }
}
