Projede okul otomasyon sistemi yapmayý amaçlanmýþtýr. Sistemimizde Öðretmen, Önkayýt öðrencisi, mevcut öðrenci, ders bilgileri CRUD iþlemleri yapýlarak, okulun tüm ihtiyaçlarýný karþýlayacak bir uygulama yazýlmasý amaçlanmýþtýr.
Projenin saðlýklý çalýþabilmesi için belli baþlý paketlerin indirilmesi gerekmektedir. Bunun içinde ilk olarak Tools’dan “NuGet Package Manager” bölümünden “Package Manager Console” açýyoruz.
Açýlan ekranda “Default Project” bölümünden DAL katmaný seçilerek “install-package Microsoft.AspNetCore.Identity.EntityFrameworkCore” ifadesi ile Identity kütüphanesi yüklüyoruz.
Daha sonra yine “Default Project” bölümünden MVC katmaný seçilerek aþaðýdaki paketleri sýrasý ile projemize yüklüyoruz.
* install-package Microsoft.EntityFrameworkCore.SqlServer
* install-package Microsoft.EntityFrameworkCore.Design
* install-package Microsoft.EntityFrameworkCore.Tools

Eðer kendiniz MVC’de bulunan Migrations silip birtakým düzenlemelerden sonra tekrar oluþturmak istiyorsanýz, belirtilen class’larda ki Cascade’leri Restrict olarak düzelttikten sonra update-database demelisiniz. Deðiþtirilecek classlar; Absenteeisms, RoomLessonTeachers, StudentSyllabusTables, TeacherSyllabusTables ve NoteEntries.
Projede yeni kullanýcý oluþturabilmek için Authorize yetkilendirmesi yorum satýrýna alýnmýþtýr. Bunun dýþýnda database oluþturulduktan sonra https://www.guidgenerator.com/ sitesinden 3 farklý GUID ID alýnarak databasede bulunan AspNetRoles tablosunda “Admin”, “Ogrenci” ve “Ogretmen” olmak üzere 3 farklý statü tanýmlanmasý gerekmektedir.

