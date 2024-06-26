﻿using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiMSProject.Storage
{
    public class UserRepository
    {

        private string fileName = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\SiMSProject\Resources\Data\UserStorage.csv";
        private Serializer<User> userSerializer = new();

        public UserRepository()
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine(fileName);
                File.Create(fileName).Close();
            }
        }
        public bool Create(User user)
        {
            List<User> users = userSerializer.fromCSV(fileName);
            foreach (User u in users)
            {
                if (user.Umcn == u.Umcn)
                    return false;
            }
            users.Add(user);
            userSerializer.toCSV(fileName, users);
            return true;
        }

        public bool Update(User user)
        {
            List<User> allUsers = userSerializer.fromCSV(fileName);
            int foundIndex = -1;
            foreach (User u in allUsers)
            {
                if (user.Umcn == u.Umcn)
                    foundIndex = allUsers.IndexOf(u);
            }
            allUsers.RemoveAt(foundIndex);
            allUsers.Insert(foundIndex, user);
            userSerializer.toCSV(fileName, allUsers);
            return true;
        }

        public List<User> GetAllUsers() 
        {
            return userSerializer.fromCSV(fileName);
            
        }
    }
}
