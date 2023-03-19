using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using SirketApis.Atribute;

namespace SirketApis.Controllers
{
    //[Route("api/[controller]")]
    [MyApiRoute]
    [ApiController]
    public class SirketApiUnvansController : ControllerBase
    {
        UnvanRepository rep = new UnvanRepository();
        [HttpGet]
        public IActionResult GetUnvanList()
        {
            var values = rep.GetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetUnvanList(int id)
        {
            var values = rep.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult PostUnvan(Unvan item)
        {
            rep.Add(item);
            return NoContent();
        }

        [HttpPut]
        public IActionResult PutUnvan(Unvan item)
        {
            rep.Update(item);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult PutUnvan(int id)
        {
            rep.Remove(new Unvan { Id = id });
            return NoContent();
        }
    }
}
