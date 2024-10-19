using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace message_system
{
    public partial class Changepass : Form
    {
        private string currentUser;
        public Changepass(String usuarioactual)
        {
            InitializeComponent();
            currentUser = usuarioactual.Trim();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string contrasenaActual = CifrarContrasena(contraseñaActual.Text);
            string nuevaContrasena = CifrarContrasena(contraseñaNueva.Text);
            string confirmarContrasena = CifrarContrasena(confirmarContraseña.Text);

            if (!ValidarContrasenaActual(currentUser.Trim(), contrasenaActual))
            {
                MessageBox.Show("La contraseña actual no es correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarSeguridadContrasena(nuevaContrasena))
            {
                MessageBox.Show("La nueva contraseña no cumple con los criterios de seguridad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("Las nuevas contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nivelSeguridad = CalcularSeguridadContrasena(contraseñaNueva.Text);
            if (nivelSeguridad == "Bajo")
            {
                MessageBox.Show("La contraseña tiene un nivel de seguridad bajo, elija una más segura.", "Seguridad Baja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ActualizarContrasena(currentUser.Trim(), nuevaContrasena))
            {
                MessageBox.Show("La contraseña ha sido actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();  
            }
            else
            {
                MessageBox.Show("Error al actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarContrasenaActual(string usuario, string contrasenaActual)
        {
            string filePath = @"C:\MEIA\user.txt";
            if (File.Exists(filePath))
            {
                string[] usuarios = File.ReadAllLines(filePath);
                foreach (string linea in usuarios)
                {
                    string[] campos = linea.Split(';');
                    if (campos[0].Trim() == usuario.Trim() && campos[3] == contrasenaActual)
                    {
                        return true;  
                    }
                }
            }
            return false;  
        }


        private bool ValidarSeguridadContrasena(string nuevaContrasena)
        {
            if (nuevaContrasena.Length >= 8)  
            {
                return true;
            }
            return false;
        }

        private bool ActualizarContrasena(string usuario, string nuevaContrasena)
        {
            string filePath = @"C:\MEIA\user.txt";
            if (File.Exists(filePath))
            {
                string[] usuarios = File.ReadAllLines(filePath);
                for (int i = 0; i < usuarios.Length; i++)
                {
                    string[] campos = usuarios[i].Split(';');
                    if (campos[0].Trim() == usuario.Trim())
                    {
                        campos[3] = nuevaContrasena;
                        usuarios[i] = string.Join(";", campos);  
                        File.WriteAllLines(filePath, usuarios);  
                        return true;
                    }
                }
            }
            return false;
        }

        private string CifrarContrasena(string contrasena)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contrasena));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        private string CalcularSeguridadContrasena(string contrasena)
        {
            int puntuacion = 0;

            if (contrasena.Length >= 8)
                puntuacion++;

            if (System.Text.RegularExpressions.Regex.IsMatch(contrasena, @"[A-Z]"))
                puntuacion++;
            if (System.Text.RegularExpressions.Regex.IsMatch(contrasena, @"[a-z]"))
                puntuacion++;

            if (System.Text.RegularExpressions.Regex.IsMatch(contrasena, @"\d"))
                puntuacion++;

            if (System.Text.RegularExpressions.Regex.IsMatch(contrasena, @"[\W_]"))
                puntuacion++;

            if (puntuacion <= 2)
                return "Bajo";
            if (puntuacion == 3)
                return "Medio";
            return "Alto";
        }

        private void contraseñaActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseñaNueva_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmarContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
