using System;
using System.Collections.Generic;
using System.Text;

namespace Trương_Song // lam chua xong !
{
    class Bai8
    {
        private static int h;
      

        static void Main()
        {
            /* Vetamgiacvuongduoi(h);*/      // chay cau nao thi bo comend cau do
            /*Vetamgiacvuongtren(h);*/
           
        }
        static int Vetamgiacvuongduoi(int h)// cau a 
        {
            Console.WriteLine(" nhap h = ");
             h = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            return 0;
        }
        static int Vetamgiacvuongtren(int h)//cau a
        {
            Console.WriteLine(" nhap h = ");
            h = Convert.ToInt32(Console.ReadLine());
            for (int i = h; i >=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("  ");
            }

            return 0;
        }
        
            
            
            

    }
}
