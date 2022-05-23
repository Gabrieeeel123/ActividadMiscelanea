using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Menu
    {
        public void menuuu()
        {
            int operadores = 0;
            do
            {
                try
                {

                    Console.WriteLine("Bienvenido al menu");
                    Console.WriteLine("Elija 1. si desea hacer operaciones");
                    Console.WriteLine("Elija 2. si desea ver los condicionales");
                    Console.WriteLine("Elija 3. si desea ver los Ciclos");
                    Console.WriteLine("Elija 4. si desea ver los bucles");
                    Console.WriteLine("Elija 0. si dese salir del programa");
                    operadores = char.Parse(Console.ReadLine());
                    switch (operadores)
                    {
                        case '1': Operacionesclass operacionesclass = new Operacionesclass(); operacionesclass.operaciones(); break;
                        case '2': Condicionales condicionales = new Condicionales(); condicionales.coondicionales(); break;
                        case '3': Ciclos ciclos = new Ciclos(); ciclos.Ciiclos(); break;
                        case '0': Environment.Exit(1); ; break;
                        default: Console.WriteLine("no especifico ninguna opcion"); break;
                    }
                } catch (FormatException ex){
                    Console.WriteLine("No especifico ninguna opcion valida");
                    Menu menu = new Menu();
                    menu.menuuu();
                }
            } while (operadores == 1 || operadores == 2 || operadores == 3 || operadores == 0);
        }
    }
}