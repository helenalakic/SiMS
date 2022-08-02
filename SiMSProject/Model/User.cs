// File:    User.cs
// Author:  Helena Lakic
// Created: Sunday, July 24, 2022 16:41:03 
// Purpose: Definition of Class User

using SiMSProject.Storage;
using System;
using System.ComponentModel;

namespace Model
{
    public class User : INotifyPropertyChanged, Serializable
    {
        private String umcn;
        private String email;
        private String password;
        private String firstName;
        private String lastName;
        private String phoneNumber;
        public UserType userType;


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public void fromCSV(string[] values)
        {
            umcn = values[0];
            email = values[1];
            password = values[2];
            firstName = values[3];
            lastName = values[4];
            phoneNumber = values[5];
            //ne radiuserType = (UserType) Enum.Parse(typeof(UserType), values[6], true);
            userType = (UserType)Enum.Parse(typeof(UserType), values[6]);

        }

        public string[] toCSV()
        {
            string[] user =
            {
                umcn,
                email,
                password,
                firstName,
                lastName,
                phoneNumber,
                Enum.GetName(userType.GetType(), userType),
             //   nameof(userType)
        };
            return user;
        }

        public string UMCN
        {
            get
            {
                return umcn;
            }
            set
            {
                if (value != umcn)
                {
                    umcn = value;
                    OnPropertyChanged("UMCN");
                }
            }
        }

        public String EMAIL
        {
            get 
            {
                return email; 
            }
            set
            {
                if (value != email)
                {
                    email = value;
                    OnPropertyChanged("EMAIL");                }
            }

        }
        public String PASSWORD
        {
            get 
            {
                return password; 
            }
            set
            {
                if (value != password)
                {
                    password = value; OnPropertyChanged("PASSWORD");
                }
            }
        }
        
        public String FIRSTNAME
        {
            get
            {
            return firstName; 
            }
            set
            {
                if (value != firstName)
                {
                    firstName = value; OnPropertyChanged("FIRSTNAME");
                }
            }
        }
        public String LASTNAME
        {
            get { return lastName; }
            set
            {
                if (value != lastName)
                {
                    lastName = value; OnPropertyChanged("LASTNAME");
                }
            }
        }
        public String PHONENUMBER
        {
            get { return phoneNumber; }
            set
            {
                if (value != phoneNumber)
                {
                    phoneNumber = value; OnPropertyChanged("PHONENUMBER");
                }
            }
        }
        public UserType USERTYPE
        {
            get
            {
                return userType;
            }
            set
            {
                if (value != userType)
                {
                    userType = value;
                    OnPropertyChanged("USERTYPE");
                }
            }

        }
    }

}