namespace AccountService
{
    internal class AccountService : IAccountService
    {
        static public List<User> _users = new List<User>();

        static public void Register(User user)
        {
            bool IsUsernameAlreadyUsed = false;
            foreach (var item in _users)
            {
                if (item.Username == user.Username)
                {
                    IsUsernameAlreadyUsed = true;
                    break;
                }
            }
            if (IsUsernameAlreadyUsed)
            {
                Console.WriteLine("Username already used");
                return;
            }
            if (user.Password == user.ConfirmPassword)
            {
                if (user.Password.Length >= 8)
                {

                    _users.Add(user);
                }
                else
                {
                    Console.WriteLine("Password is too short");
                }
            }
            else
            {
                Console.WriteLine("Password confirmed wrong try again");
                return;
            }
        }
        static public void Login(string username, string password)
        {

            var dataFound = _users.Find(f => f.Username == username && f.Password == password);
            if (dataFound != null && dataFound.IsLogin == false)
            {
                Logout();
                dataFound.IsLogin = true;
                Console.WriteLine("Login is successfull");
            }
            else
            {
                Console.WriteLine("Kill yourself");
            }


        }
        static public void Logout()
        {
            foreach (var user in _users)
            {
                user.IsLogin = false;
            }
        }



    }
}
