using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        }
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            Incidencias i = new Incidencias();

            this.Hide();

            // Mostrar el formulario de Incidencias
            i.Show();
        }

        //Codigo para el Boton Favorito
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox5.Image = Properties.Resources.estrellaAmarilla_fotor_bg_remover_20231021185036; // Cambia la imagen a la estrella seleccionada
            }
            else
            {
                pictureBox5.Image = Properties.Resources.estrellaNegra_fotor_bg_remover_2023102118503; // Cambia la imagen a la estrella no seleccionada
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = !radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox6.Image = Properties.Resources.estrellaAmarilla_fotor_bg_remover_20231021185036; // Cambia la imagen a la estrella seleccionada
            }
            else
            {
                pictureBox6.Image = Properties.Resources.estrellaNegra_fotor_bg_remover_2023102118503; // Cambia la imagen a la estrella no seleccionada
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            radioButton2.Checked = !radioButton2.Checked;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictureBox8.Image = Properties.Resources.estrellaAmarilla_fotor_bg_remover_20231021185036; // Cambia la imagen a la estrella seleccionada
            }
            else
            {
                pictureBox8.Image = Properties.Resources.estrellaNegra_fotor_bg_remover_2023102118503; // Cambia la imagen a la estrella no seleccionada
            }
        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = !radioButton3.Checked;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                pictureBox10.Image = Properties.Resources.estrellaAmarilla_fotor_bg_remover_20231021185036; // Cambia la imagen a la estrella seleccionada
            }
            else
            {
                pictureBox10.Image = Properties.Resources.estrellaNegra_fotor_bg_remover_2023102118503; // Cambia la imagen a la estrella no seleccionada
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = !radioButton4.Checked;
        }



        //Para hacer el boton circular de añadir nuevo cliente

        private void buttonAddCliente_Paint(object sender, PaintEventArgs e)
        {

            System.Windows.Forms.Button btn1 = (System.Windows.Forms.Button)sender;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(2, 2, btn1.Width-5, btn1.Height-5);
            btn1.Region = new Region(gp);
        }

        private void buttonAddCliente_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Agregar nuevo cliente");
        }

        private void buttonAddCliente_MouseEnter(object sender, EventArgs e)
        {
            buttonAddCliente.BackColor = Color.LightBlue; // Cambia el color de fondo cuando el cursor entra en el botón
            buttonAddCliente.ForeColor = Color.White;
        }

        private void buttonAddCliente_MouseLeave(object sender, EventArgs e)
        {
            buttonAddCliente.BackColor = Color.FromArgb(64, 64, 64); // Restaura el color de fondo predeterminado cuando el cursor sale del botón
            buttonAddCliente.ForeColor = Color.White;
        }

        //PlaceHolder del botton de buscar cliente
        private void buscarTextBox_Enter(object sender, EventArgs e)
        {
            if (buscarTextBox.Text == "Buscar")
            {
                buscarTextBox.Text = "";
            }
        }

        private void buscarTextBox_Leave(object sender, EventArgs e)
        {
            if (buscarTextBox.Text == "")
            {
                buscarTextBox.Text = "Buscar";
            }
        }

        //Boton para cerrar la aplicación
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimizar la pantalla
        private void buttonMinimizarr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
