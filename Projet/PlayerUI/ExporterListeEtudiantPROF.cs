using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;

namespace PlayerUI
{
    public partial class ExporterListeEtudiantPROF : UserControl

    {
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        

        public ExporterListeEtudiantPROF(int iduser)
        {
            InitializeComponent();
            idprof = iduser;
            fill_filiere(idprof);
          
        }
        int idprof { get; set; }
        private void iconButtonAjoutFiliere_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) { 
            if(gunaComboBoxFil.SelectedIndex > -1)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select cin,cne,nom,prenom,dateNaissance,email,telephone from ETUDIANT where idFiliere = '" + (gunaComboBoxFil.SelectedItem as dynamic).value + "'", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt.Rows.Count != 0)
                {
                    Excel.Application ExcelApp = new Excel.Application();
                    Excel.Workbook workbook = ExcelApp.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                    Excel.Worksheet worksheet = (Excel.Worksheet)ExcelApp.ActiveSheet;

                    ExcelApp.Visible = true;

                    

                    for (int Rows = 1; Rows < dt.Columns.Count +1; Rows++)
                    {
                        worksheet.Cells[1, Rows] = dt.Columns[Rows - 1].ColumnName;
                    }

                    // on recopie toutes les valeurs du DataGridView dans le fichier Excel

                    for (int Rows = 0; Rows < dt.Rows.Count ; Rows++)
                    {
                        for (int Columns = 0; Columns < dt.Columns.Count  ; Columns++)
                        {

                            worksheet.Cells[Rows + 2, Columns + 1] = dt.Rows[Rows][Columns];

                            worksheet.Columns.AutoFit();
                        }
                    }

                    //sauvegarde du fichier Excel
                    //puis dans ce dossier j'ai renommé Client.xlsx 
                    var savefileDialoge = new SaveFileDialog();
                    savefileDialoge.FileName = "ListeEtudiants";
                    savefileDialoge.DefaultExt = ".xlsx";
                    if (savefileDialoge.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(savefileDialoge.FileName,
                       Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                       Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                       Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    }
                    //Fermeture de l'application Excel

                    ExcelApp.Quit();
                }
                connection.Close();
                reader.Close();
                }

            
        
            else
            {
                MessageBox.Show("veuillez choisir une Fillière !");
            }
            
        }
        }

        public void fill_filiere(int idp)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
            gunaComboBoxFil.Items.Clear();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * FROM FILIERE,MODULELISTE,MODULE,AFFECTATION where FILIERE.idFiliere=MODULELISTE.idFiliere and MODULELISTE.idModule=MODULE.idModule and MODULE.idModule=AFFECTATION.module and AFFECTATION.idProfesseur="+idp+"", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            gunaComboBoxFil.DisplayMember = "Text";
            gunaComboBoxFil.ValueMember = "value";
            while (reader.Read())
            {
                gunaComboBoxFil.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });
            }
            connection.Close();

        }
        }

        private void gunaComboBoxFil_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (gunaComboBoxFil.SelectedIndex > -1)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select cin,cne,nom,prenom,dateNaissance,email,telephone from ETUDIANT where idFiliere = '" + (gunaComboBoxFil.SelectedItem as dynamic).value + "'", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    if (dt.Rows.Count != 0)
                    {
                        datagrid.DataSource = dt;
                    }
                    connection.Close();
                    reader.Close();
                }
            }
        }
    }
}
