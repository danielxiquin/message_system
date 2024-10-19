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
    public partial class modificarAdmin : Form
    {
        private string[] usuarios;
        private int indiceUsuario;
        private string nombreModificado;
        private string apellidoModificado;
        private string telefonoModificado;
        private string fechaModificada;
        public modificarAdmin(string[] usuarios, int indiceusuario)
        {
            InitializeComponent();
            this.usuarios = usuarios;
            this.indiceUsuario = indiceusuario;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            string usuarioActual = usuarios[indiceUsuario];
            string[] camposUsuario = usuarioActual.Split(';');

            txtNombre.Text = camposUsuario[1].Trim();
            txtApellido.Text = camposUsuario[2].Trim();
            txtTelefono.Text = camposUsuario[6];
            fechaNueva.Value = DateTime.Parse(camposUsuario[5]);
        }

      

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String usuarioActual = usuarios[indiceUsuario];
            String[] camposUsuario = usuarioActual.Split(';');
            try
            {
                
                string filePath = @"C:\MEIA\user.txt";

                if (File.Exists(filePath))
                {
                    string[] usuarios = File.ReadAllLines(filePath);
                    bool usuarioEncontrado = false;

                    for (int i = 0; i < usuarios.Length; i++)
                    {
                        string[] campos = usuarios[i].Split(';');

                        if (campos[0].Trim() == camposUsuario[0].Trim())
                        {

                            if (camposUsuario[1].Trim() != txtNombre.Text)
                            {
                                campos[1] = txtNombre.Text.PadRight(30);
                            }

                            if (camposUsuario[2] != txtApellido.Text)
                            {
                                campos[2] = txtApellido.Text.PadRight(30);
                            }

                            if (camposUsuario[6] != txtTelefono.Text)
                            {
                                if (string.IsNullOrWhiteSpace(txtTelefono.Text) || !int.TryParse(txtTelefono.Text, out _))
                                {
                                    MessageBox.Show("Por favor, ingrese un número de teléfono válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                campos[6] = txtTelefono.Text;
                            }

                            if (camposUsuario[5] != fechaNueva.Value.ToString("dd/MM/yyyy"))
                            {
                                campos[5] = fechaNueva.Value.ToString("dd/MM/yyyy");
                            }


                            usuarios[i] = string.Join(";", campos);

                            File.WriteAllLines(filePath, usuarios);

                            usuarioEncontrado = true;
                            MessageBox.Show("Datos cambiados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }

                    if (!usuarioEncontrado)
                    {
                        MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de usuarios no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al actualizar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechaNueva_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
