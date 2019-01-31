using System;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            
            
            Console.Write("Szia \n Kérlek írd be a neved?");
            string nev = Console.ReadLine();
            Console.WriteLine("Írj be egy jelszót");
            string jel = Console.ReadLine();
            if (nev == "Patrik" || nev == "Andi")
            {
                Console.WriteLine("Jó a név");
                if (nev!="Patrik" || nev!="Gyuri")
                {
                    Console.WriteLine("Rossz a név nem mehetsz tovább");
                    if (jel=="1" || jel=="2")
                    {
                        Console.Clear();
                    }
                   
                    
                }
            
            
            }







            Console.ReadKey();
        }
    }
}
