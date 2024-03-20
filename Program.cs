using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaATM
{
    internal class Program
    {
        static decimal bakiye; // Para birimi olarak decimal tipi kullanılabilir
        static void Main(string[] args)
        {
            BaslangicAyarlariYap();
            MenuGoster();
            IslemSec();
        }

        static void BaslangicAyarlariYap()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lütfen Başlangıç Bakiyenize giriniz:");
            while (!decimal.TryParse(Console.ReadLine(), out bakiye) || bakiye < 0)
            {
                Console.WriteLine("Geçersiz bakiye. Tekrar giriniz:");
            }
            Console.WriteLine("Bakiyeniz = " + (bakiye));
        }

        static void MenuGoster()
        {
            Console.WriteLine("\n****İŞLEMLER****\n");
            Console.WriteLine("1.Para Çekme");
            Console.WriteLine("2.Para Yatırma");
            Console.WriteLine("3.Bakiye Sorgulama");
            Console.WriteLine("4.Kart İade");
            Console.WriteLine("5. İşlemi Bitir");
        }

        static void IslemSec()
        {
            int islem;
            do
            {
                Console.WriteLine("İşleminizi Seçiniz :");
                while (!int.TryParse(Console.ReadLine(), out islem))
                {
                    Console.WriteLine("Lütfen geçerli bir işlem seçiniz:");
                }

                switch (islem)
                {
                    case 1:
                        ParaCekme();
                        break;
                    case 2:
                        ParaYatirma();
                        break;
                    case 3:
                        BakiyeSorgulama();
                        break;
                    case 4:
                        KartIade();
                        break;
                    case 5:
                        Console.WriteLine("İşlem tamamlandı. Programdan çıkılıyor...");
                        return;
                    default:
                        Console.WriteLine("Yanlış işlem seçtiniz. Tekrar giriniz.");
                        break;
                }
            } while (true);
        }

        static void ParaCekme()
        {
            Console.WriteLine("Bakiyeniz = " + FormatlaBakiye(bakiye));
            decimal tutar;
            do
            {
                Console.Write("Çekmek istediğiniz tutarı giriniz :");
            } while (!decimal.TryParse(Console.ReadLine(), out tutar) || tutar < 0);

            if (tutar > bakiye)
            {
                Console.WriteLine("Yetersiz bakiye. Tekrar deneyiniz:");
                return;
            }
            bakiye -= tutar;
            Console.WriteLine("Yeni Bakiyeniz = " + FormatlaBakiye(bakiye));
        }

        static void ParaYatirma()
        {
            Console.WriteLine("Bakiyeniz = " + FormatlaBakiye(bakiye));
            decimal tutar;
            do
            {
                Console.Write("Yatırmak istediğiniz tutarı giriniz :");
            } while (!decimal.TryParse(Console.ReadLine(), out tutar) || tutar < 0);

            bakiye += tutar;
            Console.WriteLine("Yeni Bakiyeniz = " + FormatlaBakiye(bakiye));
        }

        static void BakiyeSorgulama()
        {
            Console.WriteLine("Bakiyeniz = " + FormatlaBakiye(bakiye));
        }

        static void KartIade()
        {
            Console.WriteLine("Kartınızı almayı unutmayınız.!!");
        }

        static string FormatlaBakiye(decimal bakiye)
        {
            return bakiye.ToString("C2"); // Para birimi formatı kullanmak için
        }
    }
}