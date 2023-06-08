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
    public partial class Editar : Form
    {
        static string path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "BaseDatos.mdf";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + "; Integrated Security=True;";
        int valorMeses, year;

        public Editar()
        {
            InitializeComponent();
        }

        
        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBManzana1.SelectedItem == null)
            {
                cBNombre.Visible = false;
                labelNombre.Visible = false;
            }
            else
            {
                cBNombre.Visible = true;
                labelNombre.Visible = true;
            }

            cBNombre.Items.Clear();

            if (cBNombre.SelectedItem == null)// esconde los datos si el combobox manzana cambia
            {
                labelUsiario.Visible = false;
                label3.Visible = false;
                label2.Visible = false;   
                panel2.Visible = false;
                panel3.Visible = false;
                txtBoxNombre.Visible = false;
                textBoxDireccion.Visible = false;
                cBManzana.Visible = false;
                btnPago.Visible = false;
                
                label9.Visible = false;
            }

            string query1 = "SELECT Nombre_persona FROM Persona WHERE manzana = '" + cBManzana1.Text + "' ORDER BY Nombre_persona";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                SqlCommand comand = new SqlCommand(query1, con);

                DataTable datatable = new DataTable();
                SqlDataReader reader = comand.ExecuteReader();
                //adapter.Fill(datatable);

                while (reader.Read())
                {
                    cBNombre.Items.Add(reader["Nombre_persona"].ToString());
                }
            }


        }
        */
        private void cBNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBNombre.SelectedItem == null)
            {
                // cBTipoPago.Visible = false;
                //  label1.Visible = false;
            }
            else
            {
                labelUsiario.Visible = true;
                label3.Visible = true;
                label2.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                txtBoxNombre.Visible = true;
                textBoxDireccion.Visible = true;
                cBManzana.Visible = true;
                btnPago.Visible = true;
                
                label9.Visible = true;
            }

            /* for (int cont = 2021; cont < 2027;)
             {
                 string query10 = "SELECT a.UltimoMes FROM Pagos" + cont + " a, Persona b WHERE Nombre_persona = '" + cBNombre.Text + "' AND b.Id_persona = a.id_" + cont + "";
                 using (SqlConnection con = new SqlConnection(connectionString))
                 {
                     con.Open();
                     SqlDataAdapter adapter = new SqlDataAdapter(query10, con);
                     SqlCommand comand = new SqlCommand(query10, con);

                     DataTable datatable = new DataTable();
                     SqlDataReader reader = comand.ExecuteReader();

                     while (reader.Read())
                     {

                         if (String.IsNullOrEmpty(reader["UltimoMes"].ToString()))
                         {
                             valorMeses = 13;
                         }
                         else
                         {
                             valorMeses = Convert.ToInt32(reader["UltimoMes"]);
                         }

                         if(valorMeses == 12)
                         {
                             cont++;
                         }
                         else
                         {
                             if (valorMeses == 13)
                             {
                                 valorMeses = 12;
                                 year = cont;
                                 year--;
                                 cont = 2028;
                             }
                             else
                             {
                                 year = cont;
                                 cont = 2028;
                             }
                         }
                     }
                 }
             }
             */
       

            string query1 = "SELECT Nombre_persona, Direccion_persona, manzana FROM Persona WHERE Nombre_persona = '" + cBNombre.Text + "';";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                //SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                SqlCommand comand = new SqlCommand(query1, con);

                DataTable datatable = new DataTable();
                SqlDataReader reader = comand.ExecuteReader();
                //adapter.Fill(datatable);

                while (reader.Read())
                {
                    txtBoxNombre.Text = reader["Nombre_persona"].ToString();
                    textBoxDireccion.Text = reader["Direccion_Persona"].ToString();
                    cBManzana.Text = reader["manzana"].ToString();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre1.Text == "")
            {
                cBNombre.Visible = false;
                labelNombre.Visible = false;
                MessageBox.Show("Faltan datos");
            }
            else
            {
                cBNombre.Visible = true;
                labelNombre.Visible = true;
            }
            cBNombre.Items.Clear();

            if (cBNombre.SelectedItem == null)// esconde los datos si el combobox manzana cambia
            {
                labelUsiario.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                txtBoxNombre.Visible = false;
                textBoxDireccion.Visible = false;
                cBManzana.Visible = false;
                btnPago.Visible = false;

                label9.Visible = false;
            }

            string query1 = "SELECT Nombre_persona FROM Persona WHERE Nombre_persona LIKE '%" + textBoxNombre1.Text + "%' ORDER BY Nombre_persona";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand comand = new SqlCommand(query1, con);

                DataTable datatable = new DataTable();
                SqlDataReader reader = comand.ExecuteReader();


                //adapter.Fill(datatable);

                while (reader.Read())
                {
                    cBNombre.Items.Add(reader["Nombre_persona"].ToString());

                }   //updated.
                if (reader.HasRows == false)
                {
                    MessageBox.Show("Sin resultados");
                    cBNombre.Visible = false;
                    labelNombre.Visible = false;
                }

            }
        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            if (txtBoxNombre.Text == "" || String.IsNullOrEmpty(txtBoxNombre.Text))
            {
                MessageBox.Show("Te faltaron datos");
            }
            else if (String.IsNullOrEmpty(cBManzana.Text))
            {
                MessageBox.Show("Te faltaron datos");
            }
            else
            {
                string query6 = "Update Persona SET Nombre_persona = '"+ txtBoxNombre.Text +"', Direccion_persona = '"+ textBoxDireccion.Text + "', manzana = '" + cBManzana.Text+ "' FROM Persona WHERE Nombre_persona = '" + cBNombre.Text + "';";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand(query6, con);
                    SqlDataReader reader = comand.ExecuteReader();
                }
            }
            
            labelUsiario.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            txtBoxNombre.Visible = false;
            textBoxDireccion.Visible = false;
            cBManzana.Visible = false;
            btnPago.Visible = false;
            
            label9.Visible = false;
         
            cBNombre.Visible = false;
            labelNombre.Visible = false;
            MessageBox.Show("Persona editada");
        }
    }
}
