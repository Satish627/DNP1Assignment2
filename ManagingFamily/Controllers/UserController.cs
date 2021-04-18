using System;
using System.Threading.Tasks;
using Family_Management.Data.UsersData;
using Family_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManagingFamily.Controllers
{
    [ApiController]
    [Route("/users")]
    public class UserController:ControllerBase
    {
        private IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string username, [FromQuery] string password)
        {
            try
            {
                User user = await service.ValidateUser(username, password);
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}