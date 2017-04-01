using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void جلبملفExeclToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 ff = new Form4();
            ff.Show();
        }

        private void إضافةمستفيدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 rr = new Form14();
            rr.Show();
        }

       

        private void حدفمستفيدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 fff = new Form6();
            fff.Show();
        }

        private void عرضالمستفيدينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 ll = new Form7();
            ll.Show();
        }

        private void تدبيرالمقاعدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void عرضحسبالمعدلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 nn = new Form8();
            nn.Show();
        }

        private void بحتعنمستفيدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 mm = new Form10();
            mm.Show();
        }

        private void تدبيرالمقاعدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 hh = new Form9();
            hh.Show();
        }

        private void الممنوحينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 nn = new Form11();
            nn.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 ta = new Form12();
            ta.Show();
        }

        private void سجلالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 lk = new Form13();
            lk.Show();
        }

        private void تدبيرمقاعدالإناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 ss = new Form15();
            ss.Show();
        }

       
    }
}
