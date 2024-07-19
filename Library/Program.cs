using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_sistemi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yetkili girişi için 1 kullanıcı girişi için 2 yazar girişi için 3 tuşlayınız : ");
            int tuşlanan = Convert.ToInt32(Console.ReadLine());
            if (tuşlanan == 1)//1. kişi ile alaklaı bütün kodları metotoları buraya cağırcaksın
            {
                görevli.yetkiliGirisi();
                
            }

            else if (tuşlanan == 2)//2. kişi ile alaklaı bütün kodları metotoları buraya cağırcaksın
            {
                Console.WriteLine("Giriş yapmak için 1 kayıt olmak için lütfen 2 tuşlayınız : ");
                int giris = Convert.ToInt32(Console.ReadLine());
                if (giris == 1)
                {
                    alici.UyeGirisi();
                    alici.Kitapalma();  
                }
                else if (giris == 2)
                {
                    alici.UyeKayıt();
                }
                else if (giris == 3)//3. kişi ile alaklaı bütün kodları metotoları buraya cağırcaksın
                {
                    yazar.yazarGiris();
                    yazar.yaziyaz();
                }
                else
                {
                    Console.WriteLine("Yanlış tercih yapıldı .");
                }
            }
            else
            {
                Console.WriteLine("Yanlış tercih yapıldı .");
            }




        }
    }
}


