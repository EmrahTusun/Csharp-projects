using System;

namespace GuvenlikSistemi
{
    public interface IGirisYontemi
    {
        void GirisYap(string kullanici, string sifre);
    }

    public class KlasikGiris : IGirisYontemi
    {
        public void GirisYap(string kullanici, string sifre)
        {
            Console.WriteLine($"{kullanici} için standart şifre kontrolü yapılıyor...");
            if (sifre == "1234") Console.WriteLine("Giriş Başarılı!");
            else throw new Exception("Hatalı şifre!"); 
        }
    }
    public class SMSGiris : IGirisYontemi
    {
        public void GirisYap(string kullanici, string sifre)
        {
            Console.WriteLine($"{kullanici} için telefona SMS kodu gönderildi...");
            Console.WriteLine("SMS Onayı Başarılı!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Akıllı Kimlik Doğrulama Merkezi ===");
            
            IGirisYontemi yontem;

            Console.WriteLine("Giriş Tipi: 1-Klasik, 2-SMS");
            string secim = Console.ReadLine();

            if (secim == "1") yontem = new KlasikGiris();
            else yontem = new SMSGiris();

            try 
            {
                Console.Write("Kullanıcı Adı: ");
                string user = Console.ReadLine();
                Console.Write("Şifre: ");
                string pass = Console.ReadLine();

                yontem.GirisYap(user, pass);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sistem Hatası: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}