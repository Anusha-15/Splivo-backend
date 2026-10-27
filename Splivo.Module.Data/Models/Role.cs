using System.ComponentModel.DataAnnotations;

namespace Splivo.Module.Data.Models;

public class Role : EntityBase
{
    [Required, StringLength(100)]
    public string Name { get; set; } = string.Empty;   // Admin, User

    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}