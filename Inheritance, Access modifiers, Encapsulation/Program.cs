using System;

namespace Inheritance__Access_modifiers__Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            string username;

            do
            {
                Console.WriteLine("Enter the username: ");
                username = Console.ReadLine();

            } while (username.Length < 6);
            string password;

            do
            {
                Console.WriteLine("Enter the password: ");
                password = Console.ReadLine();

            } while (!user.Code(password));
            Console.WriteLine("Enter the section: ");
            string section = Console.ReadLine();
            Console.WriteLine("Are you a Super Admin? ");
            string isSuperAdmin = Console.ReadLine();
            bool isSuper = false;

            if (isSuperAdmin.ToLower() == "Yes")
            {
                isSuper = true;
            }
            else if (isSuperAdmin.ToLower() == "No")
            {
                isSuper = false;
            }
            Admin admin1 = new Admin(username, password, section, isSuper);
            Console.WriteLine(admin1.GetInfo());
        }
    }
}