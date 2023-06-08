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
    public partial class FormReporte : Form
    {
        static string path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "BaseDatos.mdf";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + "; Integrated Security=True;";
        int valorMeses, valorPagoAnual;
        string[] meses = { "Diciembre", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", "Año pagado" };
        string[] columnas = { "Id", "Nombre", "Telefono", "Cantidad Pago" };
        int year = 2021, a = 0, x1, b = 0,contador1 = 0,valor,id;
        double suma,sumatotal,valor1;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBoxNombre.Text == "")
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
                labelTelefono.Visible = false;
                panel6.Visible = false;
                labelFecha1.Visible = false;
                panel6.Visible = false;
                labelFecha.Visible = false;
                labelMes.Visible = false;
                labelFecha1.Visible = false;
                checkBConfirmar.Visible = false;
                panel5.Visible = false;
                labelAño.Visible = false;
                cBTipoReporte.Visible = false;
                labelTipoReporte.Visible = false;
                cBAno.Visible = false;
                cBMes.Visible = false;
                labelAno.Visible = false;
                labelCantidadPagada.Visible = false;
            }

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
                    MessageBox.Show("Sin resultados");
                    cBNombre.Visible = false;
                    labelNombre.Visible = false;
                }

            }
        }

        string mes,mes1,var;

        private void checkBConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBConfirmar.Checked)
            {
                btnPago.Visible = true;
                numericUpDown1.Visible = true;
                label1.Visible = true;
            }
            else
            {
                
                btnPago.Visible = false;
                numericUpDown1.Visible = false;
                label1.Visible = false;
            }
            

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(numericUpDown1.Value);

            string query3 = "SELECT Id_persona FROM Persona WHERE Nombre_persona = '"+cBNombre.Text+"' ;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
             //   SqlDataAdapter adapter = new SqlDataAdapter(query3, con);
                SqlCommand comand = new SqlCommand(query3, con);
                DataTable datatable = new DataTable();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id_persona"]);

                }
            }

            string query4 = "UPDATE Pagos" + x1 + " SET "+cBMes.Text+" = "+valor1+" FROM Pagos" + x1 + " WHERE Id_" + x1 + " = "+id+";";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
             //   SqlDataAdapter adapter = new SqlDataAdapter(query4, con);
                SqlCommand comand = new SqlCommand(query4, con);
                DataTable datatable = new DataTable();
                SqlDataReader reader = comand.ExecuteReader();
            }
            checkBConfirmar.Checked = false;
            labelNombre.Visible = false;
            cBNombre.Visible = false;
            MessageBox.Show("Actualizado");
            labelTelefono.Visible = false;
            panel6.Visible = false;
            labelFecha1.Visible = false;
            panel6.Visible = false;
            labelFecha.Visible = false;
            labelMes.Visible = false;
            labelFecha1.Visible = false;
            checkBConfirmar.Visible = false;
            panel5.Visible = false;
            labelAño.Visible = false;
            cBTipoReporte.Visible = false;
            labelTipoReporte.Visible = false;
            cBAno.Visible = false;
            cBMes.Visible = false;
            labelAno.Visible = false;
            labelCantidadPagada.Visible = false;
        }

        public FormReporte()
        {
            InitializeComponent();
        }

      /*  private void cBManzana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBManzana.SelectedItem == null)
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
                labelTelefono.Visible = false;
                panel6.Visible = false;
                labelFecha1.Visible = false;
                panel6.Visible = false;
                labelFecha.Visible = false;
                labelMes.Visible = false;
                labelFecha1.Visible = false;
                checkBConfirmar.Visible = false;
                panel5.Visible = false;
                labelAño.Visible = false;
                cBTipoReporte.Visible = false;
                labelTipoReporte.Visible = false;
                cBAno.Visible = false;
                cBMes.Visible = false;
                labelAno.Visible = false;
                labelCantidadPagada.Visible = false;
            }

            string query1 = "SELECT Nombre_persona FROM Persona WHERE manzana = '" + cBManzana.Text + "' ORDER BY Nombre_persona";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                SqlCommand comand = new SqlCommand(query1, con);
                DataTable datatable = new DataTable();
                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    cBNombre.Items.Add(reader["Nombre_persona"].ToString());
                }
            }
        }*/

        private void cBNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBNombre.SelectedItem == null)
            {
                cBTipoReporte.Visible = false;
                labelTipoReporte.Visible = false;
            }
            else
            {
                cBTipoReporte.Visible = true;
                labelTipoReporte.Visible = true;
                panel6.Visible = false;
                labelFecha1.Visible = false;
                labelFecha.Visible = false;
                labelAño.Visible = false;
                labelTelefono.Visible = false;
                labelMes.Visible = false;
                btnPago.Visible = false;
                panel5.Visible = false;
                
                cBAno.Visible = false;
                cBMes.Visible = false;
                labelAno.Visible = false;
                labelCantidadPagada.Visible = false;
                cBTipoReporte.Text = "";
                
                

            }
        }

        private void cBTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBAno.Items.Clear();
            if (cBTipoReporte.SelectedItem == null)
            {
                cBAno.Items.Clear();
                cBMes.Items.Clear();
                cBAno.Visible = false;
                labelAno.Visible = false;
                cBMes.Visible = false;
                labelMes.Visible = false;

            }
            if (cBTipoReporte.Text == "Anual")
            {
                cBAno.Items.Clear();
                cBMes.Items.Clear();
                cBMes.Visible = false;
                labelMes.Visible = false;
                labelTelefono.Visible = false;              
                checkBConfirmar.Visible = false;
                labelCantidadPagada.Visible = false;
                panel5.Visible = false;
                labelAno.Visible = true;
                cBAno.Visible = true;
                panel6.Visible = true;
                labelFecha1.Visible = true;
                labelFecha.Visible = true;
                labelAño.Visible = true;

                year = 2021;
                for (int a = 0; a == 0;)
                {
                    string query1 = "SELECT a.UltimoMes FROM Pagos" + year + " a, Persona b WHERE Nombre_persona = '" + cBNombre.Text + "' AND b.Id_persona = a.id_" + year + "";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                 //       SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                        SqlCommand comand = new SqlCommand(query1, con);
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

                    

                    if (valorMeses == 12)
                    {
                        cBAno.Items.Add(year);
                        year = year + 1;
                    }
                    else if (valorMeses != 0)
                    {
                        cBAno.Items.Add(year);
                        a = 1;
                    }
                    else
                    {
                        a = 1;
                    }
                    labelFecha.Text = meses[valorMeses];

                    if (valorMeses == 12 || valorMeses == 0)
                    {
                        labelAño.Text = (year - 1).ToString();
                    }
                    else
                    {
                        labelAño.Text = year.ToString();
                    }
                }

            }
            if (cBTipoReporte.Text == "Mensual")
            {
                // cBAno.Items.Clear();

                labelTelefono.Visible = false;
                panel5.Visible = false;
 
                checkBConfirmar.Visible = false;
                
                labelCantidadPagada.Visible = false;
                labelAno.Visible = true;
                cBAno.Visible = true;
                panel6.Visible = true;
                labelFecha1.Visible = true;
                labelFecha.Visible = true;
                labelAño.Visible = true;

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
                        cBAno.Items.Add(year);
                    }

                    if (valorMeses == 12)
                    {
                        year = year + 1;
                    }
                    else
                    {
                        a = 1;
                    }
                    cBMes.Items.Clear();
                }
                labelFecha.Text = meses[valorMeses];

                if (valorMeses == 12 || valorMeses == 0)
                {
                    labelAño.Text = (year - 1).ToString();
                }
                else
                {
                    labelAño.Text = year.ToString();
                }
            }
            if (cBTipoReporte.Text == "")
            {
                cBMes.Visible = false;
                labelMes.Visible = false;
                labelTelefono.Visible = false;

                checkBConfirmar.Visible = false;

                labelCantidadPagada.Visible = false;
                labelAno.Visible = false;
                cBAno.Visible = false;
                panel5.Visible = false;
            }

        }

        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBAno.SelectedItem == null)
            {
                cBMes.Visible = false;
                labelMes.Visible = false;
            }
            else
            {
                labelTelefono.Visible = false;

                checkBConfirmar.Visible = false;

                panel5.Visible = false;
                labelCantidadPagada.Visible = false;
            }

            if (cBTipoReporte.Text == "Anual")
            {
                sumatotal = 0;
                labelTelefono.Text = "";
                labelTelefono.Visible = true;

                checkBConfirmar.Visible = false;

                panel5.Visible = true;
                labelCantidadPagada.Visible = true;

                int contador = 0;
                mes = "";
                mes1 = "";
                x1 = Int32.Parse(this.cBAno.SelectedItem.ToString());
                b = 0;
                if (x1 == 2021)
                    contador = 6;
                do
                {

                    string query1 = "SELECT a.UltimoMes, a." + meses[contador + 1] + " FROM Pagos" + x1 + " a, Persona b WHERE Nombre_persona = '" + cBNombre.Text + "' AND b.Id_persona = a.id_" + x1 + "";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                      //  SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                        SqlCommand comand = new SqlCommand(query1, con);

                        DataTable datatable = new DataTable();
                        SqlDataReader reader = comand.ExecuteReader();

                        while (reader.Read())
                        {
                            if(reader[meses[contador + 1]] == null)
                            {
                                b = 1;
                                suma = 0;
                            }
                            else
                            {
                                
                                    suma = Convert.ToDouble(reader[meses[contador + 1]]);

                                valorMeses = Convert.ToInt32(reader["UltimoMes"]);
                                contador1++;
                            }
                            

                        }
                    }
                    
                    sumatotal = sumatotal + suma;

                    contador++;
                    if (valorMeses == contador)
                    {
                        b = 1;
                    }

                } while (b == 0);
                
                

                labelTelefono.Text = sumatotal.ToString();
                
            }
            if (cBTipoReporte.Text == "Mensual")
            {
                cBMes.Visible = true;
                labelMes.Visible = true;
                /*

                

                labelTelefono.Visible = false;
                panel5.Visible = false;
                btnPago.Visible = false;
                checkBox2.Visible = false;
                labelCantidadPagada.Visible = false;

                labelAno.Visible = true;
                cBAno.Visible = true;

                year = 2021;
                for (int a = 0; a == 0;)
                {
                    string query2 = "SELECT a.UltimoMes FROM Pagos" + year + " a, Persona b WHERE Nombre_persona = '" + cBNombre.Text + "' AND b.Id_persona = a.id_" + year + "";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(query2, con);
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
                                a = 1;
                            }
                        }
                    }
                    
                    if (valorMeses == 12)
                    {
                        if (!cBAno.Items.Contains(year))
                            cBAno.Items.Add(year);
                        year = year + 1;
                       
                    }
                    else
                    {
                        a = 1;
                    }
                    
                    
                }*/
                cBMes.Items.Clear();
                x1 = Int32.Parse(this.cBAno.SelectedItem.ToString());
                

                string query1 = "SELECT a.UltimoMes FROM Pagos" + x1 + " a, Persona b WHERE Nombre_persona = '" + cBNombre.Text + "' AND b.Id_persona = a.id_" + x1 + "";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                  //  SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                    SqlCommand comand = new SqlCommand(query1, con);

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

                    int x2 = 7;

                    for (int x = 0; x < valorMeses; x++)
                    {
                        if (x1 == 2021)
                        {
                            cBMes.Items.Add(meses[x2]);
                            if (x2 >= valorMeses)
                            {
                                x = 12;
                            }
                            x2++;
                        }
                        else
                        {
                            cBMes.Items.Add(meses[x + 1]);
                        }
                        
                    }
                }
            }
        }

        private void cBMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTelefono.Text = "";
            if (cBMes.SelectedItem == null)
            {
                labelTelefono.Visible = false;
                panel5.Visible = false;
                btnPago.Visible = false;
                
                labelCantidadPagada.Visible = false;
            }
            else
            {
                labelTelefono.Visible = true;

                checkBConfirmar.Visible = true;

                panel5.Visible = true;
                labelCantidadPagada.Visible = true;

                string query1 = "SELECT " + cBMes.Text + " FROM Pagos" + x1 + " a, Persona b WHERE Nombre_persona = '" + cBNombre.Text + "' AND b.Id_persona = a.id_" + x1 + "";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
               //     SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                    SqlCommand comand = new SqlCommand(query1, con);

                    DataTable datatable = new DataTable();
                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        labelTelefono.Text = (reader[""+cBMes.Text+""].ToString());

                    }
                }



            }
        }
    }
}
