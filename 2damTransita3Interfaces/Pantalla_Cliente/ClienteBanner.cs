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
    public partial class ClienteBanner : UserControl
    {
        public ClienteBanner()
        {
            InitializeComponent();
        }
        public Label getId()
        {
            return idCliente;
        }

        public Label getNombre()
        {
            return nombreCliente;
        }

        public Button getViewBtn()
        {
            return btnViewCliente;
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
