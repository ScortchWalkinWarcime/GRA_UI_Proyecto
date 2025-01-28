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
        int baseY = (Console.WindowHeight / 2) + 5; 
        int altura = 13; 
        int longitudHorizontal = 6; 

        while (baseX > 0)
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int y = 0; y < altura; y++)
            {
                if (baseY - y >= 0)
                {
                    Console.SetCursorPosition(baseX, baseY - y);
                    Console.Write("*");
                    Thread.Sleep(20);
                }
            }

         
            Console.SetCursorPosition(baseX, baseY - altura);
            Console.Write("*");

            
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int x = 1; x <= longitudHorizontal; x++)
            {
                if (baseX - x >= 0)
                {
                    Console.SetCursorPosition(baseX - x, baseY - altura);
                    Console.Write("*");
                    Thread.Sleep(20);
                }
            }

            baseX -= longitudHorizontal;

            
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int y = 0; y < altura; y++)
            {
                if (baseY - altura + y < Console.WindowHeight)
                {
                    Console.SetCursorPosition(baseX, baseY - altura + y);
                    Console.Write("*");
                    Thread.Sleep(20);
                }
            }

      
            Console.SetCursorPosition(baseX, baseY);
            Console.Write("*");

          
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int x = 1; x <= longitudHorizontal; x++)
            {
                if (baseX - x >= 0)
                {
                    Console.SetCursorPosition(baseX - x, baseY);
                    Console.Write("*");
                    Thread.Sleep(20);
                }
            }

            baseX -= longitudHorizontal;
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(0, Console.WindowHeight - 1);
        Console.WriteLine("Presiona Enter para salir...");
        Console.ReadLine();
    }


    private static void Rectangulos()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(40, 4);
        Console.WriteLine("Dibujando gráfica...\n");

        int x = 55, y = 17;
        int paso;
        int direccion = 2;
        int espacioHorizontal = 1;
        int espacioVertical = 1;

        Random random = new Random();

        var direcciones = new (int dx, int dy)[]
        {
        (1, 0),
        (0, 1),
        (-1, 0),
        (0, -1)
        };

        int[] pasosPorDireccion = { 4, 2, 9, 4, 14, 6, 19, 8, 24, 10, 29, 12, 34, 14, 39, 16, 44, 18 };
        direccion = 2;

        for (int i = 0; i < pasosPorDireccion.Length; i++)
        {
            paso = pasosPorDireccion[i];

            for (int j = 0; j < paso; j++)
            {
                Console.SetCursorPosition(x, y);
                CambiarColor(random);
                Console.Write("*");
                Thread.Sleep(100);

                x += direcciones[direccion].dx * espacioHorizontal;
                y += direcciones[direccion].dy * espacioVertical;
            }

            direccion = (direccion + 1) % 4;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(40, 4);
        Console.WriteLine("\nPresiona Enter para salir...");
        Console.ReadLine();
    }

    private static void CambiarColor(Random random)
    {
        Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
    }



}
