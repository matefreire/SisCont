using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface IVendaRepository : IRepository<Vendas, long>
    {
        public Vendas findByName(string cliente);
    }

    public class VendaRepository : Repository<Vendas, long>, IVendaRepository
    {
        public VendaRepository(CursoContext context) : base(context)
        {
        }
        public Vendas findByName(string cliente)
        {
            return db.First(u => u.Cliente == cliente);
        }
    }
}