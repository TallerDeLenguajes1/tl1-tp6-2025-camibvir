// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Ingrese una oracion");
string cadena1 = Console.ReadLine()!;
int longitud = cadena1.Length;
Console.WriteLine($"La longitud es:{longitud}");

Console.WriteLine("Ingrese una segunda cadena");
string cadena2 = Console.ReadLine()!;
string concat1 = cadena1 + cadena2;
Console.WriteLine($"La primera forma de concatenar: {concat1}");

string concat2 = string.Concat( cadena1, cadena2);
Console.WriteLine($"Otra forma de concatenar: {concat2}"); 

string subcadena = concat1.Substring(2,3);
Console.WriteLine($"Una subcadena: {subcadena}");

foreach (char letra in cadena1)
    {
        Console.WriteLine(letra);
    }
Console.WriteLine("Ingrese una tercera cadena");
string cadena3 = Console.ReadLine()!;
Console.WriteLine($"Mayúsculas: {cadena3.ToUpper()}");
Console.WriteLine($"Minúsculas: {cadena3.ToLower()}");

Console.WriteLine("Ingrese una cuarta cadena");
string cadena4 = Console.ReadLine()!;
Console.WriteLine("Ingrese separador (ej. , / -): ");
char separador = Console.ReadLine()![0];
string[] partes = cadena4.Split(separador);
Console.WriteLine("Partes separadas:");
foreach (string parte in partes)
{
    Console.WriteLine($"- {parte}");
}

Console.Write("\nIngresa una operación (ej. 8+2): ");
        string ecuacion = Console.ReadLine();
        char operador = ' ';
        if (ecuacion.Contains("+")) operador = '+';
        else if (ecuacion.Contains("-")) operador = '-';
        else if (ecuacion.Contains("*")) operador = '*';
        else if (ecuacion.Contains("/")) operador = '/';
        else
        {
            Console.WriteLine("¡Solo puedes usar +, -, *, / !");
            return;
        }
        string[] numeros = ecuacion.Split(operador);
        if (numeros.Length != 2)
        {
            Console.WriteLine("Debes ingresar exactamente DOS números");
            return;
        }
        double num1, num2;
        if (!double.TryParse(numeros[0], out num1) || !double.TryParse(numeros[1], out num2))
        {
            Console.WriteLine("Los numeros no son válidos");
            return;
        }
        double resultado = 0;
        switch (operador)
        {
            case '+': resultado = num1 + num2; break;
            case '-': resultado = num1 - num2; break;
            case '*': resultado = num1 * num2; break;
            case '/': 
                if (num2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre cero");
                    return;
                }
                resultado = num1 / num2; 
                break;
        }
        
        Console.WriteLine($"Resultado: {resultado}");
    