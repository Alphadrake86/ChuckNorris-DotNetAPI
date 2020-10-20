using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuck_norris_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            string[] Categories = (await ChuckNorrisClient.GetCategories()).ToArray();

            listBox1.Items.AddRange(Categories);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label2.Text = (await ChuckNorrisClient.GetRandomJoke()).JokeText;
        }
    }
}
