using DesignPatternAssignment7.Products;
using DesignPatternAssignment7.Users;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatternAssignment7.ChangeManagers
{
    class ChangeManager
    {
        public static ICollection<StatusUpdateHandler> EventList = new List<StatusUpdateHandler>();

        private static bool Contains(int Id)
        {
            foreach (StatusUpdateHandler item in EventList)
            {
                if (item.ProductId == Id)
                    return true;
            }
            return false;
        }
        private static void AddProductEvent(int Id, StatusUpdate St)
        {
            foreach (StatusUpdateHandler item in EventList)
            {
                if (item.ProductId == Id)
                {
                    item.StatusHandler += St;
                    break;
                }
            }
        }
        
        public static void Register(IProduct Product, IUser User)
        {
            if(!Contains(Product.Id))
            {
                EventList.Add(new StatusUpdateHandler { ProductId=Product.Id });
            }
            AddProductEvent(Product.Id, new StatusUpdate(User.Update));
        }
        public static void UnRegister(IProduct Product, IUser User)
        {
            foreach (StatusUpdateHandler item in EventList)
            {
                if (item.ProductId == Product.Id)
                {
                    item.StatusHandler -= new StatusUpdate(User.Update);
                    break;
                }
            }
        }
        public static void Notify(IProduct Product)
        {
            foreach (StatusUpdateHandler item in EventList)
            {
                if (item.ProductId == Product.Id)
                {
                    item.StartEvent(Product.Update());
                    break;
                }
            }

        }
        public static void Notify(int id,string UpdateMessage)
        {
            foreach (StatusUpdateHandler item in EventList)
            {
                if (item.ProductId == id)
                {
                    item.StartEvent(UpdateMessage);
                    break;
                }
            }

        }
    }
}
