using System;

namespace codeASM
{
    internal class User
    {
        protected int id;
        protected string userName;
        protected string password;

        public User(int id, string userName, string password)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
        }

        public User() { }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string UserName
        {
            get { return userName; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The name can't be null");
                }
                userName = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 5 || value.Length > 12)
                {
                    throw new ArgumentException("The number of characters must be between 5 and 12");
                }
                password = value;
            }
        }

        public void Register()
        {
            try
            {
                Console.WriteLine("Enter a user name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter a password: ");
                string password = Console.ReadLine();
                this.UserName = name;
                this.Password = password;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public virtual void ViewSystem() { }

        public virtual void Viewprofile() { }
    }
}