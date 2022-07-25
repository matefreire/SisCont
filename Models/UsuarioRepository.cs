using System.Linq;

namespace Br.Ufmt.Web.Curso.Repository
{
    public interface IUsuarioRepository : IRepository<Usuarios, long>
    {
        public Usuarios findByName(string username);
        public Usuarios findByNameAndPassword(string username, string password);
    }

    public class UsuarioRepository : Repository<Usuarios, long>, IUsuarioRepository
    {
        public UsuarioRepository(CursoContext context) : base(context)
        {
        }
        public Usuarios findByName(string login)
        {
            return db.First(u => u.Login == login);
        }

        public Usuarios findByNameAndPassword(string username, string password)
        {
            var user = this.findByName(username);
            if (BCrypt.Net.BCrypt.Verify(password, user.Senha, false, BCrypt.Net.HashType.SHA256))
            {
                return user;
            }
            return null;
        }
    }
}