using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork7
{
    internal class LoginTask
    {
        public static bool Login(string login, string password, string confirmPassword)
        {
            try 
            {
                if (string.IsNullOrEmpty(login) || login.Length >= 20 || login.IndexOf(' ') != -1)
                {
                    throw new WrongLoginException("Login does not match requirements");
                }
                if (string.IsNullOrEmpty(password) || password.Length >= 20 || password.IndexOf(' ') != -1 || !Regex.IsMatch(password, "[0-9]"))
                {
                    throw new WrongPasswordException("Password does not match requirements");
                }
                if (confirmPassword != password)
                {
                    throw new WrongPasswordException("Confirm password does not match password");
                }
                return true;
            } 
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return false; 
            }
        }
    }
}
