# Changelog

Tüm önemli değişiklikler bu dosyada dokümante edilecektir.

Format [Keep a Changelog](https://keepachangelog.com/tr/1.0.0/) standardına göre,
ve bu proje [Semantic Versioning](https://semver.org/lang/tr/) kullanmaktadır.

## [1.0.0] - 2024-01-XX

### Eklenenler
- ✅ Sınıf oluşturma ve yönetme özelliği
- ✅ Benzersiz kod ile sınıfa katılma sistemi
- ✅ Ödev oluşturma, gönderme ve değerlendirme sistemi
- ✅ Duyuru paylaşımı ve yorumlama özelliği
- ✅ Öğretmen değerlendirme sistemi
- ✅ Öğrenci ve öğretmen rolleri
- ✅ Sınıf arşivleme ve geri getirme özelliği
- ✅ Dosya yükleme desteği (ödevler için)
- ✅ ASP.NET Core Identity ile kimlik doğrulama
- ✅ Entity Framework Core ile veritabanı yönetimi
- ✅ Responsive tasarım (Bootstrap 5)
- ✅ Öğrenci listesi ve öğretmen atama özelliği
- ✅ Ödev notlandırma sistemi
- ✅ Ödev teslim tarihi takibi

### Değiştirilenler
- Geliştirme ortamı için SQL Server LocalDB desteği
- Production için SQL Server desteği

### Güvenlik
- ASP.NET Core Identity ile güvenli kimlik doğrulama
- Role-based authorization
- E-posta doğrulama gereksinimi
- Anti-forgery token koruması

### Bilinen Sorunlar
- ⚠️ Dosya yükleme için dosya tipi kontrolü eksik
- ⚠️ Dosya boyutu limiti yok
- ⚠️ Rate limiting implementasyonu yok
- ⚠️ E-posta gönderme özelliği yok (doğrulama e-postaları için)
- ⚠️ Şifre sıfırlama özelliği tam implementasyon yok
- ⚠️ İki faktörlü kimlik doğrulama (2FA) yok
- ⚠️ Güvenlik loglama eksik
- ⚠️ API dokümantasyonu eksik

### Gelecek Sürümler İçin Planlananlar

#### [1.1.0] - Planlanan
- [ ] Dosya yükleme güvenlik iyileştirmeleri
- [ ] Rate limiting implementasyonu
- [ ] E-posta gönderme entegrasyonu
- [ ] Şifre sıfırlama tam implementasyonu
- [ ] API dokümantasyonu (Swagger/OpenAPI)
- [ ] Unit test coverage artırma
- [ ] Integration testler

#### [1.2.0] - Planlanan
- [ ] İki faktörlü kimlik doğrulama (2FA)
- [ ] Güvenlik loglama ve monitoring
- [ ] Performans optimizasyonları
- [ ] Caching implementasyonu
- [ ] Real-time bildirimler (SignalR)
- [ ] Mobil uygulama desteği (API)

#### [2.0.0] - Uzun Vadeli
- [ ] Mikroservis mimarisi geçişi
- [ ] GraphQL API desteği
- [ ] Çoklu dil desteği (i18n)
- [ ] Gelişmiş analitik ve raporlama
- [ ] Video konferans entegrasyonu
- [ ] AI destekli ödev değerlendirme

---

## Sürüm Notları Formatı

### Eklenenler
Yeni özellikler için.

### Değiştirilenler
Mevcut özelliklerdeki değişiklikler için.

### Kaldırılanlar
Kaldırılan özellikler için.

### Düzeltmeler
Hata düzeltmeleri için.

### Güvenlik
Güvenlik açığı düzeltmeleri için.

---

**Not**: Bu changelog dosyası projenin ilk sürümü için hazırlanmıştır ve gelecekteki değişikliklerle güncellenecektir.

