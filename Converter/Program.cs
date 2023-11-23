using System.Globalization;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите путь до файла + позывной, который вы хотите открыть");
            Console.WriteLine("=====================================================================");
            List<nyda> kakoitotxt = Nechinalka.Read(Console.ReadLine());
            kakoitotxt = Chinalka.Change(kakoitotxt);
            Console.Clear();
            Console.WriteLine("Введите путь до файла + позывной, куда вы хотите сохранить текст");
            Console.WriteLine("=====================================================================");
            Nechinalka.Save(Console.ReadLine(), kakoitotxt);
        }
    }
}
