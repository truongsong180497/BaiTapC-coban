using System;
using System.Collections.Generic;
using System.Text;

namespace Trương_Song
{
    class Bai9
    {
        private static int n;

        static void Main()
        {
            // mở command chạy và so sánh kết quả 
            /*tong10sochandautienc1(n);
            tong10sochandautienc2(n);*/
        }

        

        static int tong10sochandautienc2(int n )//c1
        {
            Console.WriteLine(" nhap n = ");//nhap n>=20 
             n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;// tong 10 so tu nhien chan dau tien 
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
                if (n == 10)
                {
                    break;
                }
            }
            Console.WriteLine("tong 10 so tu nhien dau la :  " + sum);
            return 0;
        }
        static int tong10sochandautienc1(int n )//c1
        {
            int sum1 = 0;//tong 10 so chan dau tien
            for (int i = 0; i < 10; i++)
            {
                sum1 = sum1 + 2 * i;
            }
            Console.WriteLine("tong 10 so chan dau tien la :" + sum1);
            return n;
        }
    }
}
