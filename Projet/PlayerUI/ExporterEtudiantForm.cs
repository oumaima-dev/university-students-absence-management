using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PlayerUI
{
    public partial class ExporterEtudiantForm : Form
    {
        
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);

        private void ExporterEtudiantForm_Load(object sender, EventArgs e)
        {
            gunaComboBox1.Items.Insert(0, "Choisir une filière...");
            gunaComboBox1.SelectedIndex = 0;
        }
        public ExporterEtudiantForm()
        {
            InitializeComponent();
            fill_filiere();
            gunaComboBox1.Items.Insert(0, "Choisir une filière...");
            gunaComboBox1.SelectedIndex = 0;
        }

        public void fill_filiere()
        {
            gunaComboBox1.Items.Clear();


            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from FILIERE", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            gunaComboBox1.DisplayMember = "Text";
            gunaComboBox1.ValueMember = "value";
            while (reader.Read())
            {
                gunaComboBox1.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });

            }
            DataTable dt = new DataTable();
            dt.Load(reader);

        }
        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillDataGrid()
        {
            try
            {
                if (gunaComboBox1.SelectedIndex > 0)
                {
                    connection.Open();
                    SqlCommand command2 = connection.CreateCommand();
                    command2.CommandType = CommandType.Text;
                    command2.CommandText = "select idEtudiant,cin,cne,nom,prenom,dateNaissance,email,telephone from ETUDIANT where idFiliere =  '" + (gunaComboBox1.SelectedItem as dynamic).value + "' ";

                    SqlDataReader reader = command2.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    gunaDataGridView1.DataSource = dt;
                    reader.Close();
                }
            }
            catch
            {
                MessageBox.Show("erreur");

            }
            finally
            {
                connection.Close();
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook workbook = ExcelApp.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
            Excel.Worksheet worksheet = (Excel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;

            gunaDataGridView1.RowHeadersVisible = false;

            for (int Rows = 1; Rows < gunaDataGridView1.Columns.Count + 1; Rows++)
            {
                worksheet.Cells[1, Rows] = gunaDataGridView1.Columns[Rows - 1].HeaderText;
            }

            // on recopie toutes les valeurs du DataGridView dans le fichier Excel

            for (int Rows = 0; Rows < gunaDataGridView1.Rows.Count; Rows++)
            {
                for (int Columns = 0; Columns < gunaDataGridView1.Columns.Count; Columns++)
                {

                    worksheet.Cells[Rows + 2, Columns + 1] = gunaDataGridView1.Rows[Rows].Cells[Columns].Value;

                    worksheet.Columns.AutoFit();
                }
            }


            //sauvegarde du fichier Excel
            //puis dans ce dossier j'ai renommé Client.xlsx 
            var savefileDialoge = new SaveFileDialog();
            savefileDialoge.FileName = "ListeEtudiant";
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

        private void gunaComboBox1_TextChanged(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGrid();

        }
    }
}
