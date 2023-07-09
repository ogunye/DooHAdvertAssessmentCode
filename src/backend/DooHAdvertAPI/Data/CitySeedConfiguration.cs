using DooHAdvertAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DooHAdvertAPI.Data
{
    public class CitySeedConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                new Location
                {
                    Id = 1,
                    Name = "London",
                },
                new Location
                {
                    Id = 2,
                    Name = "Bournemouth",
                },
                new Location
                {
                    Id = 3,
                    Name = "Sheffield",
                }, new Location
                { 
                    Id = 4, 
                    Name = "Manchester" 
                }, 
                new Location 
                { 
                    Id = 5, 
                    Name = "Leeds"
                }, 
                new Location 
                { 
                    Id = 6, 
                    Name = "Liverpool"
                },
                new Location
                {
                    Id = 7,
                    Name = "Brighton",
                },
                new Location
                {
                    Id = 8,
                    Name = "Hove",
                });
        }
    }
}
