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

    public void Euler11()       //Not complete. Got string array list. 
    {
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

        /*
        foreach(string[] str in table)
        {
            Console.WriteLine(str[19]);
        }
        */
        Console.WriteLine(table[0][1]);
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
}

