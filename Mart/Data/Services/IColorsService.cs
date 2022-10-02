using Mart.Models;
using System.Collections.Generic;


namespace Mart.Data.Services
{
    public interface IColorsService
    {
       Task <IEnumerable<Color>> GetAll();

        Color GetById(int id);

        void Add(Color color);  

        Color Update(int id, Color newColor);

        void Delet(int id); 
    }
}
