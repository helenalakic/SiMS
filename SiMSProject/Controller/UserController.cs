using Model;
using SiMSProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiMSProject.Controller
{
    internal class UserController
    {
		private UserService userService;

		public UserController()
		{
			userService = new UserService();
		}

		public void Add(User user)
		{
			userService.Add(user);
		}

		public User LoginUser(String username, String password)
        {
			 return userService.LoginUser(username, password);
        }

		public bool IsLoggedIncorrectly(int counter)
        {
			return userService.IsLoggedIncorrectly(counter);
        }

		public List<User> GetAllUsers()
        {
			return userService.GetAllUsers();

		}
		public User RegisterUser(User user)
        {
			return userService.RegisterUser(user);

		}
		public List<User> GetAllUsersExceptManager()
		{
			return userService.GetAllUsersExceptManager();
		}
		public bool Update(User user)
        {
			return userService.Update(user);
        }
		public void BlockUser(User user)
        {
			userService.BlockUser(user);
        }
		public void UnblockUser(User user)
		{
			userService.UnblockUser(user);
		}
		public User GetUserByUmcn(String umcn)
        {
			return userService.GetUserByUmcn(umcn);
        }

	}
}
