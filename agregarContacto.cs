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
    public partial class agregarContacto : Form
    {

        private string[] usuarios;
        private int indiceUsuarioActual;
        private string usuarioActual;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.DateTimePicker fechanueva;

        public agregarContacto(string usuarioActual)
        {
            this.usuarioActual = usuarioActual.Trim();
            InitializeComponent();
        }

        private void agregarContacto_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminacion.Enabled = false;
            btnAgregar.Enabled = false;
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.ColumnCount = 6;
            dgvUsuario.Columns[0].Name = "Usuario";
            dgvUsuario.Columns[1].Name = "Nombre";
            dgvUsuario.Columns[2].Name = "Apellido";
            dgvUsuario.Columns[3].Name = "Teléfono";
            dgvUsuario.Columns[4].Name = "Estatus";
            dgvUsuario.Columns[5].Name = "Fecha de nacimiento";
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvUsuario.SelectedRows[0].Index;

                if (filaSeleccionada >=0 && filaSeleccionada < dgvUsuario.Rows.Count && dgvUsuario.Rows[filaSeleccionada].Cells[0].Value != null)
                {
                    txtNombre.Text = dgvUsuario.Rows[filaSeleccionada].Cells[1].Value.ToString();
                    txtApellido.Text = dgvUsuario.Rows[filaSeleccionada].Cells[2].Value.ToString();
                    txtTelefono.Text = dgvUsuario.Rows[filaSeleccionada].Cells[3].Value.ToString();
                    lblEstatus.Text = dgvUsuario.Rows[filaSeleccionada].Cells[4].Value.ToString();

                    if (dgvUsuario.Rows[filaSeleccionada].Cells[5].Value != null)
                    {
                        DateTime fechaseleccionada;

                        if (DateTime.TryParse(dgvUsuario.Rows[filaSeleccionada].Cells[5].Value.ToString(), out fechaseleccionada))
                        {
                            fechanueva.Value = fechaseleccionada;
                        }
                        else
                        {
                            MessageBox.Show("El valor de la fecha no es valida");

                        }
                        fechanueva.Text = fechaseleccionada.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        MessageBox.Show("La celda de la fecha esta vacia");
                    }
                }

          

            }



        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = txtBuscarUsuario.Text.Trim();
            int numeroUsuario = -1;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                MessageBox.Show("Por favor ingrese el usuario, nombre o apellido para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = @"C:\MEIA\user.txt";


            if (File.Exists(filePath))
            {
                usuarios = File.ReadAllLines(filePath);
                bool usuarioEncontrado = false;

                foreach (string linea in usuarios)
                {
                    numeroUsuario++;
                    string[] campos = linea.Split(';');

                    if (campos.Length >= 8 && campos[0].Trim() == usuarioBuscado || campos.Length >= 8 && campos[1].Trim() == usuarioBuscado || campos.Length >= 8 && campos[2].Trim() == usuarioBuscado)
                    {
                        string estatus = campos[7] == "1" ? "Activo" : "Inactivo";
                        dgvUsuario.Rows.Add(campos[0].Trim(), campos[1].Trim(), campos[2].Trim(), campos[6], estatus, campos[5]);
                        usuarioEncontrado = true;
                        indiceUsuarioActual = numeroUsuario;
                    }
                }

                if (!usuarioEncontrado)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminacion.Enabled = false;

                }
                else
                {
                    btnModificar.Enabled = true;
                    btnEliminacion.Enabled = true;
                    btnAgregar.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Archivo de usuarios no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {

            string path = @"C:\MEIA\contactos.txt";

            if (File.Exists(path))
            {
                string[] contactos = File.ReadAllLines(path);
                bool contactoEncontrado = false;

                for (int i = 0; i < contactos.Length; i++)
                {
                    string[] campos = contactos[i].Trim().Split(';');

                    string[] contactoBuscado = usuarios[indiceUsuarioActual].Split(";");

                    if (campos[0].Trim() == usuarioActual.Trim() && campos[1].Trim() == contactoBuscado[0].Trim())
                    {
                        contactoEncontrado = true;
                        modificarContacto modificarContacto = new modificarContacto(campos);

                        if (campos[4].Trim() == "0")
                        {
                            DialogResult result = MessageBox.Show("¿Este usuario esta desabilitado de tus contactos quieres continuar y rehabilitarlo?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.OK)
                            {
                                modificarContacto.Show();
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                MessageBox.Show("Operación cancelada.");
                            }
                        }

                        modificarContacto.Show();

                    }
                }


                if (!contactoEncontrado)
                {
                    MessageBox.Show("Este usuario no es parte de tus contactos.", "Baja de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            
        }    

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string path = @"C:\MEIA\contactos.txt";

            if(!File.Exists(path)) {
                File.Create(path).Close(); 
            }
            string[] contacto = usuarios[indiceUsuarioActual].Split(";");

            string newContact = $"{usuarioActual.PadRight(20)};{contacto[0].PadRight(20)};{DateTime.Now.ToString("dd/MM/yyyy")};{usuarioActual.PadRight(20)};1";

            
            List<string> contactos = new List<string>();

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                { 
                    contactos.Add(line);
                }
            }

            bool insertar = false;
            for(int i = 0; i < contactos.Count; i++)
            {
                string[] campos = contactos[i].Split(";");
                string usuario = campos[0].Trim();
                string contactoexistente = campos[1].Trim();

                if(string.Compare(usuarioActual, usuario) < 0 || string.Compare(usuarioActual, usuario) == 0 && string.Compare(contacto[0], contactoexistente) <0)
                {
                    contactos.Insert(i, newContact);
                    insertar = true;
                    break;
                }
            }

            if(!insertar)
            {
                contactos.Add(newContact);

            }

            using (StreamWriter sw = new StreamWriter(path, false)) {

                foreach(string contact in contactos)
                {
                    sw.WriteLine(contact);

                }
            }

            actualizarContactos(usuarioActual, DateTime.Now.ToString("dd/MM/yyyy"));

            MessageBox.Show("Contacto registrado correctamente", "Contacto Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void actualizarContactos(string usuarioTransaccion, string fechaNueva)
        {
            string path = @"C:\MEIA\contactos.txt";
            

            if(File.Exists(path))
            {
                string[] contactos = File.ReadAllLines(path);
                for(int i = 0; i < contactos.Length; i++)
                {
                    string[] campos = contactos[i].Split(';');

                    campos[2] = fechaNueva;
                    campos[3] = usuarioTransaccion;

                    contactos[i] = string.Join(";", campos);

                    File.WriteAllLines(path, contactos);
                }
            }
        }

        private void btnEliminacion_Click(object sender, EventArgs e)
        {
            string path = @"C:\MEIA\contactos.txt";

            if (File.Exists(path))
            {
                string[] contactos = File.ReadAllLines(path);
                bool contactoEncontrado = false;

                for(int i = 0; i < contactos.Length; i++)
                {
                    string[] campos = contactos[i].Trim().Split(';');

                    string[] contactoBuscado = usuarios[indiceUsuarioActual].Split(";");

                    if (campos[0].Trim() == usuarioActual.Trim() && campos[1].Trim() == contactoBuscado[0].Trim())
                    {
                        campos[4] = "0";

                        contactos[i] = string.Join(";", campos);

                        File.WriteAllLines(path, contactos);

                        contactoEncontrado = true;  

                        MessageBox.Show("Has eliminado este usuario de tus contactos.", "Baja de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
                if(!contactoEncontrado)
                {
                    MessageBox.Show("Este usuario no es parte de tus contactos.", "Baja de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

      

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}
