using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Operacionesclass
    {
        private double a = 0.0;
        private double b = 0.0;
        private double c = 0.0;
        private double d = 0.0;
        public double geta()
        {
            return this.a;
        }
        public void seta(double a)
        { this.a = a; }
        public double getb()
        {
            return this.b;
        }
        public void setb(double b)
        { this.b = b; }
        public double getc()
        {
            return this.c;
        }
        public void setc(double c)
        { this.c = c; }
        public double getd()
        {
            return this.d;
        }
        public void setd(double d)
        { this.d = d; }

        public void operaciones()
        {
            int ej1 = 0;
            do
            {
                try
                {
                    Console.WriteLine("Bienvenido al menu");
                    Console.WriteLine("------------------");
                    Console.WriteLine(" Elija 1 si desea ver el Area de un triangulo");
                    Console.WriteLine(" Elija 2 si desea hacer una suma  Suma ");
                    Console.WriteLine(" Elija 3 si desea hacer una Potencia al cuadrado");
                    Console.WriteLine(" Elija 4 si desea hacer una Conversion euros a dolares");
                    Console.WriteLine(" Elija 5 si desea un algoritmo que muestre el valor del area y el perimetro de un cuadrardo con el lado de un cuadrado.");
                    Console.WriteLine(" Elija 6 si desea Escribir un algoritmo que determine el área y el volúmen de un cilindro.");
                    Console.WriteLine(" Elija 7 si desea un algoritmo que lea el radio de una circunferencia y escriba la longitud de la misma y el area del circulo inscrito");
                    Console.WriteLine(" Elija 8 si desea Calcular el promedio de tres números ingresados por teclado.");
                    Console.WriteLine(" Elija 0 si desea salir del programa");
                    ej1 = int.Parse(Console.ReadLine());
                    switch (ej1)
                    {
                        case '1': Art(); break;
                        case '2': Sum(); break;
                        case '3': Pot(); break;
                        case '4': Con(); break;
                        case '5': Cuadrado(); break;
                        case '6': Cilindro(); break;
                        case '7': Circulo(); break;
                        case '8': promedio(); break;
                        case '0': Environment.Exit(1); break;
                        default: break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("No especifico ninguna opcion valida");
                    Operacionesclass operacionesclass = new Operacionesclass();
                    operacionesclass.operaciones();
                }
            }while (ej1 == 1 || ej1 == 2 || ej1 == 3 || ej1 == 4 || ej1 == 5 || ej1 == 6 || ej1 == 7 || ej1 == 8 || ej1 == 0);
        }

        

       
        public double Art()
        {
            Console.WriteLine("Por favor, digite la base del triangulo");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor digite la atura del triangulo");
            a = double.Parse(Console.ReadLine());
            c = b * a / 2;
            Console.WriteLine("El area del tringulo es: " + c);
            return c;
        }

        public double Sum()
        {
            Console.WriteLine("Por favor digite el primer numero para realizar la suma");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor digite el segundo numero para completar la suma");
            b = double.Parse(Console.ReadLine());
            c = a * b;
            Console.WriteLine("El resultado de la suma es: " + c);
            return c;

        }
        public double Pot()
        {
            Console.WriteLine("Por favor digite un numero para saber el cuadrado");
            a = double.Parse(Console.ReadLine());
            c = a * a;
            Console.WriteLine("El resultado de la potencia es: " + c);
            return c;


        }

        public double Con()

        {
            Console.WriteLine("Digite el numero en Euros");
            a = Convert.ToSingle(Console.ReadLine());
            c = (a * 1.0831);
            Console.WriteLine(a + " en doloares es " + c);
            return c;
        }


        public double Cuadrado()
        {
            Console.WriteLine("Digite la medida de un lado del cuadrado");
            a = double.Parse(Console.ReadLine());
            b = a * 4;
            c = a * a;
            Console.WriteLine("El perimetro de su cuadrado es: " + b);
            Console.WriteLine("El area de su cuadrado es: " + c);
            return c;


        }
        public double Cilindro()
        {
            Console.WriteLine("Digite el radio de su cilindro");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la altura del cilindro");
            b = double.Parse(Console.ReadLine());
            c = (int)(System.Math.PI * 2 * a + b + System.Math.PI * 2 * a * a);
            d = ((int)(System.Math.PI * a * a * b));
            Console.WriteLine("El area de su cilindro es: " + c);
            Console.WriteLine("El volumen de su cilindro es " + d);
            return c;

        }
        public double Circulo()
        {
            Console.WriteLine("Digite el radio de la circunferencia");
            a = double.Parse(Console.ReadLine());
            b = (a * 2 * System.Math.PI);
            c = (System.Math.PI * a * a);
            Console.WriteLine("El area del circulo es: " + b);
            Console.WriteLine("La longitud de la circunferencia es: " + c);
            return c;
        }
        public double promedio()
        {
            int datos;
            int d2;
            int d3;
            int promedio;
            Console.WriteLine("Digite 3 numeros enteros para saber su promedio");
            Console.WriteLine("Digite el primer numero");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero");
            d = double.Parse(Console.ReadLine());
            c = a + b + d / 3;
            Console.WriteLine("El promedio de sus numeros es: " + c);
            return c;

        }
    }
}
