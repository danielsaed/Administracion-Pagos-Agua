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
    public partial class FormEditarPagos : Form
    {
        static string path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "BaseDatos.mdf";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + "; Integrated Security=True;";
        int year,year1,valorMeses,x1,x3;
        string[] meses = { "Diciembre", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", "Año pagado" };

        public FormEditarPagos()
        {
            
            InitializeComponent();
            txtBoxNombre.Focus();
        }

        private void txtBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                btnBuscar_Click(this, new EventArgs());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBoxNombre.Text == "")
            {
                cBNombre.Visible = false;
                label7.Visible = false;
                MessageBox.Show("Faltan datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cBNombre.Visible = true;
                label7.Visible = true;
            }
            cBNombre.Items.Clear();

            if (cBNombre.SelectedItem == null)// esconde los datos si el combobox manzana cambia
            {
                label1.Visible = false;
                labelAno.Visible = false;
                label1.Visible = false;
                labelTelefono.Visible = false;
                labelCantidadPagada.Visible = false;
                labelAno.Visible = false;
                panel5.Visible = false;
                btnEliminar.Visible = false;
                labelMes.Visible = false;
                checkBox1.Visible = false;
                labelMostrarAno.Visible = false;
                labelMostrarMes.Visible = false;
                labelContraseña.Visible = false;
                panel2.Visible = false;
                txtBoxContraseña.Visible = false;
                label1.Visible = false;
            }
            try
            {
                string query1 = "SELECT Nombre_persona FROM Persona WHERE Nombre_persona LIKE '%" + txtBoxNombre.Text + "%' ORDER BY Nombre_persona";

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
                        MessageBox.Show("Sin resultados", "Sin resutaldos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cBNombre.Visible = false;
                        label7.Visible = false;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2");
            }
        }

        private void FormEditarPagos_Load(object sender, EventArgs e)
        {
            txtBoxNombre.Select();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                btnEliminar.Enabled = true;
                txtBoxContraseña.Enabled = true;
                txtBoxContraseña.Select();
            }
            else
            {
                btnEliminar.Enabled = false;
                txtBoxContraseña.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtBoxContraseña.Text == "borrar")
            {
                try
                {
                    string query3 = "UPDATE Pagos" + year + " SET " + meses[valorMeses] + " = '0', UltimoMes = @ultimomes FROM Persona a, Pagos" + year + " b WHERE Nombre_persona = @nombre AND  a.Id_persona = b.Id_" + year + "";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        //SqlDataAdapter adapter = new SqlDataAdapter(query3, con);
                        SqlCommand comand = new SqlCommand(query3, con);
                        DataTable datatable = new DataTable();

                        comand.Parameters.AddWithValue("@ultimomes", (valorMeses - 1));
                        comand.Parameters.AddWithValue("@nombre", cBNombre.Text);
                        comand.ExecuteNonQuery();
                        SqlDataReader reader = comand.ExecuteReader();
                    }
                   
                    MessageBox.Show("Pago eliminado", " Listo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error al eliminar pago", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                labelTelefono.Visible = false;
                panel5.Visible = false;
                labelCantidadPagada.Visible = false;
                btnEliminar.Visible = false;
                btnEliminar.Enabled = false;
                checkBox1.Visible = false;
                checkBox1.Checked = false;
                labelMes.Visible = false;
                labelAno.Visible = false;
                labelMostrarAno.Visible = false;
                labelMostrarMes.Visible = false;

                labelContraseña.Visible = false;
                panel2.Visible = false;
                txtBoxContraseña.Visible = false;
                txtBoxContraseña.Text = "";
                label1.Visible = false;

            }
            else
            {
                MessageBox.Show("contraseña incorrecta", " Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxContraseña.Text = "";
                checkBox1.Checked = false;
            }
            
            

        }

        private void cBNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

            //cBNombre.ResetText();
            if (cBNombre.SelectedItem == null)
            {
                label1.Visible = false;
                labelAno.Visible = false;
            }
            else
            {
                label1.Visible = true;
                labelAno.Visible = true;
                labelMes.Visible = true;
                labelTelefono.Visible = false;
                labelCantidadPagada.Visible = false;
                panel5.Visible = false;
                btnEliminar.Visible = false;
                labelMostrarAno.Visible = true;
                labelMostrarMes.Visible = true;

                checkBox1.Visible = false;
                // cBAno.Items.Clear();
                year = 2021;

                for (int a = 0; a == 0;)
                {
                    string query2 = "SELECT a.UltimoMes FROM Pagos" + year + " a, Persona b WHERE Nombre_persona = '" + cBNombre.Text + "' AND b.Id_persona = a.id_" + year + "";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        //      SqlDataAdapter adapter = new SqlDataAdapter(query2, con);
                        SqlCommand comand = new SqlCommand(query2, con);
                        DataTable datatable = new DataTable();
                        SqlDataReader reader = comand.ExecuteReader();

                        while (reader.Read())
                        {

                            if (String.IsNullOrEmpty(reader["UltimoMes"].ToString()))
                            {
                                valorMeses = 0;
                            }
                            else
                            {
                                valorMeses = Convert.ToInt32(reader["UltimoMes"]);
                            }
                        }
                    }
                    if (valorMeses != 0)
                    {
                    }
                    if (valorMeses == 12)
                    {
                        year = year + 1;
                    }
                    else
                    {
                        a = 1;
                    }
                }
                if(valorMeses == 0)
                {
                    year -= 1;
                    valorMeses = 12;
                }
                labelMostrarAno.Text = year.ToString();
                labelMostrarMes.Text = meses[valorMeses];
                label1.Visible = true;
                labelTelefono.Visible = true;
                panel5.Visible = true;
                labelCantidadPagada.Visible = true;
                btnEliminar.Visible = true;
                btnEliminar.Enabled = false;
                checkBox1.Visible = true;
                checkBox1.Checked = false;
                labelContraseña.Visible = true;
                panel2.Visible = true;
                txtBoxContraseña.Visible = true;
                txtBoxContraseña.Focus();


                try
                {
                    string query1 = "SELECT " + meses[valorMeses] + " FROM Pagos" + year + " a, Persona b WHERE Nombre_persona = '" + cBNombre.Text + "' AND b.Id_persona = a.id_" + year + "";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        //     SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                        SqlCommand comand = new SqlCommand(query1, con);

                        DataTable datatable = new DataTable();
                        SqlDataReader reader = comand.ExecuteReader();

                        while (reader.Read())
                        {
                            labelTelefono.Text = (reader["" + meses[valorMeses] + ""].ToString());
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error 2", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
    }
}
