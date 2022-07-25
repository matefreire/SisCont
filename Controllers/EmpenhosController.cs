using System.Collections.Generic;
using Br.Ufmt.Web.Curso.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Ufmt.Web.Curso.Controller
{
  [ApiController]
  [Route("api/[controller]")]
  [Authorize]
  public class EmpenhosController
  {
    private EmpenhoRepository rep;

    public EmpenhosController(EmpenhoRepository rep)
    {
      this.rep = rep;
    }

    [HttpGet]
    public ActionResult<List<Empenhos>> index()
    {
      return rep.findAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Empenhos> get(int id)
    {
      return rep.findById(id);
    }

        [HttpPost]
    public ActionResult<Empenhos> add([FromBody] Empenhos Empenhos)
    {
      return rep.adicionar(Empenhos);
    }

    [HttpPut("{id}")]
    public ActionResult<Empenhos> edit(int id, [FromBody] Empenhos Empenhos)
    {
      return rep.atualizar(Empenhos);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> delete(int id)
    {
      rep.deleteById(id);
      return true;
    }
  }
}