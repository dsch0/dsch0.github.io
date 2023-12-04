using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MIS3033002_LC_1115_AndrewSchmidt.Areas.Identity.Data;

namespace MIS3033002_LC_1115_AndrewSchmidt.Data;

public class AuthenDbConnect : IdentityDbContext<AuthenUser>
{
    public AuthenDbConnect(DbContextOptions<AuthenDbConnect> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
