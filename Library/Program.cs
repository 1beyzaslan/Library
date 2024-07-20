using Library;
using System;

namespace Kütüphane_sistemi3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Yetkili girişi için 1      /       kullanıcı girişi için 2  /      yazar girişi için 3 tuşlayınız : ");
            int tuşlanan = Convert.ToInt32(Console.ReadLine());
            if (tuşlanan == 1)
            {
                görevli.yetkiliGirisi();
                Console.WriteLine(" yazarın yazdığı kitabı onaylayıp ekletmek için 1 e  /   kitapteslim kontrolü için 2 ye    /   sadece var olan kitabı kitaplığa ekelemk için 3 e basınız");

                int tercihyetkili = Convert.ToInt32(Console.ReadLine());

                if (tercihyetkili == 1)
                {
                    görevli.Kitapkontrol();
                    kitaplik.kitapekle();
                    kitaplik.Kitapsirala();
                    kitaplik.guncelsiraliliste();
                }
                else if (tercihyetkili == 2)
                {
                    görevli.Kitapvarmiyokmu();
                }
                else
                {
                    kitaplik.kitapekle();
                    kitaplik.Kitapsirala();
                    kitaplik.guncelsiraliliste();
                }



            }

            else if (tuşlanan == 2)//2. kişi ile alaklaı bütün kodları metotoları buraya cağırcaksın
            {
                Console.WriteLine("Giriş yapmak için 1 kayıt olmak için lütfen 2 tuşlayınız : ");
                int giris = Convert.ToInt32(Console.ReadLine());
                if (giris == 1)
                {
                    alici.UyeGirisi();
                    if (alici.DogruGirisYapıldıMı == true)
                    {
                        Console.WriteLine("kitap almak istiyorsanız 1 i vermek istiyorsanız 2 yi tuşlayın");

                        int basilan = Convert.ToInt32(Console.ReadLine());

                        if (basilan == 1)
                        {
                            alici.Kitapalma();
                        }
                        else if (basilan == 2)
                        {
                            alici.kitapverme();
                        }
                        else
                        {
                            Console.Write("Yanlış tuşa bastınız ");
                        }
                    }

                }
                else if (giris == 2)
                {
                    alici.UyeKayıt();
                }


                else if (giris == 3)//3. kişi ile alaklaı bütün kodları metotoları buraya cağırcaksın
                {
                    yazar.yazarGiris();
                    yazar.kitapyaz();
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

 
