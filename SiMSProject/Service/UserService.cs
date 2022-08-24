using Model;
using SiMSProject.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiMSProject.Service
{
    public class UserService
    {
        private UserStorage userStorage;

        public UserService()
        {
            userStorage = new UserStorage();
        }

        public void Add(User user)
        {
            userStorage.Create(user);
        }

        public User LoginUser(String username, String password)
        {
            List<User> users = new List<User>();
            users = userStorage.GetAllUsers();
            foreach (User user in users)
            {
                if (user.Email.Equals(username) && user.Password.Equals(password))
                {
                    return user;
                }
              
            }
            return null;
        }

        public User RegisterUser(User user)
        {
            List<User> users = new List<User>();
            users = userStorage.GetAllUsers();
            foreach (User u in users)
            {
                if (u.Umcn.Equals(user.Umcn) || u.Email.Equals(user.Email))
                {
                    return null;
                }
            }
            return user;
        }


        public List<User> GetAllUsers()
        {
            return userStorage.GetAllUsers();
        }

        public List<User> GetAllUsersExceptManager()
        {
            return userStorage.GetAllUsers().Where(x => x.UserType != UserTypeEnum.Manager).ToList();

        }

        public void BlockUser(User user)
        {
            user.IsBlocked = true;
            userStorage.Update(user);

        }
       
        public void UnblockUser(User user)
        {
            user.IsBlocked = false;
            userStorage.Update(user);

        }
       
        public bool Update(User user)
        {
            return userStorage.Update(user);
        }

        
        public User GetUserByUmcn(String umcn)
        {
            return userStorage.GetAllUsers().FirstOrDefault(x => x.Umcn.Equals(umcn));
        }

    }
}

