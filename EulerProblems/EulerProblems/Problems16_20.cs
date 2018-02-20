using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Problems16_20
{
    public int Euler16()
    {
        BigInteger pow = new BigInteger();

        double n = 1000;
        int sum = 0;

        pow = (BigInteger)Math.Pow(2, n);      //Explicit conversion to BigInteger

        char[] powArr = pow.ToString().ToCharArray();

        for(int i = 0; i<powArr.Length; i++)
        {
            sum += (Convert.ToInt32(powArr[i]) - 48);      //returns ASCII code;
        }

        return sum;
    }
}
