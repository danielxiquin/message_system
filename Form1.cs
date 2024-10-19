namespace message_system
{
    public partial class Form1 : Form
    {
        public string UsuarioActual { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string RolUsuario { get; set; }
        public string TelefonoUsuario { get; set; }
        public string EstatusUsuario { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void Mantenimiento_Click(object sender, EventArgs e)
        {
            Usermanager usermanager = new Usermanager();
            usermanager.Show(this);
        }


        private void cambiarContraseña_Click(object sender, EventArgs e)
        {
            Changepass changepass = new Changepass(UsuarioActual.Trim());
            changepass.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cambiotelefono cambiotelefono = new cambiotelefono(UsuarioActual.Trim());
            cambiotelefono.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cambiarFecha cambio = new cambiarFecha(UsuarioActual.Trim());
            cambio.Show();
        }

        private void DarsedeBaja_Click(object sender, EventArgs e)
        {
            if (RolUsuario == "Administrador")
            {
                MessageBox.Show("No puedes darte de baja como administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    if (campos.Length >= 8 && campos[0].Trim() == UsuarioActual)
                    {
                        campos[7] = "0";

                        usuarios[i] = string.Join(";", campos);

                        File.WriteAllLines(filePath, usuarios);

                        usuarioEncontrado = true;
                        MessageBox.Show("Te has dado de baja exitosamente.", "Baja de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        Login loginForm = new Login();
                        loginForm.Show();
                        break;
                    }
                }

                if (!usuarioEncontrado)
                {
                    MessageBox.Show("Error: El usuario actual no se encontró en el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo de usuarios no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ActualizarDescripcionUsuario("registros_inactivos");
        }


        private void Respaldar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Seleccione la carpeta donde desea guardar el respaldo";

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string destino = folderDialog.SelectedPath;
                        string origen = @"C:\MEIA";

                        string respaldoPath = Path.Combine(destino, "MEIA_Backup_");

                        DirectoryCopy(origen, respaldoPath, true);

                        // Actualizar la bitácora
                        string bitacoraPath = @"C:\MEIA\bitacora_backup.txt";
                        if (!File.Exists(bitacoraPath))
                        {
                            File.WriteAllText(bitacoraPath, "");
                        }

                        string[] bitacora = File.ReadAllLines(bitacoraPath);
                        int numeroRegistros = bitacora.Length + 1;

                        using (StreamWriter sw = new StreamWriter(bitacoraPath, true))
                        {
                            string lineaBitacora = $"{respaldoPath.PadRight(20)};{UsuarioActual.PadRight(20)};{DateTime.Now.ToString("dd/MM/yyyy")}";
                            sw.WriteLine(lineaBitacora);
                        }

                        string descBitacoraPath = @"C:\MEIA\desc_bitacora_backup.txt";
                        if (!File.Exists(descBitacoraPath))
                        {
                            using (StreamWriter sw = new StreamWriter(descBitacoraPath))
                            {
                                sw.WriteLine("nombre_simbolico: MEIA_Backup");
                                sw.WriteLine("fecha_creacion: " + DateTime.Now.ToString("dd/MM/yyyy"));
                                sw.WriteLine("usuario_creacion: " + UsuarioActual);
                                sw.WriteLine("fecha_modificacion: " + DateTime.Now.ToString("dd/MM/yyyy"));
                                sw.WriteLine("usuario_modificacion: " + UsuarioActual);
                                sw.WriteLine($"#_registros: {numeroRegistros}");
                            }
                        }
                        else
                        {
                            string[] descBitacora = File.ReadAllLines(descBitacoraPath);

                            for (int i = 0; i < descBitacora.Length; i++)
                            {
                                if (descBitacora[i].StartsWith("#_registros"))
                                {
                                    descBitacora[i] = $"#_registros: {numeroRegistros}";
                                }
                                else if (descBitacora[i].StartsWith("fecha_modificacion"))
                                {
                                    descBitacora[i] = $"fecha_modificacion: {DateTime.Now.ToString("dd/MM/yyyy")}";
                                }
                                else if (descBitacora[i].StartsWith("usuario_modificacion"))
                                {
                                    descBitacora[i] = $"usuario_modificacion: {UsuarioActual}";
                                }
                            }

                            File.WriteAllLines(descBitacoraPath, descBitacora);
                        }

                        MessageBox.Show("Respaldo completo creado exitosamente", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar el respaldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("No se encuentra el directorio de origen: " + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido {NombreUsuario} {ApellidoUsuario}";
            lblRol.Text = $"Rol: {RolUsuario}";
            lblTelefono.Text = $"Teléfono: {TelefonoUsuario}";
            lblEstatus.Text = $"Estatus: {EstatusUsuario}";

            if (RolUsuario == "Usuario")
            {
                Mantenimiento.Enabled = false;
                Respaldar.Enabled = false;
            }
            else if (RolUsuario == "Administrador")
            {
                Mantenimiento.Enabled = true;
                Respaldar.Enabled = true;
            }
        }



        private void ActualizarDescripcionUsuario(string accion)
        {
            string descFilePath = @"C:\MEIA\desc_user.txt";
            string userFilePath = @"C:\MEIA\user.txt";

            int totalRegistros = 0;
            int registrosActivos = 0;
            int registrosInactivos = 0;

            if (File.Exists(userFilePath))
            {
                string[] usuarios = File.ReadAllLines(userFilePath);
                totalRegistros = usuarios.Length;

                foreach (string usuario in usuarios)
                {
                    string[] campos = usuario.Split(';');
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

            List<string> descLines = new List<string>();
            if (File.Exists(descFilePath))
            {
                descLines = File.ReadAllLines(descFilePath).ToList();
            }
            else
            {
                descLines.Add("nombre_simbolico: Usuarios del sistema");
                descLines.Add($"fecha_creacion: {DateTime.Now.ToString("dd/MM/yyyy")}");
                descLines.Add($"usuario_creacion: {UsuarioActual}");
            }

            for (int i = 0; i < descLines.Count; i++)
            {
                if (descLines[i].StartsWith("fecha_modificacion:"))
                {
                    descLines[i] = $"fecha_modificacion: {DateTime.Now.ToString("dd/MM/yyyy")}";
                }
                else if (descLines[i].StartsWith("usuario_modificacion:"))
                {
                    descLines[i] = $"usuario_modificacion: {UsuarioActual}";
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
                }
                else if (descLines[i].StartsWith("max_reorganizacion:"))
                {
                    descLines[i] = "max_reorganizacion: 100";
                }
            }

            File.WriteAllLines(descFilePath, descLines);
        }


        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblEstatus_Click(object sender, EventArgs e)
        {

        }

       
    }
}