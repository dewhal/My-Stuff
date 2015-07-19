using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegExManager
{
    public partial class Form1 : Form
    {
        Regex rx;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi;

            foreach (string s in txtRawData.Lines)
            {

                Match match = Regex.Match(s.ToString(), txtRegEx.Text);

                Console.WriteLine(match.Groups["date"]);
                Console.WriteLine(match.Groups["desc"]);




                //listView1.Items.Add(
            }

        }
    }
}
