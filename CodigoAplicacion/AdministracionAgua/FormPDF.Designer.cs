namespace WindowsFormsApp2
{
    partial class FormPDF
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
            this.btnPago = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBNombre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBTipoPago = new System.Windows.Forms.ComboBox();
            this.checkBConfirmar = new System.Windows.Forms.CheckBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelAño = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnRuta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnPago.Enabled = false;
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPago.Location = new System.Drawing.Point(320, 458);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(170, 37);
            this.btnPago.TabIndex = 17;
            this.btnPago.Text = "Pago";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Visible = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(65, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Buscar nombre:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(65, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 37);
            this.label4.TabIndex = 30;
            this.label4.Text = "Pago";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(64, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Datos de la persona:";
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
            this.cBNombre.Location = new System.Drawing.Point(387, 191);
            this.cBNombre.Name = "cBNombre";
            this.cBNombre.Size = new System.Drawing.Size(343, 24);
            this.cBNombre.TabIndex = 33;
            this.cBNombre.Visible = false;
            this.cBNombre.SelectedIndexChanged += new System.EventHandler(this.cBNombre_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(383, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Nombre";
            this.label7.Visible = false;
            // 
            // cBTipoPago
            // 
            this.cBTipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.cBTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBTipoPago.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTipoPago.ForeColor = System.Drawing.Color.White;
            this.cBTipoPago.FormattingEnabled = true;
            this.cBTipoPago.Items.AddRange(new object[] {
            "",
            "Pago Anual",
            "Pago Mensual"});
            this.cBTipoPago.Location = new System.Drawing.Point(69, 372);
            this.cBTipoPago.Name = "cBTipoPago";
            this.cBTipoPago.Size = new System.Drawing.Size(150, 28);
            this.cBTipoPago.TabIndex = 43;
            this.cBTipoPago.Visible = false;
            this.cBTipoPago.SelectedIndexChanged += new System.EventHandler(this.cBTipoPago_SelectedIndexChanged);
            // 
            // checkBConfirmar
            // 
            this.checkBConfirmar.AutoSize = true;
            this.checkBConfirmar.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBConfirmar.ForeColor = System.Drawing.Color.White;
            this.checkBConfirmar.Location = new System.Drawing.Point(320, 501);
            this.checkBConfirmar.Name = "checkBConfirmar";
            this.checkBConfirmar.Size = new System.Drawing.Size(105, 24);
            this.checkBConfirmar.TabIndex = 48;
            this.checkBConfirmar.Text = "Confirmar ";
            this.checkBConfirmar.UseVisualStyleBackColor = true;
            this.checkBConfirmar.Visible = false;
            this.checkBConfirmar.CheckedChanged += new System.EventHandler(this.checkBConfirmar_CheckedChanged);
            // 
            // labelFecha
            // 
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFecha.Location = new System.Drawing.Point(536, 377);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFecha.Size = new System.Drawing.Size(113, 17);
            this.labelFecha.TabIndex = 54;
            this.labelFecha.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel2.Location = new System.Drawing.Point(540, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 3);
            this.panel2.TabIndex = 52;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(517, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "Ultima fecha pagada";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(303, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 23);
            this.label6.TabIndex = 61;
            this.label6.Text = "Cantidad de pago";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(67, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Concepto";
            this.label1.Visible = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(352, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 79;
            this.label11.Text = "$";
            this.label11.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(373, 374);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 27);
            this.numericUpDown1.TabIndex = 80;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // labelAño
            // 
            this.labelAño.BackColor = System.Drawing.Color.Transparent;
            this.labelAño.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAño.Location = new System.Drawing.Point(655, 377);
            this.labelAño.Name = "labelAño";
            this.labelAño.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAño.Size = new System.Drawing.Size(75, 17);
            this.labelAño.TabIndex = 81;
            this.labelAño.Visible = false;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(320, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(394, 31);
            this.label30.TabIndex = 125;
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label30.Click += new System.EventHandler(this.label30_Click);
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
            this.btnRuta.Location = new System.Drawing.Point(205, 22);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(109, 35);
            this.btnRuta.TabIndex = 124;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel1.Location = new System.Drawing.Point(71, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 3);
            this.panel1.TabIndex = 126;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNombre.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxNombre.ForeColor = System.Drawing.Color.White;
            this.txtBoxNombre.Location = new System.Drawing.Point(71, 195);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(260, 32);
            this.txtBoxNombre.TabIndex = 127;
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
            this.btnBuscar.Location = new System.Drawing.Point(69, 233);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 32);
            this.btnBuscar.TabIndex = 128;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(797, 564);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBConfirmar);
            this.Controls.Add(this.cBTipoPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPDF";
            this.Load += new System.EventHandler(this.FormPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBTipoPago;
        private System.Windows.Forms.CheckBox checkBConfirmar;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Button btnBuscar;
    }
}