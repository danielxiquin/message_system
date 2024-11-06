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
    public partial class modificarContacto : Form
    {
        private string[] contacto;

        public modificarContacto(string[] contacto)
        {
            InitializeComponent();
            this.contacto = contacto;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechaT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTransacción_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRehabilitar_Click(object sender, EventArgs e)
        {
            string path = @"C:\MEIA\contactos.txt";

            if (File.Exists(path))
            {
                string[] contactos = File.ReadAllLines(path);
                bool contactoEncontrado = false;

                for (int i = 0; i < contactos.Length; i++)
                {
                    string[] campos = contactos[i].Trim().Split(';');


                    if (campos[0].Trim() == contacto[0].Trim() && campos[1].Trim() == contacto[1].Trim())
                    {
                        campos[4] = "1";

                        contactos[i] = string.Join(";", campos);

                        File.WriteAllLines(path, contactos);

                        contactoEncontrado = true;

                        MessageBox.Show("Has reasignado de nuevo el contacto.", "Contacto reasignado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (!contactoEncontrado)
                {
                    MessageBox.Show("Este usuario no es parte de tus contactos.", "Baja de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se han aceptado los cambios", "Cambios aceptados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void modificarContacto_Load(object sender, EventArgs e)
        {
            string[] campos = contacto;

            txtUsuario.Text = campos[0].Trim();
            txtContacto.Text = campos[1].Trim();
            txtTransacción.Text = campos[3].Trim();
            fechaT.Value = DateTime.Parse(campos[2]);

            txtUsuario.ReadOnly = true;
            txtContacto.ReadOnly = true;
            txtTransacción.ReadOnly = true;
            fechaT.Enabled = false; 
        }
    }
}
