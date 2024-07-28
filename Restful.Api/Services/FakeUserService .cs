namespace Restful.Api.Services
{
    public class FakeUserService : IUserService
    {
        public bool ValidateUser(string username, string password)
        {
            return username == "admin" && password == "password";
        }
    }
}
