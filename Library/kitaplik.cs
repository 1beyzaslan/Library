using System;
using System.Collections.Generic;
using System.IO;

namespace Library
{
    internal class kitaplik
    {//kitaplık mevcutlar txt,ekleme txt,kayıtlı kişi txt si,kitap alanın adı aldıgı tarihi vereceği tarihi tutacal txt,
     //yada yeni bir dosya da açarım eklenme olup sıralandıktan sonra her seferinde başka bir açtıgım txt dosyasını silerim oraya tekrar sıralı olarak yazarım bunu APPEND  MODU FALSE OLARAK YAP



        public static void kitapekle()
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

            Kitapsirala();

        }

        //   ------------------------------------------------------------------------------------------------------------------------------------------------------

        public static void Kitapsirala()//kitap eklemeden once txt  dosyasını açıp kitap numalaraını silcek kitabı ekleyecek sonra sıralayack
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
                    string siraliKitap = $"{i + 1},{kitapListesi[i]}";//i 0 dan başladığı için i + 1  diyorum
                    yazmanesnesi.WriteLine(siraliKitap);
                }
            }
        }


        //   ------------------------------------------------------------------------------------------------------------------------------------------------------

        public static void guncelsiraliliste()//kitapları tekrar sıralatıp güncel olarak yazmak istedim

        {

            string dosyayolu = @"C:\Users\Beyza\Desktop\Library\Library\mevcutkitaplar.txt";
            string siralidosyayolu = @"C:\Users\Beyza\Desktop\Library\Library\guncelsiraliliste.txt";

            List<string> kitapListesi = new List<string>();



            // Kitapları dosyadan oku
            string[] kitaplar = File.ReadAllLines(dosyayolu);
            kitapListesi.AddRange(kitaplar);

            // Dosyanın içeriğini temizle ve üzerine yaz
            using (StreamWriter yazmanesnesi = new StreamWriter(siralidosyayolu, false)) // 'false' parametresi dosyanın içeriğini temizleyecem ve s
            {
                foreach (string kitap in kitapListesi)
                {
                    yazmanesnesi.WriteLine(kitap); // Her bir kitabı dosyaya yaz
                }
            }

            Console.WriteLine("Güncel sıralı liste dosyası başarıyla oluşturuldu ve yazıldı.");



        }

    }



}
