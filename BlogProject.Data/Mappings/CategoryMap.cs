using BlogProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlogProject.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("{67444033-B248-4899-82BD-B8A929D02419}"),
                Name = "asp.net core",
                CreatedBy = "admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },

            new Category
            {

                Id = Guid.Parse("{63FB47EA-31CF-4D52-8EEA-E7E8313C87B2}"),
                Name = "asp.net core",
                CreatedBy = "admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }

            );
            
        }
    }
}
