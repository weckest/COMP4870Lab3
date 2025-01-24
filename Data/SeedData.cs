using System;
using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data;

public static class SeedData
{
     public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
    }

    public static List<City> GetCities() {
        List<City> cities = new List<City> {
            new City {
                CityId = 1,
                CityName = "Toronto",
                Population = 2731571,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 2,
                CityName = "Vancouver",
                Population = 631486,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 3,
                CityName = "Calgary",
                Population = 1239220,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 4,
                CityName = "Montreal",
                Population = 1704694,
                ProvinceCode = "QC"
            },
            new City {
                CityId = 5,
                CityName = "Halifax",
                Population = 403131,
                ProvinceCode = "NS"
            },
            new City {
                CityId = 6,
                CityName = "Mississauga",
                Population = 721599,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 7,
                CityName = "Surrey",
                Population = 517887,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 8,
                CityName = "Edmonton",
                Population = 1062643,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 9,
                CityName = "Quebec City",
                Population = 531902,
                ProvinceCode = "QC"
            },
            new City {
                CityId = 10,
                CityName = "Ottawa",
                Population = 934243,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 11,
                CityName = "Red Deer",
                Population = 100418,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 12,
                CityName = "Kelowna",
                Population = 142146,
                ProvinceCode = "BC"
            }
        };
        return cities;
    }

    public static List<Province> GetProvinces() {
        List<Province> provinces = new List<Province> {
            new Province {
                ProvinceCode = "ON",
                ProvinceName = "Ontario"
            },
            new Province {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia"
            },
            new Province {
                ProvinceCode = "AB",
                ProvinceName = "Alberta"
            },
            new Province {
                ProvinceCode = "QC",
                ProvinceName = "Quebec"
            },
            new Province {
                ProvinceCode = "NS",
                ProvinceName = "Nova Scotia"
            }
        };
        return provinces;
    }

}
