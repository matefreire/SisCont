using System.Collections.Generic;
using Br.Ufmt.Web.Curso.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Ufmt.Web.Curso.Controller
{
  [ApiController]
  [Route("api/[controller]")]
  [Authorize]
  public class LiquidacoesController
  {
    private LiquidacaoRepository rep;

    public LiquidacoesController(LiquidacaoRepository rep)
    {
      this.rep = rep;
    }

    [HttpGet]
    public ActionResult<List<Liquidacoes>> index()
    {
      return rep.findAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Liquidacoes> get(int id)
    {
      return rep.findById(id);
    }

        [HttpPost]
    public ActionResult<Liquidacoes> add([FromBody] Liquidacoes Liquidacoes)
    {
      return rep.adicionar(Liquidacoes);
    }

    [HttpPut("{id}")]
    public ActionResult<Liquidacoes> edit(int id, [FromBody] Liquidacoes Liquidacoes)
    {
      return rep.atualizar(Liquidacoes);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> delete(int id)
    {
      rep.deleteById(id);
      return true;
    }
  }
}