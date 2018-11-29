namespace Appie5.Models
{
    public class Product
    {
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public string Kleur { get; set; }
        public Categorie Categorie { get; set; }
    }
}