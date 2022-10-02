using Mart.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        public async Task AddAsync(Color color)
        {
             _context.Colors.Add(color); 
            await _context.SaveChangesAsync();     
        }

        public async Task DeletAsync(int id)
        {
            var result = await _context.Colors.FirstOrDefaultAsync(i => i.Id == id);
           _context.Colors.Remove(result);
            await _context.SaveChangesAsync();


        }

        public async Task<IEnumerable<Color>> GetAllAsync()
        {
        var result =await  _context.Colors.ToListAsync();
            return result;
        }

        public async Task<IEnumerable<Color>> GetByIdAsync(int id)
        {
            var result = await _context.Colors.FirstOrDefaultAsync(i => i.Id == id);
            return result;
        }

        public async Task<Color> UpdateAsync(int id, Color newColor)
        {
            _context.Update(newColor);
            await _context.SaveChangesAsync();          
            return newColor;    
        }
    }
}
