using EfCore.ConsoleApp.Context;
using EfCore.ConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EfCore.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EfGiris();
            //LinqGiris();
            //LinqToObjectClass();
            //LinqToMath();
            //LinqToJoin();
            LinqToEntity();
            Console.ReadLine();
        }

        private static void LinqToEntity()
        {
            Console.WriteLine("Linq to Entity");

            NorthwindDbContext dbContext = new NorthwindDbContext();
            IQueryable<Category> categoryList = from c in dbContext.Categories where c.CategoryId == 5 select c;

            Category first = categoryList.FirstOrDefault(); //Exception ile yaklanıp değer kontrolü yapılır.
            Category last = categoryList.OrderBy(c => c.CategoryId).LastOrDefault();
            Category single = categoryList.Single();


            IQueryable<Category> categoryList2 = from c in dbContext.Categories select c;

            foreach (Category category in categoryList2)
            {
                Console.WriteLine(category.CategoryId + " " + category.CategoryName);
                foreach(Product product in category.Products)
                {
                    Console.WriteLine("\t" + product.ProductId + ") " + product.ProductName);
                }
            }

            IQueryable<Category> categoryList3 = from c in dbContext.Categories.Include(c => c.Products) select c;

            foreach (Category category in categoryList3)
            {
                Console.WriteLine(category.CategoryId + " " + category.CategoryName);
                foreach (Product product in category.Products)
                {
                    Console.WriteLine("\t" + product.ProductId + ") " + product.ProductName);
                }
            }

            var categoryList4 = from c in dbContext.Categories 
                                                 join p in dbContext.Products on c.CategoryId equals p.CategoryId
                                                 select new { c, p };

            foreach (var category in categoryList4)
            {

            }


        }

        private static void LinqToJoin()
        {
            Console.WriteLine("Linq Hoş geldiniz");

            List<Ogrenci> ogrenciler = GetOgrenciler();
            List<Bolum> bolumler = GetBolumler();
            List<Sehir> sehirler = GetSehirler();

            IEnumerable<OgrenciBolum> ogrenciBolumListesi = ogrenciler.Join(bolumler, 
                                                            o => o.BolumId, b => b.Id, 
                                                           (o, b) => new OgrenciBolum { OgrenciAdi = o.Adi, OgrenciPosta = o.Eposta, BolumAdi = b.Adi });


            IEnumerable<OgrenciBolum> ogrenciBolumListesi2 = from o in ogrenciler
                                                             join b in bolumler on o.BolumId equals b.Id
                                                             select new OgrenciBolum { OgrenciAdi = o.Adi, OgrenciPosta = o.Eposta, BolumAdi = b.Adi };

            foreach (OgrenciBolum ogrenciBolum in ogrenciBolumListesi2)
            {
                Console.WriteLine(ogrenciBolum.OgrenciAdi + " " + ogrenciBolum.OgrenciPosta + " " + ogrenciBolum.BolumAdi);
            }

            IEnumerable<OgrenciBolumSehir> ogrenciBolumListesi3 = from o in ogrenciler
                                                             join b in bolumler on o.BolumId equals b.Id
                                                             join s in sehirler on o.SehirId equals s.Id
                                                             select new OgrenciBolumSehir { OgrenciAdi = o.Adi, OgrenciPosta = o.Eposta, BolumAdi = b.Adi, OgrenciYas = o.Yas, SehirAdi = s.Adi };

            foreach (OgrenciBolumSehir ogrenciBolum in ogrenciBolumListesi3)
            {
                Console.WriteLine(ogrenciBolum.OgrenciAdi + " " + ogrenciBolum.OgrenciPosta + " " + ogrenciBolum.BolumAdi + " " + ogrenciBolum.SehirAdi);
            }


            IEnumerable<OgrenciBolumSehir> ogrenciBolumListesi4 = ogrenciler.Join(bolumler, o => o.BolumId, b => b.Id, (o, b) => new { OgrenciAdi = o.Adi, OgrenciPosta = o.Eposta, BolumAdi = b.Adi, SehirId = o.SehirId })
                                                                       .Join(sehirler, o2 => o2.SehirId, s => s.Id, (o2, s) => new { SehirAdi = s.Adi, KisiBolum = o2 })
                                                                       .Select(r => new OgrenciBolumSehir { OgrenciAdi = r.KisiBolum.OgrenciAdi, OgrenciPosta = r.KisiBolum.OgrenciPosta, SehirAdi = r.SehirAdi, BolumAdi = r.KisiBolum.BolumAdi });

            Console.WriteLine("--------------");
            foreach (OgrenciBolumSehir ogrenciBolum in ogrenciBolumListesi4)
            {
                Console.WriteLine(ogrenciBolum.OgrenciAdi + " " + ogrenciBolum.OgrenciPosta + " " + ogrenciBolum.BolumAdi + " " + ogrenciBolum.SehirAdi);
            }
        }

        public static void LinqGiris()
        {
            Console.WriteLine("Linq Hoş geldiniz");

            //Linq to Object

            int[] sayilar = new int[10] ;

            for(int i = 0 ; i < sayilar.Length ; i++)
            {
                sayilar[i] = (new Random().Next(10)) + 1; // 1-10
            }

            Console.WriteLine("----Listenin ilk hali----");
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("----Liste 4 den büyük sayılar----");

            // Linq Sorgu Şekli (Query)
            IEnumerable<int> yeniListe = (from sayi in sayilar where sayi > 4 select sayi);
            Console.WriteLine("--- Linq Query ---");
            foreach (var sayi in yeniListe)
            {
                Console.WriteLine(sayi);
            }

            // Linq Method Şekli
            //IEnumerable<int> yeniListe2 = sayilar.Where(sayi => Kontrol(sayi));
            IEnumerable<int> yeniListe2 = sayilar.Where(sayi => sayi > 4);

            Console.WriteLine("--- Linq Method ---");
            foreach (var sayi in yeniListe2)
            {
                Console.WriteLine(sayi);
            }

            // Linq Method Şekli değerlerin iki katı
            //IEnumerable<int> yeniListe2 = sayilar.Where(sayi => Kontrol(sayi));
            IEnumerable<int> yeniListe3 = sayilar.Where(sayi => sayi > 4).Select(sayi => sayi*2);

            Console.WriteLine("--- Linq Method ---");
            foreach (var sayi in yeniListe3)
            {
                Console.WriteLine(sayi);
            }

            // Linq Method Şekli değerlerin iki katı çoklu koşul kullanımı
            //IEnumerable<int> yeniListe2 = sayilar.Where(sayi => Kontrol(sayi));
            IEnumerable<int> yeniListe4 = sayilar.Where(sayi => sayi > 4 && sayi < 8).Select(sayi => sayi * 2);

            Console.WriteLine("--- Linq Method ---");
            foreach (var sayi in yeniListe4)
            {
                Console.WriteLine(sayi);
            }

        }

        public static void LinqToObjectClass()
        {
            Console.WriteLine("Linq Hoş geldiniz");

            List<Ogrenci> ogrenciler = GetOgrenciler();

            IEnumerable<Ogrenci> gmailEpostaOlanlar = ogrenciler.Where(o => o.Eposta.EndsWith("gmail.com"));

            Console.WriteLine("--- Linq Ogrenciler sınıfı eposta gmail olanlar ---");

            foreach (var ogrenci in gmailEpostaOlanlar)
            {
                Console.WriteLine(ogrenci.Id + " " + ogrenci.Adi + " " + ogrenci.Yas + " " + ogrenci.Eposta);
            }

            Console.WriteLine("--- Linq Ogrenciler sınıfı eposta gmail olanlar id,adi, yas ---");

            IEnumerable<OzelOgrenciModel> gmailEpostaOlanlar2 = gmailEpostaOlanlar.Where(go => go.Yas < 20).Select(go => new OzelOgrenciModel { OgrenciNo = go.Id, OgrenciAdi = go.Adi, Yasi = go.Yas });

            if(gmailEpostaOlanlar2.Count() > 0)
            {
                foreach (var ogrenci in gmailEpostaOlanlar2)
                {
                    Console.WriteLine(ogrenci.OgrenciNo + " " + ogrenci.OgrenciAdi + " " + ogrenci.Yasi);
                }
            }

            if (gmailEpostaOlanlar2.Any())
            {
                foreach (var ogrenci in gmailEpostaOlanlar2)
                {
                    Console.WriteLine(ogrenci.OgrenciNo + " " + ogrenci.OgrenciAdi + " " + ogrenci.Yasi);
                }
            }

            //if (gmailEpostaOlanlar.Any(om => om.Adi.Contains("a")))
            //{
            //    foreach (var ogrenci in gmailEpostaOlanlar)
            //    {
            //        Console.WriteLine(ogrenci.Id + " " + ogrenci.Adi + " " + ogrenci.Yas);
            //    }
            //}

            //OzelOgrenciModel om = new OzelOgrenciModel() { OgrenciAdi = "a" };
            //Ogrenci o = new Ogrenci() { Adi = "a" };

            //if (gmailEpostaOlanlar.Contains(o))
            //{
            //    foreach (var ogrenci in gmailEpostaOlanlar)
            //    {
            //        Console.WriteLine(ogrenci.Id + " " + ogrenci.Adi + " " + ogrenci.Yas);
            //    }
            //}


        }

        private static void LinqToMath()
        {
            Console.WriteLine("Linq Hoş geldiniz");

            int[] sayilar = new int[10];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = (new Random().Next(99,1000)) + 1; // 1-10
            }


            Console.WriteLine("----Listenin ilk hali----");
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            int sayilarinToplami = sayilar.Sum();
            int enbuyuksayi = sayilar.Max();
            int enkucusayi = sayilar.Min();
            double ortalama = sayilar.Average();

            Console.WriteLine($"Toplam:{sayilarinToplami}, Max:{enbuyuksayi}, Min:{enkucusayi}, Avg:{ortalama}");

            int ogrenciYaslarininToplami = GetOgrenciler().Where(o => o.Eposta.EndsWith("gmail.com") || o.Eposta.EndsWith("bilgeadam.com"))
                                                         .Select(o => o.Yas)
                                                         .Sum();
            int yasToplam = GetOgrenciler().Where(o => o.Eposta.EndsWith("gmail.com") || o.Eposta.EndsWith("bilgeadam.com")).Sum(o => o.Yas);

            Console.WriteLine("Yas Toplamı : " + ogrenciYaslarininToplami + " Yaş Toplam :" + yasToplam);


            Ogrenci? yasMaxBy = GetOgrenciler().MaxBy(o => o.Yas);
            Ogrenci? yasMinBy = GetOgrenciler().MinBy(o => o.Yas);
        }

        public static bool Kontrol(int sayi)
        {
            return sayi > 4;
        }

        private static List<Ogrenci> GetOgrenciler()
        {
            return new List<Ogrenci>()
            {
                new Ogrenci(){ Id = 1, Adi = "Yusuf", DogumTarihi = new DateOnly(1992,1,1), BolumId = 1, SehirId = 4,  Eposta = "yusuf@gmail.com"},
                new Ogrenci(){ Id = 2, Adi = "Hakan", DogumTarihi = new DateOnly(1992,1,1), BolumId = 1, SehirId = 3,   Eposta = "hakan@gmail.com"},
                new Ogrenci(){ Id = 3, Adi = "Burak", DogumTarihi = new DateOnly(1991,1,1), BolumId = 2, SehirId = 5,   Eposta = "burak@hotmail.com"},
                new Ogrenci(){ Id = 4, Adi = "Hivda", DogumTarihi = new DateOnly(1998,1,1), BolumId = 2, SehirId = 3,   Eposta = "hivda@yahoo.com"},
                new Ogrenci(){ Id = 5, Adi = "Sümeyye", DogumTarihi = new DateOnly(2010,1,1), BolumId = 3,SehirId = 4,    Eposta = "sumeyye@outlook.com"},
                new Ogrenci(){ Id = 6, Adi = "Yasin", DogumTarihi = new DateOnly(1998,1,1), BolumId = 1,SehirId = 5,    Eposta = "yasin@fenerbahce.com"},
                new Ogrenci(){ Id = 7, Adi = "Mehmet", DogumTarihi = new DateOnly(1998,1,1), BolumId = 4, SehirId = 4,   Eposta = "mehmet@galatasaray.com"},
                new Ogrenci(){ Id = 8, Adi = "Ayşenur", DogumTarihi = new DateOnly(2000,1,1), BolumId = 3,SehirId = 1,    Eposta = "aysenur@msn.com"},
                new Ogrenci(){ Id = 9, Adi = "Eyşan", DogumTarihi = new DateOnly(1997,1,1), BolumId = 1, SehirId = 5,   Eposta = "eysan@bilgeadam.com"},
                new Ogrenci(){ Id = 10, Adi = "Kerem", DogumTarihi = new DateOnly(1999,1,1), BolumId = 3,SehirId = 1,    Eposta = "kerem@uefakupasi.com"},
                new Ogrenci(){ Id = 11, Adi = "Bengü", DogumTarihi = new DateOnly(1995,1,1), BolumId = 2, SehirId = 4,   Eposta = "bengu@bilgeadam.com"},
                new Ogrenci(){ Id = 12, Adi = "Ilgın", DogumTarihi = new DateOnly(1997,1,1), BolumId = 3, SehirId = 1,   Eposta = "ilgin@deniz.com"},
                new Ogrenci(){ Id = 13, Adi = "Furkan", DogumTarihi = new DateOnly(1998,1,1), BolumId = 4, SehirId = 1,   Eposta = "furkan@gmail.com"},
                new Ogrenci(){ Id = 14, Adi = "Göksel", DogumTarihi = new DateOnly(2019,1,1), BolumId = 1, SehirId = 3,   Eposta = "goksel@mynet.com"},
            };
        }

        private static List<Bolum> GetBolumler()
        {
            return new List<Bolum>()
            {
                new Bolum(){ Id = 1, Adi = "Matematik"},
                new Bolum(){ Id = 2, Adi = "Fizik"},
                new Bolum(){ Id = 3, Adi = "Kimya"},
                new Bolum(){ Id = 4, Adi = "Bilgisayar"}
            };
        }

        private static List<Sehir> GetSehirler()
        {
            return new List<Sehir>()
            {
                new Sehir(){ Id = 1, Adi = "Ankara"},
                new Sehir(){ Id = 2, Adi = "İstanbul"},
                new Sehir(){ Id = 3, Adi = "İzmir"},
                new Sehir(){ Id = 4, Adi = "Muğla"},
                new Sehir(){ Id = 5, Adi = "Adana"},
            };
        }

        public static void EfGiris()
        {
            Console.WriteLine("EF Core Hoş geldiniz");

            //Sql provider
            //Sql Connection String
            //Sql Connection Open
            //Sql Command 
            //Sql Reader
            //Sql Connection Close

            NorthwindDbContext db = new NorthwindDbContext();

            //Category List (Select)

            DbSet<Category> categoryEntity = db.Categories;
            IQueryable<Category> categories = categoryEntity.Where(c => c.CategoryId > 3);
            categories = categories.Where(c => c.CategoryId < 18);

            foreach (Category category in categories)
            {
                Console.WriteLine(category.CategoryId + ")\t" + category.CategoryName); // 1) Kategori Ad
            }

            Console.WriteLine($"----------{categories.Count()}-----------");

            List<Category> categoriesList = categories.ToList();

            foreach (Category category in categoriesList)
            {
                Console.WriteLine(category.CategoryId + ")\t" + category.CategoryName); // 1) Kategori Ad
            }

            Console.WriteLine($"----------{categoriesList.Count()}-----------");

            IEnumerable<Category> categoryFilterToRam = categoriesList.Where(c => c.CategoryName.StartsWith('Y'));

            foreach (Category category in categoryFilterToRam)
            {
                Console.WriteLine(category.CategoryId + ")\t" + category.CategoryName); // 1) Kategori Ad
            }

            Console.WriteLine($"----------{categoryFilterToRam.Count()}-----------");


            //Category Add (Insert)

            Category newCategory = new Category();
            newCategory.CategoryName = "Console Ek";
            newCategory.Description = "Açıklama";

            db.Categories.Add(newCategory);

            db.SaveChanges();

            categories = categoryEntity.Where(c => c.CategoryName.StartsWith("Con"));

            foreach (Category category in categories)
            {
                Console.WriteLine(category.CategoryId + ")\t" + category.CategoryName); // 1) Kategori Ad
            }

            Console.WriteLine($"----------{categories.Count()}-----------");
        }
    }

    public class OzelOgrenciModel
    {
        public int OgrenciNo { get; set; }
        public string OgrenciAdi { get; set; }
        public int Yasi { get; set; }
    }

    public class OgrenciBolum
    {
        public string OgrenciAdi { get; set; }
        public string OgrenciPosta { get; set; }
        public string BolumAdi { get; set; }
    }

    public class OgrenciBolumSehir
    {
        public string OgrenciAdi { get; set; }
        public string OgrenciPosta { get; set; }
        public int OgrenciYas { get; set; }
        public string BolumAdi { get; set; }
        public string SehirAdi { get; set; }
    }

    public class Bolum
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }

    public class Sehir
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }

    public class Ogrenci
    {
        private int _yas;
        private DateOnly _dogumTarihi;

        public int Id { get; set; }
        public string Adi { get; set; }

        public string Eposta { get; set; }

        public int BolumId { get; set; }

        public int SehirId { get; set; }

        public DateOnly DogumTarihi
        {
            get
            {
                return _dogumTarihi;
            }

            set
            {
                _dogumTarihi = value;
                _yas = (DateTime.Now.Year - value.Year);
            }
        }

        public int Yas => _yas;
    }
}
