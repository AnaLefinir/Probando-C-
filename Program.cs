using System;
using System.Collections.Generic;

namespace TryC_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Band> Bandas = new List<Band>();
            string respuesta;
            bool addBand = true;


            do
            {
                Console.WriteLine("Quieres agregar bandas?");
                respuesta = Console.ReadLine();

                if (respuesta == "Si")
                {
                    string banda;
                    int musicos = 0;
                    Band bandaaagregar;

                    Console.WriteLine("Ingrese el nombre de la Banda");
                    banda = Console.ReadLine();
                    while (musicos < 1)
                    {
                        Console.WriteLine("Cuantos musicos pertenecen a " + banda + "?");
                        int.TryParse(Console.ReadLine(), out musicos);
                    }

                    bandaaagregar = new Band { Name = banda, Musicians = musicos };
                    Bandas.Add(bandaaagregar);

                    for (int i = 0; i < musicos; i++)
                    {
                        bandaaagregar.AddMusicos(i);
                    }

                }
                else if (respuesta == "No")
                {
                    addBand = false;
                }
                else
                {
                    Console.WriteLine("Respuesta invalida, entre \"Si\" o \"No\" ");
                }
            } while (addBand == true);




            foreach (Band x in Bandas)
            {
                Console.WriteLine("La Banda " + x.Name + " tiene "+ x.musicos.Count + " integrantes");
            }

        }
    }
}
