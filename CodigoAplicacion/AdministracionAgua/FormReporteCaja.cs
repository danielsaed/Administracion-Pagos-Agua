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
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Borders;
using iText.IO.Image;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class FormReporteCaja : Form
    {
        static string path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "BaseDatos.mdf";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + "; Integrated Security=True;";
        int valorMeses, valorPagoAnual;
        string[] meses = { "Diciembre", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", "Año pagado" };
        string[] columnas = { "Id", "Nombre", "Telefono", "Cantidad Pago" };
        int year = 2021, a = 0, x1, b = 0, contador1 = 0, folio;
        double suma, sumatotal;
        string paat;
        string Pat = "C:/Users/Saed/source/repos/WindowsFormsApp2/WindowsFormsApp2/bin/Debug/Recibo.pdf";

        private void btnPago_Click(object sender, EventArgs e)
        {
            crearPDF();
            MessageBox.Show("Reporte generado");
            cBTipoReporte.Text = "";
            
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog v1 = new FolderBrowserDialog();
            //v1.Filter = "Text files (*.txt)|* .txt|All files (*.*)|*.*";
            if (v1.ShowDialog() == DialogResult.OK)
            {
                paat = v1.SelectedPath.Replace(@"\", @"\\");

                string query4 = "UPDATE Ids SET url = '" + paat + "';";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand(query4, con);
                    SqlDataReader reader = comand.ExecuteReader();
                }
                label30.Text = paat;
            }
        }

        private void FormReporteCaja_Load(object sender, EventArgs e)
        {

        }

        string mes, mes1,FechaReporte, FechaReporte1;
        string imageSource = "logo.jpg";

        public FormReporteCaja()
        {
            InitializeComponent();
            string query4 = "SELECT url FROM Ids;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand comand = new SqlCommand(query4, con);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    paat = (reader["url"]).ToString();
                }
            }
            label30.Text = paat;
        }

        private void crearPDF()
        {
            string query1 = "SELECT folio, Id FROM Ids;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
               // SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                SqlCommand comand = new SqlCommand(query1, con);

                DataTable datatable = new DataTable();
                SqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    folio = Convert.ToInt32(reader["folio"]);
                    //  suma = Convert.ToInt32(reader["cont"]);

                }
            }
            PdfWriter pdfWriter = new PdfWriter(paat + "\\Reporte" + cBTipoReporte.Text+"_"+FechaReporte+"_Fol"+folio+".pdf");
            Pat = paat + "\\Reporte" + cBTipoReporte.Text + "_" + FechaReporte + "_Fol" + folio + ".pdf";
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(20, 50, 55, 50);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);




            // Load image from disk
            ImageData imageData = ImageDataFactory.Create(imageSource);
            // Create layout image object and provide parameters. Page number = 1
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(imageData).ScaleAbsolute(65, 60).SetFixedPosition(1, 50, 710);
            // This adds the image to the page
            documento.Add(image);

            // Don't forget to close the document.
            // When you use Document, you should close it rather than PdfDocument instance







            float[] columnWidths2 = { 1, 4, 1 };
            Table table3_ = new Table(UnitValue.CreatePercentArray(columnWidths2));
            table3_.SetWidth(UnitValue.CreatePercentValue(100));

            Cell cell3_ = new Cell().Add(new Paragraph(""))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
            table3_.AddCell(cell3_);
            cell3_ = new Cell().Add(new Paragraph("COMITE DE AGUA POTABLE").SetFontSize(14))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBold()
                .SetBorder(Border.NO_BORDER);
            table3_.AddCell(cell3_);
            cell3_ = new Cell().Add(new Paragraph(DateTime.Today.ToString("dd-MM-yyyy")))
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBorder(Border.NO_BORDER);
            table3_.AddCell(cell3_);

            documento.Add(table3_);

            Table table101 = new Table(UnitValue.CreatePercentArray(columnWidths2));
            table101.SetWidth(UnitValue.CreatePercentValue(100));
            Cell cell101 = new Cell().Add(new Paragraph("").SetFontSize(14))
                   .SetBold()
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetBorder(Border.NO_BORDER);
            table101.AddCell(cell101);
            cell101 = new Cell().Add(new Paragraph("EJIDO EL AGUACATE").SetFontSize(14))
              .SetBold()
              .SetTextAlignment(TextAlignment.CENTER)
              .SetBorder(Border.NO_BORDER);
            table101.AddCell(cell101);
            cell101 = new Cell().Add(new Paragraph("Folio: " + folio))
              .SetTextAlignment(TextAlignment.RIGHT)
              .SetBorder(Border.NO_BORDER);
            table101.AddCell(cell101);
            documento.Add(table101);

            Table table102 = new Table(1).UseAllAvailableWidth();
            Cell cell102 = new Cell().Add(new Paragraph("MPIO, DE TEPIC, NAYARIT.").SetFontSize(8))
              .SetTextAlignment(TextAlignment.CENTER)
              .SetBorder(Border.NO_BORDER);
            table102.AddCell(cell102);
            documento.Add(table102);

          /*  Table table = new Table(1).UseAllAvailableWidth();
            Cell cell = new Cell().Add(new Paragraph("").SetFontSize(14))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBorder(Border.NO_BORDER);
            table.AddCell(cell);
            documento.Add(table); */

            Table table33 = new Table(1).UseAllAvailableWidth();
            Cell cell33 = new Cell().Add(new Paragraph("Reporte " + cBTipoReporte.Text).SetFontSize(14))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBorder(Border.NO_BORDER);
            table33.AddCell(cell33);
            documento.Add(table33);

            Paragraph o3 = new Paragraph("");
            o3.SetMarginBottom(10f);
            documento.Add(o3);

            Table table_1 = new Table(1).UseAllAvailableWidth();

            Cell cell_1 = new Cell().Add(new Paragraph("__________________________________________________________________________"))
                .SetTextAlignment(TextAlignment.LEFT)
                // .SetBold()
                .SetBorder(Border.NO_BORDER);
            table_1.AddCell(cell_1);

            documento.Add(table_1);

            float[] columnWidths = { 3, 2, 1 };

            Table _table = new Table(UnitValue.CreatePercentArray(columnWidths));
            _table.SetWidth(UnitValue.CreatePercentValue(100));
            Cell _cell = new Cell().Add(new Paragraph("Fecha:").SetFontSize(10))
                .SetBold()
                .SetBorder(Border.NO_BORDER);
            _table.AddCell(_cell);

            _cell = new Cell().Add(new Paragraph("Cantidad:").SetFontSize(10))
                .SetBold()
                .SetBorder(Border.NO_BORDER);
            _table.AddCell(_cell);

            _cell = new Cell().Add(new Paragraph("").SetFontSize(10))
            .SetBold()
        .SetBorder(Border.NO_BORDER);
            _table.AddCell(_cell);

            documento.Add(_table);

            Paragraph o2 = new Paragraph("");
            o2.SetMarginBottom(15f);
            documento.Add(o2);

            Table _table1 = new Table(UnitValue.CreatePercentArray(columnWidths));
            _table1.SetWidth(UnitValue.CreatePercentValue(100));

            Cell _cell1 = new Cell().Add(new Paragraph(FechaReporte1).SetFontSize(10))
                .SetBorder(Border.NO_BORDER);
            _table1.AddCell(_cell1);

            _cell1 = new Cell().Add(new Paragraph("$ " + labelTelefono.Text).SetFontSize(10))
                .SetBorder(Border.NO_BORDER);
            _table1.AddCell(_cell1);

            _cell1 = new Cell().Add(new Paragraph().SetFontSize(10))
                .SetBorder(Border.NO_BORDER);
            _table1.AddCell(_cell1);

            documento.Add(_table1);

            Table table_2 = new Table(1).UseAllAvailableWidth();

            Cell cell_2 = new Cell().Add(new Paragraph("__________________________________________________________________________"))
                .SetTextAlignment(TextAlignment.LEFT)
                // .SetBold()
                .SetBorder(Border.NO_BORDER);
            table_2.AddCell(cell_2);

            documento.Add(table_2);

            //_cell = new Cell(1,0).Add(new Paragraph("Nombre").SetFontSize(10));
            //_table.AddCell(_cell);


            Paragraph o1 = new Paragraph("");
            o1.SetMarginBottom(60f);
            documento.Add(o1);
            /*
                Table table2 = new Table(4).UseAllAvailableWidth();
                Cell cell2 = new Cell(1,2).Add(new Paragraph("Nombre   ").SetFontSize(10));
                table2.AddCell(cell2);
                cell2 = new Cell().Add(new Paragraph("Concepto").SetFontSize(10));
                table2.AddCell(cell2);
                cell2 = new Cell().Add(new Paragraph("Fecha a pagar").SetFontSize(10));
                table2.AddCell(cell2);
                cell2 = new Cell().Add(new Paragraph("Recibido").SetFontSize(10));
                table2.AddCell(cell2);

                documento.Add(table2);
                */

            Table table1 = new Table(1).UseAllAvailableWidth();

            Cell cell1 = new Cell().Add(new Paragraph("________________________________________"))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBorder(Border.NO_BORDER);
            table1.AddCell(cell1);

            documento.Add(table1);
            float[] columnWidths1 = { 1, 4, 1 };
            Table table3 = new Table(UnitValue.CreatePercentArray(columnWidths1));
            table3.SetWidth(UnitValue.CreatePercentValue(100));

            Cell cell3 = new Cell().Add(new Paragraph(""))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
            table3.AddCell(cell3);
            cell3 = new Cell().Add(new Paragraph("Tesoreria"))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBorder(Border.NO_BORDER);
            table3.AddCell(cell3);
            cell3 = new Cell().Add(new Paragraph(""))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBold()
                .SetBorder(Border.NO_BORDER);
            table3.AddCell(cell3);

            documento.Add(table3);

            folio++;
            string query4 = "UPDATE Ids SET folio = '" + folio.ToString() + "';";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand comand = new SqlCommand(query4, con);
                SqlDataReader reader = comand.ExecuteReader();
            }
            /*
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach(string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }
            Paragraph o1 = new Paragraph("");
            o1.SetMarginBottom(50f);

            string query = "SELECT Id_persona, Nombre_persona, Telefono_persona FROM Persona where Nombre_persona = 'pancho'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommand comand = new SqlCommand(query, con);

                DataTable datatable = new DataTable();
                SqlDataReader reader = comand.ExecuteReader();
                //adapter.Fill(datatable);


                    while (reader.Read()) {
                        tabla.AddCell(new Cell().Add(new Paragraph(reader["Id_persona"].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader["Nombre_persona"].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader["Telefono_persona"].ToString()).SetFont(fontContenido)));
                    }

            }
            documento.Add(tabla);
            documento.Add(o1);
            */
            documento.Close();

            Process process = new Process();

            process.StartInfo.FileName = Pat;
            process.StartInfo.Verb = "printto";
            // process.StartInfo.Arguments = "\"" + printerName + "\"";
            process.Start();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBAno.SelectedIndex = -1;

            if (cBTipoReporte.Text == "")
            {
                label2.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                label8.Visible = false;
                label10.Visible = false;
                labelTelefono.Visible = false;
                panel4.Visible = false;
                panel1.Visible = false;
                btnPago.Visible = false;
               
                cBAno.Visible = false;
                cBMes.Visible = false;
            }
            if (cBTipoReporte.Text == "Anual")
            {

                
                label2.Visible = false;
                label3.Visible = false;
                label6.Visible = true;
                label8.Visible = false;
                label10.Visible = false;
                labelTelefono.Visible = false;
                panel4.Visible = false;
                panel1.Visible = false;
                btnPago.Visible = false;
                
                cBAno.Visible = true;
                cBMes.Visible = false;
                




            }
            if (cBTipoReporte.Text == "Mensual")
            {
                label2.Visible = false;
                label3.Visible = false;
                label6.Visible = true;
                label8.Visible = false;
                label10.Visible = false;
                labelTelefono.Visible = false;
                panel4.Visible = false;
                panel1.Visible = false;
                btnPago.Visible = false;
               
                cBAno.Visible = true;
                cBMes.Visible = false;
                cBAno.SelectedIndex = -1;
            }
        }

        private void cBAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cBTipoReporte.Text = "";
            cBMes.Items.Clear();
            cBMes.Visible = false;
            if (cBTipoReporte.Text == "")
            {
                
            }
            
            if (cBTipoReporte.Text == "Anual")
            {
              if (String.IsNullOrEmpty(cBAno.Text))
                { }
              else { 

                labelTelefono.Text = "";
                label2.Visible = false;
                label3.Visible = false;
                label6.Visible = true;
                label10.Visible = true;
                labelTelefono.Visible = true;
                panel4.Visible = true;
                panel1.Visible = false;
                btnPago.Visible = true;
               

                x1 = Int32.Parse(this.cBAno.SelectedItem.ToString());

                if (x1 == 2021)
                {
                    string query2 = "SELECT SUM(Julio + Agosto + Septiembre + Octubre + Noviembre + Diciembre) AS total FROM Pagos" + x1 + "";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                       // SqlDataAdapter adapter = new SqlDataAdapter(query2, con);
                        SqlCommand comand = new SqlCommand(query2, con);

                        DataTable datatable = new DataTable();
                        SqlDataReader reader = comand.ExecuteReader();

                        while (reader.Read())
                        {
                            sumatotal = Convert.ToInt32(reader["total"]);
                            //  suma = Convert.ToInt32(reader["cont"]);
                        }
                    }
                }
                else
                {
                    if (cBAno.Text == "")
                    {
                    }
                    else
                    {

                        string query2 = "SELECT SUM(Enero + Febrero + Marzo + Abril + Mayo + Junio + Julio + Septiembre + Octubre + Noviembre + Diciembre) AS total FROM Pagos" + x1 + "";
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                          //  SqlDataAdapter adapter = new SqlDataAdapter(query2, con);
                            SqlCommand comand = new SqlCommand(query2, con);

                            DataTable datatable = new DataTable();
                            SqlDataReader reader = comand.ExecuteReader();

                            while (reader.Read())
                            {
                                sumatotal = Convert.ToInt32(reader["total"]);
                                //          suma = Convert.ToInt32(reader["cont"]);
                            }
                        }
                    }
                }
                labelTelefono.Text = sumatotal.ToString();
                    FechaReporte = "Año" + cBAno.Text;
                    FechaReporte1 = "Año " + cBAno.Text;

                    //  label2.Text = suma.ToString()
                }
            }

            if (cBTipoReporte.Text == "Mensual")
            {
                if (cBAno.Text == "")
                {
                    label8.Visible = false;
                    cBMes.Visible = false;
                }
                else { 

                    label2.Visible = false;
                    label3.Visible = false;
                    label6.Visible = true;
                    label8.Visible = true;
                    label10.Visible = false;
                    labelTelefono.Visible = false;
                    panel4.Visible = false;
                    panel1.Visible = false;
                    btnPago.Visible = false;
              
                    cBMes.Visible = true;

                    if (cBAno.Text == "2021")
                    {
                        cBMes.Items.Add("Julio");
                        cBMes.Items.Add("Agosto");
                        cBMes.Items.Add("Septiembre");
                        cBMes.Items.Add("Octubre");
                        cBMes.Items.Add("Noviembre");
                        cBMes.Items.Add("Diciembre");
                    
                    }
                    else
                    {
                        cBMes.Items.Add("Enero");
                        cBMes.Items.Add("Febrero");
                        cBMes.Items.Add("Marzo");
                        cBMes.Items.Add("Abril");
                        cBMes.Items.Add("Mayo");
                        cBMes.Items.Add("Junio");
                        cBMes.Items.Add("Julio");
                        cBMes.Items.Add("Agosto");
                        cBMes.Items.Add("Septiembre");
                        cBMes.Items.Add("Octubre");
                        cBMes.Items.Add("Noviembre");
                        cBMes.Items.Add("Diciembre");
                    }
                }
            }
        }

        private void cBMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBTipoReporte.Text == "")
            {

            }

            if (cBTipoReporte.Text == "Mensual")
            {
                labelTelefono.Text = "";
                label2.Visible = false;
                label3.Visible = false; 
                label6.Visible = true;
                label10.Visible = true;
                labelTelefono.Visible = true;
                panel4.Visible = true;
                panel1.Visible = false;
                btnPago.Visible = true;


                x1 = Int32.Parse(this.cBAno.SelectedItem.ToString());

                string query2 = "SELECT SUM("+cBMes.Text+ ") as total,COUNT(" + cBMes.Text + ") AS cont FROM Pagos" + x1 + " WHERE " + cBMes.Text + " > 1 ";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                 //   SqlDataAdapter adapter = new SqlDataAdapter(query2, con);
                    SqlCommand comand = new SqlCommand(query2, con);

                    DataTable datatable = new DataTable();
                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {   try
                        {
                            sumatotal = Convert.ToInt32(reader["total"]);
                            suma = Convert.ToInt32(reader["cont"]);
                        }
                        catch
                        {
                            sumatotal = 0;
                            suma = 0;
                        }
                        
                        
                    }
                }

                labelTelefono.Text = sumatotal.ToString();
                label2.Text = suma.ToString();

                FechaReporte ="Año-" + cBAno.Text +"_Mes-" + cBMes.Text;
                FechaReporte1 = cBMes.Text + " "+cBAno.Text ;

            }
        }
    }
}
