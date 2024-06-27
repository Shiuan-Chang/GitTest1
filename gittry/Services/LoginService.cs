using gittry.Models;

namespace gittry.Services
{
    internal class LoginService
    {
        
        
        public bool Login(UserModel userModel)
        {
            if (userModel.Name == "Leo" && userModel.Email == "leo604leo604@gmail.com" && userModel.Password == "abc")
                return true;
            return false;
        }



    }
}
