using BlogProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            

            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "deneme makalesi",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                ViewCount = 15,
                CategoryId = Guid.Parse("{67444033-B248-4899-82BD-B8A929D02419}"),
                ImageId = Guid.Parse("{A4CD6C4A-DB01-4896-8757-E8EF9335D29B}"),
                CreatedBy = "admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                

                

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "vs deneme makalesi ",
                Content = " vsLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                ViewCount = 15,
                CategoryId = Guid.Parse("{63FB47EA-31CF-4D52-8EEA-E7E8313C87B2}"),
                ImageId = Guid.Parse("{18E25216-A682-47D3-AB3E-F708CE11EE49}"),
                CreatedBy = "vs admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
               
            }
            ); ; ;
            ;
        }
    }
}
