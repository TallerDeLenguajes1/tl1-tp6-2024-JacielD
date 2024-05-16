using System;

class Program
{
    static void Main()
    {
        int a;
        int opc;

        Console.WriteLine("Ingrese un número:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la operación que desea realizar:");
        Console.WriteLine("1: Valor absoluto");
        Console.WriteLine("2: El cuadrado");
        Console.WriteLine("3: La raíz cuadrada");
        Console.WriteLine("4: El Seno");
        Console.WriteLine("5: El Coseno");
        Console.WriteLine("6: La parte entera de un float");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine($"El valor absoluto de {a} es: {Math.Abs(a)}");
                break;
            case 2:
                Console.WriteLine($"El cuadrado de {a} es: {a * a}");
                break;
            case 3:
                Console.WriteLine($"La raíz cuadrada de {a} es: {Math.Sqrt(a)}");
                break;
            case 4:
                Console.WriteLine($"El seno de {a} es: {Math.Sin(a)}");
                break;
            case 5:
                Console.WriteLine($"El coseno de {a} es: {Math.Cos(a)}");
                break;
            case 6:
                Console.WriteLine($"La parte entera de {a} es: {Convert.ToInt32(a)}");
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una operación válida.");
                break;
        }
    }
}