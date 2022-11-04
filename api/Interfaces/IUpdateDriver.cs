using api.Models;

namespace api.Interfaces
{
    public interface IUpdateDriver
    {
        public void UpdateDriverRating(int id, Driver value);
    }
}