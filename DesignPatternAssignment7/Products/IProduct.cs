using DesignPatternAssignment7.Users;

namespace DesignPatternAssignment7.Products
{
    interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        float Price { get; set; }
        int AmountInStock { get; set; }
        float? Discount { get; set; }

        string Update();

        void AttachObserver(IUser User);
        void DetachObserver(IUser User);
        void Notify();
        void Notify(string s);
    }
}
