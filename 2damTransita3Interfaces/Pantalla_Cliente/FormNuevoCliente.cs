using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class FormNuevoCliente : Form
    {
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        //// Cierra el formulario actual (NuevoCliente)
        private void btn_reportarIncidencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
