using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elag_EndesPatrik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia! \n\tKérlek írd be a neved!");
            string nev = Console.ReadLine();
            Console.WriteLine(nev);
            Console.WriteLine("Kérlek írd be a nemed!\n\t");
            string Nem = Console.ReadLine();
            Console.WriteLine(Nem);
            Console.WriteLine("Üdv a {0} táborban {1}\t",Nem,nev);
            if (Nem=="férfi")
            {
                Console.WriteLine("Legénybúcsúba várlak");
            }
            if(Nem=="Nő" ||Nem== "csaj") 
            {
            
                Console.WriteLine("Babazsúr");
            }
            if (Nem!="férfi"&& Nem!="nő"&& Nem!="csaj")
            {


                Console.WriteLine("Maradj otthon");
            }
            
        
        
        
        
            
            


            Console.ReadKey();

        }
    }
}
