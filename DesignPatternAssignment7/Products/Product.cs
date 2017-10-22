using DesignPatternAssignment7.ChangeManagers;
using DesignPatternAssignment7.Users;

namespace DesignPatternAssignment7.Products
{
    abstract class Product:IProduct
    {
        private float _price;
        private int _amountInStock;
        private float? _discount;
        private string message;
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
                this.message = "Update Message:Price Changed From "+ this._price+ " to "+ value + "\n";
                this._price = value;
                this.Notify(this.Update() + this.message);
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
                this.message = "Update Message:Amount in Stock Changed From " + this._amountInStock + " to " + value + "\n";
                this._amountInStock = value;
                this.Notify(this.Update() + this.message);
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
                this.message = "Update Message:Discount Changed From " + this._discount + " to " + value+"\n";
                this._discount = value;
                this.Notify(this.Update() + this.message);
            }
        }
        
        public string Update()
        {
            return "The Product "+Name+" With Id: "+Id+" with a base price of "+ Price+". with discount "+Discount+
                "\nThere are currently "+AmountInStock+" Items in Stock.\n";
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
            ChangeManager.Notify(this);
        }
        public void Notify(string message)
        {
            ChangeManager.Notify(this.Id, message);
        }

    }
}
