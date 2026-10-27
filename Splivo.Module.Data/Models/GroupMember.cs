namespace Splivo.Module.Data.Models;

public class GroupMember : EntityBase
{
    public long GroupId { get; set; }

    public Group Group { get; set; } = null!;

    public long UserId { get; set; }

    public User User { get; set; } = null!;

    public string Role { get; set; } = "Member";

    public DateTimeOffset JoinedOn { get; set; }
        = DateTimeOffset.UtcNow;
}
