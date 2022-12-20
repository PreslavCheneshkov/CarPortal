using System.ComponentModel.DataAnnotations;
using static CarPortal.Data.Constants.NewsArticleConstants;

namespace CarPortal.Web.Models.News
{
    public class NewsArticleInputViewModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength)]
        public string Content { get; set; }
    }
}
