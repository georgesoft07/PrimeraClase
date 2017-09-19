using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase
{
    class televisor : Electrodomestico
    {
        public string Name { get; set; }
        public int Duracion { get; set; }

        public televisor(string nom, int Durac)
        {

            this.Name = nom;
            this.Duracion = Durac;

        }


        public void ConectarcePorEnchufe()
        {
            Console.WriteLine("mi nombre es " + this.Name + " y peso " + this.Duracion);
        }
    }
}
