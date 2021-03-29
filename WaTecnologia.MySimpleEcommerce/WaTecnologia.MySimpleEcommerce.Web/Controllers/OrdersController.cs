using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces;
using WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WaTecnologia.MySimpleEcommerce.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersAppServices _ordersAppServices;

        public OrdersController(IOrdersAppServices ordersAppServices)
        {
            _ordersAppServices = ordersAppServices;
        }

        // GET: api/<SalesController>
        [HttpGet]
        public IEnumerable<OrderViewModel> Get()
        {
            return _ordersAppServices.GetAll();
        }

        // GET api/<SalesController>/5
        [HttpGet("{id}")]
        public OrderViewModel Get(int id)
        {
            return _ordersAppServices.GetById(id);
        }

        // POST api/<SalesController>
        [HttpPost]
        public void Post([FromBody] OrderViewModel saleViewModel)
        {
            _ordersAppServices.Add(saleViewModel);
        }

        // PUT api/<SalesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrderViewModel saleViewModel)
        {
            saleViewModel.Id = id;
            _ordersAppServices.Update(saleViewModel);
        }

        // DELETE api/<SalesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ordersAppServices.Delete(id);
        }
    }
}
