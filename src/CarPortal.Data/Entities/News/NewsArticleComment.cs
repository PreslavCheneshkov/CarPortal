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
    public class NewsArticleComment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NewsArticleCommentMaxLength, MinimumLength = NewsArticleCommentMinLength, ErrorMessage = $"Comment should be between 2 and 200 characters long.")]
        public string Content { get; set; }

        [Required]
        [ForeignKey(nameof(CarPortalProfile))]
        public string CommenterId { get; set; }

        public CarPortalProfile Commenter { get; set; }

        [Required]
        [ForeignKey(nameof(NewsArticle))]
        public int NewsArticleId { get; set; }

        public NewsArticle NewsArticle { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
