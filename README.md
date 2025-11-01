# Classroom - Sınıf Yönetim Sistemi

## 📋 Proje Hakkında

**Classroom**, öğretmenler ve öğrenciler için geliştirilmiş bir web tabanlı sınıf yönetim sistemidir. Bu platform, dijital sınıf ortamlarında ödev takibi, duyuru yönetimi, öğrenci-öğretmen etkileşimi ve öğretmen değerlendirme sistemini içeren kapsamlı bir çözüm sunar.

### 🎯 Ana Özellikler

- **Sınıf Yönetimi**: Öğretmenler sınıf oluşturabilir, öğrenciler benzersiz kod ile sınıflara katılabilir
- **Ödev Yönetimi**: Ödev oluşturma, gönderme, değerlendirme ve not verme sistemi
- **Duyuru Sistemi**: Sınıf içi duyuru paylaşımı ve yorumlama özelliği
- **Öğretmen Değerlendirme**: Öğrenciler öğretmenleri değerlendirebilir ve yorum yapabilir
- **Kullanıcı Rolleri**: Öğretmen ve öğrenci rolleri ile yetkilendirme sistemi
- **Arşivleme**: Sınıfları arşivleme ve geri getirme özelliği
- **Dosya Yükleme**: Ödevler için dosya yükleme desteği

### 🛠️ Teknolojiler

- **Backend**: ASP.NET Core 8.0 (MVC Pattern)
- **Veritabanı**: Microsoft SQL Server (Entity Framework Core)
- **Kimlik Doğrulama**: ASP.NET Core Identity
- **Frontend**: Razor Views, Bootstrap 5, jQuery
- **IDE**: Visual Studio / Visual Studio Code

## 📦 Kurulum

### Gereksinimler

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads) veya [SQL Server LocalDB](https://docs.microsoft.com/sql/database-engine/configure-windows/sql-server-express-localdb)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) veya [Visual Studio Code](https://code.visualstudio.com/)

### Adım Adım Kurulum

1. **Projeyi Klonlayın**
   ```bash
   git clone <repository-url>
   cd Classroom
   ```

2. **Veritabanı Bağlantı Stringini Yapılandırın**
   
   `appsettings.json` dosyasında `ConnectionStrings` bölümünü düzenleyin:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ClassroomDB;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
   }
   ```

   Veya production için SQL Server kullanıyorsanız:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=ClassroomDB;User Id=YOUR_USER;Password=YOUR_PASSWORD;Trusted_Connection=False;MultipleActiveResultSets=true"
     }
   }
   ```

3. **Veritabanı Migration'larını Çalıştırın**
   ```bash
   dotnet ef database update
   ```

   Eğer `dotnet ef` komutu yoksa:
   ```bash
   dotnet tool install --global dotnet-ef
   ```

4. **Bağımlılıkları Yükleyin**
   ```bash
   dotnet restore
   ```

5. **Uygulamayı Çalıştırın**
   ```bash
   dotnet run
   ```

   Veya Visual Studio'da `F5` tuşuna basın.

6. **Tarayıcıda Açın**
   
   Uygulama varsayılan olarak şu adreslerde çalışır:
   - HTTP: `http://localhost:5057`
   - HTTPS: `https://localhost:7242`

## 🔧 Yapılandırma

### Environment Değişkenleri

Production ortamı için `.env` dosyası oluşturun veya sistem environment değişkenlerini ayarlayın:

```bash
ASPNETCORE_ENVIRONMENT=Production
ConnectionStrings__DefaultConnection=YOUR_CONNECTION_STRING
```

### appsettings.json Yapılandırması

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "YOUR_CONNECTION_STRING"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

## 🚀 Kullanım

### İlk Kullanım

1. Uygulamayı başlattıktan sonra `/Identity/Account/Register` adresinden yeni bir hesap oluşturun
2. E-posta doğrulaması gerekmektedir (geliştirme ortamında varsayılan olarak etkin)
3. Giriş yaptıktan sonra ana sayfada sınıf oluşturabilir veya mevcut bir sınıfa katılabilirsiniz

### Öğretmen İşlemleri

