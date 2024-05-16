namespace EfCore.CodeFirst.ExampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
             - Bu projeyi database server ile bağlayınız
                    --Tools,SqlServer ve Core paketlerini yükleyiniz
            
            -DbContext oluşturunuz
                --DbContext sınıfından miras alıyoruz
                --OnConfiguring methodonu override ediyoruz
                --Connection string'imizi Server Explorer'dan alıyoruz !! Database adını değiştirmeyi unutmayınız...!!
            
            -Customer.cs sınıfını oluşturunuz
                --Propertylerini oluştunurunuz 
                -- Id olmalı
                --Proplar yazılan sırayla oluşur
                --Context sınıfında Customer sınıfını Dbset ile tabloyu oluşturuyoruz 
                    --public DbSet<Customer> Customers { get; set; }

            -Student, Lesson, Teacher, StudentLesson sınıflarından veritabanı tasarımı yapınız.   
            */
        }
    }
}
