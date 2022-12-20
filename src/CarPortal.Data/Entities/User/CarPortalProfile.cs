using CarPortal.Data.Entities.News;
using CarPortal.Data.Entities.Offer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.Entities.User
{
    public class CarPortalProfile
    {
        public CarPortalProfile()
        {
            this.Id = Guid.NewGuid().ToString();
            CreatedDate = DateTime.UtcNow;
        }

        [Key]
        public string Id { get; set; }

        [ForeignKey(nameof(CarPortalUser))]
        public string CarPortalUserId { get; set; }
        public CarPortalUser CarPortalUser { get; set; }

        [Required]
        public bool IsDealer { get; set; }

        public string? ProfilePictureAdress { get; set; }

        public DateTime? CreatedDate { get; set; }

        public List<Offer.Offer> PublishedOffers { get; set; } = new List<Offer.Offer>();
        
        public List<ProfileInterestedOffers> SavedOffers { get; set; } = new List<ProfileInterestedOffers>();

        public List<NewsArticle> NewsArticles { get; set; } = new List<NewsArticle>();
        
        public List<NewsArticleComment> NewsArticleComments { get; set;} = new List<NewsArticleComment>();

        public List<OfferComment> OfferComments { get; set; } = new List<OfferComment>();
    }
}
