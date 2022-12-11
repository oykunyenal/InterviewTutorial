using InverviewTutorial.FuncActionEventDelegate.RequestCreaters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InverviewTutorial.FuncActionEventDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPostRequestCreator getPostRequestCreator = new GetPostRequestCreator();

            var posts = getPostRequestCreator.GetPosts();

            MessageBox.Show("----> " + posts.FirstOrDefault().title);

        }
    }
}
