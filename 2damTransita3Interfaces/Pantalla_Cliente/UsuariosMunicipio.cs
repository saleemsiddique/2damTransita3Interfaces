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
        private int paginasTotalesActual;
        private int idInicial;
        private int idFinal;
        private int idPrincipio;
        private int paginasTotales;
        private int paginaActual = 1;
        public UsuariosMunicipio()
        {
            InitializeComponent();
            ObtenerUsuariosMunicipio();
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);
        }


        private async Task ObtenerUsuariosMunicipio() {
            await ObtenerIdInicialYFinal();
            idPrincipio = idInicial;
            usuariosMunicipios = await usuarioMunicipioService.GetUsuarioMunicipiosFiltred(filtro, idInicial, idFinal);
            CrearPanelesUsuariosMunicipio(usuariosMunicipios);
        }

        private async Task ObtenerIdInicialYFinal()
        {
            idInicial = 1;
            idFinal = idInicial + 6;
            paginasTotalesActual = await usuarioMunicipioService.GetNumeroUsuarioMunicipiosFiltrado(filtro);

            dividirEnPaginas();
        }

        public async Task obtenerUsuariosRefresh()
        {
            Console.WriteLine("ASHKDJAHSDKJHSADA");
            paginasTotalesActual = await usuarioMunicipioService.GetNumeroUsuarioMunicipiosFiltrado(filtro);
            Console.WriteLine("PAGINAS TOTALES ACTUAL" + paginasTotalesActual);
            dividirEnPaginas();
            idPrincipio = idInicial;
            Console.WriteLine("PAGINAS IDINICIAL ACTUAL" + idInicial);
            usuariosMunicipios = await usuarioMunicipioService.GetUsuarioMunicipiosFiltred(filtro, idInicial, idFinal);
            Console.WriteLine("USUARIOS MUNICIPIOS DONE");
            CrearPanelesUsuariosMunicipio(usuariosMunicipios);
        }

        private void dividirEnPaginas()
        {

            if (paginasTotalesActual % 7 != 0)
            {
                paginasTotalesActual = paginasTotalesActual / 7;
                paginasTotalesActual++;
            }
            else
            {
                paginasTotalesActual = paginasTotalesActual / 7;
            }

            if (paginasTotalesActual != 0)
            {
                paginas.Text = paginaActual + "/" + paginasTotalesActual;
            }
            else
            {
                paginas.Text = 0 + "/" + paginasTotalesActual;
            }
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

                usuariosMunicipioBanner.getPanel().Click += (sender, e) =>
                {
                    usuariosMunicipioBanner.getPanel().Focus();
                    nombre.Text = usuario.nombre + " " + usuario.apellidos;
                    correo.Text = usuario.nombreUsuario;
                    id_mostrar.Text = usuario.id + "";
                    nombre_mostrar.Text = usuario.nombre;
                    apellido_mostrar.Text = usuario.apellidos;
                    nombreUsuario_mostrar.Text = usuario.nombreUsuario;
                    rol_mostrar.Text = usuario.rols[0].ToString() + "";
                    usuariosMunicipioBanner.getPanel().BorderStyle = BorderStyle.Fixed3D;
                    usuariosMunicipioBanner.getPanel().Invalidate();
                };

                usuariosMunicipioBanner.getPanel().LostFocus += (sender, e) =>
                {
                    usuariosMunicipioBanner.getPanel().BorderStyle = BorderStyle.None;
                    usuariosMunicipioBanner.getPanel().Invalidate();
                };


                // Configura la ubicación y otros detalles según sea necesario
                usuariosMunicipioBanner.Location = new Point(33, topPosition); // Personaliza la ubicación
                topPosition += usuariosMunicipioBanner.Height + 10; // Ajusta el espaciado vertical según sea necesario
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

        private async void buttonAceptar_Click(object sender, EventArgs e)
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
            Task task = obtenerUsuariosRefresh();
            idInicial = 1;
            idFinal = idInicial + 6;
            paginasTotalesActual = await usuarioMunicipioService.GetNumeroUsuarioMunicipiosFiltrado(filtro);
            paginaActual = 1;
            paginas.Text = paginaActual + "/" + paginasTotalesActual;
            dividirEnPaginas();


            task.ContinueWith(t =>
            {
                Console.WriteLine("\n\n\n continue");
                Form formularioPadre = this.Owner;

                if (formularioPadre != null)
                {
                    Console.WriteLine("\n\n\n null");
                    if (formularioPadre is Transita)
                    {
                        Transita formularioTransita = (Transita)formularioPadre;
                        formularioTransita.MostrarPanelDeUsuariosMunicipio();
                        Console.WriteLine("\n\n\n close");
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

        private async void adelanteBtn_Click(object sender, EventArgs e)
        {
            if (paginaActual < paginasTotalesActual)
            {
                limpiarVisualizacion();
                idInicial += 7;
                idFinal = idInicial + 6;
                paginaActual++;
                await obtenerUsuariosRefresh();
            }
        }

        private async void atrasBtn_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                if (idInicial >= idPrincipio)
                {
                    limpiarVisualizacion();
                    idInicial -= 7;
                    idFinal = idInicial + 6;
                    paginaActual--;
                    await obtenerUsuariosRefresh();
                }
            }
        }
    }
}
