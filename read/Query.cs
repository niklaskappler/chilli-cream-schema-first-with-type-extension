using HotChocolate;
using SplitSchemaDemo.models;

namespace SplitSchemaDemo.read;

public class Query
{
    [GraphQLName("book")]
    public Book GetBook() =>
        new Book
        {
            Title = "C# in depth.",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
    
    [GraphQLName("author")]
    public Author Author() =>
        new Author()
        {
            Name = "Jon Skeet"
        };
}