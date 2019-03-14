using System;
using Users.Classes;

namespace Users
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            User[] Users = new User[3];
            Users[0] = new User(25, "Dragana", "ooo", new string[] { "Hey Dragana! Nice Shirt", "Call me please!" });
            Users[1] = new User(25, "Martin", "ooo", new string[] { "Hey Martin! Nice Shirt", "Call me please!" });
            Users[2] = new User(25, "Viktor", "ooo", new string[] { "Hey Viktor! Nice Shirt", "Call me please!" });



            Console.WriteLine("Log In/Register");
            string logInRegister = Console.ReadLine();



            if (logInRegister.ToLower() == "login")
            {
                Console.Write("Enter Username" + " ");
                var logInUser = Console.ReadLine();
                Console.Write("Enter Password" + " ");
                var logInPassword = Console.ReadLine();
                Console.WriteLine(LogIn(logInUser, logInPassword, Users));

            }
            else if (logInRegister.ToLower() == "register")
            {
                Console.Write("Enter ID");
                var registerId = int.Parse(Console.ReadLine());
                Console.Write("Enter Username");
                var registerUsername = Console.ReadLine();
                Console.Write("Enter Password");
                var registerPassword = Console.ReadLine();
                Console.WriteLine(Register(registerId,registerUsername, registerPassword, Users));
            }
            else
            {
                Console.WriteLine("Error");
            }




        }

        public static string LogIn(string username, string password, User[] someArray)
        {
            bool flag = true;
            foreach (var user in someArray)
            {
                if (username == user.Username)
                {
                    if (password == user.Password)
                    {
                        flag = false;
                        return "Logged In";
                        
                    }
                }

            }

            if (flag)
            {
                return "Incorrent Password or username";
            }

            return "Emp";
        }

        public static string Register(int id, string username, string password, User[] someArray)
        {
            bool flagTwo = true;
            foreach (var user in someArray)
            {
                if (id == user.Id)
                {
                    flagTwo = false;
                    return "This ID Already exists";

                }
                if (username == user.Username)
                {
                    flagTwo = false;
                    return "Username Already Exist";
                }

               

            }
            if (flagTwo)
            {

                    Array.Resize(ref someArray, someArray.Length + 1);
                    someArray[someArray.Length - 1] = new User(id, username, password, new string[] { $"Hey {username}! nice shirt", "Call me please" });
                    
                foreach (var item1 in someArray)
                {
                    Console.WriteLine($"{item1.Id} {item1.Username}");

                }

            }
            return "";
        }


    }
}
