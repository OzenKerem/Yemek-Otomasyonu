# Yemek Otomasyonu

Modern arayüzlü, Türk mutfağı odaklı bir yemek kategorileri ve tarifleri sunan Windows Forms uygulaması.

![Uygulama Ekran Görüntüsü](screenshots/app_screenshot.png)

## 🍽️ Proje Hakkında

Bu proje, kullanıcıların farklı kategorilerdeki Türk yemeklerini keşfetmesine olanak tanıyan bir C# Windows Forms uygulamasıdır. Uygulama, kategorilere göre yemekleri listeler, her yemeğin detaylı açıklamasını, görselini ve tarifini sunarak kullanıcılara zengin bir deneyim sağlar.

## ✨ Özellikler

- **Kategori Bazlı Listeleme**: Ana Yemekler, Çorbalar, Tatlılar, Salatalar ve diğer kategorilerdeki yemekleri kolayca görüntüleme
- **Yemek Detayları**: Seçilen yemeğin açıklaması ve resmini görüntüleme
- **Tarif Görüntüleme**: Detaylı malzeme listesi ve hazırlanış adımlarını içeren tarifler
- **Yemek Önerisi**: "Bugün Ne Yesem?" özelliği ile rastgele yemek önerisi alma
- **Modern Arayüz**: Koyu tema (dark mode) ve yuvarlak köşeli bileşenlerden oluşan şık tasarım

## 🛠️ Teknolojiler

- **Dil**: C#
- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms
- **Veritabanı**: SQL Server (MSSQL)

## 📋 Kurulum

1. Projeyi klonlayın:
```
git clone https://github.com/OzenKerem/Yemek-Otomasyonu.git
```

2. Visual Studio'da çözümü açın:
```
denem1.sln
```

3. SQL Server veritabanınızı oluşturun:
   - SQL Server Management Studio'da `sqlQuery1.sql` dosyasını çalıştırın
   - Bu script otomatik olarak OTOMASYON1 veritabanını ve Yemekler tablosunu oluşturur
   - Örnek yemek verileri de otomatik olarak eklenir

4. Bağlantı dizesini güncelleyin:
   - Form1.cs dosyasındaki connectionString değişkenini kendi SQL Server yapılandırmanıza göre düzenleyin:
   ```csharp
   private string connectionString = "Server=.;Database=OTOMASYON1;Integrated Security=True;";
   ```

5. Projeyi derleyin ve çalıştırın.

## 🖼️ Resimler Hakkında

Uygulamadaki yemek görselleri için:
- `/resimler` klasörü içinde örnek resimler yer almaktadır
- Veritabanındaki Resim alanında belirtilen dosya yollarının bilgisayarınızdaki gerçek konumlarla eşleştiğinden emin olun
- Eğer resimleri bulamazsanız, uygulama alternatif olarak `Application.StartupPath\resimler\` dizininde de kontrol eder

## 🗄️ Veritabanı Yapısı

**Yemekler Tablosu**
| Alan | Tip | Açıklama |
|------|-----|----------|
| ID | INT | Primary Key, Identity |
| YemekAdi | NVARCHAR(100) | Yemeğin adı |
| Kategori | NVARCHAR(50) | Yemeğin kategorisi (Ana Yemekler, Çorbalar vb.) |
| Aciklama | NVARCHAR(500) | Yemek hakkında kısa açıklama |
| Resim | NVARCHAR(255) | Yemek görselinin dosya yolu |
| Tarif | NVARCHAR(MAX) | Malzemeler ve hazırlanış adımlarını içeren tarif |

## 👨‍💻 Geliştirme

Bu projeyi daha da geliştirebilmek için:

1. **Yeni Kategori/Yemek Ekleme**: Admin paneli ile yeni kategoriler ve yemekler ekleme özelliği
2. **Arama Fonksiyonu**: Yemekler arasında arama yapma özelliği
3. **Favori Yemekler**: Kullanıcıların favori yemeklerini kaydetme özelliği
4. **Çoklu Dil Desteği**: Türkçe dışında diğer dillerde de kullanım imkanı
5. **Baskı Desteği**: Tarifleri yazdırma özelliği

## 📄 Lisans

Bu proje [MIT Lisansı](LICENSE) altında lisanslanmıştır.

## 📞 İletişim

Sorularınız için: [GitHub Profili](https://github.com/OzenKerem)