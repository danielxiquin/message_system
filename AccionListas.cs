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
    public partial class AccionListas : Form
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
        public AccionListas(string usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void AccionListas_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnIngresarLista.Enabled = false;
            dgvLista.AllowUserToAddRows = false;
            dgvLista.ColumnCount = 6;
            dgvLista.Columns[0].Name = "Nombre lista";
            dgvLista.Columns[1].Name = "Usuario";
            dgvLista.Columns[2].Name = "Descripción";
            dgvLista.Columns[3].Name = "Numero de usuarios";
            dgvLista.Columns[4].Name = "Fecha de creacioón";
            dgvLista.Columns[5].Name = "estatus";
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
                    MessageBox.Show("Lista no encontrado.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnIngresarLista.Enabled = false;
                }
                else
                {
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnIngresarLista.Enabled=true;
                }
            }
            else
            {
                MessageBox.Show("Archivo de listas no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnIngresarLista_Click(object sender, EventArgs e)
        {
            string pathIndice = @"C:\MEIA\lista_usuario_indice.txt";
            string pathDatos = @"C:\MEIA\lista_usuario_bloque.txt";

            if (!File.Exists(pathIndice))
            {
                using (StreamWriter sw = new StreamWriter(pathIndice))
                {
                    sw.WriteLine("// Índice");
                }
            }

            if (!File.Exists(pathDatos))
            {
                using (StreamWriter sw = new StreamWriter(pathDatos))
                {
                    sw.WriteLine("// Datos");
                }
            }

            string[] Lista = Listas[indiceListaActual].Split(";");

            string newList = $"{Lista[0].PadRight(30)};{Lista[1].PadRight(20)};{usuarioActual.PadRight(20)};{Lista[2].PadRight(40)};{DateTime.Now.ToString("dd/MM/yyyy")};1";

            List<string> indice = new List<string>();
            List<string> datos = new List<string>();

            using (StreamReader sr = new StreamReader(pathIndice))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "// Índice")
                    {
                        indice.Add(line);
                    }
                }
            }

            using (StreamReader sr = new StreamReader(pathDatos))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "// Datos")
                    {
                        datos.Add(line);
                    }
                }
            }

            int nuevaPosicion = datos.Count + 1;

            bool insertar = false;
            for (int i = 0; i < datos.Count; i++)
            {
                string[] campos = datos[i].Split(";");
                string nombreLista = campos[0].Trim();
                string listaExistente = campos[1].Trim();
                string asociadoActual = campos[2].Trim();

                if (string.Compare(Lista[0], nombreLista) < 0 ||
                    (string.Compare(Lista[0], nombreLista) == 0 && string.Compare(Lista[1], listaExistente) < 0) ||
                    (string.Compare(Lista[0], nombreLista) == 0 && string.Compare(Lista[1], listaExistente) == 0 && string.Compare(usuarioActual, asociadoActual) < 0))
                {
                    datos.Insert(i, newList);
                    insertar = true;
                    break;
                }
            }

            if (!insertar)
            {
                datos.Add(newList);
            }

            int nuevoRegistro = indice.Count + 1;
            string nuevoIndice = $"{nuevoRegistro};{nuevaPosicion};{Lista[0]};{Lista[1]};{usuarioActual.PadRight(20)};{DateTime.Now.ToString("dd/MM/yyyy")};1";
            indice.Add(nuevoIndice);

            using (StreamWriter sw = new StreamWriter(pathIndice, false))
            {
                sw.WriteLine("// Índice");
                foreach (string item in indice)
                {
                    sw.WriteLine(item);
                }
            }

            using (StreamWriter sw = new StreamWriter(pathDatos, false))
            {
                sw.WriteLine("// Datos");
                foreach (string contact in datos)
                {
                    sw.WriteLine(contact);
                }
            }

            MessageBox.Show("Contacto registrado correctamente", "Contacto Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarLista(true);
        }


        private void ActualizarLista(bool incrementar)
        {
            string path = @"C:\MEIA\lista.txt";
            string[] Lista = Listas[indiceListaActual].Split(";");


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





        private void btnModificar_Click(object sender, EventArgs e)
        {
            string pathIndice = @"C:\MEIA\lista_usuario_indice.txt";
            string pathDatos = @"C:\MEIA\lista_usuario_bloque.txt";

            if (!File.Exists(pathIndice) || !File.Exists(pathDatos))
            {
                MessageBox.Show("Los archivos de índice o datos no existen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] listaBuscada = Listas[indiceListaActual].Split(";");

            string[] indiceData = null;
            string[] bloqueData = null;
            using (StreamReader sr = new StreamReader(pathIndice))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("//")) continue;  

                    string[] campos = line.Split(';');

                    if (campos.Length >= 7 &&
                        campos[2].Trim() == listaBuscada[0].Trim() &&  
                        campos[3].Trim() == listaBuscada[1].Trim() &&  
                        campos[4].Trim() == usuarioActual.Trim())     
                    {
                        indiceData = campos;
                        break;
                    }
                }
            }

            using (StreamReader sr = new StreamReader(pathDatos))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("//")) continue;  

                    string[] campos = line.Split(';');

                    if (campos.Length >= 6 &&
                        campos[0].Trim() == listaBuscada[0].Trim() &&  
                        campos[1].Trim() == listaBuscada[1].Trim() &&  
                        campos[2].Trim() == usuarioActual.Trim())      
                    {
                        bloqueData = campos;
                        break;
                    }
                }
            }

            if (indiceData != null && bloqueData != null)
            {
                modificarListaUsuario modificarLista = new modificarListaUsuario(indiceData, bloqueData, Listas,indiceListaActual);
                modificarLista.Show();
            }
            else
            {
                MessageBox.Show("No se encontró la lista en los archivos.", "Error de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string pathIndice = @"C:\MEIA\lista_usuario_indice.txt";
            string pathDatos = @"C:\MEIA\lista_usuario_bloque.txt";

            if (!File.Exists(pathIndice) || !File.Exists(pathDatos))
            {
                MessageBox.Show("Archivos de lista de difusión no encontrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> indice = new List<string>(File.ReadAllLines(pathIndice));
            List<string> bloqueDatos = new List<string>(File.ReadAllLines(pathDatos));
            bool encontrado = false;

            string[] listaBuscada = Listas[indiceListaActual].Split(";");

            for (int i = 1; i < indice.Count; i++) 
            {
                string[] camposIndice = indice[i].Split(';');

                if (camposIndice.Length >= 7 &&
                    camposIndice[2].Trim() == listaBuscada[0].Trim() &&   
                    camposIndice[3].Trim() == listaBuscada[1].Trim() &&   
                    camposIndice[4].Trim() == usuarioActual.Trim())       
                {
                    camposIndice[6] = "0"; 
                    indice[i] = string.Join(";", camposIndice);
                    encontrado = true;
                    break;
                }
            }

            for (int j = 1; j < bloqueDatos.Count; j++) 
            {
                string[] camposBloque = bloqueDatos[j].Split(';');

                if (camposBloque.Length >= 6 &&
                    camposBloque[0].Trim() == listaBuscada[0].Trim() &&  
                    camposBloque[1].Trim() == listaBuscada[1].Trim() &&   
                    camposBloque[2].Trim() == usuarioActual.Trim())       
                {
                    camposBloque[5] = "0"; 
                    bloqueDatos[j] = string.Join(";", camposBloque);
                    break;
                }
            }

            if (encontrado)
            {
                using (StreamWriter sw = new StreamWriter(pathIndice, false))
                {
                    sw.WriteLine("// Índice");
                    foreach (string item in indice)
                    {
                        if (!item.StartsWith("// Índice"))
                        {
                            sw.WriteLine(item);
                        }
                    }
                }

                using (StreamWriter sw = new StreamWriter(pathDatos, false))
                {
                    sw.WriteLine("// Datos");
                    foreach (string item in bloqueDatos)
                    {
                        if (!item.StartsWith("// Datos"))
                        {
                            sw.WriteLine(item);
                        }
                    }
                }

                MessageBox.Show("Te has eliminado de la lista de difusión.", "Baja de lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarLista(false);
            }
            else
            {
                MessageBox.Show("No eres parte de esta lista.", "Baja de lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MantenimientoListaUsuario mantenimientoListaUsuario = new MantenimientoListaUsuario(usuarioActual);
            mantenimientoListaUsuario.Show();
            this.Close();
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
