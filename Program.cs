using System;
using System.IO;
namespace Grupitöö
{
    class Program
    {
        //https://www.codeguru.com/csharp/csharp/cs_syntax/anandctutorials/article.php/c5861/Working-with-Files-in-C.htm - SIIN ON LINK ERINEVATE VAJALIKE TERMINITE JMS-GA
        static void Main(string[] args)
        {
            string asukoht = @"C:\Users\Kasutaja\Desktop\kool\programmeerimine\rühmatöö\";
            Start:
            DirectoryInfo d = new DirectoryInfo(asukoht);
            FileInfo[] Files = d.GetFiles("*.txt");
            string str = "";
            Console.WriteLine("Olemasolevad failid on:");
            foreach (FileInfo file in Files)
            {
                string i = str + "" + file.Name;
                Console.WriteLine(i);

            }

            Console.WriteLine(" ");

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
                string text = System.IO.File.ReadAllText(asukoht + FAILINIMI + ".txt");
                Console.WriteLine(text);
                Console.ReadLine();
            }
            if (val == "Delete")
            {
                Console.WriteLine("Millist faili soovite kustutada?");
                var FAIL = Console.ReadLine();
                System.IO.File.Delete(asukoht + FAIL + ".txt");
                Console.WriteLine("Aitäh, fail on kustutatud!");
                Console.ReadLine();

            }

            if (val == "New")
            {
                Console.WriteLine("Sisestage uue faili nimi:");
                string fileName = Console.ReadLine();
                File.Create(asukoht + fileName + ".txt");
                Console.ReadLine();
            }
            {

                if (val == "Exit")
                {

                }
                else
                {
                    Console.WriteLine("Valisite vale variandi! Olemasolevad variandid on: Read, New, Delete, Exit. Vajutage enterit ja proovige uuesti!");
                    Console.ReadLine();
                    goto Start;
                }
            }
        }
    }
}