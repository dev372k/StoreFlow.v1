using Shared.Exceptions.Models;

namespace Shared.Exceptions
{
    public class CustomException(string message, CustomExceptionModel model) : Exception(message)
    {
        public CustomExceptionModel Model { get; } = model;
    }
}
