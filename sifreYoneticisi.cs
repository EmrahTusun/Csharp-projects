using System;
using System.IO;
using System.Linq; //Karakter kontrolü için

namespace SifreYoneticisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Akıllı Şifre Kasası ve Güvenlik Analizi ===");
            
            Console.Write("Hangi uygulama için şifre gireceksiniz? (Örn: GitHub): ");
            string uygulama = Console.ReadLine();

            Console.Write("Şifrenizi girin: ");
            string sifre = Console.ReadLine();

            // 1. ADIM: Şifre Gücü Analizi
            int puan = 0;
            if (sifre.Length >= 8) puan += 25;
            if (sifre.Any(char.IsUpper)) puan += 25;
            if (sifre.Any(char.IsDigit)) puan += 25;
            if (sifre.Any(char.IsSymbol) || sifre.Any(char.IsPunctuation)) puan += 25;

            Console.WriteLine($"\nŞifre Güvenlik Skoru: %{puan}");

            if (puan < 50) 
                Console.WriteLine("Uyarı: Şifreniz çok zayıf!");
            else 
                Console.WriteLine("Şifreniz güvenli görünüyor.");

            // 2. ADIM: Kayıt Tutma
            string kayit = $"{DateTime.Now} | Uygulama: {uygulama} | Sifre: {sifre} | Skor: %{puan}";
            File.AppendAllText("sifreler.txt", kayit + Environment.NewLine);

            Console.WriteLine("\nBilgiler başarıyla şifreler.txt dosyasına kaydedildi.");
            Console.ReadKey();
        }
    }
}