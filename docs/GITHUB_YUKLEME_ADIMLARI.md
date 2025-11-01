# GitHub'a Dosya Yükleme Adımları

## Seçenek 1: Git Komutları ile (Terminal/PowerShell)

### Adım 1: Mevcut GitHub Repository'nizi bu klasöre bağlayın

```powershell
# Git repository başlat (eğer henüz başlatılmadıysa)
git init

# GitHub repository'nizi remote olarak ekleyin
# ÖRNEK: git remote add origin https://github.com/KULLANICI_ADINIZ/REPO_ADI.git
git remote add origin https://github.com/KULLANICI_ADINIZ/REPO_ADI.git

# Mevcut branch'i kontrol edin
git branch
```

### Adım 2: Yeni dosyaları ekleyin

```powershell
# Tüm yeni dosyaları ekle
git add README.md
git add LICENSE
git add CONTRIBUTING.md
git add SECURITY.md
git add CODE_OF_CONDUCT.md
git add CHANGELOG.md
git add Dockerfile
git add docker-compose.yml
git add .dockerignore
git add openapi.yaml
git add PROJE_ANALIZ_RAPORU.md
git add BELGELER_OZET.md
git add .github/workflows/ci.yml
git add .github/ISSUE_TEMPLATE/bug_report.md
git add .github/ISSUE_TEMPLATE/feature_request.md
git add .github/pull_request_template.md

# VEYA tüm değişiklikleri bir seferde ekle
git add .
```

### Adım 3: Commit yapın

```powershell
git commit -m "docs: GitHub belgeleri ve dokümantasyon eklendi"
```

### Adım 4: GitHub'a push edin

```powershell
# İlk kez push ediyorsanız
git push -u origin main

# VEYA master branch kullanıyorsanız
git push -u origin master

# Sonraki push'lar için sadece
git push
```

---

## Seçenek 2: GitHub Desktop ile (Görsel Arayüz)

1. **GitHub Desktop'ı açın**
2. **File → Add Local Repository** seçin
3. Bu klasörü seçin: `C:\Users\yafes\Desktop\bitirmeOdevim - Kopya (2)`
4. Eğer repository bağlı değilse, **Repository → Repository Settings → Remote** bölümünden GitHub repository URL'inizi ekleyin
5. Sol tarafta tüm yeni dosyaları göreceksiniz
6. Her dosyayı seçin veya "Select all" yapın
7. Alt kısımda commit mesajı yazın: `docs: GitHub belgeleri ve dokümantasyon eklendi`
8. **Commit to main** butonuna tıklayın
9. **Push origin** butonuna tıklayın

---

## Seçenek 3: GitHub Web Arayüzü ile (Küçük Dosyalar İçin)

1. GitHub repository'nizi tarayıcıda açın
2. **Add file → Create new file** butonuna tıklayın
3. Dosya adını yazın (örn: `README.md`)
4. İçeriği yapıştırın
5. **Commit new file** butonuna tıklayın
6. Her dosya için tekrarlayın

**Not**: Bu yöntem çok sayıda dosya için yorucu olabilir.

---

## Önemli Notlar

⚠️ **README.md'yi güncelleyin**: Dosyadaki `YOUR_USERNAME` kısmını GitHub kullanıcı adınızla değiştirin!

⚠️ **Remote URL Kontrolü**:
```powershell
git remote -v
```
Bu komut ile mevcut remote repository'nizi görebilirsiniz.

⚠️ **Hangi Branch'te Olduğunuzu Kontrol Edin**:
```powershell
git branch
```

---

## Sorun Giderme

### "fatal: not a git repository" hatası alıyorsanız:
```powershell
git init
git remote add origin https://github.com/KULLANICI_ADINIZ/REPO_ADI.git
```

### "Updates were rejected" hatası alıyorsanız:
```powershell
git pull origin main --allow-unrelated-histories
# Sonra tekrar push yapın
git push -u origin main
```

### GitHub kullanıcı adınızı ve şifrenizi soruyorsa:
- Personal Access Token kullanmanız gerekebilir
- GitHub → Settings → Developer settings → Personal access tokens → Generate new token

