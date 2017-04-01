using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            Program.cn.Open();
            Program.cmd = new SqlCommand("select count(*) from eleve where GenreAr='ذكر'", Program.cn);
            label1.Text = Program.cmd.ExecuteScalar().ToString();

            Program.cmd = new SqlCommand("select count(*) from eleve where GenreAr='أنثى'", Program.cn);
            label2.Text = Program.cmd.ExecuteScalar().ToString();
            Program.cn.Close();
        }

      

      

        private void Form13_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            Program.cn.Open();
            Program.cmd = new SqlCommand("select nomcer from cercle", Program.cn);

            Program.dr = Program.cmd.ExecuteReader();
            while (Program.dr.Read())
            {
                comboBox1.Items.Add(Program.dr[0]);

            }

            Program.dr.Close();
            Program.cn.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Program.cn.Open();
            Program.cmd = new SqlCommand("select count(*) from  eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer  and ce.nomcer='" + comboBox1.Text + "' and el.GenreAr='ذكر'", Program.cn);
            label1.Text = Program.cmd.ExecuteScalar().ToString();

            Program.cmd = new SqlCommand("select count(*) from  eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer  and ce.nomcer='" + comboBox1.Text + "' and el.GenreAr='أنثى'", Program.cn);
            label2.Text = Program.cmd.ExecuteScalar().ToString();
            Program.cn.Close();

            Program.cn.Open();
            Program.cmd = new SqlCommand("select c.LA_COM from coumun c , cercle cu where c.idcer=cu.idcer and nomcer='" + comboBox1.Text + "'", Program.cn);

            Program.dr = Program.cmd.ExecuteReader();
            while (Program.dr.Read())
            {
                comboBox2.Items.Add(Program.dr[0]);

            }
            Program.dr.Close();
            Program.cn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.cn.Open();
            Program.cmd = new SqlCommand("select count(*) from eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer and co.LA_COM ='" + comboBox2.Text + "' and el.GenreAr='ذكر'", Program.cn);
            label1.Text = Program.cmd.ExecuteScalar().ToString();

            Program.cmd = new SqlCommand("select count(*) from eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer and co.LA_COM ='" + comboBox2.Text + "' and el.GenreAr='أنثى'", Program.cn);
            label2.Text = Program.cmd.ExecuteScalar().ToString();
            Program.cn.Close();
            Program.cn.Open();
            Program.cmd = new SqlCommand("select c.NOM_ETABA from ecole c , coumun cu where c.CD_COM =cu.CD_COM  and cu.LA_COM ='" + comboBox2.Text + "'", Program.cn);

            Program.dr = Program.cmd.ExecuteReader();
            while (Program.dr.Read())
            {
                comboBox3.Items.Add(Program.dr[0]);

            }
            Program.dr.Close();
            Program.cn.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.cn.Open();
            Program.cmd = new SqlCommand("select count(*) from eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer and ec.NOM_ETABA='" + comboBox3.Text + "' and el.GenreAr='ذكر'", Program.cn);
            label1.Text = Program.cmd.ExecuteScalar().ToString();

            Program.cmd = new SqlCommand("select count(*) from eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer and ec.NOM_ETABA='" + comboBox3.Text + "'  and el.GenreAr='أنثى'", Program.cn);
            label2.Text = Program.cmd.ExecuteScalar().ToString();
            Program.cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            this.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 lk = new Form3();
            lk.Show();
        }
    }
}
