using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1214073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tugas pertama  aritmathic operator
            //Percobaan 1.1
           int angkaPertama = int.Parse(Console.ReadLine());
            int angkaKedua = int.Parse(Console.ReadLine());
            int a = angkaPertama + angkaKedua;
            int b = angkaPertama - angkaKedua;
            int c = angkaPertama / angkaKedua;
            int d = angkaPertama * angkaKedua;

            Console.WriteLine("Angka Pertama : " + angkaPertama);
            Console.WriteLine("Angka Kedua : " + angkaKedua);

            Console.WriteLine("20 + 5 = " + a);
            Console.WriteLine("20 - 5 = " + b);
            Console.WriteLine("20 : 5 = " + c);
            Console.WriteLine("20 x 5 = " + d);
        }
    }
}
