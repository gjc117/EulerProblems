using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Problems1_5
{
    MathMethods mm = new MathMethods();

    public int Euler1()
    {
        int n = 1000;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            if (i % 5 == 0 || i % 3 == 0)
                sum += i;
        }
        return sum;
    }

    public long Euler2()
    {
        int f1 = 1;
        int f2 = 2;
        int ftmp;

        int[] arr = new int[1000];
        long sum = 0;

        for (int i = 0; i < 400000000; i++)
        {
            if (f1 < 4000000)
            {
                arr[i] = f1;

                ftmp = f1 + f2;
                f1 = f2;
                f2 = ftmp;

                if (arr[i] % 2 == 0)
                    sum += arr[i];
            }
            else
                break;
        }

        return sum; ;
    }

    public double Euler3()
    {
        double largestPrime = 0;
        double n = 600851475143;
        double sqrt_n = Math.Sqrt(n);

        for (int i = 3; i < sqrt_n; i += 2)
        {
            if (n % i == 0)
            {
                if (mm.isPrime(i) && i > largestPrime)
                    largestPrime = i;
            }

        }

        return largestPrime;


    }

}

