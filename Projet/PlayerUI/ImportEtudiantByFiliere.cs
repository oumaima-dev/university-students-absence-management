using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.Data.SqlClient;
using System.Configuration;

namespace PlayerUI
{
    public partial class ImportEtudiantByFiliere : Form
    {
        public ImportEtudiantByFiliere()
        {
            InitializeComponent();fill_filiere();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        DataTableCollection tables;

        List<etudiant> list = new List<etudiant>();
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pathbox.Text = ofd.FileName;
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tables = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tables)
                                cboSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        public void Insert_data(object o,int idfiliere)
        {
            etudiant c = (etudiant)o;
            string nom = c.nom;
            string prenom = c.prenom;
            string cne = c.cne;
            string cin = c.cin;
            string email = c.email;
            string tel = c.tel;
            string daten = c.daten;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    Image img = global::PlayerUI.Properties.Resources.tux_png_24;
                    pictureBox1.Image = img;
                    byte[] tabling = null;
                    tabling = ImageToByteArray(img);
                    string sql = @"insert into ETUDIANT VALUES ('" + cin + "','" + cne + "','" + nom + "','" + prenom + "','" + daten + "','" + email + "','" + tel + "',@img,null," + idfiliere + ")"; SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@img", tabling));
                    pathbox.Text = cmd.CommandText;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tables[cboSheet.SelectedItem.ToString()];
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    etudiant obj = new etudiant();
                    obj.nom = dt.Rows[i]["nom"].ToString();
                    obj.prenom = dt.Rows[i]["prenom"].ToString();
                    obj.cin = dt.Rows[i]["cin"].ToString();
                    obj.cne = dt.Rows[i]["cne"].ToString();
                    obj.email = dt.Rows[i]["email"].ToString();
                    obj.tel = dt.Rows[i]["telephone"].ToString();
                    obj.daten = dt.Rows[i]["dateNaissance"].ToString();
                    list.Add(obj);
                }
            }
        }

        private void ImportEtudiantByFiliere_Load(object sender, EventArgs e)
        {

        }
        public void fill_filiere()
        {
            ComboBoxFiliere.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from FILIERE", con);
                SqlDataReader reader = cmd.ExecuteReader();
                ComboBoxFiliere.DisplayMember = "Text";
                ComboBoxFiliere.ValueMember = "value";
                while (reader.Read())
                {

                    ComboBoxFiliere.Items.Add(new { Text = reader.GetString(1), value = reader.GetInt32(0) });

                }

            }
        }
            private void iconButtonCréerAdmin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            { int idf = (ComboBoxFiliere.SelectedItem as dynamic).value;
                Insert_data(list[i],idf);
            }
            MessageBox.Show("Vous avez ajouté " + list.Count+" étudiants à partir d'un fichier Excel", "SUCCES");
            list.Clear();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
