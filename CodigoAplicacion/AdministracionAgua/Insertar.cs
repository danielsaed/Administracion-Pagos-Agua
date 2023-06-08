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

namespace WindowsFormsApp2
{
    public partial class Insertar : Form
    {
        static string path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "BaseDatos.mdf";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + "; Integrated Security=True;";

        int x1,x2;

        int Id;
        public Insertar()
        {
            InitializeComponent();
            
        }

        private void Insertar_Load(object sender, EventArgs e)
        {
            
        }

        private void cBAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (cBAno.Text == "2021")
            {
                cBMes.Items.Clear();
                cBMes.Items.Add("7");
                cBMes.Items.Add("8");
                cBMes.Items.Add("9");
                cBMes.Items.Add("10");
                cBMes.Items.Add("11");
                cBMes.Items.Add("12");
            }
            else
            {
                if (cBAno.Text == "")
                {
                    cBMes.Items.Clear();
                }
                else
                {
                    cBMes.Items.Clear();
                    cBMes.Items.Add("1");
                    cBMes.Items.Add("2");
                    cBMes.Items.Add("3");
                    cBMes.Items.Add("4");
                    cBMes.Items.Add("5");
                    cBMes.Items.Add("6");
                    cBMes.Items.Add("7");
                    cBMes.Items.Add("8");
                    cBMes.Items.Add("9");
                    cBMes.Items.Add("10");
                    cBMes.Items.Add("11");
                    cBMes.Items.Add("12");

                } 
            }
        }

        private void checkBConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBConfirmar.Checked)
            {
                btnInsertar.Enabled = true;
            }
            else
            {
                btnInsertar.Enabled = false;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
            if (txtBoxNombre.Text == "" || String.IsNullOrEmpty(txtBoxNombre.Text))
            {
                MessageBox.Show("Te faltaron datos");
            }
            else if (String.IsNullOrEmpty(cBManzana.Text) || cBAno.Text == "" || String.IsNullOrEmpty(cBMes.Text))
            {
                MessageBox.Show("Te faltaron datos");
            }
            else
            {
                
                string query1 = "SELECT folio, Id FROM Ids;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                  //  SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
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
                string query2 = "INSERT INTO Persona (Id_persona, Nombre_persona, Direccion_persona, manzana) Values( " + Id + ", '" + txtBoxNombre.Text + "','" + textBoxDireccion.Text + "','" + cBManzana.Text + "');";
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
                    string query3 = "UPDATE Pagos20" + cont10 + " SET Enero = 0, Febrero = 0, Marzo = 0, Abril = 0, Mayo = 0, Junio = 0, Julio = 0, Agosto = 0, Septiembre = 0, Octubre = 0, Noviembre = 0, Diciembre = 0 WHERE Id_20"+cont10+" = "+Id+";";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand comand = new SqlCommand(query3, con);
                        SqlDataReader reader = comand.ExecuteReader();
                    }

                }

                x1 = Int32.Parse(this.cBAno.SelectedItem.ToString());
                x2 = Int32.Parse(this.cBMes.SelectedItem.ToString());
                for (int cont1 = 2021; cont1 <= x1;)
                {
                    if (cont1 == x1)
                    {
                        string query6 = "Update Pagos" + cont1 + " SET UltimoMes = "+x2+ " FROM Persona p, Pagos"+ cont1 + " pp WHERE Nombre_persona = '" + txtBoxNombre.Text + "' AND p.Id_persona = pp.id_" + cont1 + "; ";
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
                MessageBox.Show("Insertado correctamente");
            }

            //OBTIENE EL FOLIO E ID
            txtBoxNombre.Text = "";
            textBoxDireccion.Text = "";
            cBManzana.Text = "";
            cBAno.Text = "";
            cBMes.Items.Clear();
            checkBConfirmar.Checked = false;
            



        }
    }
}
