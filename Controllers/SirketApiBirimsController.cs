using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SirketApis.Atribute;

namespace SirketApis.Controllers
{
    //[Route("api/[controller]/")]
    [MyApiRoute]
    [ApiController]
    public class SirketApiBirimsController : ControllerBase
    {
        BirimRepository birim = new BirimRepository();
        [HttpGet]
        public IActionResult GetBirimList()
        {
            var values = birim.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetBirimList(int id)
        {
            var value = birim.GetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult PostBirim(Birim item)
        {
            birim.Add(item);
          
            return NoContent();
        }
        [HttpPut]
        public IActionResult PutBirim(Birim item)
        {
            birim.Update(item);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBirim(int id)
        {
            birim.Delete(new Birim { Id = id });
            return NoContent();
        }
    }
}
