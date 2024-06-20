using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SplitSchemaDemo.models;
using SplitSchemaDemo.read;

var builder = WebApplication.CreateBuilder(args);

// not working
builder.Services
    .AddGraphQLServer()
    .AddDocumentFromFile("schema.graphql")
    .AddTypeExtension<AuthorQuery>()
    .AddTypeExtension<BookQuery>()
    .BindRuntimeType<Book>()
    .BindRuntimeType<Author>();

// working
// builder.Services
//     .AddGraphQLServer()
//     .AddDocumentFromFile("schema.graphql")
//     .BindRuntimeType<Query>()
//     .BindRuntimeType<Book>()
//     .BindRuntimeType<Author>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!2");
app.MapGraphQL();
app.Run();
