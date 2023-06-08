namespace WindowsFormsApp2
{
    partial class Eliminar
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
            this.checkBConfirmar = new System.Windows.Forms.CheckBox();
            this.btnPago = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.cBNombre = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNombre1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(323, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 37);
            this.label11.TabIndex = 152;
            this.label11.Text = "Eliminar";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // checkBConfirmar
            // 
            this.checkBConfirmar.AutoSize = true;
            this.checkBConfirmar.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBConfirmar.ForeColor = System.Drawing.Color.White;
            this.checkBConfirmar.Location = new System.Drawing.Point(309, 320);
            this.checkBConfirmar.Name = "checkBConfirmar";
            this.checkBConfirmar.Size = new System.Drawing.Size(105, 24);
            this.checkBConfirmar.TabIndex = 151;
            this.checkBConfirmar.Text = "Confirmar ";
            this.checkBConfirmar.UseVisualStyleBackColor = true;
            this.checkBConfirmar.Visible = false;
            this.checkBConfirmar.CheckedChanged += new System.EventHandler(this.checkBConfirmar_CheckedChanged);
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
            this.btnPago.Location = new System.Drawing.Point(309, 279);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(150, 35);
            this.btnPago.TabIndex = 150;
            this.btnPago.Text = "Eliminar";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Visible = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(348, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 138;
            this.label9.Text = "Datos:";
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNombre.Location = new System.Drawing.Point(527, 153);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(86, 23);
            this.labelNombre.TabIndex = 156;
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
            this.cBNombre.Location = new System.Drawing.Point(397, 196);
            this.cBNombre.Name = "cBNombre";
            this.cBNombre.Size = new System.Drawing.Size(348, 24);
            this.cBNombre.TabIndex = 155;
            this.cBNombre.Visible = false;
            this.cBNombre.SelectedIndexChanged += new System.EventHandler(this.cBNombre_SelectedIndexChanged);
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
            this.btnBuscar.Location = new System.Drawing.Point(54, 235);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 32);
            this.btnBuscar.TabIndex = 168;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel1.Location = new System.Drawing.Point(54, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 3);
            this.panel1.TabIndex = 166;
            // 
            // textBoxNombre1
            // 
            this.textBoxNombre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.textBoxNombre1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNombre1.ForeColor = System.Drawing.Color.White;
            this.textBoxNombre1.Location = new System.Drawing.Point(54, 197);
            this.textBoxNombre1.Name = "textBoxNombre1";
            this.textBoxNombre1.Size = new System.Drawing.Size(260, 32);
            this.textBoxNombre1.TabIndex = 167;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 165;
            this.label1.Text = "Buscar nombre:";
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(780, 496);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxNombre1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.cBNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBConfirmar);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBConfirmar;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox cBNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNombre1;
        private System.Windows.Forms.Label label1;
    }
}