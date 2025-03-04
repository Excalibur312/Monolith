using System.Collections.Generic;

namespace UserManagement
{
    public class UserService
    {
        private List<User> Users { get; set; } = new List<User>();

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public User GetUser(int id)
        {
            return Users.Find(u => u.Id == id);
        }

        public List<User> GetAllUsers()
        {
            return Users;
        }
    }
}
