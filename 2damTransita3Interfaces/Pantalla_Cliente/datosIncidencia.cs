using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class datosIncidencia : Form
    {
        public datosIncidencia()
        {
            InitializeComponent();

            //Estilo para el boton X para cerrar la ventana de momento se usara el por defecto del form
            /*btn_cerrarDatosIncidencia.BackColor = Color.Transparent;
            btn_cerrarDatosIncidencia.ForeColor = Color.White;
            btn_cerrarDatosIncidencia.FlatStyle = FlatStyle.Flat;
            btn_cerrarDatosIncidencia.FlatAppearance.BorderSize = 0;
            btn_cerrarDatosIncidencia.TabStop = false;
            btn_cerrarDatosIncidencia.FlatAppearance.MouseOverBackColor = Color.Transparent;*/
            

        }
        private void datosIncidencia_Load(object sender, EventArgs e)
        {
            //Posible codigo para que al cargar el form obtenga los datos en forma de array y los podamos asignar al cada control del form
            /*string connectionString = "cadena_de_conexion"; // Reemplaza con tu cadena de conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, Descripcion, Imagen FROM TuTabla WHERE ID = @id"; // Reemplaza con tu consulta SQL

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Puedes establecer el valor de @id con el ID de la fila que deseas obtener
                    command.Parameters.AddWithValue("@id", tuID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader["id"];
                            string lugar = reader["lugar"].ToString();
                            double latitud = reader["latitud"];
                            double longitud = reader["longitud"];
                            byte[] imagenBytes = (byte[])reader["Imagen"];

                            // Asignar valores a los controles en el formulario
                            lblNombre.Text = nombre;
                            lblDescripcion.Text = descripcion;
                            pictureBox1.Image = ByteArrayToImage(imagenBytes); // Método para convertir bytes a imagen
                        }
                    }
                }
            }*/
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Foto del user que ha reportado o creado la incidencia
        }

        private void btn_AceptarIncidencia_Click(object sender, EventArgs e)
        {
            //codigo para aceptar o terminar la incidencia a la base de datos
        }

        private void btn_reportarIncidencia_Click(object sender, EventArgs e)
        {
            //codigo para reportar o mandar la incidencia a la base de datos
        }

        private void picture_incidencia_Click(object sender, EventArgs e)
        {
            //foto del lugar de la incidencia creada 
        }

        private void btn_cerrarDatosIncidencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_lugarData_Click(object sender, EventArgs e)
        {
            //asiganara los datos de la peticion a la BDD luigar al label luigar de la incidencia
        }

        private void label_IDData_Click(object sender, EventArgs e)
        {
            //asiganara los datos de la peticion a la BDD id al label id de la incidencia
        }

        private void label_datosInciencia_Click(object sender, EventArgs e)
        {

        }
    }
}
