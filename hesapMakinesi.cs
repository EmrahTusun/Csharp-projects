using System;
using System.IO; // Dosya işlemleri için

namespace AkilliHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = "islem_gecmisi.txt";

            Console.WriteLine("=== C# Akıllı Hesap Makinesi (Log Destekli) ===");
            
            while (true)
            {
                Console.Write("\n1. Sayı: ");
                double s1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İşlem (+, -, *, /) veya Çıkış (q): ");
                string islem = Console.ReadLine();

                if (islem == "q") break;

                Console.Write("2. Sayı: ");
                double s2 = Convert.ToDouble(Console.ReadLine());

                double sonuc = 0;
                if (islem == "+") sonuc = s1 + s2;
                else if (islem == "-") sonuc = s1 - s2;
                else if (islem == "*") sonuc = s1 * s2;
                else if (islem == "/") sonuc = s1 / s2;

                string rapor = $"{s1} {islem} {s2} = {sonuc}";
                Console.WriteLine("Sonuç: " + sonuc);

                // AKILLI ÖZELLİK: İşlemi dosyaya kaydet
                File.AppendAllText(dosyaYolu, rapor + " | Tarih: " + DateTime.Now + Environment.NewLine);
                Console.WriteLine("İşlem geçmişe kaydedildi.");
            }
        }
    }
}