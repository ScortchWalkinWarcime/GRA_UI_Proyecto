﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_1
{
    public class Menu_Localizacion1
    {
        public void menu_ProgramasDeLocalización1()
        {
            int opcion;
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("     Menú 2 - Programas de localización" + System.Environment.NewLine);
                Console.WriteLine("1. Mostrar la tabla de senos del 0 al 90");
                Console.WriteLine("2. Mostrar la tabla de cosenos del 0 al 90");
                Console.WriteLine("3. Dados los dos catetos de un triángulo rectángulo, calcule la hipotenusa y el valor de los ángulos menores de 90 grados");
                Console.WriteLine("4. Dados 2 puntos de un recta calcule: " +
                    " \na) El valor de la pendiente" +
                    " \nb) El ángulo de inclinación" +
                    " \nc) Las coordenadas del punto medio.");
                Console.WriteLine("5. Calcular y mostrar las coordenadas (x,y) de la trayectoria de un proyectil en intervalos de tiempo (0.1, 0.2, ...)" +
                    " correspondientes a la altura y velocidad que va alcanzando el proyectil en cada instante, así también mostrar la altura, velocidad y distancia máxima.");
                Console.WriteLine("0. Regresar al menú principal");
                Console.WriteLine("Escribe una opción: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            TablaSenos();
                            break;
                        case 2:
                            Console.Clear();
                            TablaCosenos();
                            break;
                        case 3:
                            Console.Clear();
                            Triangulo();
                            break;
                        case 4:
                            Console.Clear();
                            Recta();
                            break;
                        case 5:
                            Console.Clear();
                            ProgramaProyectil();
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("Presione enter para regresar al menú principal");
                            return;
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

        //Programa 1
        private static void TablaSenos()
        {
            Console.WriteLine("Tabla de Senos (0° a 90°) - Sin Funciones Propias");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Grados\tSeno");

            for (int angulo = 0; angulo <= 90; angulo++)
            {
                double radianes = ConvertirGradosARadianes(angulo); // Convertir grados a radianes
                double seno = CalcularSeno(radianes); // Calcular seno usando serie de Taylor
                Console.WriteLine($"{angulo}\t{seno:F6}"); // Mostrar resultado con 6 decimales
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPresiona Enter para regresar al menú");
        }

        // Función para convertir grados a radianes (usamos aproximación de PI)
        static double ConvertirGradosARadianes(double grados)
        {
            double PI = 3.14159265358979; // Aproximación de PI
            return grados * (PI / 180.0);
        }

        // Función para calcular el seno usando la serie de Taylor
        static double CalcularSeno(double x)
        {
            double resultado = 0;
            int iteraciones = 10; // Número de términos en la serie para mayor precisión

            for (int n = 0; n < iteraciones; n++)
            {
                double termino = Potencia(-1, n) * Potencia(x, 2 * n + 1) / Factorial(2 * n + 1);
                resultado += termino;
            }

            return resultado;
        }

        // Función para calcular la potencia manualmente
        static double Potencia(double baseNum, int exponente)
        {
            double resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }

        // Función para calcular el factorial manualmente
        static double Factorial(int numero)
        {
            double resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;

        }

        //Programa 2
        private static void TablaCosenos()
        {
            Console.WriteLine("Tabla de Cosenos (0° a 90°) - Sin Funciones Propias");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Grados\tCoseno");

            for (int angulo = 0; angulo <= 90; angulo++)
            {
                double radianes = ConvertirGradosARadianes2(angulo); // Convertir grados a radianes
                double coseno = CalcularCoseno(radianes); // Calcular coseno usando serie de Taylor
                Console.WriteLine($"{angulo}\t{coseno:F6}"); // Mostrar resultado con 6 decimales
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPresiona Enter para regresar al menú");
        }

        // Función para convertir grados a radianes (usamos aproximación de PI)
        static double ConvertirGradosARadianes2(double grados)
        {
            double PI = 3.14159265358979; // Aproximación de PI
            return grados * (PI / 180.0);
        }

        // Función para calcular el coseno usando la serie de Taylor
        static double CalcularCoseno(double x)
        {
            double resultado = 0;
            int iteraciones = 10; // Número de términos en la serie para mayor precisión

            for (int n = 0; n < iteraciones; n++)
            {
                double termino = Potencia1(-1, n) * Potencia1(x, 2 * n) / Factorial1(2 * n);
                resultado += termino;
            }

            return resultado;
        }

        // Función para calcular la potencia manualmente
        static double Potencia1(double baseNum, int exponente)
        {
            double resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }

        // Función para calcular el factorial manualmente
        static double Factorial1(int numero)
        {
            double resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        //Programa 3
        private static void Triangulo()
        {
            double cateto1 = ObtenerCateto("Ingrese el valor del primer cateto:");
            double cateto2 = ObtenerCateto("Ingrese el valor del segundo cateto:");

            // Cálculo de la hipotenusa con Pitágoras
            double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            // Cálculo de los ángulos en grados
            double angulo1 = Math.Atan(cateto1 / cateto2) * (180 / Math.PI);
            double angulo2 = 90 - angulo1;

            // Mostrar resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Hipotenusa: {hipotenusa:F6}");
            Console.WriteLine($"Ángulo 1: {angulo1:F6}°");
            Console.WriteLine($"Ángulo 2: {angulo2:F6}°");

            // Dibujar el triángulo en consola
            DibujarTriangulo(cateto1, cateto2);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPresiona Enter para regresar al menú");
        }

        // Método para obtener un cateto con validación
        private static double ObtenerCateto(string mensaje)
        {
            double cateto;
            bool valido;
            do
            {
                Console.WriteLine(mensaje);
                valido = double.TryParse(Console.ReadLine(), out cateto) && cateto > 0;
                if (!valido)
                {
                    Console.WriteLine("Por favor, ingresa un valor válido mayor que 0.");
                }
            } while (!valido);
            return cateto;
        }

        static void DibujarTriangulo(double baseTriangulo, double altura)
        {
            int maxAltura = 15;  // Límite para no desbordar la pantalla
            int maxBase = 30;

            // Escalamos si es muy grande
            double factorEscala = Math.Min(maxAltura / altura, maxBase / baseTriangulo);
            int baseEscalada = (int)(baseTriangulo * factorEscala);
            int alturaEscalada = (int)(altura * factorEscala);

            Console.WriteLine("\nTriángulo Representado en Consola:");

            for (int y = 0; y <= alturaEscalada; y++)
            {
                for (int x = 0; x <= baseEscalada; x++)
                {
                    if (x == 0 || y == alturaEscalada || x == (int)(y * (baseEscalada / (double)alturaEscalada)))
                        Console.Write("*"); // Lados del triángulo
                    else
                        Console.Write(" "); // Espacios vacíos
                }
                Console.WriteLine();
            }
        }

        // Programa 4
        private static void Recta()
        {
            // Solicitar coordenadas del primer punto
            Console.WriteLine("Ingrese la coordenada X del primer punto:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada Y del primer punto:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            // Solicitar coordenadas del segundo punto
            Console.WriteLine("Ingrese la coordenada X del segundo punto:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada Y del segundo punto:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Calcular pendiente
            double pendiente;
            if (x2 - x1 == 0)
            {
                Console.WriteLine("\nLa recta es vertical, la pendiente es infinita.");
                pendiente = double.PositiveInfinity;
            }
            else
            {
                pendiente = (y2 - y1) / (x2 - x1);
                Console.WriteLine($"\nPendiente: {pendiente:F6}");
            }

            // Calcular el ángulo de inclinación
            double angulo;
            if (double.IsInfinity(pendiente))
            {
                angulo = 90; // La inclinación de una recta vertical es 90°
            }
            else
            {
                angulo = Math.Atan(pendiente) * (180 / Math.PI);
            }
            Console.WriteLine($"Ángulo de inclinación: {angulo:F6}°");

            // Calcular punto medio
            double puntoMedioX = (x1 + x2) / 2;
            double puntoMedioY = (y1 + y2) / 2;
            Console.WriteLine($"Punto medio: ({puntoMedioX:F6}, {puntoMedioY:F6})");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPresiona Enter para regresar al menú");
        }

        public void ProgramaProyectil()
        {
            Console.Clear();
            Console.WriteLine("Programa 5: Cálculo de la trayectoria de un proyectil\n");

            // Constante de gravedad
            const double g = 9.81;

            // Pedir datos al usuario con validación
            double v0 = ObtenerDato("Ingrese la velocidad inicial (m/s):");
            double angulo = ObtenerDato("Ingrese el ángulo de lanzamiento (grados):");

            // Convertir ángulo a radianes
            double theta = angulo * Math.PI / 180;

            // Calcular componentes de la velocidad inicial
            double v0x = v0 * Math.Cos(theta);
            double v0y = v0 * Math.Sin(theta);

            // Calcular tiempo total de vuelo
            double tiempoTotal = (2 * v0y) / g;

            // Calcular altura máxima
            double alturaMaxima = (v0y * v0y) / (2 * g);

            // Calcular distancia máxima (alcance)
            double distanciaMaxima = v0x * tiempoTotal;

            Console.WriteLine("\nTrayectoria del proyectil:");

            // Mostrar coordenadas en intervalos de 0.1 segundos
            Console.WriteLine("\nTiempo (s) | X (m)  | Y (m)  | Velocidad (m/s)");
            Console.WriteLine("--------------------------------------------");

            for (double t = 0; t <= tiempoTotal; t += 0.1)
            {
                double x = v0x * t;
                double y = v0y * t - 0.5 * g * t * t;

                if (y < 0) break; // Detener cuando el proyectil toca el suelo

                // Calcular velocidad instantánea
                double vy = v0y - g * t;
                double v = Math.Sqrt(v0x * v0x + vy * vy);

                Console.WriteLine($"{t:F1}       | {x:F2}   | {y:F2}   | {v:F2}");
            }

            // Mostrar valores finales
            Console.WriteLine("\nResultados finales:");
            Console.WriteLine($"Altura máxima alcanzada: {alturaMaxima:F2} m");
            Console.WriteLine($"Distancia máxima recorrida: {distanciaMaxima:F2} m");
            Console.WriteLine($"Tiempo total de vuelo: {tiempoTotal:F2} s");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPresiona Enter para regresar al menú");
        }

        // Método para obtener datos con validación
        private static double ObtenerDato(string mensaje)
        {
            double valor;
            bool valido;
            do
            {
                Console.WriteLine(mensaje);
                valido = double.TryParse(Console.ReadLine(), out valor);
                if (!valido || valor <= 0)
                {
                    Console.WriteLine("Por favor, ingresa un número válido y mayor a 0.");
                }
            } while (!valido || valor <= 0);
            return valor;
        }
    }
}
