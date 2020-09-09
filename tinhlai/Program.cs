using System;

namespace tinhlai
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 1.0;
            int month = 1;
            double intersetRate = 1.0;
            Console.WriteLine("Nhap so tien gui: ");
            money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thang gui: ");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap lai xuat: ");
            intersetRate = Double.Parse(Console.ReadLine());
            double totalInterset = 0;
            laixuat(money, month, intersetRate);
            Console.ReadKey();
        }
        static double laixuat(double a, int b, double c){
            double d = a * (c / 100) / 12 * 3;
            Console.WriteLine("Total of interset: " + d);
            return d;

        }
    }
}

