using System.ComponentModel.DataAnnotations;

namespace Splivo.Module.Data.Models;

public class Group : EntityBase
{
    [Required]
    [StringLength(150)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    public long CreatedByUserId { get; set; }

    public User CreatedByUser { get; set; } = null!;

    public ICollection<GroupMember> Members { get; set; }
        = new List<GroupMember>();

    public ICollection<Expense> Expenses { get; set; }
        = new List<Expense>();
}
