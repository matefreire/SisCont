using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface ILiquidacaoRepository : IRepository<Liquidacoes, long>
    {
        public Liquidacoes findByName(string descricao);
    }

    public class LiquidacaoRepository : Repository<Liquidacoes, long>, ILiquidacaoRepository
    {
        public LiquidacaoRepository(CursoContext context) : base(context)
        {
        }
        public Liquidacoes findByName(string descricao)
        {
            return db.First(u => u.Descricao == descricao);
        }

    }
}