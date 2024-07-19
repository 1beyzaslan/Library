using Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_sistemi3
{
    internal class yazar
    {
        //sayfaları buraya yazın yapın


        public static string yazarAdı = "YAZAR";
        public static string yazarSifresi = "YAZAR1234";

        public static void yazarGiris()
        {
            Console.WriteLine("Yazar adını giriniz : ");
            string YazarAdı = Console.ReadLine();
            Console.WriteLine("Şifre giriniz : ");
            string yazarŞifre = Console.ReadLine();

            if (YazarAdı == yazarAdı && yazarŞifre == yazarSifresi)
            {
                Console.WriteLine("Giriş başarılı.");
            }
        }

        //yazar kitap ekleyecek
        public static void yaziyaz()
        {
            // Kitap bilgilerini gir
            Console.Write("Kitap adı: ");
            string kitapadi = Console.ReadLine();

            Console.Write("Kitap yazarı: ");
            string kitapyazari = Console.ReadLine();

            // Kitap bilgilerini tek satırda formatla
            string dosyalama = $"{kitapadi},{kitapyazari}";

            // Dosyaya yaz
            string dosyayolu = @"C:\Users\Beyza\Desktop\Library\Library\mevcutkitaplar.txt";
            StreamWriter yazmanesnesi = new StreamWriter(dosyayolu, true);
            yazmanesnesi.WriteLine(dosyalama);
            yazmanesnesi.Close();


            Console.WriteLine("Kitap bilgileri dosyaya yazıldı.");

        }
    }


}
