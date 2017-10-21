using DesignPatternAssignment7.Users;

namespace DesignPatternAssignment7.Products
{
    public delegate void StatusUpdate(string StatusUpdate);

    interface IProduct
    {
        event StatusUpdate StatusHandler;

        int Id { get; set; }
        string Name { get; set; }
        float Price { get; set; }
        int AmountInStock { get; set; }
        float? Discount { get; set; }

        string Update();
        void StartEvent(string s);

        void AttachObserver(IUser User);
        void DetachObserver(IUser User);
        void Notify();
    }
}
