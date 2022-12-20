using CarPortal.Data.Entities.News;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.EntityConfigurations.NewsArticleConfigurations
{
    public class NewsArticleCommentEntityConfiguration : IEntityTypeConfiguration<NewsArticleComment>
    {
        public void Configure(EntityTypeBuilder<NewsArticleComment> builder)
        {
            builder
                .HasOne(c => c.NewsArticle)
                .WithMany(a => a.Comments)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Commenter)
                .WithMany(cc => cc.NewsArticleComments)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(c => c.IsActive)
                .HasDefaultValue(true);
        }
    }
}
