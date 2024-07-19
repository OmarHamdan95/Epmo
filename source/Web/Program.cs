using System.Reflection;
using FluentValidation;

var builder = WebApplication.CreateBuilder();

builder.Host.UseSerilog();

builder.Services.AddResponseCompression();
builder.Services.AddJsonStringLocalizer();
builder.Services.AddHashService();
builder.Services.AddJwtService();
builder.Services.AddAuthorization().AddAuthentication().AddJwtBearer();
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies(typeof(Epmo.Application._IAssemblyMark).Assembly));
builder.Services.AddContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(Context))));
builder.Services.AddClassesMatchingInterfaces(nameof(Epmo));
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
//builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer().AddSwaggerGen();
builder.Services.AddProfiler();
builder.Services.AddControllers().AddJsonOptions().AddAuthorizationPolicy();


var application = builder.Build();

application.UseException();
application.UseHsts().UseHttpsRedirection();
application.UseLocalization("en", "ar");
application.UseResponseCompression();
application.UseStaticFiles();
application.UseSwagger().UseSwaggerUI();
application.UseMiniProfiler();
application.UseRouting();
application.MapControllers();
//application.MapFallbackToFile("index.html");

application.ConfigureMapster();

application.UseAuthentication();
application.UseAuthorization();

// To Do Move It To endpoint Register And Remove all Controller To be Minimal Api
//application.MapGet("/test", () => "Hello, World!");


application.RegisterEndPoints();

application.Run();
