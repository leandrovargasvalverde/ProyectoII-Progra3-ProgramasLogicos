
/*UNIVERSIDAD CASTRO CARAZO - PROGRAMACION III
GRUPO #2
EJERCICIO 2 PROYECTO II

DESCRIPCION:
Un algoritmo que invierta los valores de un entero de 2 digitos, por ejemplo si recibi 45 se debe imprimir 54.*/

using System;

namespace Ejercicio_2_Proyecto_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ingresoNumero;
                int Num, Decimal, Uni, Operacion;
                Console.Write("\n Digite un numero de 2 digitos: ");
                ingresoNumero = Console.ReadLine();
                Num = int.Parse(ingresoNumero);
                Decimal = Num / 10;
                Uni = Num % 10;
                Operacion = (Uni * 10) + Decimal;
                Console.WriteLine("\n El numero que digito invertido es: " + Operacion);
                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine("\n El digito ingresado es incorrecto", error);
                Console.ReadKey();
            }

        }
    }
}