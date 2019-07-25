using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_circulo_y_cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            char NO; //Para evitar que se rompa si se pone una letra o un signo como "#"
            ClsFig Figura = new ClsFig(0, 0, 0,0, "Este es un programa para calcular el area de un cuadrado y un circulo","Teclee 1 para calcular el area de un cuadrado, en cambio teclee 2 para calcular el area de un circulo","","El resultado es ","Escriba la medida del lado del cuadrado", "Escriba la medida del radio del circulo");
            Console.WriteLine(Figura.Titulo);
            Console.WriteLine(Figura.Texto1);
            Figura.Texto2 = Console.ReadLine();
            NO = char.Parse(Figura.Texto2);
            if (Char.IsDigit(NO))
            {
                Figura.Opcion = int.Parse(Figura.Texto2);
                if (Figura.Opcion == 1)
                {
                    Console.WriteLine(Figura.Texto3);
                    Figura.Texto2 = Console.ReadLine();
                    Figura.Var1 = int.Parse(Figura.Texto2);
                    Figura.Var2 = Figura.Var1 * 4;
                    Console.WriteLine(Figura.Resultado + "" + Figura.Var2);
                    Console.ReadKey();
                }
                if(Figura.Opcion == 2)
                {
                    Console.WriteLine(Figura.Texto4);
                    Figura.Texto2 = Console.ReadLine();
                    Figura.Var1 = int.Parse(Figura.Texto2);
                    Figura.Var2 = (Figura.Var1 * Figura.Var1);
                    Figura.Var3 = Figura.Var2 * 3.1416;
                    Console.WriteLine(Figura.Resultado + "" + Figura.Var3);
                    Console.ReadKey();

                }

            }
            else
            {
                Console.WriteLine("Usted no ha ingresado un numero de los solicitados anteriormente :c");
                Console.ReadKey();
            }

        }
    }
}
