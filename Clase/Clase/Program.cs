using System;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Eliga Un Numero del 1 al 2 y le dire el color que contiene");
            Console.Readline(a);
            switch (a)
            {
                case 1:
                    Console.WriteLine("Seleccionaste El Rojo");
                    
                      break;
                    
                case 2:
                    Console.WriteLine("Seleccionaste El Negro");
                    break;
                   
            }Console.ReadKey();
            
        }
    }
}
