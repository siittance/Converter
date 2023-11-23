using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Chinalka
    {
        public static List<nyda> Change(List<nyda> kakoitotxt)
        {
            string[] text = new string[9];
            int i = 0, j = 0;
            int position = 2;
            ConsoleKeyInfo key;
            do
            {
                text[i] = kakoitotxt[j].Chtoto;
                text[i + 1] = kakoitotxt[j].Cifra1.ToString();
                text[i + 2] = kakoitotxt[j].Cifra2.ToString();
                i += 3;
                j++;
            } while (text.Length > i);
            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Сохранить файл в одном из форматов: tХt, jsОn - F1. Попрощаться :_) - Escape");
                Console.WriteLine("=====================================================================");

                j = 2;
                foreach (string smth in text)
                {
                    Console.SetCursorPosition(0, j);
                    Console.WriteLine("  " + smth);
                    j++;
                }
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.Write("  ");
                if (key.Key == ConsoleKey.UpArrow && position >= 3)
                {
                    position--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Write("                       ");
                    Console.SetCursorPosition(2, position);
                    string change = Console.ReadLine();
                    text[position - 2] = change;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            } while (key.Key != ConsoleKey.F1);
            i = 0;
            kakoitotxt.Clear();
            do
            {
                nyda newFigure = new nyda(text[i], int.Parse(text[i + 1]), int.Parse(text[i + 2]));
                kakoitotxt.Add(newFigure);
                i += 3;
            } while (text.Length > i);
            return kakoitotxt;
        }
    }
}

