using CarPortal.Web.Models.News;
using CarPortal.Web.Models.Offer;

namespace CarPortal.Web.Models.Home
{
    public class HomePageViewModel
    {
        public List<OfferInCollectionViewModel> RecentOffers { get; set; } = new List<OfferInCollectionViewModel>();

        public List<NewsArticleInCollectionViewModel> RecentNewsArticles { get; set; } = new List<NewsArticleInCollectionViewModel>();
    }
}
