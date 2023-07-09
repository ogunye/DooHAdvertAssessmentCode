using DooHAdvertAPI.Models;

namespace DooHAdvertAPI.Repository.Contract
{
    public interface ICityRepository
    {      
        string GetActiveAdvertPath (string cityName);
    }
}
