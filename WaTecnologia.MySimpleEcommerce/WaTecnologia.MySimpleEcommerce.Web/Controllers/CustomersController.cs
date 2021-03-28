using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces;
using WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WaTecnologia.MySimpleEcommerce.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerAppServices _customerAppServices;

        public CustomersController(ICustomerAppServices customerAppServices)
        {
            _customerAppServices = customerAppServices;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<CustomerViewModel> Get()
        {
            return _customerAppServices.GetAll();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public CustomerViewModel Get(int id)
        {
            return _customerAppServices.GetById(id);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] CustomerViewModel customerViewModel)
        {
            _customerAppServices.Add(customerViewModel);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustomerViewModel customerViewModel)
        {
            customerViewModel.Id = id;
            _customerAppServices.Update(customerViewModel);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerAppServices.Delete(id);
        }
    }
}
