using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLOKA16
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A16.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopuniComboPas();
            PopuniComboIzlozba();
            PopuniComboKategorija();
            PopuniKategorije();
            richTextBox1.LoadFile(@"../../A16.rtf");
        }
        private void PopuniComboPas()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT PasID, CONCAT(PasId,' - ',Ime) AS ImePsa FROM Pas";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtc = new DataTable();
            try
            {
                da.Fill(dtc);
                comboBoxPas.DataSource = dtc;
                comboBoxPas.DisplayMember = "ImePsa";
                comboBoxPas.ValueMember = "PasID";
                comboBoxPas.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Doslo je do greške:");
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
            }
        }
        private void PopuniComboIzlozba()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT IzlozbaID, CONCAT(IzlozbaID,' - ',Mesto,' - ', CONVERT(VARCHAR(10),Datum,105)) AS Naziv FROM Izlozba";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtc = new DataTable();
            try
            {
                da.Fill(dtc);
                comboBoxIzlozba.DataSource = dtc;
                comboBoxIzlozba.DisplayMember = "Naziv";
                comboBoxIzlozba.ValueMember = "IzlozbaID";
                comboBoxIzlozba2.DataSource = dtc;
                comboBoxIzlozba2.DisplayMember = "Naziv";
                comboBoxIzlozba2.ValueMember = "IzlozbaID";
            }
            catch
            {
                MessageBox.Show("Doslo je do greške:");
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
            }
        }
        private void PopuniComboKategorija()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT KategorijaID, CONCAT(KategorijaID,' - ',Naziv) AS ImeKategorije FROM Kategorija";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtc = new DataTable();
            try
            {
                da.Fill(dtc);
                comboBoxKategorija.DataSource = dtc;
                comboBoxKategorija.DisplayMember = "ImeKategorije";
                comboBoxKategorija.ValueMember = "KategorijaID";
                comboBoxKategorija.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Doslo je do greške:");
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxPas.Text == "" || comboBoxIzlozba.Text == "" || comboBoxKategorija.Text == "")
            {
                MessageBox.Show("Popunite podatke");
                return;
            }
            // provera da li prijava vec postoji
            string sqlProvera = "SELECT * FROM Rezultat " +
                "WHERE IzlozbaID=@Izlozba " +
                "AND KategorijaID=@Kategorija " +
                "AND PasID=@Pas";
            SqlCommand cmdProvera = new SqlCommand(sqlProvera, conn);
            cmdProvera.Parameters.AddWithValue("@Izlozba", comboBoxIzlozba.SelectedValue);
            cmdProvera.Parameters.AddWithValue("@Kategorija", comboBoxKategorija.SelectedValue);
            cmdProvera.Parameters.AddWithValue("@Pas", comboBoxPas.SelectedValue);
            SqlDataAdapter dap = new SqlDataAdapter(cmdProvera);
            DataTable dtp = new DataTable();
            try
            {
                dap.Fill(dtp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska" + ex.Message);
            }
            if (dtp.Rows.Count > 0)
            {
                MessageBox.Show("Pas je vec prijavljen!");
                return;
            }
           
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Rezultat(IzlozbaID, KategorijaID, PasID) VALUES(@Izlozba, @Kategorija, @Pas)", conn);
                command.Parameters.AddWithValue("@Izlozba", comboBoxIzlozba.SelectedValue);
                command.Parameters.AddWithValue("@Kategorija", comboBoxKategorija.SelectedValue);
                command.Parameters.AddWithValue("@Pas", comboBoxPas.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dtc = new DataTable();
                da.Fill(dtc);
                MessageBox.Show("Uspešan unos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            string sqlupit = "SELECT Kategorija.KategorijaID as Sifra, " +
                                     "Kategorija.Naziv as Naziv_Kategorije, " +
                                     "COUNT(*) as BrojPasa " +
                            "FROM  Rezultat " +
                            "INNER JOIN Kategorija ON Rezultat.KategorijaID = Kategorija.KategorijaID " +
                            "WHERE IzlozbaID=@izlId " +
                            "GROUP BY Kategorija.KategorijaID, Kategorija.Naziv";
            SqlCommand cmd = new SqlCommand(sqlupit, conn);
            cmd.Parameters.AddWithValue("@izlId", comboBoxIzlozba2.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                chart1.DataSource = dt;
                chart1.Series[0].XValueMember = "Naziv_Kategorije";
                chart1.Series[0].YValueMembers = "BrojPasa";
                chart1.Series[0].IsValueShownAsLabel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
                adapter.Dispose();
            }

            string sql1 = "SELECT COUNT(*) FROM Rezultat WHERE IzlozbaID = @izlId";
            string sql2 = "SELECT COUNT(*) FROM Rezultat WHERE IzlozbaID = @izlId AND LEN(Napomena)>0";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@izlId", comboBoxIzlozba2.SelectedValue);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            cmd2.Parameters.AddWithValue("@izlId", comboBoxIzlozba2.SelectedValue);
            try
            {
                conn.Open();
                int prijavljeno = (Int32)cmd1.ExecuteScalar();
                int takmicilo = (Int32)cmd2.ExecuteScalar();
                labelUkupnoPrijavljeno.Text = "Ukupan broj pasa koji je prijavljen " + prijavljeno.ToString();
                labelUkupnoTakmicilo.Text = "Ukupan broj pasa koji se takmicio " + takmicilo.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Doslo je do greške:");
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                PopuniComboKategorija();
            if (tabControl1.SelectedIndex == 4)
                this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int katID = 0;
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            katID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            string sqlProvera = "SELECT Rezultat.PasID,Pas.Ime " +
                "FROM Rezultat, Pas " +
                "WHERE IzlozbaID=@Izlozba " +
                "AND Rezultat.PasID=Pas.PasID " +
                "AND Rezultat.KategorijaID=@kategID";
            SqlCommand cmdProvera = new SqlCommand(sqlProvera, conn);
            cmdProvera.Parameters.AddWithValue("@Izlozba", comboBoxIzlozba.SelectedValue);
            cmdProvera.Parameters.AddWithValue("@kategID", katID);
            SqlDataAdapter dap = new SqlDataAdapter(cmdProvera);
            DataTable dtp = new DataTable();
            try
            {
                dap.Fill(dtp);
               
                listView1.Items.Clear();
                foreach (DataRow red in dtp.Rows)
                {
                    ListViewItem elem = new ListViewItem(red[0].ToString());
                    elem.SubItems.Add(red[1].ToString());
                    listView1.Items.Add(elem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska" + ex.Message);
            }
        }
        void PopuniKategorije()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Kategorija";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtk = new DataTable();
            try
            {
                da.Fill(dtk);
                dataGridViewKategorije.DataSource = dtk;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greške: \n" + ex.Message);
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
            }
        }

        private void dataGridViewKategorije_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKategorije.SelectedRows.Count == 0)
            {
                textBoxIDKat.Text = "";
                textBoxNazivKat.Text = "";
            }
            else
            {
                textBoxIDKat.Text = dataGridViewKategorije.
                    SelectedRows[0].Cells[0].Value.ToString();
                textBoxNazivKat.Text = dataGridViewKategorije.
                    SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Kategorija " +
                "VALUES (@idKat,@nazKat)";
            cmd.Parameters.AddWithValue
                ("@idKat", Convert.ToInt32(textBoxIDKat.Text));
            cmd.Parameters.AddWithValue
                ("@nazKat", textBoxNazivKat.Text);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                PopuniKategorije();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greške: \n" + ex.Message);
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Kategorija " +
                "WHERE KategorijaID=@idKat " +
                "AND Naziv=@nazKat";
            cmd.Parameters.AddWithValue
                ("@idKat", Convert.ToInt32(textBoxIDKat.Text));
            cmd.Parameters.AddWithValue
                ("@nazKat", textBoxNazivKat.Text);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                PopuniKategorije();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greške: \n" + ex.Message);
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }
        }

        private void buttonIzmenaKategorije_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Kategorija " +
                "SET Naziv=@nazKat " +
                "WHERE KategorijaID=@idKat";
            cmd.Parameters.AddWithValue
                ("@idKat", Convert.ToInt32(textBoxIDKat.Text));
            cmd.Parameters.AddWithValue
                ("@nazKat", textBoxNazivKat.Text);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                PopuniKategorije();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greške: \n" + ex.Message);
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }

        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}