using System;
using CalculadoraHistorial;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        string? opcion;

        do
        {
            Interfaz(calc);
            Console.WriteLine("Opcion: ");
            opcion = Console.ReadLine();
            if (opcion is "1" or "2" or "3" or "4")
            {
                Console.WriteLine("Ingrese un numero");
                string? numero = Console.ReadLine();
                bool resultNum = double.TryParse(numero, out double valor);
                if (!resultNum)
                {
                    Console.WriteLine("Numero invalido. Debe ser un numero.");
                    continue;
                }
                if (opcion == "4" && valor == 0)
                {
                    Console.WriteLine("No se puede dividir entre 0.");
                    continue;
                }
                var tipo = opcion switch
                {
                    "1" => Operacion.TipoOperacion.Suma,
                    "2" => Operacion.TipoOperacion.Resta,
                    "3" => Operacion.TipoOperacion.Multiplicacion,
                    "4" => Operacion.TipoOperacion.Division,
                    _ => Operacion.TipoOperacion.limpiar
                };
                calc.EjecutarOperacion(valor, tipo);
            }
            else if (opcion == "5")
            {
                calc.Limpiar();
                Console.WriteLine("Resultado Limpiado");
            }
            else if (opcion == "6")
            {
                calc.MostrarHistorial();
            }
        } while (opcion != "0");
        Console.WriteLine("- - - Programa Finalizado - - -");
    }

    private static void Interfaz(Calculadora calc)
    {
        Console.WriteLine($"- - > Resultado actual: {calc.Resultado} < - -");
        Console.WriteLine("Seleccione una opcion: ");
        Console.WriteLine("1_ Suma");
        Console.WriteLine("2_ Resta");
        Console.WriteLine("3_ Multiplicacion");
        Console.WriteLine("4_ Division");
        Console.WriteLine("5_ Limpiar");
        Console.WriteLine("6_ Ver Historial");
        Console.WriteLine("0_ Salir");
    }
}