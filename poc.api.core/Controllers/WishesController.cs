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
    public class WishsController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Wish), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Wish), StatusCodes.Status400BadRequest)]
        public ActionResult Get(int page_size, int page)
        {
            try
            {
                return Ok(new WishSVC().List(page_size, page));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Wish), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Wish), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Wish), StatusCodes.Status404NotFound)]
        public ActionResult<string> Get(int id)
        {
            try
            {
                var Wish = new WishSVC().Fetch(id);

                if (Wish==null)
                {
                    return NotFound();
                }
                return Ok(Wish);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(Wish), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(Wish), StatusCodes.Status400BadRequest)]
        public async Task< ActionResult<int>> Post([FromBody] Wish wish)
        {
            try
            {
                int Wish_id = await new WishSVC().Create(wish);
                return Ok(Wish_id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Wish), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Wish), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> Put(int id, [FromBody] Wish wish)
        {
            try
            {
                bool blnStatusResponse = await new WishSVC().Update(wish);

                if (blnStatusResponse)
                {
                    return Ok(blnStatusResponse);
                }

                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Wish), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Wish), StatusCodes.Status400BadRequest)]
        public async void DeleteAsync(int id)
        {
            try
            {
                bool blnOperation = await new WishSVC().Delete(new WishSVC().Fetch(id));
            }
            catch (Exception)
            {
                BadRequest();
            }
        }


    }
}
