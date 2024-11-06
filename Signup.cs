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
using static System.Windows.Forms.DataFormats;

namespace message_system
{
    public partial class Signup : Form
    {
        public string usuarioActual;
        public Signup()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearUsuario_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarContrasena.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nivelSeguridad = CalcularSeguridadContrasena(txtContrasena.Text);
            if (nivelSeguridad == "Bajo")
            {
                MessageBox.Show("La contraseña tiene un nivel de seguridad bajo, elija una más segura.", "Seguridad Baja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GuardarUsuarioEnArchivo(nivelSeguridad);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

            dateTimePicker1.MaxDate = DateTime.Today;

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

        private void GuardarUsuarioEnArchivo(string nivelSeguridad)
        {
            string filePath = @"C:\MEIA\user.txt";  
            string rol = "0"; 

            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                rol = "1"; 
            }

            string contrasenaCifrada = CifrarContrasena(txtContrasena.Text);

            string newUser = $"{txtUsuario.Text.PadRight(20)};{txtNombre.Text.PadRight(30)};{txtApellido.Text.PadRight(30)};{contrasenaCifrada};{rol};{dateTimePicker1.Value.ToString("dd/MM/yyyy")};{txtTelefono.Text};1";

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(newUser);
            }

            GuardarCriteriosSeguridad(txtUsuario.Text.PadRight(20), nivelSeguridad);

            MessageBox.Show("Usuario registrado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarDescripcionUsuario();
            
            this.Close();
        }


        public void ActualizarDescripcionUsuario()
        {
            string descFilePath = @"C:\MEIA\desc_user.txt";
            string userFilePath = @"C:\MEIA\user.txt";

            int totalRegistros = 0;
            int registrosActivos = 0;
            int registrosInactivos = 0;
            int maxReorganizacion = 10;
            string usuarioActual = " ";


            if (File.Exists(userFilePath))
            {
                string[] usuarios = File.ReadAllLines(userFilePath);
                totalRegistros = usuarios.Length;

                foreach (string usuario in usuarios)
                {
                    string[] campos = usuario.Split(';');
                    if (campos.Length >= 8)
                    {
                        if (campos[7] == "1")
                        {
                            registrosActivos++;
                        }
                        else
                        {
                            registrosInactivos++;
                        }
                    }
                }


                string[] campos1 = usuarios[0].Split(';');
                usuarioActual = campos1[1];
            }

            List<string> descLines = new List<string>();

            if (File.Exists(descFilePath))
            {
                descLines = File.ReadAllLines(descFilePath).ToList();
            }
            else
            {
                descLines.Add("nombre_simbolico: Usuarios del sistema");
                descLines.Add($"fecha_creacion: {DateTime.Now.ToString("dd/MM/yyyy")}");
                descLines.Add($"usuario_creacion: {usuarioActual} ");
            }

            bool reorganizar = false;
            for (int i = 0; i < descLines.Count; i++)
            {
                if (descLines[i].StartsWith("fecha_modificacion:"))
                {
                    descLines[i] = $"fecha_modificacion: {DateTime.Now.ToString("dd/MM/yyyy")}";
                }
                else if (descLines[i].StartsWith("usuario_modificacion:"))
                {
                    descLines[i] = $"usuario_modificacion: ";
                }
                else if (descLines[i].StartsWith("#_registros:"))
                {
                    descLines[i] = $"#_registros: {totalRegistros}";
                }
                else if (descLines[i].StartsWith("registros_activos:"))
                {
                    descLines[i] = $"registros_activos: {registrosActivos}";
                }
                else if (descLines[i].StartsWith("registros_inactivos:"))
                {
                    descLines[i] = $"registros_inactivos: {registrosInactivos}";
                    if (registrosInactivos >= maxReorganizacion)
                    {
                        reorganizar = true;
                    }
                }
                else if (descLines[i].StartsWith("max_reorganizacion:"))
                {
                    descLines[i] = $"max_reorganizacion: {maxReorganizacion}";
                }
            }

            if (!descLines.Any(line => line.StartsWith("fecha_modificacion:")))
            {
                descLines.Add($"fecha_modificacion: {DateTime.Now.ToString("dd/MM/yyyy")}");
                descLines.Add($"usuario_modificacion: ");
                descLines.Add($"#_registros: {totalRegistros}");
                descLines.Add($"registros_activos: {registrosActivos}");
                descLines.Add($"registros_inactivos: {registrosInactivos}");
                descLines.Add($"max_reorganizacion: {maxReorganizacion}");
            }

            File.WriteAllLines(descFilePath, descLines);

            if (reorganizar)
            {
                ReorganizarArchivoUsuarios();
            }
        }
        private void ReorganizarArchivoUsuarios()
        {
            string userFilePath = @"C:\MEIA\user.txt";
            List<string> usuariosActivos = new List<string>();

            if (File.Exists(userFilePath))
            {
                string[] usuarios = File.ReadAllLines(userFilePath);

                foreach (string usuario in usuarios)
                {
                    string[] campos = usuario.Split(';');
                    if (campos.Length >= 8 && campos[7] == "1")
                    {
                        usuariosActivos.Add(usuario);
                    }
                }

                File.WriteAllLines(userFilePath, usuariosActivos);
            }

            MessageBox.Show("El archivo de usuarios ha sido reorganizado eliminando usuarios inactivos.", "Reorganización completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarDescripcionUsuario();

        }

        private void GuardarCriteriosSeguridad(string usuario, string nivelSeguridad)
        {
            string filePath = @"C:\MEIA\seguridad_contrasenas.txt";  
            string criterios = $"Usuario: {usuario}, Nivel de Seguridad: {nivelSeguridad}, Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}";

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(criterios);  
            }
        }
    }
}
