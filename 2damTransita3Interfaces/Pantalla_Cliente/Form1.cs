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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void imgTransita_Click(object sender, EventArgs e)
        {
                     



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Incidencias i = new Incidencias();

            this.Hide();

            // Mostrar el formulario de Incidencias
            i.Show();
        }
    }

    /*Codigo para refrescar la unica pantalla usa
     * private void btnCambiarContenido_Click(object sender, EventArgs e)
{
    // Borra el contenido actual del Panel
    panelContenido.Controls.Clear();

    // Crea y agrega un nuevo control o formulario al Panel
    var nuevoContenido = new MiNuevoControl(); // Reemplaza 'MiNuevoControl' con el control que deseas mostrar
    panelContenido.Controls.Add(nuevoContenido);

    // Ajusta el tamaño del nuevo contenido
    nuevoContenido.Dock = DockStyle.Fill;
}*/
}
