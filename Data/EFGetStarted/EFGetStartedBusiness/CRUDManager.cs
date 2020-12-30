using System;
using System.Collections.Generic;
using System.Linq;
using EFGetStarted;

namespace EFGetStartedBusiness
{
    public class CRUDManager
    {
        public User SelectedUser { get; set; }

		public List<User> RetrieveAll()
        {
			using (var db = new BloggingContext())
			{
				return db.Users.ToList();
			}
		}

        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {

            }
        }

		public void CreateUser(string username, string name)
		{

			using (var db = new BloggingContext())
			{
				var newUser = new User
				{
					
					UserName = username.Trim(),
					Name = name.Trim()
				};

				db.Users.Add(newUser);

				db.SaveChanges();
			}
		}

		public void UpdateUserDetails(int userid, string userName, string name)
		{
			using (var db = new BloggingContext())
			{
				SelectedUser = db.Users.Where(c => c.UserId == userid).FirstOrDefault();
				SelectedUser.Name = name;
				SelectedUser.UserName = username;

				db.SaveChanges();
			}
		}

		public void UpdateNameDetails(string username, string name)
		{
			using (var db = new BloggingContext())
			{
				var SelectedUser =
					from u in db.Users
					where u.UserName == username
					select u;
                //db.Users.Where(c => c.UserName == username).FirstOrDefault();
                //SelectedUser.Name = name.Trim();
                foreach (var item in SelectedUser)
                {
					item.Name = name;
                }

				db.SaveChanges();
			}
		}

		public void DeleteUser(string username, string name)
		{

			using (var db = new BloggingContext())
			{
				var selectedUser =
			from u in db.Users
			where u.UserName== username && u.Name == name
			select u;

				db.Users.RemoveRange(selectedUser);


				db.SaveChanges();
			}
		}

		/////////
		///



	}
}
