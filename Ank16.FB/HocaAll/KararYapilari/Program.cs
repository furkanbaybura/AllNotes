using System.Text;

namespace KararYapilari
{
    internal class Program
    {
        static int ornekNo; // global variable 
        static DateTime dt = DateTime.Now;
        static int i = 1, j = 1;
        static void Main(string[] args)
        {
            //Console.InputEncoding = Encoding.UTF8; // İngilizce dil olarak çalışan bir pc de Türkçe karakter veri girişi almak için
            //Console.OutputEncoding = Encoding.UTF8;// İngilizce dil olarak çalışan bir pc de Türkçe karatker veri çıkışı vermek için 

            //ornekNo = 4;
            //KararYapilariIf();

            //Console.ReadKey();

            ToDay();
        }

        static void KararYapilariIf()
        {
            #region İf yapısı notları
            /*
             * if(koşul)
             * {
             *      koşul sağlandığında yani doğru ise
             * }
             * else
             * {
             *      koşul sağlanmadığında yani yanlış ise, Bu alan isteğe bağlı
             * }
             * 
             * koşul'un sonucu mantıksal değer döndüren bir yapı içermelidir. 
             * koşul da ya bool tipinde bir değişken kullanılması
             * ya da sonucu bool olacak bir mantıksal operatörler ile karşılaştırma yapılır.
             * 
             * birden fazla koşulu &&(And), ||(Or) Kısa devre ya da &(And), |(or) tüm kontrol sağlayan yardımcı araçlar kullanılır.
             * 
             * 
             * if(koşul_1) -> Farklı bir kontrol
             * {
             * 
             * }
             * 
             * Bu alanda kod çalışması yapılabilir.
             * 
             * if(koşul_1) -> Farklı bir kontrol
             * {
             * 
             * }
             * 
             * string gun = "Cuma";
             * if(gun == "Pazartesi")
             * {
             *      
             * }
             * else
             * {
             *      if(gun == "Salı")
             *      {
             *          
             *      }
             *      else
             *      {
             *          if(gun == "Çarşamba")
             *          {
             *              
             *          }
             *          else
             *          {
             *              //...
             *          }
             *      }
             * }
             * 
             * 
             * if(gun == "Pazaresi")
             * {
             *  
             * }
             * else if(gun == "Salı")
             * {}
             * else if(gun == "Çarşamba")
             * {}
             * else if(gun == "Perşembe")
             * {}
             * else if(gun == "Cuma")
             * {}
             * else
             * {}
             * 
             * if(koşul)
             *      Console.WrirteLine("Mesaj");
             * else
             *      Console.WrirteLine("Yanlış Mesaj");
             */
            #endregion

            if (ornekNo == 1)
            {
                //Genel if-else, if-else if-else yapısı örnekleri

                #region Örnek 1
                Console.Write("Sayı 1 = ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sayı 2 = ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                // Sayılarında bir birinden faklı olması kontrolü
                if (sayi1 != sayi2)
                {
                    Console.WriteLine("Girilen iki sayı da birbirinden farklıdır.");
                }

                Ayrac();

                // Sayıların birin diğerinden büyük olma durumu kontrolü

                if (sayi1 > sayi2)
                    Console.WriteLine("Sayı 1, Sayı 2 den büyüktür.");
                else
                    Console.WriteLine("Sayı 2, Sayı 1 den büyüktür.");

                Ayrac();

                if (sayi1 != sayi2)
                {
                    //Console.WriteLine("Girilen iki sayı da birbirinden farklıdır.");

                    if (sayi1 > sayi2)
                        Console.WriteLine("Sayı 1, Sayı 2 den büyüktür.");
                    else
                        Console.WriteLine("Sayı 2, Sayı 1 den büyüktür.");
                }
                else
                {
                    Console.WriteLine("Girilen iki sayı da birbirine eşittir.");
                }

                Ayrac();

                if (sayi1 < sayi2)
                    Console.WriteLine("Sayı 2 büyüktür Sayı 1");
                else if (sayi1 > sayi2)
                    Console.WriteLine("Sayı 1 büyüktür Sayı 2");
                else
                    Console.WriteLine("Sayı 1 ile Sayı 2 eşittir");

                Ayrac();

                if (sayi1 <= sayi2)
                    Console.WriteLine("Sayı 1 Sayı2 den küçük veya eşittir.");
                else
                    Console.WriteLine("Sayı 1 Sayı2 den büyüktür.");

                Ayrac();

                string mesaj;
                bool kontrol = false;


                if (sayi1 <= sayi2)
                {
                    mesaj = "Sayı 1 Sayı 2 den küçük veya eşittir.";
                    kontrol = true;
                }
                else
                {
                    mesaj = "Sayı 1 Sayı 2 den büyüktür.";
                    //kontrol = false; 
                }

                if (kontrol)
                    Console.WriteLine(mesaj); 
                #endregion

            }
            else if (ornekNo == 2)
            {
                // Ternary Operatörü ? :, ??
                #region Örnek 2

                Console.Write("Sayı 1 = ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sayı 2 = ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                bool kontrol = false;
                string mesaj = "";
                int sonuc = 0;

                // koşulu ? (return) doğru ise : (return )yanlış ise;


                mesaj = (sayi1 >= sayi2) ? "Sayı 1 Sayı 2 den büyük veya eşittir." : "Sayı 2 Sayı 1 den büyüktür.";

                Console.WriteLine(mesaj);

                mesaj = (sayi1 >= sayi2) ? (sayi1+sayi2).ToString() : Convert.ToString(sayi2 - sayi1);

                Console.WriteLine(mesaj);

                kontrol = (sayi1 >= sayi2) ? true : false;

                Console.WriteLine(kontrol);

                // Ternary Operatörü iç içe kullanımı

                mesaj = (sayi1 >= sayi2) ? 
                            ((sayi1 + sayi2) % 2 == 0) ? "Toplamı Çift" : "Toplamı Tek" :
                                    ((sayi2 - sayi1) % 2 == 0) ? "Farkı Çift" : "Farkı Tek";

                Console.WriteLine(mesaj);


                int d;

                //d = d + 1; // Use of unassigned local variable 'd'

                //Console.WriteLine((d == null) );

                int? a = Servis();
                
                //...

                int b = (a != null) ? (int)a : -1;
                int c = Servis() ?? -1;



                #endregion
            }
            else if(ornekNo == 3)
            {
                //if - else if eski zaman switch case yapısı

                //DateTime dt =  DateTime.Now;

                if(ToDay() == "Sunday")
                    Console.WriteLine("Bugün Pazar");
                else if(ToDay() == "Monday")
                    Console.WriteLine("Bugün Pazartesi");
                else if (ToDay() == "Tuesday")
                    Console.WriteLine("Bugün Salı");
                else if (ToDay() == "Wednesday")
                    Console.WriteLine("Bugün Çarşamba");
                else if (ToDay() == "Thursday")
                    Console.WriteLine("Bugün Perşembe");
                else if (ToDay() == "Friday")
                    Console.WriteLine("Bugün Cuma");
                else if (ToDay() == "Saturday")
                    Console.WriteLine("Bugün Cumartesi");
                else
                    Console.WriteLine("Bugün Mars günü :)");

                Ayrac();

                Console.WriteLine("Performans düzeltmesi");

                string bugun = ToDay();

                if (bugun == "Sunday" & Kontrol())
                    Console.WriteLine("Bugün Pazar");
                else if (bugun == "Monday" & Kontrol())
                    Console.WriteLine("Bugün Pazartesi");
                else if (bugun == "Tuesday" & Kontrol())
                    Console.WriteLine("Bugün Salı");
                else if (bugun == "Wednesday" & Kontrol())
                    Console.WriteLine("Bugün Çarşamba");
                else if (bugun == "Thursday" & Kontrol())
                    Console.WriteLine("Bugün Perşembe");
                else if (bugun == "Friday" & Kontrol())
                    Console.WriteLine("Bugün Cuma");
                else if (bugun == "Saturday" & Kontrol())
                    Console.WriteLine("Bugün Cumartesi");
                else
                    Console.WriteLine("Bugün Mars günü :)");

                Ayrac();

                switch (ToDayInt()) {
                    case 0:
                        Console.WriteLine("Bugün Pazar");
                        break;
                    case 1:
                        Console.WriteLine("Bugün Pazartesi");
                        break;
                    case 2:
                        Console.WriteLine("Bugün Salı");
                        break;
                    case 3:
                        Console.WriteLine("Bugün Çarşamba");
                        break;
                    case 4:
                        Console.WriteLine("Bugün Perşembe");
                        break;
                    case 5:
                        Console.WriteLine("Bugün Cuma");
                        break;
                    case 6:
                        Console.WriteLine("Bugün Cumartesi");
                        break;
                    default:
                        Console.WriteLine("Bugün Mars Günü :)");
                        break;

                }

                Ayrac();

                switch (DateTime.Now.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                    case DayOfWeek.Tuesday:
                    case DayOfWeek.Wednesday:
                    case DayOfWeek.Thursday:
                    case DayOfWeek.Friday:
                        Console.WriteLine("Bugün Hafta içi");
                        break;
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                        Console.WriteLine("Bugün Hafta sonu");
                        break;
                    default:
                        Console.WriteLine("Bugün Mars Günü :)");
                        break;

                }

                Ayrac();

                Console.Write("Lütfen bir ders adı yazınız (C#,Php,Java,C++,Python): ");

                string dersAdi = Console.ReadLine();

                switch (dersAdi)
                {
                    case "c#":
                    case "C#":
                        Console.WriteLine("C# dersine hoş geldiniz.");
                        break;
                    case "php":
                    case "PHP":
                        Console.WriteLine("PHP dersine hoş geldiniz.");
                        break;
                    case "Java":
                        Console.WriteLine("Java dersine hoş geldiniz.");
                        break;
                    case "Python":
                        Console.WriteLine("Python dersine hoş geldiniz.");
                        break;
                    case "C++":
                        Console.WriteLine("C++ dersine hoş geldiniz.");
                        break;
                    default:
                        Console.WriteLine("Listeye uygun bir ders seçmediniz.");
                        break;
                }

                Ayrac();


                Console.Write("Lütfen 1 ile 10 arası bir sayı giriniz: ");

                int sayi = Convert.ToInt32(Console.ReadLine());
                
                // C# 9.0 da gelen kullanım
                switch (sayi)
                {
                    case <= 0: // (sayi <= 0)
                        Console.WriteLine("Girdiğiniz değer 1 dan küçüktür. Lütfen 1 ile 10 arası giriniz");
                        break;
                    case > 0 and <= 10: // (0 < sayi and sayi <= 10) 
                        Console.WriteLine("Teşekkürler girdiniz değer : " + sayi);
                        break;
                    default:
                        Console.WriteLine("Girdiğiniz değer 10 dan büyüktür. Lütfen 1 ile 10 arası giriniz");
                        break;

                }

                // C# 7 de gelen kullanım
                switch (sayi)
                {
                    case int n when (n <= 0): // case <= 0: // (sayi <= 0)
                        Console.WriteLine("Girdiğiniz değer 1 dan küçüktür. Lütfen 1 ile 10 arası giriniz");
                        break;
                    case int n when (0 < n && n <= 10): // case > 0 and <= 10: // (0 < sayi and sayi <= 10) 
                        Console.WriteLine("Teşekkürler girdiniz değer : " + sayi);
                        break;
                    default:
                        Console.WriteLine("Girdiğiniz değer 10 dan büyüktür. Lütfen 1 ile 10 arası giriniz");
                        break;

                }

            }

            else if(ornekNo == 4)
            {
                //Random Sınıfı
                // Random(5) => 0 başlıyor 5'e kadar ama 5 dahil değil 0,1,2,3,4

                Random random = new Random();

                Console.WriteLine("Random Int: " + random.Next()); // minDeğer : 0, maxDeğer : int.MaxValue ancak maxDeğer dahil değil
                Console.WriteLine("Random Int: " + random.Next(10)); // minDeğer : 0, maxDeğer : 10 ancak maxDeğer dahil değil
                Console.WriteLine("Random Int: " + random.Next(2,10)); // minDeğer : 2(negatif değer alabilir), maxDeğer : 10 ancak maxDeğer dahil değil
                Console.WriteLine("Random Double: " + random.NextDouble()); // minDeğer : 0.0, maxDeğer : 1.0 ancak maxDeğer dahil değil (Basamak sayısı double sınıraları içinde kalır)
                Console.WriteLine("Random Float(Single): " + random.NextSingle()); // minDeğer : 0.0, maxDeğer : 1.0 ancak maxDeğer dahil değil (Basamak sayısı float sınıraları içinde kalır)

                Ayrac();

                Console.WriteLine("Random [1-10] arası int : " + random.Next(10) + 1);

                Ayrac();

                Console.WriteLine("Random [7-38] arası int : " + (random.Next(32) + 7 )); //0+7 => 7, 31+7 => 38 Bengü

                Console.WriteLine("Random [7-38] arası int : " + (random.Next(7,38) + 1)); //7+1 => 8, 37+1 => 38 Burak
                Console.WriteLine("Random [7-38] arası int : " + (random.Next(6,38) + 1)); //6+1 => 7, 37+1 => 38 Burak Düzeltme yaptık başlangıç değeri 6

                Console.WriteLine("Random [7-38] arası int : " + random.Next(7, 39)); //7 => 7, 38 Sümeyye 
                Ayrac();

                Console.WriteLine("Random [7-38] arası int : " + random.Next(-10, 1));

                Ayrac();
            }

        }

        private static bool Kontrol()
        {
            
            Console.WriteLine("Buraya geldik sayac : " + i);
            i++;
            return true;
        }

        //private static int GunSayi()
        //{
        //    Console.WriteLine("Buraya geldik sayac : " + j);
        //    j++;
        //    return 5;
        //}

        static void Ayrac()
        {
            int karaktersayi = 15;
            string ayrac = new String('-', karaktersayi);// birinci parametre tekrar edilecek karakteri char tipinde, ikinic parametre tekrar miktarnın int tipinde

            Console.WriteLine(ayrac);
        }

        static int? Servis()
        {
            if (1 > 5)
                return 3;

            return null;
        }

        static string ToDay()
        {
            Console.WriteLine(dt.ToString());
            return dt.DayOfWeek.ToString();
        }

        static int ToDayInt()
        {
            Console.WriteLine(dt.ToString());
            return (int)dt.DayOfWeek;
        }
    }
}
