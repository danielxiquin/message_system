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
    public partial class crearLista : Form
    {
        private string usuarioActual;
       
        public crearLista(string usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void crearLista_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string path = @"C:\MEIA\lista.txt";

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            string newList = $"{txtNombre.Text.PadRight(30)};{usuarioActual.PadRight(20)};{txtDescripcion.Text.PadRight(40)};{0};{DateTime.Now.ToString("dd/MM/yyyy")};1";


            List<string> listas = new List<string>();

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listas.Add(line);
                }
            }

            bool insertar = false;
            for (int i = 0; i < listas.Count; i++)
            {
                string[] campos = listas[i].Split(";");
                string lista = campos[0].Trim();
                string usuario = campos[1].Trim();

                if(txtNombre.Text.Trim() == lista)
                {
                    MessageBox.Show("No se puede ingresar una lista con el mismo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    insertar = false;
                    return;
                }
                
                if(string.Compare(txtNombre.Text.Trim(), lista) < 0 || string.Compare(txtNombre.Text.Trim(), lista) == 0 && string.Compare(usuarioActual, usuario) < 0)
                {
                    listas.Insert(i, newList);
                    insertar = true;
                    break;
                }
            }

            if (!insertar)
            {
                listas.Add(newList);

            }

            using (StreamWriter sw = new StreamWriter(path, false))
            {

                foreach (string lista in listas)
                {
                    sw.WriteLine(lista);

                }
            }


            MessageBox.Show("Contacto registrado correctamente", "Contacto Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListaDifusion listaDifusion = new ListaDifusion(usuarioActual);
            listaDifusion.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
