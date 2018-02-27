using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
            System.Diagnostics.Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //Call function
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine(ts);
*/

namespace EulerProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Gavin Home");

            /*
            Problems1_5 ep1_5 = new Problems1_5();
            Problems6_10 ep6_10 = new Problems6_10();
            */

            Problems11_15 ep11_15 = new Problems11_15();
            Problems16_20 ep16_20 = new Problems16_20();
            Problems21_25 ep21_25 = new Problems21_25();
            MathMethods mm = new MathMethods();

            /*
            
            Console.WriteLine("EP1 = " + (ep1_5.Euler1()).ToString());
            Console.WriteLine("EP2 = " + (ep1_5.Euler2()).ToString());
            Console.WriteLine("EP3 = " + (ep1_5.Euler3()).ToString());
            Console.WriteLine("EP4= " + (ep1_5.Euler4()).ToString());
            Console.WriteLine("EP5= " + (ep1_5.Euler5()).ToString());                    
            Console.WriteLine("EP6 = " + (ep6_10.Euler6()).ToString());
            Console.WriteLine("EP7 = " + (ep6_10.Euler7()).ToString());
            Console.WriteLine("EP8 = " + (ep6_10.Euler8()).ToString());
            Console.WriteLine("EP9 = " + (ep6_10.Euler9()).ToString());
            Console.WriteLine("EP10 = " + (ep6_10.Euler10()).ToString());
       


            Console.WriteLine("EP12 = " + ep11_15.Euler12().ToString());
            Console.WriteLine("EP13 = " + ep11_15.Euler13());


            Console.WriteLine("EP16 = " + ep16_20.Euler16().ToString());

            Console.WriteLine("EP22 = " + ep21_25.Euler22().ToString());
            */

            ep11_15.Euler11();


            Console.ReadLine();
        }
    }
}
