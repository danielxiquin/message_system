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
    public partial class cambiotelefono : Form
    {
        private string UsuarioActual;

        public cambiotelefono(string usuario)
        {
            InitializeComponent();
            UsuarioActual = usuario;
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textTelefono.Text) || !int.TryParse(textTelefono.Text, out _))
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string filePath = @"C:\MEIA\user.txt";

                if (File.Exists(filePath))
                {
                    string[] usuarios = File.ReadAllLines(filePath);
                    bool usuarioEncontrado = false;

                    for (int i = 0; i < usuarios.Length; i++)
                    {
                        string[] campos = usuarios[i].Split(';');

                        if (campos[0].Trim() == UsuarioActual)
                        {
                            campos[6] = textTelefono.Text;

                            usuarios[i] = string.Join(";", campos);

                            File.WriteAllLines(filePath, usuarios);

                            usuarioEncontrado = true;
                            MessageBox.Show("Teléfono actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Se produjo un error al actualizar el teléfono: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
