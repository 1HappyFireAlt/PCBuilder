using PCBuilder.Model;
using Microsoft.EntityFrameworkCore;

namespace PCBuilder.Context
{
    public class ComponentProvider
    {
        private readonly DatabaseContext _context;

        public ComponentProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Component>> GetAllComponentsAsync()
        {
            return await _context.Components.OrderBy(Component => Component.Name).ToListAsync();
        }

        public Component? GetComponent(int id)
        {
            return _context.Components.Find(id);
        }

        public async Task AddComponentAsync(Component component)
        {
            _context.Components.Add(component);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateComponentAsync(Component component)
        {
            _context.Components.Update(component);
            await _context.SaveChangesAsync();
        }
    }
}
