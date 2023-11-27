using System;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class FiltrosIncidencia : Form
    {
        private int tipoFiltro;
        private bool checkBox1Estado;
        private bool checkBox2Estado;
        private bool checkBox3Estado;
        private bool checkBox4Estado;

        public FiltrosIncidencia()
        {
            InitializeComponent();
        }

        // Método público para obtener el valor del filtro
        public int ObtenerValorFiltro()
        {
            if (checkBox1.Checked)
                tipoFiltro = 1;
            else if (checkBox2.Checked)
                tipoFiltro = 2;
            else if (checkBox3.Checked)
                tipoFiltro = 3;
            else if (checkBox4.Checked)
                tipoFiltro = 4;

            return tipoFiltro;
        }

        private void GuardarEstadoCheckBox()
        {
            checkBox1Estado = checkBox1.Checked;
            checkBox2Estado = checkBox2.Checked;
            checkBox3Estado = checkBox3.Checked;
            checkBox4Estado = checkBox4.Checked;
        }

        private void RestaurarEstadoCheckBox()
        {
            checkBox1.Checked = checkBox1Estado;
            checkBox2.Checked = checkBox2Estado;
            checkBox3.Checked = checkBox3Estado;
            checkBox4.Checked = checkBox4Estado;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // Puedes realizar acciones específicas cuando se cambia el estado del checkbox
        }

        private void FiltrosIncidencia_Load(object sender, EventArgs e)
        {
            // Restaurar el estado de los checkboxes al cargar el formulario
            RestaurarEstadoCheckBox();
        }

        private void FiltrosIncidencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Guardar el estado de los checkboxes al cerrar el formulario
            GuardarEstadoCheckBox();
        }


        // En FiltrosIncidencia
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
          
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
