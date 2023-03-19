using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Model;
using _02_SirketApp.Model.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SirketApis.Atribute;

namespace SirketApis.Controllers
{
    //[Route("api/[controller]/[action]")]
    [MyApiRoute]
    [ApiController]
    public class SirketApiPersonelsController : ControllerBase
    {
        PersonelRepository pers = new PersonelRepository();
        [HttpGet]
        public IActionResult GetPersonelList()
        {
            var values = pers.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetPersonelList(int id)
        {
            var values = pers.GetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult PostPersonel(Personel personel)
        {
            pers.Add(personel);
            return NoContent();
        }

        [HttpPut]
        public IActionResult PutPersonel(Personel personel)
        {
            pers.Update(personel);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePersonel(int id)
        {
            pers.Delete(new Personel { Id = id });
            return NoContent();
        }
    }
}
