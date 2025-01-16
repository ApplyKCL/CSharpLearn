using System;

namespace C8T1
{
    class StorkInfo
    {
        
        private string productName
        {
            set;
            get;
        }
        public StorkInfo(string name)
        {
            this.productName = name;
        }
        public StorkInfo()
        {
            this.productName = "No name";
        }
        
        
        public void SetName(string name)
        {
            this.productName = name;
        }
        // cannot use static method in the class
        public void showName()
        {
            Console.WriteLine("Product name: " + this.productName);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter product name: ");
            StorkInfo storkInfo = new StorkInfo(Console.ReadLine());
            storkInfo.showName();
        }
    }
}