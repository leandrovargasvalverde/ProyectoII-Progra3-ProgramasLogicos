
/*UNIVERSIDAD CASTRO CARAZO - PROGRAMACION III
GRUPO #2
EJERCICIO 3 PROYECTO II

DESCRIPCION:
El usuario debe ingresar dos números y el programa mostrará el resultado de la operación (a+b)*(a-b).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ingresoNumero;
            int Num1,Num2, Suma, Resta, Multiplicacion;
            Console.Write("\n Digite el primer numero: ");
            ingresoNumero = Console.ReadLine();
            Num1 = int.Parse(ingresoNumero);
            Console.Write("\n Digite el segundo numero: ");
            ingresoNumero = Console.ReadLine();
            Num2 = int.Parse(ingresoNumero);
            Suma = Num1 + Num2;
            Resta = Num1 - Num2;
            Multiplicacion = Suma * Resta;
            Console.WriteLine("\n Suma: " + Suma);
            Console.WriteLine("\n Resta: " + Resta);
            Console.WriteLine("\n El resultado el resultado de la operación (a+b)*(a-b) es: " + Multiplicacion);
            Console.ReadKey();
        }
    }
}