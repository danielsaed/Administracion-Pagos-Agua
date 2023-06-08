namespace WindowsFormsApp2
{
    partial class FormEditarPagos
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
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBNombre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMes = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelCantidadPagada = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.txtBoxContraseña = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMostrarAno = new System.Windows.Forms.Label();
            this.labelMostrarMes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(-1, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(797, 37);
            this.label11.TabIndex = 138;
            this.label11.Text = "Borrar Pagos";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnBuscar.Location = new System.Drawing.Point(61, 226);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 32);
            this.btnBuscar.TabIndex = 145;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel1.Location = new System.Drawing.Point(63, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 3);
            this.panel1.TabIndex = 143;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNombre.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxNombre.ForeColor = System.Drawing.Color.White;
            this.txtBoxNombre.Location = new System.Drawing.Point(63, 188);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(260, 32);
            this.txtBoxNombre.TabIndex = 144;
            this.txtBoxNombre.Tag = "1";
            this.txtBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNombre_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(375, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 142;
            this.label7.Text = "Nombre";
            this.label7.Visible = false;
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
            this.cBNombre.Location = new System.Drawing.Point(379, 184);
            this.cBNombre.Name = "cBNombre";
            this.cBNombre.Size = new System.Drawing.Size(343, 24);
            this.cBNombre.TabIndex = 141;
            this.cBNombre.Visible = false;
            this.cBNombre.SelectedIndexChanged += new System.EventHandler(this.cBNombre_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(56, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 29);
            this.label5.TabIndex = 140;
            this.label5.Text = "Datos de la persona:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(57, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 23);
            this.label3.TabIndex = 139;
            this.label3.Text = "Buscar nombre:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 150;
            this.label1.Text = "Mes de pago a eliminar:";
            this.label1.Visible = false;
            // 
            // labelMes
            // 
            this.labelMes.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMes.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMes.Location = new System.Drawing.Point(205, 356);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(44, 23);
            this.labelMes.TabIndex = 149;
            this.labelMes.Text = "Mes";
            this.labelMes.Visible = false;
            // 
            // labelAno
            // 
            this.labelAno.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAno.Location = new System.Drawing.Point(59, 354);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(42, 23);
            this.labelAno.TabIndex = 147;
            this.labelAno.Text = "Año";
            this.labelAno.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel5.Location = new System.Drawing.Point(361, 434);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 3);
            this.panel5.TabIndex = 154;
            this.panel5.Visible = false;
            // 
            // labelTelefono
            // 
            this.labelTelefono.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefono.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTelefono.Location = new System.Drawing.Point(382, 411);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(142, 23);
            this.labelTelefono.TabIndex = 152;
            this.labelTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTelefono.Visible = false;
            // 
            // labelCantidadPagada
            // 
            this.labelCantidadPagada.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadPagada.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCantidadPagada.Location = new System.Drawing.Point(382, 360);
            this.labelCantidadPagada.Name = "labelCantidadPagada";
            this.labelCantidadPagada.Size = new System.Drawing.Size(140, 23);
            this.labelCantidadPagada.TabIndex = 151;
            this.labelCantidadPagada.Text = "Cantidad Pagada";
            this.labelCantidadPagada.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(361, 458);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 44);
            this.btnEliminar.TabIndex = 158;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(361, 508);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 23);
            this.checkBox1.TabIndex = 159;
            this.checkBox1.Text = "Estas seguro";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelContraseña
            // 
            this.labelContraseña.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.SystemColors.Control;
            this.labelContraseña.Location = new System.Drawing.Point(600, 356);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(122, 29);
            this.labelContraseña.TabIndex = 160;
            this.labelContraseña.Text = "Contraseña";
            this.labelContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelContraseña.Visible = false;
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.txtBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxContraseña.Enabled = false;
            this.txtBoxContraseña.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxContraseña.ForeColor = System.Drawing.Color.White;
            this.txtBoxContraseña.Location = new System.Drawing.Point(588, 416);
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.PasswordChar = '*';
            this.txtBoxContraseña.Size = new System.Drawing.Size(170, 32);
            this.txtBoxContraseña.TabIndex = 161;
            this.txtBoxContraseña.Tag = "1";
            this.txtBoxContraseña.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel2.Location = new System.Drawing.Point(588, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 3);
            this.panel2.TabIndex = 144;
            this.panel2.Visible = false;
            // 
            // labelMostrarAno
            // 
            this.labelMostrarAno.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostrarAno.ForeColor = System.Drawing.Color.White;
            this.labelMostrarAno.Location = new System.Drawing.Point(57, 418);
            this.labelMostrarAno.Name = "labelMostrarAno";
            this.labelMostrarAno.Size = new System.Drawing.Size(116, 31);
            this.labelMostrarAno.TabIndex = 162;
            // 
            // labelMostrarMes
            // 
            this.labelMostrarMes.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostrarMes.ForeColor = System.Drawing.Color.White;
            this.labelMostrarMes.Location = new System.Drawing.Point(207, 419);
            this.labelMostrarMes.Name = "labelMostrarMes";
            this.labelMostrarMes.Size = new System.Drawing.Size(116, 31);
            this.labelMostrarMes.TabIndex = 163;
            // 
            // FormEditarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(797, 564);
            this.Controls.Add(this.labelMostrarMes);
            this.Controls.Add(this.labelMostrarAno);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBoxContraseña);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelCantidadPagada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditarPagos";
            this.Text = "FormEditarPagos";
            this.Load += new System.EventHandler(this.FormEditarPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelCantidadPagada;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox txtBoxContraseña;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMostrarAno;
        private System.Windows.Forms.Label labelMostrarMes;
    }
}