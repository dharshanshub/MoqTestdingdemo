using CatWebAPI.Models;
using CatWebAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace CatWebAPI.Controllers{
    [Route("api/[controller]")]
    [ApiController]

    public class CatController:ControllerBase
    {

        private readonly CatService _catservice;

        public CatController(CatService catService){
            _catservice=catService;
        }
        [HttpGet]
        public async Task<ActionResult<Cat>> CatMessage()
        {
          var cat = await _catservice.GetFact();
             

            return Ok(cat);

        }


    }
}