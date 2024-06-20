using SplitSchemaDemo.models;

namespace SplitSchemaDemo.read;

[ExtendObjectType("Query")]
public class AuthorQuery
{
    [GraphQLName("author")]
    [GraphQLType("Author")]
    public Author Author() =>
        new Author()
        {
            Name = "Jon Skeet"
        };
}