- **Sınıf Oluşturma**: Ana sayfadan "Sınıf Oluştur" butonuna tıklayın
- **Ödev Oluşturma**: Sınıf sayfasından "Ödev Oluştur" seçeneğini kullanın
- **Ödev Değerlendirme**: Ödev detay sayfasından öğrenci çalışmalarını görüntüleyip not verebilirsiniz
- **Duyuru Paylaşma**: Sınıf sayfasından duyuru ekleyebilirsiniz
- **Öğrenci Yönetimi**: Sınıf sayfasından öğrencileri yönetebilir, öğretmen yapabilir veya çıkarabilirsiniz

### Öğrenci İşlemleri

- **Sınıfa Katılma**: Benzersiz sınıf kodunu kullanarak sınıfa katılın
- **Ödev Gönderme**: Ödev detay sayfasından ödevinizi gönderebilirsiniz
- **Duyuru Yorumlama**: Duyurulara yorum yapabilirsiniz
- **Öğretmen Değerlendirme**: Öğretmenleri değerlendirebilir ve yorum yapabilirsiniz

## 📁 Proje Yapısı

```
Bitirme-Projesi/
│
├── 📁 .github/                    # GitHub workflows ve şablonlar
│   ├── workflows/
│   │   └── ci.yml                 # CI/CD pipeline
│   └── ISSUE_TEMPLATE/            # Issue ve PR şablonları
│
├── 📁 Areas/                      # ASP.NET Core Identity
│   └── Identity/
│       └── Pages/
│           ├── Account/            # Kimlik doğrulama sayfaları
│           └── Manage/             # Hesap yönetimi sayfaları
│
├── 📁 Controllers/                 # MVC Controllers
│   ├── ClassroomController.cs      # Sınıf yönetimi
│   ├── CommentController.cs        # Yorum işlemleri
│   ├── HelloController.cs          # Test sayfaları
│   ├── HomeController.cs           # Ana sayfa ve sınıf oluşturma
│   ├── HomeworkController.cs       # Ödev yönetimi
│   └── WebRtcHub.cs                # WebRTC hub
│
├── 📁 Data/                       # Entity Framework Core
│   ├── ApplicationDbContext.cs    # Veritabanı context
│   └── Migrations/                 # Veritabanı migration'ları
│
├── 📁 Models/                     # Entity Models
│   ├── Announcements.cs            # Duyurular
│   ├── ApplicationUser.cs          # Kullanıcı modeli
│   ├── Class_User.cs              # Sınıf-Kullanıcı ilişkisi
│   ├── ClassRoom.cs                # Sınıf modeli
│   ├── Comment.cs                  # Yorum modeli
│   ├── ErrorViewModel.cs           # Hata görünüm modeli
│   ├── Homework.cs                 # Ödev modeli
│   ├── Homework_User.cs            # Ödev-Kullanıcı ilişkisi
│   └── TeacherRating.cs            # Öğretmen değerlendirme
│
├── 📁 ViewModels/                 # View Models
│   └── JoinClassRoomModel.cs       # Sınıfa katılma modeli
│
├── 📁 Views/                      # Razor Views
│   ├── Classroom/                  # Sınıf görünümleri
│   ├── Hello/                      # Test sayfaları
│   ├── Home/                       # Ana sayfa görünümleri
│   ├── Homework/                   # Ödev görünümleri
│   ├── Shared/                     # Paylaşılan layout'lar
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
│
├── 📁 wwwroot/                    # Statik Dosyalar
│   ├── css/                        # Stil dosyaları
│   │   └── style.css
│   ├── js/                         # JavaScript dosyaları
│   │   └── script.js
│   ├── images/                     # Proje görselleri
│   ├── lib/                        # 3. parti kütüphaneler
│   │   ├── bootstrap/              # Bootstrap CSS framework
│   │   ├── jquery/                  # jQuery kütüphanesi
│   │   ├── jquery-validation/      # Form doğrulama
│   │   └── jquery-validation-unobtrusive/
│   ├── uploads/                    # Kullanıcı yüklemeleri (.gitignore'da)
│   └── favicon.ico
│
├── 📁 Properties/                 # Proje özellikleri
│   ├── launchSettings.json         # Launch ayarları
│   └── serviceDependencies.json
│
├── 📁 docs/                       # 📚 Dokümantasyon
│   ├── BELGELER_OZET.md
│   ├── DUZENLEME_OZET.md
│   ├── GITHUB_YUKLEME_ADIMLARI.md
│   ├── ONERILEN_KLASOR_YAPISI.md
│   ├── PROJE_ANALIZ_RAPORU.md
│   └── PROJE_YAPISI_DUZENLEME_PLANI.md
│
├── 📁 docker/                     # 🐳 Docker yapılandırması
│   ├── Dockerfile                 # Docker image tanımı
│   └── docker-compose.yml         # Docker Compose yapılandırması
│
├── 📄 .dockerignore               # Docker ignore kuralları
├── 📄 .gitattributes              # Git attributes
├── 📄 .gitignore                  # Git ignore kuralları
├── 📄 CHANGELOG.md                # Versiyon geçmişi
├── 📄 CODE_OF_CONDUCT.md          # Davranış kuralları
├── 📄 CONTRIBUTING.md             # Katkı rehberi
├── 📄 LICENSE                     # MIT Lisansı
├── 📄 openapi.yaml                # API dokümantasyonu
├── 📄 README.md                   # Ana dokümantasyon
├── 📄 SECURITY.md                 # Güvenlik politikası
├── 📄 appsettings.json            # Uygulama ayarları
├── 📄 appsettings.Development.json
├── 📄 Classroom.csproj            # Proje dosyası
├── 📄 Classroom.sln               # Solution dosyası
└── 📄 Program.cs                  # Uygulama giriş noktası
```

