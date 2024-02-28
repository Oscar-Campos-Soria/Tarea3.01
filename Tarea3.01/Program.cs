using System;

namespace Tarea3._01
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();

            bool continuar = true;
            while (continuar)
            {
                Console.Write("\nSeleccione una opción (1-6): ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Sumar();
                        break;
                    case "2":
                        Restar();
                        break;
                    case "3":
                        Multiplicar();
                        break;
                    case "4":
                        Dividir();
                        break;
                    case "5":
                        Potencia();
                        break;
                    case "6":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 6.");
                        break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Bienvenido a la calculadora:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Salir");
        }

        static void Sumar()
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = num1 + num2;
            Console.WriteLine($"El resultado de la suma es: {resultado}");
        }

        static void Restar()
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = num1 - num2;
            Console.WriteLine($"El resultado de la resta es: {resultado}");
        }

        static void Multiplicar()
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = num1 * num2;
            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        }

        static void Dividir()
        {
            Console.Write("Ingrese el dividendo: ");
            double dividendo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor != 0)
            {
                double resultado = dividendo / divisor;
                Console.WriteLine($"El resultado de la división es: {resultado}");
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
        }

        static void Potencia()
        {
            Console.Write("Ingrese la base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            double exponente = Convert.ToDouble(Console.ReadLine());
            double resultado = Math.Pow(baseNum, exponente);
            Console.WriteLine($"El resultado de la potencia es: {resultado}");
        }
    }
}
