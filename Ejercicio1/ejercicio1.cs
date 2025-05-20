// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool esEntero = true;
int num;
string cadena;
int numInvertido = 0;
do{
    Console.WriteLine("Ingrese un número entero mayor que 0");
    cadena = Console.ReadLine();
    esEntero = int.TryParse(cadena, out num);
}while(!esEntero || num <= 0);

while(num != 0){
    int aux = num % 10;
    num = num/10;
    numInvertido = (numInvertido * 10) + aux;
}

Console.WriteLine("El numero invertido es: "+numInvertido);

