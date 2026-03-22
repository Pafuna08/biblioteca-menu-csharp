using System;
// Clase que representa un libro del sistema
namespace BibliotecaMenu.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public string Autor { get; set; } = "";
        public int Anio { get; set; }
        public string Categoria { get; set; } = "";
        public bool Disponible { get; set; }

        // Constructor vacío
        public Libro()
        {
            Disponible = true;
        }

        // Constructor completo
        public Libro(int id, string titulo, string autor, int anio, string categoria)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Categoria = categoria;
            Disponible = true;
        }

        public string ResumenCorto()
        {
            return $"{Id} - {Titulo} ({(Disponible ? "Disponible" : "Prestado")})";
        }

        public string DetalleCompleto()
        {
            return $"ID: {Id}\nTítulo: {Titulo}\nAutor: {Autor}\nAño: {Anio}\nCategoría: {Categoria}\nDisponible: {Disponible}";
        }

        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}