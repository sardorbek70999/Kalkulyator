using System;

namespace KalkulyatorDasturi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulyator Dasturiga Xush Kelibsiz!");
            Console.WriteLine("Amalni kiriting (qo'shimcha amallar: +, -, *, /):");

            // Foydalanuvchidan amalni olish
            char amal = char.Parse(Console.ReadLine());

            Console.WriteLine("Birinchi sonni kiriting:");
            double birinchiSon = double.Parse(Console.ReadLine());

            Console.WriteLine("Ikkinchi sonni kiriting:");
            double ikkinchiSon = double.Parse(Console.ReadLine());

            double natija = 0;

            // Amalni bajarish
            switch (amal)
            {
                case '+':
                    natija = birinchiSon + ikkinchiSon;
                    break;
                case '-':
                    natija = birinchiSon - ikkinchiSon;
                    break;
                case '*':
                    natija = birinchiSon * ikkinchiSon;
                    break;
                case '/':
                    if (ikkinchiSon != 0)
                    {
                        natija = birinchiSon / ikkinchiSon;
                    }
                    else
                    {
                        Console.WriteLine("Nolga bo'lish mumkin emas!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Noto'g'ri amal kiritildi!");
                    return;
            }

            Console.WriteLine("Natija: " + natija);
        }
    }
}
