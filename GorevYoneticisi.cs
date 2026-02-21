using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GorevApp
{
    public class Gorev
    {
        public string Baslik { get; set; }
        public bool TamamlandiMi { get; set; }
    }

    class Program
    {
        static string dosyaYolu = "gorevler.json";
        static List<Gorev> gorevler = new List<Gorev>();

        static void Main(string[] args)
        {
            VerileriYukle();
            while (true)
            {
                Console.WriteLine("\nAKILLI GÖREV YÖNETİCİSİ");
                Console.WriteLine("1.Görev Ekle | 2.Görevleri Listele | 3.Kaydet ve Çık");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.Write("Görev Başlığı: ");
                    string baslik = Console.ReadLine();
                    gorevler.Add(new Gorev { Baslik = baslik, TamamlandiMi = false });
                }
                else if (secim == "2")
                {
                    Console.WriteLine("\nGÖREV LİSTESİ");
                    foreach (var g in gorevler)
                    {
                        string durum = g.TamamlandiMi ? "[X]" : "[ ]";
                        Console.WriteLine($"{durum} {g.Baslik}");
                    }
                }
                else if (secim == "3")
                {
                    VerileriKaydet();
                    break;
                }
            }
        }

        static void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(gorevler, Formatting.Indented);
            File.WriteAllText(dosyaYolu, json);
            Console.WriteLine("Veriler kaydedildi!");
        }

        static void VerileriYukle()
        {
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                gorevler = JsonConvert.DeserializeObject<List<Gorev>>(json);
            }
        }
    }
}