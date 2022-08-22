// File:    User.cs
// Author:  Helena Lakic
// Created: Sunday, July 24, 2022 16:41:03 
// Purpose: Definition of Class User

using SiMSProject.Storage;
using System;
using System.ComponentModel;

namespace Model
{
    public class User : Serializable
    {
        public String Umcn { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber { get; set; }
        public UserTypeEnum UserType { get; set; }
        public bool IsBlocked { get; set; }


        public void fromCSV(string[] values)
        {
            Umcn = values[0];
            Email = values[1];
            Password = values[2];
            FirstName = values[3];
            LastName = values[4];
            PhoneNumber = values[5];
            //ne radiuserType = (UserType) Enum.Parse(typeof(UserType), values[6], true);
            UserType = (UserTypeEnum)Enum.Parse(typeof(UserTypeEnum), values[6]);
            IsBlocked = values[7].ToLower().Equals("true") ? true : false;
        }

        public string[] toCSV()
        {
            string[] user =
            {
                Umcn,
                Email,
                Password,
                FirstName,
                LastName,
                PhoneNumber,
                Enum.GetName(UserType.GetType(), UserType),
                IsBlocked.ToString()
             //   nameof(userType)
        };
            return user;
        }

    }

}