using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.DTOs.Search
{
    public class NewsArticleSearchResultDTO
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int ArticleId { get; set; }
    }
}
