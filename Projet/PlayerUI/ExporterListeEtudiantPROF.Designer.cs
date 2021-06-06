namespace PlayerUI
{
    partial class ExporterListeEtudiantPROF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaComboBoxFil = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLineTextBox7 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox8 = new Guna.UI.WinForms.GunaLineTextBox();
            this.iconButtonExport = new FontAwesome.Sharp.IconButton();
            this.datagrid = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaComboBoxFil
            // 
            this.gunaComboBoxFil.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBoxFil.BaseColor = System.Drawing.Color.White;
            this.gunaComboBoxFil.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBoxFil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBoxFil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBoxFil.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBoxFil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBoxFil.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBoxFil.FormattingEnabled = true;
            this.gunaComboBoxFil.Location = new System.Drawing.Point(217, 94);
            this.gunaComboBoxFil.Name = "gunaComboBoxFil";
            this.gunaComboBoxFil.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.gunaComboBoxFil.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBoxFil.Size = new System.Drawing.Size(283, 26);
            this.gunaComboBoxFil.TabIndex = 51;
            this.gunaComboBoxFil.SelectedIndexChanged += new System.EventHandler(this.gunaComboBoxFil_SelectedIndexChanged);
            // 
            // gunaLineTextBox7
            // 
            this.gunaLineTextBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox7.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.gunaLineTextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox7.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLineTextBox7.Location = new System.Drawing.Point(33, 94);
            this.gunaLineTextBox7.Name = "gunaLineTextBox7";
            this.gunaLineTextBox7.PasswordChar = '\0';
            this.gunaLineTextBox7.ReadOnly = true;
            this.gunaLineTextBox7.SelectedText = "";
            this.gunaLineTextBox7.Size = new System.Drawing.Size(110, 26);
            this.gunaLineTextBox7.TabIndex = 50;
            this.gunaLineTextBox7.Text = "Filière : ";
            // 
            // gunaLineTextBox8
            // 
            this.gunaLineTextBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLineTextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox8.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.gunaLineTextBox8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLineTextBox8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.gunaLineTextBox8.Location = new System.Drawing.Point(33, 13);
            this.gunaLineTextBox8.Name = "gunaLineTextBox8";
            this.gunaLineTextBox8.PasswordChar = '\0';
            this.gunaLineTextBox8.ReadOnly = true;
            this.gunaLineTextBox8.SelectedText = "";
            this.gunaLineTextBox8.Size = new System.Drawing.Size(200, 30);
            this.gunaLineTextBox8.TabIndex = 53;
            this.gunaLineTextBox8.Text = "Exporter la liste d\'étudiants : ";
            // 
            // iconButtonExport
            // 
            this.iconButtonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.iconButtonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonExport.FlatAppearance.BorderSize = 0;
            this.iconButtonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonExport.ForeColor = System.Drawing.Color.White;
            this.iconButtonExport.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.iconButtonExport.IconColor = System.Drawing.Color.White;
            this.iconButtonExport.IconSize = 26;
            this.iconButtonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonExport.Location = new System.Drawing.Point(341, 354);
            this.iconButtonExport.Name = "iconButtonExport";
            this.iconButtonExport.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButtonExport.Rotation = 0D;
            this.iconButtonExport.Size = new System.Drawing.Size(159, 40);
            this.iconButtonExport.TabIndex = 23;
            this.iconButtonExport.Text = "Exporter la liste";
            this.iconButtonExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExport.UseVisualStyleBackColor = false;
            this.iconButtonExport.Click += new System.EventHandler(this.iconButtonAjoutFiliere_Click);
            // 
            // datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.BackgroundColor = System.Drawing.Color.White;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid.Location = new System.Drawing.Point(33, 142);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(467, 193);
            this.datagrid.TabIndex = 101;
            this.datagrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid.ThemeStyle.HeaderStyle.Height = 30;
            this.datagrid.ThemeStyle.ReadOnly = false;
            this.datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid.ThemeStyle.RowsStyle.Height = 22;
            this.datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ExporterListeEtudiantPROF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.gunaLineTextBox8);
            this.Controls.Add(this.gunaComboBoxFil);
            this.Controls.Add(this.gunaLineTextBox7);
            this.Controls.Add(this.iconButtonExport);
            this.Name = "ExporterListeEtudiantPROF";
            this.Size = new System.Drawing.Size(520, 453);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonExport;
        private Guna.UI.WinForms.GunaComboBox gunaComboBoxFil;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox7;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox8;
        private Guna.UI.WinForms.GunaDataGridView datagrid;
    }
}
