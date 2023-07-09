using DooHAdvertAPI.Data;
using DooHAdvertAPI.Models;
using DooHAdvertAPI.Repository.Contract;
using Microsoft.EntityFrameworkCore;

namespace DooHAdvertAPI.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly AppDbContext _context;
       
        public CityRepository(AppDbContext context)
        {
            _context = context;
        }

       

        public string GetActiveAdvertPath(string cityName)
        {
                      
            DateTime currentTime = DateTime.Now;
            

            var activeAdverts = _context.Adverts.Where(x=> x.CityName.Contains(cityName) &&(x.StartTime <= currentTime && x.EndTime >= currentTime)).ToList() ;


            if (activeAdverts.Count == 0)
            {
                return null;
            }
            else if(activeAdverts.Count == 1)
            {
                return activeAdverts[0].Path;
            }
            else { 
                var highestPriorityAdvert = activeAdverts
                    .OrderByDescending(ad=> ad.Priority)
                    .FirstOrDefault();

                return highestPriorityAdvert?.Path;
            }

        }
    }
}
