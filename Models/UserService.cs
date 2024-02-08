namespace HousingProjectAPI.Models
{
    public class UserService
    {
        public User Authenticate(string username,string password)
        {
            if(username == "jeni" && password =="jeni123")
            {
                return new User { Id = 1, Username = "jeni" };
            }
            return null;
        }
    }
}
