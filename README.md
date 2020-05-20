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
  - Builder Design Pattern
  - Prototype Design Pattern
  - Singleton Design Pattern
  - Object Pool Design Pattern

- Structural Patterns
  - Adapter Design Pattern
  - Bridge Design Pattern
  - Composite Design Pattern
  - Decorator Design Pattern
  - Facade Design Pattern
  - Proxy Design Pattern

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

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Builder Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Builder Design Pattern, bir bütünü oluşturan parçaların birleştirilmesiyle ortaya yeni bir ürün çıkartmak için kullanılan bir tasarım kalıbıdır. Parçalardan istediğimizi eklemek yada eklememek tercihine sahibiz.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  Bu tasarım kalıbının ortaya çıkmasına sebep olan sorun şöyledir; bir bütünü oluşturduğumuzu düşünelim. Bu bütünü tek bir sınıf üzerinden parametre ile yönetmeye kalktığımızda, bir çok parametre yanyana verilecek ve istenmeyen değerler null olarak atanmak zorunda kalacaktır. Böyle bir durum ise oldukça karmaşıklığa sebep olmaktadır. Ancak eklenmek istenen parçalar ayrı methodlar halinde eklendiğinde, hem okunurluk artacak hem de kolay yönetim sağlanarak modülerite artacaktır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Aşağıdaki UML diagramında çizilen builder tasarımı bir öğün yemeği oluşturmakta kullanılmıştır. Çocuk ve yetişkin olarak ayrılan iki kısım içerisinde farklı farklı çeşitlilik barındırabilecektir. Çocuğun içeceği süt ve yetişkinin içeceği çay olabilir. Yada herhangi bir içecek verilmeyebilir. Farklı durumlar da mevcut interface ile sisteme tam entegre olabilir. Direktör ile de istenen değer dependency injection yöntemiyle kolaylıkla oluşturulabilir. Farklı tarz örnekler de kod üzerinde gösterilmiştir. 

