using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchTextBox
{
    public partial class SearchTextBox: UserControl
    {
        public List<string> items = new List<string>();
        public SearchTextBox()
        {
            InitializeComponent();
        }
        public void AddItems(params string[] input)
        {
            foreach (string i in input)
            {
                try
                {
                    items.Add(i);
                }
                catch (Exception e)
                {

                }
            }
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
                        int after_length = indexes.Length;
                        int defference = before_legth - after_length;
                        items.RemoveAt(i - defference);
                    }
                }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
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
                    label1.Text = string.Format("Results:\n{0}", ResultString);
                    if (label1.Height > (Size.Height - label1.Location.Y))
                    {
                        Size = new Size(150, label1.Location.Y + label1.Height);
                    }
                }
                else
                {
                    label1.Text = "Results:";
                }
            }
            catch (Exception foo)
            {
            }
        }
    }
}
