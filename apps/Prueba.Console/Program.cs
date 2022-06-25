//import
using Prueba.Application.Figures.CalculateAreaCircle;
using Prueba.Application.Figures.CalculateAreaSquare;

//variables
CalculateAreaSquareHandler calculateAreaSquareHandler = new();
CalculateAreaCircleHandler calculateAreaCircleHandler = new();
bool sequir = true;
int caso;

//metodos
int GetCaso()
{
    string caso = Console.ReadLine();
    if (caso is "")
        throw new Exception("seleccion invalida");

    return int.Parse(caso);
}

void CalculateAreaSquare()
{
    Console.WriteLine($"ingrese altura y luego la base");
    string altura = Console.ReadLine();
    string @base = Console.ReadLine();

    if (altura is "")
        throw new Exception("valor invalido");
    else if(@base is "")
        throw new Exception("valor invalido");

    try
    {
        var resultado = calculateAreaSquareHandler.Handler(
            altura: int.Parse(altura),
            @base: int.Parse(@base));

        Console.WriteLine($"el area es: { resultado}");
    }
    catch (Exception e)
    {
        Console.Error.WriteLine(e.Message);
    }
}

void CalculateAreaCircle()
{
    Console.WriteLine($"ingrese el radio");
    string radio = Console.ReadLine();

    if (radio is "")
        throw new Exception("valor invalido");

    try
    {
        double resultado = calculateAreaCircleHandler.Handler(
            radio: int.Parse(radio));

        Console.WriteLine($"el area es: { resultado}");
    }
    catch (Exception e)
    {
        Console.Error.WriteLine(e.Message);
    }
}

//programa
do
{
    Console.WriteLine("ingrese 1 para calcular area cuadro, " +
        "2 para cualcular area circulo" +
        "3 para salir.");
    

    caso = GetCaso();
    switch (caso)
    {
        case 1:
            CalculateAreaSquare();
            break;

        case 2:
            CalculateAreaCircle();
            break;

        case 3:
            Console.WriteLine("finalizo el programa");
            sequir = false;
            break;

        default:
            Console.Error.WriteLine("seleccion invalida");
            break;
    }

} while (sequir);
