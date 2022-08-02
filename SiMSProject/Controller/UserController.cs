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

		//public void Edit(Surgery surgery)
		//{
		//	surgeryService.Edit(surgery);
		//}

		//internal List<Surgery> GetByDoctor(string Id)
		//{
		//	return surgeryService.GetByDoctor(Id);
		//}

		///*public List<Surgery> GetAll()
		//{
		//	return surgeryService.GetAll();
		//}*/

		//public void Remove(string surgeryId)
		//{
		//	surgeryService.Remove(surgeryId);
		//}
	}
}
