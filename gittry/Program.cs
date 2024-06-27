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
            UserModel userModel = new UserModel("Leo","leo604leo604@gmail.com","高雄市","abc123");
            RegisterService service = new RegisterService();
            service.Regist(userModel);
            Console.ReadKey();

            Console.WriteLine("請輸入使用者名稱");
            string inputUserName = Console.ReadLine();
            Console.WriteLine("請輸入使用者密碼");
            string inputUserPassword = Console.ReadLine();

        }
    }
}
