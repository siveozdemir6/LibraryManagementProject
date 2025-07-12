using LibraryManagementProject.Models;

namespace LibraryManagementProject.Repositories
{
    public class BookRepository
    {
        public static List<Book> Books = new List<Book>  // Static list of books 
        {
            new Book
            {
                Id = 1,
                Title = "Martin Eden",
                AuthorId = 1,
                GenreId = 1,
                PublishDate = new DateTime(1909, 1, 10),
                ISBN = "9786053322122",
                PageCount = 517,
                Description = "Martin Eden, kendi çabasıyla yükselmeye çalışan genç bir denizci olan Martin’in, entelektüel dünyaya ve burjuva sınıfına duyduğu hayranlıkla başlayan; zamanla bu dünyanın çelişkileri karşısında yaşadığı hayal kırıklığını anlatan yarı otobiyografik bir romandır.Martin, burjuva bir ailenin kızı olan Ruth’a âşık olduktan sonra, sıradan bir işçiyken yazar olmak için büyük bir mücadeleye girişir. Kitap boyunca sınıf atlamanın zorluğu, bireysel azim, toplumsal yabancılaşma ve sanatın ticarileşmesi gibi temalar işlenir. Ancak Martin başarıya ulaştığında, sevdiği dünyadan artık yabancılaşmış ve yalnızlaşmıştır. Roman, idealizmin çöküşünü ve bireyin içsel boşluğunu etkileyici bir şekilde yansıtır." ,
                TotalCopies = 5,
                BorrowedCopies = 0, // Initialize borrowed copies to 0
            },

            new Book
            {
                Id = 2,
                Title = "Olağanüstü Bir Gece",
                AuthorId = 2,
                GenreId = 1,
                PublishDate = new DateTime(1922, 10, 5),
                ISBN = "9786053326090",
                PageCount = 69,
                Description = "Olağanüstü Bir Gece, seçkin bir burjuva olarak rahat ve tasasız varoluşunu sürdürürken giderek duyarsızlaşan bir adamın hayatındaki dönüştürücü deneyimin hikâyesidir. Sıradan bir Pazar gününü at yarışlarında geçirirken, belki de ilk kez burjuva ahlakından saparak “suç” işler. Böylece yeniden “hissetmeye” başladığını, kötücül ve ateşli hazları olan gerçek bir insan olduğunu fark eder. İçindeki haz dolu esrime, aynı günün akşamında onu gece âleminin son atıklarının arasına, “hayatın en dibindeki lağımlara” sürükleyecek, varış noktası ise ruhani bir uyanış olacaktır.",
                TotalCopies = 1,
                BorrowedCopies = 0, // Initialize borrowed copies to 0
            },
            new Book
            {
                Id = 3,
                Title = "Amok Koşucusu",
                AuthorId = 2,
                GenreId = 1,
                PublishDate = new DateTime(1922, 7, 5),
                ISBN = "9786053329053",
                PageCount = 60,
                Description = "Amok Koşucusu doktor olarak yardıma ihtiyaç duyan bir insana el uzatmanın vicdani yükümlülüğüyle kendi karmaşık duyguları arasında sıkışıp kalan bir adamın hikâyesidir. Hollanda Doğu Hint Adaları’nda görev yapan bir doktor, dara düşüp kendisine başvuran çok zengin bir kadının “yardım” talebini geri çevirir. Zira kadının mağrur ve hesapçı tavrı karşısında büyük bir öfkeye kapılmış, gururuna yenik düşmüştür.Ancak söz konusu olan insan hayatıdır. Kısa süre içinde pişmanlığın pençesine düşer. Kadına yardım etmeyi saplantı haline getiren doktor, Malezya halkında rastlanan bir nevi öldürücü delilik olan hummanın, amokun etkisi altına girer.",
                TotalCopies = 6, 
                BorrowedCopies = 0
            },
            new Book
            {
                Id = 4,
                Title = "Dönüşüm",
                AuthorId = 3,
                GenreId = 1,
                PublishDate = new DateTime(1915, 3, 21),
                ISBN = "9786053609322",
                PageCount = 74,
                Description = "İlk kez 1915'te “Die Weissen Blaetter” adlı aylık dergide yayımlanan Dönüşüm, Kafka'nın en uzun ve en tanınmış öyküsüdür ve yayımlanmasının üzerinden nerdeyse bir asır geçmesine rağmen hâlâ tüm dünyada en çok okunan kitaplar arasındadır.17 Ekim 1912'de Felice Bauer'e gönderdiği mektupta Kafka Amerika romanı üzerinde çalıştığını, ilerleyemediğini görünce sıkıldığını ve yataktan kalkamaz hale geldiğini, bu nedenle bir öykü yazarak ara vermek istediğini yazar. Dönüşüm işte böyle ortaya çıkar.Kumaş pazarlamacısı olan Gregor Samsa'nın uykusundan kocaman bir böceğe dönüşerek uyanmasıyla başlayan Dönüşüm, giderek gerçeklikle kurmacanın sınırlarını zorlayan müthiş bir anlatıma dönüşür.",
                TotalCopies = 5,
                BorrowedCopies = 0, 
            },

            new Book
            {
                Id = 5,
                Title = "Yeraltından Notlar",
                AuthorId = 4,
                GenreId = 1,
                PublishDate = new DateTime(1864, 4, 10),
                ISBN = "9789944884013",
                PageCount = 140,
                Description = "Dostoyevski'nin Rus çoğunluğunun hakiki insanı dediği bir isimsiz kahramanın yalın ve karanlık düşünceleri... Edebiyat tarihinin en ünlü isimsizlerinden Yeraltı Adamı, insanların oradan oraya üşüşen karıncalara dönüştüğü St. Petersburg'un gri kaldırımlarında itilip kakılırken, yaşama isteğini yavaş ama emin adımlarla mutlak bir öç isteğiyle değiş tokuş eder. Yeraltı Adamı'nın bir devlet memuru olarak geçirdiği tekdüze günler, yanında bir türlü rahat hissedemediği arkadaşları ve hayattaki mutlak yalnızlığı, bıkkın bir öfke ve küçük, imkânsız pazarlıklarla gittikçe daha fazla lekelenir, ta ki kendisini bir arada tutan görünmez ipler yavaşça çözülmeye başlayana kadar. Yeraltından Notlar, yayımlandığı 1864 yılından beri öfke ve sessizliğin en güçlü manifestolarından biri olmuştur." ,
               TotalCopies = 3, 
                BorrowedCopies = 0,

            },
            new Book
            {
                Id = 6,
                Title = "Ölüler Evinden Anılar",
                AuthorId = 4,
                GenreId = 1,
                PublishDate = new DateTime(1862, 1, 10),
                ISBN = "9780451524935",
                PageCount = 376,
                Description = "Ölüler Evinden Anılar, Fyodor Dostoyevski’nin Sibirya’da geçirdiği sürgün yıllarına dayanan yarı otobiyografik bir romandır. Eserde, çarlık Rusya’sında bir hapishanedeki mahkumların yaşamları, psikolojileri, acıları ve insanlık durumları anlatılır. Anlatıcı, soylu bir mahkûm olan Aleksandr Petrovich’tir ve onun gözünden cezaevi yaşamı gözlemlenir.Roman, bireyin ruhsal çözümlemesini yaparken aynı zamanda Rus toplumunun çeşitli sınıflarına ve adalet sistemine eleştirel bir bakış sunar. Dostoyevski bu eserde, insanın en ağır koşullarda bile insan kalma mücadelesini işlemiştir.",
                TotalCopies = 2, 
                BorrowedCopies = 0


            },

            new Book
            {
                Id = 7,
                Title = "Fahrenheit 451",
                AuthorId = 5,
                GenreId = 2,
                PublishDate = new DateTime(1953, 10, 10),
                ISBN = "9786053757818",
                PageCount = 202,
                Description = "Ray Bradbury sadece bilimkurgunun değil fantastik edebiyatın ve korkunun da yirminci yüzyıldaki ustalarından biri. Bilimkurgunun “iyi edebiyat” da olabileceğini kanıtlayan belki de ilk yazar. Yayımlandığı anda klasikleşen, distopya edebiyatının dört temel kitabından biri olan Fahrenheit 451 ise bir yirminci yüzyıl başyapıtı.Guy Montag bir itfaiyeciydi. Televizyonun hüküm sürdüğü bu dünyada kitaplar ise yok olmak üzereydi zira itfaiyeciler yangın söndürmek yerine ortalığı ateşe veriyordu. Montag’ın işi ise yasadışı olanların en tehlikelisini yakmaktı: Kitapları.Montag yaptığı işi tek bir gün dahi sorgulamamıştı ve tüm gününü televizyonla kaplı odalarda geçiren eşi Mildred’la beraber yaşıyordu. Ancak yeni komşusu Clarisse’le tanışmasıyla tüm hayatı değişti. Kitapların değerini kavramaya başlayan Montag artık tüm bildiklerini sorgulayacaktı.İnsanların uğruna canlarını feda etmeyi göze aldığı bu kitapların içinde ne vardı? Gerçeklerin farkına vardıktan sonra bu karanlık toplumda artık yaşanabilir miydi?Fahrenheit 451, yeryüzünde tek bir kitap kalacak olsa, o kitap olmaya aday.“Mutlu olmamız için gerekli her şeye sahibiz, ama mutlu değiliz. Bir şey eksik. Etrafa bakındım. Ortadan kaybolduğunu kesinlikle bildiğim tek şey, on-on iki yıldır yaktığım kitaplardı.”",
                TotalCopies = 5,
                BorrowedCopies = 0, 

            },
            new Book
            {
                Id = 8,
                Title = "Otostopçunun Galaksi Rehberi",
                AuthorId = 6,
                GenreId = 2,
                PublishDate = new DateTime(1979, 10, 15),
                ISBN = "9786051715124",
                PageCount = 248,
                Description = "Otostopçunun Galaksi Rehberi, sıradan bir İngiliz olan Arthur Dent’in, Dünya'nın ani bir şekilde yok edilmesinin ardından galaksiler arası çılgın bir yolculuğa çıkmasını konu alır. Dünya, uzayda bir hiperuzay yolu inşası için yok edilir ve Arthur, uzaylı arkadaşı Ford Prefect sayesinde son anda kurtulur.Yanlarında galaksinin en garip ve komik karakterleri vardır: İki kafalı uzay başkanı Zaphod Beeblebrox, depresif robot Marvin, ve akıllı araştırmacı Trillian. Ekip, evrenin anlamını ararken absürt olaylar, bürokratik uzaylılar ve felsefi sorularla karşılaşır.Roman, “Hayat, evren ve her şeyin cevabı 42’dir” gibi ikonik replikleriyle tanınır ve bilim kurguyu zekice hicivle harmanlar.",
                TotalCopies = 10, 
                BorrowedCopies = 0

            },
            new Book
            {
                Id = 9,
                Title = "Yerdeniz Büyücüsü",
                AuthorId = 7,
                GenreId = 3,
                PublishDate = new DateTime(1968, 5, 15),
                ISBN = "9789753420570",
                PageCount = 192,
                Description = "Yerdeniz Büyücüsü (A Wizard of Earthsea, 1968), genç bir çoban olan Ged’in büyü gücünü keşfetmesi ve bir büyücü olarak olgunlaşma yolculuğunu konu alır. Ged, büyü konusunda olağanüstü bir yeteneğe sahiptir ancak kibri ve sabırsızlığı yüzünden bir büyü sırasında gölgemsi bir yaratığı dünyaya salıverir.Roman boyunca Ged, hem bu karanlık varlıkla hem de kendi içindeki korkularla yüzleşir. Yolculuğu yalnızca fiziksel değil, ruhsal bir olgunlaşmayı da temsil eder. Kitap, isimlerin gücü, denge, öz disiplin ve sorumluluk gibi temalar üzerine kuruludur.",
                TotalCopies = 5, 
                BorrowedCopies = 0

            },
            new Book
            {
                Id = 10,
                Title = "O",
                AuthorId = 8,
                GenreId = 4,
                PublishDate = new DateTime(1986, 9, 21),
                ISBN = "9789752119277",
                PageCount = 1142,
                Description = "Küçük bir Amerikan kasabası olan Derry’yi diğer kasabalardan farklı kılan şey, kanalizasyon mazgallarının altındaki dehlizlerde yaşayan, kendini kimi zaman kâbuslarda, kimi zaman da gerçek hayatta gösteren bir yaratığın, insanları kendi karanlık dünyasına çeken esrarengiz bir gücün varlığıdır. Bu korkunç yaratıkla uzun yıllar önce savaşıp ardından kasabayı terk eden ve kendilerine yeni bir hayat kurmuş olan yedi çocuk, artık birer yetişkin olmuş ve yaşadıkları dehşet dolu günleri unutmuşlardır. Ancak, anılarının derinliklerine gömülen yaratık yıllar sonra yeniden harekete geçince, onunla bir kez daha hesaplaşmak zorunda kalırlar. Geçmişte kalan kâbuslar, şimdiki zamanda korkunç bir gerçeğe dönüşmüştür artık.Stephen King’in yazımını dört yılda tamamladığı ölümsüz başyapıtının sansürsüz ve eksiksiz metnini okurken tam da Daily Express’in tarif ettiği gibi, kendinizi O’nun karanlık dünyasında hissedeceksiniz.",
                TotalCopies = 3, 
                BorrowedCopies = 0

            },
            new Book
            {
                Id = 11,
                Title = "Tutunamayanlar",
                AuthorId = 9,
                GenreId = 6,
                PublishDate = new DateTime(1971, 9, 21),
                ISBN = "9789754700114",
                PageCount = 724,
                Description = "Selim Işık'ın intihar ettiğini öğrenen Turgut Özben, ihmal ettiğini düşündüğü arkadaşının geçmişinin izini sürmeye ve Selim'in tanıdığı insanlar aracılığıyla onu tanımaya çalışır. Her insana farklı bir yönünü gösteren Selim'in görüntüsü, Turgut'un bu insanlarla konuşması sonucu okuyucunun ve Turgut'un gözünde netlik kazanacaktır. Romanda birçok kişi vardır ama her biri aslında Selim'in hayatındaki kişilerdir ve tüm anlatılanlar Selim Işık'ı aydınlatır. Selim Işık, düşünen ve sorgulayan insanın simgesidir ve bu yüzden hayata tutunamamış ve bir tutunamayan olmuştur.Yıldız Ecevit'in yazdığı Ben Buradayım... başlıklı Oğuz Atay biyografisinin ardından, romanın pek çok otobiyografik öğe taşıdığı anlaşılmıştır. Berna Moran'a göre küçük burjuva dünyasını zekice alaya alan Atay, saldırısını, tutunanların anlamayacağı, red edeceği türden bir romanla yapar.",
                TotalCopies = 15,
                BorrowedCopies = 0, 

            },
            new Book
            {
                Id = 12,
                Title = "Tehlikeli Oyunlar",
                AuthorId = 9,
                GenreId = 5,
                PublishDate = new DateTime(1973, 12, 8),
                ISBN = "9789754702095",
                PageCount = 479,
                Description = "Tehlikeli Oyunlar (1973), hayal ve gerçek arasında gidip gelen, toplumdan dışlanmış bir adam olan Hikmet Benol’un zihinsel parçalanmışlığını anlatır. Hikmet, hayatın anlamını tiyatrosal oyunlar kurarak, kendi içindeki karakterlerle hesaplaşarak bulmaya çalışır.Roman, modern bireyin parçalanmış kimliğini, toplumun baskısıyla yüzleşmesini ve kaçış arayışlarını merkezine alır. Hikmet’in oyunları aslında kendi içsel hesaplaşmalarının ve topluma uyum sağlayamamasının bir ifadesidir.",
                TotalCopies = 5, 
                BorrowedCopies = 0,

            },
            new Book
            {
                Id = 13,
                Title = "Kim Bağışlayacak Beni?",
                AuthorId = 10,
                GenreId = 7,
                PublishDate = new DateTime(2020, 09, 8),
                ISBN = "9789753425131",
                PageCount = 184,
                Description = @"Serin bir rüyanın hatırınadır
                                çektiğim dünya ağrısı.

                                Bir hayalden geldim ben,
                                bir hayal verdim sana,
                                mavi-yeşil bir hatıra: işte dünya
                                ruhum! ovada sert es, yamaçta sus,
                                ırmakta ağla.

                                İşte dünya kapısı, işte dünya kederi
                                ister dağının gölgesinde dur, ister
                                incirin neşesine vur
                                ağrı kendini ve tamamla.",
                TotalCopies = 0, 
                BorrowedCopies = 0

            },
            new Book
            {
                Id = 14,
                Title = "Yaşlı Adam ve Deniz",
                AuthorId = 11,
                GenreId = 8,
                PublishDate = new DateTime(1950, 09, 8),
                ISBN = "9789752201682",
                PageCount = 88,
                Description = "Ernest Hemingway’in bu ünlü kısa romanı, Kübalı yaşlı bir balıkçı olan Santiago’nun, uzun süredir balık tutamamasının ardından denize açılması ve verdiği epik mücadeleyi anlatır.Santiago, 84 gündür hiç balık yakalayamamıştır. Genç yardımcısı Manolin, ailesinin isteğiyle başka bir balıkçıyla çalışsa da, yaşlı adama derin bir sevgi ve saygı duymaya devam eder. Santiago, 85. gün büyük bir umutla tek başına denize açılır ve devasa bir kılıç balığı yakalar.\r\n\r\nAncak balığı hemen çekemez; Santiago ile dev balık arasında günler süren bir mücadele başlar. Balığı sonunda öldürüp teknesine bağlayarak geri dönmeye çalışır, ancak dönüş yolunda köpekbalıkları balığı parçalayarak yer. Santiago limana ulaştığında geriye sadece dev bir balık iskeleti kalmıştır.",
                TotalCopies = 5,
                BorrowedCopies = 0, 

            },
            new Book
            {
                Id = 15,
                Title = "Morgue Sokağı Cinayetleri",
                AuthorId = 12,
                GenreId = 9,
                PublishDate = new DateTime(1841, 09, 8),
                ISBN = "9786050017021",
                PageCount = 142,
                Description = "Morgue Sokağı Cinayetleri (The Murders in the Rue Morgue, 1841), modern dedektif öyküsünün ilk örneği kabul edilir.Paris'te, Morgue Sokağı’ndaki bir evde anne-kız vahşice öldürülür. Olayın çözülmesi için hiçbir ipucu yok gibidir. Polis başarısız olunca, zeki ve eksantrik bir adam olan C. Auguste Dupin davayı incelemeye başlar. (Bu karakter, Sherlock Holmes’tan önce yaratılmış ilk dedektiftir.)",
                TotalCopies = 3, 
                BorrowedCopies = 0 

            },
            new Book
            {
                Id = 16,
                Title = "Nietzsche Ağladığında",
                AuthorId = 13,
                GenreId = 10,
                PublishDate = new DateTime(1992, 10, 8),
                ISBN = "9789755391465",
                PageCount = 416,
                Description = "Her hastanın hikâyesinin biricik olduğuna, her biri için farklı terapi uygulamak gerektiğine inanan psikiyatr Irvin D. Yalom, ilk kez 1992 yılında yayımlanan, tüm dünyada çok okunup çok sevilen ve kendi hayat hikâyesinden de izler taşıyan Nietzsche Ağladığında adlı romanında kurmacayla gerçeği harmanlıyor. Dostluğun iyileştirici gücüne dair unutulmaz bir hikâye anlatırken Yalom, okurlarını 19. yüzyıl Viyana’sında, psikanalizin doğum sancılarının başladığı dönemde ve o yılların entelektüel çevresinde ağırlıyor. Henüz iki kitabı yayımlanmış, kimsenin tanımadığı ve son derece yoksul bir filozof olan Friedrich Nietzsche’nin yolu, bir gün henüz gençliğinin baharındayken pek çok sanatçının ve düşünürün doktoru olmayı başarmış, zengin ve saygın bir karakter olan Josef Breuer’le kesişir. Bunda Nietzsche’nin arkadaşı, genç ve güzel bir kadın olan Lou Salomé’nin payı yadsınamayacak derecede büyüktür; kendisi Nietzsche’nin yalnızlığına, ümitsizliğine ve hastalıklarına Breuer’den başkasının çare olamayacağını düşünür. Haklıdır da. Ama bu o kadar kolay olmaz. Nietzsche yardımı kabul etmediği gibi hasta olduğunu da inkâr eder. Süreç zorlu bir yola girse de yolculukları “konuşma terapileriyle” yavaş yavaş ilerler. Bu seanslarda sadece Nietzsche değil, Breuer de teselli bulur. Kendisinin şeytani yönleriyle yüzleşen yetenekli doktor ancak ondan sonra hastasını iyileştirme gücünü kendisinde bulabilir. Breuer bu esnada yakın arkadaşı ve öğrencisi olan Sigmund Freud ile de sık sık görüşüp uyguladığı tedavi yöntemlerini ve süreci paylaşır. Nietzsche’nin düşüncelerini psikanalizle buluşturmasına şahit olduğunuz bu “konuşma terapisi” seanslarında siz de hem hayata dair derin sorgulamalara gireceksiniz hem de kendinizle yüzleşeceksiniz.",
                TotalCopies = 7,
                BorrowedCopies = 0, 

            },
            new Book
            {
                Id = 17,
                Title = "Çürümenin Kitabı",
                AuthorId = 14,
                GenreId = 11,
                PublishDate = new DateTime(1949, 9, 18),
                ISBN = "9789753422666",
                PageCount = 192,
                Description = "Nerede tükettin ömrünü? Bir hareketin hatırası, bir tutkunun işareti, bir maceranın parıltısı, güzel ve firari bir cinnet – geçmişinde bunların hiçbiri yok; hiçbir sayıklama senin ismini taşımıyor, seni hiçbir zaaf onurlandırmıyor. İz bırakmadan kayıp gittin; senin rüyan neydi peki?",
                TotalCopies = 5, 
                BorrowedCopies = 0,

            },
            new Book
            {
                Id = 18,
                Title = "Umutsuzluğun Doruklarında",
                AuthorId = 14,
                GenreId = 11,
                PublishDate = new DateTime(1934, 9, 18),
                ISBN = "9786056923968",
                PageCount = 152,
                Description = @"Umutsuzluğun Doruklarında, Cioran’ın 23 yaşında, tam da uykusuzluk hastalığının başladığı yıllarda yazdığı ve onu filozoflar katına çıkaran; sonsuz dünya içindeki sonlu insanın anlamı, aşk, acı, sevinç, ölüm ve umutsuzluk hakkında, sert ve ele avuca gelmeyen fikirlerin yoğuştuğu bir kitap.
                             -Hayatın anlamsızlığını bilip de buna rağmen devam etmek, işte asıl cesaret budur.",
                TotalCopies = 5,
                BorrowedCopies = 0, 

            },
        };
    }
}
