using System.ComponentModel.DataAnnotations;

namespace EmptyBlazorApp1.Models
{
    public class Clovek
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string Jmeno { get; set; }

        [MaxLength(10)]
        public string Prijmeni { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DatumNarozeni { get; set; }

        [MaxLength(12)]
        public string Telefon { get; set; }
    }
}
