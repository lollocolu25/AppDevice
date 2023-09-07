using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevice
{
    internal class Song: AbsContenuto
    {
        public Song() {
            _Tipologia = "Song";
        }

        public IEnumerable<object> Listabrani { get; private set; }

        public static void ToString()
        {
            var names = new List<string> {
                "1 -  Holliwood",
                "2 -  Malamente",
                "3 -  Altamente mia",
                "4 -  Mirage"};
            /*List<object> listabrani = new();
            new Song() { _Nome = "1 -  Holliwood" };
            new Song() { _Nome = "2 -  Malamente" };
            new Song() { _Nome = "3 -  Altamente mia" };
            new Song() { _Nome = "4 -  Mirage" };*/
            foreach (var listabrani in Listabrani)
            {
                Console.WriteLine($"{listabrani}");
            }
        }
    }
}
