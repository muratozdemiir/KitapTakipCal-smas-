using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KitapTakip.Models
{
    public class KitapTuru
    {
        [Key] // burada Id mmi primary key olarak belirledim
        public int Id { get; set; }

        [Required] // burada ise Ad alanımı not null olarak belirledim
        [MaxLength(25)]
        [DisplayName("Kitap Türü Adı")]
        public string Ad { get; set; }
    }
}
