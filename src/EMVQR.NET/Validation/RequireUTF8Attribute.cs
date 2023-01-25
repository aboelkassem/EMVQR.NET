using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StandardizedQR.Validation
{
    public sealed class RequireUTF8Attribute : ValidationAttribute
    {
        private const string UTF8EncodingName = "UTF-8";

        public override bool IsValid(object value)
        {
            var str = value as string;
            if (!string.IsNullOrWhiteSpace(str))
            {
                var bytes = Encoding.GetEncoding(UTF8EncodingName).GetBytes(str);
                var result = Encoding.GetEncoding(UTF8EncodingName).GetString(bytes);

                return string.Equals(str, result);
            }

            return true;
        }
    }
}
