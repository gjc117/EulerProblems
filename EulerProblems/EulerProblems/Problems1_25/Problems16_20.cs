using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



public class Problems16_20
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

    //100-999 is returning wrong answer by 45
    public void Euler17()
    {
        string[] words = { "and", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred", "thousand" };
        int sum = 0;
 
        for(int i=1; i<=1000; i++)
        {
            if (i >= 1 && i <= 19)
                sum += words[i].Length;
            else if (i < 100 && i % 10 == 0)
            {
                string str = i.ToString();
                char[] tmp = str.ToCharArray();
                int tmpInt1 = Convert.ToInt32(tmp[0] - 48);
                sum += words[tmpInt1 + 18].Length;
            }

            else if (i > 20 && i < 100)
            {
                string str = i.ToString();
                char[] tmp = str.ToCharArray();
                int tmpInt1 = Convert.ToInt32(tmp[0] - 48);
                int tmpInt2 = Convert.ToInt32(tmp[1] - 48);
                sum += words[tmpInt1 + 18].Length + words[tmpInt2].Length;
            }
            else if (i < 1000 && i % 100 == 0)
            {
                string str = i.ToString();
                char[] tmp = str.ToCharArray();
                int tmpInt1 = Convert.ToInt32(tmp[0] - 48);
                sum += words[tmpInt1].Length + words[28].Length;

            }
            else if (i > 100 && i < 1000)
            {
                string str = i.ToString();
                char[] tmp = str.ToCharArray();
                int tmpInt1 = Convert.ToInt32(tmp[0] - 48);
                int tmpInt2 = Convert.ToInt32(tmp[1] - 48);
                int tmpInt3 = Convert.ToInt32(tmp[2] - 48);

                if (i % 10 == 0)
                    sum += words[tmpInt1].Length + words[28].Length + words[0].Length + words[tmpInt2 + 18].Length;

                else if (tmpInt2 <= 1 && tmpInt3 > 0 && tmpInt3 <= 9)
                {
                    int tmp23 = Convert.ToInt32(tmpInt2.ToString() + tmpInt3.ToString());
                    sum += words[tmpInt1].Length + words[28].Length + words[0].Length + words[tmp23].Length;
                }
                else
                    sum += words[tmpInt1].Length + words[28].Length + words[0].Length + words[tmpInt2 + 18].Length + words[tmpInt3].Length;


            }
            else if (i == 1000)
                sum += words[1].Length + words[29].Length;
        }
        Console.WriteLine(sum);
    }
    
        

}
