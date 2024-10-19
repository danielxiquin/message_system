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
    public partial class cambiarFecha : Form
    {
        private string UsuarioActual;

        public cambiarFecha(string usuario)
        {
            InitializeComponent();
            UsuarioActual = usuario;
        }

        private void cambios_Click(object sender, EventArgs e)
        {
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

                        if (campos[0].Trim() == UsuarioActual)
                        {
                            campos[5] = fecha.Value.ToString("dd/MM/yyyy");  

                            usuarios[i] = string.Join(";", campos);

                            File.WriteAllLines(filePath, usuarios);

                            usuarioEncontrado = true;
                            MessageBox.Show("Fecha de nacimiento actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Se produjo un error al actualizar la fecha: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
