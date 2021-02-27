using System;
using System.Collections.Generic;
using System.Text;
using MobileApp.Class;

namespace MobileApp.Class
{
    public class listUser
    {
        public List<User> list { get; set; }
        public listUser()
        {
            list = new List<User>();
            list.Add(new User("first","first"));
            list.Add(new User("second", "second"));
            list.Add(new User("third", "third"));
        }
    }
}
