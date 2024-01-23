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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {


        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image 
                {
                    Id = Guid.Parse("{A4CD6C4A-DB01-4896-8757-E8EF9335D29B}"),
                    FileName = "test",
                    FileType = "jpg",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedBy = "Admin test",
                    DeletedBy = "1"
                },
                new Image 
                {
                    Id = Guid.Parse("{18E25216-A682-47D3-AB3E-F708CE11EE49}"),
                    FileName = "test1",
                    FileType = "jpg",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedBy = "Admin test",
                    DeletedBy = "1"
                });
            
        }
    }
}
