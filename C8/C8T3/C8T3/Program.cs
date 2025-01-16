using System;

namespace C8T3
{
    class User
    {
        private string _name = "";
        private int _age = 0;
        private string _gender = "";
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
            
        }

        public User(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Gender: " + Gender);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("John", 13, "male");
            user.Display();
        }
    }
}