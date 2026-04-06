using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaMenu.Models;

namespace BibliotecaMenu.Services
{
    public class LibroService
    {
        private List<Libro> libros = new List<Libro>();

        // =============================
        // AGREGAR
        // =============================
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        // =============================
        // OBTENER TODOS
        // =============================
        public List<Libro> ObtenerTodos()
        {
            return libros;
        }

        // =============================
        // ELIMINAR
        // =============================
        public bool EliminarLibro(int id)
        {
            var libro = libros.FirstOrDefault(l => l.Id == id);

            if (libro != null)
            {
                libros.Remove(libro);
                return true;
            }

            return false;
        }

        // =============================
        // BUSCAR
        // =============================
        public Libro BuscarPorId(int id)
        {
            return libros.FirstOrDefault(l => l.Id == id);
        }

        public List<Libro> BuscarPorTitulo(string titulo)
        {
            return libros
                .Where(l => l.Titulo.ToLower().Contains(titulo.ToLower()))
                .ToList();
        }

        public List<Libro> BuscarPorAutor(string autor)
        {
            return libros
                .Where(l => l.Autor.ToLower().Contains(autor.ToLower()))
                .ToList();
        }

        // =============================
        // ORDENAR
        // =============================
        public List<Libro> OrdenarPorTitulo()
        {
            return libros.OrderBy(l => l.Titulo).ToList();
        }

        public List<Libro> OrdenarPorAnio()
        {
            return libros.OrderBy(l => l.Anio).ToList();
        }

        // =============================
        // KPIs
        // =============================
        public int TotalLibros()
        {
            return libros.Count;
        }

        public int LibrosDisponibles()
        {
            return libros.Count(l => l.Disponible);
        }

        public int LibrosPrestados()
        {
            return libros.Count(l => !l.Disponible);
        }
    }
}