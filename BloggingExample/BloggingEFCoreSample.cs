using Intro;

namespace entity_framework_core_sandbox;

public class BloggingEFCoreSample
{
    private readonly BloggingContext _context;

    public BloggingEFCoreSample(BloggingContext context) => _context = context;

    public void QueryAllBlogs()
    {
        var blogs = _context.Blogs.ToList();
        foreach (var blog in blogs)
        {
            Console.WriteLine(blog);
        }
    }

    public void QueryBlogById(int id)
    {
        var blog = _context.Blogs.Find(id);

        Console.WriteLine(blog);
    }

    public void QueryBlogByTitle(string title)
    {
        var blog = _context.Blogs.Where(b => b.Title.Contains(title)).FirstOrDefault();
        Console.WriteLine(blog);
    }

    public void CreateBlog(Blog newBlog)
    {
        _context.Blogs.Add(newBlog);
        _context.SaveChanges();
    }
}
