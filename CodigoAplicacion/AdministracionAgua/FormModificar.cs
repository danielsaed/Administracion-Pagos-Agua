using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
        }
        public void AbrirFormInPanel(object Formhijo)
        {
            if (this.panel3.Controls.Count > 0)
            {
                this.panel3.Controls.RemoveAt(0);
            }

            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Insertar());
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Editar());
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Eliminar());
        }
    }
}
