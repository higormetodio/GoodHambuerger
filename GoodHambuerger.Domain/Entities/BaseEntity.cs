namespace GoodHambuerger.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; private set; }
    public DateTime CreatedOn { get; private set; } = DateTime.UtcNow;
}
