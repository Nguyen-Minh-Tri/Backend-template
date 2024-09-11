namespace BackendTemplate.DataAccess;

public class BaseDataAccess<T> : IBaseDataAccess<T> where T : BaseEntity
{
    protected readonly List<T> _dataStore = new List<T>();

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        // Simulating async behavior
        return await Task.FromResult(_dataStore);
    }

    public async Task<T> GetByIdAsync(string id)
    {
        // Simulating async behavior
        var entity = _dataStore.Find(e => e.Id == Guid.Parse(id));
        return await Task.FromResult(entity);
    }

    public async Task AddAsync(T entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedAt = DateTime.UtcNow;
        entity.UpdatedAt = DateTime.UtcNow;
        _dataStore.Add(entity);
        await Task.CompletedTask;
    }

    public async Task UpdateAsync(T entity)
    {
        var existingEntity = _dataStore.Find(e => e.Id == entity.Id);
        if (existingEntity != null)
        {
            existingEntity.UpdatedAt = DateTime.UtcNow;
            // Update the rest of the entity properties here as needed
        }
        await Task.CompletedTask;
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = _dataStore.Find(e => e.Id == id);
        if (entity != null)
        {
            _dataStore.Remove(entity);
        }
        await Task.CompletedTask;
    }
}
