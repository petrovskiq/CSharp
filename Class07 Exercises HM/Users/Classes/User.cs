using System;
namespace Users.Classes
{
    public class User
    {
       
            public int Id { get; set; }
            public string Username { get; set;}
            public string Password { get; set;}
            public string[] Message { get; set;}

        public User(int id, string username, string password, string[] message)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Message = message;

        }


    }
}
