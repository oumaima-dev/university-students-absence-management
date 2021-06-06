namespace PlayerUI
{
    partial class Etudiant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etudiant));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.iconButtonDeconnexion = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.panelGérerAbs = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButtonModifAbs = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelGérerAbs.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.flowLayoutPanel1.Controls.Add(this.gunaPictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.gunaLineTextBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(240, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(694, 60);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::PlayerUI.Properties.Resources.avatar;
            this.gunaPictureBox1.Location = new System.Drawing.Point(618, 10);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(66, 44);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 6;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLineTextBox1.ForeColor = System.Drawing.Color.White;
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.gunaLineTextBox1.Location = new System.Drawing.Point(439, 10);
            this.gunaLineTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.ReadOnly = true;
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(179, 33);
            this.gunaLineTextBox1.TabIndex = 7;
            this.gunaLineTextBox1.Text = "login@gmail.com";
            this.gunaLineTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaLineTextBox1.TextChanged += new System.EventHandler(this.gunaLineTextBox1_TextChanged);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(231)))));
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(240, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(694, 687);
            this.panelChildForm.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(135, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENUE DANS VOTRE PLATEFORME";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 238);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panelSideMenu.Controls.Add(this.iconButtonDeconnexion);
            this.panelSideMenu.Controls.Add(this.iconButton9);
            this.panelSideMenu.Controls.Add(this.panelGérerAbs);
            this.panelSideMenu.Controls.Add(this.iconButton1);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(240, 687);
            this.panelSideMenu.TabIndex = 4;
            // 
            // iconButtonDeconnexion
            // 
            this.iconButtonDeconnexion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonDeconnexion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonDeconnexion.FlatAppearance.BorderSize = 0;
            this.iconButtonDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDeconnexion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonDeconnexion.ForeColor = System.Drawing.Color.Black;
            this.iconButtonDeconnexion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonDeconnexion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.iconButtonDeconnexion.IconSize = 26;
            this.iconButtonDeconnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonDeconnexion.Location = new System.Drawing.Point(0, 647);
            this.iconButtonDeconnexion.Name = "iconButtonDeconnexion";
            this.iconButtonDeconnexion.Rotation = 0D;
            this.iconButtonDeconnexion.Size = new System.Drawing.Size(240, 40);
            this.iconButtonDeconnexion.TabIndex = 15;
            this.iconButtonDeconnexion.Text = "Déconnexion";
            this.iconButtonDeconnexion.UseVisualStyleBackColor = false;
            this.iconButtonDeconnexion.Click += new System.EventHandler(this.iconButtonDeconnexion_Click_1);
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.iconButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton9.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton9.ForeColor = System.Drawing.Color.White;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton9.IconColor = System.Drawing.Color.White;
            this.iconButton9.IconSize = 26;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton9.Location = new System.Drawing.Point(0, 189);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton9.Rotation = 0D;
            this.iconButton9.Size = new System.Drawing.Size(240, 40);
            this.iconButton9.TabIndex = 14;
            this.iconButton9.Text = "Modifier Mot de Passe";
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.UseVisualStyleBackColor = false;
            this.iconButton9.Click += new System.EventHandler(this.iconButton9_Click);
            // 
            // panelGérerAbs
            // 
            this.panelGérerAbs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelGérerAbs.Controls.Add(this.iconButton2);
            this.panelGérerAbs.Controls.Add(this.iconButtonModifAbs);
            this.panelGérerAbs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGérerAbs.Location = new System.Drawing.Point(0, 100);
            this.panelGérerAbs.Name = "panelGérerAbs";
            this.panelGérerAbs.Size = new System.Drawing.Size(240, 89);
            this.panelGérerAbs.TabIndex = 11;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SatelliteDish;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.iconButton2.IconSize = 26;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(0, 45);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(240, 44);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Notice d\'Absence";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButtonModifAbs
            // 
            this.iconButtonModifAbs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonModifAbs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonModifAbs.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonModifAbs.FlatAppearance.BorderSize = 0;
            this.iconButtonModifAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonModifAbs.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonModifAbs.ForeColor = System.Drawing.Color.Black;
            this.iconButtonModifAbs.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButtonModifAbs.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.iconButtonModifAbs.IconSize = 26;
            this.iconButtonModifAbs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonModifAbs.Location = new System.Drawing.Point(0, 0);
            this.iconButtonModifAbs.Name = "iconButtonModifAbs";
            this.iconButtonModifAbs.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.iconButtonModifAbs.Rotation = 0D;
            this.iconButtonModifAbs.Size = new System.Drawing.Size(240, 45);
            this.iconButtonModifAbs.TabIndex = 2;
            this.iconButtonModifAbs.Text = "Consulter et justifier";
            this.iconButtonModifAbs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonModifAbs.UseVisualStyleBackColor = false;
            this.iconButtonModifAbs.Click += new System.EventHandler(this.iconButtonModifAbs_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 26;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(0, 60);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(240, 40);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Mes absences";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 687);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Etudiant";
            this.Text = "Etudiant";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelGérerAbs.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelChildForm;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Panel panelSideMenu;
        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.Panel panelGérerAbs;
        private FontAwesome.Sharp.IconButton iconButtonModifAbs;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButtonDeconnexion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}