using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevice
{
    internal class Menu
    {
        public static void StartMenu() {
            Console.WriteLine("Per iniziare un brano premi 'm', per iniziare un film digita'f' ");
            string risposta =Console.ReadLine();
            Console.WriteLine("----------------------");
            if(risposta =="m") { 
            
            }
        }
        public static void MediumMenu()
        {
            Console.WriteLine("Cosa vuoi riprodurre?");
            Console.WriteLine("----------------------");

        }
        public static void SelectAction()
        {
            Console.WriteLine("Next press F");
            Console.WriteLine("Previous press F");
            Console.WriteLine("Pause press F");
        }
    }
}
