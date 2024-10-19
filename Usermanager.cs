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
    public partial class Usermanager : Form
    {
        private string[] usuarios;
        private int indiceUsuarioActual;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.DateTimePicker fechanueva;


        public Usermanager()
        {
            InitializeComponent();
        }

        private void Usermanager_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnDarDeBaja.Enabled = false;

            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ColumnCount = 6;
            dgvUsuarios.Columns[0].Name = "Usuario";
            dgvUsuarios.Columns[1].Name = "Nombre";
            dgvUsuarios.Columns[2].Name = "Apellido";
            dgvUsuarios.Columns[3].Name = "Teléfono";
            dgvUsuarios.Columns[4].Name = "Estatus";
            dgvUsuarios.Columns[5].Name = "Fecha de nacimiento";
        }


        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvUsuarios.SelectedRows[0].Index;

                if (filaSeleccionada >= 0 && filaSeleccionada < dgvUsuarios.Rows.Count && dgvUsuarios.Rows[filaSeleccionada].Cells[0].Value != null)
                {
                    txtNombre.Text = dgvUsuarios.Rows[filaSeleccionada].Cells[1].Value.ToString();
                    txtApellido.Text = dgvUsuarios.Rows[filaSeleccionada].Cells[2].Value.ToString();
                    txtTelefono.Text = dgvUsuarios.Rows[filaSeleccionada].Cells[6].Value.ToString();
                    lblEstatus.Text = dgvUsuarios.Rows[filaSeleccionada].Cells[7].Value.ToString();

                    if (dgvUsuarios.Rows[filaSeleccionada].Cells[5].Value != null)
                    {
                        DateTime fechaSeleccionada;

                        if (DateTime.TryParse(dgvUsuarios.Rows[filaSeleccionada].Cells[5].Value.ToString(), out fechaSeleccionada))
                        {
                            fechanueva.Value = fechaSeleccionada;
                        }
                        else
                        {
                            MessageBox.Show("El valor de la fecha no es válido.");
                        }
                        fechanueva.Text = fechaSeleccionada.ToString("dd/MM/yyyy");

                    }
                    else
                    {
                        MessageBox.Show("La celda de la fecha está vacía.");
                    }



                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = txtBuscarUsuario.Text.Trim();
            int numeroUsuario = -1;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                MessageBox.Show("Por favor ingrese el nombre de un usuario para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    if (campos.Length >= 8 && campos[0].Trim() == usuarioBuscado)
                    {
                        string estatus = campos[7] == "1" ? "Activo" : "Inactivo";
                        dgvUsuarios.Rows.Add(campos[0].Trim(), campos[1].Trim(), campos[2].Trim(), campos[6], estatus, campos[5]);
                        usuarioEncontrado = true;
                        indiceUsuarioActual = numeroUsuario;
                    }
                }

                if (!usuarioEncontrado)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnModificar.Enabled = false;
                    btnDarDeBaja.Enabled = false;
                }
                else
                {
                    btnModificar.Enabled = true;
                    btnDarDeBaja.Enabled = true;


                }
            }
            else
            {
                MessageBox.Show("Archivo de usuarios no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarAdmin modificarAdmin = new modificarAdmin(usuarios, indiceUsuarioActual);
            modificarAdmin.Show();
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            String usuarioActual = usuarios[indiceUsuarioActual];
            String[] camposUsuario = usuarioActual.Split(';');
            if (camposUsuario[4] == "1")
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

                    if (campos.Length >= 8 && campos[0].Trim() == camposUsuario[0].Trim())
                    {
                        campos[7] = "0";

                        usuarios[i] = string.Join(";", campos);

                        File.WriteAllLines(filePath, usuarios);

                        usuarioEncontrado = true;
                        MessageBox.Show($"Has dado de baja a {camposUsuario[0].Trim()}.", "Baja de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
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

        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
