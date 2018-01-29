using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techcraft7_DLL_Pack
{
    public class ConsoleString
    {
        public string value;
        public string name;
        public override string ToString()
        {
            return string.Format("ConsoleString: name: {0} value:\n{{1}\n}", name, value);
        }
        public void Write(string input)
        {
            value += input;
        }
        public void WriteLine(string input)
        {
            value += input + "\n";
        }
        public void Clear()
        {
            value = string.Empty;
        }
    }
}
