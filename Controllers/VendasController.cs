using System.Collections.Generic;
using Br.Ufmt.Web.Curso.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Ufmt.Web.Curso.Controller
{
  [ApiController]
  [Route("api/[controller]")]
  [Authorize]
  public class VendasController
  {
    private VendaRepository rep;

    public VendasController(VendaRepository rep)
    {
      this.rep = rep;
    }

    [HttpGet]
    public ActionResult<List<Vendas>> index()
    {
      return rep.findAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Vendas> get(int id)
    {
      return rep.findById(id);
    }

        [HttpPost]
    public ActionResult<Vendas> add([FromBody] Vendas Vendas)
    {
      return rep.adicionar(Vendas);
    }

    [HttpPut("{id}")]
    public ActionResult<Vendas> edit(int id, [FromBody] Vendas Vendas)
    {
      return rep.atualizar(Vendas);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> delete(int id)
    {
      rep.deleteById(id);
      return true;
    }
  }
}