�zet Proje Geli�tirme A�amalar�:

1) Record'dan miras alan Entity ve DbContext'ten miras alan s�n�flar�n derlemesi.
2) Service'ten miras alan abstract (soyut) ve somut (somut) Service s�n�flar�n�n d�zenlenmesi,
somut s�n�f i�indeki yap�s� DbContext'ten miras alan s�n�f�n�n yap�c�da tutulmas�
ve ihtiyaca g�re base Service abstract class'�ndaki metodlar�n ge�ersiz k�l�nmas�.
3) appsettings.json ve appsetting.Development.json dosyalar�na ba�lant� dizgisinin yaz�lmas�.
4) Program.cs IoC Container'da builder'�n Services'lar�na AddDbContext y�ntemi ile program� DbContext'ten miras
alan s�n�f�n�n ba�lant� string'i builder'�n Yap�land�rma �zelli�inin GetConnectionString y�ntemi
appsettings.json ve appettings.Development.json dosyalar�nda tan�mlanan ad ile d�n�lerek ekim.
5) Program.cs IoC Container'da builder'�n Services'lar�na AddScoped y�ntemi ile proje ile ilgili servislerin
sol taraftaki base abstract varyantlar� (soyut), sa� taraftaki base da base abstract tip miraslar�ndan alan
beton �e�itlerini (somut) �ekek.
6) �lgili servislerin ilgili controller'lara base abstract tipleri kullan�larak yap�c� �zerinden y�klenmesi
ve controller action'lar�n�n CRUD i�lemleri i�in ilgili entity'ler k�t�phanesini kullanarak.
7) Her bir eylem i�in i�indeki model (varl�k) �zerinden d�zenleyiciyi g�r�nt�le.
8) _Layout.cshtml'deki men�ye kaynakl� controller'lar�n �ndeks (listeleme) action'lar� i�in ba�lant�y� onaylama.

NuGet Paketleri:
1) AppCore -> Microsoft.EntityFrameworkCore.SqlServer

Bu Projenin Katmanlar�:
3) Uygulama Katman� (MVC, WebApi)
2) DataAccess Katman� (Service (Repository), Entity (Model entity �zerinden geni�letilerek olu�turulacak), DbContext)
1) AppCore Katman�

Sekt�rde Kar��la�abilece�imiz �rnek Proje Katmanlar�:
4) Uygulama Katman� (MVC, WebApi)
3) �� Katman� (Servis (Entity <-> Model d�n���mleri i�in), Model)
2) DataAccess Katman� (Repository, Entity, DbContext)
1) AppCore Katman