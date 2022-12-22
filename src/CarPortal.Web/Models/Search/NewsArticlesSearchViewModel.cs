using System.ComponentModel.DataAnnotations;

namespace CarPortal.Web.Models.Search
{
    public class NewsArticlesSearchViewModel
    {
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Name { get; set; } = null!;

        public List<NewsArticleSearchResultViewModel> Articles { get; set; } = new List<NewsArticleSearchResultViewModel>();
    }
}
