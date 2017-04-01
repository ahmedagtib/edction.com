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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        public bool exite()
        {
            bool e = false;
            Program.cn.Open();
            Program.cmd = new SqlCommand("select * from eleve where codeEleve='" + textBox1.Text + "'", Program.cn);
            Program.dr = Program.cmd.ExecuteReader();
            if (Program.dr.HasRows == true)
            {
                e = true;

            }
            Program.dr.Close();
            Program.cn.Close();
            return e;

        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            comboBox4.Items.Add("ذكر");
            comboBox4.Items.Add("أنثى");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            Program.cmd = new SqlCommand("select c.NOM_ETABA from ecole c , coumun cu where c.CD_COM =cu.CD_COM  and cu.LA_COM='" + comboBox2.Text + "'", Program.cn);

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
            Program.cmd = new SqlCommand("select RATT from ecole where NOM_ETABA='" + comboBox3.Text + "'", Program.cn);

            Program.dr = Program.cmd.ExecuteReader();
            while (Program.dr.Read())
            {
                comboBox5.Items.Add(Program.dr[0]);

            }
            Program.dr.Close();
            Program.cn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            { MessageBox.Show("تحقق من ملئ البيانات"); }
            else
            {
                if (exite() == true) { MessageBox.Show("هدا التلميد يوجد في قاعدة البيانات"); }
                else
                {
                    Program.cn.Open();
                    Program.cmd = new SqlCommand("insert into eleve values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox4.Text + "'," + textBox6.Text + "," + textBox7.Text + "," + textBox8.Text + "," + textBox9.Text + ",'" + textBox10.Text + "','" + comboBox5.Text + "')", Program.cn);

                    Program.cmd.ExecuteNonQuery();

                    MessageBox.Show("تمة الإضافة");
                    Program.cn.Close();
                }
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("قم إدخال رمز التلميد"); }
            else
            {
                if (exite() == false)
                {
                    MessageBox.Show("لا يوجد");
                }
                else
                {
                    Program.cn.Open();
                    Program.cmd = new SqlCommand("select  el.codeEleve as'??? ???????',el.nomEleve as'????? ???????',el.prenomEleve as'????? ??????',el.nomElevefr as 'Nom',el.prenomElevefr as 'Prenom',el.Moyennecc as'???? ??????',el.Moyenne_Exam as'???? ?????? ????',el.Moyenne_ses as '???? ??????',el.distance as '???????',el.situation_fam as'??????? ????????',ec.NOM_ETABA as'???????'from eleve el,ecole ec where  el.RATT=ec.RATT and  el.codeEleve='" + textBox1.Text + "'", Program.cn);
                    Program.dr = Program.cmd.ExecuteReader();
                    if (Program.dr.Read())
                    {
                        textBox1.Text = Program.dr[0].ToString();
                        textBox2.Text = Program.dr[1].ToString();
                        textBox3.Text = Program.dr[2].ToString();
                        textBox4.Text = Program.dr[3].ToString();
                        textBox5.Text = Program.dr[4].ToString();
                        textBox6.Text = Program.dr[5].ToString();
                        textBox7.Text = Program.dr[6].ToString();
                        textBox8.Text = Program.dr[7].ToString();

                    }

                    Program.dr.Close();
                    Program.cn.Close();

                }

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            { MessageBox.Show("تحقق من ملئ البيانات"); }
            else
            {
                if (exite() == false) { MessageBox.Show(" لايوجد هدا التلميد"); }
                else
                {
                    Program.cn.Open();
                    Program.cmd = new SqlCommand("update eleve set nomEleve='" + textBox2.Text + "',prenomEleve='" + textBox3.Text + "',nomElevefr='" + textBox4.Text + "',prenomElevefr='" + textBox5.Text + "',GenreAr='" + comboBox4.Text + "',distance=" + textBox9.Text + ",situation_fam='" + textBox10.Text + "',RATT='" + comboBox5.Text + "' where codeEleve='" + textBox1.Text + "'", Program.cn);

                    Program.cmd.ExecuteNonQuery();

                    MessageBox.Show("  تم التعديل");
                    Program.cn.Close();


                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ff = new Form3();
            ff.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            this.Refresh();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}