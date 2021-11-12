using System;
using System.Collections.Generic;
using System.Text;

namespace Trương_Song
{
    class Bai6
    {
        static void Main()
        {
            Console.WriteLine("=========== Menu ==========");
            Console.WriteLine(" 1.Tinh chu vi va dien tich cua tam giac :");
            Console.WriteLine(" 2.Tinh chu vi va dien tich cua hinh chu nhat :");
            Console.WriteLine(" 3.Tinh chu vi va dien tich cua hinh vuong :");
            Console.WriteLine(" 4.Tinh chu vi va dien tich cua hinh tron :");
            Console.WriteLine(" vui long chon so de tinh chu vi va dien tich : ");
            float chuvivadientich = Convert.ToSingle(Console.ReadLine());
            switch (chuvivadientich)
            {
                case 1: // gia su a,b,c la 3 canh tam giac 
                    int a, b, c;
                    Console.WriteLine(" nhap a = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" nhap b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" nhap c = ");
                    c = Convert.ToInt32(Console.ReadLine());
                    float P = a + b + c;//p : chu vi
                    float S = (float)Math.Sqrt(P * (P - a) * (P - b) * (P - c));// s : dientich
                    Console.WriteLine(" chu vi tam giac la :"+P);
                    Console.WriteLine(" dien tich cua tam giac la :"+S);
                    break;
                case 2://gia su a1 va b1 la 2 canh hcn
                    int a1, b1;
                    Console.WriteLine("nhap a1 = ");
                    a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("nhap b1 = ");
                    b1 = Convert.ToInt32(Console.ReadLine());
                    int chuvi = 2 * (a1 + b1);
                    int dientich = a1 * b1;
                    Console.WriteLine("chu vi hinh chu nhat la :"+chuvi);
                    Console.WriteLine("dien tich hinh chu nhat la :" + dientich );
                    break;
                case 3://gia su a2,b2 la 2 canh hinh vuong 
                    int a2, b2;
                    Console.WriteLine("nhap a2 = ");
                    a2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("nhap b2 = ");
                    b2 = Convert.ToInt32(Console.ReadLine());
                    int chuvi1 = 2 * (a2 + b2);
                    int dientich1 = a2 * b2;
                    Console.WriteLine("chu vi hinh chu nhat la :" + chuvi1);
                    Console.WriteLine("dien tich hinh chu nhat la :" + dientich1);
                    break;
                case 4:// gia su D la duong kinh hinh tron 
                    int D;
                    Console.WriteLine(" nhap D = ");
                    D = Convert.ToInt32(Console.ReadLine());
                    float C = (float)Math.PI * D;// C : chu vi hinh tron
                    float S1 =(float) (D * D * Math.PI) / 4;// S1: dien tich hinh tron 
                    Console.WriteLine(" chu vi hinh tron la :"+C);
                    Console.WriteLine(" dien tich hinh tron la :"+S1);
                    break;



                default:
                    break;
            }
            Console.WriteLine("============================");
        }
    }
}
