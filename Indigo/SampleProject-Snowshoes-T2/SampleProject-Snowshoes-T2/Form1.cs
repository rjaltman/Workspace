using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SampleProject_Snowshoes_T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\ProjectSnowshoes\TechSquared.txt",richTextBox1.Text);
            saveButton.BackColor = Color.Green;
            saveButton.Text = "SAVED";

        }
    }
}
