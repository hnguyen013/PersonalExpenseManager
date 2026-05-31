using PersonalExpenseManager.Entity;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PersonalExpenseManager.DAL
{
    internal class UserDAL : IUserDAL
    {
        private readonly string filePath = "users.txt";

        public UserDAL()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllLines(filePath, new string[]
                {
                    "admin|123456",
                    "nguyen|123456"
                });
            }
        }

        public List<User> ReadAll()
        {
            List<User> users = new List<User>();

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 2)
                {
                    User user = new User(parts[0], parts[1]);
                    users.Add(user);
                }
            }

            return users;
        }

        public bool CheckLogin(string username, string password)
        {
            username = username.Trim().ToLower();
            password = password.Trim();

            List<User> users = ReadAll();

            return users.Any(u =>
                u.Username.Trim().ToLower() == username &&
                u.Password.Trim() == password
            );
        }

        public bool IsUsernameExists(string username)
        {
            username = username.Trim().ToLower();

            List<User> users = ReadAll();

            return users.Any(u =>
                u.Username.Trim().ToLower() == username
            );
        }

        public bool Create(User user)
        {
            if (IsUsernameExists(user.Username))
            {
                return false;
            }

            string line = user.Username.Trim() + "|" + user.Password.Trim();

            File.AppendAllText(filePath, line + "\n");

            return true;
        }
    }
}