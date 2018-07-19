using System;
namespace startup
{
    class Tangtang
    {
        private string name = "john";
        public Tangtang(string name)
        {
            this.name = name;
        }
        ~Tangtang()
        {
            System.Console.WriteLine("Your name is {0}", name);
        }
    }
}