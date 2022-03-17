using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modifiers.Models
{
    internal class User
    {
        private string _password;
        public string _usarName { get; set; }
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Yaw menfi ola bilmez");
                    return;
                }
                _age = value;
            }
        }
        public string Password
        {
            get
            {
                return Password;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                if (value.Length < 8)
                {
                    Console.WriteLine("Pasword en azi 8 simvoldan ibaret olmalidi");
                }
                if (IsexistsDigit(value) == false)
                {
                    return;
                }
                if (IsexistsUpperCase(value) == false)
                {
                    return;
                }

            }
        }
        private bool IsexistsUpperCase(string value)
        {
            foreach (var item in value)
            {
                if (Char.IsUpper(item))
                {
                    Console.WriteLine("True");
                    return true;
                }
            }
            return false;
        }
        private bool IsexistsDigit(string value)
        {
            foreach (var item in value)
            {
                if (Char.IsDigit(item))
                {
                    Console.WriteLine("True");
                    return true;
                }
            }
            return false;
        }
        public User (string UserName, int age, string password)
        {
            this._usarName = UserName;
            this.Age = age;
            this.Password = Password;
            
        }
     }    
}
