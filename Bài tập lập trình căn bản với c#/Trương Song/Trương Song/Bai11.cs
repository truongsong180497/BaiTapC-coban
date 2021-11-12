using System;
using System.Collections.Generic;
using System.Text;

namespace Trương_Song
{
    class Bai11
    {
        static void Main()
        {
            int sum = 0;//sum la tong boi so cua 7
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0)//boi so cua 7 la so chia het cho 7
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(" tong cac so la boi cua 7 tu 1 den 99 la :"+sum);
        }
    }
}
