using System.ComponentModel.DataAnnotations;

namespace Splivo.Module.Data.Models;

public class User : EntityBase
{
    [Required, StringLength(450)]
    public string Name { get; set; } = string.Empty;

    [Required, EmailAddress, StringLength(256)]
    public string Email { get; set; } = string.Empty;

    public string? PasswordHash { get; set; }

    public bool IsActive { get; set; } = true;
    public bool IsSocialLogin { get; set; } = false;
    public string? FirebaseId { get; set; }
    public string? SocialLoginApp { get; set; }

    public int LoginVia { get; set; }

    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}