using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        public class Coord
        {
            public Double Latitud { get; set; }
            public Double Longitud { get; set; }
        }
        static void Main(string[] args)
        {
            int Numero = 1;
            bool Continuar = true;
            Console.WriteLine("Ingrese coordenadas (Latitud, Longitud) ó 'x' para salir");
            Console.WriteLine("Ejemplo: 1.4, 2.5");
            Console.WriteLine("===============================================================================");
            List<Coord> coordenadas = new List<Coord>();
            while (Continuar)
            {
                Console.WriteLine(String.Format("Ingrese la coordenada N° " + Numero));
                string input = Console.ReadLine();
                if (input.ToLower().Equals("x"))
                {
                    Continuar = false;
                }
                if (input.Split(',').Length != 2)
                {
                    continue;
                }
                Double Lat;
                Double Long;
                Coord mycoord = new Coord()
                {
                    Latitud = Double.TryParse(input.Split(',')[0], out Lat) ? Lat : 0,
                    Longitud = Double.TryParse(input.Split(',')[1], out Long) ? Long : 0,
                };
                Numero++;
                coordenadas.Add(mycoord);
            }
            string Variable = "";
            foreach (Coord Link in coordenadas)
            {
                Variable = Variable + Convert.ToString(Link.Latitud) + "%2C%20" + Convert.ToString(Link.Longitud) + "%0A";
            }
            Console.WriteLine("===============================================================================");
            Console.WriteLine("Dirección de Coordenadas: https://www.keene.edu/campus/maps/tool/?coordinates{0}", Variable);
            Console.WriteLine("===============================================================================");
            Console.WriteLine("Usted ingresó {0} coordenadas", coordenadas.Count);
            Console.WriteLine("===============================================================================");
            Console.ReadKey();
        }
    }
}
