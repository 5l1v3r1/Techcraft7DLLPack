using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techcraft7_DLL_Pack
{
    public static class ColorConsoleMethods
    {
#region Write/WriteLine
#region FG
        public static void WriteColor(string text, ConsoleColor color)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = prev;
        }
        public static void WriteLineColor(string text, ConsoleColor color)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = prev;
        }
        public static void WriteMultiColor(string[] strings, ConsoleColor[] colors)
        {
            ConsoleColor prev = Console.ForegroundColor;
            try
            {
                if (strings.Length >= colors.Length)
                {
                    foreach (string i in strings)
                    {
                        Console.ForegroundColor = colors[Array.IndexOf(strings.ToArray(), i)];
                        Console.Write(i);
                    }
                    Console.ForegroundColor = prev;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("An error has occured in ColorConsoleMethods.dll of type of:\nTechcraft7_DLL_Pack.ColorConsoleMethods.InvalidLength\nPlease make sure that the length of the input string is equal to the length of the color input array.");
                    Console.WriteLine(string.Format("The length of the input string is {0}.\nThe length of the color input is {1}.", strings.Length, colors.Length));
                    Console.Read();
                }
                Console.ForegroundColor = prev;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
        public static void WriteLineMultiColor(string[] strings, ConsoleColor[] colors)
        {
            ConsoleColor prev = Console.ForegroundColor;
            try
            {
                if (strings.Length >= colors.Length)
                {
                    foreach (string i in strings)
                    {
                        Console.ForegroundColor = colors[Array.IndexOf(strings.ToArray(), i)];
                        Console.Write(i);
                    }
                    Console.ForegroundColor = prev;
                    Console.WriteLine(string.Empty);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("An error has occured in ColorConsoleMethods.dll of type of:\nTechcraft7_DLL_Pack.ColorConsoleMethods.InvalidLength\nPlease make sure that the length of the input string is equal to the length of the color input array.");
                    Console.WriteLine(string.Format("The length of the input string is {0}.\nThe length of the color input is {1}.", strings.Length, colors.Length));
                    Console.Read();
                }
                Console.ForegroundColor = prev;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
        #endregion
#region BG
        public static void WriteBGColor(string text, ConsoleColor color)
        {
            ConsoleColor prev = Console.BackgroundColor;
            Console.BackgroundColor = color;
            Console.Write(text);
            Console.BackgroundColor = prev;
        }
        public static void WriteLineBGColor(string text, ConsoleColor color)
        {
            ConsoleColor prev = Console.BackgroundColor;
            Console.BackgroundColor = color;
            Console.WriteLine(text);
            Console.BackgroundColor = prev;
        }
        public static void WriteMultiBGColor(string[] strings, ConsoleColor[] colors)
        {
            ConsoleColor prev = Console.BackgroundColor;
            try
            {
                if (strings.Length >= colors.Length)
                {
                    foreach (string i in strings)
                    {
                        Console.BackgroundColor = colors[Array.IndexOf(strings.ToArray(), i)];
                        Console.Write(i);
                    }
                    Console.BackgroundColor = prev;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("An error has occured in ColorConsoleMethods.dll of type of:\nTechcraft7_DLL_Pack.ColorConsoleMethods.InvalidLength\nPlease make sure that the length of the input string is equal to the length of the color input array.");
                    Console.WriteLine(string.Format("The length of the input string is {0}.\nThe length of the color input is {1}.", strings.Length, colors.Length));
                    Console.Read();
                }
                Console.BackgroundColor = prev;
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
        public static void WriteLineMultiBGColor(string[] strings, ConsoleColor[] colors)
        {
            ConsoleColor prev = Console.BackgroundColor;
            try
            {
                if (strings.Length >= colors.Length)
                {
                    foreach (string i in strings)
                    {
                        Console.BackgroundColor = colors[Array.IndexOf(strings.ToArray(), i)];
                        Console.Write(i);
                    }
                    Console.BackgroundColor = prev;
                    Console.WriteLine(string.Empty);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("An error has occured in ColorConsoleMethods.dll of type of:\nTechcraft7_DLL_Pack.ColorConsoleMethods.InvalidLength\nPlease make sure that the length of the input string is equal to the length of the color input array.");
                    Console.WriteLine(string.Format("The length of the input string is {0}.\nThe length of the color input is {1}.", strings.Length, colors.Length));
                    Console.Read();
                }
                Console.BackgroundColor = prev;
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
        #endregion
#region BGandFG
        public static void WriteBGandFGcolor(string text, ConsoleColor bg, ConsoleColor fg)
        {
            ConsoleColor bgprev = Console.BackgroundColor;
            ConsoleColor fgprev = Console.ForegroundColor;
            Console.Write(text);
            Console.BackgroundColor = bgprev;
            Console.ForegroundColor = fgprev;
        }
        public static void WriteLineBGandFGcolor(string text, ConsoleColor bg, ConsoleColor fg)
        {
            ConsoleColor bgprev = Console.BackgroundColor;
            ConsoleColor fgprev = Console.ForegroundColor;
            Console.WriteLine(text);
            Console.BackgroundColor = bgprev;
            Console.ForegroundColor = fgprev;
        }
        public static void WriteMultiBGandFGColor(string[] strings, ConsoleColor[] fgs, ConsoleColor[] bgs)
        {
            ConsoleColor bgprev = Console.BackgroundColor;
            ConsoleColor fgprev = Console.ForegroundColor;
            try
            {
                if (strings.Length >= fgs.Length && strings.Length >= bgs.Length)
                {
                    foreach (string i in strings)
                    {
                        Console.ForegroundColor = fgs[Array.IndexOf(strings.ToArray(), i)];
                        Console.BackgroundColor = bgs[Array.IndexOf(strings.ToArray(), i)];
                        Console.Write(i);
                    }
                    Console.BackgroundColor = bgprev;
                    Console.ForegroundColor = fgprev;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("An error has occured in ColorConsoleMethods.dll of type of:\nTechcraft7_DLL_Pack.ColorConsoleMethods.InvalidLength\nPlease make sure that the length of the input string is equal to the length of the color input array.");
                    Console.WriteLine(string.Format("The length of the input string is {0}.\nThe length of the bg input is {1}.\nThe length of the fg input is {2}.", strings.Length, bgs.Length, fgs.Length));
                    Console.Read();
                }
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.Read();
            }
            finally
            {
                Console.BackgroundColor = bgprev;
                Console.ForegroundColor = fgprev;
            }
        }
        public static void WriteLineMultiBGandFGColor(string[] strings, ConsoleColor[] fgs, ConsoleColor[] bgs)
        {
            ConsoleColor bgprev = Console.BackgroundColor;
            ConsoleColor fgprev = Console.ForegroundColor;
            try
            {
                if (strings.Length >= fgs.Length && strings.Length >= bgs.Length)
                {
                    foreach (string i in strings)
                    {
                        Console.ForegroundColor = fgs[Array.IndexOf(strings.ToArray(), i)];
                        Console.BackgroundColor = bgs[Array.IndexOf(strings.ToArray(), i)];
                        Console.Write(i);
                    }
                    Console.BackgroundColor = bgprev;
                    Console.ForegroundColor = fgprev;
                    Console.WriteLine(string.Empty);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("An error has occured in ColorConsoleMethods.dll of type of:\nTechcraft7_DLL_Pack.ColorConsoleMethods.InvalidLength\nPlease make sure that the length of the input string is equal to the length of the color input array.");
                    Console.WriteLine(string.Format("The length of the input string is {0}.\nThe length of the bg input is {1}.\nThe length of the fg input is {2}.", strings.Length, bgs.Length, fgs.Length));
                    Console.Read();
                }
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(e.Message);
                Console.Read();
            }
            finally
            {
                Console.BackgroundColor = bgprev;
                Console.ForegroundColor = fgprev;
            }
        }
            #endregion
            #endregion
#region Read/ReadLine
            public static int ReadColor(ConsoleColor color)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            int output = Console.Read();
            Console.ForegroundColor = prev;
            return output;
        }
        public static string ReadLineColor(ConsoleColor color)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            string output = Console.ReadLine();
            Console.ForegroundColor = prev;
            return output;
        }
        public static int ReadBGColor(ConsoleColor color)
        {
            ConsoleColor prev = Console.BackgroundColor;
            Console.BackgroundColor = color;
            int output = Console.Read();
            Console.BackgroundColor = prev;
            return output;
        }
        public static string ReadLineBGColor(ConsoleColor color)
        {
            ConsoleColor prev = Console.BackgroundColor;
            Console.BackgroundColor = color;
            string output = Console.ReadLine();
            Console.BackgroundColor = prev;
            return output;
        }
        #endregion
    }
}