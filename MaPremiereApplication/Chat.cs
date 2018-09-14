using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereApplication
{
    class Chat : Animal
    {
        public Chat(string prenomDuChat)
        {
            prenom = prenomDuChat;
        }

        public void Miauler()
        {
            Console.WriteLine("Miaou");
        }
    }
}
