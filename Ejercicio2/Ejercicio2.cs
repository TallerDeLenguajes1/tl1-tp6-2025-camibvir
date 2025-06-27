// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        int opcion, seguir = 1;
        float num1, num2, num3, num4, num5;

        while(seguir == 1)
        {
            Console.WriteLine("Ingrese el número 1 y el número 2");
            while(!float.TryParse(Console.ReadLine(), out num1))
                Console.WriteLine("Entrada inválida. Ingrese número 1 nuevamente:");
            
            while(!float.TryParse(Console.ReadLine(), out num2))
                Console.WriteLine("Entrada inválida. Ingrese número 2 nuevamente:");
            Console.WriteLine("Ingrese la operación que desea realizar");
            Console.WriteLine("1-Sumar");
            Console.WriteLine("2-Restar");  
            Console.WriteLine("3-Multiplicar"); 
            Console.WriteLine("4-Dividir");  

            while(!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
                Console.WriteLine("Opción inválida. Ingrese 1-4:");

            switch(opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {num1 * num2}");
                    break;
                case 4:
                    if(num2 != 0)
                        Console.WriteLine($"Resultado: {num1 / num2:F4}");  
                    else
                        Console.WriteLine("No se puede dividir por cero");
                    break;
            }
            Console.WriteLine("Ingrese un número para operaciones avanzadas");
            while(!float.TryParse(Console.ReadLine(), out num3))
                Console.WriteLine("Entrada inválida. Ingrese un número:");

            Console.WriteLine($"Valor absoluto: {Math.Abs(num3)}");
            Console.WriteLine($"Cuadrado: {num3 * num3}");
            if(num3 >= 0)
                Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(num3)}");
            else
                Console.WriteLine("No existe raíz cuadrada real de números negativos");
            Console.WriteLine($"Coseno: {Math.Cos(num3)}");
            Console.WriteLine($"Seno: {Math.Sin(num3)}");
            Console.WriteLine($"Parte entera: {(int)num3}");

            Console.WriteLine("Ingrese dos números para max y min");
            while(!float.TryParse(Console.ReadLine(), out num4))
                Console.WriteLine("Entrada invalida. Ingrese el numero");

            while(!float.TryParse(Console.ReadLine(), out num5))
                Console.WriteLine("Entrada invalida. Ingrese el numero");
            
            float minimo = Math.Min(num4, num5);
            float maximo = Math.Max(num4, num5);

            Console.WriteLine($"Mínimo: {minimo}");
            Console.WriteLine($"Máximo: {maximo}");

            Console.WriteLine("¿Desea continuar? (1 = Sí, otro número = No)");
            int.TryParse(Console.ReadLine(), out seguir);
        }
    }
}