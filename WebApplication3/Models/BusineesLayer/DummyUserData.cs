using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class DummyUserData
    {
        private static List<User> users = new List<User>();
       

        public static List<User> addUsers()
        {
            if (!(users.Count == 0))
            {
                return users;
            }
            users.Add(
                new User
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Karkow",
                    Gender = Gender.Male.ToString(),
                    Coverage = 80,
                    DOB = Convert.ToDateTime("03/01/1980")
                }
                );
            users.Add(
                new User
                {
                    Id = 2,
                    FirstName = "James",
                    LastName = "Feather",
                    Gender = Gender.Male.ToString(),
                    Coverage = 50,
                    DOB = Convert.ToDateTime("03/01/1980")
                }
                );
            users.Add(
                new User
                {
                    Id = 3,
                    FirstName = "Red",
                    LastName = "Hemmington",
                    Gender = Gender.Male.ToString(),
                    Coverage = 80,
                    DOB = Convert.ToDateTime("03/01/1980")
                }
                );
            users.Add(
                new User
                {
                    Id = 4,
                    FirstName = "Ron",
                    LastName = "Eldrich",
                    Gender = Gender.Male.ToString(),
                    Coverage = 80,
                    DOB = Convert.ToDateTime("07/11/1990")
                }
                );
            users.Add(
                new User
                {
                    Id = 5,
                    FirstName = "Ron",
                    LastName = "Crystal",
                    Gender = Gender.Male.ToString(),
                    Coverage = 80,
                    DOB = Convert.ToDateTime("03/01/1976")
                }
                );
            return users;
        }
    }
}