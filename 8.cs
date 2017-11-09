using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kas soovite salvestada või mitte? Kui jah siis kirjutage Save ja kui mitte siis Canel.");
            string vastus = "";

            if (vastus == "Save")
            {
                Failinimi.ShowDialog();
            }
            
        }
    }
}
