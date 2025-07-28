CarBook 

## 🚗 CarBook - Araç Kiralama

Bu proje, .NET Core 8.0 kullanılarak geliştirilmiş, Onion Architecture prensipleriyle gelistirilmistir

## Teknolojiler
* **.NET Core 8.0**: Modern ve yüksek performanslı bir uygulama geliştirme çatısı.
* **Onion Architecture**: Katmanlı mimari prensiplerini uygulayarak bağımlılıkları dıştan içe yönetir.
* **Entity Framework Core**: Veritabanı işlemleri için ORM (Object-Relational Mapper).
* **JWT (JSON Web Token)**: Güvenli kimlik doğrulama ve yetkilendirme.
* **MediatR**: CQRS (Command Query Responsibility Segregation) desenini uygulamak için.
* **Fluent Validation**: Veri doğrulama kurallarını belirlemek için.


## <span style="font-size: 182px;">🏛️ Proje Mimarisi ve Ana Klasör Yapısı</span>

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


<details>
   <summary> 💾 HOME PAGE(Genişletmek için tıklayın)</summary>

  <img width="1920" height="6239" alt="Home" src="https://github.com/user-attachments/assets/062a5f71-ff5e-4bee-9b15-7cdc4f720861" />
</details>


<details>

   <summary> 💾  ABOUT PAGE(Genişletmek için tıklayın)</summary>
<img width="2560" height="3139" alt="about" src="https://github.com/user-attachments/assets/323c3435-0429-4152-9f5d-01ee94ddc9c8" />
</details>
<details>
   <summary> 💾  PRICING PAGE(Genişletmek için tıklayın)</summary>
   
   <img width="2560" height="1440" alt="Screenshot 2025-07-28 181339" src="https://github.com/user-attachments/assets/b06ce303-23ed-4615-bd3f-645638d95c36" />

</details>
<details>
   <summary> 💾 CARS PAGE(Genişletmek için tıklayın)</summary>
   <img width="2560" height="1440" alt="Screenshot 2025-07-28 181549" src="https://github.com/user-attachments/assets/ca14bcef-7f7f-4988-b5de-8345ffae8e0c" />


</details>


<details>
   <summary> 💾 CARDETAIL PAGE (Genişletmek için tıklayın)</summary>
   <img width="2560" height="1440" alt="Screenshot 2025-07-28 181549" src="https://github.com/user-attachments/assets/ca14bcef-7f7f-4988-b5de-8345ffae8e0c" />
</details>
<details>
   <summary> 💾 CARDETAIL-REVIEW (Genişletmek için tıklayın)</summary>
<img width="2560" height="1440" alt="Screenshot 2025-07-28 181922" src="https://github.com/user-attachments/assets/c78e7dea-31a9-474c-877b-71dd49faefa5" />
</details>

</details>
<details>
   <summary> 💾 BLOG PAGE* CARDETAIL-REVIEW (Genişletmek için tıklayın)</summary>
<img width="2560" height="7475" alt="BLOG" src="https://github.com/user-attachments/assets/e5fd445a-a5c2-4c64-b8f4-6f3b3c4cbe2e" />

</details>




***Projede 75 araç her araca ait özellikler vs vs hepsi mimariye uygun çalışıyor bunların hepsini Admin Sayfasından yönetim yapabiliyorsunuz.

***Aşağıda Admin sayfası ve gerekli fotoğrafları bırakıyorum.

<details>
   <summary> 💾 ADMIN SAYFASI DASHBOARD-(Genişletmek için tıklayın)</summary> 

<img width="2560" height="1440" alt="image" src="https://github.com/user-attachments/assets/6c9c1d49-6aad-4d22-a172-d89af22e94d3" />

</details>
<details>
   <summary>💾 ADMIN SAYFASINDA ARAÇLARIN LİSTELENDİĞİ SAYFA(Genişletmek için tıklayın)</summary>
<img width="2560" height="1440" alt="image" src="https://github.com/user-attachments/assets/82f7e490-ee3b-437a-aef0-f7d2b19bc212" />


</details>

<details>
   <summary>💾 ADMIN SAYFASINDA ARAÇ ÖZELLİKLERİNİN LİSTELENDİĞİ SAYFA -Burada Tüm özellik eklemeler ve kaldırmalar çalışıyor!-(Genişletmek için tıklayın)</summary> 
<img width="2560" height="1440" alt="image" src="https://github.com/user-attachments/assets/1a606ead-299f-4202-9498-1bbc58627ab1" />

</details>
Diüer menüdeki işlemlerin hepsinde temel CRUD işlemleri yapılıyorç


<details>
   <summary>💾 API SWAGGER UI all -Burada Tüm özellik eklemeler ve kaldırmalar çalışıyor!-(Genişletmek için tıklayın)</summary> 
<img width="1285" height="10902" alt="APILER" src="https://github.com/user-attachments/assets/aedc5046-5bc7-49ed-95e9-e8cb5b6eb132" />

</details>





