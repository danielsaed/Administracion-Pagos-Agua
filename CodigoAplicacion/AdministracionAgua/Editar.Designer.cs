namespace WindowsFormsApp2
{
    partial class Editar
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
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.cBNombre = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBManzana = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.labelUsiario = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNombre1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPago.Location = new System.Drawing.Point(302, 399);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(174, 45);
            this.btnPago.TabIndex = 135;
            this.btnPago.Text = "Editar";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Visible = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(340, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 123;
            this.label9.Text = "Datos:";
            this.label9.Visible = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(339, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 37);
            this.label11.TabIndex = 137;
            this.label11.Text = "Editar";
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNombre.Location = new System.Drawing.Point(528, 76);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(86, 23);
            this.labelNombre.TabIndex = 152;
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
            this.cBNombre.Location = new System.Drawing.Point(380, 119);
            this.cBNombre.Name = "cBNombre";
            this.cBNombre.Size = new System.Drawing.Size(348, 24);
            this.cBNombre.TabIndex = 151;
            this.cBNombre.Visible = false;
            this.cBNombre.SelectedIndexChanged += new System.EventHandler(this.cBNombre_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel3.Location = new System.Drawing.Point(354, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 3);
            this.panel3.TabIndex = 159;
            this.panel3.Visible = false;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDireccion.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDireccion.ForeColor = System.Drawing.Color.White;
            this.textBoxDireccion.Location = new System.Drawing.Point(354, 321);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(260, 32);
            this.textBoxDireccion.TabIndex = 160;
            this.textBoxDireccion.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(350, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 158;
            this.label3.Text = "Direccion:";
            this.label3.Visible = false;
            // 
            // cBManzana
            // 
            this.cBManzana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.cBManzana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBManzana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBManzana.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBManzana.ForeColor = System.Drawing.Color.White;
            this.cBManzana.FormattingEnabled = true;
            this.cBManzana.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cBManzana.Location = new System.Drawing.Point(658, 313);
            this.cBManzana.Name = "cBManzana";
            this.cBManzana.Size = new System.Drawing.Size(70, 28);
            this.cBManzana.TabIndex = 157;
            this.cBManzana.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(654, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 156;
            this.label2.Text = "Manzana:";
            this.label2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel2.Location = new System.Drawing.Point(53, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 3);
            this.panel2.TabIndex = 154;
            this.panel2.Visible = false;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNombre.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxNombre.ForeColor = System.Drawing.Color.White;
            this.txtBoxNombre.Location = new System.Drawing.Point(53, 321);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(260, 32);
            this.txtBoxNombre.TabIndex = 155;
            this.txtBoxNombre.Visible = false;
            // 
            // labelUsiario
            // 
            this.labelUsiario.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsiario.ForeColor = System.Drawing.Color.White;
            this.labelUsiario.Location = new System.Drawing.Point(49, 271);
            this.labelUsiario.Name = "labelUsiario";
            this.labelUsiario.Size = new System.Drawing.Size(184, 23);
            this.labelUsiario.TabIndex = 153;
            this.labelUsiario.Text = "Nombre Completo:";
            this.labelUsiario.Visible = false;
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
            this.btnBuscar.Location = new System.Drawing.Point(53, 161);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 32);
            this.btnBuscar.TabIndex = 164;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel1.Location = new System.Drawing.Point(53, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 3);
            this.panel1.TabIndex = 162;
            // 
            // textBoxNombre1
            // 
            this.textBoxNombre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.textBoxNombre1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNombre1.ForeColor = System.Drawing.Color.White;
            this.textBoxNombre1.Location = new System.Drawing.Point(53, 123);
            this.textBoxNombre1.Name = "textBoxNombre1";
            this.textBoxNombre1.Size = new System.Drawing.Size(260, 32);
            this.textBoxNombre1.TabIndex = 163;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(49, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 161;
            this.label1.Text = "Buscar nombre:";
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(780, 496);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxNombre1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBManzana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.labelUsiario);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.cBNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editar";
            this.Text = "Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox cBNombre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBManzana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label labelUsiario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNombre1;
        private System.Windows.Forms.Label label1;
    }
}