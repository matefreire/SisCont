using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface IClientesRepository : IRepository<Clientes, long>
    {
        public Clientes findByName(string nome);
    }

    public class ClientesRepository : Repository<Clientes, long>, IClientesRepository
    {
        public ClientesRepository(CursoContext context) : base(context)
        {
        }
        public Clientes findByName(string nome)
        {
            return db.First(u => u.Nome == nome);
        }

    }
}