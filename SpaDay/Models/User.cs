using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; }

        public User() // need to keep this no arg constructor. otherwise  it can not pick valu from input type text form Add.cshtml it will try to find a null constructor.
        {
            Date = DateTime.Now;
        }
        public User(string userName, string email, string password): this()
        {
            UserName = userName;
            Email = email;
            Password = password;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
