using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
             => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Blogging;");
    }

    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; } = new List<Blog>();
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public string MonthCreated { get; set; }
        public User User { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
