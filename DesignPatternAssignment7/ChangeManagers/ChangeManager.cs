using DesignPatternAssignment7.Products;
using DesignPatternAssignment7.Users;

namespace DesignPatternAssignment7.ChangeManagers
{
    class ChangeManager
    {
        public static void Register(IProduct Product, IUser User)
        {
            Product.StatusHandler+= new StatusUpdate(User.Update);
        }
        public static void UnRegister(IProduct Product, IUser User)
        {
            Product.StatusHandler -= new StatusUpdate(User.Update);
        }
        public static void Notify(IProduct Product)
        {
            Product.StartEvent(Product.Update());
        }
    }
}
