using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gittry.Models;
using gittry.Services;

namespace gittry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 註冊模組
            Console.WriteLine("歡迎使用者登入我們的GIT系統，請先輸入註冊訊息，以利後續登入做使用");
            while (true)
            {
                string name = Console.ReadLine();
                string email = Console.ReadLine();
                string account = Console.ReadLine();
                string password = Console.ReadLine();
                UserModel registerModel = new UserModel(name, email, account, password);
                RegisterService service = new RegisterService();
                bool isSuccess = service.Regist(registerModel);

                if (isSuccess)
                {
                    Console.WriteLine("註冊成功！");
                    break;
                }
                else
                {
                    Console.WriteLine("註冊失敗！請重新註冊！");
                }
            }
            #endregion

            #region 登入模組
        
            

            #endregion

        }
    }
}
