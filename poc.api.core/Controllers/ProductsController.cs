using System;
using System.Threading.Tasks;
using DomainLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;

namespace WebInterface.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Product), StatusCodes.Status400BadRequest)]
        public ActionResult Get(int page_size, int page)
        {
            try
            {
                return Ok(new ProductSVC().List(page_size, page));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Product), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Product), StatusCodes.Status404NotFound)]

        public ActionResult<string> Get(int id)
        {
            try
            {
                var Product = new ProductSVC().Fetch(id);

                if (Product==null)
                {
                    return NotFound();
                }
                return Ok(Product);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(Product), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(Product), StatusCodes.Status400BadRequest)]
        public async Task< ActionResult<int>> Post([FromBody] string name)
        {
            try
            {
                int Product_id = await new ProductSVC().Create(new Product() { name = name});
                return Ok(Product_id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
