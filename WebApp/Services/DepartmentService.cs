using System.Collections.Generic;
using System.Linq;
using WebApp.Data;
using WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class DepartmentService
    {
        private readonly WebAppContext _context;

        public DepartmentService(WebAppContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
