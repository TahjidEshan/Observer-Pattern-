
namespace DesignPatternAssignment7.ChangeManagers
{
    public delegate void StatusUpdate(string StatusUpdate);
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
