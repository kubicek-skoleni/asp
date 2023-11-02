using System.ComponentModel.DataAnnotations;

namespace TelefonniSeznam.Models
{
    public class Clovek
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Jmeno { get; set; }

        [MaxLength(100)]
        public string Prijmeni { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DatumNarozeni { get; set; }

        [MaxLength(50)]
        public string Telefon { get; set; }
    }
}
