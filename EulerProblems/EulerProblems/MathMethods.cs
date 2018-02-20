using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 class MathMethods
 {
    public bool isPrime(double x)
    {
        double sqrt_x = Math.Sqrt(x);

        int p = 0;
     
        for (int j = 1; j <= sqrt_x; j++)
        {
            if (x % j == 0)
                    p++;
        }
        if (p == 1)
            return true;
        else
            return false;
    }

    public bool isPalindrome(double x)
    {
        int[] arr = new int[x.ToString().Length];
        string arrRev="";
        double xOrg = x;

        for(int i=0; i<arr.Length;i++)
        {
            arr[i] = (int)x % 10;
            arrRev += arr[i].ToString();
            x /= 10;
        }

        if (Convert.ToDouble(arrRev) == xOrg)
            return true;
        else
            return false;
    }

 }

