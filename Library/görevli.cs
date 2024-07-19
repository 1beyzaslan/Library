using Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_sistemi3
{
    internal class görevli
    {
        static string DosyaYoluÜyeler = @"C:\Users\ASUS\Desktop\üyeler.txt";
        public static string yetkiliAdi = "YETKİLİ";
        public static string yetkiliSifresi = "123456";

        public static void yetkiliGirisi()
        {
            Console.WriteLine("Yetkili kullanıcı adınız : ");
            string yetkili_Adi = Console.ReadLine();
            Console.WriteLine("Yetkili şifreniz : ");
            string yetkili_Sifresi = Console.ReadLine();

            if (yetkiliAdi == yetkili_Adi && yetkiliSifresi == yetkili_Sifresi)
            {
                Console.WriteLine("Giriş Başarılı!");
                kitaplik.Kitapekle();
                kitaplik.Kitapsirala();
            }
            else
            {
                Console.WriteLine("YANLIŞ GİRİŞ.BURAYA BULAŞMA.");
            }
        }

        public void Kitapvarmiyokmu()
        {
            //listeleyip okutup kontrol edecek


        }
    }
    
}
