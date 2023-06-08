namespace WindowsFormsApp2
{
    partial class FormReporte
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
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelCantidadPagada = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.cBNombre = new System.Windows.Forms.ComboBox();
            this.labelTipoReporte = new System.Windows.Forms.Label();
            this.cBTipoReporte = new System.Windows.Forms.ComboBox();
            this.btnPago = new System.Windows.Forms.Button();
            this.labelAño = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelFecha1 = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.cBAno = new System.Windows.Forms.ComboBox();
            this.labelMes = new System.Windows.Forms.Label();
            this.cBMes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBConfirmar = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTelefono
            // 
            this.labelTelefono.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefono.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTelefono.Location = new System.Drawing.Point(353, 465);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(142, 23);
            this.labelTelefono.TabIndex = 66;
            this.labelTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTelefono.Visible = false;
            // 
            // labelCantidadPagada
            // 
            this.labelCantidadPagada.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadPagada.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCantidadPagada.Location = new System.Drawing.Point(351, 421);
            this.labelCantidadPagada.Name = "labelCantidadPagada";
            this.labelCantidadPagada.Size = new System.Drawing.Size(140, 23);
            this.labelCantidadPagada.TabIndex = 60;
            this.labelCantidadPagada.Text = "Cantidad Pagada";
            this.labelCantidadPagada.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNombre.Location = new System.Drawing.Point(535, 133);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(86, 23);
            this.labelNombre.TabIndex = 58;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Visible = false;
            // 
            // cBNombre
            // 
            this.cBNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.cBNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBNombre.Font = new System.Drawing.Font("Adobe Gothic Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cBNombre.ForeColor = System.Drawing.Color.White;
            this.cBNombre.FormattingEnabled = true;
            this.cBNombre.Items.AddRange(new object[] {
            "Daniel Saed Ibarra Maldonado"});
            this.cBNombre.Location = new System.Drawing.Point(388, 178);
            this.cBNombre.Name = "cBNombre";
            this.cBNombre.Size = new System.Drawing.Size(348, 24);
            this.cBNombre.TabIndex = 57;
            this.cBNombre.Visible = false;
            this.cBNombre.SelectedIndexChanged += new System.EventHandler(this.cBNombre_SelectedIndexChanged);
            // 
            // labelTipoReporte
            // 
            this.labelTipoReporte.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoReporte.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTipoReporte.Location = new System.Drawing.Point(52, 290);
            this.labelTipoReporte.Name = "labelTipoReporte";
            this.labelTipoReporte.Size = new System.Drawing.Size(167, 23);
            this.labelTipoReporte.TabIndex = 68;
            this.labelTipoReporte.Text = "Tipo  de Reporte";
            this.labelTipoReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTipoReporte.Visible = false;
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
            this.cBTipoReporte.Location = new System.Drawing.Point(74, 354);
            this.cBTipoReporte.Name = "cBTipoReporte";
            this.cBTipoReporte.Size = new System.Drawing.Size(128, 28);
            this.cBTipoReporte.TabIndex = 67;
            this.cBTipoReporte.Visible = false;
            this.cBTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cBTipoReporte_SelectedIndexChanged);
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPago.Location = new System.Drawing.Point(586, 507);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(136, 30);
            this.btnPago.TabIndex = 71;
            this.btnPago.Text = "Editar";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Visible = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // labelAño
            // 
            this.labelAño.BackColor = System.Drawing.Color.Transparent;
            this.labelAño.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAño.Location = new System.Drawing.Point(384, 359);
            this.labelAño.Name = "labelAño";
            this.labelAño.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAño.Size = new System.Drawing.Size(75, 17);
            this.labelAño.TabIndex = 85;
            this.labelAño.Visible = false;
            // 
            // labelFecha
            // 
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFecha.Location = new System.Drawing.Point(265, 359);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFecha.Size = new System.Drawing.Size(113, 17);
            this.labelFecha.TabIndex = 84;
            this.labelFecha.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel6.Location = new System.Drawing.Point(280, 379);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 3);
            this.panel6.TabIndex = 82;
            this.panel6.Visible = false;
            // 
            // labelFecha1
            // 
            this.labelFecha1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFecha1.Location = new System.Drawing.Point(261, 292);
            this.labelFecha1.Name = "labelFecha1";
            this.labelFecha1.Size = new System.Drawing.Size(212, 23);
            this.labelFecha1.TabIndex = 83;
            this.labelFecha1.Text = "Ultima fecha pagada";
            this.labelFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFecha1.Visible = false;
            // 
            // labelAno
            // 
            this.labelAno.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAno.Location = new System.Drawing.Point(537, 292);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(60, 23);
            this.labelAno.TabIndex = 87;
            this.labelAno.Text = "Año";
            this.labelAno.Visible = false;
            // 
            // cBAno
            // 
            this.cBAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.cBAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBAno.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAno.ForeColor = System.Drawing.Color.White;
            this.cBAno.FormattingEnabled = true;
            this.cBAno.Location = new System.Drawing.Point(503, 354);
            this.cBAno.Name = "cBAno";
            this.cBAno.Size = new System.Drawing.Size(112, 28);
            this.cBAno.TabIndex = 86;
            this.cBAno.Visible = false;
            this.cBAno.SelectedIndexChanged += new System.EventHandler(this.cbAño_SelectedIndexChanged);
            // 
            // labelMes
            // 
            this.labelMes.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMes.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMes.Location = new System.Drawing.Point(667, 292);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(60, 23);
            this.labelMes.TabIndex = 89;
            this.labelMes.Text = "Mes";
            this.labelMes.Visible = false;
            // 
            // cBMes
            // 
            this.cBMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.cBMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBMes.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMes.ForeColor = System.Drawing.Color.White;
            this.cBMes.FormattingEnabled = true;
            this.cBMes.Location = new System.Drawing.Point(637, 354);
            this.cBMes.Name = "cBMes";
            this.cBMes.Size = new System.Drawing.Size(102, 28);
            this.cBMes.TabIndex = 88;
            this.cBMes.Visible = false;
            this.cBMes.SelectedIndexChanged += new System.EventHandler(this.cBMes_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(67, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 31);
            this.label9.TabIndex = 105;
            this.label9.Text = "Datos de la persona:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(66, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 37);
            this.label11.TabIndex = 104;
            this.label11.Text = "Reporte Personal";
            // 
            // checkBConfirmar
            // 
            this.checkBConfirmar.AutoSize = true;
            this.checkBConfirmar.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBConfirmar.ForeColor = System.Drawing.Color.White;
            this.checkBConfirmar.Location = new System.Drawing.Point(386, 497);
            this.checkBConfirmar.Name = "checkBConfirmar";
            this.checkBConfirmar.Size = new System.Drawing.Size(72, 24);
            this.checkBConfirmar.TabIndex = 106;
            this.checkBConfirmar.Text = "Editar";
            this.checkBConfirmar.UseVisualStyleBackColor = true;
            this.checkBConfirmar.Visible = false;
            this.checkBConfirmar.CheckedChanged += new System.EventHandler(this.checkBConfirmar_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(624, 465);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 27);
            this.numericUpDown1.TabIndex = 107;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel5.Location = new System.Drawing.Point(332, 488);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 3);
            this.panel5.TabIndex = 83;
            this.panel5.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(568, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 108;
            this.label1.Text = "Cantidad nueva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(72, 220);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 32);
            this.btnBuscar.TabIndex = 132;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel1.Location = new System.Drawing.Point(74, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 3);
            this.panel1.TabIndex = 130;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNombre.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxNombre.ForeColor = System.Drawing.Color.White;
            this.txtBoxNombre.Location = new System.Drawing.Point(74, 182);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(260, 32);
            this.txtBoxNombre.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(68, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 23);
            this.label3.TabIndex = 129;
            this.label3.Text = "Buscar nombre:";
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(797, 564);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBConfirmar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.cBMes);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.cBAno);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.labelFecha1);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.labelTipoReporte);
            this.Controls.Add(this.cBTipoReporte);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelCantidadPagada);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.cBNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelCantidadPagada;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox cBNombre;
        private System.Windows.Forms.Label labelTipoReporte;
        private System.Windows.Forms.ComboBox cBTipoReporte;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelFecha1;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.ComboBox cBAno;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.ComboBox cBMes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBConfirmar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label3;
    }
}