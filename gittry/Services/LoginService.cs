using gittry.Models;

namespace gittry.Services
{
    internal class LoginService
    {
        public bool Login(UserModel userModel)
        {
            if (userModel.Name == "Leo" && userModel.Email == "leo604leo604@gmail.com" && userModel.Password == "123")
                return true;
            return false;
        }

    }
}
