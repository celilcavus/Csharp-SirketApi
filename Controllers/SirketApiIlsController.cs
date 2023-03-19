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
    public class SirketApiIlsController : ControllerBase
    {
        ILRepository rep = new ILRepository();

        [HttpGet]
        public IActionResult GetIlList()
        {
            var values = rep.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetIlList(int id)
        {
            var values = rep.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult PostIl(Il il)
        {
            rep.Add(il);
            return NoContent();
        }
        [HttpPut]
        public IActionResult PutIl(Il il)
        {
            rep.Update(new Il { Id = il.Id });
            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteIl(Il il)
        {
            rep.Delete(new Il { Id = il.Id});
            return NoContent();
        }
    }
}
