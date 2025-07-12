using LibraryManagementProject.Models;

namespace LibraryManagementProject.Repositories
{
    public class AuthorRepository
    {

        public static List<Author> Authors = new List<Author> // Static list of authors
        {
            new Author
            {
                Id = 1,
                FirstName = "Jack",
                LastName = "London",
                Biography = "Jack London (1876–1916), Amerikalı roman ve kısa öykü yazarıdır. Doğal yaşamla insanın mücadelesini anlatan güçlü ve sürükleyici eserleriyle tanınır. Zorluklarla geçen gençliğinde fabrika işçiliğinden altın arayıcılığına kadar pek çok işte çalıştı. Klondike Altına Hücumu sırasında yaşadığı deneyimler, özellikle Vahşetin Çağrısı (The Call of the Wild) ve Beyaz Diş (White Fang) gibi eserlerine ilham kaynağı olmuştur.Toplumsal adaletsizlik ve sınıf ayrımına karşı duyarlılığı, yazılarına yansımış ve sosyalist görüşleriyle dikkat çekmiştir. Sert doğa koşulları, bireysel hayatta kalma mücadelesi ve insan-doğa ilişkisi, kitaplarında öne çıkan temalardır.Kısa ömrüne rağmen Amerikan edebiyatında derin izler bırakmıştır.",
                DateOfBirth = new DateTime(1876, 1, 12),
                IsDeleted = false

            },
            new Author
            {
                Id = 2,
                FirstName = "Stefan",
                LastName = "Zweig",
                Biography = "Stefan Zweig (1881–1942), Avusturyalı yazar, biyografi ustası, denemeci ve gazetecidir. 20. yüzyılın ilk yarısında Avrupa'nın en çok okunan ve çevrilen yazarlarından biri olmuştur. Viyana’da varlıklı bir Yahudi ailenin çocuğu olarak doğan Zweig, edebiyat eğitimi aldı ve genç yaşta şiir, deneme ve öyküler yazmaya başladı.I. Dünya Savaşı sırasında barış yanlısı tutumuyla dikkat çekti. Avrupa’daki savaşlar, faşizmin yükselişi ve özellikle Nazizm, onun eserlerine derin bir hüzün ve insanlık üzerine sorgulamalar kattı. II. Dünya Savaşı’nın dehşeti ve Avrupa’nın çöküşü karşısında büyük bir umutsuzluğa kapılan Zweig, 1942’de eşiyle birlikte Brezilya’da intihar etti.En bilinen eserleri arasında Satranç, Bilinmeyen Bir Kadının Mektubu, Olağanüstü Bir Gece, Bir Çöküşün Öyküsü ve Dünün Dünyası yer alır.",
                DateOfBirth = new DateTime(1881, 11, 28),
                IsDeleted = false

            },

            new Author
            {
                Id = 3,
                FirstName = "Franz",
                LastName = "Kafka",
                Biography = "Franz Kafka (1883–1924), Alman dilinde yazan Çek kökenli bir yazardır. Modern dünya edebiyatının en etkileyici ve özgün figürlerinden biri olarak kabul edilir. Eserlerinde bürokrasi, yabancılaşma, suçluluk duygusu, otorite karşısında bireyin çaresizliği gibi temaları işler. Hikâyelerinde sık sık absürt, karanlık ve rüya benzeri atmosferler görülür.\r\n\r\nKafka, Prag'da doğmuş, hukuk eğitimi almış ve sigorta şirketlerinde çalışmıştır. Hayatı boyunca az sayıda eser yayımlamış, çoğu yazdıklarını ölümünden sonra yayımlanmamak üzere arkadaşı Max Brod’a bırakmıştır. Ancak Brod onun vasiyetine uymamış ve Kafka’nın başyapıtları olan Dava, Şato ve Amerika gibi eserleri yayımlamıştır.",
                DateOfBirth = new DateTime(1883, 7, 3),
                IsDeleted = false

            },
            new Author
            {
                Id = 4,
                FirstName = "Fyodor Mihayloviç",
                LastName = "Dostoyevski",
                Biography = "Fyodor Mihayloviç Dostoyevski (1821–1881), Rus romancı, kısa hikâye yazarı ve düşünürdür. 1821 yılında Moskova’da doğdu. Mühendislik eğitimi aldıktan sonra edebiyata yöneldi. 1849'da siyasi faaliyetleri nedeniyle tutuklandı, idama mahkûm edildi fakat son anda cezası Sibirya sürgününe çevrildi. Bu deneyim, eserlerinde insan psikolojisini derinlemesine işlemesine zemin hazırladı.En bilinen eserleri arasında Suç ve Ceza, Budala, Karamazov Kardeşler ve Yeraltından Notlar bulunur. İnsan ruhunun karanlık yönlerini, inanç, özgürlük ve ahlak gibi temaları benzersiz bir şekilde işledi. 1881 yılında St. Petersburg’da hayatını kaybetti.",
                DateOfBirth = new DateTime(1821, 11, 11),
                IsDeleted = false

            },

            new Author
            {
                Id = 5,
                FirstName = "Ray",
                LastName = " Bradbury",
                Biography = "Ray Bradbury (1920–2012), Amerikalı yazar ve senaristtir. En çok bilim kurgu, fantastik ve distopik türlerde verdiği eserlerle tanınır. Özellikle insan doğası, teknoloji, özgürlük ve sansür gibi temaları işlediği eserleriyle modern edebiyatın önemli isimlerinden biri olmuştur.En ünlü eseri olan Fahrenheit 451, kitapların yasaklandığı ve yakıldığı totaliter bir geleceği anlatır ve sansür karşıtı güçlü bir mesaj taşır. Bradbury, aynı zamanda birçok kısa öykü koleksiyonu, oyun ve televizyon senaryosu da yazmıştır. Edebi tarzı şiirsel dili, hayal gücü ve insani değerleriyle dikkat çeker.",
                DateOfBirth = new DateTime(1920, 8, 22),
                IsDeleted = false

            },
            new Author
            {
                Id = 6,
                FirstName = "Douglas",
                LastName = " Adams",
                Biography = "Douglas Adams (1952–2001), İngiliz mizah yazarı, senarist ve radyo yapımcısıdır. En çok kült bilim kurgu serisi olan Otostopçunun Galaksi Rehberi (The Hitchhiker's Guide to the Galaxy) ile tanınır. Absürt mizahı, bilim kurgu klişeleriyle harmanlayan tarzıyla büyük bir hayran kitlesi kazanmıştır.Adams yazarlık kariyerine radyo tiyatrosu ile başladı ve daha sonra roman, televizyon dizisi ve bilgisayar oyunu gibi farklı formatlarda da üretken oldu. Aynı zamanda çevrecilik ve teknolojiye olan ilgisiyle de bilinir. Beklenmedik bir şekilde 49 yaşında hayatını kaybetmiştir.",
                DateOfBirth = new DateTime(1952, 3, 11),
                IsDeleted = false

            },
            new Author
            {
                Id = 7,
                FirstName = "Ursula K.",
                LastName = " Le Guin",
                Biography = "Ursula Kroeber Le Guin (1929–2018), Amerikalı yazar ve edebiyat dünyasının en saygın isimlerinden biridir. Bilim kurgu ve fantastik türlerinde çığır açan eserler kaleme almıştır. Toplum, cinsiyet, kimlik, güç dengesi ve doğa temalarını işlerken hem felsefi hem de şiirsel bir anlatım kullanmıştır.Antropolog bir babanın ve yazar bir annenin kızı olan Le Guin, bu kültürel birikimi eserlerine taşımıştır. En ünlü yapıtları arasında Mülksüzler, Karanlığın Sol Eli ve Yerdeniz Serisi yer alır. Özellikle feminizm, anarşizm ve Taoizm'den etkilenen görüşleriyle, bilim kurgunun sadece teknoloji değil insanlık üzerine de düşündüren bir tür olduğunu göstermiştir.",
                DateOfBirth = new DateTime(1929, 10, 21),
                IsDeleted = false

            },
            new Author
            {
                Id = 8,
                FirstName = "Stephen",
                LastName = "King",
                Biography = "Stephen King (1947–), Amerikalı yazar ve “korku edebiyatının kralı” olarak anılır. Korku, gerilim, bilim kurgu ve fantastik türlerinde 60’tan fazla roman ve 200’ün üzerinde kısa hikâye yazmıştır. Eserleri dünya çapında 400 milyondan fazla satmış, birçoğu da filme ve diziye uyarlanmıştır.İlk büyük çıkışını 1974’te yayımlanan Carrie ile yaptı. The Shining (Medyum), It (O), Misery, The Stand (Mahşer) ve Pet Sematary (Hayvan Mezarlığı) gibi romanları kült hâline geldi. Genellikle sıradan insanların başına gelen doğaüstü veya psikolojik korkular üzerinden Amerikan toplumunun korkularını yansıtır.Zor bir çocukluk geçiren King, alkol ve madde bağımlılığıyla da mücadele etti, bu deneyimler kitaplarına da yansımıştır. Hâlâ yazmaya devam eden King, aynı zamanda toplumsal ve politik konularda da aktif bir ses olmuştur.",
                DateOfBirth = new DateTime(1947, 9, 21),
                IsDeleted = false

            },
            new Author
            {
                Id = 9,
                FirstName = "Oğuz",
                LastName = "Atay",
                Biography = "Oğuz Atay (1934–1977), modern Türk edebiyatının en özgün ve etkileyici yazarlarından biridir. Mühendislik eğitimi almasına rağmen edebiyata yönelmiş, özellikle bireyin toplumla, kendiyle ve geçmişle çatışmalarını postmodern tekniklerle ele almıştır. Eserlerinde iç monologlar, ironi, oyunlar ve çok katmanlı anlatılar öne çıkar.Oğuz Atay, yaşadığı dönemde yeterince anlaşılamamış olsa da, ölümünden sonra Türk edebiyatında bir kırılma noktası olarak kabul edilmiştir. Özellikle Tutunamayanlar romanı, “tutunamayan” bireyin topluma karşı mücadelesini hem acıklı hem de ironik bir dille yansıtarak edebiyatımızda çığır açmıştır.",
                DateOfBirth = new DateTime(1934, 10, 12),
                IsDeleted = false

            },
            new Author
            {
                Id = 10,
                FirstName = "Birhan",
                LastName = "Keskin",
                Biography = "Türk şair, yazar. 1986 yılında İstanbul Üniversitesi Edebiyat Fakültesi Sosyoloji Bölümü'nü bitirdi. İlk şiirini 1984 yılında yayımladı. 1995-98 yılları arasında arkadaşlarıyla birlikte Göçebe dergisini çıkardı.Çeşitli yayın kuruluşlarında editör olarak çalıştı. 1991 ile 2002 arasında beş şiir kitabı yayımladı.",
                DateOfBirth = new DateTime(1963, 11, 22),
                IsDeleted = false

            },
            new Author
            {
                Id = 11,
                FirstName = "Ernest",
                LastName = "Hemingway",
                Biography = "Ernest Hemingway (1899–1961), Amerikalı romancı, kısa öykü yazarı ve gazetecidir. 20. yüzyıl edebiyatının en etkili yazarlarından biri olarak kabul edilir. Sade, doğrudan ve gösterişsiz anlatımı ile tanınır; bu tarzı “buzdağı tekniği” (görünenin altında derin anlamlar barındıran anlatım) olarak da bilinir.Gençliğinde I. Dünya Savaşı'nda ambulans şoförü olarak görev yaptı, bu deneyimler yazılarına ilham verdi. En bilinen eserleri arasında Çanlar Kimin İçin Çalıyor (For Whom the Bell Tolls), Silahlara Veda (A Farewell to Arms) ve Yaşlı Adam ve Deniz (The Old Man and the Sea) yer alır. 1954 yılında Nobel Edebiyat Ödülü'nü kazanmıştır.Hayatı boyunca savaş, ölüm, cesaret, aşk ve insanın doğayla ilişkisi gibi temaları işledi. 1961’de psikolojik sorunları nedeniyle kendi yaşamına son verdi.",
                DateOfBirth = new DateTime(1899, 07, 21),
                IsDeleted = false

            },
            new Author
            {
                Id = 12,
                FirstName = "Edgar Allan",
                LastName = "Poe",
                Biography = "Edgar Allan Poe (1809–1849), Amerikalı şair, öykü yazarı, editör ve edebiyat eleştirmenidir. Gotik korku, psikolojik gerilim ve dedektif kurgu türlerinin öncüsü olarak kabul edilir. Modern polisiyenin kurucusu sayılan Poe, aynı zamanda kara romantizmin en önemli temsilcilerindendir.Zor bir çocukluk geçirmiş, genç yaşta yetim kalmış ve yoksullukla mücadele etmiştir. Hayatı boyunca birçok kişisel trajedi yaşamış ve bu karanlık deneyimlerini yazılarına yansıtmıştır. Kuzgun (The Raven), Usher Evinin Çöküşü, Kuyu ve Sarkaç gibi şiir ve öyküleriyle unutulmaz bir edebi miras bırakmıştır.",
                DateOfBirth = new DateTime(1809, 01, 18),
                IsDeleted = false

            },
            new Author
            {
                Id = 13,
                FirstName = "Irvin D.",
                LastName = "Yalom",
                Biography = "Irvin David Yalom (1931–), Amerikalı psikiyatr, psikoterapist ve yazardır. Özellikle varoluşçu psikoterapi alanındaki çalışmalarıyla tanınır. Hem akademik hem de edebi düzeyde etkili eserler vermiştir. Psikolojiyi felsefe ile birleştiren yaklaşımıyla, terapi sürecini sadece hastalık değil, insan olmanın anlamı çerçevesinde ele almıştır.",
                DateOfBirth = new DateTime(1931, 06, 13),
                IsDeleted = false

            },
            new Author
            {
                Id = 14,
                FirstName = "Emil Michel",
                LastName = "Cioran",
                Biography = "Emil Michel Cioran (1911–1995), Rumen asıllı Fransız filozof ve deneme yazarıdır. Varoluşçuluk, nihilizm, umutsuzluk, ölüm ve hiçlik temalarını derinlemesine işlemiş, karamsar felsefenin en çarpıcı temsilcilerinden biri olmuştur.İlk eserlerini Romence yazan Cioran, 1937’de Fransa’ya yerleşmiş ve daha sonra Fransızca yazmaya başlamıştır. Çürümenin Kitabı, Umutsuzluğun Doruklarında, Zamanla Yüzleşme, Var Olma Eğilimi gibi kitapları, aforizmalarla dolu çarpıcı ve keskin üsluplarıyla tanınır.Cioran için hayat, anlamdan yoksun ve trajik bir deneyimdir. Ancak bu karamsarlığı, ona göre yüzeysel bir iyimserlikten çok daha dürüst ve insancıldır. Kendisi hiçbir zaman sistematik bir felsefi yapı kurmamış, daha çok sezgisel ve edebi bir anlatımla insan varoluşunu sorgulamıştır.",
                DateOfBirth = new DateTime(1911, 04, 08),
                IsDeleted = false

            },

        };
    }
}