## 🗄️ Veritabanı Şeması

### Ana Tablolar

- **AspNetUsers**: Kullanıcı bilgileri (Identity tablosu)
- **ClassRoom**: Sınıf bilgileri
- **ClassUser**: Sınıf- kullanıcı ilişkisi (çoktan çoğa)
- **Homework**: Ödev bilgileri
- **HomeworkUser**: Ödev-öğrenci ilişkisi ve notlar
- **Announcements**: Duyurular
- **Comment**: Duyuru yorumları
- **TeacherRatings**: Öğretmen değerlendirmeleri

### İlişkiler

- **ClassRoom** (1) ↔ (N) **ClassUser** ↔ (N) **ApplicationUser**
- **ClassRoom** (1) ↔ (N) **Homework**
- **ClassRoom** (1) ↔ (N) **Announcements**
- **Homework** (1) ↔ (N) **HomeworkUser** ↔ (N) **ApplicationUser**
- **Announcements** (1) ↔ (N) **Comment**

## 🧪 Test

### Unit Test Çalıştırma

```bash
dotnet test
```

### Integration Test

Veritabanı migration'larını test veritabanına uygulayın ve testleri çalıştırın.

## 🐳 Docker ile Çalıştırma

Docker kullanarak uygulamayı çalıştırmak için `docker/` klasöründeki `docker-compose.yml` dosyasını kullanabilirsiniz:

```bash
cd docker
docker-compose -f docker-compose.yml up -d
```

Veya kök dizinden:

```bash
docker-compose -f docker/docker-compose.yml up -d
```

Detaylar için [Docker bölümüne](#docker) bakın.

## 🔒 Güvenlik

- Tüm controller'lar `[Authorize]` attribute'u ile korunmaktadır
- SQL Injection koruması Entity Framework Core tarafından sağlanmaktadır
- XSS koruması Razor engine tarafından otomatik sağlanmaktadır
- Dosya yükleme işlemleri için güvenlik kontrolleri yapılmaktadır

Detaylı güvenlik bilgileri için [SECURITY.md](SECURITY.md) dosyasına bakın.

## 🤝 Katkıda Bulunma

Bu projeye katkıda bulunmak istiyorsanız lütfen [CONTRIBUTING.md](CONTRIBUTING.md) dosyasını okuyun.

## 📝 Lisans

Bu proje [MIT Lisansı](LICENSE) altında lisanslanmıştır.

## 🐛 Bilinen Sorunlar ve Geliştirme Planı

Bilinen sorunlar ve gelecek geliştirmeler için [CHANGELOG.md](CHANGELOG.md) dosyasına bakın.

## 📞 İletişim ve Destek

Sorularınız veya önerileriniz için lütfen bir [Issue](https://github.com/ibrahimyagar/Bitirme-Projesi/issues) oluşturun.

## 🙏 Teşekkürler

Bu projeyi kullandığınız için teşekkür ederiz!

---

**Not**: Bu proje eğitim amaçlı geliştirilmiştir. Production kullanımı için ek güvenlik ve performans iyileştirmeleri önerilir.

