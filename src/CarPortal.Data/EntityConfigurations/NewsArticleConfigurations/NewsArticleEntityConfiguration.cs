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
    public class NewsArticleEntityConfiguration : IEntityTypeConfiguration<NewsArticle>
    {
        public void Configure(EntityTypeBuilder<NewsArticle> builder)
        {
            builder
                .HasMany(na => na.Comments)
                .WithOne(c => c.NewsArticle)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.Author)
                .WithMany(at => at.NewsArticles)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
