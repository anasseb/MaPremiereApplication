using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereApplication
{
    class Animal
    {
        protected string prenom;
        protected bool estVivant;
        public int age;

        public int nombreDePattes { get; set; }

        public void Respirer()
        {
            Console.WriteLine("Je suis " + prenom + " et je respire");
        }
    }
}
