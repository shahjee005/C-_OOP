using System;

namespace encapsulation
{
    class User
    {
        private string username;
        private string password;
        public string MyUsername
        { //accessos
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string MyPassword
        { //accesor 
            get
            {
                return password;
            }
            set
            {
                password = value;

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                User myUser = new User();
                myUser.MyUsername = "jsmith";
                myUser.MyPassword = "Password";
                Console.WriteLine("username:" + myUser.MyUsername);
                string myOutput = myUser.MyPassword;
                Console.WriteLine(myOutput);
                Console.WriteLine("Password:" + myUser.MyPassword);
            }
        }
    }
}
