using CarPortal.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarPortal.Data.Constants.NewsArticleConstants;

namespace CarPortal.Data.Entities.News
{
    public class NewsArticle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength)]
        public string Content { get; set; }

        [Required]
        [ForeignKey(nameof(CarPortalProfile))]
        public string AuthorId { get; set; }

        public CarPortalProfile Author { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public IEnumerable<NewsArticleComment> Comments { get; set; } = new List<NewsArticleComment>();
    }
}
