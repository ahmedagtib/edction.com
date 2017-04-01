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
    public partial class Form10 : Form
    {
        public Form10()
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
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 yy = new Form3();
            yy.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("قم بإدخال رمز التلميد"); }
            else
            {
                if (exite() == false)
                {
                    MessageBox.Show("لا يوجد في قاعدة البيانات");
                }
                else
                {
                    Program.cn.Open();
                    Program.cmd = new SqlCommand("select  el.codeEleve as'رمز التلميد',el.nomEleve as'الإسم العائلي',el.prenomEleve as'الإسم الشخصي',el.nomElevefr as 'Nom',el.prenomElevefr as 'Prenom',el.GenreAr as 'الجنس',el.Moyennecc as'معدل الدورة',el.Moyenne_Exam as'معدل إمتحان موحد',el.Moyenne_ses as 'معدل الأسدس',el.distance as 'المسافة',el.situation_fam as'الوضعية العائلية',ec.NOM_ETABA as'المؤسسة'from eleve el,ecole ec where  el.RATT=ec.RATT and  el.codeEleve='"+textBox1.Text+"'",Program.cn);
                    Program.dr = Program.cmd.ExecuteReader();
                    DataTable t = new DataTable();
                    t.Load(Program.dr);
                    dataGridView1.DataSource = t;
                    Program.dr.Close();
                    Program.cn.Close();

                }


            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
