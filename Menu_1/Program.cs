internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Gráfica de barras");
            Console.WriteLine("2. Espiral giratoria de asteriscos");
            Console.WriteLine("3. Salir");

            ConsoleKeyInfo opcion = Console.ReadKey();

            if (opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1)
            {
                GraficaColumnas();
            }
            else if (opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2)
            {
                Rectangulos();
            }
            else if (opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3)
            {
                break;
            }
        }
    }

    static void GraficaColumnas()
    {
        int[] valores = { 5, 3, 7, 4 };
        int anchoBarra = 5;
        int espacioEntreBarras = 2;

        int anchoTotal = valores.Length * (anchoBarra + espacioEntreBarras) - espacioEntreBarras;
        int margenIzquierdo = (Console.WindowWidth - anchoTotal) / 2;

        for (int i = 0; i < valores.Length; i++)
        {
            Console.SetCursorPosition(margenIzquierdo + i * (anchoBarra + espacioEntreBarras), Console.CursorTop);

            for (int j = 0; j < anchoBarra; j++)
            {
                Console.Write("*");
            }

            for (int j = 0; j < valores[i]; j++)
            {
                Console.SetCursorPosition(Console.CursorLeft - anchoBarra + 1, Console.CursorTop - 1);
                for (int k = 0; k < anchoBarra; k++)
                {
                    Console.Write("*");
                }
            }
        }
    }

    private static void Rectangulos()
    {
        int ancho = Console.WindowWidth;
        int alto = Console.WindowHeight;

        int inicioX = ancho / 2;
        int inicioY = alto / 2;

        int paso = 2;
        int limite = Math.Min(ancho, alto) / 2 - paso;

        Console.Clear();

        for (int nivel = 0; nivel <= limite; nivel += paso)
        {
            ConsoleColor color = ObtenerColor(nivel / paso % 4);
            Console.ForegroundColor = color;

            for (int x = inicioX - nivel; x <= inicioX + nivel; x++)
            {
                Console.SetCursorPosition(x, inicioY - nivel);
                Console.Write("*");
                Thread.Sleep(10);
            }

            for (int y = inicioY - nivel + 1; y <= inicioY + nivel; y++)
            {
                Console.SetCursorPosition(inicioX + nivel, y);
                Console.Write("*");
                Thread.Sleep(10);
            }

            for (int x = inicioX + nivel - 1; x >= inicioX - nivel; x--)
            {
                Console.SetCursorPosition(x, inicioY + nivel);
                Console.Write("*");
                Thread.Sleep(10);
            }

            for (int y = inicioY + nivel - 1; y > inicioY - nivel; y--)
            {
                Console.SetCursorPosition(inicioX - nivel, y);
                Console.Write("*");
                Thread.Sleep(10);
            }
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(0, alto - 1);
        Console.WriteLine("\nPresiona Enter para salir...");
        Console.ReadLine();
    }

    static ConsoleColor ObtenerColor(int indice)
    {
        return indice switch
        {
            0 => ConsoleColor.Red,
            1 => ConsoleColor.Green,
            2 => ConsoleColor.Blue,
            3 => ConsoleColor.Yellow,
            _ => ConsoleColor.White,
        };
    }
}
