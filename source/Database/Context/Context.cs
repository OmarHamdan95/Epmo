using System.Reflection;
using Epmo.Database.Common;
using Epmo.Database.Constants;
using Epmo.Domain.Common;
using MediatR;


namespace Epmo.Database;

public sealed class Context : DbContext
{
    private readonly IMediator _mediator;

    public Context(DbContextOptions options, IMediator mediator) : base(options)
    {
        _mediator = mediator;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //System.Diagnostics.Debugger.Launch();
        base.OnModelCreating(builder);

        var domainTypes = Assembly
            .GetAssembly(typeof(Epmo.Domain._IAssemblyMark))
            .GetTypes()
            .Where(
                myType =>
                    (myType.IsClass) && !myType.IsAbstract && myType.IsSubclassOf(typeof(BaseEntity))
            )
            .ToList();

        builder.ApplyConvention(domainTypes, DatabaseConstants.DB_SCHEMA_NAME);

        foreach (var entity in builder.Model.GetEntityTypes())
        {
            foreach (var property in entity.GetProperties())
            {
                property.SetColumnName(property.Name.ToUpperUnderscoreColumnName());
            }
        }

        builder.ApplyConfigurationsFromAssembly(typeof(_IAssemblyMark).Assembly);

        builder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly).Seed();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     //optionsBuilder.UseLazyLoadingProxies(false);
    //     //optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
    //     //base on
    // }

    public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = new CancellationToken())
    {
        await _mediator.DispatchDomainEvents(this);
        return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }
}
