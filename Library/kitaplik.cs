using System;
using System.Collections.Generic;
using System.IO;

namespace Library
{
    internal class kitaplik
    {//kitaplık mevcutlar txt,ekleme txt,kayıtlı kişi txt si,kitap alanın adı aldıgı tarihi vereceği tarihi tutacal txt,


    




        public static void Kitapsirala()
        {

            string dosyayolu = @"C:\Users\Beyza\Desktop\Library\Library\mevcutkitaplar.txt";
            List<string> kitapListesi = new List<string>();

            // Kitapları dosyadan oku
            string[] kitaplar = File.ReadAllLines(dosyayolu);
            kitapListesi.AddRange(kitaplar);

            // Kitapları alfabetik sıraya göre sırala
            kitapListesi.Sort();

            // Sıralı kitapları numaralandırarak dosyaya yaz
            using (StreamWriter yazmanesnesi = new StreamWriter(dosyayolu, false))
            {
                for (int i = 0; i < kitapListesi.Count; i++)
                {
                    string siraliKitap = $"{i + 1},{kitapListesi[i]}";
                    yazmanesnesi.WriteLine(siraliKitap);
                }
            }

            Console.WriteLine("Kitaplar alfabetik olarak sıralandı ve dosyaya yazıldı.");
        }


    }



}
