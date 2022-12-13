using LearnGraphQL;
using LearnGraphQL.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<BooksContext>();

builder.Services
    .AddGraphQLServer()
    .AddProjections()
    .AddFiltering()
    .RegisterDbContext<BooksContext>()
    .AddMutationType<BookMutations>()
    .AddMutationConventions()
    .AddQueryType<BookQuery>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
