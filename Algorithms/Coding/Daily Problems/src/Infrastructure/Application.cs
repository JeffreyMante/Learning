namespace DailyProblems.src.Infrastructure
{
    public class Application
    {
        public static void Run<T>() where T : new()
        {
            new T();
        }
    }
}