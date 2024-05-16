using System;

namespace CalculatorProgram
{
    class Program
    {
        static void Main()
        {
            int a;
            int b;
            int operacion;
            int resultado;
            int repetir;
            do
            {
                Console.WriteLine("Ingrese el primer valor: ");
                a = Console.Read();
                Console.WriteLine("Ingrese el segundo valor:");
                b = Console.Read();
                Console.WriteLine("Ingrese la operación que desea realizar:\n1 para sumar\n2 para restar\n3 para multiplicar\n4 para dividir");
                operacion = Console.Read();
                switch (operacion)
                {
                    case 1:
                        resultado = a + b;
                        break;
                    case 2:
                        resultado = a - b;
                        break;
                    case 3:
                        resultado = a * b;
                        break;
                    case 4:
                        resultado = a / b;
                        break;
                    default:
                        Console.WriteLine("Operación no válida.");
                        resultado = 0;
                        break;
                }

                Console.WriteLine("El resultado de su operación es: " + resultado);
                Console.WriteLine("¿Quiere realizar otra operación?\n1: Sí\n0: No");
                repetir = Console.Read();
            } while (repetir == 1);
        }
    }
}