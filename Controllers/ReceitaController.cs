using System.Collections.Generic;
using Br.Ufmt.Web.Curso.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Ufmt.Web.Curso.Controller
{
  [ApiController]
  [Route("api/[controller]")]
  [Authorize]
  public class ReceitasController
  {
    private ReceitaRepository rep;

    public ReceitasController(ReceitaRepository rep)
    {
      this.rep = rep;
    }

    [HttpGet]
    public ActionResult<List<Receitas>> index()
    {
      return rep.findAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Receitas> get(int id)
    {
      return rep.findById(id);
    }

        [HttpPost]
    public ActionResult<Receitas> add([FromBody] Receitas Receitas)
    {
      return rep.adicionar(Receitas);
    }

    [HttpPut("{id}")]
    public ActionResult<Receitas> edit(int id, [FromBody] Receitas Receitas)
    {
      return rep.atualizar(Receitas);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> delete(int id)
    {
      rep.deleteById(id);
      return true;
    }
  }
}