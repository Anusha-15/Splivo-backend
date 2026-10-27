
using Microsoft.EntityFrameworkCore;

namespace Splivo.Module.Data.Models;

public class ExpenseSplit : EntityBase
{
    public long ExpenseId { get; set; }

    public Expense Expense { get; set; } = null!;

    public long UserId { get; set; }    

    public User User { get; set; } = null!;

    [Precision(18, 2)]
    public decimal Amount { get; set; }
}
