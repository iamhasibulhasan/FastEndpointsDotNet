using System.ComponentModel.DataAnnotations;

namespace FastEndpointsDotNet.Domain.Common;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; private set; }
    public Guid? Uid { get; private set; } = Guid.NewGuid();
    public int StatusId { get; private set; } = (int)EntityConstants.StatusId.Active;

    public void Active()
    {
        StatusId = (int)EntityConstants.StatusId.Active;
    }
    public void InActive()
    {
        StatusId = (int)EntityConstants.StatusId.InActive;
    }
    public void Delete()
    {
        StatusId = (int)EntityConstants.StatusId.Delete;
    }
}
