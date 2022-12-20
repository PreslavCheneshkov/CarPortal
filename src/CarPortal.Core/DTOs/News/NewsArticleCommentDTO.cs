using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.DTOs.News
{
    public class NewsArticleCommentDTO
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }

        public string CreatedOn { get; set; }
    }
}
