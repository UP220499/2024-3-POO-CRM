using CRM.Application.Services;
using CRM.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _customerService.GetAllCustomersAsync();
        }

        [HttpGet("{id}")]
        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _customerService.GetCustomerByIdAsync(id);
        }

        [HttpPost]
        public async Task AddCustomerAsync(Customer customer)
        {
            await _customerService.AddCustomerAsync(customer);
        }

        [HttpPut]
        public async Task UpdateCustomerAsync(Customer customer)
        {
            await _customerService.UpdateCustomerAsync(customer);
        }
    }
}