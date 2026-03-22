using System;
// Clase que representa un préstamo de libro
namespace BibliotecaMenu.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public Libro Libro { get; set; } = new Libro();
        public Usuario Usuario { get; set; } = new Usuario();
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public EstadoPrestamo Estado { get; set; }

        // Constructor vacío
        public Prestamo()
        {
            Estado = EstadoPrestamo.Activo;
            FechaDevolucion = null;
        }

        // Constructor completo
        public Prestamo(int id, Libro libro, Usuario usuario, DateTime fechaPrestamo)
        {
            Id = id;
            Libro = libro;
            Usuario = usuario;
            FechaPrestamo = fechaPrestamo;
            Estado = EstadoPrestamo.Activo;
            FechaDevolucion = null;
        }

        public bool EstaVencido()
        {
            return Estado == EstadoPrestamo.Activo &&
                   (DateTime.Now - FechaPrestamo).Days > 7;
        }

        public int DiasTranscurridos()
        {
            return (DateTime.Now - FechaPrestamo).Days;
        }

        public string ResumenCorto()
        {
            return $"Préstamo {Id} - {Libro.Titulo} a {Usuario.Nombre} ({Estado})";
        }

        public string DetalleCompleto()
        {
            return $"ID: {Id}\nLibro: {Libro.Titulo}\nUsuario: {Usuario.Nombre}\nFecha préstamo: {FechaPrestamo}\nFecha devolución: {FechaDevolucion}\nEstado: {Estado}";
        }

        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}