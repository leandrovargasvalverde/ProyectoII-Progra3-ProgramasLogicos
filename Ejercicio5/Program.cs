
/*UNIVERSIDAD CASTRO CARAZO - PROGRAMACION III
GRUPO #2
EJERCICIO 5 PROYECTO II

DESCRIPCION:
Crear un programa que pida números positivos al usuario,
y vaya calculando la suma de todos ellos (terminará cuando se teclea un número negativo o cero).*/

using System;

namespace Ejercicio_5_Proyecto_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero = 1;
                int suma = 0;

                while (numero > 0)
                {
                    Console.Write(" Digite un numero positivo: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero > 0)
                    {
                        suma = suma + numero;
                    }
                }
                Console.WriteLine("\n El resultado de la suma es: " + suma);
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