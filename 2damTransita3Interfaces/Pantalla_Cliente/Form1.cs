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
    public partial class PantallaCliente : Form
    {
        public PantallaCliente()
        {
            InitializeComponent();
            this.Text = "Mi Aplicación Personalizada";
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);

            btn_filtrar.FlatStyle = FlatStyle.Flat;
            btn_filtrar.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;
            //this.MinimizeBox = false;
            this.MaximizeBox = false;
            //this.ControlBox = false
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void imgTransita_Click(object sender, EventArgs e)
        {
                     



        }
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Incidencias i = new Incidencias();
            this.Hide();
            i.Show();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
