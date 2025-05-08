-- Veritabanı oluşturma (eğer yoksa)
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'OTOMASYON1')
BEGIN
    CREATE DATABASE OTOMASYON1;
END
GO

USE OTOMASYON1;
GO

-- Yemekler tablosunu oluşturma (eğer yoksa)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Yemekler')
BEGIN
    CREATE TABLE Yemekler (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        YemekAdi NVARCHAR(100) NOT NULL,
        Kategori NVARCHAR(50) NOT NULL,
        Aciklama NVARCHAR(500),
        Resim NVARCHAR(255),
        Tarif NVARCHAR(MAX)
    );
END
GO

-- Örnek kategorilere göre verileri ekleme (varsa veriler tekrar eklenmez)
-- Ana Yemekler kategorisi için örnek veriler
IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Kıymalı Pide')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Kıymalı Pide', 'Ana Yemekler', 
        'Türk mutfağının sevilen lezzetlerinden biri olan kıymalı pide, hem doyurucu hem de lezzetlidir.',
        'resimler\kiymali_pide.jpg',
        'Malzemeler:
- 500g un
- 300ml ılık su
- 10g kuru maya
- 10g tuz
- 30ml zeytinyağı
- 400g kıyma
- 2 adet soğan
- 2 adet domates
- 1 adet biber
- Baharatlar

Hazırlanışı:
1. Hamur için un, su, maya, tuz ve zeytinyağını karıştırıp yoğurun.
2. Hamuru 30 dakika mayalanmaya bırakın.
3. Kıyma, soğan, domates ve baharat karışımını hazırlayın.
4. Hamuru oval şekilde açın ve iç malzemeyi yerleştirin.
5. 220 derecede 15-20 dakika pişirin.');
END

IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Köfte')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Köfte', 'Ana Yemekler', 
        'Türk mutfağının en sevilen et yemeklerinden biri olan köfte, her öğünde tercih edilebilir.',
        'resimler\kofte.jpg',
        'Malzemeler:
- 500g kıyma
- 1 adet soğan
- 2 diş sarımsak
- 1 çay kaşığı karbonat
- Tuz, karabiber, kimyon
- Maydanoz

Hazırlanışı:
1. Kıymayı geniş bir kaba alın.
2. Rendelenmiş soğan, sarımsak ve baharatları ekleyin.
3. Karbonat ve doğranmış maydanozu ekleyip iyice yoğurun.
4. 30 dakika buzdolabında dinlendirin.
5. Köfteleri şekillendirin.
6. Izgarada veya tavada pişirin.');
END

IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Karnıyarık')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Karnıyarık', 'Ana Yemekler', 
        'Patlıcan ve kıyma ile hazırlanan geleneksel Türk yemeği, zengin lezzetiyle sofraları şenlendirir.',
        'resimler\karniyarik.jpg',
        'Malzemeler:
- 6 adet patlıcan
- 300g kıyma
- 2 adet soğan
- 3 adet domates
- 3 adet yeşil biber
- 2 diş sarımsak
- Tuz, karabiber
- Zeytinyağı

Hazırlanışı:
1. Patlıcanları yıkayıp alacalı soyun.
2. Tuzlu suda bekletin, sonra kurulayın.
3. Kızgın yağda patlıcanları kızartın.
4. Soğan, sarımsak ve biberi yağda soteleyin.
5. Kıymayı ekleyip kavurun.
6. Domates ve baharatları ekleyin.
7. Patlıcanları yarıp içlerini doldurun.
8. 180 derecede 25-30 dakika pişirin.');
END

-- Çorbalar kategorisi için örnek veriler
IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Mercimek Çorbası')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Mercimek Çorbası', 'Çorbalar', 
        'Türk mutfağının vazgeçilmez çorbalarından biri olan mercimek çorbası, hem besleyici hem de lezzetlidir.',
        'resimler\mercimek_corbasi.jpg',
        'Malzemeler:
- 1.5 su bardağı kırmızı mercimek
- 1 adet soğan
- 1 adet havuç
- 1 adet patates
- 2 yemek kaşığı un
- 1 yemek kaşığı tereyağı
- Tuz, karabiber, nane
- 6 su bardağı su veya et suyu

Hazırlanışı:
1. Mercimekleri yıkayın.
2. Soğan, havuç ve patatesi küçük küçük doğrayın.
3. Tencerede tereyağı ile soğanları kavurun.
4. Havuç ve patatesi ekleyip kavurmaya devam edin.
5. Mercimekleri ekleyin ve karıştırın.
6. Su veya et suyunu ilave edip kaynamaya bırakın.
7. Mercimekler yumuşayınca blenderdan geçirin.
8. Tuz ve baharatları ilave edin.');
END

IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Ezogelin Çorbası')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Ezogelin Çorbası', 'Çorbalar', 
        'Gaziantep yöresine ait olan bu çorba, kırmızı mercimek, bulgur ve pirinç ile hazırlanır.',
        'resimler\ezogelin_corbasi.jpg',
        'Malzemeler:
- 1 su bardağı kırmızı mercimek
- 2 yemek kaşığı pirinç
- 2 yemek kaşığı bulgur
- 1 adet soğan
- 1 yemek kaşığı biber salçası
- 1 yemek kaşığı tereyağı
- Tuz, karabiber, nane, pul biber
- 8 su bardağı su

Hazırlanışı:
1. Mercimek, pirinç ve bulguru yıkayın.
2. Soğanı yemeklik doğrayın.
3. Tencerede tereyağı ile soğanları kavurun.
4. Salçayı ekleyip karıştırın.
5. Mercimek, pirinç ve bulguru ekleyin.
6. Su ilave edip kaynamaya bırakın.
7. Malzemeler yumuşayınca blenderdan geçirin.
8. Tuz ve baharatları ilave edin.');
END

-- Tatlılar kategorisi için örnek veriler
IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Baklava')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Baklava', 'Tatlılar', 
        'Türk mutfağının dünyaca ünlü tatlılarından biri olan baklava, ince yufka katmanları ve fıstık içeriğiyle göz dolduruyor.',
        'resimler\baklava.jpg',
        'Malzemeler:
- 30 adet yufka
- 500g tereyağı
- 500g Antep fıstığı
- 4 su bardağı şeker
- 2.5 su bardağı su
- Yarım limon suyu

Hazırlanışı:
1. Fıstıkları robottan geçirin.
2. Tereyağını eritin.
3. Yufkaları tepsiye sererek aralarına tereyağı sürün.
4. 15 kat yufka serdikten sonra fıstık serpin.
5. Kalan yufkaları da aynı şekilde dizin.
6. Baklavaları dilimleyin.
7. Kalan tereyağını üzerine dökün.
8. 180 derecede altı üstü kızarana kadar pişirin.
9. Şerbeti hazırlayıp soğuk şerbeti sıcak baklavanın üzerine dökün.');
END

IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Sütlaç')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Sütlaç', 'Tatlılar', 
        'Pirinç ve süt ile hazırlanan, fırında üzeri kızartılarak servis edilen geleneksel Türk tatlısı.',
        'resimler\sutlac.jpg',
        'Malzemeler:
- 1 litre süt
- 1 su bardağı şeker
- Yarım su bardağı pirinç
- 2 yemek kaşığı pirinç unu
- 1 paket vanilya
- 2 su bardağı su

Hazırlanışı:
1. Pirinci yıkayıp suda haşlayın.
2. Sütü kaynatın ve şekeri ekleyin.
3. Haşlanmış pirinçleri süte ekleyin.
4. Pirinç unu ve vanilyayı karıştırıp süte ilave edin.
5. Karışımı güveç kaplarına dökün.
6. 180 derecede üzeri kızarana kadar fırınlayın.
7. Soğuttuktan sonra servis yapın.');
END

-- Salatalar kategorisi için örnek veriler
IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Çoban Salatası')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Çoban Salatası', 'Salatalar', 
        'Domates, salatalık, biber ve soğan ile yapılan, zeytinyağı ve limon ile tatlandırılan klasik Türk salatası.',
        'resimler\coban_salatasi.jpg',
        'Malzemeler:
- 3 adet domates
- 2 adet salatalık
- 1 adet kırmızı soğan
- 2 adet yeşil biber
- 1 demet maydanoz
- Zeytinyağı
- Limon suyu
- Tuz

Hazırlanışı:
1. Tüm sebzeleri küp küçük doğrayın.
2. Maydanozu ince ince kıyın.
3. Tüm malzemeyi bir kasede karıştırın.
4. Zeytinyağı, limon suyu ve tuz ekleyip servis yapın.');
END

