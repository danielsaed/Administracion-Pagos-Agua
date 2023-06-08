using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.IO;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Diagnostics;
using iText.Layout.Borders;
using iText.IO.Image;

namespace WindowsFormsApp2
{
    public partial class FormPDF : Form
    {
        static string path = System.IO.Path.GetFullPath(Environment.CurrentDirectory);
        static string databaseName = "BaseDatos.mdf";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + "; Integrated Security=True;";

        string Pat = "C:/Users/Saed/source/repos/WindowsFormsApp2/WindowsFormsApp2/bin/Debug/Recibo.pdf";
        string imageSource = "logo.jpg",tipopago,FechaPago;
        int valorMeses,valorPagoAnual,FechaYear,FechaArray;
        string[] meses = { "Diciembre", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", "Año pagado" };
        string[] columnas = { "Id", "Nombre", "Telefono", "Cantidad Pago" };
        int year = 2021, a = 0;
        int folio,oo, error;
        string paat, printerName = "EPSON9ACD22 (L395 Series)",manzana, mensaje;
       

        public FormPDF()
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
            try
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
           
                PdfWriter pdfWriter = new PdfWriter(paat + "\\" + cBNombre.Text + "_Fol" + folio + "_" + DateTime.Today.ToString("dd-MM-yyyy") + ".pdf");
                Pat = paat + "\\" + cBNombre.Text + "_Fol" + folio + "_" + DateTime.Today.ToString("dd-MM-yyyy") + ".pdf";
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

            Table table = new Table(1).UseAllAvailableWidth();
                Cell cell = new Cell().Add(new Paragraph("Recibo de Pago").SetFontSize(14))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);
                documento.Add(table);

            Table table33 = new Table(1).UseAllAvailableWidth();
            Cell cell33 = new Cell().Add(new Paragraph("Concepto: Pago " +tipopago).SetFontSize(14))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBorder(Border.NO_BORDER);
            table33.AddCell(cell33);
            documento.Add(table33);

            Paragraph o3 = new Paragraph("");
            o3.SetMarginBottom(8f);
            documento.Add(o3);

            Table table_1 = new Table(1).UseAllAvailableWidth();

            Cell cell_1 = new Cell().Add(new Paragraph("__________________________________________________________________________"))
                .SetTextAlignment(TextAlignment.LEFT)
               // .SetBold()
                .SetBorder(Border.NO_BORDER);
            table_1.AddCell(cell_1);

            documento.Add(table_1);

            float[] columnWidths = {2,1,2,1};

                Table _table = new Table(UnitValue.CreatePercentArray(columnWidths));
             _table.SetWidth(UnitValue.CreatePercentValue(100));
            Cell _cell = new Cell().Add(new Paragraph("Nombre:").SetFontSize(10))
                .SetBold()
                .SetBorder(Border.NO_BORDER);
            _table.AddCell(_cell);

            _cell = new Cell().Add(new Paragraph("Manzana:").SetFontSize(10))
                .SetBold()
                .SetBorder(Border.NO_BORDER);
            _table.AddCell(_cell);

            _cell = new Cell().Add(new Paragraph("Fecha Pagada:").SetFontSize(10))
                .SetBold()
                .SetBorder(Border.NO_BORDER);
            _table.AddCell(_cell);              
            
                _cell = new Cell().Add(new Paragraph("Cantidad:").SetFontSize(10))
                .SetBold()
            .SetBorder(Border.NO_BORDER);
            _table.AddCell(_cell);

            documento.Add(_table);

            Paragraph o2 = new Paragraph("");
            o2.SetMarginBottom(10f);
            documento.Add(o2);

            Table _table1 = new Table(UnitValue.CreatePercentArray(columnWidths));
            _table1.SetWidth(UnitValue.CreatePercentValue(100));

            Cell _cell1 = new Cell().Add(new Paragraph(cBNombre.Text).SetFontSize(8))
                .SetBorder(Border.NO_BORDER);
            _table1.AddCell(_cell1);

            _cell1 = new Cell().Add(new Paragraph(manzana).SetFontSize(8))
                .SetBorder(Border.NO_BORDER);
            _table1.AddCell(_cell1);

            _cell1 = new Cell().Add(new Paragraph(FechaPago).SetFontSize(8))
                .SetBorder(Border.NO_BORDER);
            _table1.AddCell(_cell1);
                
            _cell1 = new Cell().Add(new Paragraph("$ " + numericUpDown1.Value.ToString()).SetFontSize(8))
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
            o1.SetMarginBottom(38f);
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

