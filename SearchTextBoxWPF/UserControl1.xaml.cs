using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SearchTextBoxWPF
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class SearchTextBoxWPF : UserControl
    {
        public List<string> items = new List<string>();
        public SearchTextBoxWPF()
        {
            InitializeComponent();
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string ResultString = string.Empty;
                List<string> results = new List<string>();
                foreach (string i in items)
                {
                    if (textBox1.Text.ToUpper() == i.Substring(0, textBox1.Text.Length).ToUpper())
                    {
                        results.Add(i);
                    }
                }
                if (textBox1.Text != "")
                {
                    foreach (string i in results)
                    {
                        ResultString += string.Format("{0}\n", i);
                    }
                    label1.Content = string.Format("Results:\n{0}", ResultString);
                    if (label1.Height > (this.Height - label1.Height))
                    {
                        this.Height = label1.Height + label1.Height;
                    }
                }
                else
                {
                    label1.Content = "Results:";
                }
            }
            catch (Exception foo)
            {
            }
        }
    }
}
