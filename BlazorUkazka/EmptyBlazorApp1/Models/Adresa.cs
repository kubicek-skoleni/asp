using System.ComponentModel.DataAnnotations;

namespace EmptyBlazorApp1.Models
{
    public class Adresa
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Mesto { get; set; }

        [MaxLength(200)]
        public string Ulice { get; set; }

        public override string ToString()
        {
            return $"{Mesto} {Ulice}";
        }
    }
}
