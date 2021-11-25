using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Entidades
{
    public class Libro:ICloneable
    {
        public string ISBN { get; set; }
        public string NombreLibro { get; set; }
        public Editorial Editorial { get; set; }
        public Tema Tema { get; set; }
        public int Paginas { get; set; }
        public string Autor { get; set; }
        public override string ToString()
        {
            return $"{NombreLibro} - {Autor} - Pág:{Paginas}";
        }

        public override bool Equals(object obj)
        {
            if (obj==null ||!(obj is Libro))
            {
                return false;
            }

            return this.ISBN == ((Libro) obj).ISBN &&
                   this.NombreLibro == ((Libro) obj).NombreLibro &&
                   this.Editorial == ((Libro) obj).Editorial &&
                   this.Tema == ((Libro) obj).Tema &&
                   this.Paginas == ((Libro) obj).Paginas &&
                   this.Autor == ((Libro) obj).Autor;

        }

        public override int GetHashCode()
        {
            return this.ISBN.GetHashCode() + this.NombreLibro.GetHashCode() +
                   this.Editorial.GetHashCode() + this.Tema.GetHashCode() +
                   this.Paginas.GetHashCode() + this.Autor.GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool ValidarLibro()
        {
            if (string.IsNullOrEmpty(ISBN.Trim())) return false;
            if (string.IsNullOrEmpty(Autor.Trim())) return false;
            if (Paginas <= 0) return false;
            return true;
        }
    }
}
