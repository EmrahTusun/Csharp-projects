using System;

namespace OkulProjelerim
{
    class Kitap
    {
        public string Ad;
        public string Yazar;
        public int SayfaSayisi;

        public void BilgileriGoster()
        {
            Console.WriteLine("\n--- Kayıt Edilen Kitap Bilgileri ---");
            Console.WriteLine("Kitap Adı    : " + Ad);
            Console.WriteLine("Yazarı       : " + Yazar);
            Console.WriteLine("Sayfa Sayısı : " + SayfaSayisi);
            Console.WriteLine("------------------------------------\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir kitap nesnesi oluşturuyoruz
            Kitap yeniKitap = new Kitap();

            Console.WriteLine("===== KİTAP KAYIT SİSTEMİ =====");

            // Kullanıcıdan bilgileri tek tek istiyoruz
            Console.Write("Kitabın Adını Giriniz: ");
            yeniKitap.Ad = Console.ReadLine(); // Metinsel veri alma

            Console.Write("Yazarın Adını Giriniz: ");
            yeniKitap.Yazar = Console.ReadLine();

            Console.Write("Sayfa Sayısını Giriniz: ");
            // DİKKAT: Console.ReadLine() her şeyi string (metin) alır. 
            // Sayı lazım olduğu için Convert.ToInt32 ile tam sayıya çeviriyoruz.
            string girilenSayfa = Console.ReadLine();
            yeniKitap.SayfaSayisi = Convert.ToInt32(girilenSayfa);

            // Bilgileri ekrana basan fonksiyonu çağırıyoruz
            yeniKitap.BilgileriGoster();

            Console.WriteLine("Kayıt başarılı! Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}