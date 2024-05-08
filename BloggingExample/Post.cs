namespace Intro;

public class Post
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Content { get; private set; }

    public int BlogId { get; private set; }
    public Blog Blog { get; private set; }

    // Constructor required by EF Core
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private Post() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    public Post(string title, string content, Blog blog)
    {
        Title = title;
        Content = content;

        Blog = blog;
        BlogId = blog.Id;
    }

    public override string ToString() =>
    $"""
    Post-{Id}
        Title: {Title},
        Content: {Content}
    """;
}