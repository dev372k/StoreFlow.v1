namespace Shared.Helpers
{
    public class ConversionHelper
    {
        public static T ConvertTo<T>(object value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