![image](https://user-images.githubusercontent.com/16361055/80277773-027e5080-86fa-11ea-83de-2a6f20c4414f.png)

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Prototype Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bir işlemi gerçekleştirebilmek için devamlı aynı nesnenin üretilmesi ve üzerine farklı eklemeler yapıldığı durumlarda kullanılmaktadır. Devamlı kullanılacak bir prototip oluşturulmaktadır ve gerektiği yerlerde bu prototip alınarak üzerine eklemeler yapılmaktadır. Prototip için hazırladığımız nesneyi bir sınıfın içine koyabiliriz ve bu nesneyi gerektiği yerlerde belirli kopyalama fonkisyonlarına göre bir kopyasını oluşturarak alabiliriz.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mevcut nesnenin erişilemeyen değişkenlerini aynı şekilde kopyalayabilmek için veya veritabanından alınan bilgilerle içeriğinin doldurulmasından dolayı ortaya çıkaibilecek yavaşlıktan kurtulmak için bu tasarım deseni kullanılmaktadır. 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Aşağıdaki UML diagramında kedi ve köpek sınıfları ortak bir alandan yönetilebilmesi için bir evcil hayvan prototip interfacesine bağlandı. Prototipleri oluşturacağımız ve saklayacağımız yeni bir sınıf olarak PrototypeRegistry sınıfı oluşturuldu. Oluşturduğumuz prototipleri bu sınıf içerisindeki listeye bir key yardımıyla ekliyoruz. Gereken yerde shallow veya deep copy yaparak bu listeden bir kopyasını alıyoruz. 


![image](https://user-images.githubusercontent.com/16361055/80307484-05e50b00-87d2-11ea-87ef-e4ef199c2ecd.jpg)

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Singleton Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Yapacağımız işlemler için bir nesnenin bir kez oluşturulmasının yeterli olduğu durumlarda kullanılır. Sınıfımızın nesnesini bir kez tanımlarız ve programı durdurana kadar bu nesne üzerinden işlem yaparız. İlgili sınıftan bir nesne talep ettiğimizde ilk kez işlem yapılıyorsa yeni bir nesne dönecek ancak ilk seferden sonrakilerde aynı nesneyi verecektir. Programdaki örneğimizde toplama ve çıkartma işlemi yapan bir sınıf oluşturduk. Toplama ve çıkartma işlemlerinde parametreler ile çalışan methodlar bize yeterli olduğu için hesaplama sınıfın aracı olarak kullandık. Bir kez tanımladıktan sonra hep aynı nesneyi kullandık. Örnek UML diagramı aşağıdadır.
  
![image](https://user-images.githubusercontent.com/16361055/79700520-e2d0cd80-829e-11ea-9c6f-2320bd769ec1.png)

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Object Pool Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bazen bir nesnenin aynısından çok fazla oluşturmamız gerekebilir. Örneğin bir oyunda atılan mermileri örnek olarak düşünürsek, mermiler hem devamlı oluşturulacak hem de aynı işlemi görecektir. Ancak her defasında yeni nesne oluşturulması maliyetli olacaktır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Devamlı kullanılan nesnelerin her defasında tekrar oluşturulma maliyetinden kurtulmak için tasarlanmış olan Object Pool design pattern, oluşturulan ve görevini tamamlamış nesneleri bellekten silmeden bir havuzda saklamaktadır. Ve daha sonra gerektiği yerde bu havuzdan alınması ve kullanılması üzerine işlemler yapılmaktadır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Aşağıda konu ile ilgili UML diagramı bulunmaktadır. Client istemcimiz, oluşturulan havuz ile iletişim kurarak havuza ekleme ve silme işlemleri yapabilmektedir.

![image](https://user-images.githubusercontent.com/16361055/80761590-86459c00-8b43-11ea-91ee-f34cab73d1d7.png)

### Structural Patterns

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Adapter Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Belirli bir işlemi gerçekleştiren bir interface kullandığımızı varsayalım. Bu interface'in imzasını taşıyan bir çok sınıf olabilmektedir. Ancak benzer görevi gerçekleştiren ve bu interface'nin imzasını taşıyamayan sınıfları kullanmamız gerekir ise hali hazırdaki kodlarımızı değiştirmek yerine; interface ve sınıf arasında bir adapter çeviricisi koyarak etkileşimi sağlamak için bu tasarım deseni kullanılmaktadır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Aşağıdaki UML diagramında yukarıda bahsettiğimiz sebepten bir adapter kullanma ihtiyacı doğmuştur. IXmlToJson interfacemiz bir imza olarak oluşturulmuştur. Client bu imza ile birlikte XmlToJsonConverter sınıfını kullanarak xml dosyalarını json tipine çevirebilmektedir. Farklı bir yerde kullanılan bir sınıf olan ObjectToJsonConverter sınıfımız var ve bu interface ile kullanılmak istenmektedir. Amaç olarak bu sınıf da Json üretmektedir. Ancak mevcut interface miz ile uyumlu değildir. Bu sebeple bu interface ile bu sınıfı birleştirmek için araya bir adapter koyduk ve başarılı bir şekilde bağlantı kurmuş olduk. Böylece Client her iki sınıfı da kullanabilmektedir.

![image](https://user-images.githubusercontent.com/16361055/81220941-d19bf680-8fea-11ea-8218-8802e953efea.png)

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bridge Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Belirli bir forma sahip sınıfların farklı implementasyonlarla etkileşiminin ayrı ayrı tanımlanmasından ziyade, köprü misali bir yapı oluşturarak, istenilen sınıfı gereken implementasyonu ile eşleştirerek kullanılan bir tasarım kalıbıdır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Aşağıdaki UML diagramında yukarıda bahsettiğimiz şekilde asıl işlem görecek gerçek sınıflarımız, Document abstract sınıfını kalıtım alan sınıflardır. IDatabase interface'i ise hazırlanan sınıfların ne tür işlem göreceğini belirtmektedir. Rapor ve yazı şeklinde belge hazırladığımızı varsayarsak; hazırlanan belgeleri kaydetmek için mysql veya postgresql veritabanlarından birini seçtiğimizi belirteceğiz. Her işlem gören belge kendi içerisinde hangi veritabanını seçtiğini belirtecek. Aksi halde yapılması gereken, tüm belgelerin ayrı ayrı veritabanlarıyla olan etkileşimine dönüşecektir. Bu kullanımın önüne geçmek için bridge tasarım deseni geliştirilmiştir.

![image](https://user-images.githubusercontent.com/16361055/81976304-01717c80-9631-11ea-8e70-60fae7245e39.png)

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Composite Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bir grup işlemin alt gruplara ayrılarak, ağaç yapısı şeklinde oluşturulması ve işlenmesi için kullanılan bir tasarım kalıbıdır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Aşağıdaki UML diagramında yukarıda bahsettiğimiz şekilde bir ağaç yapısı gösterilmiştir. Bir Manager sınıfımız ve altında başka manager ve depeloper barındırabilecek şekilde ağaç yapısında oluşturuldu. Developer sınıfı ise bir tane ve altında grup barındırmayan bir yapı olarak tasarlandı. Kullanıcı IWorker arayüzünü kullanarak alt alta oluşan tüm grup ve tekil kişilere erişim imkanı sağlamaktadır. Örneğimizde ise en üst kademedeki kişiye toplam çalışma zamanını sorduğumuzda tüm alt yapıları dolaşarak bize toplamı gösterme imkanı sunmaktadır. Böylece karmaşık bir yapıdan ziyade sınıflandırılmış ve kolay işlenebilir bir yapı oluşturulmuştur.

![image](https://user-images.githubusercontent.com/16361055/82235913-05a4df00-993c-11ea-9551-28a0f466360e.jpg)

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Decorator Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bir interface'i kalıtım alan benzer ürün sınıflarının, aynı interface'i kalıtım alan bir tasarımsal sınıf yardımıyla, benzer ürün sınıflarına yeni özellikler kazandırılmasıdır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Aşağıdaki UML diagramında yukarıda bahsettiğmiz şekilde bir interface ve bu interface'den kalıtım alan benzer ürünler olarak Laptop ve DesktopPc sınıflarını oluşturulmuştur. Bu benzer nesnelere farklı donanımlar eklemek için aynı interface'i kalıtım alan bir tasarımsal sınıf olarak ComputerDecorator oluşturuldu. Bu tasarımsal sınıfa diğer benzer ürünlerin gönderilmesi ve yeni özellik sınıflarıyla sarmalanmasıyla yeni özellikler kazandırılmaktadır.

![image](https://user-images.githubusercontent.com/16361055/82237271-0b032900-993e-11ea-8771-dd16cccb9bba.jpg)

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Facade Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bir istemcinin bir grup işlemi yapmak için, bir sınıf ile iletişim kurarak ve bu sınıfın ne yaptığına bakmadan sonucunu istemesidir. İletişim kurulan sınıf alt sınıflarla iletişim kurarak kendi içerisinde bir grup işlemi tamamlamakta ve istemciye dönmektedir. Bu şekilde istemci detaylarla ilgilenmeden istediği sonuca ulaşmaktadır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Aşağıdaki UML diagramında yukarıda bahsettiğmiz şekilde istemcinin iletişim kurması ve bir grup işlemi yaptırıp, sonucunu alabilmesi için bir adet Reporting adında bir raporlama facade sınıfı oluşturulmuştur. Bu sınıf verilen isme göre kendi içerisinde veritabanından ilgili veriyi okumakta, rapor oluşturmakta ve bu oluşturulan sınıfı mail olarak göndermektedir. Reporting facade sınıfımız dönüş objesi olarak yapılan işlemlerin loglarını dönmektedir. Böylece istemci Reporting facade sınıfına sadece kişi ismini bilgirerek, yapılan işlemleri bilme gereği duymadan, işlemlerini tamamlayacaktır.

![image](https://user-images.githubusercontent.com/16361055/82492439-e13d3400-9aee-11ea-80f7-42ac2931059b.jpg)

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Proxy Design Pattern
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Bir interface'e bağlı olan bir sınıfın, yapacağı işlemi güvenlik, hız vb. nedenlerle farklı bir sınıf aracılığı ile mevcut interface'e bağlı olarak oluşturulması ve kullanılmasıdır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Kullanım çeşitliliği olarak 3'e ayrılır.
- Remote Proxy : Uzak bir sunucuya erişimde kullanılmak üzere local bir temsilci sağlamaktadır.
- Virtual Proxy : Oluşturulması maliyetli bir nesnenin oluşturulmasında bir ara temsilci olarak işlem görmektedir. Örneğin web servisten alınan bir verinin cache ile saklanması.
- Protection Proxy : Bir nesneye oluşturulurken güvenlik vb ön kontrollerin sağlanması için kullanılmaktadır.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Aşağıdaki UML diagramında yukarıda bahsettiğimiz Protection Proxy yöntemini kullanarak bir proxy tasarım kalıbını kullanılmıştır. Database'den veri alınmadan önce nesneyi talep eden kişinin login olup olmadığı kontrolü sağlanmıştır.

![image](https://user-images.githubusercontent.com/16361055/82237535-7baa4580-993e-11ea-941e-3790fe34b9ac.jpg)

> Geliştirme devam ediyor.

### Behavioral Patterns

> Geliştirme devam ediyor.

### Other Patterns

> Geliştirme devam ediyor.
