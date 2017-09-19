using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Electrodomestico> electrodomestico = new List<Electrodomestico>();


            Electrodomestico lamp = new Lampara("lampara", 5);
            electrodomestico.Add(lamp);
            
            Electrodomestico tele = new televisor("televisor", 20);
            electrodomestico.Add(tele);
        
            Electrodomestico radio = new Radio("radio", 10);
            electrodomestico.Add(radio);

            //electrodomestico.ForEach(x => x.ConectarcePorEnchufe());

            foreach (Electrodomestico s in electrodomestico)
            {
                s.ConectarcePorEnchufe();
            }




        //Manzana manzana = new Manzana();
        //manzana.Name = "chilena";
        //manzana.Duracion = 10;
        //manzana.DecirDuracion();
        Console.ReadKey();

        }
    }
}
