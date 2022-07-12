using apicuestomers.DTO;

namespace apicuestomers.Core.IRepositories;

public interface IGenericRepository<T> where T : class
{

  Task<IEnumerable<T>> All();
  Task<T> GetById(int id);
  Task<bool> Add(T entity);
  Task<bool> Delete(int id);
  Task<bool> Upsert(T entity);
  Task<bool> PutUsuario(UserDTO userDTO);
  Task<string> RecoveryPassword(string correo);

}
