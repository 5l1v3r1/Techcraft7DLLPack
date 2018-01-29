using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techcraft7_DLL_Pack;

namespace Techcraft7_DLL_Pack
{
    public class StringSwitcher
    {
        string name;
        bool debug = true;
        public string SwitchString;
        char[] chars = { '`', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '=', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', '[', ']', '\\', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', ';', '\'', 'z', 'x', 'c', 'v', 'b', 'n', 'm', ',', '.', '/', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', '{', '}', '|', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', ':', '"', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', '<', '>', '?', };
        string UnSwitchString = string.Empty;
        public StringSwitcher(string _name, bool _debug)
        {
            try
            {
                UnSwitchString = new string(chars);
                name = _name;
                debug = _debug;
                GenerateMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void GenerateMethod()
        {
            string output = string.Empty;
            Random rng = new Random();
            char[] array = { '`', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '=', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', '[', ']', '\\', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', ';', '\'', 'z', 'x', 'c', 'v', 'b', 'n', 'm', ',', '.', '/', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', '{', '}', '|', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', ':', '"', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', '<', '>', '?', };
            int n = chars.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = chars[k];
                array[k] = array[n];
                array[n] = value;
                output = new string(array);
                if (debug)
                {
                    ColorConsoleMethods.WriteLineColor(string.Format("n:{0}\nk:{1}\nvalue:{2}\noutput:{3}", n, k, value, output), ConsoleColor.DarkBlue);
                    if (debug)
                    {
                        Console.WriteLine(SwitchString);
                    }
                }
            }
            SwitchString = output;
        }
        public string Switch(string input)
        {
            string output = string.Empty;
            foreach (char i in input)
            {
                if (debug)
                {
                    ColorConsoleMethods.WriteLineColor(SwitchString.Length.ToString(), ConsoleColor.Green);
                }
                output += SwitchString.ToCharArray()[SwitchString.IndexOf(i)];
                if (debug)
                {
                    Console.WriteLine(output);
                }
            }
            return output;
        }
        public string UnSwitch(string input)
        {
            string output = string.Empty;
            foreach (char i in input)
            {
                output += UnSwitchString[SwitchString.IndexOf(i)];
            }
            return output;
        }
    }
}
