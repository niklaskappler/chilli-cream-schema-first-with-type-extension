using HotChocolate;
using HotChocolate.Types;
using SplitSchemaDemo.models;

namespace SplitSchemaDemo.read;

[ExtendObjectType("Query")]
public class BookQuery
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
}