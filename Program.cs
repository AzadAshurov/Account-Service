namespace AccountService

{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Name = "Azad",
                Surname = "Ashurov",
                Password = "admin123",
                ConfirmPassword = "admin123",
                Username = "WertDrof"
            };
            User user2 = new User()
            {
                Name = "Azad2",
                Surname = "Ashurov",
                Password = "admin123",
                ConfirmPassword = "admin123",
                Username = "WertDrof"
            };

            AccountService.Register(user);
            AccountService.Register(user2);
            Console.WriteLine(AccountService._users[0].IsLogin);
            AccountService.Login("WertDrof", "admin123");
            Console.WriteLine(AccountService._users[0].IsLogin);
            AccountService.Logout();
            Console.WriteLine(AccountService._users[0].IsLogin);





        }
    }
}