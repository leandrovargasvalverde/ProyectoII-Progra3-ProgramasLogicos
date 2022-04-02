
/*UNIVERSIDAD CASTRO CARAZO - PROGRAMACION III
GRUPO #2
EJERCICIO 7 PROYECTO II

DESCRIPCION:
Elabore un programa que genere un número aleatorio y que les dé la posibilidad a dos jugadores de adivinar dicho número, 
el algoritmo debe intercalar los turnos para adivinar y mostrar el ganador final. El número debe estar entre 0-10*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" Bienvenido al juego de Adivinar un Número del 0 al 10");
                Console.Write("\n Nombre del Jugador 1: ");
                string player1 = Console.ReadLine();
                Console.Write("\n Nombre del Jugador 2: ");
                string player2 = Console.ReadLine();
                Console.Write($"\n Jugador 1: {player1} Introduzca un número entre 0 y 10: ");
                int nIntroducido = Int32.Parse(Console.ReadLine());
                Random numero = new Random();
                int numeroAleatorio = numero.Next(0, 10);
                while (nIntroducido != numeroAleatorio)
                {
                    Console.WriteLine($"\n El Jugador 1: {player1} no adivinó el número");
                    Console.Write($"\n Jugador 2: {player2} Introduzca un número entre 0 y 10: ");
                    int nIntroducido2 = Int32.Parse(Console.ReadLine());
                    if (nIntroducido2 != numeroAleatorio)
                    {
                        Console.WriteLine($"\n El Jugador 2: {player2} no adivinó el número");
                        Console.Write($"\n Jugador 1: {player1} Introduzca un número entre 0 y 10: ");
                        int nIntroducido3 = int.Parse(Console.ReadLine());
                        if (nIntroducido3 == numeroAleatorio)
                        {
                            Console.WriteLine($"\n El jugador 1: {player1} ha adivinado el número");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else if (nIntroducido2 == numeroAleatorio)
                    {
                        Console.WriteLine($"\n El Jugador 2: {player2} ha adivinado el número");
                        Console.ReadKey();
                        break;
                    }
                }
                if (nIntroducido == numeroAleatorio)
                {
                    Console.WriteLine($"\n El Jugador 1: {player1} ha adivinado el número");
                    Console.ReadKey();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("\n El digito que ha ingresado es incorrecto", error);
                Console.ReadKey();
            }         
        }
    }
}