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

