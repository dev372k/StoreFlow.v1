namespace Shared.Exceptions.Models
{
    public class CustomExceptionModel
    {
        public string Message { get; set; } = string.Empty;
        public int StatusCode { get; set; }
    }
}
