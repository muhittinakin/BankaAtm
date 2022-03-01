using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaATM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 10000;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine( "Bakiyeniz ="+bakiye);
            Console.WriteLine("\n****İŞLEMLER****\n");
            Console.WriteLine("1.Para Çekme");
            Console.WriteLine("2.Para Yatırma");
            Console.WriteLine("3.Bakiye Sorgulama");
            Console.WriteLine("4.Kart Iade");

            Console.WriteLine("\nİşleminizi Seciniz :");
            int islem = Convert.ToInt32(Console.ReadLine());
            switch(islem)
            {
                case 1: 
                    Console.WriteLine("Bakiyeniz ="+bakiye);
                    Console.Write("Çekmek istediğiniz tutarı giriniz :");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    if(tutar>bakiye)
                    {
                        Console.Write("Yetersiz bakiye.Tekrar deneyiniz.");
                        tutar = Convert.ToInt32(Console.ReadLine());
                    }
                    bakiye -= tutar;
                    Console.WriteLine("Yeni Bakiyeniz=" + bakiye);
                    break;

                case 2:
                    Console.WriteLine("Bakiyeniz=" + bakiye);
                    Console.Write("Yatırmak istediğiniz tutarı giriniz :");
                     tutar = Convert.ToInt32(Console.ReadLine());
                    bakiye += tutar;
                    Console.WriteLine("Yeni Bakiyeniz ="+bakiye);
                    break;

                case 3: 
                    Console.WriteLine("Bakiyeniz="+bakiye);
                    break;

                case 4: 
                    Console.WriteLine("Kartınızı almayı unutmayınız.!!");
                    break;
                default:
                    Console.WriteLine("Yanlış islem sectiniz.Tekrar giriniz.");
                    break;
            }
            Console.ReadLine();

        }
    }
}
