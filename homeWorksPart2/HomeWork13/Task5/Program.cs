namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();

            Service service = new Service(consoleLogger);
            service.Log("aaaaaaaaaa");

            ILogger fileLogger = new FileLogger();

            Service service1 = new Service(fileLogger);
            service1.Log("bbbbbbbbbbbbbbb");

        }
    }


    public interface ILogger
    {
        public void Log(string message);
    }


    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        { 
            Console.WriteLine($"ConsoleLogger {message} ");
        }
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"FileLogger {message} ");
        }
    }

    public class Service
    {

        private ILogger Logger;
        public Service(ILogger logger)
        {
            Logger = logger;
        }

        public void Log(string message)
        {
            Logger.Log(message);
        }

    }
}
