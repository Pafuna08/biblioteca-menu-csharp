using System;
// Clase que representa un usuario del sistema
namespace BibliotecaMenu.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Contacto { get; set; } = "";
        public bool Activo { get; set; }

        // Constructor vacío
        public Usuario()
        {
            Activo = true;
        }

        // Constructor completo
        public Usuario(int id, string nombre, string contacto)
        {
            Id = id;
            Nombre = nombre;
            Contacto = contacto;
            Activo = true;
        }

        public string ResumenCorto()
        {
            return $"{Id} - {Nombre} ({(Activo ? "Activo" : "Inactivo")})";
        }

        public string DetalleCompleto()
        {
            return $"ID: {Id}\nNombre: {Nombre}\nContacto: {Contacto}\nActivo: {Activo}";
        }

        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}