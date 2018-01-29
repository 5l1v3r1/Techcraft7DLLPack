using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techcraft7_DLL_Pack;

namespace Techcraft7_DLL_Pack
{
    public class SearchEngine
    {
        public bool DebugMode = false;
        string name;
        List<string> items = new List<string>();
        int LengthOfItems;
        public SearchEngine(string inname, bool _DebugMode)
        {
            name = inname;
            DebugMode = _DebugMode;
            LengthOfItems = items.Count;
        }
        public override string ToString()
        {
            string foo = string.Format("SearcheEngine: name: {0} items: DebugMode: {1}", name, DebugMode);
            foreach (string i in items)
            {
                if (items.IndexOf(i) != LengthOfItems - 1)
                {
                    foo += string.Format("{0}, ", i);
                }
                else
                {
                    foo += i;
                }
            }
            return foo;
        }
        public void AddItems(params string[] input)
        {
            foreach (string i in input)
            {
                items.Add(i);
            }
            LengthOfItems = items.Count;
        }
        public void RemoveItems(params int[] indexes)
        {
            int before_legth = indexes.Length;
            bool itteration_one = true;
            foreach (int i in indexes)
            {
                if (itteration_one == true)
                {
                    items.RemoveAt(i);
                    itteration_one = false;
                }
                else
                {
                    int after_length = items.Count - indexes.Length;
                    int defference = before_legth - after_length;
                    items.RemoveAt(i - defference);
                }
            }
            LengthOfItems = items.Count;
        }
        public List<string> Search(string input)
        {
            List<string> results = new List<string>();
            List<string> ItemStrings = new List<string>();
            List<char> InputUpper = new List<char>();
            try
            {
                foreach (char i in input.ToUpper())
                {
                    if (DebugMode)
                    {
                        Console.WriteLine(i);
                    }
                    InputUpper.Add(i);
                }
                foreach (string a in items)
                {
                    ItemStrings.Add(a.ToUpper());
                    if (DebugMode)
                    {
                        Console.WriteLine(a);
                    }
                }
                foreach (string a in items)
                {
                    if (DebugMode)
                    {
                        Console.WriteLine(a);
                    }
                    string first2input = input.Length >= 2 ? InputUpper[0] + InputUpper[1].ToString() : InputUpper[0].ToString();
                    string first2a = a[0] + a[1].ToString();
                    if (DebugMode)
                    {
                        Console.WriteLine("first2input:{1}\nfirst2a:{0}", first2a, first2input);
                    }
                    bool test = (first2a.ToUpper() == first2input.ToUpper() || first2a.ToUpper()[0] == first2input.ToUpper()[0]);
                    if (first2a.ToUpper() == first2input.ToUpper() || first2a.ToUpper()[0] == first2input.ToUpper()[0])
                    {
                        if (DebugMode && test)
                        {
                            ConsoleColor[] foo2 = { ConsoleColor.White, ConsoleColor.Green };
                            string[] foo = { "first2a.ToUpper() == first2input.ToUpper() || first2a.ToUpper()[0] == first2input.ToUpper()[0] = ", string.Format("{0}", test) };
                            ColorConsoleMethods.WriteLineMultiColor(foo, foo2);
                        }
                        results.Add(a);
                    }
                    else
                    {
                        if (DebugMode)
                        {
                            ConsoleColor[] foo2 = { ConsoleColor.White, ConsoleColor.Red };
                            string[] foo = { "first2a.ToUpper() == first2input.ToUpper() || first2a.ToUpper()[0] == first2input.ToUpper()[0] = ", string.Format("{0}", test) };
                            ColorConsoleMethods.WriteLineMultiColor(foo, foo2);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                ColorConsoleMethods.WriteLineColor(e.Message, ConsoleColor.Red);
            }
            if (DebugMode)
            {
                Console.WriteLine("\n\n\nReturning results...\n\n\n");
            }
            return results;
        }
    }
}