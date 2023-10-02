
namespace SRPDemo
{
    interface ILogin
    {
        bool Login(string username, string password);
    };

    interface IRegister
    {
        bool Register(string username, string password, string email);
    };

    interface ILoggerr
    {
        void LogError(string error);
    };
    interface IEmail
    {
        bool SendEmail(string emailContent);
    }

    // Второй блок демонстрации
    class Navigation
    {
        public void GoToFirstPage() =>
            Console.WriteLine("Переход к первой странице");

        public void GoToLastPage() =>
            Console.WriteLine("Переход к последней странице");

        public void GoToPage(int pageNumber) =>
            Console.WriteLine($"Переход к странице {pageNumber}");
    }

    class Printer
    {
        public void PrintReport(Navigation report)
        {
            Console.WriteLine("Печать отчета");
        }
    }
}


