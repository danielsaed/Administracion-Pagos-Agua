using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    
    public partial class Form2 : Form
    {
        static string path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "BaseDatos.mdf";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + "; Integrated Security=True;";

        string paat,name;
        string[] meses = { "Diciembre", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", "Año pagado" };
        string[] manzanas = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "Y", "W", "X", "Z" };
        int Id,x1,x2;

        public Form2()
        {
            InitializeComponent();           
            AbrirFormInPanel(new FormPDF());
            panel10.Visible = true;
        }
        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }
        public void AbrirFormInPanel(object Formhijo)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormPDF());
            panel10.Visible = true;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormPDF());
            panel10.Visible = true;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormReporte());
            panel10.Visible = false;
            panel11.Visible = true;
            panel12.Visible = false;
            panel13.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormModificar());
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = true;
        }

        private void buttonReporteCaja_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormReporteCaja());
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = true;
            panel13.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        

        /*private void button1_Click_1(object sender, EventArgs e)
        {
            Id = 10021;
            for(int c1 = 0; c1 < 1550; c1++){ 
            for (int x = 21; x <= 35; x++)
            {
                string query4 = "DELETE FROM Pagos20" + x + " WHERE Id_20" + x + " = " + Id + ";";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query4, con);
                    SqlCommand comand = new SqlCommand(query4, con);
                    SqlDataReader reader = comand.ExecuteReader();
                }
            }

            string query3 = "DELETE FROM Persona WHERE Id_persona = " + Id + ";";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query3, con);
                SqlCommand comand = new SqlCommand(query3, con);
                SqlDataReader reader = comand.ExecuteReader();
            }
                Id++;
            }
            
        }
        */
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            
   
            
        }

        /*  private void button1_Click(object sender, EventArgs e)
          {
              for(int ins = 0; ins < 1501; ins++)
              {

                Random rnd = new Random();
                int randomNum = rnd.Next(0, 16); // creates a number between 1 and 12

                name = GenerateName(10);

                string query1 = "SELECT folio, Id FROM Ids;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                    SqlCommand comand = new SqlCommand(query1, con);

                    DataTable datatable = new DataTable();
                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Id"]);
                        //  suma = Convert.ToInt32(reader["cont"]);
                    }
                }
                //INSERTA LOS DATOS A PERSONA
                string query2 = "INSERT INTO Persona (Id_persona, Nombre_persona, Direccion_persona, manzana) Values( " + Id + ", '" + name + "','','"+manzanas[randomNum]+"');";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand(query2, con);
                    SqlDataReader reader = comand.ExecuteReader();
                }


                for (int cont = 21; cont < 36; cont++)
                {
                    string query3 = "INSERT INTO Pagos20" + cont + " (Id_20" + cont + ") Values(" + Id + ");";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand comand = new SqlCommand(query3, con);
                        SqlDataReader reader = comand.ExecuteReader();
                    }

                }

                string query10 = "UPDATE Pagos2021 SET Julio = 0, Agosto = 0, Septiembre = 0, Octubre = 0, Noviembre = 0, Diciembre = 0 WHERE Id_2021 = " + Id + ";";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand(query10, con);
                    SqlDataReader reader = comand.ExecuteReader();
                }

                for (int cont10 = 22; cont10 < 36; cont10++)
                {
                    string query3 = "UPDATE Pagos20" + cont10 + " SET Enero = 0, Febrero = 0, Marzo = 0, Abril = 0, Mayo = 0, Junio = 0, Julio = 0, Agosto = 0, Septiembre = 0, Octubre = 0, Noviembre = 0, Diciembre = 0 WHERE Id_20" + cont10 + " = " + Id + ";";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand comand = new SqlCommand(query3, con);
                        SqlDataReader reader = comand.ExecuteReader();
                    }

                }

                x1 = 2021;
                x2 = 11;
                for (int cont1 = 2021; cont1 <= x1;)
                {
                    if (cont1 == 2021)
                    {
                        string query6 = "Update Pagos" + cont1 + " SET UltimoMes = "+ x2 +" FROM Persona p, Pagos" + cont1 + " pp WHERE Nombre_persona = '" + name + "' AND p.Id_persona = pp.id_" + cont1 + "; ";
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            SqlCommand comand = new SqlCommand(query6, con);
                            SqlDataReader reader = comand.ExecuteReader();
                        }
                    }
                    else
                    {
                        string query5 = "Update Pagos" + cont1 + " SET UltimoMes = 12;";
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            SqlCommand comand = new SqlCommand(query5, con);
                            SqlDataReader reader = comand.ExecuteReader();
                        }
                    }

                    cont1++;
                }


                Id++;

                string query4 = "UPDATE Ids SET Id = '" + Id.ToString() + "';";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand(query4, con);
                    SqlDataReader reader = comand.ExecuteReader();
                }

              }


    }*/
    }

}

