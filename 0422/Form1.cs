using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0422
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요!", "HELLO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이미지입니다!", "이미지");
        }
    }
}
