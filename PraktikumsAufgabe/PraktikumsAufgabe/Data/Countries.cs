using System.ComponentModel.DataAnnotations;

namespace PraktikumsAufgabe.Data
{
    public class Countries
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
