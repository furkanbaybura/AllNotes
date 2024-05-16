namespace HataYonetimi
{
    internal class Program
    {
        public static int i = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Hata Yönetimi");

            //HataYonetimi1();
            //HataYonetimi1ek();
            //HataYonetimi2();
            //HataYonetimi3();

            //int deger = HataYonetimi4();

            //Console.WriteLine("------");

            //Console.WriteLine(deger);

            //try
            //{
            //    HataYonetimi5();
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    HataYonetimi6();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            HataYonetimi7();

            Console.ReadKey();
        }

        static void HataYonetimi7()
        {
            A:
            Console.Write("Sayı Giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());  
            


            if(sayi < 100)
                goto A;

            try
            {
                int sonuc = sayi / 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }

        private static void HataYonetimi6()
        {
            Console.Write("Kullanıcı Adınız : ");
            string name = Console.ReadLine();

            Console.Write("Şifreniz: ");
            string password = Console.ReadLine();

            Console.Write("Şifreniz Tekrar: ");
            string againpassword = Console.ReadLine();


            CheckUserName(name);

            CheckPassWord(password, againpassword);

            //try
            //{
            //    CheckUserName(name);

            //    CheckPassWord(password, againpassword);

            //    //Akış gereği bir hata oluşutu.
            //    //throw new Exception("Başka bir hata durumu");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("İç hata" + ex.Message);
            //    throw new Exception("Başka bir hata durumu", ex);
            //}


        }

        private static void CheckPassWord(string? password, string? againpassword)
        {

            if (!(password.Length >= 8))
                throw new Exception("Girdiğiniz şifre uygun uzunlukta değildir.");

            if (password != againpassword)
                throw new Exception("Girdiğiniz şifreler uyuşmamaktadır.");
        }

        private static void CheckUserName(string? name)
        {
            if (!(name.Length >= 5 && name.Length <= 15))
                throw new Exception("Kullanıcı adınızı belirlenen limitler dışındadır.");
        }

        private static void HataYonetimi5()
        {
            throw new NotImplementedException();
        }

        static void HataYonetimi1()
        {
            int sayi = 10 / 1; // Bu hata Derleme Zamanı (Compiling Time) hatası

            int sayi1 = 10;
            int sayi2 = 0;
            
            int sonuc = sayi1 / sayi2; // Burada oluşacak hata Çalışma Zamanı (Runtime) hatası

            byte deger = 125;

            if(deger >= 0)
            {
                Console.WriteLine("Değer 0'a eşit veya büyüktür.");
            }
            else
            {
                Console.WriteLine("Değer 0 dan küçüktür.");
            }

            if (2>1)
            {
                Console.WriteLine("Değer 0'a eşit veya büyüktür.");
            }
            else
            {
                Console.WriteLine("Değer 0 dan küçüktür.");
            }
        }

        static void HataYonetimi1ek()
        {
            A:
            Console.Write("Sayı 1:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 2:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Merhaba program {0}. kez çalıştı.", i);
            int sonuc = sayi1 / sayi2; // Burada oluşacak hata Çalışma Zamanı (Runtime) hatası

            if (sonuc < 10)
            {
                i++;

                goto A;
            }
        }

        static void HataYonetimi2()
        {
            B:
            Console.Write("Sayı 1:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 2:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                //Hata olması muhtemel kod bloğu

                int sonuc = sayi1 / sayi2; // Burada oluşacak hata Çalışma Zamanı (Runtime) hatası
                Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, sonuc); //Hivda, Hakan, Sümeyye, Bengü Çikolatalı gofret**
            }
            catch (Exception ex) // Genel Hata yakalama sınıfı Exception
            {
                //Hata olduğunda çalışacak kod bloğu
                Console.WriteLine(ex.Message);
            }

            goto B;


        }

        static void HataYonetimi3()
        {
            B:
            try
            {
                Console.Write("Sayı 1:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sayı 2:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                //Hata olması muhtemel kod bloğu

                int sonuc = sayi1 / sayi2; // Burada oluşacak hata Çalışma Zamanı (Runtime) hatası
                Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, sonuc); //Hivda, Hakan, Sümeyye, Bengü Çikolatalı gofret**
            }
            catch (DivideByZeroException ex)
            {
                //Hata olduğunda çalışacak kod bloğu
                Console.WriteLine("DivideByZero Exc:" + ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Format Exc:" + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow Exc:" + ex.Message);
            }
            catch (Exception ex)
            {
                //Hata olduğunda çalışacak kod bloğu
                Console.WriteLine("Exception :" + ex.Message);
            }

            goto B;


        }

        static int HataYonetimi4()
        {
            int sonuc;

            string mesaj = "";

            try
            {
                Console.Write("Sayı 1:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sayı 2:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                //Hata olması muhtemel kod bloğu

                sonuc = sayi1 / sayi2; // Burada oluşacak hata Çalışma Zamanı (Runtime) hatası
                Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, sonuc); //Hivda, Hakan, Sümeyye, Bengü Çikolatalı gofret**

                return sonuc;
            }
            catch (DivideByZeroException ex)
            {
                //Hata olduğunda çalışacak kod bloğu
                //Console.WriteLine("DivideByZero Exc:" + ex.Message);
                mesaj = ex.Message;
                return 0;
            }
            catch (FormatException ex)
            {
                //Console.WriteLine("Format Exc:" + ex.Message);
                mesaj = ex.Message;
                return 0;
            }
            catch (OverflowException ex)
            {
                //Console.WriteLine("Overflow Exc:" + ex.Message);
                mesaj = ex.Message;
                return 0;
            }
            catch (Exception ex)
            {
                //Hata olduğunda çalışacak kod bloğu
                //Console.WriteLine("Exception :" + ex.Message);
                mesaj = ex.Message;
                return 0;
            }
            finally
            {
                Console.WriteLine("Son blok log yazdım bir yere haber verdim. Ancak kimse beni duymuyor. Ex:" + mesaj);
            }
        }
    }
}
