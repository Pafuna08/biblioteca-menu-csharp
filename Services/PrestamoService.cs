using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaMenu.Models;

namespace BibliotecaMenu.Services
{
    public class PrestamoService
    {
        private List<Prestamo> prestamos = new List<Prestamo>();

        // =============================
        // AGREGAR PRÉSTAMO
        // =============================
        public bool CrearPrestamo(Prestamo prestamo)
        {
            // Validar disponibilidad del libro
            if (!prestamo.Libro.Disponible)
                return false;

            // Validar usuario activo
            if (!prestamo.Usuario.Activo)
                return false;

            prestamo.Libro.Disponible = false;
            prestamos.Add(prestamo);

            return true;
        }

        // =============================
        // OBTENER TODOS
        // =============================
        public List<Prestamo> ObtenerTodos()
        {
            return prestamos;
        }

        // =============================
        // BUSCAR
        // =============================
        public Prestamo BuscarPorId(int id)
        {
            return prestamos.FirstOrDefault(p => p.Id == id);
        }

        public List<Prestamo> BuscarPorEstado(EstadoPrestamo estado)
        {
            return prestamos.Where(p => p.Estado == estado).ToList();
        }

        // =============================
        // DEVOLUCIÓN
        // =============================
        public bool RegistrarDevolucion(int id)
        {
            var prestamo = BuscarPorId(id);

            if (prestamo == null)
                return false;

            prestamo.FechaDevolucion = DateTime.Now;
            prestamo.Estado = EstadoPrestamo.Devuelto;
            prestamo.Libro.Disponible = true;

            return true;
        }

        // =============================
        // ELIMINAR
        // =============================
        public bool EliminarPrestamo(int id)
        {
            var prestamo = BuscarPorId(id);

            if (prestamo != null)
            {
                prestamos.Remove(prestamo);
                return true;
            }

            return false;
        }

        // =============================
        // ORDENAR
        // =============================
        public List<Prestamo> OrdenarPorFecha()
        {
            return prestamos.OrderBy(p => p.FechaPrestamo).ToList();
        }

        // =============================
        // KPIs
        // =============================
        public int TotalPrestamos()
        {
            return prestamos.Count;
        }

        public int PrestamosActivos()
        {
            return prestamos.Count(p => p.Estado == EstadoPrestamo.Activo);
        }

        public int PrestamosDevueltos()
        {
            return prestamos.Count(p => p.Estado == EstadoPrestamo.Devuelto);
        }

        public int PrestamosVencidos()
        {
            return prestamos.Count(p => p.EstaVencido());
        }

        public double PromedioDiasPrestamo()
        {
            if (prestamos.Count == 0) return 0;

            return prestamos.Average(p => p.DiasTranscurridos());
        }
    }
}