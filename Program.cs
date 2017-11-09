using System;
using System.IO;
namespace Grupitöö
{
    class Program
    {
        //https://www.codeguru.com/csharp/csharp/cs_syntax/anandctutorials/article.php/c5861/Working-with-Files-in-C.htm - SIIN ON LINK ERINEVATE VAJALIKE TERMINITE JMS-GA
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\opilane\Desktop\TEXTS");
            FileInfo[] Files = d.GetFiles("*.txt"); 
            string str = "";
            Console.WriteLine("Olemasolevad failid on:");
            foreach (FileInfo file in Files)
            {
                string i = str + "" + file.Name;
                Console.WriteLine(i);

            }
            
            Console.ReadLine();

            //New file
            Console.WriteLine("Mida soovite teha?");
            Console.WriteLine("Loe faili - Read FAILINIMI");
            Console.WriteLine("Loo uus fail - New FAILINIMI");
            Console.WriteLine("Kustuta fail- Delete FAILINIMI");
            Console.WriteLine("Lahku - Exit");


            var val = Console.ReadLine();
            if (val == "Read")
            {
                Console.WriteLine("Millist faili soovite lugeda?");
                var FAILINIMI = Console.ReadLine();
                string text = System.IO.File.ReadAllText(@"C:\Users\opilane\Desktop\TEXTS\" + FAILINIMI + ".txt");
                Console.WriteLine(text);
                Console.ReadLine();
            }
            if (val == "Delete")
            {
                Console.WriteLine("Millist faili soovite kustutada?");
                var FAIL = Console.ReadLine();
                System.IO.File.Delete(@"C:\Users\opilane\Desktop\TEXTS\" + FAIL + ".txt");
                Console.WriteLine("Aitäh, fail on kustutatud!");
                Console.ReadLine();

            }

            {

                string a = "";

                if (a == "Exit")
                {

                }


                Console.ReadLine();
            }
        }
    }
}