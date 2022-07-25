using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface IPagamentoRepository : IRepository<Pagamentos, long>
    {
        public Pagamentos findByName(string descricao);
    }

    public class PagamentoRepository : Repository<Pagamentos, long>, IPagamentoRepository
    {
        public PagamentoRepository(CursoContext context) : base(context)
        {
        }
        public Pagamentos findByName(string descricao)
        {
            return db.First(u => u.Descricao == descricao);
        }

    }
}