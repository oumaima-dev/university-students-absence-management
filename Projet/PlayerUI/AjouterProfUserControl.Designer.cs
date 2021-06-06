namespace PlayerUI
{
    partial class AjouterProfUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterProfUserControl));
            this.DateNaissanceProf = new Guna.UI.WinForms.GunaDateTimePicker();
            this.TextBoxProfNom = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBoxProfPrenom = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBoxProfEmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBoxProfTelephone = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox7 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox6 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox5 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox4 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox3 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox2 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.DateEmbaucheProf = new Guna.UI.WinForms.GunaDateTimePicker();
            this.TextBoxProfCin = new Guna.UI.WinForms.GunaLineTextBox();
            this.iconButtonCréerAdmin = new FontAwesome.Sharp.IconButton();
            this.gunaLineTextBox9 = new Guna.UI.WinForms.GunaLineTextBox();
            this.CirclePictureBoxProf = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBoxProf)).BeginInit();
            this.SuspendLayout();
            // 
            // DateNaissanceProf
            // 
            this.DateNaissanceProf.BaseColor = System.Drawing.Color.White;
            this.DateNaissanceProf.BorderColor = System.Drawing.Color.Silver;
            this.DateNaissanceProf.CustomFormat = null;
            this.DateNaissanceProf.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateNaissanceProf.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateNaissanceProf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateNaissanceProf.ForeColor = System.Drawing.Color.Black;
            this.DateNaissanceProf.Location = new System.Drawing.Point(237, 265);
            this.DateNaissanceProf.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateNaissanceProf.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateNaissanceProf.Name = "DateNaissanceProf";
            this.DateNaissanceProf.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateNaissanceProf.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateNaissanceProf.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateNaissanceProf.OnPressedColor = System.Drawing.Color.Black;
            this.DateNaissanceProf.Size = new System.Drawing.Size(200, 30);
            this.DateNaissanceProf.TabIndex = 33;
            this.DateNaissanceProf.Text = "mardi 9 juin 2020";
            this.DateNaissanceProf.Value = new System.DateTime(2020, 6, 9, 16, 2, 50, 783);
            // 
            // TextBoxProfNom
            // 
            this.TextBoxProfNom.BackColor = System.Drawing.Color.White;
            this.TextBoxProfNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxProfNom.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxProfNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxProfNom.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBoxProfNom.Location = new System.Drawing.Point(237, 195);
            this.TextBoxProfNom.Name = "TextBoxProfNom";
            this.TextBoxProfNom.PasswordChar = '\0';
            this.TextBoxProfNom.SelectedText = "";
            this.TextBoxProfNom.Size = new System.Drawing.Size(200, 30);
            this.TextBoxProfNom.TabIndex = 31;
            this.TextBoxProfNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxProfNom.TextChanged += new System.EventHandler(this.gunaLineTextBox16_TextChanged);
            // 
            // TextBoxProfPrenom
            // 
            this.TextBoxProfPrenom.BackColor = System.Drawing.Color.White;
            this.TextBoxProfPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxProfPrenom.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxProfPrenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxProfPrenom.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBoxProfPrenom.Location = new System.Drawing.Point(237, 230);
            this.TextBoxProfPrenom.Name = "TextBoxProfPrenom";
            this.TextBoxProfPrenom.PasswordChar = '\0';
            this.TextBoxProfPrenom.SelectedText = "";
            this.TextBoxProfPrenom.Size = new System.Drawing.Size(200, 30);
            this.TextBoxProfPrenom.TabIndex = 30;
            this.TextBoxProfPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxProfPrenom.TextChanged += new System.EventHandler(this.gunaLineTextBox15_TextChanged);
            // 
            // TextBoxProfEmail
            // 
            this.TextBoxProfEmail.BackColor = System.Drawing.Color.White;
            this.TextBoxProfEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxProfEmail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxProfEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxProfEmail.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBoxProfEmail.Location = new System.Drawing.Point(237, 300);
            this.TextBoxProfEmail.Name = "TextBoxProfEmail";
            this.TextBoxProfEmail.PasswordChar = '\0';
            this.TextBoxProfEmail.SelectedText = "";
            this.TextBoxProfEmail.Size = new System.Drawing.Size(200, 30);
            this.TextBoxProfEmail.TabIndex = 29;
            this.TextBoxProfEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxProfTelephone
            // 
            this.TextBoxProfTelephone.BackColor = System.Drawing.Color.White;
            this.TextBoxProfTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxProfTelephone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxProfTelephone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxProfTelephone.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBoxProfTelephone.Location = new System.Drawing.Point(237, 335);
            this.TextBoxProfTelephone.Name = "TextBoxProfTelephone";
            this.TextBoxProfTelephone.PasswordChar = '\0';
            this.TextBoxProfTelephone.SelectedText = "";
            this.TextBoxProfTelephone.Size = new System.Drawing.Size(200, 30);
            this.TextBoxProfTelephone.TabIndex = 28;
            this.TextBoxProfTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLineTextBox7
            // 
            this.gunaLineTextBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox7.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox7.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox7.Location = new System.Drawing.Point(53, 370);
            this.gunaLineTextBox7.Name = "gunaLineTextBox7";
            this.gunaLineTextBox7.PasswordChar = '\0';
            this.gunaLineTextBox7.ReadOnly = true;
            this.gunaLineTextBox7.SelectedText = "";
            this.gunaLineTextBox7.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox7.TabIndex = 26;
            this.gunaLineTextBox7.Text = "Date d\'embauche : ";
            // 
            // gunaLineTextBox6
            // 
            this.gunaLineTextBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox6.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox6.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox6.Location = new System.Drawing.Point(53, 335);
            this.gunaLineTextBox6.Name = "gunaLineTextBox6";
            this.gunaLineTextBox6.PasswordChar = '\0';
            this.gunaLineTextBox6.ReadOnly = true;
            this.gunaLineTextBox6.SelectedText = "";
            this.gunaLineTextBox6.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox6.TabIndex = 25;
            this.gunaLineTextBox6.Text = "Téléphone : ";
            // 
            // gunaLineTextBox5
            // 
            this.gunaLineTextBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox5.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox5.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox5.Location = new System.Drawing.Point(53, 195);
            this.gunaLineTextBox5.Name = "gunaLineTextBox5";
            this.gunaLineTextBox5.PasswordChar = '\0';
            this.gunaLineTextBox5.ReadOnly = true;
            this.gunaLineTextBox5.SelectedText = "";
            this.gunaLineTextBox5.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox5.TabIndex = 24;
            this.gunaLineTextBox5.Text = "Nom : ";
            // 
            // gunaLineTextBox4
            // 
            this.gunaLineTextBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox4.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox4.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox4.Location = new System.Drawing.Point(53, 230);
            this.gunaLineTextBox4.Name = "gunaLineTextBox4";
            this.gunaLineTextBox4.PasswordChar = '\0';
            this.gunaLineTextBox4.ReadOnly = true;
            this.gunaLineTextBox4.SelectedText = "";
            this.gunaLineTextBox4.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox4.TabIndex = 23;
            this.gunaLineTextBox4.Text = "Prénom : ";
            // 
            // gunaLineTextBox3
            // 
            this.gunaLineTextBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox3.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox3.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox3.Location = new System.Drawing.Point(53, 265);
            this.gunaLineTextBox3.Name = "gunaLineTextBox3";
            this.gunaLineTextBox3.PasswordChar = '\0';
            this.gunaLineTextBox3.ReadOnly = true;
            this.gunaLineTextBox3.SelectedText = "";
            this.gunaLineTextBox3.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox3.TabIndex = 22;
            this.gunaLineTextBox3.Text = "Date Naissance : ";
            // 
            // gunaLineTextBox2
            // 
            this.gunaLineTextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox2.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox2.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox2.Location = new System.Drawing.Point(53, 300);
            this.gunaLineTextBox2.Name = "gunaLineTextBox2";
            this.gunaLineTextBox2.PasswordChar = '\0';
            this.gunaLineTextBox2.ReadOnly = true;
            this.gunaLineTextBox2.SelectedText = "";
            this.gunaLineTextBox2.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox2.TabIndex = 21;
            this.gunaLineTextBox2.Text = "Email : ";
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(53, 161);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.ReadOnly = true;
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox1.TabIndex = 20;
            this.gunaLineTextBox1.Text = "CIN :";
            // 
            // DateEmbaucheProf
            // 
            this.DateEmbaucheProf.BaseColor = System.Drawing.Color.White;
            this.DateEmbaucheProf.BorderColor = System.Drawing.Color.Silver;
            this.DateEmbaucheProf.CustomFormat = null;
            this.DateEmbaucheProf.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateEmbaucheProf.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateEmbaucheProf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateEmbaucheProf.ForeColor = System.Drawing.Color.Black;
            this.DateEmbaucheProf.Location = new System.Drawing.Point(237, 370);
            this.DateEmbaucheProf.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateEmbaucheProf.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateEmbaucheProf.Name = "DateEmbaucheProf";
            this.DateEmbaucheProf.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateEmbaucheProf.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateEmbaucheProf.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateEmbaucheProf.OnPressedColor = System.Drawing.Color.Black;
            this.DateEmbaucheProf.Size = new System.Drawing.Size(200, 30);
            this.DateEmbaucheProf.TabIndex = 36;
            this.DateEmbaucheProf.Text = "mardi 9 juin 2020";
            this.DateEmbaucheProf.Value = new System.DateTime(2020, 6, 9, 16, 2, 50, 783);
            // 
            // TextBoxProfCin
            // 
            this.TextBoxProfCin.BackColor = System.Drawing.Color.White;
            this.TextBoxProfCin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxProfCin.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxProfCin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxProfCin.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBoxProfCin.Location = new System.Drawing.Point(237, 161);
            this.TextBoxProfCin.Name = "TextBoxProfCin";
            this.TextBoxProfCin.PasswordChar = '\0';
            this.TextBoxProfCin.SelectedText = "";
            this.TextBoxProfCin.Size = new System.Drawing.Size(200, 30);
            this.TextBoxProfCin.TabIndex = 27;
            this.TextBoxProfCin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.iconButtonCréerAdmin.Location = new System.Drawing.Point(238, 501);
            this.iconButtonCréerAdmin.Name = "iconButtonCréerAdmin";
            this.iconButtonCréerAdmin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonCréerAdmin.Rotation = 0D;
            this.iconButtonCréerAdmin.Size = new System.Drawing.Size(184, 40);
            this.iconButtonCréerAdmin.TabIndex = 37;
            this.iconButtonCréerAdmin.Text = "Ajouter";
            this.iconButtonCréerAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCréerAdmin.UseVisualStyleBackColor = false;
            this.iconButtonCréerAdmin.Click += new System.EventHandler(this.iconButtonCréerAdmin_Click);
            // 
            // gunaLineTextBox9
            // 
            this.gunaLineTextBox9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox9.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox9.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox9.Location = new System.Drawing.Point(53, 421);
            this.gunaLineTextBox9.Name = "gunaLineTextBox9";
            this.gunaLineTextBox9.PasswordChar = '\0';
            this.gunaLineTextBox9.ReadOnly = true;
            this.gunaLineTextBox9.SelectedText = "";
            this.gunaLineTextBox9.Size = new System.Drawing.Size(110, 30);
            this.gunaLineTextBox9.TabIndex = 56;
            this.gunaLineTextBox9.Text = "Image : ";
            // 
            // CirclePictureBoxProf
            // 
            this.CirclePictureBoxProf.BaseColor = System.Drawing.Color.White;
            this.CirclePictureBoxProf.Image = ((System.Drawing.Image)(resources.GetObject("CirclePictureBoxProf.Image")));
            this.CirclePictureBoxProf.Location = new System.Drawing.Point(237, 421);
            this.CirclePictureBoxProf.Name = "CirclePictureBoxProf";
            this.CirclePictureBoxProf.Size = new System.Drawing.Size(62, 54);
            this.CirclePictureBoxProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CirclePictureBoxProf.TabIndex = 55;
            this.CirclePictureBoxProf.TabStop = false;
            this.CirclePictureBoxProf.UseTransfarantBackground = false;
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
            this.iconButton1.Location = new System.Drawing.Point(312, 421);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(31, 26);
            this.iconButton1.TabIndex = 54;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // AjouterProfUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLineTextBox9);
            this.Controls.Add(this.CirclePictureBoxProf);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButtonCréerAdmin);
            this.Controls.Add(this.DateEmbaucheProf);
            this.Controls.Add(this.DateNaissanceProf);
            this.Controls.Add(this.TextBoxProfNom);
            this.Controls.Add(this.TextBoxProfPrenom);
            this.Controls.Add(this.TextBoxProfEmail);
            this.Controls.Add(this.TextBoxProfTelephone);
            this.Controls.Add(this.TextBoxProfCin);
            this.Controls.Add(this.gunaLineTextBox7);
            this.Controls.Add(this.gunaLineTextBox6);
            this.Controls.Add(this.gunaLineTextBox5);
            this.Controls.Add(this.gunaLineTextBox4);
            this.Controls.Add(this.gunaLineTextBox3);
            this.Controls.Add(this.gunaLineTextBox2);
            this.Controls.Add(this.gunaLineTextBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "AjouterProfUserControl";
            this.Size = new System.Drawing.Size(535, 563);
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBoxProf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDateTimePicker DateNaissanceProf;
        private Guna.UI.WinForms.GunaLineTextBox TextBoxProfNom;
        private Guna.UI.WinForms.GunaLineTextBox TextBoxProfPrenom;
        private Guna.UI.WinForms.GunaLineTextBox TextBoxProfEmail;
        private Guna.UI.WinForms.GunaLineTextBox TextBoxProfTelephone;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox7;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox6;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox5;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox4;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox3;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox2;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaDateTimePicker DateEmbaucheProf;
        private Guna.UI.WinForms.GunaLineTextBox TextBoxProfCin;
        private FontAwesome.Sharp.IconButton iconButtonCréerAdmin;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox9;
        private Guna.UI.WinForms.GunaCirclePictureBox CirclePictureBoxProf;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
