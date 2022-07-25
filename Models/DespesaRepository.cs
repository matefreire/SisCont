using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface IDespesaRepository : IRepository<Despesas, long>
    {
        public Despesas findByName(string descricao);
    }

    public class DespesaRepository : Repository<Despesas, long>, IDespesaRepository
    {
        public DespesaRepository(CursoContext context) : base(context)
        {
        }
        public Despesas findByName(string descricao)
        {
            return db.First(u => u.Descricao == descricao);
        }

    }
}