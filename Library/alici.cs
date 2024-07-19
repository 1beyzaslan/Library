using Kütüphane_sistemi3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_sistemi3
{
    internal class alici
    {
        static string DosyaYoluÜyeler = @"C:\Users\ASUS\Desktop\üyeler.txt";
        static bool DogruGirisYapıldıMı = false;

        public static void UyeGirisi()
        {
            Console.Write("TC KİMLİK NO : ");
            string tc = Console.ReadLine();
            Console.Write("ŞİFRENİZ : ");
            string sifre = Console.ReadLine();


            string satir;
            StreamReader okumaNesnesi2 = new StreamReader(DosyaYoluÜyeler);

            while ((satir = okumaNesnesi2.ReadLine()) != null)
            {
                string[] parcalar = satir.Split('*');
                if (parcalar[0] == tc && parcalar[4] == sifre)
                {
                    Console.WriteLine("HOŞGELDİNİZ ! SAYIN " + parcalar[1]);
                    DogruGirisYapıldıMı = true;
                    break;
                }
            }
            Console.ReadLine();

            okumaNesnesi2.Close();
            if (DogruGirisYapıldıMı == false)
            {
                Console.WriteLine("Kayıt bulunamadı.Kayıt oluşturmak ister misiniz ? (E/H) : ");
                string tuş = Console.ReadLine();
                if (tuş == "E" && tuş == "e")
                {
                    UyeKayıt();
                }
            }

        }



        public static void UyeKayıt()
        {
            string satir = "";
            Console.Write("TC KİMLİK NUMARANIZ : ");
            string tc = Console.ReadLine();
            Console.Write("ADINIZ : ");
            string isim = Console.ReadLine();
            Console.Write("SOYADINIZ : ");
            string soyisim = Console.ReadLine();
            Console.Write("TELEFON NUMARANIZ : ");
            string telno = Console.ReadLine();
            Console.Write("ŞİFRE BELİRLEYİNİZ : ");
            string sifre1 = Console.ReadLine();
            Console.Write("YENİ ŞİFRENİZİ TEKRAR GİRİNİZ : ");
            string sifre2 = Console.ReadLine();
            if (sifre1 == sifre2)
            {
                satir = tc + "" + isim + "" + soyisim + "" + telno + "" + sifre1;
            }
            else
            {
                Console.WriteLine("Girdiğiniz iki şifre hatalıdır.Tekrar deneyiniz.");
                Console.WriteLine("ŞİFRE BELİRLEYİNİZ : ");
                string sifre3 = Console.ReadLine();
                Console.WriteLine("YENİ ŞİFRENİZİ TEKRAR GİRİNİZ : ");
                string sifre4 = Console.ReadLine();
                if (sifre3 == sifre4)
                {
                    satir = tc + "" + isim + "" + soyisim + "" + telno + "" + sifre3;
                }
                else
                {
                    Console.WriteLine("Tekrar hatalı giriş yapıldı.");
                    Console.WriteLine("Güvenliğiniz için program kapatılıyor...");
                    Environment.Exit(0);
                }
            }

            StreamWriter yazmaNesnesi = new StreamWriter(DosyaYoluÜyeler, true);
            yazmaNesnesi.WriteLine(satir);
            yazmaNesnesi.Close();

        }

        public static void Kitapalma()
        {//once kitap adı ve yazarını girisn sonra dosyayo açsın okuma yapsın eğer varsa traih girdirsin ve kitabı alsın eğer yoksa hiç tarih fln istemeyip direkt kitap mevcut deği desin

            // Kitap bilgilerini gir

            Console.Write(" TC Kimlik no giriniz ");
            string tc = Console.ReadLine();

            Console.Write("Kitap adı: ");
            string kitapadi = Console.ReadLine();

            Console.Write("Kitap yazarı: ");
            string kitapyazari = Console.ReadLine();

            Console.Write("Kitap numarası: ");
            int kitapnumarasi = Convert.ToInt32(Console.ReadLine());


            string dosyayolu = @"C:\Users\Beyza\Desktop\Library\Library\mevcutkitaplar.txt";
            bool kitapmevcutmu = false;

            StreamReader okumanesnesi = new StreamReader(dosyayolu);

            while (okumanesnesi.EndOfStream == false)
            {

                string satir = okumanesnesi.ReadLine();
                string[] parcalar = satir.Split(',');

                if (parcalar[0] == tc.ToString() && parcalar[1] == kitapnumarasi.ToString() && parcalar[2] == kitapadi && parcalar[3] == kitapyazari)
                {
                    kitapmevcutmu = true;
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

            //kitap alma-iade etme metodu



        }
    }
}
