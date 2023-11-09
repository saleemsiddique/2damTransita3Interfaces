using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Crimson;
            this.BackColor = Color.Crimson;
            Activated += DoSomeStuff;
            
        }

        public void dispose() {
            this.Close();
        }

        private async void DoSomeStuff(object sender, EventArgs e)
        {
            //Do You Stuff here
            await Task.Run(() => Thread.Sleep(2000));
            this.Close();
        }


    }
}
