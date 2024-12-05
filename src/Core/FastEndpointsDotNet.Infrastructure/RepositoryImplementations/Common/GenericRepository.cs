using FastEndpointsDotNet.Application.RepositoryInterfaces.Common;
using Microsoft.EntityFrameworkCore;

namespace FastEndpointsDotNet.Infrastructure.RepositoryImplementations.Common;


public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly DbContext _context;
    public GenericRepository(DbContext context)
    {
        _context = context;
    }
    private DbSet<T> _dbSet;
    protected DbSet<T> DbSet
    {
        get
        {
            _dbSet ??= _context.Set<T>();
            return _dbSet;
        }
    }
    public async Task<T> CreateAsync(T entity, bool saveChanges, CancellationToken cancellationToken)
    {
        var r = await DbSet.AddAsync(entity, cancellationToken);
        if (saveChanges)
            await _context.SaveChangesAsync(cancellationToken);
        return r.Entity;
    }

    public async Task CreateRangeAsync(IEnumerable<T> entity, bool saveChanges, CancellationToken cancellationToken)
    {
        await DbSet.AddRangeAsync(entity, cancellationToken);
        if (saveChanges)
            await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<bool> DeleteAsync(int id, bool saveChanges, CancellationToken cancellationToken)
    {
        var entity = await GetByIdAsync(id, cancellationToken);
        if (entity != null)
        {
            DbSet.Remove(entity);
            if (saveChanges)
                await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
        return false;
    }

    public async Task<IList<T>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await DbSet.ToListAsync(cancellationToken);
    }

    public async Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await DbSet.FindAsync(id, cancellationToken);
    }

    public async Task UpdateAsync(T entity, bool saveChanges, CancellationToken cancellationToken)
    {
        await Task.Run(() =>
        {
            DbSet.Update(entity);
        });
        if (saveChanges)
            await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateRangeAsync(IEnumerable<T> entity, bool saveChanges, CancellationToken cancellationToken)
    {
        await Task.Run(() =>
        {
            DbSet.UpdateRange(entity);
        });
        if (saveChanges)
        {
            await _context.SaveChangesAsync();
        }
    }
}
