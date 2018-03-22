using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Problems6_10
{
    MathMethods mm = new MathMethods();

    public int Euler6()
    {
        int n = 100;
        int sum_of_squares = 0;
        int sum = 0;
        int sq_sum = 0;

        for(int i=1; i<=n;i++)
        {
            sum_of_squares += (i * i);
            sum += i;
        }
        sq_sum = sum * sum;

        return sq_sum- sum_of_squares;
    }

    public long Euler7()
    {
        int pCount = 1;
        int searchN = 10001;
        long nthPrime = 0;

        for (int i = 3; ; i += 2)
        {
            int p = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    p++;
            }
            if (p == 2 && pCount < searchN)
            {
                nthPrime = long.Parse(i.ToString());
                pCount++;
            }
            else if (pCount >= searchN)
                break;
        }

        return nthPrime;
    }

    public double Euler8()
    {
        //Read in from text file, Create array
        int k = 0;
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Files\\Euler8.txt";
        StreamReader r = new StreamReader(path);
        int[] arr = new int [r.BaseStream.Length-3];
     
        while (!r.EndOfStream)
        {
            arr[k] = r.Read();
            k++;
        }

        r.Close();

        //Search for largest product
        double largestProd = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            double prod = 1;

            for (int j = i; j < i + 13 && j < arr.Length; j++)
            {
                prod *= (arr[j]-48);
            }
            if (prod > largestProd)
                largestProd = prod;
        }

        return largestProd;

    }

    public double Euler9()
    {
        double c = 0;
        int n = 1000;
        double prod=0;
        bool flag = true;
        int a = 1;

        while(flag)
        {
            for(int b=a; b<n ;b++)
            {
                c = (Math.Sqrt(((a * a) + (b * b))));

                if (a + b + c == n && a<b && b<c)
                {
                    prod = a * b * c;
                    flag = false;
                    break;
                }
            }
            a++;
        }
        return prod;
    }

    public double Euler10()
    {
        int n = 2000000;
        double sum_of_primes = 2; ;

        for(int i=3; i<n;i+=2)
        {
            if (mm.isPrime(i))
                sum_of_primes += i;
        }
        return sum_of_primes;
    }

}