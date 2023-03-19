using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SirketApis.Atribute;

namespace SirketApis.Controllers
{
    //[Route("api/[controller]")]
    [MyApiRoute]
    [ApiController]
    public class SirketApiIIcesController : ControllerBase
    {
        IlceRepository rep = new IlceRepository();

        [HttpGet]
        public IActionResult GetIlceList()
        {
            var values = rep.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetIlceList(int id)
        {
            var values = rep.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult PostIlce(Ilce ilce)
        {
            rep.Add(ilce);
            return NoContent();
        }
        [HttpPut]
        public IActionResult PutIlce(Ilce ilce)
        {
            rep.Update(new Ilce { Id = ilce.Id });
            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteIlce(Ilce ilce)
        {
            rep.Delete(new Ilce { Id = ilce.Id});
            return NoContent();
        }
    }
}
