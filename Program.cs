using System;

// Mostrar mensaje de bienvenida
Console.WriteLine("Bienvenido al sistema de control de producción de textiles de la empresa Textilerias Aguirre.");

// Solicitar los datos del producto
Console.Write("Ingrese el código del producto: ");
string codigo = Console.ReadLine() ?? "";

Console.Write("Ingrese el nombre del producto: ");
string nombre = Console.ReadLine() ?? "";

Console.Write("Ingrese el color del producto: ");
string color = Console.ReadLine() ?? "";

Console.Write("Ingrese la talla del producto: ");
string talla = Console.ReadLine() ?? "";

// Solicitar la cantidad programada
int cantidadProgramada;
while (true)
{
    Console.Write("Ingrese la cantidad programada de unidades: ");
    if (int.TryParse(Console.ReadLine(), out cantidadProgramada) && cantidadProgramada >= 0)
        break;

    Console.WriteLine("Error: ingrese un número entero mayor o igual a cero.");
}

// Solicitar las unidades producidas
int cantidadProducida;
while (true)
{
    Console.Write("Ingrese la cantidad de unidades producidas: ");
    if (int.TryParse(Console.ReadLine(), out cantidadProducida) && cantidadProducida >= 0)
        break;

    Console.WriteLine("Error: ingrese un número entero mayor o igual a cero.");
}

// Solicitar las unidades defectuosas
int cantidadDefectuosa;
while (true)
{
    Console.Write("Ingrese la cantidad de unidades defectuosas: ");
    if (int.TryParse(Console.ReadLine(), out cantidadDefectuosa) &&
        cantidadDefectuosa >= 0 &&
        cantidadDefectuosa <= cantidadProducida)
        break;

    Console.WriteLine("Error: ingrese un número válido que no supere las unidades producidas.");
}