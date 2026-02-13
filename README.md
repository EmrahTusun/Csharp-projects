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

# C# Weather API - Canlı Hava Durumu Uygulaması
Bu uygulama, bir Bilgisayar Mühendisliği öğrencisi olarak C# dilinde **API entegrasyonu** ve **JSON veri işleme** konularını pratik etmek için geliştirdiğim bir projedir.

## Özellikler
* **Gerçek Zamanlı Veri:** OpenWeatherMap API kullanarak anlık hava durumu bilgilerini çeker.
* **Hata Yönetimi:** Geçersiz şehir girişlerinde veya bağlantı sorunlarında kullanıcıyı bilgilendirir.
* **Modern C# Yapısı:** `async/await` yapısı ile verimli bir asenkron çalışma sunar.

### Çalıştırma
Projeyi çalıştırmadan önce bağımlılıkları yüklemeyi unutmayın:
```bash
dotnet add package Newtonsoft.Json
