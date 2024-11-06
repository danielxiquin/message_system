using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace message_system
{
    public partial class mantenimientoLista : Form
    {
        private string usuarioActual;
        private string[] Listas;
        private int indiceListaActual;
        private System.Windows.Forms.TextBox txtnombreLista;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtdescrípcion;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.DateTimePicker fechaCreacion;
        private System.Windows.Forms.TextBox txtNumeroUsuarios;
        public mantenimientoLista(string usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string listaBuscada = txtBuscarUsuario.Text.Trim();
            int numeroUsuario = -1;

            if (string.IsNullOrWhiteSpace(listaBuscada))
            {
                MessageBox.Show("Por favor ingrese el nombre de la lista a buscar", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = @"C:\MEIA\lista.txt";


            if (File.Exists(filePath))
            {
                Listas = File.ReadAllLines(filePath);
                bool usuarioEncontrado = false;

                foreach (string linea in Listas)
                {
                    numeroUsuario++;
                    string[] campos = linea.Split(';');

                    if (campos.Length >= 6 && campos[0].Trim() == listaBuscada)
                    {
                        string estatus = campos[5] == "1" ? "Activo" : "Inactivo";
                        dgvLista.Rows.Add(campos[0].Trim(), campos[1].Trim(), campos[2].Trim(), campos[3].Trim(), campos[4], estatus);
                        usuarioEncontrado = true;
                        indiceListaActual = numeroUsuario;
                    }
                }

                if (!usuarioEncontrado)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;

                }
                else
                {
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Archivo de usuarios no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarLista modificarLista = new modificarLista(Listas, indiceListaActual);
            modificarLista.Show();  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string path = @"C:\MEIA\lista.txt";

            if (File.Exists(path))
            {
                string[] listas = File.ReadAllLines(path);
                bool contactoEncontrado = false;

                for (int i = 0; i < listas.Length; i++)
                {
                    string[] campos = listas[i].Trim().Split(';');

                    string[] listaBuscada = Listas[indiceListaActual].Split(";");

                    if (campos[0].Trim() == listaBuscada[0].Trim())
                    {
                        campos[5] = "0";

                        listas[i] = string.Join(";", campos);

                        File.WriteAllLines(path, listas);

                        contactoEncontrado = true;

                        MessageBox.Show("Has eliminado este usuario de tus contactos.", "Baja de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (!contactoEncontrado)
                {
                    MessageBox.Show("Este usuario no es parte de tus contactos.", "Baja de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ListaDifusion listaDifusion = new ListaDifusion(usuarioActual);
            listaDifusion.Show();
            this.Close();

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvLista.SelectedRows[0].Index;

                if (filaSeleccionada >= 0 && filaSeleccionada < dgvLista.Rows.Count && dgvLista.Rows[filaSeleccionada].Cells[0].Value != null)
                {
                    txtnombreLista.Text = dgvLista.Rows[filaSeleccionada].Cells[0].Value.ToString();
                    txtUsuario.Text = dgvLista.Rows[filaSeleccionada].Cells[1].Value.ToString();
                    txtdescrípcion.Text = dgvLista.Rows[filaSeleccionada].Cells[2].Value.ToString();
                    txtNumeroUsuarios.Text = dgvLista.Rows[filaSeleccionada].Cells[3].Value.ToString();
                    lblEstatus.Text = dgvLista.Rows[filaSeleccionada].Cells[5].Value.ToString();

                    if (dgvLista.Rows[filaSeleccionada].Cells[4].Value != null)
                    {
                        DateTime fechaSeleccionada;

                        if (DateTime.TryParse(dgvLista.Rows[filaSeleccionada].Cells[5].Value.ToString(), out fechaSeleccionada))
                        {
                            fechaCreacion.Value = fechaSeleccionada;
                        }
                        else
                        {
                            MessageBox.Show("El valor de la fecha no es válido.");
                        }
                        fechaCreacion.Text = fechaSeleccionada.ToString("dd/MM/yyyy");

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

        private void mantenimientoLista_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvLista.AllowUserToAddRows = false;
            dgvLista.ColumnCount = 6;
            dgvLista.Columns[0].Name = "Nombre lista";
            dgvLista.Columns[1].Name = "Usuario";
            dgvLista.Columns[2].Name = "Descripción";
            dgvLista.Columns[3].Name = "Numero de usuarios";
            dgvLista.Columns[4].Name = "Fecha de creacioón";
            dgvLista.Columns[5].Name = "estatus";
        }
    }
}
