using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace message_system
{
    public partial class MantenimientoListaUsuario : Form
    {
        private string usuarioActual;
        public MantenimientoListaUsuario(string usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AccionListas usas = new AccionListas(usuarioActual);
            usas.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ListaDifusion listaDifusion = new ListaDifusion(usuarioActual);
            listaDifusion.Show();   
            this.Close();
        }
    }
}
