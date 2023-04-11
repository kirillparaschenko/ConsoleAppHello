using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWorkLINQ
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public User(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        /// <summary>
        /// возвращает "<FirstName> <MiddleName> <LastName>", если отчество присутствует Или "<FirstName> <LastName>", если отчество отсутствует.
        /// </summary>
        /// <param name="user"></param>
        public static void GetFullName(List<User> users)
        {
            var selectedUsersWithMidleName = from u in users where u.MiddleName != "" select u;
            foreach (var user in selectedUsersWithMidleName)
            {
                Console.WriteLine($"{user.FirstName} {user.MiddleName} {user.LastName}");
            }
            var selectedUsersWithoutMidleName = from u in users where u.MiddleName == ""  select u;
            foreach(var user in selectedUsersWithoutMidleName)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}");
            }
        }

        /// <summary>
        /// возвращает предоставленный список пользователей, упорядоченный по LastName в порядке убывания.
        /// </summary>
        /// <param name="users"></param>
        public static void OrderUsersByLastName(List<User> users)
        {
            var seletedUsers = from u in users
                               orderby u.LastName descending
                               select u;
            foreach (var user in seletedUsers)
            {
                Console.WriteLine($"{user.LastName} {user.FirstName} {user.MiddleName}");
            }
        }
    }
}
