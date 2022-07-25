using System.Collections.Generic;
using Br.Ufmt.Web.Curso.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Ufmt.Web.Curso.Controller
{
  [ApiController]
  [Route("api/[controller]")]
  [Authorize]
  public class ContasController
  {
    private ContaRepository rep;

    public ContasController(ContaRepository rep)
    {
      this.rep = rep;
    }

    [HttpGet]
    public ActionResult<List<Contas>> index()
    {
      return rep.findAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Contas> get(int id)
    {
      return rep.findById(id);
    }

        [HttpPost]
    public ActionResult<Contas> add([FromBody] Contas Contas)
    {
      return rep.adicionar(Contas);
    }

    [HttpPut("{id}")]
    public ActionResult<Contas> edit(int id, [FromBody] Contas Contas)
    {
      return rep.atualizar(Contas);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> delete(int id)
    {
      rep.deleteById(id);
      return true;
    }
  }
}