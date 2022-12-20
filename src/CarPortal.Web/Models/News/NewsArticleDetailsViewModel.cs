namespace CarPortal.Web.Models.News
{
    public class NewsArticleDetailsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string CreatedOn { get; set; }

        public List<NewsArticleCommentViewModel> Comments { get; set; } = new List<NewsArticleCommentViewModel>();

        public NewCommentInputModel NewComment { get; set; }
    }
}
