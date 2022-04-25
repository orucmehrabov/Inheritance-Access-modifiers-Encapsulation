using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance__Access_modifiers__Encapsulation
{
    class Admin:User
    {
        public string Section;
        public bool isSuperAdmin;

        public Admin()
        {

        }
        public Admin(string username, string password, string section, bool SuperAdmin = false) : base(username, password)

        {
            Section = section;
            isSuperAdmin = SuperAdmin;
        }
        public string GetInfo()

        {
            return $"Username: {Username} Password: {Password} Section: {Section} Admin: {(isSuperAdmin ? "You are a Super Admin" : "You are not a Super Admin")} ";
        }
    }
}