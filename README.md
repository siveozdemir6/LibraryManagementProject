# LibraryManagementProject

# 📚 The Enchanted Aisle - Kütüphane Yönetim Sistemi (ASP.NET Core MVC)

Bu proje, bir kütüphane sisteminin temel ihtiyaçlarını karşılayacak şekilde tasarlanmış, ASP.NET Core MVC yapısı kullanılarak geliştirilmiş bir uygulamadır. Kitap, yazar, tür işlemleri, ödünç alma ve harita sistemi gibi temel bileşenler içermektedir.

## ✨ Genel Özellikler

- Kitapları listeleme, detay görüntüleme, ekleme, düzenleme ve silme
- Yazar ve tür yönetimi (CRUD işlemleri)
- Kitap ödünç alma ve geri getirme sistemi
- Oturum (login) sistemi ile sadece yetkili kullanıcıların giriş yapabildiği **yönetim paneli**

## 👩‍💼 Kullanıcı Giriş Bilgileri

Yönetici paneline giriş için aşağıdaki kullanıcılar kullanılabilir:

| Kullanıcı Adı      | Şifre   |
|--------------------|---------|
| `siveozdemir`      | `123456`|
| `sertanbozkus`     | `123456`|

**Projede kullanılan diller ve teknolojiler:**
- ASP.NET Core MVC 
- C#
- Bootstrap 5
- Session tabanlı oturum yönetimi
- TempData ile mesaj bildirimleri

**Static Repositories**:
- Kitap, yazar ve tür verileri `Repository` klasörü altında static listeler ile tutulur.
- Login için kullanıcılar `LoginUserRepository.cs` içindedir.

**Oturum Kontrolü:**
- Session ile oturum kontrolü yapılır.
- Giriş yapılmadan yönetim panellerine erişilemez.

## 🧭 Proje Detayları

- **Kitap Yönetimi**: `BookController`
- Tüm CRUD işlemleri
- Kitap türü ve yazarı dropdown ile seçilir

- **Yazar ve Tür Yönetimi**: `AuthorController`, `GenreController`
- Her biri kendi içinde List, Create, Edit, Delete işlemlerini barındırır
- Silme işlemleri soft-delete (IsDeleted = true) olarak çalışır

- **Harita Sayfası**: `MapController`
- Türlere göre raf sistemi ve konumlandırma haritası
- Hover ile büyüyen interaktif harita görseli

- **Ödünç Alma Sistemi**: `BorrowController`
- Sadece admin kullanıcılar görebilir
- Toplam ve ödünç alınan kopya sayısına göre `IsAvailable` bilgisi güncellenir

## 🧪 Test Etme ve Gözlemleme

Projenin test edilmesi için:

1. Visual Studio’da çalıştırın 
2. Login ekranında yukarıda verilen kullanıcı adı/şifreyi kullanın
3. Giriş yaptıktan sonra:
- Admin Paneline ulaşabilir
- Kitap ekleyebilir
- Tür ve yazar yönetimini gerçekleştirebilir
- Kitaplara ait detayları ve türlere göre haritayı görebilirsiniz

## 🎨 Tema & Tasarım

- `custom.css` ile butonlar, formlar, kartlar özelleştirilmiştir
- Navbar ve footer özel olarak sticky yapıya sahiptir




