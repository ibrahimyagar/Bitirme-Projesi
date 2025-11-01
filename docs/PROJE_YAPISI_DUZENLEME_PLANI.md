# 📋 Proje Yapısı Düzenleme Planı

## 🔍 Mevcut Durum Analizi

### Tespit Edilen Sorunlar:

1. **İkili Proje Yapısı**
   - Kök dizinde: Controllers, Models, Views, Data, Areas, wwwroot
   - `Classroom/` klasöründe: Aynı yapı tekrar ediyor
   - İki adet `.csproj` dosyası var

2. **Git'e Eklenmiş Gereksiz Dosyalar**
   - `bin/` klasörleri (build çıktıları)
   - `obj/` klasörleri (intermediate dosyalar)
   - `.vs/` klasörleri (Visual Studio cache)
   - `node_modules/` (npm paketleri)
   - `.user` dosyaları (Visual Studio user settings)
   - `package.json` ve `package-lock.json` (gereksiz)

3. **Gereksiz Dosyalar**
   - `.gitignore.txt` (duplicate)
   - `ScaffoldingReadMe.txt` (otomatik oluşturulan)
   - `GITHUB_YUKLEME_ADIMLARI.md` (geçici dokümantasyon)

4. **Düzensiz Yapı**
   - Belge dosyaları kök dizinde dağınık
   - wwwroot içinde uploads klasöründe test dosyaları

---

## ✅ Önerilen Standart Yapı

```
Bitirme-Projesi/
├── .github/                    # GitHub şablonları ve CI/CD
│   ├── workflows/
│   └── ISSUE_TEMPLATE/
├── Areas/                      # ASP.NET Core Identity sayfaları
│   └── Identity/
├── Controllers/                # MVC Controllers
├── Data/                       # DbContext ve Migrations
├── Models/                     # Entity modelleri
├── ViewModels/                 # View modelleri
├── Views/                      # Razor Views
├── wwwroot/                    # Statik dosyalar
│   ├── css/
│   ├── js/
│   ├── images/
│   └── lib/                    # Bootstrap, jQuery vb.
├── Properties/                 # Launch settings vb.
├── docs/                       # 📚 Dokümantasyon dosyaları
│   ├── BELGELER_OZET.md
│   ├── PROJE_ANALIZ_RAPORU.md
│   └── GITHUB_YUKLEME_ADIMLARI.md
├── .dockerignore
├── .gitattributes
├── .gitignore
├── CHANGELOG.md
├── CODE_OF_CONDUCT.md
├── CONTRIBUTING.md
├── docker-compose.yml
├── Dockerfile
├── LICENSE
├── openapi.yaml
├── README.md
├── SECURITY.md
├── appsettings.json
├── appsettings.Development.json
├── EduHub.csproj
├── EduHub.sln
└── Program.cs
```

---

## 🔧 Yapılacak İşlemler

### 1. Klasör Temizliği

**Git'ten Kaldırılacak Dosyalar:**
```bash
# Build çıktıları
- bin/
- obj/
- .vs/
- node_modules/

# User-specific dosyalar
- *.user
- *.suo
- *.userosscache

# Gereksiz dosyalar
- .gitignore.txt
- ScaffoldingReadMe.txt
- package.json
- package-lock.json
- Classroom/ klasörü (eğer kök dizin ana proje ise)
```

### 2. Dosya Taşıma İşlemleri

**Yeni `docs/` Klasörüne Taşınacaklar:**
- `BELGELER_OZET.md`
- `PROJE_ANALIZ_RAPORU.md`
- `GITHUB_YUKLEME_ADIMLARI.md`

**wwwroot/uploads Temizliği:**
- Test dosyaları kaldırılacak (gerçek kullanıcı dosyaları değilse)

### 3. Classroom Klasörü Kararı

**Seçenek A:** Kök dizin ana proje, Classroom klasörü kaldırılacak
**Seçenek B:** Classroom klasörü ana proje, kök dizindeki dosyalar taşınacak

**Öneri:** Kök dizindeki yapı daha güncel görünüyor (csproj'da ek paketler var), bu yüzden Classroom klasörünü kaldırmayı öneriyorum.

### 4. .gitignore Güncellemesi

Standart ASP.NET Core .gitignore ile güncellenecek.

---

## 📊 Etkilenen Dosyalar

### Git'ten Kaldırılacak (~600+ dosya):
- Tüm bin/ klasörleri
- Tüm obj/ klasörleri  
- .vs/ klasörleri
- node_modules/
- *.user dosyaları

### Taşınacak Dosyalar (3 adet):
- BELGELER_OZET.md → docs/
- PROJE_ANALIZ_RAPORU.md → docs/
- GITHUB_YUKLEME_ADIMLARI.md → docs/

### Silinecek Dosyalar (4 adet):
- .gitignore.txt (duplicate)
- ScaffoldingReadMe.txt (otomatik oluşturulan)
- package.json (gereksiz)
- package-lock.json (gereksiz)

### Kaldırılacak Klasör (1 adet):
- Classroom/ (kök dizindeki yapı kullanılacak)

---

## ⚠️ Dikkat Edilmesi Gerekenler

1. **Classroom klasöründe TeacherRating.cs var mı kontrol edilmeli**
2. **Classroom klasöründeki farklılıklar varsa kök dizine aktarılmalı**
3. **Git commit'leri kaybolmayacak, sadece dosyalar git'ten kaldırılacak**
4. **Kod içeriği değişmeyecek, sadece yapı düzenlenecek**

---

## ✅ Onay Sonrası Yapılacaklar

1. Classroom klasörü içeriği kontrol edilecek
2. Eksik dosyalar kök dizine aktarılacak
3. Gereksiz dosyalar git'ten kaldırılacak
4. docs/ klasörü oluşturulacak ve dosyalar taşınacak
5. .gitignore güncellenecek
6. README.md güncellenecek (klasör yapısı bölümü)
7. Değişiklikler commit edilecek

---

**Onay bekleniyor...**

