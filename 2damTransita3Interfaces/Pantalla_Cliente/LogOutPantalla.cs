using Pantalla_Cliente;
using System;
using System.Windows.Forms;

namespace transitaControllers
{
    public partial class LogOutPantalla : Form
    {
        private static bool tiempoAgotadoProcesadoGlobal = false;
        private LogOutTImer logOutTimerControl;

        public LogOutPantalla()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            logOutTimerControl = new LogOutTImer();
            logOutTimerControl.TiempoAgotado += LogOutTimerControl_TiempoAgotado;
            
        }

        private void LogOutTimerControl_TiempoAgotado(object sender, EventArgs e)
        {
            if (!tiempoAgotadoProcesadoGlobal)
            {
                tiempoAgotadoProcesadoGlobal = true;
                this.Close();
                AbrirFormularioLogin();
            }
        }
        private void AbrirFormularioLogin()
        {
            Application.Restart();
        }
        private void btn_si_Click(object sender, EventArgs e)
        {
            AbrirFormularioLogin();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            logOutTimerControl.TiempoAgotado -= LogOutTimerControl_TiempoAgotado;

            this.Close();
        }


        private void LogOutPantalla_Load(object sender, EventArgs e)
        {

        }
    }
}
