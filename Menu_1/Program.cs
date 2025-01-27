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
        Console.Clear();

        int baseX = Console.WindowWidth - 1;
        int baseY = Console.WindowHeight / 2;
        int altura = 10;
        int longitudHorizontal = 5;

        while (baseX > 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int y = 0; y < altura; y++)
            {
                if (baseY - y >= 0)
                {
                    Console.SetCursorPosition(baseX, baseY - y);
                    Console.Write("*");
                    Thread.Sleep(30);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            for (int x = 1; x <= longitudHorizontal; x++)
            {
                if (baseX - x >= 0)
                {
                    Console.SetCursorPosition(baseX - x, baseY - altura);
                    Console.Write("*");
                    Thread.Sleep(30);
                }
            }

            baseX -= longitudHorizontal;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int y = 0; y < altura; y++)
            {
                if (baseY - altura + y < Console.WindowHeight)
                {
                    Console.SetCursorPosition(baseX, baseY - altura + y);
                    Console.Write("*");
                    Thread.Sleep(30);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            for (int x = 1; x <= longitudHorizontal; x++)
            {
                if (baseX - x >= 0)
                {
                    Console.SetCursorPosition(baseX - x, baseY);
                    Console.Write("*");
                    Thread.Sleep(30);
                }
            }

            baseX -= longitudHorizontal;
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPresiona Enter para salir...");
        Console.ReadLine();
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
