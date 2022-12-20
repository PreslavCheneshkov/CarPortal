using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.DTOs.News
{
    public class NewsArticleInCollectionDTO
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string CreatedOn { get; set; }

        public string Content { get; set; }

        public int Id { get; set; }
    }
}
