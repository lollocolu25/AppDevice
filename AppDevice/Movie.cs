using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevice
{
    internal class Movie : AbsContenuto
    {
        public Movie()
        {
            _Tipologia = "Movie";
        }

        public IEnumerable<object> ListaFilm { get; private set; }

        public static void ToString()
        {
            var names = new List<string> {
                "1 -  Titanic",
                "2 -  Tre uomini e una gamba" ,
                "3 -  Focus",
                "4 -  Chiedimi se sono felice"};
            /*List<string> listafilm = new List<string>();
            new Movie() { _Nome = "1 -  Titanic" };
            new Movie() { _Nome = "2 -  Tre uomini e una gamba" };
            new Movie() { _Nome = "3 -  Focus" };
            new Movie() { _Nome = "4 -  Chiedimi se sono felice" };*/
            foreach (var listafilm in ListaFilm)
            {
                Console.WriteLine($"{listafilm}");
            }
        }
    }
}
