using DesignPatternAssignment7.Products;
using DesignPatternAssignment7.Users;
using System;


namespace DesignPatternAssignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            User FirstUser = new User
            {
                Name = "First User",
                UserId = 1
            };
            User SecondUser = new User
            {
                Name = "Second User",
                UserId = 2
            };
            ConcreteProduct Book = new ConcreteProduct
            {
                Name = "Book1",
                Price = 500,
                Discount = 0,
                Id = 1,
                AmountInStock = 5,
            };
            Book.AttachObserver(FirstUser);
            Book.AttachObserver(SecondUser);
            Book.AmountInStock = 10;
            Book.DetachObserver(SecondUser);
            Book.Price = 550;
            Console.ReadLine();
        }
    }
}
