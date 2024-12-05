namespace FastEndpointsDotNet.Application.RepositoryInterfaces.Common;

public interface IGenericRepository<T> where T : class
{
    Task<T> CreateAsync(T entity, bool saveChanges, CancellationToken cancellationToken);
    Task CreateRangeAsync(IEnumerable<T> entity, bool saveChanges, CancellationToken cancellationToken);

    Task UpdateAsync(T entity, bool saveChanges, CancellationToken cancellationToken);
    Task UpdateRangeAsync(IEnumerable<T> entity, bool saveChanges, CancellationToken cancellationToken);

    Task<IList<T>> GetAllAsync(CancellationToken cancellationToken);
    Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken);

    Task<bool> DeleteAsync(int id, bool saveChanges, CancellationToken cancellationToken);
}
