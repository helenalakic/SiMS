using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiMSProject.Storage
{
    public class UserStorage
    {

        private string fileName = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\SiMSProject\Resources\Data\UserStorage.csv";
        private Serializer<User> userSerializer = new();

        public UserStorage()
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
                if (user.UMCN == u.UMCN)
                    return false;
            }
            users.Add(user);
            userSerializer.toCSV(fileName, users);
            return true;
        }

        public List<User> GetAllUsers() 
        {
            return userSerializer.fromCSV(fileName);
            
        }
    }
}
