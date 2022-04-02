
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
            try
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
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'ñ':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':

                    case 'B':
                    case 'C':
                    case 'D':
                    case 'F':
                    case 'G':
                    case 'H':
                    case 'J':
                    case 'K':
                    case 'L':
                    case 'M':
                    case 'N':
                    case 'Ñ':
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                    case 'T':
                    case 'V':
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                        ;
                        Console.WriteLine("\n ES UNA CONSONANTE");
                        break;
                    default:
                        Console.WriteLine("\n ES UNA TECLA ESPECIAL O DE FUNCION");
                        break;
                }
                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine("\n LA TECLA INGRESADA ES INCORRECTA", error);
                Console.ReadKey();
            }
        }
    }
}