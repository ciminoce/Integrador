using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Integrador.Datos;
using Integrador.Entidades;

namespace Integrador.Windows
{
    public partial class FrmLibrosAE : Form
    {
        public FrmLibrosAE()
        {
            InitializeComponent();
        }

        private Libro libro;
        public Libro GetLibro()
        {
            return libro;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboEditoriales(ref EditorialComboBox);
            CargarDatosComboTemas(ref TemaComboBox);
            if (libro != null)
            {
                NombreLibroTextBox.Text = libro.NombreLibro;
                AutorTextBox.Text = libro.Autor;
                ISBNTextBox.Text = libro.ISBN;

                PaginasNumericUpDown.Value = libro.Paginas;
                EditorialComboBox.SelectedItem = libro.Editorial;
                TemaComboBox.SelectedItem = libro.Tema;
            }
        }

        private void CargarDatosComboTemas(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Tema));
        }

        private void CargarDatosComboEditoriales(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Editorial));
        }


        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (libro == null)
                {
                    libro = new Libro();
                }

                libro.ISBN = ISBNTextBox.Text;
                libro.NombreLibro = NombreLibroTextBox.Text;
                libro.Autor = AutorTextBox.Text;
                libro.Paginas =(int) PaginasNumericUpDown.Value;
                libro.Editorial =(Editorial) EditorialComboBox.SelectedItem;
                libro.Tema = (Tema) TemaComboBox.SelectedItem;
                if (!libro.ValidarLibro())
                {
                    //errorProvider1.SetError(NombreLibroTextBox,"El libro no pasa la validación!!");
                    MessageBox.Show("El libro no pasa la validación" + Environment.NewLine +
                                    "Favor de revisar los datos ingresados", "Error",

                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (RepositorioDeLibros.GetInstancia().ExisteISBN(libro.ISBN))
                {
                    errorProvider1.SetError(ISBNTextBox,"ISBN repetido!!!");
                    return;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {

            return true;
        }

    }
}
