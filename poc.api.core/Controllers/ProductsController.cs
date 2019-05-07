using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DomainLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using WebInterface.Contracts.Request;
using WebInterface.Contracts.Response;

namespace WebInterface.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{v:apiVersion}/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductsController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ProductResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<ProductResponse>> Get(int pageSize, int page)
        {
            var products = _productService.List(pageSize, page);

            var result = _mapper.Map<List<ProductResponse>>(products);

            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProductResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ProductResponse> Get(int id)
        {
            var product = _productService.Fetch(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductResponse>(product));
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<int>> Post([FromBody] ProductRequest request)
        {
            var product = _mapper.Map<Product>(request);

            return Ok(await _productService.Create(product));
        }
    }
}