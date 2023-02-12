using Xunit;

namespace EMVQR.XUnitTests
{
    internal static class AssertUtils
    {
        public static string AssertThatContainsAndRemove(string actual, string expected)
        {
            Assert.Contains(expected, actual);
            return actual.Replace(expected, string.Empty);
        }
    }
}
