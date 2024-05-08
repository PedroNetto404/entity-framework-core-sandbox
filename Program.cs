using entity_framework_core_sandbox;
using Intro;

var bloggingSample = new BloggingEFCoreSample(
    new Intro.BloggingContext()
);

var newBlog = new Blog(
    "Example Blog",
    "https://www.example.com", 5);

newBlog.AddPost("First Post", "This is the first post.");
newBlog.AddPost("Second Post", "This is the second post.");

System.Console.WriteLine("Creating new blog...");
bloggingSample.CreateBlog(newBlog);

System.Console.WriteLine("Querying all blogs...");
bloggingSample.QueryAllBlogs();

System.Console.WriteLine("Querying blog by ID...");
bloggingSample.QueryBlogById(1);

System.Console.WriteLine("Querying blog by title...");
bloggingSample.QueryBlogByTitle("First");

