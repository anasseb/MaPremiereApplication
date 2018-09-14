using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animaux = new List<Animal>();
            Animal milou = new Chien("Milou");
            Animal dingo = new Chien("Dingo");
            Animal idefix = new Chien("Idefix");
            Animal tom = new Chat("Tom");
            Animal felix = new Chat("Félix");

            animaux.Add(milou);
            animaux.Add(dingo);
            animaux.Add(idefix);
            animaux.Add(tom);
            animaux.Add(felix);

            foreach (Animal animal in animaux)
                animal.Respirer();

            //Animal animal = new Animal { nombreDePattes = 4 };
            //animal.Respirer();
            //Console.WriteLine();

            //Chien chien = new Chien { nombreDePattes = 4 };
            //chien.Respirer();
            //Console.WriteLine();
            Console.ReadKey();
        }
    }
}
