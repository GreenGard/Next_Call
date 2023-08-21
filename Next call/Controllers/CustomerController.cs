using ClassLibrary.Models.EntityModels;
using ClassLibrary.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using Next_call.Services;

namespace Next_call.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {


        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("test")]
        public  string GetHej()
        {
       
            return "hej";
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<CustomerEntity>>> GetCustomerById(int id, CancellationToken cancellationToken)
        {
            var response = await _customerService.GetCustomerById(id, cancellationToken);

            if (!response.Success)
            {
                return NotFound(response);
            }

            return Ok(response.Data);
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<CustomerEntity>>>> GetAllCustomers()
        {
            var response = await _customerService.GetAllCustomersAcync();

            return Ok(response);
        }


    }
    }
