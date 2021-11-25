using Integrador.Entidades;
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

namespace Integrador.Windows
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private List<Libro> lista;
        private int cantidadRegistros;
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosComboBordes();
            MostrarCantidadRegistros();
            if (cantidadRegistros > 0)
            {
                lista = RepositorioDeLibros.GetInstancia().GetLista();
                MostrarDatosEnGrilla();
            }
        }

        private void CargarDatosComboBordes()
        {
            //var listaBordes = Enum.GetValues(typeof(Color)).Cast<Color>().ToList();
            //foreach (var borde in listaBordes)
            //{
            //    BordesToolStripComboBox.Items.Add(borde);
            //}
        }

        private void MostrarCantidadRegistros()
        {
            cantidadRegistros = RepositorioDeLibros.GetInstancia().GetCantidad();
            CantidadRegistrosLabel.Text = cantidadRegistros.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var libro in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, libro);
                AgregarFila(r);
            }
        }

        private void SetearFila(DataGridViewRow r, Libro libro)
        {
            r.Cells[colNombreLibro.Index].Value = libro.NombreLibro;
            r.Cells[colAutor.Index].Value = libro.Autor;
            r.Cells[colEditorial.Index].Value = libro.Editorial;
            r.Cells[colTema.Index].Value = libro.Tema;
            r.Cells[colPaginas.Index].Value = libro.Paginas;

            r.Tag = libro;
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            ////capturar los datos
            //FrmLibrosAE frm = new FrmLibrosAE() { Text = "Agregar Libro" };
            //DialogResult dr = frm.ShowDialog(this);
            ////ver si ya no existe
            //if (dr == DialogResult.Cancel)
            //{
            //    return;
            //}

            //Libro libro = frm.GetLibro();
            //if (RepositorioDeLibros.GetInstancia().Existe(libro))
            //{
            //    MessageBox.Show("Libro existente!!!", "ERROR",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    return;
            //}
            ////si no existe la guardo
            //RepositorioDeLibros.GetInstancia().Agregar(libro);
            //DataGridViewRow r = ConstruirFila();
            //SetearFila(r, libro);
            //AgregarFila(r);
            //MostrarCantidadRegistros();

        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            //if (DatosDataGridView.SelectedRows.Count == 0)
            //{
            //    return;
            //}

            //var r = DatosDataGridView.SelectedRows[0];
            //Libro libro = (Libro)r.Tag;
            //DialogResult dr = MessageBox.Show($"¿Desea borrar la libro de radio {libro.Radio}?",
            //    "Pregunta",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question,
            //    MessageBoxDefaultButton.Button2);
            //if (dr == DialogResult.No)
            //{
            //    return;
            //}
            //RepositorioDeLibros.GetInstancia().Borrar(libro);
            //DatosDataGridView.Rows.Remove(r);
            //MessageBox.Show("Registro Borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MostrarCantidadRegistros();
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            //if (DatosDataGridView.SelectedRows.Count == 0)
            //{
            //    return;
            //}

            //var r = DatosDataGridView.SelectedRows[0];
            //Libro libro = (Libro)r.Tag;
            //Libro libroCopia = (Libro)libro.Clone();
            //FrmLibroAE frm = new FrmLibroAE() { Text = "Editar Libro" };
            //frm.SetLibro(libroCopia);
            //DialogResult dr = frm.ShowDialog(this);
            //if (dr == DialogResult.Cancel)
            //{
            //    return;
            //}

            //libroCopia = frm.GetLibro();
            //if (RepositorioDeLibros.GetInstancia().Existe(libroCopia))
            //{
            //    MessageBox.Show("Libro existente!!!", "ERROR",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    return;
            //}
            //RepositorioDeLibros.GetInstancia().Editar(libro, libroCopia);
            //SetearFila(r, libroCopia);
            //MessageBox.Show("Registro Modificado!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BordesToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (BordesToolStripComboBox.SelectedIndex == -1)
            //{
            //    return;
            //}

            //Color color = (Color)BordesToolStripComboBox.SelectedItem;
            //lista = RepositorioDeLibros.GetInstancia().FiltrarPorBorde(color);
            //MostrarDatosEnGrilla();
            //cantidadRegistros = RepositorioDeLibros.GetInstancia().GetCantidad(color);
            //CantidadRegistrosLabel.Text = cantidadRegistros.ToString();
        }

        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            lista = RepositorioDeLibros.GetInstancia().GetLista();
            MostrarDatosEnGrilla();
            MostrarCantidadRegistros();
        }



    }
}
