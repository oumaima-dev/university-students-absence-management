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
using System.Configuration;
using PlayerUI.Properties;

namespace PlayerUI
{
    public partial class ConsulterAbsForm : Form
    {
        string connection = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;


        private void ConsulterAbsForm_Load(object sender, EventArgs e)
        {
            
        }
        public ConsulterAbsForm(int idF,int idM)
        {
            
            InitializeComponent();
            displayData(idF,idM);
            gunaPictureBox3.Visible = false;
            idfil = idF;
            idMod = idM;
            gunaDataGridView2.Visible = false;
        }
        private int idfil { get; set; }
        private int idMod { get; set; }
        private void displayData(int idf,int idm)
        {
            try {
            using (SqlConnection con = new SqlConnection(connection))
            {
                    int i;
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ABSENCE,ETUDIANT where ABSENCE.idEtudiant=ETUDIANT.idEtudiant and ABSENCE.idFiliere = '" + idf + "'  and ABSENCE.idModule ='" + idm + "' ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
               
                dt.Load(reader);
                    DataTable dtCloned = dt.Clone();
                    dtCloned.Columns[1].DataType = typeof(String);
                    foreach (DataRow row in dt.Rows)
                    {
                        dtCloned.ImportRow(row);
                    }
                    gunaDataGridView1.DataSource = dt;
                gunaDataGridView2.DataSource = dtCloned;
                gunaDataGridView1.Columns[0].Visible = false; 

                gunaDataGridView1.Columns[1].HeaderText = "Justifiée";
               
                gunaDataGridView1.Columns[1].ReadOnly = true;
                

                gunaDataGridView1.Columns[2].HeaderText = "Heure Début";
                gunaDataGridView1.Columns[2].ReadOnly = true;

                gunaDataGridView1.Columns[3].HeaderText = "Heure Fin";
                gunaDataGridView1.Columns[3].ReadOnly = true;

                gunaDataGridView1.Columns[10].HeaderText = "Date d'absence";
                gunaDataGridView1.Columns[10].ReadOnly = true;


                    for (i = 4; i < 22; i++)
                    {
                        if (i!=10)
                        {
                            gunaDataGridView1.Columns[i].Visible = false;
                        }
                    }
                    
                    gunaDataGridView2.Columns[0].Visible = false;
                    gunaDataGridView2.Columns[1].Width = 68;
                    gunaDataGridView2.Columns[1].HeaderText = "Etat";
                    
                    gunaDataGridView2.Columns[1].ReadOnly = true;

                    gunaDataGridView2.Columns[2].Width = 40;
                    gunaDataGridView2.Columns[2].HeaderText = "De";
                    gunaDataGridView2.Columns[2].ReadOnly = true;

                    gunaDataGridView2.Columns[3].Width = 40;
                    gunaDataGridView2.Columns[3].HeaderText = "À";
                    gunaDataGridView2.Columns[3].ReadOnly = true;

                    gunaDataGridView2.Columns[10].Width = 70;
                    gunaDataGridView2.Columns[10].HeaderText = "Date";
                    gunaDataGridView2.Columns[10].ReadOnly = true;

                    gunaDataGridView2.Columns[14].Width = 90;
                    gunaDataGridView2.Columns[14].HeaderText = "Nom";
                    gunaDataGridView2.Columns[14].ReadOnly = true;
                    gunaDataGridView2.Columns[15].Width = 150;
                    gunaDataGridView2.Columns[15].HeaderText = "Prenom";
                    gunaDataGridView2.Columns[15].ReadOnly = true;
                    for (i = 4; i < 22; i++)
                    {
                        if (i != 14 && i != 15 && i!=10)
                        {
                            gunaDataGridView2.Columns[i].Visible = false;
                        }
                    }
                    


                }
            }
            catch
            {
                MessageBox.Show("erreur!");
            }
            
            int j = 0;
            for (j = 0; j < gunaDataGridView2.Rows.Count-1; j++)
            {

                String check = gunaDataGridView2.Rows[j].Cells[1].Value.ToString();
                if (check == "False")
                {
                    // gunaDataGridView2.Columns[1].ValueType = typeof(String);
                    gunaDataGridView2.Rows[j].Cells[1].Value = "Non Justifiée";
                }
                if (check == "True")
                {

                    gunaDataGridView2.Rows[j].Cells[1].Value = "Justifiée";
                }
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
                DataTable dt = new DataTable();
                dt.Load(reader);

                gunaLineTextBoxNom.Text = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
                gunaLineTextBoxProf.Text = dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString();
                gunaLineTextBoxFiliere.Text = dt.Rows[0][4].ToString();
                gunaLineTextBoxModule.Text = dt.Rows[0][5].ToString();
               
            }
                }
                catch
            {
               // MessageBox.Show("erreur!");
            }
        }
            
        }

        private void gunaDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gunaDataGridView1.CurrentRow != null)
                {
                    if (gunaDataGridView1.CurrentRow.Cells[0].Value != null)
                    {
                        int idA = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value);
                        remplir_champs(idA);
                        gunaComboBoxHeureDebut.Text = gunaDataGridView1.CurrentRow.Cells[2].Value.ToString();
                        gunaComboBoxHeureFin.Text = gunaDataGridView1.CurrentRow.Cells[3].Value.ToString();
                        gunaDateTimePicker1.Value = Convert.ToDateTime(gunaDataGridView1.CurrentRow.Cells[4].Value);
                        gunaPictureBox3.Visible = true;                       
                        gunaPictureBox3.Location= new Point(22,220+21* gunaDataGridView1.CurrentRow.Index);    
                    }
                }
            }
            catch
            {
                //MessageBox.Show("");
            }
            
            
        }

       
        private bool checkHour()
        {
            int debut = Int16.Parse(gunaComboBoxHeureDebut.SelectedItem.ToString());
            int fin = Int16.Parse(gunaComboBoxHeureFin.SelectedItem.ToString());
            if (debut >= fin)
            {
                MessageBox.Show("Veuillez choisir une heure correcte de la fin de la séance !");
                return false;
            }
            return true;
        }
        private void gunaComboBoxHeureFin_Leave(object sender, EventArgs e)
        {
            //checkHour();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
            {
                    if (checkHour())
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
                        displayData(idf, idm);
                        con.Close();
                    }          
            }

        }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Veuillez Ressayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


}

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Voulez-vous supprimer cette absence", "confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    int idA = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[0].Value);
                    SqlCommand cmd = new SqlCommand("delete from ABSENCE where idAbsence=" + idA + "", con);
                    MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    displayData(idfil,idMod);
                }
            }
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)

        {
            
            Bitmap Objtbmp = new Bitmap(this.gunaDataGridView2.Width, this.gunaDataGridView2.Height);
            gunaDataGridView2.DrawToBitmap(Objtbmp, new Rectangle(0, 0, this.gunaDataGridView2.Width, this.gunaDataGridView2.Height));
            System.Resources.ResourceManager rm = Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject("ensak");
           
        
            e.Graphics.DrawImage(myImage, new Rectangle(20, 10,70,70));
           // Bitmap myImage1 = (Bitmap)rm.GetObject("logo");


            //e.Graphics.DrawImage(myImage1, new Rectangle(400, 10, 130, 130));
            e.Graphics.DrawImage(Objtbmp, 20, 200);

           e.Graphics.DrawString("Liste D'absence Pour "+ gunaLineTextBoxFiliere.Text+ "", new Font("verdana", 17,FontStyle.Underline), Brushes.CadetBlue, new Point(250,30));
           e.Graphics.DrawString("Module : " + gunaLineTextBoxModule.Text + "", new Font("verdana", 14), Brushes.Black, new Point(300, 70));
           e.Graphics.DrawString("Professeur : " + gunaLineTextBoxProf.Text + "", new Font("verdana", 14), Brushes.Black, new Point(300, 110));
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog(); 
        }
    }
}
