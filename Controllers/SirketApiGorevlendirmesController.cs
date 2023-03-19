using _01_SirketApi.Entity.Entity;
using _02_SirketApp.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using SirketApis.Atribute;

namespace SirketApis.Controllers
{
    //[Route("api/[controller]")]
    [MyApiRoute]
    [ApiController]
    public class SirketApiGorevlendirmesController : ControllerBase
    {
        GorevlendirmeRepository rep = new GorevlendirmeRepository();

        [HttpGet]
        public IActionResult GetGorevlendirmeList()
        {
            var values = rep.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetGorevlendirmeList(int id)
        {
            var values = rep.GetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult PostGorevlendirme(Gorevlendirme gorevlendirme)
        {
            rep.Add(gorevlendirme);
            return NoContent();
        }
        [HttpPut]
        public IActionResult PutGorevlendirme(Gorevlendirme gorevlendirme)
        {
            rep.Update(new Gorevlendirme { Id = gorevlendirme.Id });
            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteGorevlendirme(Gorevlendirme gorevlendirme)
        {
            rep.Delete(new Gorevlendirme { Id = gorevlendirme.Id });
            return NoContent();
        }
    }
}
