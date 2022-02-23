using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Supermarket.Data.Services;
using Supermarket.Data.ViewModels;

namespace Supermarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]

    public class SectorsController : ControllerBase
    {

        //Inject SectorsServices file
        private ISectorsService _sectorsService;


        //The Constructor
        public SectorsController(ISectorsService sectorsService)
        {
            _sectorsService = sectorsService;
        }



        //Creating #1 API endpoint (HttpPost) to add sectors 
        [HttpPost("add-sector")]
        public IActionResult AddSector([FromBody] SectorVM sector)
        {
             _sectorsService.AddSector(sector);
            return Ok();
        }



        //Creating #2 API endpoint (HttpGet) to list all sectors
        [HttpGet("get-all-sectors")]
        public IActionResult GetAllSectors()
        {
            var result = _sectorsService.GetAllSectors();
            return Ok(result);
        }


        //Creating #3 API endpoint (HttpGet) to list a sector by Id
        [HttpGet("get-sector-by-Id/{id}")]
        public IActionResult GetSectorById(int id)
        {
            var result = _sectorsService.GetSectorById(id);
            return Ok(result);
        }




        //Creating #4 API endpoint (HttpPut) to update an existing sector by Id
        [HttpPut("update-sector-by-Id/{id}")]
        public IActionResult UpdateSector(int id, [FromBody] SectorVM sector)
        {
            var dbSector = _sectorsService.GetSectorById(id);
            return Ok(dbSector);
        }



        //Creating #5 API endpoint (HttpDelete) to delete a sector by Id
        [HttpDelete("delete-sector-by-Id/{id}")]
        public IActionResult DeleteSector(int id)
        {
                _sectorsService.DeleteSector(id);
                return Ok();
        }
    }
}

