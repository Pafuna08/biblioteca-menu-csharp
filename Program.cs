using System;

class Program
{
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

    // ==============================
    // MENÚ REPORTES
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
    // FUNCIONES LIBROS
    // ==============================

    static void RegisterBook()
    {
        Console.WriteLine("Función RegisterBook ejecutada");
        Console.ReadKey();
    }

    static void ListBooksMenu()
    {
        Console.WriteLine("Función ListBooksMenu ejecutada");
        Console.ReadKey();
    }

    static void ListBooksAll()
    {
        Console.WriteLine("Función ListBooksAll ejecutada");
        Console.ReadKey();
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("Función ListBooksAvailable ejecutada");
        Console.ReadKey();
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("Función ListBooksBorrowed ejecutada");
        Console.ReadKey();
    }

    static void ViewBookDetail()
    {
        Console.WriteLine("Función ViewBookDetail ejecutada");
        Console.ReadKey();
    }

    static void UpdateBookMenu()
    {
        Console.WriteLine("Función UpdateBookMenu ejecutada");
        Console.ReadKey();
    }

    static void EditBookTitle()
    {
        Console.WriteLine("Función EditBookTitle ejecutada");
        Console.ReadKey();
    }

    static void EditBookAuthor()
    {
        Console.WriteLine("Función EditBookAuthor ejecutada");
        Console.ReadKey();
    }

    static void EditBookYearCategory()
    {
        Console.WriteLine("Función EditBookYearCategory ejecutada");
        Console.ReadKey();
    }

    static void DeleteBook()
    {
        Console.WriteLine("Función DeleteBook ejecutada");
        Console.ReadKey();
    }

    // ==============================
    // FUNCIONES USUARIOS
    // ==============================

    static void RegisterUser()
    {
        Console.WriteLine("Función RegisterUser ejecutada");
        Console.ReadKey();
    }

    static void ListUsers()
    {
        Console.WriteLine("Función ListUsers ejecutada");
        Console.ReadKey();
    }

    static void ViewUserDetail()
    {
        Console.WriteLine("Función ViewUserDetail ejecutada");
        Console.ReadKey();
    }

    static void UpdateUserMenu()
    {
        Console.WriteLine("Función UpdateUserMenu ejecutada");
        Console.ReadKey();
    }

    static void EditUserName()
    {
        Console.WriteLine("Función EditUserName ejecutada");
        Console.ReadKey();
    }

    static void EditUserContact()
    {
        Console.WriteLine("Función EditUserContact ejecutada");
        Console.ReadKey();
    }

    static void ToggleUserActiveStatus()
    {
        Console.WriteLine("Función ToggleUserActiveStatus ejecutada");
        Console.ReadKey();
    }

    static void DeleteUser()
    {
        Console.WriteLine("Función DeleteUser ejecutada");
        Console.ReadKey();
    }

    // ==============================
    // FUNCIONES PRÉSTAMOS
    // ==============================

    static void CreateLoan()
    {
        Console.WriteLine("Función CreateLoan ejecutada");
        Console.ReadKey();
    }

    static void ListLoansMenu()
    {
        Console.WriteLine("Función ListLoansMenu ejecutada");
        Console.ReadKey();
    }

    static void ListLoansAll()
    {
        Console.WriteLine("Función ListLoansAll ejecutada");
        Console.ReadKey();
    }

    static void ListLoansActive()
    {
        Console.WriteLine("Función ListLoansActive ejecutada");
        Console.ReadKey();
    }

    static void ListLoansClosed()
    {
        Console.WriteLine("Función ListLoansClosed ejecutada");
        Console.ReadKey();
    }

    static void ViewLoanDetail()
    {
        Console.WriteLine("Función ViewLoanDetail ejecutada");
        Console.ReadKey();
    }

    static void RegisterReturn()
    {
        Console.WriteLine("Función RegisterReturn ejecutada");
        Console.ReadKey();
    }

    static void DeleteLoan()
    {
        Console.WriteLine("Función DeleteLoan ejecutada");
        Console.ReadKey();
    }

    // ==============================
    // FUNCIONES REPORTES
    // ==============================

    static void SearchBook()
    {
        Console.WriteLine("Función SearchBook ejecutada");
        Console.ReadKey();
    }

    static void SearchUser()
    {
        Console.WriteLine("Función SearchUser ejecutada");
        Console.ReadKey();
    }

    static void ShowReportsMenu()
    {
        Console.WriteLine("Función ShowReportsMenu ejecutada");
        Console.ReadKey();
    }

    static void ReportByUser()
    {
        Console.WriteLine("Función ReportByUser ejecutada");
        Console.ReadKey();
    }

    static void ReportByBook()
    {
        Console.WriteLine("Función ReportByBook ejecutada");
        Console.ReadKey();
    }

    static void ReportOverdue()
    {
        Console.WriteLine("Función ReportOverdue ejecutada");
        Console.ReadKey();
    }

    static void ReportSummary()
    {
        Console.WriteLine("Función ReportSummary ejecutada");
        Console.ReadKey();
    }

    // ==============================
    // FUNCIONES PERSISTENCIA
    // ==============================

    static void SaveData()
    {
        Console.WriteLine("Función SaveData ejecutada");
        Console.ReadKey();
    }

    static void LoadData()
    {
        Console.WriteLine("Función LoadData ejecutada");
        Console.ReadKey();
    }

    static void ResetData()
    {
        Console.WriteLine("Función ResetData ejecutada");
        Console.ReadKey();
    }

    static void ConfirmResetData()
    {
        Console.WriteLine("Función ConfirmResetData ejecutada");
        Console.ReadKey();
    }

    // ==============================
    // SALIDA
    // ==============================

    static void ConfirmExitAndSave()
    {
        Console.WriteLine("Saliendo del sistema...");
        Console.ReadKey();
    }
}