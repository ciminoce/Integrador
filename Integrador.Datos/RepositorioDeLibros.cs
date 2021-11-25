using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integrador.Entidades;

namespace Integrador.Datos
{
    public class RepositorioDeLibros
    {
        private List<Libro> listaLibros;
        private ManejadorDeArchivo manejador;
        public static RepositorioDeLibros _instancia = null;
        
        public static RepositorioDeLibros GetInstancia()
        {
            if (_instancia==null)
            {
                _instancia = new RepositorioDeLibros();
            }

            return _instancia;
        }
        private RepositorioDeLibros()
        {
            listaLibros = new List<Libro>();
            manejador = new ManejadorDeArchivo();
            listaLibros = manejador.LeerDatosDelArchivo();
        }

        public List<Libro> GetLista()
        {
            return listaLibros;
        }

        public void Agregar(Libro libro)
        {
            manejador.Agregar(libro);
            listaLibros.Add(libro);
        }

        public void Editar(Libro circOriginal, Libro circModificada)
        {
            manejador.Editar(circOriginal, circModificada);
            int index = listaLibros.IndexOf(circOriginal);//obtengo el nro. de elemento de la circ orig
            listaLibros.RemoveAt(index);//borro el elemento con el index obtenido
            listaLibros.Insert(index,circModificada);//pongo la circ modificada en el lugar que estaba antes la orig
        }

        public void Borrar(Libro libro)
        {
            manejador.BorrarDelArchivo(libro);
            listaLibros.Remove(libro);
        }

        public bool Existe(Libro libro)
        {
            return listaLibros.Contains(libro);
        }

        public bool ExisteISBN(string isbnBuscado)
        {
            return listaLibros.Any(l => l.ISBN == isbnBuscado);
        }
        public int GetCantidad()
        {
            return listaLibros.Count;
        }

    }
}
