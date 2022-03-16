using System;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            Console.Write("Inputkan Nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan Nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
        }
        {
        static int penambahan(int a, int b)
        { }
        }

       
}
