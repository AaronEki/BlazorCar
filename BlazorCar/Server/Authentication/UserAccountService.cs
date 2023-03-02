namespace BlazorCar.Server.Authentication
{
    public class UserAccountService
    {
        //private variable to temporarily save the user data in memory
        private List<UserAccount> _userAccountList;

        //constructor for the UserAccountService
        public UserAccountService()
        {
            //hardcoding users - in practice this should be done with a seperate database - using salted hashes of the passwords and NOT stored in plaintext
            _userAccountList = new List<UserAccount> {
                new UserAccount { UserName = "admin", Password = "admin", Role = "Administrator" },
                new UserAccount { UserName = "user", Password = "user", Role = "user" }
            };            
        }

        //implementing a method to get the user account details filtering by their username
        public UserAccount? GetUserAccountByUserName(string userName)
        {
            return _userAccountList.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
