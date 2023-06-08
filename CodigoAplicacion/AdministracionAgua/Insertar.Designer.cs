namespace WindowsFormsApp2
{
    partial class Insertar
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
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.labelUsiario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBManzana = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBConfirmar = new System.Windows.Forms.CheckBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.labelMes = new System.Windows.Forms.Label();
            this.cBMes = new System.Windows.Forms.ComboBox();
            this.labelAno = new System.Windows.Forms.Label();
            this.cBAno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(358, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 23);
            this.label9.TabIndex = 109;
            this.label9.Text = "Datos:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(341, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 37);
            this.label11.TabIndex = 108;
            this.label11.Text = "Insertar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel2.Location = new System.Drawing.Point(77, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 3);
            this.panel2.TabIndex = 111;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNombre.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxNombre.ForeColor = System.Drawing.Color.White;
            this.txtBoxNombre.Location = new System.Drawing.Point(77, 187);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(292, 32);
            this.txtBoxNombre.TabIndex = 112;
            // 
            // labelUsiario
            // 
            this.labelUsiario.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsiario.ForeColor = System.Drawing.Color.White;
            this.labelUsiario.Location = new System.Drawing.Point(71, 139);
            this.labelUsiario.Name = "labelUsiario";
            this.labelUsiario.Size = new System.Drawing.Size(218, 23);
            this.labelUsiario.TabIndex = 110;
            this.labelUsiario.Text = "Nombre Completo:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 116;
            this.label2.Text = "Manzana:";
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
            "NN",
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
            "Z",
            "AA",
            "BB",
            "CC",
            "DD",
            "EE"});
            this.cBManzana.Location = new System.Drawing.Point(77, 304);
            this.cBManzana.Name = "cBManzana";
            this.cBManzana.Size = new System.Drawing.Size(70, 28);
            this.cBManzana.TabIndex = 117;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel3.Location = new System.Drawing.Point(413, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 3);
            this.panel3.TabIndex = 119;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDireccion.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDireccion.ForeColor = System.Drawing.Color.White;
            this.textBoxDireccion.Location = new System.Drawing.Point(413, 187);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(276, 32);
            this.textBoxDireccion.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(409, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 118;
            this.label3.Text = "Direccion:";
            // 
            // checkBConfirmar
            // 
            this.checkBConfirmar.AutoSize = true;
            this.checkBConfirmar.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBConfirmar.ForeColor = System.Drawing.Color.White;
            this.checkBConfirmar.Location = new System.Drawing.Point(325, 441);
            this.checkBConfirmar.Name = "checkBConfirmar";
            this.checkBConfirmar.Size = new System.Drawing.Size(105, 24);
            this.checkBConfirmar.TabIndex = 122;
            this.checkBConfirmar.Text = "Confirmar ";
            this.checkBConfirmar.UseVisualStyleBackColor = true;
            this.checkBConfirmar.CheckedChanged += new System.EventHandler(this.checkBConfirmar_CheckedChanged);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnInsertar.Enabled = false;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(325, 400);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(150, 35);
            this.btnInsertar.TabIndex = 121;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // labelMes
            // 
            this.labelMes.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMes.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMes.Location = new System.Drawing.Point(649, 253);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(44, 23);
            this.labelMes.TabIndex = 126;
            this.labelMes.Text = "Mes";
            // 
            // cBMes
            // 
            this.cBMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.cBMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBMes.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMes.ForeColor = System.Drawing.Color.White;
            this.cBMes.FormattingEnabled = true;
            this.cBMes.Location = new System.Drawing.Point(637, 304);
            this.cBMes.Name = "cBMes";
            this.cBMes.Size = new System.Drawing.Size(70, 28);
            this.cBMes.TabIndex = 125;
            // 
            // labelAno
            // 
            this.labelAno.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAno.Location = new System.Drawing.Point(489, 255);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(42, 23);
            this.labelAno.TabIndex = 124;
            this.labelAno.Text = "Año";
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
            "",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cBAno.Location = new System.Drawing.Point(455, 306);
            this.cBAno.Name = "cBAno";
            this.cBAno.Size = new System.Drawing.Size(118, 28);
            this.cBAno.TabIndex = 123;
            this.cBAno.SelectedIndexChanged += new System.EventHandler(this.cBAno_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 127;
            this.label1.Text = "Ultima Fecha Pagada:";
            // 
            // Insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(780, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.cBMes);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.cBAno);
            this.Controls.Add(this.checkBConfirmar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBManzana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.labelUsiario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insertar";
            this.Text = "Insertar";
            this.Load += new System.EventHandler(this.Insertar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label labelUsiario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBManzana;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBConfirmar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.ComboBox cBMes;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.ComboBox cBAno;
        private System.Windows.Forms.Label label1;
    }
}