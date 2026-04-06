using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaMenu.Models;

namespace BibliotecaMenu.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();

        // =============================
        // AGREGAR
        // =============================
        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        // =============================
        // OBTENER TODOS
        // =============================
        public List<Usuario> ObtenerTodos()
        {
            return usuarios;
        }

        // =============================
        // ELIMINAR
        // =============================
        public bool EliminarUsuario(int id)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario != null)
            {
                usuarios.Remove(usuario);
                return true;
            }

            return false;
        }

        // =============================
        // BUSCAR
        // =============================
        public Usuario BuscarPorId(int id)
        {
            return usuarios.FirstOrDefault(u => u.Id == id);
        }

        public List<Usuario> BuscarPorNombre(string nombre)
        {
            return usuarios
                .Where(u => u.Nombre.ToLower().Contains(nombre.ToLower()))
                .ToList();
        }

        // =============================
        // ORDENAR
        // =============================
        public List<Usuario> OrdenarPorNombre()
        {
            return usuarios.OrderBy(u => u.Nombre).ToList();
        }

        // =============================
        // KPIs
        // =============================
        public int TotalUsuarios()
        {
            return usuarios.Count;
        }

        public int UsuariosActivos()
        {
            return usuarios.Count(u => u.Activo);
        }

        public int UsuariosInactivos()
        {
            return usuarios.Count(u => !u.Activo);
        }
    }
}