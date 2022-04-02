
/*UNIVERSIDAD CASTRO CARAZO - PROGRAMACION III
GRUPO #2
EJERCICIO 6 PROYECTO II

DESCRIPCION:
Agrupar un arreglo de valores usando Linq y su funcion GroupBy.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_6_Proyecto_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personas> personas = new List<Personas>()
            {
                new Personas (){Nombre =" Juan Jose Alvarez Lopez",Edad =20, Salario= 320000},
                new Personas (){Nombre =" Jose Enrique Urena Aguilar ",Edad =24, Salario= 150000},
                new Personas (){Nombre =" Leandro Martin Vargas Valverde",Edad =22, Salario= 480000},
                new Personas (){Nombre =" Jeudy Lugery Espinoza Cubillo",Edad =30, Salario= 890000},
                new Personas (){Nombre =" Jason David Delgado Aguilar",Edad =40, Salario= 100000},
                new Personas (){Nombre =" Karol Dayana Alvarez Lopez",Edad =52, Salario= 740000},
                new Personas (){Nombre =" Sandra Maria Lopez Bermudez",Edad =16, Salario= 950000},
                new Personas (){Nombre =" Juan Rafalel Alvarez Delgado",Edad =34, Salario= 130000},
                new Personas (){Nombre =" Eliana Rebeca Fernandez Lopez",Edad =44, Salario= 450000},
                new Personas (){Nombre =" Wendy Pamela Loaiza Delgado ",Edad =12, Salario= 580000},
                new Personas (){Nombre =" Yeisy Melissa Garro Chavarria",Edad =13, Salario= 200000},
            };
            var grupos = personas.GroupBy(x =>
            {
                if (x.Edad <= 18)
                {
                    return "Menor de edad";
                }
                else if (x.Edad >= 20 && x.Edad <= 30)
                {
                    return "Rango de edad de 20 a 30 años";
                }
                else if (x.Edad >= 31 && x.Edad >= 40)
                {
                    return "Rango de edad de 31 a 40 años";
                }
                else
                {
                    return "Mayores a 41 años";
                }
            });

            foreach (var grupo in grupos)
            {
                Console.WriteLine(" Grupo de: " + grupo.Key + "     Cantidad: " + grupo.Count());
                Console.WriteLine("");
                foreach (var grupoPer in grupo)
                {
                    Console.WriteLine(grupoPer.Nombre);
                }
                Console.WriteLine("\n");
            }
            Console.Read();
        }
    }
    class Personas
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Salario { get; set; }
    }
}