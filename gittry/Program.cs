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
            Console.WriteLine("歡迎使用系統！ 請先進行帳號註冊：");
            UserModel userModel = new UserModel( Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            RegisterService service = new RegisterService();
            service.Regist(userModel);
            
            Console.WriteLine("註冊成功！");
            Console.ReadKey();

            Console.WriteLine("請輸入使用者名稱");
            string inputUserName = Console.ReadLine();
            Console.WriteLine("請輸入使用者密碼");
            string inputUserPassword = Console.ReadLine();

        }
    }
}
