using System;
using System.Collections.Generic;
using System.Text;

namespace Trương_Song
{
    class Bai3
    {
        static void Main()
        {
            // gia su 2 so nhap vao ban phim la a va b !
            Console.WriteLine(" nhap a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" nhap b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine(" tong a+b = "+sum);
        }
    }
}
