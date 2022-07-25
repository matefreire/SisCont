using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface IReceitaRepository : IRepository<Receitas, long>
    {
        public Receitas findByName(string descricao);
    }

    public class ReceitaRepository : Repository<Receitas, long>, IReceitaRepository
    {
        public ReceitaRepository(CursoContext context) : base(context)
        {
        }
        public Receitas findByName(string descricao)
        {
            return db.First(u => u.Descricao == descricao);
        }

    }
}