using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace message_system
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;  
            string contrasena = txtContrasena.Text;  

            string contrasenaCifrada = CifrarContrasena(contrasena);
            if (ValidarCredenciales(usuario, contrasenaCifrada, out string nombre, out string apellido, out string rol, out string telefono, out string estatus))
            {
                Form1 form = new Form1();
                form.UsuarioActual = usuario;
                form.NombreUsuario = nombre;
                form.ApellidoUsuario = apellido;
                form.RolUsuario = rol;
                form.TelefonoUsuario = telefono;
                form.EstatusUsuario = estatus;
                form.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCredenciales(string usuario, string contrasenaCifrada, out string nombre, out string apellido, out string rol, out string telefono, out string estatus)
        {
            nombre = string.Empty;
            apellido = string.Empty;
            rol = string.Empty;
            telefono = string.Empty;
            estatus = string.Empty;

            string filePath = @"C:\MEIA\user.txt";  
            if (File.Exists(filePath))
            {
                string[] usuarios = File.ReadAllLines(filePath);
                foreach (string linea in usuarios)
                {
                    string[] campos = linea.Split(';');

                    if (campos.Length >= 8)
                    {
                        if (campos[0].Trim() == usuario && campos[3] == contrasenaCifrada)
                        {
                            if (campos[7] == "1")
                            {
                                nombre = campos[1].Trim();  
                                apellido = campos[2].Trim();  
                                rol = (campos[4] == "1") ? "Administrador" : "Usuario";  
                                telefono = campos[6];  
                                estatus = campos[7];  
                                return true; 
                            }
                            else
                            {
                                MessageBox.Show("Tu cuenta está inactiva. No puedes iniciar sesión.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;  
                            }
                        }
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


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {

            Signup registrarUser = new Signup();
            registrarUser.Show();

            this.Hide();

        }


    }
}
