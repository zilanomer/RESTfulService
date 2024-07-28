# Restful.Api
## Genel Bakış

Bu proje, modern yazılım geliştirme prensiplerine uygun bir REST API oluşturmak amacıyla geliştirilmiştir. API, SOLID prensiplerine sadık kalınarak ve Dependency Injection ile yapılandırılmıştır. Ayrıca, kullanıcı doğrulama, global hata yönetimi ve dokümantasyon gibi önemli özelliklerle donatılmıştır.

## Özellikler

### 🚀 REST Standartları
- API, REST standartlarına uygun olarak tasarlanmıştır ve HTTP metodları (GET, POST, PUT, DELETE, PATCH) ile çalışır.
  
### 🏗️ SOLID Prensipleri
- SOLID prensipleri doğrultusunda, kodun sürdürülebilirliğini ve test edilebilirliğini artıran bir mimari kullanılmıştır.

### 💉 Dependency Injection
- Servislerin bağımlılıkları, Dependency Injection kullanılarak yönetilmektedir. Bu yöntem, kodun esnekliğini ve bakımını kolaylaştırır.

### 🔧 Extension Geliştirme
- API'ye ek işlevsellik kazandırmak için çeşitli extension metodları geliştirilmiştir.

### 📜 Swagger İmplementasyonu
- API dokümantasyonu ve test işlemleri için Swagger entegrasyonu sağlanmıştır. Swagger UI üzerinden API endpoint'lerini ve metodlarını görüntüleyebilirsiniz.

### 📝 Global Loglama Middleware
- API'ye gelen istekler hakkında temel loglama işlemleri gerçekleştiren bir global loglama middleware'i eklenmiştir.

## Bonus Özellikler

### 🔑 Fake Kullanıcı Giriş Sistemi
- Fake bir kullanıcı giriş sistemi entegre edilmiştir. Bu sistem, kullanıcı doğrulama süreçlerini taklit eder ve test aşamasında kullanılır.

### 🎯 Custom Attribute ile Kontrol
- Erişim kontrolünü basit ve etkili bir şekilde yönetmek için özel bir attribute geliştirilmiştir.

### ⚠️ Global Exception Middleware
- API'de oluşabilecek global hataları merkezi bir noktada ele almak için bir exception middleware'i oluşturulmuştur. Bu middleware, hata yönetimini kolaylaştırır.
