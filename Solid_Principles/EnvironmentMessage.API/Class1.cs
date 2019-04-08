using System;

namespace EnvironmentMessage.API
{
    public interface IEnvironment
    {
        string BuildMessage(string message);

    }

    public class ProductionEnvironment : IEnvironment
    {
        public string BuildMessage(string message)
        {
            return $"Production Message : {message}";
        }
    }

    class QaEnvironment : IEnvironment
    {
        public string BuildMessage(string message)
        {
            return $"Qa Message : {message}";
        }
    }


    class DevelopmentEnvironment : IEnvironment
    {
        public string BuildMessage(string message)
        {
            return $"Development Server :  Message : {message}";
        }
    }

    public class ExceptionMessageToUser
    {
        private readonly string _createdMessage;
        public ExceptionMessageToUser(IEnvironment environment, string message)
        {
            _createdMessage = environment.BuildMessage(message);
        }

        public void ShowConsoleMessage()
        {
            Console.WriteLine(_createdMessage);
        }
    }
}
