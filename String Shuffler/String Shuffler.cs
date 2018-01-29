using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techcraft7_DLL_Pack
{
    public class StringShuffler
    {
        string name;
        string output;
        bool debug = false;
        public StringShuffler(string _name, bool _debug)
        {
            name = _name;
            debug = _debug;
        }
        public override string ToString()
        {
            return string.Format("String Shuffler: name: {0}", name);
        }   
        public string ShuffleSingleLine(string input)
        {
            ///<summary>
            ///<para>Shuffles a single line string</para>
            ///</summary>
            char[] array = input.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }
        public string ShuffleMultiLine(params string[] lines)
        {
            ///<summary>
            ///<para>Shuffles an array of single line strings to make a multi line string</para>
            ///</summary>
            char[] array = { };
            Random rng = new Random();
            int n;
            string output = string.Empty;
            List<string> foo = new List<string>();
            foreach (string i in lines)
            {
                array = i.ToCharArray();
                n = array.Length;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    var value = array[k];
                    array[k] = array[n];
                    array[n] = value;
                }
                foo.Add(new string(array));
                foo.Add("\n");
            }
            foreach (string i in foo)
            {
                output += i;
            }
            return output;
        }
        public string ShuffleMultiLine(List<string> lines)
        {
            ///<summary>
            ///<para>Shuffles a List of single line strings to make a multi line string</para>
            ///</summary>
            char[] array = { };
            Random rng = new Random();
            int n;
            string output = string.Empty;
            List<string> foo = new List<string>();
            foreach (string i in lines)
            {
                array = i.ToCharArray();
                n = array.Length;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    var value = array[k];
                    array[k] = array[n];
                    array[n] = value;
                }
                foo.Add(new string(array));
                foo.Add("\n");
            }
            foreach (string i in foo)
            {
                output += i;
            }
            return output;
        }
    }
}
