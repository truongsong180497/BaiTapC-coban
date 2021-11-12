using System;
using System.Collections.Generic;
using System.Text;

namespace Trương_Song
{
    class Bai4
    {
        static void Main()
        {
            //pt bac nhat ax+b=0!
            float a, b;
            Console.WriteLine(" nhap a = ");
             a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" nhap b = ");
             b = Convert.ToSingle(Console.ReadLine());
            if (a != 0 && b != 0)
            {
                float x = -b*1.0f / a;
                Console.WriteLine(" pt co 1 nghiem la : x = "+x);
            }else if (a == 0 && b != 0)
            {
                Console.WriteLine(" pt vo nghiem ");
            }
            else
            {
                Console.WriteLine(" pt vo so nghiem ");
            }
            

        }
    }
}
