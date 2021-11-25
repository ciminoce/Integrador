using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integrador.Datos;
using Integrador.Entidades;

namespace Integrador.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var libro = new Libro()
            {
                ISBN = "179796464",
                NombreLibro = "Un gijarro en el cielo",
                Autor = "xxxxxx",
                Editorial = Editorial.McGrawHill,
                Tema = Tema.Guerra,
                Paginas = 500
            };

            if (libro.ValidarLibro())
            {
                if (!RepositorioDeLibros.GetInstancia().Existe(libro))
                {

                    if (!RepositorioDeLibros.GetInstancia().ExisteISBN(libro.ISBN))
                    {
                        RepositorioDeLibros.GetInstancia().Agregar(libro);
                        Console.WriteLine(RepositorioDeLibros.GetInstancia().GetCantidad());
                        foreach (var libroEnLista in RepositorioDeLibros.GetInstancia().GetLista())
                        {
                            Console.WriteLine(libroEnLista.ToString());
                        }

                    }
                    else
                    {
                        Console.WriteLine("ISBN repetido!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Libro existente!!!!");
                }

            }
            else
            {
                Console.WriteLine("El libro no pasó la validación... favor verifique");
            }
            //Console.WriteLine(RepositorioDeLibros.GetInstancia().GetCantidad());
            //var libro2 = new Libro()
            //{
            //    Radio = 40,
            //    Borde = Color.Rojo,
            //    Relleno = Color.Negro
            //};
            //if (libro2.Validar())
            //{

            //    if (!RepositorioDeCircunferencias.GetInstancia().Existe(libro2))
            //    {
            //        RepositorioDeCircunferencias.GetInstancia().Agregar(libro2);
            //        Console.WriteLine(RepositorioDeCircunferencias.GetInstancia().GetCantidad());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Circ existente!!!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Circ mal ingresada!!!");
            //}
            //var libro = new Libro()
            //{
            //};
            //if (RepositorioDeLibros.GetInstancia().Existe(libro))
            //{
            //    RepositorioDeLibros.GetInstancia().Borrar(libro);
            //    Console.WriteLine(RepositorioDeLibros.GetInstancia().GetCantidad());

            //}
            //else
            //{
            //    Console.WriteLine("Circ no guardada en el repo");
            //}
            Console.ReadLine();

        }
    }
}
