using System;
using FastFoodDelivery.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FastFoodDelivery.Repository;

public class DbInitializer : IDbInitializer
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly ApplicationDbContext _context;

    public DbInitializer(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
    {
        _roleManager = roleManager;
        _userManager = userManager;
        _context = context;
    }

    public void Initialize()
    {
        try
        {
            if (_context.Database.GetPendingMigrations().Count() > 0)
            {
                _context.Database.Migrate();
            }
        }
        catch (System.Exception)
        {
            throw;
        }

        if (_context.Roles.Any(x => x.Name == "Admin"))
        {
            return;
        }

        _roleManager.CreateAsync(new IdentityRole("Manager")).GetAwaiter().GetResult();
        _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
        _roleManager.CreateAsync(new IdentityRole("Customer")).GetAwaiter().GetResult();

        var user = new AppUser
        {
            UserName = "admin@gmail.com",
            Email = "admin@gmail.com",
            Name = "Admin",
            City = "xyz",
            Addresses = "xyz",
            PostalCode = "0000",
        };
        _userManager.CreateAsync(user, "Admin@123").GetAwaiter().GetResult();
        _userManager.AddToRoleAsync(user, "Admin");

    }
}
