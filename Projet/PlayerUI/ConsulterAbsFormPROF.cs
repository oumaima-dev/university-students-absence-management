using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;

namespace PlayerUI
{
    public partial class ConsulterAbsFormPROF : Form
    {
        string connection = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        private void ConsulterAbsForm_Load(object sender, EventArgs e)
        {
            
        }
        private int IDPROF { get; set; }
        public ConsulterAbsFormPROF(int idF,int idM,int idProf)
        {
            IDPROF = idProf;
            InitializeComponent();
            displayData(idF,idM);
        }

        private void displayData(int idf,int idm)
        {
            try {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select idAbsence,etat,heureDebut,HeureFin,dateAbsence,idFiliere,idModule,idProfesseur,idEtudiant from ABSENCE where idFiliere = '" + idf + "' and idModule ='" + idm + "' and idProfesseur ='" + IDPROF + "' ", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                
                gunaDataGridView1.DataSource = dt;
                gunaDataGridView1.Columns[0].Visible = false;

                gunaDataGridView1.Columns[1].HeaderText = "Justifiée";
                gunaDataGridView1.Columns[1].ReadOnly = true;

                gunaDataGridView1.Columns[2].HeaderText = "Heure Début";
                gunaDataGridView1.Columns[2].ReadOnly = true;

                gunaDataGridView1.Columns[3].HeaderText = "Heure Fin";
                gunaDataGridView1.Columns[3].ReadOnly = true;

                gunaDataGridView1.Columns[4].HeaderText = "Date d'absence";
                gunaDataGridView1.Columns[4].ReadOnly = true;

                gunaDataGridView1.Columns[5].Visible = false;
                gunaDataGridView1.Columns[6].Visible = false;
                gunaDataGridView1.Columns[7].Visible = false;
                gunaDataGridView1.Columns[8].Visible = false;

                    con.Close();
            }
        }
            catch
            {
                MessageBox.Show("erreur!");
            }
}



private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remplir_champs(int idAbs)
        {
            
            if (gunaDataGridView1.SelectedRows != null) {
                try
                {
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select ETUDIANT.nom,ETUDIANT.prenom,PROFESSEUR.nom,PROFESSEUR.prenom,FILIERE.libelle,MODULE.libelle from ABSENCE JOIN ETUDIANT ON ABSENCE.idEtudiant = ETUDIANT.idEtudiant JOIN PROFESSEUR ON ABSENCE.idProfesseur = PROFESSEUR.idProfesseur JOIN FILIERE ON FILIERE.idFIliere = ABSENCE.idFiliere JOIN MODULE ON MODULE.idModule = ABSENCE.idModule where ABSENCE.idAbsence = '" + idAbs + "'", con);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) { 

                            gunaLineTextBoxNom.Text = reader.GetString(1)+ " " + reader.GetString(0);

                            gunaLineTextBoxFiliere.Text = reader.GetString(4);
                            gunaLineTextBoxModule.Text = reader.GetString(5);
                        }


                }
            }
                catch
            {
                MessageBox.Show("erreur!");
            }
        }
            
        }

        private void gunaDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try { 
            if (gunaDataGridView1.CurrentRow != null)
            {
                if (gunaDataGridView1.CurrentRow.Cells[0].Value != null)
                {
                    

                    int idA = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value);
                    if (idA > -1 )
                    {
                        remplir_champs(idA);
                    }
                    
                    
                    gunaComboBoxHeureDebut.Text = gunaDataGridView1.CurrentRow.Cells[2].Value.ToString();
                    gunaComboBoxHeureFin.Text = gunaDataGridView1.CurrentRow.Cells[3].Value.ToString();
                    gunaDateTimePicker1.Value = Convert.ToDateTime(gunaDataGridView1.CurrentRow.Cells[4].Value);

                    

                }
            }
            }
            catch
            {
                MessageBox.Show("La ligne est vide ! ");
            }


        }


        private void gunaComboBoxHeureFin_Leave(object sender, EventArgs e)
        {
            
        }
         // MODIFIER ABSENCE
        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                DateTime date;
                date = gunaDateTimePicker1.Value;
                date.ToString("yyyy-MM-dd");

                int idA = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value);

                SqlCommand command1 = con.CreateCommand();
                command1.CommandType = CommandType.Text;
                command1.CommandText = "update ABSENCE set heureDebut='" + gunaComboBoxHeureDebut.Text + "' , heureFin='" + gunaComboBoxHeureFin.Text + "' , dateAbsence='" + date.ToString("yyyy-MM-dd") + "'  where idAbsence=" + idA + " ";
                command1.ExecuteNonQuery();
                MessageBox.Show("Modification réussie");
                int idf = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[5].Value);
                int idm = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[6].Value);

                gunaDataGridView1.ClearSelection();
                
                displayData(idf,idm);
                
                
                con.Close();
            }

        }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Veuillez Ressayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


}
        // Supprimer absence
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

        DialogResult confirmation = MessageBox.Show(" supprimer cette absence  ?", "Confirmation", MessageBoxButtons.YesNo);
        if(confirmation == DialogResult.Yes) { 

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
         

                    int idA = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value);

                    SqlCommand command1 = con.CreateCommand();
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = "delete from ABSENCE where idAbsence=" + idA + " ";
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Suppression réussie");
                    int idf = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[5].Value);
                    int idm = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[6].Value);

                    gunaDataGridView1.ClearSelection();
                    gunaLineTextBoxNom.Text = " ";
                    gunaLineTextBoxFiliere.Text = " ";
                    gunaLineTextBoxModule.Text = " ";

                    gunaComboBoxHeureDebut.SelectedItem = null;
                    gunaComboBoxHeureFin.SelectedItem = null;
                    

                    displayData(idf, idm);


                    con.Close();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Veuillez Ressayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }

        // Exporter Absence
        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook workbook = ExcelApp.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
            Excel.Worksheet worksheet = (Excel.Worksheet)ExcelApp.ActiveSheet;

            ExcelApp.Visible = true;

            gunaDataGridView1.RowHeadersVisible = false;

            for (int Rows = 1; Rows < 6; Rows++)
            {
                worksheet.Cells[1, Rows] = gunaDataGridView1.Columns[Rows - 1].HeaderText;
            }
            worksheet.Cells[1, 6] = "Nom Des Etudiants"; 

            // on recopie toutes les valeurs du DataGridView dans le fichier Excel

            for (int Rows = 0; Rows < gunaDataGridView1.Rows.Count; Rows++)
            {
                for (int Columns = 0; Columns < 5; Columns++)
                {

                    worksheet.Cells[Rows + 2, Columns + 1] = gunaDataGridView1.Rows[Rows].Cells[Columns].Value;

                    worksheet.Columns.AutoFit();
                }
            }


            for (int Rows = 0; Rows < gunaDataGridView1.Rows.Count; Rows++)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        con.Open();
                        int ide = Convert.ToInt32(gunaDataGridView1.Rows[Rows].Cells[6].Value);
                        SqlCommand cmd = new SqlCommand("select prenom,nom from ETUDIANT where idEtudiant = '" + ide + "'", con);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) {
                            worksheet.Cells[Rows + 2, 6] = reader.GetString(0) + " " + reader.GetString(1);
                            worksheet.Columns.AutoFit();
                        }
                        con.Close();
                    }
                }
                catch {
                    MessageBox.Show("Erreur !");
                }

                }




            //sauvegarde du fichier Excel
            //puis dans ce dossier j'ai renommé Client.xlsx 
            var savefileDialoge = new SaveFileDialog();
            savefileDialoge.FileName = "ListeAbsence";
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
    }
}
