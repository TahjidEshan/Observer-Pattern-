using System;
namespace DesignPatternAssignment7.Users
{
    class User:IUser
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public void Update(string value)
        {
            Console.WriteLine(this.Name+ " with Id:"+this.UserId+" is subscribed to "+value);
        }
    }
}
