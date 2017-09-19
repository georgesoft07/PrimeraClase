using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase
{
    class Lampara:Electrodomestico
    {

        public string Name { get; set; }
        public int peso { get; set; }

       public Lampara( string nom, int pes)
        {
            this.Name = nom;
            this.peso = pes;
        }

        public void ConectarcePorEnchufe()
        {
            Console.WriteLine("mi nombre es " + this.Name + " y peso " + this.peso);
        }
    }
}
