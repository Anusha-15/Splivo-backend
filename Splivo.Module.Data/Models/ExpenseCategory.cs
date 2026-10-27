using System.ComponentModel.DataAnnotations;

namespace Splivo.Module.Data.Models;

public class ExpenseCategory : EntityBase
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedOn { get; set; }
    public DateTime LatestUpdatedOn { get; set; }
}
