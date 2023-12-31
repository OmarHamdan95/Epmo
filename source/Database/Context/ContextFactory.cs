using Epmo.Database.Common;

namespace Epmo.Database;

public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
{
    public Context CreateDbContext(string[] args)
    {
        const string connectionString = "Server=.;Database=EpmoGitHub;TrustServerCertificate=True;User Id=sa;Password=P@ssw0rd;";

        return new Context(new DbContextOptionsBuilder<Context>().UseSqlServer(connectionString).Options , new NoMediator());
    }
}
