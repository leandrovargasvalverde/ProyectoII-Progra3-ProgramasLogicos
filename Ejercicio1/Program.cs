
/*UNIVERSIDAD CASTRO CARAZO - PROGRAMACION III
GRUPO #2
EJERCICIO 1 PROYECTO II

DESCRIPCION:
Un algoritmo que convierta la hora en letras, por ejemplo "12:40" deberia imprimir "Doce horas y cuarenta minutos".*/

using System;

namespace Ejercicio_1_Proyecto_II
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] unidades =
                {"cero", "uno", "dos" ,"tres" ,"cuatro" ,"cinco" ,
                "seis" ,"siete" ,"ocho" ,"nueve","diez"};

                string[] especiales =
                {"once", "doce","trece","catorce", "quince",
                "diezciseis", "diecisiete", "dieciocho", "diecinueve"};

                string[] decenas =
                {"veinte", "treinta","cuarenta","cincuenta",
                "sesenta"};

                Console.Write(" Ingrese el valor de horas: ");
                int horas = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Ingrese el valor de minutos: ");
                int minutos = Convert.ToInt32(Console.ReadLine());

                if (horas >= 0 && horas < 11)
                    Console.Write('\n' + " RESULTADO " + '\n' + " " + unidades[horas] + " horas");
                else if (horas < 20)
                    Console.Write('\n' + " RESULTADO " + '\n' + " " + especiales[horas - 11] + " horas");
                else if (horas <= 24)
                {
                    int unid = horas % 10;
                    int dec = horas / 10;
                    if (unid == 0)
                        Console.Write('\n' + " RESULTADO " + '\n' + " " + decenas[dec - 2] + " horas");
                    else
                        Console.Write('\n' + " RESULTADO " + '\n' + " " + decenas[dec - 2] + " y " + unidades[unid] + " horas");
                }
                else
                    Console.WriteLine(" El numero de horas debe ser menor o igual a 24");


                if (minutos >= 0 && minutos < 11)
                    Console.Write(" y " + unidades[minutos] + " minutos ");
                else if (minutos < 20)
                    Console.Write(" y " + especiales[minutos - 11] + " minutos ");
                else if (minutos <= 60)
                {
                    int unid = minutos % 10;
                    int dec = minutos / 10;
                    if (unid == 0)
                        Console.Write(" y " + decenas[dec - 2] + " minutos ");
                    else
                        Console.Write(" y " + decenas[dec - 2] + " y " + unidades[unid] + " minutos ");
                }
                else
                    Console.WriteLine(" El numero de minutos debe ser menor o igual a 60");

                Console.ReadLine();
            }
            catch (Exception error)
            {
                Console.WriteLine("\n El valor ingresado es incorrecto", error);
                Console.ReadKey();
            }
        }
    }
}