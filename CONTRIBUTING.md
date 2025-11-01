# Katkıda Bulunma Rehberi

Classroom projesine katkıda bulunmak istediğiniz için teşekkür ederiz! Bu rehber, projeye nasıl katkıda bulunabileceğinizi açıklar.

## 🎯 Katkıda Bulunma Yolları

- 🐛 Hata bildirimi
- 💡 Yeni özellik önerileri
- 📝 Dokümantasyon iyileştirmeleri
- 🔧 Kod iyileştirmeleri
- ✅ Test yazımı

## 📋 Katkıda Bulunma Süreci

### 1. Projeyi Fork Edin

GitHub'da projeyi fork edin ve yerel bilgisayarınıza klonlayın:

```bash
git clone https://github.com/YOUR_USERNAME/Classroom.git
cd Classroom
```

### 2. Development Branch Oluşturun

Ana branch'ten yeni bir branch oluşturun:

```bash
git checkout -b feature/amazing-feature
# veya
git checkout -b fix/bug-description
```

### 3. Değişikliklerinizi Yapın

- Kod değişikliklerinizi yapın
- Kod standartlarına uyun (C# coding conventions)
- Gerekli testleri yazın
- Dokümantasyonu güncelleyin

### 4. Değişikliklerinizi Test Edin

```bash
# Uygulamayı çalıştırın
dotnet run

# Testleri çalıştırın (varsa)
dotnet test

# Migration'ları kontrol edin
dotnet ef migrations list
```

### 5. Commit Yapın

Anlamlı commit mesajları yazın:

```bash
git add .
git commit -m "feat: yeni özellik eklendi"
# veya
git commit -m "fix: hata düzeltildi"
```

**Commit Mesaj Formatı:**
- `feat:` Yeni özellik
- `fix:` Hata düzeltmesi
- `docs:` Dokümantasyon değişikliği
- `style:` Kod formatlama
- `refactor:` Kod refaktoring
- `test:` Test ekleme/düzeltme
- `chore:` Build, konfigürasyon değişiklikleri

### 6. Push ve Pull Request Oluşturun

```bash
git push origin feature/amazing-feature
```

GitHub'da Pull Request oluşturun ve şunları ekleyin:
- Değişikliklerin açıklaması
- İlgili issue numarası (varsa)
- Test sonuçları
- Ekran görüntüleri (UI değişiklikleri için)

## 📝 Kod Standartları

### C# Kod Standartları

- 4 boşluk indentasyon kullanın (tab değil)
- PascalCase kullanın (sınıf, metod, property isimleri)
- camelCase kullanın (yerel değişkenler, parametreler)
- Açıklayıcı değişken ve metod isimleri kullanın
- Gereksiz yorumlar yazmayın, kendini açıklayan kod yazın
- Her public metod için XML dokümantasyon yorumu ekleyin

### Örnek Kod Formatı

```csharp
/// <summary>
/// Sınıf oluşturur ve veritabanına kaydeder.
/// </summary>
/// <param name="model">Sınıf modeli</param>
/// <returns>Oluşturulan sınıf ID'si</returns>
public IActionResult CreateClassRoom(ClassRoom model)
{
    if (model == null)
    {
        return BadRequest();
    }
    
    // İş mantığı...
    
    return Ok();
}
```

### Dosya Organizasyonu

- Her controller kendi dosyasında olmalı
- Modeller `Models/` klasöründe
- ViewModeller `ViewModels/` klasöründe
- Data access kodları `Data/` klasöründe

## 🧪 Test Yazımı

- Yeni özellikler için unit test yazın
- Critical path'ler için integration test yazın
- Test coverage'ı artırmaya çalışın

## 📚 Dokümantasyon

- README.md dosyasını güncelleyin (gerekirse)
- Kod yorumlarını İngilizce veya Türkçe yazabilirsiniz
- Yeni API endpoint'leri için dokümantasyon ekleyin

## 🔍 Code Review Süreci

1. Pull Request'iniz otomatik olarak CI kontrollerinden geçecek
2. Maintainer'lar kodunuzu inceleyecek
3. Geri bildirim alırsanız, lütfen değişiklikleri yapın
4. Onaylandıktan sonra merge edilecektir

## ❓ Sorularınız mı Var?

Herhangi bir sorunuz varsa:
- Bir [Issue](https://github.com/YOUR_USERNAME/Classroom/issues) oluşturun
- Discussions bölümünde soru sorun

## 📜 Davranış Kuralları

Lütfen şu kurallara uyun:
- Saygılı ve profesyonel olun
- Yapıcı geri bildirimde bulunun
- Farklı görüşlere açık olun
- Topluluk üyelerine destek olun

Teşekkürler! 🎉

