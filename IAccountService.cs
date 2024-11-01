namespace AccountService
{
    internal interface IAccountService
    {

        void Register(User user)
        {
        }
        void Login(string username, string password) { }

        void Logout() { }

    }
}
