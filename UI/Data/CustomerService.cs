using DB.Model;
using Microsoft.EntityFrameworkCore;

namespace UI.Data
{
    public class CustomerService
    {
        private readonly SoiTestContext _context;

        public CustomerService(SoiTestContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }
    }
}
