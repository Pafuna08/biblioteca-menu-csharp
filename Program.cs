using System;

using BibliotecaMenu.Models; 
using BibliotecaMenu.Services;

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
            Console.WriteLine("6. Salir");
            Console.WriteLine("7. Probar modelos");
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
                    ConfirmExitAndSave();
                    break;

                case 7:
                    TestObjects();
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
    // FUNCIONES MODIFICADAS
    // ==============================

    static void RegisterBook()
    {
        Console.Clear();

        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Título: ");
        string titulo = Console.ReadLine();

        Console.Write("Autor: ");
        string autor = Console.ReadLine();

        Console.Write("Año: ");
        int anio = int.Parse(Console.ReadLine());

        Console.Write("Categoría: ");
        string categoria = Console.ReadLine();

        Libro libro = new Libro(id, titulo, autor, anio, categoria);

        libroService.AgregarLibro(libro);

        Console.WriteLine("Libro agregado correctamente");
        Console.ReadKey();
    }

    // ==============================
    // STUBS (IGUAL QUE TU ORIGINAL)
    // ==============================

    static void ListBooksAll() { Console.WriteLine("Listar todos los libros"); Console.ReadKey(); }
    static void ListBooksAvailable() { Console.WriteLine("Listar libros disponibles"); Console.ReadKey(); }
    static void ListBooksBorrowed() { Console.WriteLine("Listar libros prestados"); Console.ReadKey(); }
    static void ViewBookDetail() { Console.WriteLine("Ver detalle del libro"); Console.ReadKey(); }
    static void EditBookTitle() { Console.WriteLine("Editar título del libro"); Console.ReadKey(); }
    static void EditBookAuthor() { Console.WriteLine("Editar autor del libro"); Console.ReadKey(); }
    static void EditBookYearCategory() { Console.WriteLine("Editar año o categoría"); Console.ReadKey(); }
    static void DeleteBook() { Console.WriteLine("Eliminar libro"); Console.ReadKey(); }

    static void RegisterUser()
{
    Console.Clear();

    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();

    Console.Write("Contacto: ");
    string contacto = Console.ReadLine();

    Usuario usuario = new Usuario(id, nombre, contacto);

    usuarioService.AgregarUsuario(usuario);

    Console.WriteLine("Usuario registrado correctamente");
    Console.ReadKey();
}
    static void ListUsers() { Console.WriteLine("Listar usuarios"); Console.ReadKey(); }
    static void ViewUserDetail() { Console.WriteLine("Ver detalle del usuario"); Console.ReadKey(); }
    static void EditUserName() { Console.WriteLine("Editar nombre"); Console.ReadKey(); }
    static void EditUserContact() { Console.WriteLine("Editar contacto"); Console.ReadKey(); }
    static void ToggleUserActiveStatus() { Console.WriteLine("Activar / desactivar usuario"); Console.ReadKey(); }
    static void DeleteUser() { Console.WriteLine("Eliminar usuario"); Console.ReadKey(); }

    static void CreateLoan()
{
    Console.Clear();

    Console.Write("ID préstamo: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("ID libro: ");
    int idLibro = int.Parse(Console.ReadLine());

    Console.Write("ID usuario: ");
    int idUsuario = int.Parse(Console.ReadLine());

    var libro = libroService.BuscarPorId(idLibro);
    var usuario = usuarioService.BuscarPorId(idUsuario);

    if (libro == null || usuario == null)
    {
        Console.WriteLine("Libro o usuario no existe");
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
    static void ListLoansAll() { Console.WriteLine("Listar préstamos"); Console.ReadKey(); }
    static void ListLoansActive() { Console.WriteLine("Préstamos activos"); Console.ReadKey(); }
    static void ListLoansClosed() { Console.WriteLine("Préstamos cerrados"); Console.ReadKey(); }
    static void ViewLoanDetail() { Console.WriteLine("Detalle préstamo"); Console.ReadKey(); }
    static void RegisterReturn() { Console.WriteLine("Registrar devolución"); Console.ReadKey(); }
    static void DeleteLoan() { Console.WriteLine("Eliminar préstamo"); Console.ReadKey(); }

    static void SearchBook() { Console.WriteLine("Buscar libro"); Console.ReadKey(); }
    static void SearchUser() { Console.WriteLine("Buscar usuario"); Console.ReadKey(); }
    static void ReportByUser() { Console.WriteLine("Reporte usuario"); Console.ReadKey(); }
    static void ReportByBook() { Console.WriteLine("Reporte libro"); Console.ReadKey(); }
    static void ReportOverdue() { Console.WriteLine("Vencidos"); Console.ReadKey(); }
    static void ReportSummary() { Console.WriteLine("Resumen"); Console.ReadKey(); }

    static void SaveData() { Console.WriteLine("Datos guardados"); Console.ReadKey(); }
    static void LoadData() { Console.WriteLine("Datos cargados"); Console.ReadKey(); }

    static void ConfirmResetData()
    {
        Console.WriteLine("¿Seguro que desea reiniciar? (S/N)");
        if (Console.ReadLine().ToUpper() == "S")
            Console.WriteLine("Datos reiniciados");

        Console.ReadKey();
    }

    static void ConfirmExitAndSave()
    {
        Console.WriteLine("Saliendo...");
        Console.ReadKey();
    }

    // ==============================
    // TEST
    // ==============================

    static void TestObjects()
    {
        Console.Clear();

        Libro libro1 = new Libro(1, "Prueba", "Autor", 2020, "General");
        Libro libro2 = new Libro(2, "Cien años", "Gabo", 1967, "Novela");

        libroService.AgregarLibro(libro1);
        libroService.AgregarLibro(libro2);

        Console.WriteLine("=== PRUEBA SERVICE ===");
        Console.WriteLine("Total: " + libroService.TotalLibros());
        Console.WriteLine("Disponibles: " + libroService.LibrosDisponibles());

        Console.ReadKey();
    }
}