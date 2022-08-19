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
                if(user.Email.Equals(username) && user.Password.Equals(password))
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
             foreach(User u in users)
             { 
                if (u.Umcn.Equals(user.Umcn))
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


        //public void Remove(string surgeryId)
        //{
        //    surgeryStorage.Delete(surgeryId);
        //}

        //public List<Surgery> GetSurgeriesByPatient(Patient patient)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Surgery> GetByDoctor(string Id)
        //{
        //    return surgeryStorage.ReadByDoctor(Id);
        //}

        //public void Edit(Surgery surgery)
        //{
        //    surgeryStorage.Update(surgery);
        //}


    }
}

