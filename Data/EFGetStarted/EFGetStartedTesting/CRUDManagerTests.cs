using EFGetStartedBusiness;
using System.Linq;
using EFGetStarted;
using NUnit.Framework;

namespace EFGetStartedTesting
{
    public class UserCRUDTests
    {
        CRUDManager _crudManager = new CRUDManager();


        [SetUp]
        public void Setup()
        {
            using (var db = new BloggingContext())
            {

                //var selectedUsers =
                //from u in db.Users
                //where c.Name == "Breesha Foxton"
                //select u;

                //db.Users.RemoveRange(selectedUsers);

                //db.SaveChanges();
            }
        }

        [TearDown]

        public void TearDown()
        {
            using (var db = new BloggingContext())
            {

                var selectedUsers =
                from c in db.Users
                where c.UserName == "bfoxton3"
                select c;


                db.Users.RemoveRange(selectedUsers);

                db.SaveChanges();
            }
        }


        [Test]
        public void NewUserIsAdded_IncreasesBy1()
        {
            using (var db = new BloggingContext())
            {

                var numberBefore = db.Users.ToList().Count();
                _crudManager.CreateUser("bfoxton3", "Breesha Foxton");
                var numberAfter = db.Users.ToList().Count();

                Assert.AreEqual(numberBefore + 1, numberAfter);
            }
        }

        [Test]
        public void WhenANewUserIsAdded_TheirDetailsAreCorrect()
        {
            using (var db = new BloggingContext())
            {
                _crudManager.CreateUser("bfoxton3", "Breesha Foxton");
                var check = db.Users.Where(c => c.UserName == "bfoxton3");
                foreach (var item in check)
                {
                    Assert.AreEqual(item.Name, "Breesha Foxton");
                }

            }
        }

        [Test]
        public void NameIsChanged_TheDatabaseIsUpdated()
        {
            using (var db = new BloggingContext())
            {

                var newUser = new User
                {
                    UserName = "bfoxton3".Trim(),
                    Name = "Breesha Foxton".Trim()

                };
                db.Users.Add(newUser);
                db.SaveChanges();
                _crudManager.UpdateNameDetails("bfoxton3", "Breesha");
                var selectedUser = db.Users.Where(c => c.UserName == "bfoxton3");
                foreach (var item in selectedUser)
                {
                    Assert.AreEqual(item.Name, "Breesha");
                }

            }
        }

        [Test]
        public void UserIsChanged_TheDatabaseIsUpdated()
        {
            using (var db = new BloggingContext())
            {

                var newUser = new User
                {
                    UserName = "bfoxton3".Trim(),
                    Name = "Breesha Foxton".Trim()

                };
                db.Users.Add(newUser);
                db.SaveChanges();
                _crudManager.UpdateUserDetails(17,"bfoxton3", "Breesha");
                var selectedUser = db.Users.Where(c => c.UserName == "bfoxton3");
                foreach (var item in selectedUser)
                {
                    Assert.AreEqual(item.Name, "Breesha");
                }

            }
        }

        [Test]
        public void UserIsRemoved_NoLongerInTheDatabase()
        {
            using (var db = new BloggingContext())
            {

                var newUser = new User
                {
                    UserName = "bfoxton3".Trim(),
                    Name = "Breesha Foxton".Trim()

                };
                db.Users.Add(newUser);
                db.SaveChanges();
                int before = db.Users.Count();
                _crudManager.DeleteUser("bfoxton3", "Breesha Foxton");
                int after = db.Users.Count();
                Assert.AreEqual(before - 1, after);

            }
        }
    }

}