using System;
using BibliotecaMenu.Models;
using BibliotecaMenu.Services;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static LibroService libroService = new LibroService();
    static UsuarioService usuarioService = new UsuarioService();
    static PrestamoService prestamoService = new PrestamoService();

    static void Main()
    {
        ShowMainMenu();
    }

    // ==============================
    // MENÚ PRINCIPAL
    // ==============================

    static void ShowMainMenu()
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE BIBLIOTECA ===");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Probar modelos");
            Console.WriteLine("7. Comparar Array vs List");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    ShowBooksMenu();
                    break;

                case 2:
                    ShowUsersMenu();
                    break;

                case 3:
                    ShowLoansMenu();
                    break;

                case 4:
                    ShowSearchReportsMenu();
                    break;

                case 5:
                    ShowPersistenceMenu();
                    break;

                case 6:
                    TestObjects();
                    break;

                case 7:
                    CompararArrayVsList();
                    break;
                case 8:
                    ConfirmExitAndSave();
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    Console.ReadKey();
                    break;
            }

        } while (option != 6);
    }

    // ==============================
    // MENÚ LIBROS
    // ==============================

    static void ShowBooksMenu()
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ LIBROS ===");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Ver detalle");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    RegisterBook();
                    break;

                case 2:
                    ListBooksMenu();
                    break;

                case 3:
                    ViewBookDetail();
                    break;

                case 4:
                    UpdateBookMenu();
                    break;

                case 5:
                    DeleteBook();
                    break;
            }

        } while (option != 0);
    }

    static void ListBooksMenu()
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("=== LISTAR LIBROS ===");
            Console.WriteLine("1. Listar todos");
            Console.WriteLine("2. Listar disponibles");
            Console.WriteLine("3. Listar prestados");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    ListBooksAll();
                    break;

                case 2:
                    ListBooksAvailable();
                    break;

                case 3:
                    ListBooksBorrowed();
                    break;
            }

        } while (option != 0);
    }

    static void UpdateBookMenu()
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("=== ACTUALIZAR LIBRO ===");
            Console.WriteLine("1. Editar título");
            Console.WriteLine("2. Editar autor");
            Console.WriteLine("3. Editar año / categoría");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    EditBookTitle();
                    break;

                case 2:
                    EditBookAuthor();
                    break;

                case 3:
                    EditBookYearCategory();
                    break;
            }

        } while (option != 0);
    }

    // ==============================
    // MENÚ USUARIOS
    // ==============================

    static void ShowUsersMenu()
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ USUARIOS ===");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Ver detalle usuario");
            Console.WriteLine("4. Actualizar usuario");
            Console.WriteLine("5. Eliminar usuario");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    RegisterUser();
                    break;

                case 2:
                    ListUsers();
                    break;

                case 3:
                    ViewUserDetail();
                    break;

                case 4:
                    UpdateUserMenu();
                    break;

                case 5:
                    DeleteUser();
                    break;
            }

        } while (option != 0);
    }

    static void UpdateUserMenu()
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("=== ACTUALIZAR USUARIO ===");
            Console.WriteLine("1. Editar nombre");
            Console.WriteLine("2. Editar contacto");
            Console.WriteLine("3. Activar / desactivar");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    EditUserName();
                    break;

                case 2:
                    EditUserContact();
                    break;

                case 3:
                    ToggleUserActiveStatus();
                    break;
            }

        } while (option != 0);
    }

    // ==============================
    // MENÚ PRÉSTAMOS
    // ==============================

    static void ShowLoansMenu()
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ PRÉSTAMOS ===");
            Console.WriteLine("1. Crear préstamo");
            Console.WriteLine("2. Listar préstamos");
            Console.WriteLine("3. Ver detalle préstamo");
            Console.WriteLine("4. Registrar devolución");
            Console.WriteLine("5. Eliminar préstamo");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    CreateLoan();
                    break;

                case 2:
                    ListLoansMenu();
                    break;

                case 3:
                    ViewLoanDetail();
                    break;

                case 4:
                    RegisterReturn();
                    break;

                case 5:
                    DeleteLoan();
                    break;
            }

        } while (option != 0);
    }

    static void ListLoansMenu()
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("=== LISTAR PRÉSTAMOS ===");
            Console.WriteLine("1. Todos");
            Console.WriteLine("2. Activos");
            Console.WriteLine("3. Cerrados");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    ListLoansAll();
                    break;

                case 2:
                    ListLoansActive();
                    break;

                case 3:
                    ListLoansClosed();
                    break;
            }

        } while (option != 0);
    }

    // ==============================
    // MENÚ BÚSQUEDAS Y REPORTES
    // ==============================

    static void ShowSearchReportsMenu()
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("=== BÚSQUEDAS Y REPORTES ===");
            Console.WriteLine("1. Buscar libro");
            Console.WriteLine("2. Buscar usuario");
            Console.WriteLine("3. Reportes");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    SearchBook();
                    break;

                case 2:
                    SearchUser();
                    break;

                case 3:
                    ShowReportsMenu();
                    break;
            }

        } while (option != 0);
    }

    static void ShowReportsMenu()
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("=== REPORTES ===");
            Console.WriteLine("1. Reporte por usuario");
            Console.WriteLine("2. Reporte por libro");
            Console.WriteLine("3. Libros vencidos");
            Console.WriteLine("4. Resumen");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    ReportByUser();
                    break;

                case 2:
                    ReportByBook();
                    break;

                case 3:
                    ReportOverdue();
                    break;

                case 4:
                    ReportSummary();
                    break;
            }

        } while (option != 0);
    }

    // ==============================
    // MENÚ PERSISTENCIA
    // ==============================

    static void ShowPersistenceMenu()
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("=== PERSISTENCIA ===");
            Console.WriteLine("1. Guardar datos");
            Console.WriteLine("2. Cargar datos");
            Console.WriteLine("3. Reiniciar datos");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    SaveData();
                    break;

                case 2:
                    LoadData();
                    break;

                case 3:
                    ConfirmResetData();
                    break;
            }

        } while (option != 0);
    }

    // ==============================
    // FUNCIONES DE LIBROS
    // ==============================

    static void RegisterBook()
    {
        Console.Clear();

        Console.Write("ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        Console.Write("Título: ");
        string titulo = Console.ReadLine();

        Console.Write("Autor: ");
        string autor = Console.ReadLine();

        Console.Write("Año: ");
        if (!int.TryParse(Console.ReadLine(), out int anio))
        {
            Console.WriteLine("Año inválido");
            Console.ReadKey();
            return;
        }

        Console.Write("Categoría: ");
        string categoria = Console.ReadLine();

        Libro libro = new Libro(id, titulo, autor, anio, categoria);

        libroService.AgregarLibro(libro);

        Console.WriteLine("Libro agregado correctamente");
        Console.ReadKey();
    }

    static void ListBooksAll()
    {
        Console.Clear();

        var libros = libroService.ObtenerTodos();

        if (libros.Count == 0)
        {
            Console.WriteLine("No hay libros registrados");
        }
        else
        {
            foreach (var libro in libros)
            {
                Console.WriteLine(libro.ResumenCorto());
            }
        }

        Console.ReadKey();
    }

    static void ListBooksAvailable()
    {
        Console.Clear();

        var libros = libroService.ObtenerTodos()
            .Where(l => l.Disponible)
            .ToList();

        if (libros.Count == 0)
        {
            Console.WriteLine("No hay libros disponibles");
        }
        else
        {
            foreach (var libro in libros)
            {
                Console.WriteLine(libro.ResumenCorto());
            }
        }

        Console.ReadKey();
    }

    static void ListBooksBorrowed()
    {
        Console.Clear();

        var libros = libroService.ObtenerTodos()
            .Where(l => !l.Disponible)
            .ToList();

        if (libros.Count == 0)
        {
            Console.WriteLine("No hay libros prestados");
        }
        else
        {
            foreach (var libro in libros)
            {
                Console.WriteLine(libro.ResumenCorto());
            }
        }

        Console.ReadKey();
    }

    static void ViewBookDetail()
    {
        Console.Clear();

        Console.WriteLine("=== DETALLE DEL LIBRO ===");

        Console.Write("Ingrese el ID del libro: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var libro = libroService.BuscarPorId(id);

        if (libro == null)
        {
            Console.WriteLine("Libro no encontrado");
        }
        else
        {
            Console.WriteLine(libro.DetalleCompleto());
        }

        Console.ReadKey();
    }

    static void EditBookTitle()
    {
        Console.Clear();

        Console.Write("ID del libro: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var libro = libroService.BuscarPorId(id);

        if (libro == null)
        {
            Console.WriteLine("Libro no encontrado");
        }
        else
        {
            Console.Write("Nuevo título: ");
            libro.Titulo = Console.ReadLine();
            Console.WriteLine("Título actualizado");
        }

        Console.ReadKey();
    }

    static void EditBookAuthor()
    {
        Console.Clear();

        Console.Write("ID del libro: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var libro = libroService.BuscarPorId(id);

        if (libro == null)
        {
            Console.WriteLine("Libro no encontrado");
        }
        else
        {
            Console.Write("Nuevo autor: ");
            libro.Autor = Console.ReadLine();
            Console.WriteLine("Autor actualizado");
        }

        Console.ReadKey();
    }

    static void EditBookYearCategory()
    {
        Console.Clear();

        Console.Write("ID del libro: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var libro = libroService.BuscarPorId(id);

        if (libro == null)
        {
            Console.WriteLine("Libro no encontrado");
        }
        else
        {
            Console.Write("Nuevo año: ");
            if (int.TryParse(Console.ReadLine(), out int anio))
            {
                libro.Anio = anio;
            }

            Console.Write("Nueva categoría: ");
            libro.Categoria = Console.ReadLine();

            Console.WriteLine("Datos actualizados");
        }

        Console.ReadKey();
    }

    static void DeleteBook()
    {
        Console.Clear();

        Console.WriteLine("=== ELIMINAR LIBRO ===");

        Console.Write("Ingrese el ID del libro a eliminar: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        bool eliminado = libroService.EliminarLibro(id);

        if (eliminado)
            Console.WriteLine("Libro eliminado correctamente");
        else
            Console.WriteLine("No se encontró el libro con ese ID");

        Console.ReadKey();
    }

    // ==============================
    // FUNCIONES DE USUARIOS
    // ==============================

    static void RegisterUser()
    {
        Console.Clear();

        Console.Write("ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Contacto: ");
        string contacto = Console.ReadLine();

        Usuario usuario = new Usuario(id, nombre, contacto);

        usuarioService.AgregarUsuario(usuario);

        Console.WriteLine("Usuario registrado correctamente");
        Console.ReadKey();
    }

    static void ListUsers()
    {
        Console.Clear();

        var usuarios = usuarioService.ObtenerTodos();

        if (usuarios.Count == 0)
        {
            Console.WriteLine("No hay usuarios registrados");
        }
        else
        {
            foreach (var u in usuarios)
            {
                Console.WriteLine(u.ResumenCorto());
            }
        }

        Console.ReadKey();
    }

    static void ViewUserDetail()
    {
        Console.Clear();

        Console.WriteLine("=== DETALLE DEL USUARIO ===");

        Console.Write("Ingrese el ID del usuario: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var usuario = usuarioService.BuscarPorId(id);

        if (usuario == null)
        {
            Console.WriteLine("Usuario no encontrado");
        }
        else
        {
            Console.WriteLine(usuario.DetalleCompleto());
        }

        Console.ReadKey();
    }

    static void EditUserName()
    {
        Console.Clear();

        Console.Write("ID del usuario: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var usuario = usuarioService.BuscarPorId(id);

        if (usuario == null)
        {
            Console.WriteLine("Usuario no encontrado");
        }
        else
        {
            Console.Write("Nuevo nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Nombre actualizado");
        }

        Console.ReadKey();
    }

    static void EditUserContact()
    {
        Console.Clear();

        Console.Write("ID del usuario: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var usuario = usuarioService.BuscarPorId(id);

        if (usuario == null)
        {
            Console.WriteLine("Usuario no encontrado");
        }
        else
        {
            Console.Write("Nuevo contacto: ");
            usuario.Contacto = Console.ReadLine();
            Console.WriteLine("Contacto actualizado");
        }

        Console.ReadKey();
    }

    static void ToggleUserActiveStatus()
    {
        Console.Clear();

        Console.Write("ID del usuario: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var usuario = usuarioService.BuscarPorId(id);

        if (usuario == null)
        {
            Console.WriteLine("Usuario no encontrado");
        }
        else
        {
            usuario.Activo = !usuario.Activo;
            Console.WriteLine($"Usuario {(usuario.Activo ? "activado" : "desactivado")}");
        }

        Console.ReadKey();
    }

    static void DeleteUser()
    {
        Console.Clear();

        Console.WriteLine("=== ELIMINAR USUARIO ===");

        Console.Write("Ingrese el ID del usuario a eliminar: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        bool eliminado = usuarioService.EliminarUsuario(id);

        if (eliminado)
            Console.WriteLine("Usuario eliminado correctamente");
        else
            Console.WriteLine("No se encontró el usuario con ese ID");

        Console.ReadKey();
    }

    // ==============================
    // FUNCIONES DE PRÉSTAMOS
    // ==============================

    static void CreateLoan()
    {
        Console.Clear();

        Console.WriteLine("=== CREAR PRÉSTAMO ===");

        Console.Write("ID préstamo: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        Console.Write("ID libro: ");
        if (!int.TryParse(Console.ReadLine(), out int idLibro))
        {
            Console.WriteLine("ID de libro inválido");
            Console.ReadKey();
            return;
        }

        Console.Write("ID usuario: ");
        if (!int.TryParse(Console.ReadLine(), out int idUsuario))
        {
            Console.WriteLine("ID de usuario inválido");
            Console.ReadKey();
            return;
        }

        var libro = libroService.BuscarPorId(idLibro);
        var usuario = usuarioService.BuscarPorId(idUsuario);

        if (libro == null)
        {
            Console.WriteLine("Libro no existe");
            Console.ReadKey();
            return;
        }

        if (usuario == null)
        {
            Console.WriteLine("Usuario no existe");
            Console.ReadKey();
            return;
        }

        if (!usuario.Activo)
        {
            Console.WriteLine("El usuario está inactivo");
            Console.ReadKey();
            return;
        }

        if (!libro.Disponible)
        {
            Console.WriteLine("El libro no está disponible");
            Console.ReadKey();
            return;
        }

        Prestamo prestamo = new Prestamo(id, libro, usuario, DateTime.Now);

        bool creado = prestamoService.CrearPrestamo(prestamo);

        if (creado)
            Console.WriteLine("Préstamo creado correctamente");
        else
            Console.WriteLine("No se pudo crear el préstamo");

        Console.ReadKey();
    }

    static void ListLoansAll()
    {
        Console.Clear();

        var prestamos = prestamoService.ObtenerTodos();

        if (prestamos.Count == 0)
        {
            Console.WriteLine("No hay préstamos registrados");
        }
        else
        {
            foreach (var p in prestamos)
            {
                Console.WriteLine(p.ResumenCorto());
            }
        }

        Console.ReadKey();
    }

    static void ListLoansActive()
    {
        Console.Clear();

        var prestamos = prestamoService.BuscarPorEstado(EstadoPrestamo.Activo);

        if (prestamos.Count == 0)
        {
            Console.WriteLine("No hay préstamos activos");
        }
        else
        {
            foreach (var p in prestamos)
            {
                Console.WriteLine(p.ResumenCorto());
            }
        }

        Console.ReadKey();
    }

    static void ListLoansClosed()
    {
        Console.Clear();

        var prestamos = prestamoService.BuscarPorEstado(EstadoPrestamo.Devuelto);

        if (prestamos.Count == 0)
        {
            Console.WriteLine("No hay préstamos cerrados");
        }
        else
        {
            foreach (var p in prestamos)
            {
                Console.WriteLine(p.ResumenCorto());
            }
        }

        Console.ReadKey();
    }

    static void ViewLoanDetail()
    {
        Console.Clear();

        Console.WriteLine("=== DETALLE DEL PRÉSTAMO ===");

        Console.Write("Ingrese el ID del préstamo: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var prestamo = prestamoService.BuscarPorId(id);

        if (prestamo == null)
        {
            Console.WriteLine("Préstamo no encontrado");
        }
        else
        {
            Console.WriteLine(prestamo.DetalleCompleto());
        }

        Console.ReadKey();
    }

    static void RegisterReturn()
    {
        Console.Clear();

        Console.WriteLine("=== REGISTRAR DEVOLUCIÓN ===");

        Console.Write("Ingrese el ID del préstamo: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var prestamo = prestamoService.BuscarPorId(id);

        if (prestamo == null)
        {
            Console.WriteLine("Préstamo no encontrado");
            Console.ReadKey();
            return;
        }

        if (prestamo.Estado != EstadoPrestamo.Activo)
        {
            Console.WriteLine("Este préstamo ya fue devuelto o está vencido");
            Console.ReadKey();
            return;
        }

        bool devuelto = prestamoService.RegistrarDevolucion(id);

        if (devuelto)
            Console.WriteLine("Devolución registrada correctamente");
        else
            Console.WriteLine("No se pudo registrar la devolución");

        Console.ReadKey();
    }

    static void DeleteLoan()
    {
        Console.Clear();

        Console.WriteLine("=== ELIMINAR PRÉSTAMO ===");

        Console.Write("Ingrese el ID del préstamo a eliminar: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var prestamo = prestamoService.BuscarPorId(id);

        if (prestamo != null && prestamo.Estado == EstadoPrestamo.Activo)
        {
            prestamo.Libro.Disponible = true;
        }

        bool eliminado = prestamoService.EliminarPrestamo(id);

        if (eliminado)
            Console.WriteLine("Préstamo eliminado correctamente");
        else
            Console.WriteLine("No se encontró el préstamo con ese ID");

        Console.ReadKey();
    }

    // ==============================
    // FUNCIONES DE BÚSQUEDA Y REPORTES
    // ==============================

    static void SearchBook()
    {
        Console.Clear();

        Console.WriteLine("=== BUSCAR LIBRO ===");
        Console.WriteLine("1. Buscar por ID");
        Console.WriteLine("2. Buscar por título");
        Console.WriteLine("3. Buscar por autor");
        Console.Write("Seleccione una opción: ");

        if (!int.TryParse(Console.ReadLine(), out int option))
        {
            Console.WriteLine("Opción inválida");
            Console.ReadKey();
            return;
        }

        switch (option)
        {
            case 1:
                Console.Write("Ingrese el ID: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    var libro = libroService.BuscarPorId(id);
                    if (libro == null)
                        Console.WriteLine("Libro no encontrado");
                    else
                        Console.WriteLine(libro.DetalleCompleto());
                }
                break;

            case 2:
                Console.Write("Ingrese el título: ");
                string titulo = Console.ReadLine();
                var librosPorTitulo = libroService.BuscarPorTitulo(titulo);
                if (librosPorTitulo.Count == 0)
                    Console.WriteLine("No se encontraron libros");
                else
                    foreach (var l in librosPorTitulo)
                        Console.WriteLine(l.ResumenCorto());
                break;

            case 3:
                Console.Write("Ingrese el autor: ");
                string autor = Console.ReadLine();
                var librosPorAutor = libroService.BuscarPorAutor(autor);
                if (librosPorAutor.Count == 0)
                    Console.WriteLine("No se encontraron libros");
                else
                    foreach (var l in librosPorAutor)
                        Console.WriteLine(l.ResumenCorto());
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }

        Console.ReadKey();
    }

    static void SearchUser()
    {
        Console.Clear();

        Console.WriteLine("=== BUSCAR USUARIO ===");
        Console.WriteLine("1. Buscar por ID");
        Console.WriteLine("2. Buscar por nombre");
        Console.Write("Seleccione una opción: ");

        if (!int.TryParse(Console.ReadLine(), out int option))
        {
            Console.WriteLine("Opción inválida");
            Console.ReadKey();
            return;
        }

        switch (option)
        {
            case 1:
                Console.Write("Ingrese el ID: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    var usuario = usuarioService.BuscarPorId(id);
                    if (usuario == null)
                        Console.WriteLine("Usuario no encontrado");
                    else
                        Console.WriteLine(usuario.DetalleCompleto());
                }
                break;

            case 2:
                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                var usuariosPorNombre = usuarioService.BuscarPorNombre(nombre);
                if (usuariosPorNombre.Count == 0)
                    Console.WriteLine("No se encontraron usuarios");
                else
                    foreach (var u in usuariosPorNombre)
                        Console.WriteLine(u.ResumenCorto());
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }

        Console.ReadKey();
    }

    static void ReportByUser()
    {
        Console.Clear();

        Console.WriteLine("=== REPORTE POR USUARIO ===");

        Console.Write("Ingrese el ID del usuario: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var usuario = usuarioService.BuscarPorId(id);

        if (usuario == null)
        {
            Console.WriteLine("Usuario no encontrado");
            Console.ReadKey();
            return;
        }

        Console.WriteLine($"\nPréstamos del usuario: {usuario.Nombre}");
        Console.WriteLine("=====================================");

        var prestamos = prestamoService.ObtenerTodos()
            .Where(p => p.Usuario.Id == id)
            .ToList();

        if (prestamos.Count == 0)
        {
            Console.WriteLine("El usuario no tiene préstamos");
        }
        else
        {
            foreach (var p in prestamos)
            {
                Console.WriteLine(p.ResumenCorto());
            }
        }

        Console.ReadKey();
    }

    static void ReportByBook()
    {
        Console.Clear();

        Console.WriteLine("=== REPORTE POR LIBRO ===");

        Console.Write("Ingrese el ID del libro: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido");
            Console.ReadKey();
            return;
        }

        var libro = libroService.BuscarPorId(id);

        if (libro == null)
        {
            Console.WriteLine("Libro no encontrado");
            Console.ReadKey();
            return;
        }

        Console.WriteLine($"\nHistorial del libro: {libro.Titulo}");
        Console.WriteLine("=====================================");

        var prestamos = prestamoService.ObtenerTodos()
            .Where(p => p.Libro.Id == id)
            .ToList();

        if (prestamos.Count == 0)
        {
            Console.WriteLine("El libro no tiene préstamos registrados");
        }
        else
        {
            foreach (var p in prestamos)
            {
                Console.WriteLine(p.ResumenCorto());
            }
        }

        Console.ReadKey();
    }

    static void ReportOverdue()
    {
        Console.Clear();

        Console.WriteLine("=== LIBROS VENCIDOS ===");
        Console.WriteLine("(Préstamos activos con más de 7 días)");
        Console.WriteLine("=====================================");

        var prestamosVencidos = prestamoService.ObtenerTodos()
            .Where(p => p.EstaVencido())
            .ToList();

        if (prestamosVencidos.Count == 0)
        {
            Console.WriteLine("No hay préstamos vencidos");
        }
        else
        {
            foreach (var p in prestamosVencidos)
            {
                Console.WriteLine($"{p.ResumenCorto()} - Días: {p.DiasTranscurridos()}");
            }
        }

        Console.ReadKey();
    }

    static void ReportSummary()
    {
        Console.Clear();

        Console.WriteLine("=== KPIs DEL SISTEMA ===\n");

        // Actualizar estados vencidos antes del reporte
        ActualizarEstadosVencidos();

        // Libros
        Console.WriteLine("LIBROS:");
        Console.WriteLine($"Total: {libroService.TotalLibros()}");
        Console.WriteLine($"Disponibles: {libroService.LibrosDisponibles()}");
        Console.WriteLine($"Prestados: {libroService.LibrosPrestados()}");

        // Usuarios
        Console.WriteLine("\nUSUARIOS:");
        Console.WriteLine($"Total: {usuarioService.TotalUsuarios()}");
        Console.WriteLine($"Activos: {usuarioService.UsuariosActivos()}");
        Console.WriteLine($"Inactivos: {usuarioService.UsuariosInactivos()}");

        // Préstamos
        Console.WriteLine("\nPRÉSTAMOS:");
        Console.WriteLine($"Total: {prestamoService.TotalPrestamos()}");
        Console.WriteLine($"Activos: {prestamoService.PrestamosActivos()}");
        Console.WriteLine($"Devueltos: {prestamoService.PrestamosDevueltos()}");
        Console.WriteLine($"Vencidos: {prestamoService.PrestamosVencidos()}");
        Console.WriteLine($"Promedio días: {prestamoService.PromedioDiasPrestamo():0.00}");

        Console.ReadKey();
    }

    static void ActualizarEstadosVencidos()
    {
        foreach (var prestamo in prestamoService.ObtenerTodos())
        {
            if (prestamo.Estado == EstadoPrestamo.Activo && prestamo.EstaVencido())
            {
                prestamo.Estado = EstadoPrestamo.Vencido;
            }
        }
    }

    // ==============================
    // FUNCIONES DE PERSISTENCIA
    // ==============================

    static void SaveData()
    {
        Console.Clear();
        Console.WriteLine("=== GUARDAR DATOS ===");

        // En una versión real, aquí se guardaría en archivos JSON/XML o base de datos
        // Por ahora simulamos el guardado
        Console.WriteLine($"Libros guardados: {libroService.TotalLibros()}");
        Console.WriteLine($"Usuarios guardados: {usuarioService.TotalUsuarios()}");
        Console.WriteLine($"Préstamos guardados: {prestamoService.TotalPrestamos()}");
        Console.WriteLine("\nDatos guardados correctamente (simulado)");

        Console.ReadKey();
    }

    static void LoadData()
    {
        Console.Clear();
        Console.WriteLine("=== CARGAR DATOS ===");

        // En una versión real, aquí se cargaría desde archivos JSON/XML o base de datos
        // Por ahora simulamos la carga
        Console.WriteLine("Datos cargados correctamente (simulado)");

        Console.ReadKey();
    }

    static void ConfirmResetData()
    {
        Console.Clear();
        Console.WriteLine("=== REINICIAR DATOS ===");
        Console.Write("¿Seguro que desea reiniciar todos los datos? (S/N): ");

        if (Console.ReadLine().ToUpper() == "S")
        {
            // Reiniciar datos
            libroService = new LibroService();
            usuarioService = new UsuarioService();
            prestamoService = new PrestamoService();
            Console.WriteLine("Datos reiniciados correctamente");
        }
        else
        {
            Console.WriteLine("Operación cancelada");
        }

        Console.ReadKey();
    }

    static void ConfirmExitAndSave()
    {
        Console.Clear();
        Console.WriteLine("=== SALIR ===");
        Console.Write("¿Desea guardar los datos antes de salir? (S/N): ");

        if (Console.ReadLine().ToUpper() == "S")
        {
            SaveData();
        }

        Console.WriteLine("¡Hasta luego!");
        Console.ReadKey();
    }

    // ==============================
    // TEST Y DEMOSTRACIÓN
    // ==============================

    static void TestObjects()
    {
        Console.Clear();

        Console.WriteLine("=== PRUEBA DE MODELOS ===\n");

        // Probar Libro
        Libro libro1 = new Libro(1, "Prueba", "Autor Test", 2020, "General");
        Console.WriteLine("LIBRO:");
        Console.WriteLine(libro1.DetalleCompleto());
        Console.WriteLine();

        // Probar Usuario
        Usuario usuario1 = new Usuario(1, "Usuario Test", "test@email.com");
        Console.WriteLine("USUARIO:");
        Console.WriteLine(usuario1.DetalleCompleto());
        Console.WriteLine();

        // Probar Préstamo
        Prestamo prestamo1 = new Prestamo(1, libro1, usuario1, DateTime.Now);
        Console.WriteLine("PRÉSTAMO:");
        Console.WriteLine(prestamo1.DetalleCompleto());
        Console.WriteLine();
        Console.WriteLine($"¿Está vencido? {prestamo1.EstaVencido()}");
        Console.WriteLine($"Días transcurridos: {prestamo1.DiasTranscurridos()}");

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void CompararArrayVsList()
    {
        Console.Clear();

        Console.WriteLine("=== COMPARACIÓN: ARRAY vs LIST ===\n");

        Console.WriteLine("ARRAY (tamaño fijo):");
        string[] nombresArray = new string[2];
        nombresArray[0] = "Juan";
        nombresArray[1] = "Ana";
        // nombresArray[2] = "Carlos"; ❌ ERROR (tamaño fijo)

        foreach (var n in nombresArray)
        {
            Console.WriteLine($"  - {n}");
        }

        Console.WriteLine("\nLIST (tamaño dinámico):");
        List<string> nombresList = new List<string>();
        nombresList.Add("Juan");
        nombresList.Add("Ana");
        nombresList.Add("Carlos"); // ✔ se puede agregar dinámicamente
        nombresList.Add("María");  // ✔ se puede seguir agregando

        foreach (var n in nombresList)
        {
            Console.WriteLine($"  - {n}");
        }

        Console.WriteLine("\n=== DIFERENCIAS PRINCIPALES ===");
        Console.WriteLine("• Array: Tamaño fijo, más eficiente en memoria");
        Console.WriteLine("• List: Tamaño dinámico, métodos útiles (Add, Remove, Find)");
        Console.WriteLine("• Para colecciones que cambian frecuentemente, usar List");
        Console.WriteLine("• Para datos de tamaño conocido y fijo, usar Array");

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}