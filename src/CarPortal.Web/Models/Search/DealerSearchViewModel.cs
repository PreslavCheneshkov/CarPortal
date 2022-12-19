using System.ComponentModel.DataAnnotations;

namespace CarPortal.Web.Models.Search
{
    public class DealerSearchViewModel
    {
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Name { get; set; } = null!;

        public List<string> Dealers { get; set; }
    }
}
