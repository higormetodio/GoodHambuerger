namespace GoodHambuerger.Domain.Entities;

public abstract class BaseEntity
{
    protected BaseEntity(int id)
    {
        Id = id;
        CreatedOn = DateTime.UtcNow;
    }

    public int Id { get; private set; }
    public DateTime CreatedOn { get; private set; }
}
