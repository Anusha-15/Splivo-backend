using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Splivo.Module.Data.Models;

public class Expense : EntityBase
{
    [Required]
    [StringLength(200)]
    public string Description { get; set; } = string.Empty;

    [Precision(18, 2)]
    public decimal Amount { get; set; }

    public long GroupId { get; set; }

    public Group Group { get; set; } = null!;

    public long PaidByUserId { get; set; }

    public User PaidByUser { get; set; } = null!;

    public long? ExpenseCategoryId { get; set; }

    public ExpenseCategory? ExpenseCategory { get; set; }

    public DateTimeOffset ExpenseDate { get; set; }
        = DateTimeOffset.UtcNow;

    public ICollection<ExpenseSplit> Splits { get; set; }
        = new List<ExpenseSplit>();
}
