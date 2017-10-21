using DesignPatternAssignment7.ChangeManagers;
using DesignPatternAssignment7.Users;

namespace DesignPatternAssignment7.Products
{
    abstract class Product:IProduct
    {
        public event StatusUpdate StatusHandler = null;
  
        private float _price;
        private int _amountInStock;
        private float? _discount;
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
                this.Notify();
            }
        }
        public int AmountInStock
        {
            get
            {
                return this._amountInStock;
            }
            set
            {
                this._amountInStock = value;
                this.Notify();
            }
        }
        public float? Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                this._discount = value;
                this.Notify();
            }
        }
        
        public string Update()
        {
            return "The Product "+Name+" With Id: "+Id+" has a price of "+ Price+". with discount "+Discount+
                "\n There are currently "+AmountInStock+" Items in Stock";
        }

        public void AttachObserver(IUser User)
        {
            ChangeManager.Register(this, User);
        }
        public void DetachObserver(IUser User)
        {
            ChangeManager.UnRegister(this, User);
        }
        public void Notify()
        {
            if (this.StatusHandler != null)  
                ChangeManager.Notify(this);
        }
        public void StartEvent(string str)
        {
            StatusHandler(str);
        }
    }
}
