using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OsuLocalizationCorruptor
{
    class LocalizationFile
    {
        internal string Path;
        internal Dictionary<string, string> Content = new Dictionary<string, string>();

        internal void MessWords(int times = 1, int percent = 100)
        {
            Random r = new Random();
            var lastMessWords = new List<List<string>>();

            for (int i = 0; i < times; i++)
            {
                foreach (var e in new Dictionary<string, string>(Content))
                {
                    if (r.Next(101) > percent) continue;

                    var words = new List<string>(e.Value.Split(' '));
                    int k = r.Next(words.Count);
                    string word = words[k];

                    if (lastMessWords.Count != 0 && (!word.Contains("{") || !word.Contains("}")) && !int.TryParse(word, out int a))
                    {
                        var replaced = new List<string>(lastMessWords[r.Next(lastMessWords.Count)]);
                        string rword = replaced[r.Next(replaced.Count)];
                        words[k] = rword;
                        if((!rword.Contains("{") || !rword.Contains("}")) && !int.TryParse(rword, out a))
                            Content[e.Key] = string.Join(" ", words);
                    }
                    
                    lastMessWords.Add(words);
                }
            }
        }

        internal void Shuffle(int percent = 100)
        {
            Random r = new Random();
            var s = new List<string>(Content.Values);
            s.Sort((i, i2) => r.Next(-1, 2));

            int id = 0;
            foreach (string k in new List<string>(Content.Keys))
            {
                if (r.Next(101) < percent)
                    Content[k] = s[id];
                id++;
            }
        }

        internal void ReplaceAll(string value)
        {
            foreach (var e in new Dictionary<string, string>(Content))
                Content[e.Key] = value;
        }

        internal void Generate()
        {
            Random r = new Random();

            foreach (var e in new Dictionary<string, string>(Content))
            {
                byte[] bytes = new byte[256];
                r.NextBytes(bytes);
                Content[e.Key] = Encoding.ASCII.GetString(bytes).Replace('=', ':').Replace('{', '[').Replace('}', ']').Substring(0, 16);
            }
        }

        internal void Backup()
        {
            File.Copy(Path, Path + ".backup", true);
        }

        internal void Restore()
        {
            if(File.Exists(Path + ".backup"))
                File.Copy(Path + ".backup", Path, true);
        }

        internal void Save()
        {
            File.Delete(Path);
            using (var w = File.OpenWrite(Path))
            using (var sw = new StreamWriter(w))
            {
                foreach (var e in Content)
                    sw.WriteLine($"{e.Key}={e.Value}");
                sw.Flush();
            }
        }

        internal static LocalizationFile Load(string path)
        {
            var l = new LocalizationFile();
            string[] data = File.ReadAllLines(path);
            l.Path = path;

            foreach(string s in data)
            {
                string[] k = s.Split(new char[] { '=' }, 2);
                if (k.Length < 2) continue;

                l.Content.Add(k[0], k[1]);
            }

            return l;
        }
    }
}
