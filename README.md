Projede okul otomasyon sistemi yapmayı amaçlanmıştır. Sistemimizde Öğretmen, Önkayıt öğrencisi, mevcut öğrenci, ders bilgileri CRUD işlemleri yapılarak, okulun tüm ihtiyaçlarını karşılayacak bir uygulama yazılması amaçlanmıştır.
Projenin sağlıklı çalışabilmesi için belli başlı paketlerin indirilmesi gerekmektedir. Bunun içinde ilk olarak Tools’dan “NuGet Package Manager” bölümünden “Package Manager Console” açıyoruz.
Açılan ekranda “Default Project” bölümünden DAL katmanı seçilerek “install-package Microsoft.AspNetCore.Identity.EntityFrameworkCore” ifadesi ile Identity kütüphanesi yüklüyoruz.
Daha sonra yine “Default Project” bölümünden MVC katmanı seçilerek aşağıdaki paketleri sırası ile projemize yüklüyoruz.
* install-package Microsoft.EntityFrameworkCore.SqlServer
* install-package Microsoft.EntityFrameworkCore.Design
* install-package Microsoft.EntityFrameworkCore.Tools

Eğer kendiniz MVC’de bulunan Migrations silip birtakım düzenlemelerden sonra tekrar oluşturmak istiyorsanız, belirtilen class’larda ki Cascade’leri Restrict olarak düzelttikten sonra update-database demelisiniz. Değiştirilecek classlar; Absenteeisms, RoomLessonTeachers, StudentSyllabusTables, TeacherSyllabusTables ve NoteEntries.
Projede yeni kullanıcı oluşturabilmek için Authorize yetkilendirmesi yorum satırına alınmıştır. 
Bunun dışında database oluşturulduktan sonra https://www.guidgenerator.com/ sitesinden 3 farklı GUID ID alınarak databasede bulunan AspNetRoles tablosunda “Admin”, “Ogrenci” ve “Ogretmen” olmak üzere 3 farklı statü tanımlanması gerekmektedir.

