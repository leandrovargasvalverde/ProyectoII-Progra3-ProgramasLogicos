
/*UNIVERSIDAD CASTRO CARAZO - PROGRAMACION III
GRUPO #2
EJERCICIO 3 PROYECTO II

DESCRIPCION:
El usuario debe ingresar dos números y el programa mostrará el resultado de la operación (a+b)*(a-b).*/

using System;

namespace Ejercicio_3_Proyecto_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ingresoNumero;
                int Num1, Num2, Suma, Resta, Multiplicacion;
                Console.Write("\n Digite el primer numero: ");
                ingresoNumero = Console.ReadLine();
                Num1 = int.Parse(ingresoNumero);
                Console.Write("\n Digite el segundo numero: ");
                ingresoNumero = Console.ReadLine();
                Num2 = int.Parse(ingresoNumero);
                Suma = Num1 + Num2;
                Resta = Num1 - Num2;
                Multiplicacion = Suma * Resta;
                Console.WriteLine("\n Numeros Sumados: " + Suma);
                Console.WriteLine("\n Numeros Restados: " + Resta);
                Console.WriteLine("\n El resultado de la operación (a+b)*(a-b) es: " + Multiplicacion);
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