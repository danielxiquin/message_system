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
    public partial class modificarListaUsuario : Form
    {
        private string[] indiceData;
        private string[] bloqueData;
        private string[] lista;
        private int indiceListas;
        public modificarListaUsuario(string[] indiceData, string[] bloqueData, string[] lista, int indiceListas)
        {
            InitializeComponent();
            this.indiceData = indiceData;
            this.bloqueData = bloqueData;
            this.lista = lista;
            this.indiceListas = indiceListas;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void modificarListaUsuario_Load(object sender, EventArgs e)
        {
            txtRegistro.Text = indiceData[0].Trim();
            txtPosicion.Text = indiceData[1].Trim();
            txtListaIndice.Text = indiceData[2].Trim();
            txtUsuarioIndice.Text = indiceData[3].Trim();
            txtAsociadoIndice.Text = indiceData[4].Trim();

            DateTime fechaCreacion;
            if (DateTime.TryParse(indiceData[5], out fechaCreacion))
            {
                FechaIndice.Value = fechaCreacion;
            }
            else
            {
                MessageBox.Show("El valor de la fecha no es válido en el índice.");
                FechaIndice.Value = DateTime.Now;
            }


            txtRegistro.ReadOnly = true;
            txtPosicion.ReadOnly = true;
            txtListaIndice.ReadOnly = true;
            txtUsuarioIndice.ReadOnly = true;
            txtAsociadoIndice.ReadOnly = true;
            FechaIndice.Enabled = false;

            txtListaBloque.Text = bloqueData[0].Trim();
            txtUsuarioBloque.Text = bloqueData[1].Trim();
            txtAsociadoBloque.Text = bloqueData[2].Trim();
            txtDescripcion.Text = bloqueData[3].Trim();

            if (DateTime.TryParse(bloqueData[4], out fechaCreacion))
            {
                FechaBloque.Value = fechaCreacion;
            }
            else
            {
                MessageBox.Show("El valor de la fecha no es válido en el bloque.");
                FechaBloque.Value = DateTime.Now;
            }


            txtListaBloque.ReadOnly = true;
            txtUsuarioBloque.ReadOnly = true;
            txtAsociadoBloque.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            FechaBloque.Enabled = false;
        }


        private void txtRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPosicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtListaIndice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioIndice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAsociadoIndice_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaIndice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEstatusIndice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtListaBloque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioBloque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAsociadoBloque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaBloque_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEstatusBloque_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios aceptados", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void btnReactivar1_Click(object sender, EventArgs e)
        {
            string pathIndice = @"C:\MEIA\lista_usuario_indice.txt";
            string usuarioActual = "";
            string nombreLista = "";

            if (File.Exists(pathIndice))
            {
                string[] lineasIndice = File.ReadAllLines(pathIndice);
                for (int i = 0; i < lineasIndice.Length; i++)
                {
                    string[] campos = lineasIndice[i].Split(';');
                    if (campos.Length >= 7 &&
                        campos[0].Trim() == indiceData[0].Trim() &&
                        campos[1].Trim() == indiceData[1].Trim() &&
                        campos[2].Trim() == indiceData[2].Trim() &&
                        campos[3].Trim() == indiceData[3].Trim())
                    {
                        usuarioActual = campos[4];
                        nombreLista = campos[2];
                        campos[6] = "1";
                        lineasIndice[i] = string.Join(";", campos);
                        File.WriteAllLines(pathIndice, lineasIndice);
                        MessageBox.Show("Estatus del índice reactivado.", "Reactivación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            ActualizarLista(true);

        }

        private void ActualizarLista(bool incrementar)
        {
            string path = @"C:\MEIA\lista.txt";
            string[] Lista = lista[indiceListas].Split(";");


            if (!File.Exists(path))
            {
                MessageBox.Show("Archivo de listas no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> listaContenido = new List<string>();
            bool listaActualizada = false;

            using (StreamReader sr = new StreamReader(path))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    listaContenido.Add(linea);
                }
            }

            for (int i = 0; i < listaContenido.Count; i++) // Empezamos en 1 para omitir encabezados si existen
            {
                string[] camposLista = listaContenido[i].Split(';');

                if (camposLista.Length >= 5 &&
                    camposLista[0].Trim() == Lista[0].Trim() &&
                    camposLista[1].Trim() == Lista[1].Trim())
                {
                    int numeroUsuarios;
                    if (int.TryParse(camposLista[3].Trim(), out numeroUsuarios))
                    {
                        numeroUsuarios = incrementar ? numeroUsuarios + 1 : numeroUsuarios - 1;
                        camposLista[3] = numeroUsuarios.ToString();
                        listaContenido[i] = string.Join(";", camposLista);
                        listaActualizada = true;
                    }
                    break;
                }
            }

            if (listaActualizada)
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    foreach (string linea in listaContenido)
                    {
                        sw.WriteLine(linea);
                    }
                }
                MessageBox.Show("Lista actualizada correctamente.", "Actualización de Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La lista no fue encontrada o no pudo ser actualizada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnReactivar2_Click(object sender, EventArgs e)
        {
            string pathDatos = @"C:\MEIA\lista_usuario_bloque.txt";

            if (File.Exists(pathDatos))
            {
                string[] lineasDatos = File.ReadAllLines(pathDatos);
                for (int i = 0; i < lineasDatos.Length; i++)
                {
                    string[] campos = lineasDatos[i].Split(';');
                    if (campos.Length >= 6 &&
                        campos[0].Trim() == bloqueData[0].Trim() &&
                        campos[1].Trim() == bloqueData[1].Trim() &&
                        campos[2].Trim() == bloqueData[2].Trim())
                    {
                        campos[5] = "1";
                        lineasDatos[i] = string.Join(";", campos);
                        File.WriteAllLines(pathDatos, lineasDatos);
                        MessageBox.Show("Estatus del bloque reactivado.", "Reactivación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
        }

        private void btnReactivarIndice_Click(object sender, EventArgs e)
        {

        }
    }
}
