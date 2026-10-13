
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
    if (int.TryParse(Console.ReadLine(), out cantidadProgramada) && cantidadProgramada > 0)
        break;

    Console.WriteLine("Error: ingrese un número entero mayor que cero.");
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

// Calcular las unidades aceptadas
int cantidadAceptada = cantidadProducida - cantidadDefectuosa;

// Calcular las unidades pendientes
int cantidadPendiente = cantidadProgramada - cantidadProducida;

// Calcular el porcentaje de cumplimiento
double porcentajeCumplimiento = 0;

if (cantidadProgramada > 0)
{
    porcentajeCumplimiento = (double)cantidadProducida / cantidadProgramada * 100;
}

// Determinar el estado de la producción
string estadoProduccion;

if (cantidadProducida >= cantidadProgramada)
{
    estadoProduccion = "PRODUCCIÓN COMPLETADA";
}
else
{
    estadoProduccion = "PRODUCCIÓN PENDIENTE";
}

//Mostrar los datos del producto y el estado de la producción
Console.WriteLine("\n--- Resumen de Producción ---");
Console.WriteLine($"Código: {codigo}");
Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Color: {color}");
Console.WriteLine($"Talla: {talla}");

Console.WriteLine($"Cantidad Programada: {cantidadProgramada}");
Console.WriteLine($"Cantidad Producida: {cantidadProducida}");
Console.WriteLine($"Cantidad Defectuosa: {cantidadDefectuosa}");
Console.WriteLine($"Cantidad Aceptada: {cantidadAceptada}");
Console.WriteLine($"Cantidad Pendiente: {cantidadPendiente}");

Console.WriteLine($"Porcentaje de Cumplimiento: {porcentajeCumplimiento:F2}%");
Console.WriteLine($"Estado de la Producción: {estadoProduccion}");