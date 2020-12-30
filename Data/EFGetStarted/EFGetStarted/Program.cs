using System;
using System.Linq;

namespace EFGetStarted
{
    class Program
    {
        static void Main()
        {
            using (var db = new BloggingContext())
            {
                //var userToBeDeleted =
                //    from c in db.Users
                //    where c.Name == "Breesha Foxton"
                //    select c;

                //foreach (var item in userToBeDeleted)
                //{
                //    db.Customers.Remove(item);
                //}

                //db.SaveChanges();

                //var newUser = new User { Name = "Nish Mandal" };
                //var newBlog = new Blog { Url = "www.SpartaGlobal.com", User = newUser };
                //var newPost = new Post { Blog = newBlog, Title = "Whatever", Content = "Happy Birthday Lenny" };

                //db.Users.Add(newUser);
                //db.Blogs.Add(newBlog);
                //db.Posts.Add(newPost);

                //db.SaveChanges();

                //var selectedUser = db.Users.Where(x => x.Name=="Nish Mandal").FirstOrDefault();
                //var newBlog = new Blog { Url = "www.Youtube.com", User = selectedUser };


                //db.Blogs.Add(newBlog);
                //db.SaveChanges();


                //// Create
                //Console.WriteLine("Inserting a new blog");
                //db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                //db.SaveChanges();

                //// Read
                //Console.WriteLine("Querying for a blog");
                //var blog = db.Blogs
                //    .OrderBy(b => b.BlogId)
                //    .First();

                //// Update
                //Console.WriteLine("Updating the blog and adding a post");
                //blog.Url = "https://devblogs.microsoft.com/dotnet";
                //blog.Posts.Add(
                //    new Post
                //    {
                //        Title = "Hello World",
                //        Content = "I wrote an app using EF Core!"
                //    });
                //db.SaveChanges();

                //// Delete
                //Console.WriteLine("Delete the blog");
                //db.Remove(blog);
                //db.SaveChanges();
            }
        }
    }
}