            Paragraph o10 = new Paragraph("");
            o10.SetMarginBottom(4f);
            documento.Add(o10);

            Table table111 = new Table(1).UseAllAvailableWidth();
            Cell cell111 = new Cell().Add(new Paragraph("EL AGUA POTABLE ES PARA EL CONSUMO DOMESTICO, ESTA EXTRICTAMENTE PROHIBIDO EL DESPERDICIO SEA ESTE EN EL RIEGO DE LA CALLE, USO EXCESIVO EN AREAS VERDES, RIEGO EN HORTALIZAS Y ARBOLES FRUTALES EN HUERTOS DE TRASPATIO ETC. CUALQUIER USO INDEBIDO POR PARTE DEL USUARIO SERA PENALIZADO CON EL CORTE TEMPORAL O DEFINITIVO DEL SERVICIO Y/O LA RESCICION DEL CONTRATO."))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(6)
                    .SetBold()
                    .SetItalic()
                    .SetBorder(Border.NO_BORDER);
            table111.AddCell(cell111);
            documento.Add(table111);

            folio++;
            string query4 = "UPDATE Ids SET folio = '" + folio.ToString() + "';";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand comand = new SqlCommand(query4, con);
                SqlDataReader reader = comand.ExecuteReader();
            }
           
            documento.Close();

