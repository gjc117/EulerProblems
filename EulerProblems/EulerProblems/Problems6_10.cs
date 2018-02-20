using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Problems6_10
{
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
}