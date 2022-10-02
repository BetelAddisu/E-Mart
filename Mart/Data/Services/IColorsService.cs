using Mart.Models;
using System.Collections.Generic;


namespace Mart.Data.Services
{
    public interface IColorsService
    {
       Task <IEnumerable<Color>> GetAllAsync();

        Color GetByIdAsync(int id);

        Task AddAsync(Color color);  

        Task<Color> UpdateAsync(int id, Color newColor);

        Task DeleteAsync(int id); 
    }
}
