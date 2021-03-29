using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WaTecnologia.MySimpleEcommerce.ApplicationService.Interfaces;
using WaTecnologia.MySimpleEcommerce.ApplicationService.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WaTecnologia.MySimpleEcommerce.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsAppServices _productsAppServices;
        public ProductsController(IProductsAppServices productsAppServices)
        {
            _productsAppServices = productsAppServices;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<ProductViewModel> Get()
        {
            return _productsAppServices.GetAll();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ProductViewModel Get(int id)
        {
            return _productsAppServices.GetById(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] ProductViewModel productViewModel)
        {
            _productsAppServices.Add(productViewModel);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductViewModel productViewModel)
        {
            productViewModel.Id = id;
            _productsAppServices.Update(productViewModel);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productsAppServices.Delete(id);
        }
    }
}
