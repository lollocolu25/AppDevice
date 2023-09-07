using System;
using System.Collections.Generic;

namespace AppDevice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu.StartMenu();
            string risposta = Console.ReadLine();
            if (risposta == "m")
            {
                Song.ToString();
            }
            else
            {
                Movie.ToString();
            }
            /*List<String> listabrani = new List<String>();
            new Song() { _Nome = "1 -  Holliwood" };
            new Song() { _Nome = "2 -  Malamente" };
            new Song() { _Nome = "3 -  Altamente mia" };
            new Song() { _Nome = "4 -  Mirage" };

            List<string> listafilm= new List<string>();
            new Movie() { _Nome = "1 -  Titanic" };
            new Movie() { _Nome = "2 -  Tre uomini e una gamba" };
            new Movie() { _Nome = "3 -  Focus" };
            new Movie() { _Nome = "4 -  Chiedimi se sono felice" };*/


        }
    }
}
