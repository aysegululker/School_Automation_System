Projede okul otomasyon sistemi yapmay� ama�lanm��t�r. Sistemimizde ��retmen, �nkay�t ��rencisi, mevcut ��renci, ders bilgileri CRUD i�lemleri yap�larak, okulun t�m ihtiya�lar�n� kar��layacak bir uygulama yaz�lmas� ama�lanm��t�r.
Projenin sa�l�kl� �al��abilmesi i�in belli ba�l� paketlerin indirilmesi gerekmektedir. Bunun i�inde ilk olarak Tools�dan �NuGet Package Manager� b�l�m�nden �Package Manager Console� a��yoruz.
A��lan ekranda �Default Project� b�l�m�nden DAL katman� se�ilerek �install-package Microsoft.AspNetCore.Identity.EntityFrameworkCore� ifadesi ile Identity k�t�phanesi y�kl�yoruz.
Daha sonra yine �Default Project� b�l�m�nden MVC katman� se�ilerek a�a��daki paketleri s�ras� ile projemize y�kl�yoruz.
* install-package Microsoft.EntityFrameworkCore.SqlServer
* install-package Microsoft.EntityFrameworkCore.Design
* install-package Microsoft.EntityFrameworkCore.Tools

E�er kendiniz MVC�de bulunan Migrations silip birtak�m d�zenlemelerden sonra tekrar olu�turmak istiyorsan�z, belirtilen class�larda ki Cascade�leri Restrict olarak d�zelttikten sonra update-database demelisiniz. De�i�tirilecek classlar; Absenteeisms, RoomLessonTeachers, StudentSyllabusTables, TeacherSyllabusTables ve NoteEntries.
Projede yeni kullan�c� olu�turabilmek i�in Authorize yetkilendirmesi yorum sat�r�na al�nm��t�r. Bunun d���nda database olu�turulduktan sonra https://www.guidgenerator.com/ sitesinden 3 farkl� GUID ID al�narak databasede bulunan AspNetRoles tablosunda �Admin�, �Ogrenci� ve �Ogretmen� olmak �zere 3 farkl� stat� tan�mlanmas� gerekmektedir.

