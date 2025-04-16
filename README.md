### 🧅 MyAkademi Onion Architecture Web API Project 

Bu proje, eğitim sürecinde geliştirilen bir .NET Core Web API uygulamasıdır. Amacımız, yazılım geliştirme süreçlerinde sıkça kullanılan CQRS (Command Query Responsibility Segregation) ve Mediator yapılarının temel mantığını öğrenmek, bunu gerçek bir proje üzerinden uygulamaktı.
Projemiz aynı zamanda katmanlı mimaride daha sürdürülebilir ve test edilebilir bir yapı sunan Onion Architecture (Soğan Mimarisi) prensipleriyle yapılandırılmıştır.

 ## 🚀 Kullanılan Teknolojiler ve Araçlar
 
+ .NET 8

+ CQRS Pattern

+ MediatR Kütüphanesi

+ Entity Framework Core

+ AutoMapper

+ Onion Architecture

+ Repository & UnitOfWork Pattern

+ Swagger UI (API Test ve Dokümantasyon)

+ SQL Server

+ Web API


## 📂 Proje Yapısı (Onion Architecture)

MyAkademiOnionArch/
│
├── MyAkademiOnionArch.API            → API katmanı (giriş noktası)
├── MyAkademiOnionArch.Application    → CQRS işlemleri, handler'lar, DTO'lar, business kuralları
├── MyAkademiOnionArch.Domain         → Temel domain modelleri ve entityler
├── MyAkademiOnionArch.Infrastructure → Dış kaynaklar için kullanılıyor. 
├── MyAkademiOnionArch.Persistence    → DbContext, Repository, konfigürasyonlar


## 🧠Öğrenilen Konular

+ CQRS ile sorguların (Query) ve komutların (Command) ayrılması

+ MediatR ile loosely-coupled yapı kurulması

+ Katmanlı mimaride sorumlulukların ayrılması

+ Repository Pattern ile veri erişiminin soyutlanması

+ Unit of Work ile işlemlerin tek bir noktadan yönetimi
