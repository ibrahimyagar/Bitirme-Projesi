# 📁 Önerilen Profesyonel Klasör Yapısı

## 🔍 Mevcut Durum Analizi

### Tespit Edilen Sorunlar:
- ✅ `bin/`, `obj/`, `.vs/`, `node_modules/` klasörleri fiziksel olarak mevcut (git'ten kaldırılmalı)
- ✅ `PROJE_YAPISI_DUZENLEME_PLANI.md` hem kök dizinde hem `docs/` klasöründe (duplicate)
- ✅ `Classroom.csproj.user` dosyası kök dizinde (git'ten kaldırılmalı)
- ✅ `Properties/` içinde `.user` dosyaları var
- ✅ `wwwroot/uploads/` klasörü var (içeriği kontrol edilmeli)

### İyi Durumda Olanlar:
- ✅ `docs/` klasörü zaten oluşturulmuş
- ✅ Standart ASP.NET Core MVC yapısı mevcut
- ✅ `.github/` klasörü var

---

## ✅ Önerilen Yeni Klasör Yapısı

```
Bitirme-Projesi/
│
├── 📁 .github/                          # GitHub yapılandırması
│   ├── workflows/
│   │   └── ci.yml                      # CI/CD pipeline
│   └── ISSUE_TEMPLATE/
│       ├── bug_report.md
│       └── feature_request.md
│
├── 📁 Areas/                           # ASP.NET Core Identity
│   └── Identity/
│       └── Pages/
│           ├── Account/
│           └── Manage/
│
├── 📁 Controllers/                      # MVC Controllers
│   ├── ClassroomController.cs
│   ├── CommentController.cs
│   ├── HelloController.cs
│   ├── HomeController.cs
│   ├── HomeworkController.cs
│   └── WebRtcHub.cs
│
├── 📁 Data/                            # Entity Framework Core
│   ├── ApplicationDbContext.cs
│   └── Migrations/                     # Veritabanı migration'ları
│       ├── 00000000000000_CreateIdentitySchema.cs
│       ├── 20240806095338_createdb.cs
│       └── ...
│
├── 📁 Models/                          # Entity Models
│   ├── Announcements.cs
│   ├── ApplicationUser.cs
│   ├── Class_User.cs
│   ├── ClassRoom.cs
│   ├── Comment.cs
│   ├── ErrorViewModel.cs
│   ├── Homework.cs
│   ├── Homework_User.cs
│   └── TeacherRating.cs
│
├── 📁 ViewModels/                      # View Models
│   └── JoinClassRoomModel.cs
│
├── 📁 Views/                           # Razor Views
│   ├── Classroom/
│   │   └── Index.cshtml
│   ├── Hello/
│   │   ├── Detail.cshtml
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── Home/
│   │   ├── Archived.cshtml
│   │   ├── CreateClassRoom.cshtml
│   │   ├── Index.cshtml
│   │   └── JoinClassRoom.cshtml
│   ├── Homework/
│   │   ├── AddHomework.cshtml
│   │   ├── CreateHomework.cshtml
│   │   ├── HomeworkList.cshtml
│   │   ├── Index.cshtml
│   │   └── TeachIndex.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _Layout.cshtml.css
│   │   ├── _Layout2.cshtml
│   │   ├── _LoginPartial.cshtml
│   │   ├── _ValidationScriptsPartial.cshtml
│   │   └── Error.cshtml
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
│
├── 📁 wwwroot/                         # Statik Dosyalar
│   ├── css/
│   │   └── style.css
│   ├── js/
│   │   └── script.js
│   ├── images/                         # Proje görselleri
│   │   └── [8 adet .jpg dosyası]
│   ├── lib/                            # 3. parti kütüphaneler
│   │   ├── bootstrap/
│   │   ├── jquery/
│   │   ├── jquery-validation/
│   │   └── jquery-validation-unobtrusive/
│   ├── uploads/                        # Kullanıcı yüklemeleri (.gitignore'da)
│   │   └── homeworks/
│   └── favicon.ico
│
├── 📁 Properties/                      # Proje özellikleri
│   ├── launchSettings.json
│   ├── serviceDependencies.json
│   └── serviceDependencies.local.json
│
├── 📁 docs/                           # 📚 Dokümantasyon
│   ├── BELGELER_OZET.md
│   ├── DUZENLEME_OZET.md
│   ├── GITHUB_YUKLEME_ADIMLARI.md
│   ├── PROJE_ANALIZ_RAPORU.md
│   └── PROJE_YAPISI_DUZENLEME_PLANI.md
│
├── 📄 .dockerignore                   # Docker ignore kuralları
├── 📄 .gitattributes                   # Git attributes
├── 📄 .gitignore                       # Git ignore kuralları (güncellenecek)
├── 📄 CHANGELOG.md                     # Versiyon geçmişi
├── 📄 CODE_OF_CONDUCT.md              # Davranış kuralları
├── 📄 CONTRIBUTING.md                  # Katkı rehberi
├── 📄 docker-compose.yml               # Docker Compose yapılandırması
├── 📄 Dockerfile                       # Docker image tanımı
├── 📄 LICENSE                          # MIT Lisansı
├── 📄 openapi.yaml                     # API dokümantasyonu
├── 📄 README.md                        # Ana dokümantasyon (güncellenecek)
├── 📄 SECURITY.md                      # Güvenlik politikası
├── 📄 appsettings.json                 # Uygulama ayarları
├── 📄 appsettings.Development.json    # Geliştirme ayarları
├── 📄 Classroom.csproj                 # Proje dosyası
├── 📄 Classroom.sln                    # Solution dosyası
└── 📄 Program.cs                       # Uygulama giriş noktası
```

---

## 🗑️ Git'ten Kaldırılacak Dosya/Klasörler

### Klasörler:
- `bin/` (build çıktıları)
- `obj/` (intermediate dosyalar)
- `.vs/` (Visual Studio cache)
- `node_modules/` (npm paketleri)

### Dosyalar:
- `Classroom.csproj.user` (Visual Studio user settings)
- `Properties/serviceDependencies.local.json.user` (user-specific)
- `PROJE_YAPISI_DUZENLEME_PLANI.md` (kök dizinden - docs'ta zaten var)

---

## ✅ Yapılacak İşlemler Özeti

1. **Git'ten Temizlik:**
   - `bin/`, `obj/`, `.vs/`, `node_modules/` klasörlerini git'ten kaldır
   - `*.user` dosyalarını git'ten kaldır
   - Duplicate `PROJE_YAPISI_DUZENLEME_PLANI.md` dosyasını kök dizinden sil

2. **.gitignore Güncellemesi:**
   - Standart ASP.NET Core .gitignore kuralları ekle
   - `wwwroot/uploads/` klasörünü ignore listesine ekle (zaten var)

3. **README.md Güncellemesi:**
   - Klasör yapısı bölümünü yukarıdaki ağaç yapısıyla güncelle

---

## 📊 Değişiklik Özeti

- **Git'ten kaldırılacak:** ~600+ dosya (bin, obj, .vs, node_modules)
- **Silinecek:** 1 dosya (duplicate PROJE_YAPISI_DUZENLEME_PLANI.md)
- **Güncellenecek:** 2 dosya (.gitignore, README.md)
- **Kod değişikliği:** YOK ❌

---

## ⚠️ Önemli Notlar

1. **Kod içeriği değişmeyecek** - Sadece klasör yapısı düzenlenecek
2. **Build klasörleri fiziksel olarak kalacak** - Sadece git'ten kaldırılacak
3. **wwwroot/uploads/** içindeki test dosyaları kalabilir (git'te zaten ignore ediliyor)
4. **Mevcut klasör yapısı zaten iyi durumda** - Sadece temizlik yapılacak

---

**Bu yapıyı onaylıyor musunuz? Onay verirseniz işlemleri başlatacağım.** ✅

