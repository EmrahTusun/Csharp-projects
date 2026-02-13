using System;
using System.Net.Http; //İnternet bağlantısı için
using System.Threading.Tasks; //Asenkron (async/await) yapı için
using Newtonsoft.Json.Linq; //JSON verisini ayıklamak için

namespace HavaDurumuApp
{
    class Program
    {
        // Main metodunu async yapıyoruz çünkü internetten veri bekleyeceğiz
        static async Task Main(string[] args)
        {
            string apiKey = "fd4b7dc99d9cedecf7c33e0eae42e7e0";
            
            Console.WriteLine("=== C# Canlı Hava Durumu Uygulaması ===");
            Console.Write("Hangi şehrin hava durumunu öğrenmek istersin?: ");
            string sehir = Console.ReadLine();

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={sehir}&appid={apiKey}&units=metric&lang=tr";

            using (HttpClient istemci = new HttpClient())
            {
                try
                {
                    // İnternetten veriyi çekme
                    string cevap = await istemci.GetStringAsync(url);

                    // Gelen karmaşık metni (JSON) nesneye dönüştürme
                    JObject veri = JObject.Parse(cevap);

                    // JSON içindeki spesifik bilgileri çekiyoruz
                    string durum = veri["weather"][0]["description"].ToString();
                    double derece = (double)veri["main"]["temp"];
                    int nem = (int)veri["main"]["humidity"];
                    double ruzgar = (double)veri["wind"]["speed"];

                    // Sonuçları ekrana basma
                    Console.WriteLine("\n------------------------------------");
                    Console.WriteLine($"{sehir.ToUpper()} İÇİN HAVA DURUMU:");
                    Console.WriteLine($"Sıcaklık: {derece}°C");
                    Console.WriteLine($"Durum   : {durum}");
                    Console.WriteLine($"Nem     : %{nem}");
                    Console.WriteLine($"Rüzgar  : {ruzgar} m/s");
                    Console.WriteLine("------------------------------------\n");
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine("\nHata: İnternet bağlantısı kurulamadı veya şehir ismi yanlış.");
                }
                catch (Exception ex)
                {
                    // Herhangi bir hata olursa burada görülür.
                    Console.WriteLine("\nBeklenmedik bir hata oluştu: " + ex.Message);
                }
            }

            Console.WriteLine("Kapatmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}