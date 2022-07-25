using System.Collections.Generic;
using Br.Ufmt.Web.Curso.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Ufmt.Web.Curso.Controller
{
  [ApiController]
  [Route("api/[controller]")]
  [Authorize]
  public class DespesasController
  {
    private DespesaRepository rep;

    public DespesasController(DespesaRepository rep)
    {
      this.rep = rep;
    }

    [HttpGet]
    public ActionResult<List<Despesas>> index()
    {
      return rep.findAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Despesas> get(int id)
    {
      return rep.findById(id);
    }

        [HttpPost]
    public ActionResult<Despesas> add([FromBody] Despesas Despesas)
    {
      return rep.adicionar(Despesas);
    }

    [HttpPut("{id}")]
    public ActionResult<Despesas> edit(int id, [FromBody] Despesas Despesas)
    {
      return rep.atualizar(Despesas);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> delete(int id)
    {
      rep.deleteById(id);
      return true;
    }
  }
}