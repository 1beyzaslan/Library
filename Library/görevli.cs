using System;
using System.Collections.Generic;
using System.IO;

namespace Kütüphane_sistemi3
{
    internal class görevli
    {//kitap ekleme yapabilir,kitapteslimalabilir,kitap var mı yok mu kontrolüne göre kitap verebilir
        public static string yetkiliAdi = "yetkili";
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
            }
            else
            {
                Console.WriteLine("YANLIŞ GİRİŞ.BURAYA BULAŞMA.");
            }
        }
        //   ------------------------------------------------------------------------------------------------------------------------------------------------------


        public static void Kitapkontrol()//yazarın yazdıgı kitabı kontrol edecek sayfasına geleni
        {

            string dosyaYolu = @"C:\Users\Beyza\Desktop\Library\Library\kitap1.txt";//hangi kitaba bakmak istiyorsa onun adını txt olarak buraya dosya yoluna yazcak

            // dosyayı okuma nesnesi
            StreamReader okumaNesnesi = new StreamReader(dosyaYolu);
            List<string> kitapMetni = new List<string>();
            while (!okumaNesnesi.EndOfStream)
            {
                string satir = okumaNesnesi.ReadLine();
                kitapMetni.Add(satir);// Her satırı okuyup  kitapmetni listesine ekleyecegiz ve burdan okuma yapacagız
            }
            okumaNesnesi.Close();

            // okuma kısmını kapattık şimdi tüm metni tek bir metin haline getirmeye calışıcaz ve consol ekranında görevliye göstercem 80 kelimeli olarak sayfalayacaz
            string tamMetin = string.Join(" ", kitapMetni);//kitap metnini birleştirip her split arasına boşluk koyar ve  tek metin haline getiririz
            string[] kelimeler = tamMetin.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//tamMetin metnini ' ' boşluk olarak  böler ve her bir parçayı kelimeler dizisine yerleştirir.
            // Sayfa başına 80 kelime
            int kelimeSayisi = 80;
            int sayfaNo = 1;

            List<string> sayfaKelimeleri = new List<string>();
            if (kelimeler.Length <= kelimeSayisi)
            {
                // Eğer kelime sayısı 80 veya daha azsa, tüm metni tek bir sayfada göster
                Console.WriteLine($"Sayfa {sayfaNo}:");
                Console.WriteLine(tamMetin);//o sayfadaki tam metni yazdırcaz
                Console.WriteLine(new string('-', 50)); // Sayfalar arası ayraç
            }
            else
            {
                for (int i = 0; i < kelimeler.Length; i++)//kelimeler dizisindeki her bir kelimeyi sayfaKelimeleri listesine ekler.

                {
                    sayfaKelimeleri.Add(kelimeler[i]);

                    if (sayfaKelimeleri.Count == kelimeSayisi || i == kelimeler.Length - 1)// Eğer döngüdeki son kelimeye ulaşılmışsa  
                    {
                        Console.WriteLine($"Sayfa {sayfaNo}:");
                        Console.WriteLine(string.Join(" ", sayfaKelimeleri));
                        Console.WriteLine(new string('-', 50)); // Sayfalar arası ayraç

                        sayfaKelimeleri.Clear();//sayfaKelimeleri listesini temizler, yani içindeki tüm kelimeleri kaldırır. Bu, bir sonraki sayfa için hazır hale getirir.
                        //burda direkt consol ekranına gelecek sayfalar
                        sayfaNo++;
                    }
                }

            }


        }
        //   ------------------------------------------------------------------------------------------------------------------------------------------------------


        public static void Kitapvarmiyokmu()
        {
            //listeleyip okutup kontrol edecek
        }
    }

}
