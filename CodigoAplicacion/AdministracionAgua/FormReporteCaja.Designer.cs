namespace WindowsFormsApp2
{
    partial class FormReporteCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cBTipoReporte = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cBMes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBAno = new System.Windows.Forms.ComboBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPago = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnRuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(78, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tipo  de Reporte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBTipoReporte
            // 
            this.cBTipoReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.cBTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTipoReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBTipoReporte.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTipoReporte.ForeColor = System.Drawing.Color.White;
            this.cBTipoReporte.FormattingEnabled = true;
            this.cBTipoReporte.Items.AddRange(new object[] {
            "",
            "Anual",
            "Mensual"});
            this.cBTipoReporte.Location = new System.Drawing.Point(102, 198);
            this.cBTipoReporte.Name = "cBTipoReporte";
            this.cBTipoReporte.Size = new System.Drawing.Size(128, 28);
            this.cBTipoReporte.TabIndex = 69;
            this.cBTipoReporte.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(514, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 93;
            this.label8.Text = "Mes";
            this.label8.Visible = false;
            // 
            // cBMes
            // 
            this.cBMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.cBMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBMes.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMes.ForeColor = System.Drawing.Color.White;
            this.cBMes.FormattingEnabled = true;
            this.cBMes.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cBMes.Location = new System.Drawing.Point(496, 198);
            this.cBMes.Name = "cBMes";
            this.cBMes.Size = new System.Drawing.Size(78, 28);
            this.cBMes.TabIndex = 92;
            this.cBMes.Visible = false;
            this.cBMes.SelectedIndexChanged += new System.EventHandler(this.cBMes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(384, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 91;
            this.label6.Text = "Año";
            this.label6.Visible = false;
            // 
            // cBAno
            // 
            this.cBAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.cBAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBAno.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAno.ForeColor = System.Drawing.Color.White;
            this.cBAno.FormattingEnabled = true;
            this.cBAno.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cBAno.Location = new System.Drawing.Point(335, 198);
            this.cBAno.Name = "cBAno";
            this.cBAno.Size = new System.Drawing.Size(128, 28);
            this.cBAno.TabIndex = 90;
            this.cBAno.Visible = false;
            this.cBAno.SelectedIndexChanged += new System.EventHandler(this.cBAno_SelectedIndexChanged);
            // 
            // labelTelefono
            // 
            this.labelTelefono.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefono.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTelefono.Location = new System.Drawing.Point(331, 412);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(142, 22);
            this.labelTelefono.TabIndex = 96;
            this.labelTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTelefono.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel4.Location = new System.Drawing.Point(305, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 3);
            this.panel4.TabIndex = 94;
            this.panel4.Visible = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(261, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 23);
            this.label10.TabIndex = 95;
            this.label10.Text = "Cantidad Total Ingresada";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(354, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 99;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel1.Location = new System.Drawing.Point(374, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 3);
            this.panel1.TabIndex = 97;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(314, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 98;
            this.label3.Text = "Personas que Pagaron";
            this.label3.Visible = false;
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.Color.White;
            this.btnPago.Location = new System.Drawing.Point(323, 479);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(150, 35);
            this.btnPago.TabIndex = 100;
            this.btnPago.Text = "Generar Reporte";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Visible = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(97, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 23);
            this.label9.TabIndex = 107;
            this.label9.Text = "Datos:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(96, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 37);
            this.label11.TabIndex = 106;
            this.label11.Text = "Reporte General";
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(450, 32);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(315, 27);
            this.label30.TabIndex = 127;
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnRuta.FlatAppearance.BorderSize = 0;
            this.btnRuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuta.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuta.ForeColor = System.Drawing.Color.White;
            this.btnRuta.Location = new System.Drawing.Point(335, 24);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(109, 35);
            this.btnRuta.TabIndex = 126;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // FormReporteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(797, 564);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBMes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBAno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBTipoReporte);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteCaja";
            this.Text = "FormReporteCaja";
            this.Load += new System.EventHandler(this.FormReporteCaja_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBTipoReporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBAno;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnRuta;
    }
}