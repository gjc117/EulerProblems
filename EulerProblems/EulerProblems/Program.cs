using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EulerProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Problems1_5 ep1_5 = new Problems1_5();
            Problems6_10 ep6_10 = new Problems6_10();
            Problems11_15 ep11_15 = new Problems11_15();
            Problems16_20 ep16_20 = new Problems16_20();


            Console.WriteLine("Hi Gavin Home");
            /*
            Console.WriteLine("EP1 = " + (ep1_5.Euler1()).ToString());
            Console.WriteLine("EP2 = " + (ep1_5.Euler2()).ToString());
            Console.WriteLine("EP3 = " + (ep1_5.Euler3()).ToString());
            */

            /*
            Console.WriteLine("EP7 = " + (ep6_10.Euler7()).ToString());
            Console.WriteLine("EP8 = " + (ep6_10.Euler8()).ToString());
            */

            /*
            Console.WriteLine("EP13 = " + ep11_15.Euler13());
            */

            /*
            */
            Console.WriteLine("EP16 = " + ep16_20.Euler16().ToString());


            Console.ReadLine();
        }
    }
}
