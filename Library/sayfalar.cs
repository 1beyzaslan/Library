using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class sayfalar
    {
        public void Kitapyaz()
        {
            string dosyayolu = @"C:\Users\Beyza\Desktop\Library\Library\mevcutkitaplar.txt";

            StreamReader okumanesnesi = new StreamReader(dosyayolu);
            string satir = okumanesnesi.ReadToEnd();
            string[] dosya=File.ReadAllLines(dosyayolu);
            Console.WriteLine(dosya);

       
            okumanesnesi.Close();

        }
    }
}
