using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class maain
    {
        public static void Main(string[] args)
        {
           

                try
                {
                    Menu menu = new Menu();
                    menu.menuuu();
                }
                catch (FormatException )
                {
                    Console.WriteLine("no especifico ninguna opcion valida");
                    Menu menu = new Menu();
                    menu.menuuu();
                }
            
            }
        
            

        
    }
}
