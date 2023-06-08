namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReporteCaja = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonReportePersona = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(189, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 564);
            this.panel1.TabIndex = 18;
            this.panel1.Tag = "10";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "AGUA POTABLE";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "EL AGUACATE";
            // 
            // buttonReporteCaja
            // 
            this.buttonReporteCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.buttonReporteCaja.FlatAppearance.BorderSize = 0;
            this.buttonReporteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReporteCaja.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonReporteCaja.ForeColor = System.Drawing.Color.White;
            this.buttonReporteCaja.Image = global::WindowsFormsApp2.Properties.Resources.Reporte;
            this.buttonReporteCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReporteCaja.Location = new System.Drawing.Point(-10, 297);
            this.buttonReporteCaja.Name = "buttonReporteCaja";
            this.buttonReporteCaja.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonReporteCaja.Size = new System.Drawing.Size(199, 51);
            this.buttonReporteCaja.TabIndex = 27;
            this.buttonReporteCaja.Text = "        Reporte Caja";
            this.buttonReporteCaja.UseVisualStyleBackColor = true;
            this.buttonReporteCaja.Click += new System.EventHandler(this.buttonReporteCaja_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.grifo_de_agua;
            this.pictureBox1.Location = new System.Drawing.Point(54, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // buttonReportePersona
            // 
            this.buttonReportePersona.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.buttonReportePersona.FlatAppearance.BorderSize = 0;
            this.buttonReportePersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportePersona.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonReportePersona.ForeColor = System.Drawing.Color.White;
            this.buttonReportePersona.Image = global::WindowsFormsApp2.Properties.Resources.equipo__1_;
            this.buttonReportePersona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportePersona.Location = new System.Drawing.Point(-7, 240);
            this.buttonReportePersona.Name = "buttonReportePersona";
            this.buttonReportePersona.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonReportePersona.Size = new System.Drawing.Size(221, 51);
            this.buttonReportePersona.TabIndex = 20;
            this.buttonReportePersona.Text = "    Reporte Persona";
            this.buttonReportePersona.UseVisualStyleBackColor = true;
            this.buttonReportePersona.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::WindowsFormsApp2.Properties.Resources.efectivo;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-5, 183);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(197, 51);
            this.button2.TabIndex = 21;
            this.button2.Text = "Pagos  ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::WindowsFormsApp2.Properties.Resources.flecha;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-16, 519);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(211, 43);
            this.button3.TabIndex = 22;
            this.button3.Text = "     Cerrar Sesion";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.Image = global::WindowsFormsApp2.Properties.Resources.editar;
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificar.Location = new System.Drawing.Point(-11, 354);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonModificar.Size = new System.Drawing.Size(203, 51);
            this.buttonModificar.TabIndex = 23;
            this.buttonModificar.Text = "    Personas";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel2.Location = new System.Drawing.Point(17, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 3);
            this.panel2.TabIndex = 28;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel10.Location = new System.Drawing.Point(-5, 183);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 51);
            this.panel10.TabIndex = 29;
            this.panel10.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel11.Location = new System.Drawing.Point(-5, 240);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 51);
            this.panel11.TabIndex = 30;
            this.panel11.Visible = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel12.Location = new System.Drawing.Point(-5, 297);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 51);
            this.panel12.TabIndex = 31;
            this.panel12.Visible = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel13.Location = new System.Drawing.Point(-5, 354);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 51);
            this.panel13.TabIndex = 30;
            this.panel13.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonReporteCaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonReportePersona);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReportePersona;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReporteCaja;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
    }
}