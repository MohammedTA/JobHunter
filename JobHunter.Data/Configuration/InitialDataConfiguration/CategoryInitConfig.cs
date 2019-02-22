using JobHunter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace JobHunter.Data.Configuration.InitialDataConfiguration
{
    public class CategoryInitConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            int categoryId = 1;
            Category[] categories = new Category[]
            {
                new Category
                {
                    Id =categoryId++,
                    Name="jobs-it"
                },
                 new Category
                {
                    Id =categoryId++,
                    Name="jobs-construction-architecture"
                },
                    new Category
                {
                    Id =categoryId++,
                    Name="jobs-accounting"
                },
                 new Category
                {
                    Id =categoryId++,
                    Name="jobs-administration"
                },
                    new Category
                {
                    Id =categoryId++,
                    Name="jobs-hotel-restaurant-tourism"
                },
                 new Category
                {
                    Id =categoryId++,
                    Name="jobs-design-art"
                },
                    new Category
                {
                    Id =categoryId++,
                    Name="jobs-publishing-media"
                },
                 new Category
                {
                    Id =categoryId++,
                    Name="jobs-beauty-sports"
                },
                    new Category
                {
                    Id =categoryId++,
                    Name="jobs-culture-music-showbiz"
                },
                 new Category
                {
                    Id =categoryId++,
                    Name="jobs-logistic-supply-chain"
                },
                   new Category
                {
                    Id =categoryId++,
                    Name="jobs-marketing-advertising-pr"
                },
                    new Category
                {
                    Id =categoryId++,
                    Name="jobs-healthcare"
                },
                 new Category
                {
                    Id =categoryId++,
                    Name="jobs-real-estate"
                },
                   new Category
                {
                    Id =categoryId++,
                    Name="jobs-education-scientific"
                },
                    new Category
                {
                    Id =categoryId++,
                    Name="jobs-security"
                },
                 new Category
                {
                    Id =categoryId++,
                    Name="jobs-sales"
                },
                  new Category
                {
                    Id =categoryId++,
                    Name="jobs-production-engineering"
                },
                    new Category
                {
                    Id =categoryId++,
                    Name="jobs-retail"
                },
                       new Category
                {
                    Id =categoryId++,
                    Name="jobs-office-secretarial"
                },
                          new Category
                {
                    Id =categoryId++,
                    Name="jobs-agriculture"
                },
                           new Category
                {
                    Id =categoryId++,
                    Name="jobs-insurance"
                },
                          new Category
                {
                    Id =categoryId++,
                    Name="jobs-customer-service"
                },
                         new Category
                {
                    Id =categoryId++,
                    Name="jobs-telecommunications"
                },
                     new Category
                {
                    Id =categoryId++,
                    Name="jobs-management-executive"
                },
                   new Category
                {
                    Id =categoryId++,
                    Name="jobs-auto-transport"
                },
            };
            builder.HasData(categories);
        }
    }
}
