using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using SirketApis.Atribute;

namespace SirketApis.Controllers
{
    [MyApiRoute]
    //[Route("api/[controller]")]
    [ApiController]
    public class SirketApiCocuksController : ControllerBase
    {
        CocukRepository rep = new CocukRepository();


        [HttpGet]
        public IActionResult GetCocukList()
        {
            var value = rep.GetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetCocukList(int id)
        {
            var value = rep.GetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult PostCocuk(Cocuk cocuk)
        {
            rep.Add(cocuk);
            return NoContent();
        }
        [HttpPut]
        public IActionResult PutCocuk(Cocuk cocuk)
        {
            rep.Update(cocuk);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCocuk(int id)
        {
            rep.Delete(new Cocuk { Id = id });
            return NoContent();
        }

    }
}