                try
                {
                    Process process = new Process();

                    process.StartInfo.FileName = Pat;
                    process.StartInfo.Verb = "printto";
                    // process.StartInfo.Arguments = "\"" + printerName + "\"";
                    process.Start();
                }
                catch
                {
                    MessageBox.Show("Error al imprimir, pago no realizado");
                    error = 1;
                }
            }
            catch
            {
                MessageBox.Show("Error al generar pdf, pago no realizado");
                error = 1;


            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (txtBoxNombre.Text == "")
            {
                cBNombre.Visible = false;
                label7.Visible = false;
                MessageBox.Show("Faltan datos");
            }
            else
            {
                cBNombre.Visible = true;
                label7.Visible = true;
            }
            cBNombre.Items.Clear();

            if (cBNombre.SelectedItem == null)// esconde los datos si el combobox manzana cambia
            {
                panel2.Visible = false;
                label2.Visible = false;
                labelFecha.Visible = false;
                cBTipoPago.Visible = false;
                label1.Visible = false;
                label6.Visible = false;
                label11.Visible = false;
                numericUpDown1.Visible = false;
                btnPago.Visible = false;
                checkBConfirmar.Visible = false;
                labelAño.Visible = false;
            }

            string query1 = "SELECT Nombre_persona FROM Persona WHERE Nombre_persona LIKE '%" + txtBoxNombre.Text+ "%' ORDER BY Nombre_persona";

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
                if(reader.HasRows == false)
                {
                    MessageBox.Show("Sin resultados");
                    cBNombre.Visible = false;
                    label7.Visible = false;
                }

            }
          
            
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void FormPDF_Load(object sender, EventArgs e)
        {        
        }

       /* private void cBManzana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBManzana.SelectedItem == null)
            {
                cBNombre.Visible = false;
                label7.Visible = false;
            }
            else
            {
                cBNombre.Visible = true;
                label7.Visible = true;
            }
            cBNombre.Items.Clear();

            if (cBNombre.SelectedItem == null)// esconde los datos si el combobox manzana cambia
            {        
                panel2.Visible = false;
                label2.Visible = false;             
                labelFecha.Visible = false;
                cBTipoPago.Visible = false;
                label1.Visible = false;
                label6.Visible = false;
                label11.Visible = false;
                numericUpDown1.Visible = false;
                btnPago.Visible = false;
                checkBConfirmar.Visible = false;
                labelAño.Visible = false;
            }

            string query1 = "SELECT Nombre_persona FROM Persona WHERE manzana = '" + cBManzana.Text + "' ORDER BY Nombre_persona";

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
            //cBNombre.ResetText();
            if (cBNombre.SelectedItem == null)
            {
                cBTipoPago.Visible = false;
                label1.Visible = false;
                year = 2021;
            }
            else
            {
                year = 2021;
                cBTipoPago.Visible = true;
                label1.Visible = true;
                panel2.Visible = false;
                label2.Visible = false;
                labelFecha.Visible = false;
                label6.Visible = false;
                label11.Visible = false;
                numericUpDown1.Visible = false;
                btnPago.Visible = false;
                checkBConfirmar.Visible = false;
                labelAño.Visible = false;
                cBTipoPago.Text = "";
            }

            
        }

        private void checkBConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBConfirmar.Checked)
            {
                btnPago.Enabled = true;
            }
            else
            {
                btnPago.Enabled = false;
            }
        }

        private void cBTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = 2021;
            if (cBTipoPago.Text == "Pago Anual" || cBTipoPago.Text ==  "Pago Mensual")
            {
                
                for (int a = 0; a == 0;){
                 string query1 = "SELECT a.UltimoMes, b.manzana FROM Pagos"+year+" a, Persona b WHERE Nombre_persona = '" + cBNombre.Text + "' AND b.Id_persona = a.id_" +year+ "";
                 using (SqlConnection con = new SqlConnection(connectionString))
                 {
                     con.Open();
                    // SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                     SqlCommand comand = new SqlCommand(query1, con);

                     DataTable datatable = new DataTable();
                     SqlDataReader reader = comand.ExecuteReader();

                     while (reader.Read())
                     {
                            manzana = reader["manzana"].ToString();
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

                 if (cBTipoPago.Text == "Pago Anual")
                 {
                     if (valorMeses == 12) {
                         year = year + 1;
                     }
                     else
                     {
                         //  valorMesesRestantes = 12 - valorMeses;
                         //  valorPagoAnual = 120 * valorMesesRestantes;
                         //   numericUpDown1.Value = valorPagoAnual;
                         valorPagoAnual = 1200;
                         numericUpDown1.Value = valorPagoAnual;

                         a = 1;
                     }


                 }
                 else if (cBTipoPago.Text == "Pago Mensual")
                 {
                     if (valorMeses == 12)
                     {
                         year = year + 1;
                     }
                     else
                     {
                         numericUpDown1.Value = 120;
                         a = 1;
                     }

                 }
             }
             }
  
            if (cBTipoPago.Text == "")
            {
                panel2.Visible = false;
                label2.Visible = false;
                labelFecha.Visible = false;
                label6.Visible = false;
                label11.Visible = false;
                numericUpDown1.Visible = false;
                btnPago.Visible = false;
                checkBConfirmar.Visible = false;
                labelAño.Visible = false;

            }
            else
            {
                panel2.Visible = true;
                label2.Visible = true;
                labelFecha.Visible = true;
                label6.Visible = true;
                label11.Visible = true;
                numericUpDown1.Visible = true;
                btnPago.Visible = true;
                checkBConfirmar.Visible = true;
                labelFecha.Text = meses[valorMeses];
                

                labelAño.Visible = true;
                if (valorMeses == 12 || valorMeses == 0)
                {
                    labelAño.Text = (year-1).ToString();
                    FechaArray = 1;
                    FechaYear = (year - 1);
                }
                else
                {
                    labelAño.Text = year.ToString();
                    FechaArray = valorMeses + 1;
                    FechaYear = year;
                }

                
            }
            
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            if (cBTipoPago.Text == "Pago Anual")
            {

                double valorPagoAnualDividido;
                valorPagoAnualDividido = Convert.ToDouble(numericUpDown1.Value);

                //valorPagoAnualDividido = valorPagoAnual/valorMesesRestantes;
                int X = 1;
                for (int i = 12; i > 0; i--)
                {
                    if (valorMeses == 12) 
                    {
                        valorMeses = 0;
                        year++;
                    }
                    try
                    {
                        string query3 = "UPDATE Pagos" + year + " SET " + meses[valorMeses + 1] + " = @pagomes, UltimoMes = @ultimomes FROM Persona a, Pagos" + year + " b WHERE Nombre_persona = @nombre AND  a.Id_persona = b.Id_" + year + "";
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            //SqlDataAdapter adapter = new SqlDataAdapter(query3, con);
                            SqlCommand comand = new SqlCommand(query3, con);
                            DataTable datatable = new DataTable();

                            comand.Parameters.AddWithValue("@year", year);
                            //  comand.Parameters.AddWithValue("@meses",meses[valorMeses + 1]);
                            comand.Parameters.AddWithValue("@pagomes", (valorPagoAnualDividido / 12));
                            comand.Parameters.AddWithValue("@ultimomes", (valorMeses + 1));
                            comand.Parameters.AddWithValue("@nombre", cBNombre.Text);
                            comand.ExecuteNonQuery();
                            SqlDataReader reader = comand.ExecuteReader();
                            valorMeses++;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error al realizar el pago");
                        error = 1;

                    }
                }
                if(FechaArray == 1)
                {
                    FechaPago = meses[FechaArray] + " " + FechaYear + " - " + meses[12] + " " + (FechaYear);
                }
                else
                {
                    FechaPago = meses[FechaArray] + " " + FechaYear + " - " + meses[FechaArray - 1] + " " + (FechaYear + 1);
                }
                

                tipopago = "Anual";
                crearPDF();
                panel2.Visible = false;
                label2.Visible = false;
                labelFecha.Visible = false;
                label6.Visible = false;
                label11.Visible = false;
                numericUpDown1.Visible = false;
                btnPago.Visible = false;
                checkBConfirmar.Visible = false;
                labelAño.Visible = false;
                cBTipoPago.Text = "";
                if (error == 0)
                {
                    MessageBox.Show("Pago anual realizado");
                }
                else
                {
                    for (int i = 12; i > 0; i--)
                    {
                        if (valorMeses == 0)
                        {
                            valorMeses = 12;
                            year--;
                        }
                        string query3 = "UPDATE Pagos" + year + " SET " + meses[valorMeses] + " = 0, UltimoMes = " + (valorMeses - 1) + " FROM Persona a, Pagos" + year + " b WHERE Nombre_persona = @nombre AND  a.Id_persona = b.Id_" + year + "";
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            //SqlDataAdapter adapter = new SqlDataAdapter(query3, con);
                            SqlCommand comand = new SqlCommand(query3, con);
                            DataTable datatable = new DataTable();

                            comand.Parameters.AddWithValue("@year", year);
                            //  comand.Parameters.AddWithValue("@meses",meses[valorMeses + 1]);
                            // comand.Parameters.AddWithValue("@pagomes", (valorPagoAnualDividido / 12));
                            //comand.Parameters.AddWithValue("@ultimomes", (valorMeses + 1));
                            comand.Parameters.AddWithValue("@nombre", cBNombre.Text);
                            comand.ExecuteNonQuery();
                            SqlDataReader reader = comand.ExecuteReader();
                            valorMeses--;
                        }
                    }
                }
                error = 0;

            }

            if (cBTipoPago.Text == "Pago Mensual")
            {
                    double valorPagoAnualDividido;
                    valorPagoAnualDividido = Convert.ToDouble(numericUpDown1.Value);
                    if (valorMeses == 12)
                    {
                        valorMeses = 0;
                        year++;
                    }
                    try
                    {
                        string query3 = "UPDATE Pagos" + year + " SET " + meses[valorMeses + 1] + " = @pagomes, UltimoMes = @ultimomes FROM Persona a, Pagos" + year + " b WHERE Nombre_persona = @nombre AND  a.Id_persona = b.Id_" + year + "";
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            //    SqlDataAdapter adapter = new SqlDataAdapter(query3, con);
                            SqlCommand comand = new SqlCommand(query3, con);
                            DataTable datatable = new DataTable();
                            comand.Parameters.AddWithValue("@year", year);
                            //  comand.Parameters.AddWithValue("@meses",meses[valorMeses + 1]);
                            comand.Parameters.AddWithValue("@pagomes", (valorPagoAnualDividido));
                            comand.Parameters.AddWithValue("@ultimomes", (valorMeses + 1));
                            comand.Parameters.AddWithValue("@nombre", cBNombre.Text);
                            comand.ExecuteNonQuery();
                            SqlDataReader reader = comand.ExecuteReader();
                            valorMeses++;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error, no se realizo el pago");
                        error = 1;
                    }
                    
                    tipopago = "Mensual";
                    FechaPago = meses[FechaArray] + " " + FechaYear;
       
                    crearPDF();

                    /*  Process p = new Process();
                      p.StartInfo = new ProcessStartInfo()
                      {
                          CreateNoWindow = true,
                          Verb = "print",
                          FileName = Pat //put the correct path here
                      };
                      p.Start();*/

                    // process.WaitForInputIdle();
                    // process.Kill();

                    panel2.Visible = false;
                    label2.Visible = false;
                    labelFecha.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    numericUpDown1.Visible = false;
                    btnPago.Visible = false;
                    checkBConfirmar.Visible = false;
                    labelAño.Visible = false;
                    cBTipoPago.Text = "";
                if (error == 0)
                {
                    MessageBox.Show("Pago mensual realizado");
                }
                error = 0;
                    
                }
            }
        }
    }

