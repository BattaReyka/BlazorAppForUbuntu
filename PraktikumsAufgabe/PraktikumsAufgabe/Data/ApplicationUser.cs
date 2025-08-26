using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Hosting;
using static PraktikumsAufgabe.Components.Account.Pages.Register;

namespace PraktikumsAufgabe.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Vorname")]
        public string Vorname { get; set; } = "";

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nachname")]
        public string Nachname { get; set; } = "";

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Geschlecht")]
        public string Geschlecht { get; set; } = "";

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Geburtsdatum")]
        public DateTime Geburtsdatum { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Strasse")]
        public string Strasse { get; set; } = "";

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "PLZ")]
        public string PLZ { get; set; } = "";

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Ort")]
        public string Ort { get; set; } = "";

        public string? CountryId { get; set; }
        public Countries? Country { get; set; }
        public string Telefon { get; set; } = "";

        [DataType(DataType.Text)]
        [Display(Name = "Telefon 2")]
        public string telefon2 { get; set; } = "";

        [DataType(DataType.Text)]
        [Display(Name = "Geburtsort")]
        public string Geburtsort { get; set; } = "";

        [DataType(DataType.Text)]
        [Display(Name = "Bemerkung")]
        public string Bemerkung { get; set; } = "";

        public bool Aktiv { get; set; }
    }

}
