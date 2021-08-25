using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int yuzluk, ellilik, yirmilik, onluk;
            int para = 0;

            do
            {
                Console.Write("Lütfen para miktarını giriniz: ");
                para = int.Parse(Console.ReadLine());

                if (para % 10 == 5)
                {
                    Console.WriteLine("En küçük 10 TL'lik banknot mevcut \n");
                    Console.WriteLine("Lütfen para miktarını giriniz: \n");
                    para = int.Parse(Console.ReadLine());

                    yuzluk = (para / 100); para -= yuzluk * 100;
                    ellilik = (para / 50); para -= ellilik * 50;
                    yirmilik = (para / 20); para -= yirmilik * 20;
                    onluk = (para / 10); para -= onluk * 10;

                }
                else
                {
                    yuzluk = (para / 100); para -= yuzluk * 100;
                    ellilik = (para / 50); para -= ellilik * 50;
                    yirmilik = (para / 20); para -= yirmilik * 20;
                    onluk = (para / 10); para -= onluk * 10;
                }
                if (yuzluk > 0)
                {
                    Console.WriteLine(yuzluk + "Adet 100 TL ");
                }
                if (ellilik > 0)
                {
                    Console.WriteLine(ellilik + "Adet 50 TL ");
                }
                if (yirmilik > 0)
                {
                    Console.WriteLine(yirmilik + "Adet 20 TL ");
                }
                if (onluk > 0)
                {
                    Console.WriteLine(onluk + "Adet 10 TL ");
                }

            } while (para > 0);

         
            Console.ReadKey();








        }


    }
}
