using APIROBERTO.Models;
using APIROBERTO.Models.DCModel;
using Microsoft.EntityFrameworkCore;

namespace APIROBERTO.Services 
{
    public class AspiranteServices 
    {
        private readonly DCcontext _context;
        
        public AspiranteServices(DCcontext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Aspirante>> GetAll()
        {
            return await _context.Aspirantes.ToListAsync();
        }
        public async void Create(Aspirante aspirante)
        {
            _context.Aspirantes.Add(aspirante);
            await _context.SaveChangesAsync();
        }
    }
}