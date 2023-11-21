using System;
using System.Windows.Forms;

namespace transitaControllers
{
    public partial class LogOutTImer : UserControl
    {
        private int tiempoRestante = 15;

        public event EventHandler TiempoAgotado;

        public LogOutTImer()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
        }

        public void IniciarContador()
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            bool tiempoAgotado = ControlarTiempo();
            if (tiempoAgotado)
            {
                // Lanza el evento TiempoAgotado cuando el tiempo se ha agotado
                OnTiempoAgotado(EventArgs.Empty);
                timer1.Stop();
            }
        }

        private bool ControlarTiempo()
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--;
                lbl_timer.Text = TimeSpan.FromSeconds(tiempoRestante).ToString("mm\\:ss");
                return false; // El tiempo no se ha agotado todavía.
            }
            else
            {
                return true; // El tiempo se ha agotado.
            }
        }

        protected virtual void OnTiempoAgotado(EventArgs e)
        {
            // Lanza el evento TiempoAgotado
            TiempoAgotado?.Invoke(this, e);
        }

        private void LogOutTImer_Load(object sender, EventArgs e)
        {

        }
    }
}
