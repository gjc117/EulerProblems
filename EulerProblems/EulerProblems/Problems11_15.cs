using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Reflection;

public class Problems11_15
{
    MathMethods mm = new MathMethods();

    public double Euler11()
    {
        double prod = 0; ;
        double largestProd = 0;
        int size = 20;
        List<string[]> table = new List<string[]>();
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Files\\Euler11.txt";
        string line;
        StreamReader r = new StreamReader(path);

        while ((line = r.ReadLine()) != null)
        {
            string[] arr = line.Split(' ');
            table.Add(arr);
        }

        r.Close();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {

                if (j + 1 < size && j + 2 < size && j + 3 < size)
                {
                    prod = Convert.ToDouble(table[i][j]) * Convert.ToDouble(table[i][j + 1]) * Convert.ToDouble(table[i][j + 2]) * Convert.ToDouble(table[i][j + 3]);
                    if (prod > largestProd)
                        largestProd = prod;
                }

                if (i + 1 < size && i + 2 < size && i + 3 < size)
                {
                    prod = Convert.ToDouble(table[i][j]) * Convert.ToDouble(table[i + 1][j]) * Convert.ToDouble(table[i + 2][j]) * Convert.ToDouble(table[i + 3][j]);
                    if (prod > largestProd)
                        largestProd = prod;
                }

                if (i + 1 < size && i + 2 < size && i + 3 < size && j + 1 < size && j + 2 < size && j + 3 < size)
                {
                    prod = Convert.ToDouble(table[i][j]) * Convert.ToDouble(table[i + 1][j + 1]) * Convert.ToDouble(table[i + 2][j + 2]) * Convert.ToDouble(table[i + 3][j + 3]);
                    if (prod > largestProd)
                        largestProd = prod;
                }

            }
        }

        for (int i = size-1; i>=0; i--)
        {
            for (int j = 0; j < size; j++)
            {

                if (j + 1 < size && j + 2 < size && j + 3 < size)
                {
                    prod = Convert.ToDouble(table[i][j]) * Convert.ToDouble(table[i][j + 1]) * Convert.ToDouble(table[i][j + 2]) * Convert.ToDouble(table[i][j + 3]);
                    if (prod > largestProd)
                        largestProd = prod;
                }

                if (i - 1 >= 0 && i - 2 >= 0 && i - 3 >= 0)
                {
                    prod = Convert.ToDouble(table[i][j]) * Convert.ToDouble(table[i - 1][j]) * Convert.ToDouble(table[i - 2][j]) * Convert.ToDouble(table[i - 3][j]);
                    if (prod > largestProd)
                        largestProd = prod;
                }

                if (i - 1 >= 0 && i + 2 >= 0 && i - 3 >= 0 && j + 1 < size && j + 2 < size && j + 3 < size)
                {
                    prod = Convert.ToDouble(table[i][j]) * Convert.ToDouble(table[i - 1][j + 1]) * Convert.ToDouble(table[i - 2][j + 2]) * Convert.ToDouble(table[i - 3][j + 3]);
                    if (prod > largestProd)
                        largestProd = prod;
                }

            }
        }

        return largestProd;
    }

    public double Euler12()
    {
        
        int n = 500;
        double sum = 0;
        double triNum = 0;

        for(int i=1;;i++)
        {
            sum += i;
            if(mm.numberOfDivisors(sum)>n)
            {
                triNum = sum;
                break;
            }
        }
        return triNum;


    }

    public string Euler13()
    {
        //string path1 = Directory.GetCurrentDirectory();
        //string path2 = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
        string path3 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Files\\Euler13.txt";

        BigInteger result = new BigInteger();
        string line;
        StreamReader r = new StreamReader(path3);

        while ((line = r.ReadLine()) != null)
        {
            result += BigInteger.Parse(line);
        }

        r.Close();

        return result.ToString().Substring(0, 10);

    }

    public void Euler14()
    {
       
        bool flag;
        int terms;
        int largestTerms = 0;
        double largestStart = 0;
        double n = 0;
        double test = 0;

        for (int i=999950;i<1000000;i++)

        {
            n = i;
            terms = 1;
            flag = false;
            while (!flag)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    terms++;
                }
                else
                {
                    n = (3 * n) + 1;
                    terms++;
                }
                if (n == 1 && terms>largestTerms)
                {
                    largestTerms = terms;
                    largestStart = i;
                    flag = true;
                }
            }
            Console.WriteLine(test++);
        }
        Console.WriteLine(largestStart);
        Console.WriteLine(largestTerms);

    }
}

