namespace WebApplication11.Service
{
    public class Myservice : IMyservice
    {
        public string GetMessage()
        {
            return "Hello from Myservice using Dependency Injection";
        }
    }
}
