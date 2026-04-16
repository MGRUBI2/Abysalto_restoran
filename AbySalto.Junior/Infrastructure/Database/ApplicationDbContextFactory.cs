using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AbySalto.Junior.Infrastructure.Database;

public class ApplicationDbContextFactory: IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=AbySalto;Username=myuser;Password=mypassword;");
        
        return new ApplicationDbContext(optionsBuilder.Options);
    }
    
}