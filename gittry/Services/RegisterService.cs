using gittry.Models;

namespace gittry.Services
{
    public class RegisterService
    {
        public bool Regist(UserModel userModel)
        {
            if (userModel.Name == "Leo" && userModel.Email == "leo604leo604@gmail.com")
                return true;
            return false;
        }
    }
}