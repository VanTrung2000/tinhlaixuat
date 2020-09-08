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
            Console.WriteLine("Nhan so tien gui: ");
            money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhan so thang gui: ");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhan lai xuat: ");
            intersetRate = Double.Parse(Console.ReadLine());
            double totalInterset = 0;
            for (int i = 0; i < month; i++)
            {
                totalInterset = money * (intersetRate / 100) / 12 * 3;
            }
            Console.WriteLine("Total of interset: " + totalInterset);
            Console.ReadKey();
        }
    }
}
