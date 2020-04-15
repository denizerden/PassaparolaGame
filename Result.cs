using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola2
{
    public partial class Result : Form
    {
        public Result(int corrects, int wrongs,int totalPoints, int time)
        {
            InitializeComponent();
            correct.Text = corrects.ToString();
            wrong.Text = wrongs.ToString();
            timeLeft.Text = time.ToString();
            totalPoint.Text = totalPoints.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 f = new Form1();
            f.Show();
        }
        private void Result_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
