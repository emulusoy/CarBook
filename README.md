CarBook 

## 🚗 CarBook - Araç Kiralama

Bu proje, .NET Core 8.0 kullanılarak geliştirilmiş, Onion Architecture prensipleriyle gelistirilmistir

## 🚀 Teknolojiler
* **.NET Core 8.0**: Modern ve yüksek performanslı bir uygulama geliştirme çatısı.
* **Onion Architecture**: Katmanlı mimari prensiplerini uygulayarak bağımlılıkları dıştan içe yönetir.
* **Entity Framework Core**: Veritabanı işlemleri için ORM (Object-Relational Mapper).
* **JWT (JSON Web Token)**: Güvenli kimlik doğrulama ve yetkilendirme.
* **MediatR**: CQRS (Command Query Responsibility Segregation) desenini uygulamak için.
* **Fluent Validation**: Veri doğrulama kurallarını belirlemek için.


## 🏛️ Proje Mimarisi ve Ana Klasör Yapısı

Proje, bağımsız ve test edilebilir katmanlar oluşturmak için Onion Architecture desenini kullanır. Bu mimari, iş mantığını dış bağımlılıklardan (veri erişimi, UI vb.) ayırarak daha temiz bir kod tabanı ve daha kolay bakım sağlar. Projenizdeki ana klasörler bu mimari katmanlarla aşağıdaki gibi eşleşmektedir:

* **Core**: Uygulamanın temel iş mantığı ve varlıkları bu kısımda yer alır.
    * **Application**: Uygulama senaryolarını, komutları, sorguları ve arayüzleri içerir.
    * **Domain**: Temel varlıkları, değer nesnelerini ve iş kurallarını içerir.
* **Frontends**: Kullanıcı arayüzü ve DTO (Data Transfer Object) tanımlamalarını barındırır.
    * **Dto**: Katmanlar arası veri transferi için kullanılan DTO sınıflarını içerir.
    * **WebUI**: Tarayıcı tabanlı kullanıcı arayüzü uygulamasını (Client) içerir.
* **Infrastructure**: Uygulamanın dış bağımlılıklarıyla (veritabanı, harici servisler vb.) etkileşimini yönetir.
    * **Persistence**: Veritabanı erişim katmanı; DbContext, repository uygulamaları ve geçişleri içerir.
* **Presentation**: Son kullanıcıya sunulan arayüz veya API katmanını içerir.
    * **WebApi**: HTTP isteklerini işleyen ve uygulama katmanıyla iletişim kuran Web API projesi.
 
Onemli Gordugum Sayfalar ve fotograflari!

WebUI Frontends tarafi.

ANASAYFA
<details>
   <summary>**Infrastructure/Persistence Katmanı Görseli (Genişletmek için tıklayın)**</summary>

  <img width="1920" height="6239" alt="Home" src="https://github.com/user-attachments/assets/062a5f71-ff5e-4bee-9b15-7cdc4f720861" />

</details>
Arac Kiralama Sayfasi 
<details>
   <img width="1445" height="789" alt="image" src="https://github.com/user-attachments/assets/0328908b-4125-4652-ad0a-35329e80b2a8" />

</details>
