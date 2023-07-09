using DooHAdvertAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DooHAdvertAPI.Data
{
    public class AdvertSeedConfiguration : IEntityTypeConfiguration<Adverts>
    {
        public void Configure(EntityTypeBuilder<Adverts> builder)
        {
            builder.HasData
                (
                    new Adverts
                    {
                        Id = 1,
                        Path = "Resources/Images/AeroTech Drones",
                        CityName = "London",
                        StartTime = DateTime.Now,
                        EndTime = new DateTime(2023, 7, 6, 05, 10, 0),
                        Priority = 9,

                    },
                    new Adverts
                    {
                        Id = 2,
                        Path = "Resources/Images/HumblePies",
                        CityName = "Bournemouth",
                        StartTime = new DateTime(2023, 7, 2, 10, 30, 0),
                        EndTime = new DateTime(2023, 7, 8, 05, 10, 0),
                        Priority = 4
                    },
                     new Adverts
                     {
                         Id = 3,
                         Path = "Resources/Images/Java Coffee",
                         CityName = "Sheffield",
                         StartTime = new DateTime(2023, 7, 3, 10, 30, 0),
                         EndTime = new DateTime(2023, 7, 8, 07, 10, 0),
                         Priority = 6

                     },
                      new Adverts
                      {
                          Id = 4,
                          Path = "Resources/Images/LNN",
                          CityName = "Manchester",
                          StartTime = new DateTime(2023, 7, 4, 10, 30, 0),
                          EndTime = new DateTime(2023, 7, 9, 05, 10, 0),
                          Priority = 6
                      },
                       new Adverts
                       {
                           Id = 5,
                           Path = @"Resources/Images/LumoThread",
                           CityName = "Leeds",
                           StartTime = new DateTime(2023, 7, 5, 10, 30, 0),
                           EndTime = new DateTime(2023, 7, 10, 05, 10, 0),
                           Priority = 2
                       },
                        new Adverts
                        {
                            Id = 6,
                            Path = "Resources/Images/MackyCs",
                            CityName ="Liverpool",
                            StartTime = new DateTime(2023, 7, 6, 10, 30, 0),
                            EndTime = new DateTime(2023, 7, 11, 05, 10, 0),
                            Priority = 5
                        },
                        new Adverts
                        {
                            Id = 7,
                            Path = "Resources/Images/Solaris Solar",
                            CityName ="Brighton",
                            StartTime = new DateTime(2023, 7, 6, 10, 30, 0),
                            EndTime = new DateTime(2023, 7, 11, 05, 10, 0),
                            Priority = 2
                        },
                        new Adverts
                        {
                            Id = 8,
                            Path = "Resources/Images/Solaris Solar",
                            CityName = "Hove",
                            StartTime = DateTime.Now,
                            EndTime = new DateTime(2023, 7, 11, 05, 10, 0),
                            Priority = 9
                        },
                        new Adverts
                        {
                            Id = 9,
                            Path = "Resources/Images/AeroTech Drones",
                            CityName = "Liverpool",
                            StartTime = DateTime.Now,
                            EndTime = new DateTime(2023, 7, 6, 05, 10, 0),
                            Priority = 9,

                        },
                        new Adverts
                        {
                            Id = 10,
                            Path = "Resources/Images/Solaris Solar",
                            CityName = "Leeds",
                            StartTime = new DateTime(2023, 7, 6, 10, 30, 0),
                            EndTime = new DateTime(2023, 7, 11, 05, 10, 0),
                            Priority = 10
                        }
                ) ;
        }
    }
}
