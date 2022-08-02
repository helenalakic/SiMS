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
                if(user.EMAIL.Equals(username) && user.PASSWORD.Equals(password))
                {
                    return user;
                }
            }
            return null;
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

