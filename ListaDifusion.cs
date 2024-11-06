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
    public partial class ListaDifusion : Form
    {
        private string usuarioActual;
        public ListaDifusion(string usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            crearLista crearLista = new crearLista(usuarioActual);
            crearLista.Show();
            this.Close();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            mantenimientoLista mantenimientoLista = new mantenimientoLista(usuarioActual);
            mantenimientoLista.Show();
            this.Close();

        }

        private void btnUsuarioLista_Click(object sender, EventArgs e)
        {
            MantenimientoListaUsuario mantenimientoLista = new MantenimientoListaUsuario(usuarioActual);
            mantenimientoLista.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
