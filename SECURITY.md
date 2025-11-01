# Güvenlik Politikası

## 🔒 Desteklenen Versiyonlar

Aşağıdaki versiyonlar güvenlik güncellemeleri almaktadır:

| Versiyon | Destekleniyor mu? |
| -------- | ----------------- |
| 1.0.x    | ✅ Evet            |
| < 1.0    | ❌ Hayır          |

## 🚨 Güvenlik Açığı Bildirimi

Eğer bir güvenlik açığı keşfettiyseniz, lütfen **doğrudan GitHub Issues'da paylaşmayın**. Bunun yerine:

1. **E-posta ile bildirin**: security@yourdomain.com (varsa)
2. **GitHub Security Advisory kullanın**: Repository'nin "Security" sekmesinden "Report a vulnerability" seçeneğini kullanın

Bildiriminizden sonra 48 saat içinde yanıt alacaksınız.

## 🔍 Güvenlik Denetimi

### Mevcut Güvenlik Önlemleri

✅ **Kimlik Doğrulama ve Yetkilendirme**
- ASP.NET Core Identity kullanılıyor
- E-posta doğrulaması gerekmektedir
- Role-based authorization implementasyonu

✅ **SQL Injection Koruması**
- Entity Framework Core kullanılıyor (parametreli sorgular)
- Raw SQL kullanımından kaçınılıyor

✅ **XSS Koruması**
- Razor Engine otomatik HTML encoding yapıyor
- Kullanıcı girdileri sanitize ediliyor

✅ **CSRF Koruması**
- ASP.NET Core anti-forgery token'ları kullanılıyor

⚠️ **İyileştirme Gereken Alanlar**

### 1. Dosya Yükleme Güvenliği

**Mevcut Durum:**
```csharp
// HomeworkController.cs:244-257
var uniqueFileName = $"{Guid.NewGuid()}_{Path.GetFileName(HomeworkFile.FileName)}";
```

**Riskler:**
- Dosya uzantısı kontrolü eksik
- Dosya boyutu limiti yok
- Dosya içeriği kontrolü yok
- Dosya tipi doğrulaması yok

**Öneriler:**
- İzin verilen dosya uzantılarını kontrol edin
- Maksimum dosya boyutu limiti ekleyin (örn: 10MB)
- Dosya içeriği taraması yapın
- Güvenli dosya adlandırma kullanın

### 2. Kimlik Doğrulama Ayarları

**Mevcut Durum:**
```csharp
// Program.cs:20
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
```

**İyileştirmeler:**
- Şifre güçlülük kurallarını artırın
- İki faktörlü kimlik doğrulama (2FA) ekleyin
- Oturum timeout süresi ayarlayın
- Şifre değiştirme zorunluluğu ekleyin

### 3. Rate Limiting

**Eksik:**
- Login denemeleri için rate limiting yok
- API endpoint'leri için rate limiting yok
- Dosya yükleme için rate limiting yok

**Öneriler:**
- `Microsoft.AspNetCore.RateLimiting` middleware'ini ekleyin
- Login endpoint'ine rate limiting uygulayın

### 4. Logging ve Monitoring

**Eksik:**
- Güvenlik olayları için loglama eksik
- Başarısız login denemeleri loglanmıyor
- Şüpheli aktiviteler izlenmiyor

**Öneriler:**
- Security event logging ekleyin
- Başarısız authentication denemelerini loglayın
- Anormal aktiviteleri tespit edin

### 5. Secrets Management

**Mevcut Durum:**
- Connection string'ler `appsettings.json`'da
- Production için User Secrets kullanılmalı

**Öneriler:**
- Production'da Azure Key Vault veya benzeri kullanın
- `appsettings.json`'a secrets eklemeyin
- Environment variables kullanın

### 6. HTTPS Zorunluluğu

**Mevcut Durum:**
```csharp
// Program.cs:39
app.UseHttpsRedirection();
```

✅ HTTPS redirection var, ancak production'da sertifika kontrolü gerekli.

### 7. CORS Ayarları

**Mevcut Durum:**
- `AllowedHosts: "*"` tüm hostlara izin veriyor

**Öneriler:**
- Production'da spesifik domain'ler belirtin
- CORS policy'si ekleyin (API kullanımı için)

### 8. Input Validation

**İyileştirme Gereken Alanlar:**
- Model validation güçlendirilmeli
- Custom validation attribute'ları eklenmeli
- SQL injection riski taşıyan string manipülasyonları kontrol edilmeli

## 🛡️ Güvenlik Checklist

### Development Ortamı
- [ ] Güçlü şifreler kullanın
- [ ] Geliştirme veritabanı production veritabanından ayrı olsun
- [ ] Test verileri production'a gitmesin

### Production Ortamı
- [ ] HTTPS sertifikası kurulu ve geçerli
- [ ] Connection string'ler environment variables'da
- [ ] Database backup'ları düzenli alınıyor
- [ ] Log dosyaları güvenli saklanıyor
- [ ] Güvenlik güncellemeleri takip ediliyor
- [ ] Penetrasyon testi yapıldı
- [ ] Dependency vulnerability taraması yapıldı

### Kod İncelemesi
- [ ] Hardcoded secrets yok
- [ ] SQL injection riski yok
- [ ] XSS koruması var
- [ ] CSRF koruması var
- [ ] Dosya yükleme güvenliği var
- [ ] Authentication/Authorization doğru çalışıyor

## 📚 Güvenlik Kaynakları

- [OWASP Top 10](https://owasp.org/www-project-top-ten/)
- [ASP.NET Core Security Best Practices](https://docs.microsoft.com/aspnet/core/security/)
- [CWE Top 25](https://cwe.mitre.org/top25/)

## 🔄 Güvenlik Güncellemeleri

Güvenlik güncellemeleri düzenli olarak kontrol edilmeli ve uygulanmalıdır:

```bash
# NuGet paketlerini güncelle
dotnet list package --outdated
dotnet add package PACKAGE_NAME --version LATEST_VERSION
```

## 📞 İletişim

Güvenlik sorunları için: security@yourdomain.com

**NOT**: Bu belge, projenin mevcut durumunu yansıtmaktadır ve sürekli güncellenmelidir.

