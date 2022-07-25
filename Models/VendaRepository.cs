using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface IVendasRepository : IRepository<Vendas, long>
    {
        public Vendas findByName(string cliente);
    }

    public class VendasRepository : Repository<Vendas, long>, IVendasRepository
    {
        public VendasRepository(CursoContext context) : base(context)
        {
        }
        public Vendas findByName(string cliente)
        {
            return db.First(u => u.Cliente == cliente);
        }
    }
}