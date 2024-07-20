using System;
using System.IO;

namespace Kütüphane_sistemi3
{
    internal class yazar
    {
        //sayfaları yazacak ve bir kitap olarak kitapekle yapacak,tek yazra var

        public static string kitapadi = "";
        public static string yazarAdı = "Yazar";
        public static string yazarSifresi = "123456";
        public static string icerik = "";


        public static void yazarGiris()
        {
            Console.WriteLine("Yazar adını giriniz : ");
            string yazarAdı = Console.ReadLine();
            Console.WriteLine("Şifre giriniz : ");
            string yazarŞifre = Console.ReadLine();

            if (yazarAdı == yazarAdı && yazarŞifre == yazarSifresi)
            {
                Console.WriteLine("Giriş başarılı.");
            }
        }
        //   ------------------------------------------------------------------------------------------------------------------------------------------------------

        //yazar kitap yazacak
        public static void kitapyaz()
        {
            Console.WriteLine("kitap adını giriniz : ");
            string kitapadi = Console.ReadLine();

            Console.WriteLine("Yazar adını giriniz : ");
            string yazarAdı = Console.ReadLine();

            Console.WriteLine("kitabı yaz  : "); //yazar istediği kadar yazabilir 80 kelime kontrolünü gözetmen yapacak
            string icerik = Console.ReadLine();

            string kitaphali = kitapadi + "," + yazarAdı + "," + icerik;

            string dosya = @"C:\Users\Beyza\Desktop\Library\Library\kitap3.txt";


            StreamWriter yazmanesnesi = new StreamWriter(dosya, true); // 'false' parametresi dosyanın içeriğini temizler
            yazmanesnesi.WriteLine(kitaphali); // Her bir kitabı dosyaya yaz
            yazmanesnesi.Close();


            Console.WriteLine("Güncel sıralı liste dosyası başarıyla oluşturuldu ve yazıldı.");
        }




    }

}



