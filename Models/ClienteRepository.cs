using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface IClienteRepository : IRepository<Clientes, long>
    {
        public Clientes findByName(string nome);
    }

    public class ClienteRepository : Repository<Clientes, long>, IClienteRepository
    {
        public ClienteRepository(CursoContext context) : base(context)
        {
        }
        public Clientes findByName(string nome)
        {
            return db.First(u => u.Nome == nome);
        }

    }
}