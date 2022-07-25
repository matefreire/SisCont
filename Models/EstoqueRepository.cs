using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface IEstoqueRepository : IRepository<Estoque, long>
    {
        public Estoque findByName(string produto);
    }

    public class EstoqueRepository : Repository<Estoque, long>, IEstoqueRepository
    {
        public EstoqueRepository(CursoContext context) : base(context)
        {
        }
        public Estoque findByName(string produto)
        {
            return db.First(u => u.Produto == produto);
        }
    }
}