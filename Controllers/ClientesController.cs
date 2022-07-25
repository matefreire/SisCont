using System.Collections.Generic;
using Br.Ufmt.Web.Curso.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Br.Ufmt.Web.Curso.Controller
{
  [ApiController]
  [Route("api/[controller]")]
  [Authorize]
  public class ClientesController
  {
    private ClienteRepository rep;

    public ClientesController(ClienteRepository rep)
    {
      this.rep = rep;
    }

    [HttpGet]
    public ActionResult<List<Clientes>> index()
    {
      return rep.findAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Clientes> get(int id)
    {
      return rep.findById(id);
    }

        [HttpPost]
    public ActionResult<Clientes> add([FromBody] Clientes Clientes)
    {
      return rep.adicionar(Clientes);
    }

    [HttpPut("{id}")]
    public ActionResult<Clientes> edit(int id, [FromBody] Clientes Clientes)
    {
      return rep.atualizar(Clientes);
    }

    [HttpDelete("{id}")]
    public ActionResult<bool> delete(int id)
    {
      rep.deleteById(id);
      return true;
    }
  }
}