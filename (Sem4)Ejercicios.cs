using System;
class Program
{
    static double CalculaArea(double baseR, double alturaR)
    //static permite iniciar desde ya, double es para decimales
{
    double area = baseR * alturaR;
    //lo que tiene que hacer la función
    return area;
    //lo que me tiene que devolver
}

static void Main()
//void es porque este dato no llegará a otras funciones
//main es la operación principal
{
    Console.WriteLine("Ingresa la base del rectángulo: ");
    //writeline para imprimir lo que el usuario debe ver
    double baseR = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingresa la altura del rectángulo: ");
    //readline lee la info, pero solo puede leer como texto
    //va acompañada de parse para que ese "texto" se convierta en n°s y  puedan operarse
    double alturaR = double.Parse(Console.ReadLine());

    double rpta = CalculaArea(baseR, alturaR);
    //en el paréntesis van los parámetros para descubrir el área

    Console.WriteLine($"El área del rectángulo es: {rpta}");
    //imprimo la respuesta
}
}
