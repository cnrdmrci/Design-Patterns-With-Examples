# Örneklerle Tasarım Desenleri (Design Patterns)

### Design Pattern Nedir?
Design Pattern, bir yazılımı en iyi şekilde geliştirmek için geçmiş sorunlardan edinilmiş tecrübeler ile harmanlanarak, üzerine düşünülmüş, esneklik, kolaylık ve sürdürülebilirlik sağlayan yazılım tasarımlarıdır diyebiliriz.

Nesneye yönelimli programlama ve UML diagramlarıyla beraber hayatımıza tam olarak giren design patternler, yazılım dünyasında belirli işlemlerin devamlı tekrarlanmasından kaynaklı bir standarda bağlanmıştır.

Gang of Four olarak bilinen: Eric Gamma, Richard Helm, Ralph Johnson ve John Vlissides isimli yazarların, "Design Patterns : Elements of Reusable Object – Oriented Software" kitabını çıkarttılar. Bu kitapta 3 kategori olmak üzere 23 farklı tasarım kalıbına yer vermişlerdir. 

Biz bu projemizde bu 3 kategorideki tüm tasarım kalıplarını ve ekstra farklı tasarım kalıplarını da işleyeceğiz.

### Projede Anlatılan Tasarım Kalıpları (Design Patterns) 

- Creational Patterns
  - Factory Design Pattern
  - Abstract Factory Design Pattern
  - Singleton Design Pattern
- Structural Patterns

- Behavioral Patterns

- Other Patterns

### Creational Patterns

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Factory Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Birbiriyle benzerlik gösteren işlemleri yapan classları bir araya toplamak için, gerektiğinde kolaylıkla tek bir yerden tüm yerde kullanılan classı değiştirebilmek için ve yönetimini kolayca sağlamak için factory design pattern'i kullanırız. Bu pattern yeni oluşturulacak bir nesneyi otomatik olarak oluşturarak bize dönmektedir. Otomatik oluşturma kısmında adını da aldığı üzere fabrika misali, gerekli işlemleri yaparak nesneyi oluşturur. Fabrika içerisinde istediğimiz işlemleri yapabiliriz. Mesela bu dökümanda da bulunan singleton patternini uygulayarak, tekrar tekrar nesne oluşturulmasını engelleyebiliriz.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Örneğimizde, mesaj gönderen bir uygulamanın tasarımını yapmaya çalıştık. Sms ve Email olarak gönderim çeşitleri mevcut. Bu sınıflar Message abstract ata sınıfına bağlılar. Fabrika modelinde ise oluşturulan gerçek sınıfların her birinin fabrikası mevcut. Tek fabrika üzerinden de durumu oluşturabilirdik. Genelde örnekler tek fabrika üzerinden gösterilmekte. Biz bu örneğimizde her Mesaj gönderim çeşidinin farklı fabrika olmasını sağladık. Böylece fabrika içerisinde yapılacak her ince iş kendi bölümünde bulunarak, Single responsibility prensibini de  uygulayarak, karmaşıklığı önleyecektir.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Daha sonrasında MessageService classımızı bu fabrikanın üretimindeki yetkili kişi olarak belirledik ve tam otomatik bir fabrika oluşturduk. Fabrikanın yetkilisi olarak belirlediğimiz MessageService classına ne istediğimizi söylememiz yeterli. Örnek UML diagramı aşağıda verilmiştir. 


![image](https://user-images.githubusercontent.com/16361055/79768529-94b9d980-8333-11ea-83c6-c922ac2347a8.png)

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Abstract Factory Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Birbiriyle ilişkili ve farklı varyantlara sahip sınıfların üretiminde kullanılan bir tasarım kalıbıdır. İlişkili ürünler bir matris biçiminde tasarlanması gerekmektedir. Aşağıda UML diagramı Abstract Design Patterni temsil etmektedir. Örneğimizde bir yayınevimiz var ve bu yayın evinde ; kitap ve gazete üretimi yapmaktadır. Gereken durumlarda yeni ürünlerin eklenebilecek olması da tabiki bu tasarım kalıbının geliştirilebilir olmasının yararıdır. Üretimi yapılan kitap ve gazete ürünlerinin ingilizce ve rusça olarak 2 üretim çeşidini oluşturduk. Böylece bir matris görünümü elde ederek gereken şartlar sağlandı. 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Aşağıda verilen UML diagramında, genelde çizilen UML diagramlarının aksine, farklı bir çizim tasarımı kullanılarak matris şeklinde oluşturulmuş ve anlaşılması kolaylaştırılmıştır. Böylece Client , PublishingService(YayıneviServisi) yetkilisiyle iletişim kurarak, dil seçimini yaparak istediği ürünü üretim için istekte bulunabilecektir. Üzerine konuştuğumuz UML diagramı aşağıdadır.

![image](https://user-images.githubusercontent.com/16361055/79878898-a4e6bd00-83f6-11ea-8f91-407dcaec4de1.png)


#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Singleton Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Yapacağımız işlemler için bir nesnenin bir kez oluşturulmasının yeterli olduğu durumlarda kullanılır. Sınıfımızın nesnesini bir kez tanımlarız ve programı durdurana kadar bu nesne üzerinden işlem yaparız. İlgili sınıftan bir nesne talep ettiğimizde ilk kez işlem yapılıyorsa yeni bir nesne dönecek ancak ilk seferden sonrakilerde aynı nesneyi verecektir. Programdaki örneğimizde toplama ve çıkartma işlemi yapan bir sınıf oluşturduk. Toplama ve çıkartma işlemlerinde parametreler ile çalışan methodlar bize yeterli olduğu için hesaplama sınıfın aracı olarak kullandık. Bir kez tanımladıktan sonra hep aynı nesneyi kullandık. Örnek UML diagramı aşağıdadır.
  
![image](https://user-images.githubusercontent.com/16361055/79700520-e2d0cd80-829e-11ea-9c6f-2320bd769ec1.png)

> Geliştirme devam ediyor.

### Structural Patterns

> Geliştirme devam ediyor.

### Behavioral Patterns

> Geliştirme devam ediyor.

### Other Patterns

> Geliştirme devam ediyor.
