using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;

namespace WebInterface.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(User), StatusCodes.Status400BadRequest)]
        public ActionResult Get(int page_size, int page)
        {
            try
            {
                return Ok(new UserSVC().List(page_size, page));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(User), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(User), StatusCodes.Status404NotFound)]

        public ActionResult<string> Get(int id)
        {
            try
            {
                var User = new UserSVC().Fetch(id);

                if (User==null)
                {
                    return NotFound();
                }
                return Ok(User);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(User), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(User), StatusCodes.Status400BadRequest)]

        public async Task< ActionResult<int>> Post([FromBody] string name, string email)
        {
            try
            {
                int user_id = await new UserSVC().Create(new User() { name = name, email = email });
                return Ok(user_id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
