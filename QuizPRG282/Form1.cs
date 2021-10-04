using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizPRG282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            List<string> text = new List<string>();
            
            text = File.ReadAllLines("text.txt").ToList();
            
            foreach (string line in text)
            {
                listBox1.Items.Add(line);
            }
        }
    }
}
