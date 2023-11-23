using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Nechinalka
    {
        public static List<nyda> Read(string path)
        {
            int i = 0;
            List<nyda> kakoitotxt = new List<nyda>();
            if (path[path.Length - 1] == 't')
            {
                string[] text = File.ReadAllLines(path);
                do
                {
                    nyda newFigure = new nyda(text[i], int.Parse(text[i + 1]), int.Parse(text[i + 2]));
                    kakoitotxt.Add(newFigure);
                    i += 3;
                } while (text.Length > i);
            }
            if (path[path.Length - 1] == 'n')
            {
                string Text = File.ReadAllText(path);
                kakoitotxt = JsonConvert.DeserializeObject<List<nyda>>(Text);
            }
            return kakoitotxt;
        }
        public static void Save(string path, List<nyda> kakoitotxt)
        {
            int i = 0, j = 0;
            string[] text = new string[9];

            if (path[path.Length - 1] == 't')
            {
                do
                {
                    text[i] = kakoitotxt[j].Chtoto;
                    text[i + 1] = kakoitotxt[j].Cifra1.ToString();
                    text[i + 2] = kakoitotxt[j].Cifra2.ToString();
                    i += 3;
                    j++;
                } while (text.Length > i);
                File.WriteAllLines(path, text);
            }
            if (path[path.Length - 1] == 'n')
            {
                string json = JsonConvert.SerializeObject(kakoitotxt);
                File.WriteAllText(path, json);
            }
        }
    }
}
