using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Family.Data.AdultsData;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ManagingFamily.Controllers
{
    [ApiController]
    [Route("/adults")]
    public class AdultsController : ControllerBase
    {


        private IAdults service;

        public AdultsController(IAdults service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults()
        {
            try
            {
                IList<Adult> adults = await service.GetAdults();
                return Ok(adults);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("{Id:int}")]
        public async Task<ActionResult<Adult>> GetAdult([FromRoute] int Id)
        {
            try
            {
                Adult adult = await service.getAdult(Id);
                return Ok(adult);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Adult toAdd = await service.AddAdult(adult);
                return Created($"/{toAdd}", toAdd);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPatch]
        [Route("{Id:int}")]
        public async Task<ActionResult<Adult>> UpdateAdult([FromRoute] int id, [FromBody] Adult adult)
        {
            try
            {
                Adult toUpdate = await service.Update(id, adult);
                return Created($"/{toUpdate}", toUpdate);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{Id:int}")]
        public async Task RemoveAdult([FromRoute] int adultid)
        {
            try
            
            {
                Adult toRemove = await service.Remove(adultid);
            }
            catch (Exception e)
            { Console.WriteLine(StatusCode(500, e.Message));
            }
        }
        
    }
}