using Microsoft.EntityFrameworkCore;

namespace Splivo.Module.Data.Models;

public class Settlement : EntityBase
{
    public long GroupId { get; set; }

    public Group Group { get; set; } = null!;

    public long FromUserId { get; set; }

    public User FromUser { get; set; } = null!;

    public long ToUserId { get; set; }

    public User ToUser { get; set; } = null!;

    [Precision(18, 2)]
    public decimal Amount { get; set; }

    public DateTimeOffset SettledOn { get; set; }
        = DateTimeOffset.UtcNow;
}
