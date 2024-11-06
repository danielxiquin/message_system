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
    public partial class modificarLista : Form
    {
        private string[] Listas;
        private int indiceLista;
        public modificarLista(string[] Listas, int indiceLista)
        {
            InitializeComponent();
            this.Listas = Listas;
            this.indiceLista = indiceLista;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String listaActual = Listas[indiceLista];
            String[] camposListas = listaActual.Split(';');
            try
            {

                string filePath = @"C:\MEIA\lista.txt";

                if (File.Exists(filePath))
                {
                    string[] listas = File.ReadAllLines(filePath);
                    bool usuarioEncontrado = false;

                    for (int i = 0; i < listas.Length; i++)
                    {
                        string[] campos = listas[i].Split(';');

                        if (campos[0].Trim() == camposListas[0].Trim())
                        {

                            if (camposListas[0].Trim() != textBox1.Text)
                            {
                                campos[0] = textBox1.Text.PadRight(30);
                            }

                            if (camposListas[2] != txtDescripcion.Text)
                            {
                                campos[2] = txtDescripcion.Text.PadRight(40);
                            }


                            listas[i] = string.Join(";", campos);

                            File.WriteAllLines(filePath, listas);

                            usuarioEncontrado = true;
                            MessageBox.Show("Datos cambiados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }

                    if (!usuarioEncontrado)
                    {
                        MessageBox.Show("Lista no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de listas no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void modificarLista_Load(object sender, EventArgs e)
        {
            string[] campos = Listas[indiceLista].Split(';');
            textBox1.Text = campos[0].Trim();
            txtDescripcion.Text = campos[2].Trim();

        }
    }
}
