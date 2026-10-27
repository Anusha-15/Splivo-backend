namespace Splivo.Module.Data.Models
{
    public abstract class EntityBase
    {
        public long Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? LatestUpdatedOn { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}