using System.Collections.Generic;
using Br.Ufmt.Web.Curso.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Ufmt.Web.Curso.Controller
{
  [ApiController]
  [Route("api/[controller]")]
  [Authorize]
  public class EstoqueController
  {
    private EstoqueRepository rep;

    public EstoqueController(EstoqueRepository rep)
    {
      this.rep = rep;
    }

    [HttpGet]
    public ActionResult<List<Estoque>> index()
    {
      return rep.findAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Estoque> get(int id)
    {
      return rep.findById(id);
    }

        [HttpPost]
    public ActionResult<Estoque> add([FromBody] Estoque Estoque)
    {
      return rep.adicionar(Estoque);
    }

    [HttpPut("{id}")]
    public ActionResult<Estoque> edit(int id, [FromBody] Estoque Estoque)
    {
      return rep.atualizar(Estoque);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> delete(int id)
    {
      rep.deleteById(id);
      return true;
    }
  }
}