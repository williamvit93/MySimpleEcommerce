using System.Linq;

namespace WaTecnologia.MySimpleEcommerce.Domain.Services
{
    public static class CPFServices
    {
        public static string FormatCPF(string number)
        {
            return string.Concat(number.Where(char.IsDigit));
        }

        public static bool IsValid(string number)
        {
            return number.Length == 11;
        }
    }
}
