using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO Implementar funcion cambiar contraseña
namespace Pantalla_Cliente
{
    public partial class UsuariosMunicipio : Form
    {
        UsuarioMunicipioService usuarioMunicipioService = new UsuarioMunicipioService();
        private int filtro = 0;
        List<Cliente> usuariosMunicipios;
        private bool esVisible = false;
        public UsuariosMunicipio()
        {
            InitializeComponent();
            ObtenerUsuariosMunicipio();
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);
        }


        private async Task ObtenerUsuariosMunicipio() {
            usuariosMunicipios = await usuarioMunicipioService.GetUsuariosMunicipiosAsync(filtro);
            CrearPanelesUsuariosMunicipio(usuariosMunicipios);
        }
        private void CrearPanelesUsuariosMunicipio(List<Cliente> listaUsuariosMunicipio)
        {
            foreach (Cliente usuario in listaUsuariosMunicipio)
            { Console.WriteLine(usuario.ToString()); }

            int topPosition = 0; // Posición vertical inicial
            foreach (Cliente usuario in listaUsuariosMunicipio)
            {
                UsuariosMunicipioBanner usuariosMunicipioBanner = new UsuariosMunicipioBanner(); // Crea una instancia del UserControl
                usuariosMunicipioBanner.getId().Text = usuario.id + "";
                usuariosMunicipioBanner.getNombre().Text = $"{usuario.nombre} {usuario.apellidos}";

                usuariosMunicipioBanner.getViewBtn().Click += (sender, e) =>
                {
                    nombre.Text = usuario.nombre + " " + usuario.apellidos;
                    correo.Text = usuario.nombreUsuario;
                    id_mostrar.Text = usuario.id + "";
                    nombre_mostrar.Text = usuario.nombre;
                    apellido_mostrar.Text = usuario.apellidos;
                    nombreUsuario_mostrar.Text = usuario.nombreUsuario;
                    rol_mostrar.Text = usuario.rols[0].ToString() + "";
                };

                // Configura la ubicación y otros detalles según sea necesario
                usuariosMunicipioBanner.Location = new Point(0, topPosition); // Personaliza la ubicación
                topPosition += usuariosMunicipioBanner.Height + 30; // Ajusta el espaciado vertical según sea necesario
                //usuariosMunicipioBanner.Anchor = AnchorStyles.Left | AnchorStyles.Right; // Anclaje para que se ajuste al tamaño del formulario
                usuariosMunicipioBanner.Show();
                // Agrega el control al formulario principal
                panelUsuarios.Controls.Add(usuariosMunicipioBanner);
            }
        }

        public Panel ObtenerPanelCentralZona()
        {
            return panel4;
        }

        public Panel ObtenerPanelDerechaZona()
        {
            return panel3;
        }



        private void buttonAddCliente_Click(object sender, EventArgs e)
        {
            CrearUsuarioMunicipio crearUsuarioMunicipio = new CrearUsuarioMunicipio();
            crearUsuarioMunicipio.Owner = this;
            crearUsuarioMunicipio.Show();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (filtro_admin.Checked) filtro = 1;
            else if (filtro_mod.Checked) filtro = 2;
            else filtro = 0;

            limpiarVisualizacion();
            groupBox2.Visible = false;
            esVisible = false;
            usuarioImg = null;
            nombre.Text = "";
            correo.Text = "";
            id_mostrar.Text = "";
            nombre_mostrar.Text = "";
            apellido_mostrar.Text = "";
            nombreUsuario_mostrar.Text = "";
            Task task = ObtenerUsuariosMunicipio();

            task.ContinueWith(t =>
            {
                // This part will be executed when modifyUser completes, but won't block the UI
                Form formularioPadre = this.Owner;

                if (formularioPadre != null)
                {
                    if (formularioPadre is Transita)
                    {
                        Transita formularioTransita = (Transita)formularioPadre;
                        formularioTransita.MostrarPanelDeUsuariosMunicipio();
                        this.Close();
                    }
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());

        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    foreach (Control control in checkBox.Parent.Controls)
                    {
                        if (control is CheckBox otherCheckBox && !otherCheckBox.Equals(checkBox))
                        {
                            otherCheckBox.Checked = false;
                        }
                    }
                }
            }
        }

        private void limpiarVisualizacion()
        {
            usuariosMunicipios.Clear();
            foreach (Control control in panelUsuarios.Controls.OfType<UsuariosMunicipioBanner>().ToList())
            {
                panelUsuarios.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            esVisible = !esVisible;
            groupBox2.Visible = esVisible;
        }
    }
}
