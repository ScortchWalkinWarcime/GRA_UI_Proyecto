using Menu_1;

public class Program
{
    public static void Main(string[] args)
    {
        int opcion;
        bool continuar = true;
        Menu_Introduction Menu1 = new Menu_Introduction();
        Menu_Localizacion1 Menu2 = new Menu_Localizacion1();
        do
        {
            Console.Clear();
            Console.WriteLine("     Menú Principal" + System.Environment.NewLine);
            Console.WriteLine("1. Menú 1 - Programas de introducción");
            Console.WriteLine("2. Menú 2 - Programas de localización");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Escribe una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Menu1.menu_ProgramasDeIntroducción();
                        break;
                    case 2:
                        Console.Clear();
                        Menu2.menu_ProgramasDeLocalización1();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("BYE BYE");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no permitida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingresa una opción válida");
            }
            Console.ReadKey();
        } while (continuar != false);
    }
}