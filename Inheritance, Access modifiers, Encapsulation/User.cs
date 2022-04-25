using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance__Access_modifiers__Encapsulation
{
    class User
    {
        string _username;
        string _password;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Re-enter the username");
                    Console.WriteLine("Username must consist of at least 6 characters");
                }

            }
        }

        public User()
        {

        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {

                if (Code(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password must consist of at least 8 characters");
                }
            }
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }


        public bool Code(string password)
        {
            bool isDigit = false;
            bool isUpper = false;
            bool isLower = false;
            if (password.Length > 8)
            {
                foreach (char letter in password)
                {
                    if (char.IsDigit(letter))
                    {
                        isDigit = true;
                    }
                    else if (char.IsUpper(letter))
                    {
                        isUpper = true;
                    }
                    else if (char.IsLower(letter))
                    {
                        isLower = true;
                    }
                }
                bool result = isDigit && isUpper && isLower;
                return result;
            }
            return false;
        }
    }
}