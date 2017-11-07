using System;
using System.IO;
namespace Grupitöö
{
    class Program
    {
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


        }
    }
}
