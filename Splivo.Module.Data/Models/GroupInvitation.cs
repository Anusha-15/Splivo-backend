
using System.ComponentModel.DataAnnotations;

namespace Splivo.Module.Data.Models;

public class GroupInvitation : EntityBase
{
    public long GroupId { get; set; }

    public Group Group { get; set; } = null!;

    public long InvitedByUserId { get; set; }

    public User InvitedByUser { get; set; } = null!;

    [Required]
    [EmailAddress]
    [StringLength(256)]
    public string InvitedEmail { get; set; } = string.Empty;

    // Pending, Accepted, Declined, Expired
    public string Status { get; set; } = "Pending";

    public DateTimeOffset? ExpiresOn { get; set; }
}
