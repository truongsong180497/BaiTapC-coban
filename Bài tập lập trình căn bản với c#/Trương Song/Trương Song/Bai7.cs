using System;
using System.Collections.Generic;
using System.Text;

namespace Trương_Song
{
    class Bai7
    {
        static void Main()
        {
            Console.WriteLine("=========== Menu ==========");
            Console.WriteLine(" Nhap 2 so nguyen a va b:");// nhap ngoai switch moi thuc hien cac cong viec duoc
            Console.WriteLine("1.Xuat tong a+b :");
            Console.WriteLine("2.xuat hieu a-b :");
            Console.WriteLine("3.Xuat tich a*b :");
            Console.WriteLine("4.Xuat thuong a/b :");
            Console.WriteLine("5.Ket thuc:");
            Console.WriteLine(" nhap so nguyen a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" nhap so nguyen b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" vui long nhap su lua chon ");
            int Menu = Convert.ToInt32(Console.ReadLine());
            switch (Menu)
            {
               
                case 1 :
                    int Tong  = a + b;
                    Console.WriteLine(" Tong a+b = "+Tong);
                    break;
                case 2:
                    int Hieu = a - b;
                    Console.WriteLine(" Hieu a-b = " + Hieu);
                    break;
                case 3:
                    int Tich = a * b;
                    Console.WriteLine(" Tich a*b = "+Tich);
                    break;
                case 4:
                    float Thuong = a*1.0f / b;
                    Console.WriteLine(" Thuong a/b = "+Thuong);
                    break;
                case 5:
                    Console.WriteLine(" Ket thuc ");
                    break;
                default:
                    break;
            }
            Console.WriteLine("============================");


        }

    }
}
