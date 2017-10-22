using DesignPatternAssignment7.Products;

namespace DesignPatternAssignment7.ChangeManagers
{
    class StatusUpdateHandler
    {
        public int ProductId { get; set; }
        public event StatusUpdate StatusHandler = null;

        public void StartEvent(string str)
        {
            StatusHandler(str);
        }
    }
}
