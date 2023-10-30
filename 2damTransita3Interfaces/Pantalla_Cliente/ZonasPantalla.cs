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
    public partial class ZonasPantalla : Form
    {
        public ZonasPantalla()
        {
            InitializeComponent();
        }

        private void buttonAddCliente_Click(object sender, EventArgs e)
        {

        }
        public Panel ObtenerPanelCentralZona()
        {
            return panel4;
        }

        public Panel ObtenerPanelDerechaZona()
        {
            return panel3;
        }

    }
}
