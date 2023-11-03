using System.ComponentModel.DataAnnotations;

namespace EmptyBlazorApp1.Models
{
    public class Clovek
    {
        public int Id { get; set; }

        [MaxLength(10)]
        [Required]
        public string Jmeno { get; set; }

        [MaxLength(10)]
        [Required]
        public string Prijmeni { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DatumNarozeni { get; set; }

        [MaxLength(12)]
        [Required]
        public string Telefon { get; set; }

        public Adresa? Bydliste { get; set; }

        public List<Dokument>? Dokumenty { get; set;} = new List<Dokument>();
    }
}
