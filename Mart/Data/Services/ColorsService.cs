using Mart.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Mart.Data.Services
{
    public class ColorsService : IColorsService
    {
        private readonly AppDbContext _context;
        public ColorsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Color color)
        {
            throw new NotImplementedException();
        }

        public void Delet(int id)
        {
            throw new NotImplementedException();
        }

       public async Task<IEnumerable<Color>> GetAll()
        {
        var result =await  _context.Colors.ToListAsync();
            return result;
        }

        public Color GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Color Update(int id, Color newColor)
        {
            throw new NotImplementedException();
        }
    }
}
