namespace Galeri.Entities
{
    public class Marka : BaseEntity
    {
        public string Name { get; set; }
        public string LogoAd {get; set;}
        public IEnumerable<Mode> Modeller { get; set;}
    }
}
