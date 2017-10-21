namespace DesignPatternAssignment7.Users
{
    interface IUser
    {
        string Name { get; set; }
        int UserId { get; set; }
        void Update(string Message);
    }
}
