using ColorsMedium.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ColorsMedium.WebApi.Controllers
{
    [ApiController]
    [Route("api/colors")]
    public class ColorController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllColors() => Ok(ColorsRepository.GetAll());

        [HttpGet("{name}")]
        public IActionResult GetByName(string name) => Ok(ColorsRepository.GetAll()
            .Where(x => x.Name.ToLower() == name.ToLower()));
    }
}