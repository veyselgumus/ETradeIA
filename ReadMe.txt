Özet Proje Geliþtirme Aþamalarý:

1) Record'dan miras alan Entity ve DbContext'ten miras alan sýnýflarýn derlemesi.
2) Service'ten miras alan abstract (soyut) ve somut (somut) Service sýnýflarýnýn düzenlenmesi,
somut sýnýf içindeki yapýsý DbContext'ten miras alan sýnýfýnýn yapýcýda tutulmasý
ve ihtiyaca göre base Service abstract class'ýndaki metodlarýn geçersiz kýlýnmasý.
3) appsettings.json ve appsetting.Development.json dosyalarýna baðlantý dizgisinin yazýlmasý.
4) Program.cs IoC Container'da builder'ýn Services'larýna AddDbContext yöntemi ile programý DbContext'ten miras
alan sýnýfýnýn baðlantý string'i builder'ýn Yapýlandýrma özelliðinin GetConnectionString yöntemi
appsettings.json ve appettings.Development.json dosyalarýnda tanýmlanan ad ile dönülerek ekim.
5) Program.cs IoC Container'da builder'ýn Services'larýna AddScoped yöntemi ile proje ile ilgili servislerin
sol taraftaki base abstract varyantlarý (soyut), sað taraftaki base da base abstract tip miraslarýndan alan
beton çeþitlerini (somut) çekek.
6) Ýlgili servislerin ilgili controller'lara base abstract tipleri kullanýlarak yapýcý üzerinden yüklenmesi
ve controller action'larýnýn CRUD iþlemleri için ilgili entity'ler kütüphanesini kullanarak.
7) Her bir eylem için içindeki model (varlýk) üzerinden düzenleyiciyi görüntüle.
8) _Layout.cshtml'deki menüye kaynaklý controller'larýn Ýndeks (listeleme) action'larý için baðlantýyý onaylama.

NuGet Paketleri:
1) AppCore -> Microsoft.EntityFrameworkCore.SqlServer

Bu Projenin Katmanlarý:
3) Uygulama Katmaný (MVC, WebApi)
2) DataAccess Katmaný (Service (Repository), Entity (Model entity üzerinden geniþletilerek oluþturulacak), DbContext)
1) AppCore Katmaný

Sektörde Karþýlaþabileceðimiz Örnek Proje Katmanlarý:
4) Uygulama Katmaný (MVC, WebApi)
3) Ýþ Katmaný (Servis (Entity <-> Model dönüþümleri için), Model)
2) DataAccess Katmaný (Repository, Entity, DbContext)
1) AppCore Katmaný