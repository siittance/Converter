using System.Globalization;
using System.Text;
using static System.Console;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            InputEncoding = Encoding.UTF8;
            OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, World!");
        }
    }
}