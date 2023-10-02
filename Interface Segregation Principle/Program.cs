
namespace InterfaceSegregationPDemo
{
    interface ILogin
    {
        string Login(string username, string password);
        string Register(string username, string password, string email);
        void LogError(string error);
        bool SendEmail(string emailContent);
    };

    interface ILoginEmployee
    {
        string Login(string username, string password);
        string Register(string username, string password, string email);
    };


    public class Employee : ILoginEmployee
    {
        public string Login(string username, string password)
        {
            return ("Login completed successfully");
        }
        public string Register(string username, string password, string email)
        {
            return ("Register completed successfully");
        }

    }
}