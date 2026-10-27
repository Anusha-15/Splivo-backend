using Microsoft.EntityFrameworkCore;
using Splivo.Module.Data.Models;

namespace Splivo.Module.Data.Data
{
    public static class CoreSeedData
    {
        // Fixed date: seed me kabhi DateTime.Now / UtcNow use mat karna
        private static readonly DateTime SeedDate =
            new(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        // Admin@123 ka BCrypt hash (sirf development ke liye)
        private const string AdminPasswordHash =
            "$2a$11$u3QvsmYQKt3UDpgz5Ie6cu.hZGxnIYPo9tqL2gup.TP46H51bbjbm";

        public static void SeedData(ModelBuilder builder)
        {
            // ---------- Roles ----------
            builder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin", CreatedOn = SeedDate, LatestUpdatedOn = SeedDate, IsDeleted = false },
                new Role { Id = 2, Name = "User", CreatedOn = SeedDate, LatestUpdatedOn = SeedDate, IsDeleted = false }
            );

            // ---------- Users ----------
            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Admin",
                    Email = "admin@splivo.com",
                    PasswordHash = AdminPasswordHash,
                    IsActive = true,
                    IsSocialLogin = false,
                    LoginVia = 0,                 // 0 = Email
                    CreatedOn = SeedDate,
                    LatestUpdatedOn = SeedDate,
                    IsDeleted = false
                }
            );

            // ---------- User ↔ Role ----------
            builder.Entity<UserRole>().HasData(
                new UserRole { UserId = 1, RoleId = 1 }
            );

            // ---------- Expense categories ----------
            builder.Entity<ExpenseCategory>().HasData(
                new ExpenseCategory { Id = 1, Name = "Food", CreatedOn = SeedDate, LatestUpdatedOn = SeedDate, IsDeleted = false },
                new ExpenseCategory { Id = 2, Name = "Rent", CreatedOn = SeedDate, LatestUpdatedOn = SeedDate, IsDeleted = false },
                new ExpenseCategory { Id = 3, Name = "Travel", CreatedOn = SeedDate, LatestUpdatedOn = SeedDate, IsDeleted = false },
                new ExpenseCategory { Id = 4, Name = "Utilities", CreatedOn = SeedDate, LatestUpdatedOn = SeedDate, IsDeleted = false },
                new ExpenseCategory { Id = 5, Name = "Groceries", CreatedOn = SeedDate, LatestUpdatedOn = SeedDate, IsDeleted = false },
                new ExpenseCategory { Id = 6, Name = "Entertainment", CreatedOn = SeedDate, LatestUpdatedOn = SeedDate, IsDeleted = false },
                new ExpenseCategory { Id = 7, Name = "Shopping", CreatedOn = SeedDate, LatestUpdatedOn = SeedDate, IsDeleted = false },
                new ExpenseCategory { Id = 8, Name = "Other", CreatedOn = SeedDate, LatestUpdatedOn = SeedDate, IsDeleted = false }
            );
        }
    }
}