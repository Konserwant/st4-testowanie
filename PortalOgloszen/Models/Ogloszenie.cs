using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalOgloszen.Models
{
    public class Ogloszenie
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Tytuł ogłoszenia")]
        [MaxLength(50, ErrorMessage = "Maksymalna dlugosc tytułu to 50 znakow.")]
        [Required(ErrorMessage = "Pole wymagane")]
        public string? Title { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [MaxLength(500, ErrorMessage = "Maksymalna dlugosc opisu to 500 znakow.")]
        [DisplayName("Opis")]
        public string? Description { get; set; }

        [Column(TypeName = "nvarchar(400)")]
        [DisplayName("Zdjecie")]
        public string? ImageLink { get; set; }

        [DisplayName("Cena")]
        [Required(ErrorMessage = "Pole wymagane")]
        public int Price { get; set; }

        [DisplayName("Telefon")]
        [Required(ErrorMessage = "Pole wymagane")]
        [DataType(DataType.PhoneNumber)]
        [MinLength(9, ErrorMessage ="Podaj poprawny numer telefonu")]
        public string Phone { get; set; }

        [DisplayName("Data publikacji")]
        [Required(ErrorMessage = "Pole wymagane")]
        public DateTime PublishDate { get; set; }


    }
}
