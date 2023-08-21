using ClassLibrary.Models.EntityModels;
using ClassLibrary.Models.Responses;
using Microsoft.EntityFrameworkCore;
using Next_call.Data;

namespace Next_call.Services
{
    public class CustomerService
    {
        private readonly DataContext _context;

        public CustomerService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<CustomerEntity>> GetCustomerById(int id, CancellationToken cancellationToken)
        {
            var response = new ServiceResponse<CustomerEntity>();

            try
            {
                var customer = await _context.Customers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
               
                if (customer == null)
                {
                    response.Message = "Customer not found";
                }
                else
                {
                    response.Success = true;
                    response.Data = customer;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"An error occurred: {ex.Message}";
            }

            return response;
        }

        public async Task<ServiceResponse<List<CustomerEntity>>> GetAllCustomersAcync()
        {
            var response = new ServiceResponse<List<CustomerEntity>>();

            try
            {
                var customers = await _context.Customers.ToListAsync();

                response.Success = true;
                response.Data = customers;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"An error occurred: {ex.Message}";
            }

            return response;
        }
    }
    }
