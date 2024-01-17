using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public static class Utils
    {
        public static ContextMenuStrip emptyMenu = new ContextMenuStrip();

        public static void paginaDropDown_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
