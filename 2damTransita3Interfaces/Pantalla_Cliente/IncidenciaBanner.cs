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
    public partial class IncidenciaBanner : UserControl
    {
        public IncidenciaBanner()
        {
            InitializeComponent();
        }

        public Label getId()
        {
            return idIncidencia;
        }

        public Label getNombre()
        {
            return nombreIncidencia;
        }

        public Button getViewBtn()
        {
            return btnViewIncidencia;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
