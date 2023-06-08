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
    public partial class Eliminar : Form
    {
        static string path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "BaseDatos.mdf";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + "; Integrated Security=True;";
        int Id;

        public Eliminar()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        //ejemplo
       /* private void cBManzana1_SelectedIndexChanged(object sender, EventArgs e)
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
                btnPago.Visible = false;
                checkBConfirmar.Visible = false;
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
        }*/

        private void cBNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBNombre.SelectedItem == null)
            {
                btnPago.Visible = false;
                checkBConfirmar.Visible = false;
            }
            else
            {
                btnPago.Visible = true;
                checkBConfirmar.Visible = true;
            }
            
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT Id_persona FROM Persona WHERE Nombre_persona = '" + cBNombre.Text + "'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
               // SqlDataAdapter adapter = new SqlDataAdapter(query2, con);
                SqlCommand comand = new SqlCommand(query2, con);
                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Id = Convert.ToInt32(reader["Id_persona"]);
                }
            }

            for (int x = 21; x <= 35; x++)
            {
                string query4 = "DELETE FROM Pagos20" + x + " WHERE Id_20" + x + " = " + Id + ";";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                 //   SqlDataAdapter adapter = new SqlDataAdapter(query4, con);
                    SqlCommand comand = new SqlCommand(query4, con);
                    SqlDataReader reader = comand.ExecuteReader();
                }
            }

            string query3 = "DELETE FROM Persona WHERE Id_persona = " + Id + ";";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
             //   SqlDataAdapter adapter = new SqlDataAdapter(query3, con);
                SqlCommand comand = new SqlCommand(query3, con);
                SqlDataReader reader = comand.ExecuteReader();
            }

            MessageBox.Show("Persona eliminada");
            
            btnPago.Visible = false;
            checkBConfirmar.Visible = false;
            cBNombre.Visible = false;
            labelNombre.Visible = false;
            checkBConfirmar.Checked = false;
             
        }

        private void checkBConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBConfirmar.Checked)
            {
                btnPago.Enabled = true;
            }else
            {
                btnPago.Enabled = false;
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
                btnPago.Visible = false;
                checkBConfirmar.Visible = false;
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
    }
}
