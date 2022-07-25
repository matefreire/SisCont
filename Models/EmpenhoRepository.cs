using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface IEmpenhoRepository : IRepository<Empenhos, long>
    {
        public Empenhos findByName(string descricao);
    }

    public class EmpenhoRepository : Repository<Empenhos, long>, IEmpenhoRepository
    {
        public EmpenhoRepository(CursoContext context) : base(context)
        {
        }
        public Empenhos findByName(string descricao)
        {
            return db.First(u => u.Descricao == descricao);
        }

    }
}