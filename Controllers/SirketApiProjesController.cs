using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using SirketApis.Atribute;

namespace SirketApis.Controllers
{
    //[Route("api/[controller]")]
    [MyApiRoute]
    [ApiController]
    public class SirketApiProjesController : ControllerBase
    {
        ProjeRepository rep = new ProjeRepository();

        [HttpGet]
        public IActionResult GetProjeList()
        {
            var value = rep.GetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetProjeList(int id)
        {
            var value = rep.GetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult PostProje(Proje item)
        {
            rep.Add(item);
            return NoContent();
        }
        [HttpPut]
        public IActionResult PutProje(Proje item)
        {
            rep.Update(item);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProje(int id)
        {
            rep.Delete(new Proje { Id = id });
            return NoContent();
        }
    }
}
