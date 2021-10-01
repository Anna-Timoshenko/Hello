using Softeq.XToolkit.Common.Converters;

namespace Hello
{
    public class IntToStringConverter : IConverter<string, int>
    {
        public static IntToStringConverter Instance { get; } = new IntToStringConverter();

        public string ConvertValue(int value, object? parameter = null, string? language = null)
        {
            return value.ToString();
        }

        public int ConvertValueBack(string value, object? parameter = null, string? language = null)
        {
            return int.Parse(value);
        }
    }
}
