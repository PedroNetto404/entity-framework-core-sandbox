namespace Intro;

public class Blog
{
    private readonly List<Post> _posts = new();

    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Url { get; private set; }
    public int Rating { get; private set; }
    public IReadOnlyCollection<Post> Posts => _posts;

    // Constructor required by EF Core
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private Blog() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    public Blog(string title, string url, int rating)
    {
        Title = title;
        Url = url;
        Rating = rating;
    }

    public void AddPost(string title, string content) => _posts.Add(new Post(title, content, this));

    public void RemovePost(Post post) => _posts.Remove(post);

    public void RemoveAllPosts() => _posts.Clear();

    public void UpdateRating(int rating) => Rating = rating;

    public void UpdateUrl(string url) => Url = url;

    public void UpdatePosts(params Post[] posts)
    {
        _posts.Clear();
        _posts.AddRange(posts);
    }

    public override string ToString() =>
        $"""
        Blog-{Id}
            Title: {Title},
            Url: {Url},
            Rating: {Rating}
            Posts:
            \t{string.Join("\n", Posts)}
        """;
}
