
/*UNIVERSIDAD CASTRO CARAZO - PROGRAMACION III
GRUPO #2
EJERCICIO 4 PROYECTO II

DESCRIPCION:
Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, una cifra numérica 
o una consonante (pista: habrá que usar un dato de tipo "char").*/

using System;

namespace Ejercicio_4_Proyecto_II
{
    public class Program
    {
        static void Main(string[] args)
        {
            char TECLA;
            string linea;
            Console.Write("\n DIGITE UNA SOLA TECLA  ");

            linea = Console.ReadLine();
            TECLA = char.Parse(linea);
            switch (TECLA)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    ;
                    Console.WriteLine("\n ES UNA CIFRA NUMÉRICA");
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    ;
                    Console.WriteLine("\n ES UNA VOCAL");
                    break;
                default:
                    Console.WriteLine("\n ES UNA CONSONANTE");
                    break;
            }
            Console.ReadKey();
        }
    }
}