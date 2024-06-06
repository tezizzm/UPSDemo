using Microsoft.EntityFrameworkCore;
using UI.Model;

namespace UI.Data
{
    public class ContosoService
    {
        private readonly ContosoContext _context;

        public ContosoService(ContosoContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _context.Customers.Take(100).ToListAsync();
        }

        public async Task<Customer?> GetCustomerAsync(int customerKey)
        {
            return await _context.Customers.FindAsync(customerKey);
        }

        public async Task<List<Order>> GetOrdersForCustomerAsync(int customerKey)
        {
            return await _context.Orders.Where(o => o.CustomerKey == customerKey).ToListAsync();
        }

        public async Task<List<OrderRow>> GetOrderDetailsForOrderAsync(int orderKey)
        {
            return await _context
                .OrderRows
                .Where(od => od.OrderKey == orderKey)
                .Include(or => or.ProductKeyNavigation)
                .Include(or => or.OrderKeyNavigation)
                .ToListAsync();
        }
    }
}