-- Daha fazla Ana Yemek ekleniyor
IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'İskender')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('İskender', 'Ana Yemekler', 
        'Bursa''nın meşhur lezzeti olan İskender, döner, tereyağı, domates sosu ve yoğurt ile servis edilen eşsiz bir Türk yemeğidir.',
        'resimler\iskender.jpg',
        'Malzemeler:
- 500g kuzu eti (ince dilimlenmiş)
- 2 adet pide
- 3 yemek kaşığı tereyağı
- 2 su bardağı domates sosu
- 250g yoğurt
- Tuz, karabiber
- Kırmızı biber

Hazırlanışı:
1. Eti marine edip döner şişine dizip pişirin.
2. Pideleri küçük parçalara bölüp tabaklara yerleştirin.
3. Pişen eti pidelerin üzerine yerleştirin.
4. Tereyağını kızdırıp üzerine dökün.
5. Domates sosunu kaynatıp etin üzerine gezdirin.
6. Yanına yoğurt koyarak servis edin.');
END

IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Mantı')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Mantı', 'Ana Yemekler', 
        'Kayseri yöresine ait, küçük hamur parçalarının içine kıyma konulup kapatıldıktan sonra haşlanıp, sarımsaklı yoğurt ve baharatlı sos ile servis edilen geleneksel Türk yemeği.',
        'resimler\manti.jpg',
        'Malzemeler:
- 3 su bardağı un
- 1 adet yumurta
- Tuz, su
- 250g kıyma
- 1 adet soğan
- Karabiber, tuz
- 500g yoğurt
- 2-3 diş sarımsak
- Tereyağı
- Pul biber, nane

Hazırlanışı:
1. Un, yumurta, tuz ve su ile hamur yoğurun, dinlendirin.
2. Kıyma, soğan, tuz ve karabiber ile iç harcı hazırlayın.
3. Hamuru ince açıp küçük kareler kesin.
4. Her karenin ortasına harçtan koyup kapatın.
5. Tuzlu suda haşlayın.
6. Sarımsaklı yoğurt hazırlayın.
7. Tereyağını eritip pul biber ve nane ekleyin.
8. Mantıların üzerine yoğurt ve sos gezdirerek servis edin.');
END

-- İçecekler kategorisi için örnek veriler
IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Ayran')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Ayran', 'İçecekler', 
        'Yoğurt, su ve tuz karışımından oluşan, Türk mutfağının geleneksel içeceği. Özellikle sıcak havalarda serinletici etkisiyle tercih edilir.',
        'resimler\ayran.jpg',
        'Malzemeler:
- 2 su bardağı yoğurt
- 2 su bardağı soğuk su
- Tuz

Hazırlanışı:
1. Yoğurt, su ve tuzu bir kaba alın.
2. Mikser veya çırpıcı ile köpürene kadar çırpın.
3. Bardaklara doldurup servis edin.');
END

IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Şalgam Suyu')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Şalgam Suyu', 'İçecekler', 
        'Mor havuç, şalgam, bulgur unu, ekşi maya ve tuzla yapılan, ekşi ve baharatlı tadıyla özellikle Adana ve Mersin yöresinde sevilen fermante bir içecek.',
        'resimler\salgam_suyu.jpg',
        'Malzemeler:
- 1 kg mor havuç
- 250g şalgam
- 100g bulgur unu
- Ekşi maya
- Tuz
- Kırmızı biber

Hazırlanışı:
1. Mor havuçları yıkayıp temizleyin.
2. Şalgamları soyup doğrayın.
3. Bulgur ununu, ekşi mayayı ve tuzu karıştırın.
4. Tüm malzemeleri büyük bir kavanoza koyun.
5. Üzerini geçecek kadar su ekleyin.
6. Kavanozun ağzını gevşek kapatın.
7. Serin ve karanlık bir yerde 1 hafta bekletin.
8. Süzüp servis edin.');
END

-- Mezeleri kataloglama
IF NOT EXISTS (SELECT * FROM Yemekler WHERE YemekAdi = 'Humus')
BEGIN
    INSERT INTO Yemekler (YemekAdi, Kategori, Aciklama, Resim, Tarif)
    VALUES ('Humus', 'Mezeler', 
        'Nohut, tahin, limon suyu, zeytinyağı ve sarımsakla yapılan, Orta Doğu kökenli bir meze.',
        'resimler\humus.jpg',
        'Malzemeler:
- 2 su bardağı haşlanmış nohut
- 3 yemek kaşığı tahin
- 2 diş sarımsak
- 2 yemek kaşığı limon suyu
- 3 yemek kaşığı zeytinyağı
- Tuz, kimyon, pul biber

Hazırlanışı:
1. Haşlanmış nohutların kabuklarını ayıklayın.
2. Nohut, tahin, sarımsak ve limon suyunu mutfak robotunda püre haline getirin.
3. Karışımı kremsi bir kıvam alana kadar zeytinyağı ile çırpın.
4. Servis tabağına alıp üzerine zeytinyağı gezdirin ve baharatları serpin.');
END