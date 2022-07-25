using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface IContaRepository : IRepository<Contas, long>
    {
        public Contas findByName(string banco);
    }

    public class ContaRepository : Repository<Contas, long>, IContaRepository
    {
        public ContaRepository(CursoContext context) : base(context)
        {
        }
        public Contas findByName(string banco)
        {
            return db.First(u => u.Banco == banco);
        }

    }
}