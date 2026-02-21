# C# Yazılım Geliştirme Projeleri
Bu depo, modern C# ve .NET ekosistemi kullanılarak geliştirilmiş yazılım projelerimi içermektedir. Odak noktam Nesne Yönelimli Programlama (OOP) prensipleri ve temiz kod (Clean Code) yazımıdır.
## Proje 1: Dinamik Kitap Kayıt Konsol Uygulaması
###  Proje Hakkında
Bu uygulama, C# dilindeki **Sınıf (Class)** yapısını ve **Kullanıcı Etkileşimi (Console Input/Output)** mantığını kavramak için geliştirilmiştir. Sabit veriler yerine, kullanıcının o an girdiği bilgileri bir nesne (Object) içerisinde saklar ve yönetir.
### Teknik Kazanımlar
* **OOP Temelleri:** Gerçek hayattaki bir nesneyi (Kitap) sınıf yapısı ile dijital ortama aktardım.
* **Veri Alma ve Dönüştürme:** `Console.ReadLine()` ile metin (string) verisi almayı ve `Convert.ToInt32()` ile bu veriyi sayısal tiplere (int) dönüştürmeyi uyguladım.
* **Metot Kullanımı:** Sınıf içerisindeki verileri düzenli bir formatta ekrana basmak için özel bir metot (`BilgileriGoster`) tanımladım.
### Kurulum ve Çalıştırma
1. Bu projeyi bilgisayarınıza indirin.
2. Visual Studio veya herhangi bir C# derleyicisi (VS Code + .NET SDK vb.) ile açın.
3. `Program.cs` dosyasını derleyip çalıştırın.
## Proje 2:C# Weather API - Canlı Hava Durumu Uygulaması
Bu uygulama, bir Bilgisayar Mühendisliği öğrencisi olarak C# dilinde **API entegrasyonu** ve **JSON veri işleme** konularını pratik etmek için geliştirdiğim bir projedir.
### Özellikler
* **Gerçek Zamanlı Veri:** OpenWeatherMap API kullanarak anlık hava durumu bilgilerini çeker.
* **Hata Yönetimi:** Geçersiz şehir girişlerinde veya bağlantı sorunlarında kullanıcıyı bilgilendirir.
* **Modern C# Yapısı:** `async/await` yapısı ile verimli bir asenkron çalışma sunar.
### Çalıştırma
Projeyi çalıştırmadan önce bağımlılıkları yüklemeyi unutmayın:
```bash
dotnet add package Newtonsoft.Json
```
## Proje 3: C# Smart Calculator - Geçmiş Kayıtlı Hesap Makinesi
Bu proje, temel matematiksel işlemlerin ötesinde, verilerin kalıcılığını (Data Persistence) sağlamak amacıyla geliştirilmiş bir sistem aracıdır.
### Proje Hakkında
Klasik hesap makinelerinden farklı olarak, yapılan her başarılı işlemi tarih ve saat bilgisiyle birlikte `islem_gecmisi.txt` dosyasına otomatik olarak raporlar. 
### Teknik Kazanımlar
* **File System Access:** `System.IO` kütüphanesi ile dosya oluşturma ve üzerine veri ekleme (`AppendAllText`) işlemlerini uyguladım.
* **Control Flow:** `while(true)` döngüsü ile kesintisiz bir kullanıcı deneyimi sağladım.
* **Data Logging:** Yazılım dünyasında çok kritik olan "Log tutma" mantığını projeye entegre ettim.
* **Date & Time:** `DateTime.Now` kullanarak sistem saatini dinamik olarak çektim.
### Kullanım
Programı çalıştırıp işlemlerinizi yapın. Program kapansa bile, aynı klasörde oluşan `.txt` dosyasından eski işlemlerinizi kontrol edebilirsiniz.
## Proje4: C# Password Manager & Strength Checker
Bu proje, temel veri girişi ve dosya yönetiminin ötesinde, kullanıcı güvenliğini ön planda tutan bir şifre yönetim aracıdır.
### Proje Hakkında
Uygulama, kullanıcının girdiği şifreleri belirli kriterlere (uzunluk, büyük harf, rakam, sembol) göre analiz eder ve bir güven puanı oluşturur. Ardından bu verileri tarih damgasıyla birlikte bir metin dosyasında arşivler.
### Teknik Kazanımlar
* **LINQ (Language Integrated Query):** Karakter dizileri içerisinde hızlı ve modern arama tekniklerini kullandım.
* **Security Analysis:** Şifre karmaşıklığını ölçen bir algoritma tasarladım.
* **File I/O:** Verilerin kalıcı olarak saklanması için dosya sistemini kullandım.
* **Conditional Logic:** Skor tabanlı geri bildirim sistemini kurdum.
### Nasıl Çalışır?
1. Uygulama adını ve şifreyi girersiniz.
2. Program şifrenizi analiz edip size % üzerinden bir puan verir.
3. Sonuçlar `sifreler.txt` dosyasına "log" mantığıyla kaydedilir.
##  Proje5: JSON-Based Task Manager (Data Persistence)
Bu proje, verilerin çalışma zamanı (runtime) dışında nasıl saklanacağını ve yönetileceğini (Persistent Data) anlamak amacıyla geliştirilmiştir.
### Proje Hakkında
Uygulama, klasik bir "To-Do List" mantığında çalışır ancak verileri bir veritabanı gibi **JSON** dosyasında saklar. Bu sayede program kapatılsa bile veriler kaybolmaz.
### Teknik Kazanımlar
* **JSON Serialization:** Nesneleri diskte saklanabilir metin formatına dönüştürme yeteneği kazandım.
* **File I/O & Persistence:** Verilerin kalıcılığını sağlamak için dosya sistemini bir "Mini-DB" olarak kullandım.
* **Collections (List<T>):** Dinamik veri listelerini yönetme ve filtreleme süreçlerini uyguladım.
