using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class kitap
    {
        public void Kitapalma()
        {//once kitap adı ve yazarını girisn sonra dosyayo açsın okuma yapsın eğer varsa traih girdirsin ve kitabı alsın eğer yoksa hiç tarih fln istemeyip direkt kitap mevcut deği desin

            // Kitap bilgilerini gir
            Console.Write("Kitap adı: ");
            string kitapadi = Console.ReadLine();

            Console.Write("Kitap yazarı: ");
            string kitapyazari = Console.ReadLine();

            Console.Write("Kitap numarası: ");
            int kitapnumarasi =Convert.ToInt32(Console.ReadLine());


            string dosyayolu = @"C:\Users\Beyza\Desktop\Library\Library\mevcutkitaplar.txt";
            bool kitapmevcutmu = false;

            StreamReader okumanesnesi = new StreamReader(dosyayolu);

            while (okumanesnesi.EndOfStream==false)
            {
             
                string satir = okumanesnesi.ReadLine();
                string[] parcalar=satir.Split(',');
                if (parcalar[0] == kitapnumarasi.ToString() && parcalar[1] == kitapadi && parcalar[2] == kitapyazari)
                {
                    kitapmevcutmu=true;
                }
            

            }
            okumanesnesi.Close();

            if (kitapmevcutmu == false)
                Console.WriteLine("Maalesef kitap mevcut değil");
            else
            {


                Console.Write("Kitap alım tarihi (yyyy-MM-dd): ");
                DateTime alimtarihi = DateTime.Parse(Console.ReadLine());

                Console.Write("Kitap teslim tarihi (yyyy-MM-dd): ");
                DateTime teslimtarihi = DateTime.Parse(Console.ReadLine());

                // Teslim tarihi 30 günü geçiyor mu kontrol et
                string kontrol = (teslimtarihi > alimtarihi.AddDays(30)) ? "Kitabı zamanında getirmediğiniz için cezalısınız bir kitap daha getiriniz" : "Zamanında teslim ettiğiniz için teşekkürler";

                // Kitap bilgilerini tek satırda formatla
                string dosyalama = $"{kitapnumarasi},{kitapadi},{kitapyazari},{alimtarihi:yyyy-MM-dd},{teslimtarihi:yyyy-MM-dd}";

                // Dosyaya yaz
                string dosyayolu1 = @"C:\Users\Beyza\Desktop\Library\Library\kitaplik.txt";//alınan kitaplar için txt

                StreamWriter yazmanesnesi1 = new StreamWriter(dosyayolu1, true);
                yazmanesnesi1.WriteLine(dosyalama);
                yazmanesnesi1.Close();
            }

        }

        public void Kitapteslim()
        {
            

        }

        public void Kitapvarmiyokmu()
        {
            //listeleyip okutup kontrol edecek


        }

    }
}
