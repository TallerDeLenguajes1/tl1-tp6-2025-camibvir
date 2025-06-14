// See https://aka.ms/new-console-template for more information

int opcion, num1, num2, seguir = 1;

while(seguir == 1)
{
    Console.WriteLine("Ingrese el número 1 y el número 2");
    num1 = Convert.ToInt32(Console.ReadLine());
    num2 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Ingrese la operación que desea realizar");
    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");  
    Console.WriteLine("3-Multiplicar"); 
    Console.WriteLine("4-Dividir");  
    
    opcion = Convert.ToInt32(Console.ReadLine());
    
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
                Console.WriteLine($"Resultado: {num1 / (double)num2}");  
            else
                Console.WriteLine("No se puede dividir por cero");
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
    
    Console.WriteLine("¿Desea continuar? (1 = Sí, otro número = No)");
    seguir = Convert.ToInt32(Console.ReadLine());
}