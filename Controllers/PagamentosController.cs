using System.Collections.Generic;
using Br.Ufmt.Web.Curso.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Ufmt.Web.Curso.Controller
{
  [ApiController]
  [Route("api/[controller]")]
  [Authorize]
  public class PagamentosController
  {
    private PagamentoRepository rep;

    public PagamentosController(PagamentoRepository rep)
    {
      this.rep = rep;
    }

    [HttpGet]
    public ActionResult<List<Pagamentos>> index()
    {
      return rep.findAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Pagamentos> get(int id)
    {
      return rep.findById(id);
    }

        [HttpPost]
    public ActionResult<Pagamentos> add([FromBody] Pagamentos Pagamentos)
    {
      return rep.adicionar(Pagamentos);
    }

    [HttpPut("{id}")]
    public ActionResult<Pagamentos> edit(int id, [FromBody] Pagamentos Pagamentos)
    {
      return rep.atualizar(Pagamentos);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> delete(int id)
    {
      rep.deleteById(id);
      return true;
    }
  }
}