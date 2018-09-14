using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereApplication
{
    class Chien : Animal
    {
        public void Aboyer()
        {
            Console.WriteLine("Wouaf !");
        }

        public void Vieillir()
        {
            age++;
        }

        public void Naissance()
        {
            age = 0;
            estVivant = true;
        }

        public Chien(string prenomDuChien)
        {
            prenom = prenomDuChien;
        }
    }
}
