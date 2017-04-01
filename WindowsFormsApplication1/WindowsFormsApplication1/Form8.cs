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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        DataTable dt=new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            Program.cn.Open();
            Program.cmd = new SqlCommand("select el.codeEleve as'رمز التلميد',el.nomEleve as'الإسم العائلي',el.prenomEleve as'الإسم الشخصي',el.nomElevefr as 'Nom',el.prenomElevefr as 'Prenom',el.GenreAr as 'الجنس',el.Moyennecc as'معدل الدورة',el.Moyenne_Exam as'معدل إمتحان موحد',el.Moyenne_ses as 'معدل الأسدس',el.distance as 'المسافة',el.situation_fam as'الوضعية العائلية',ec.NOM_ETABA as'المؤسسة'from eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer order by el.Moyennecc desc  ", Program.cn);
            // Program.cmd.Connection = Program.cn;
            Program.cmd.CommandType = CommandType.Text;
            SqlDataReader dr1 = Program.cmd.ExecuteReader();

            dt.Load(dr1);

            dataGridView1.DataSource = dt;
            dr1.Close();
            Program.cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dt = new DataTable();
            Program.cn.Open();
            Program.cmd.CommandText = ("select el.codeEleve as'رمز التلميد',el.nomEleve as'الإسم العائلي',el.prenomEleve as'الإسم الشخصي',el.nomElevefr as 'Nom',el.prenomElevefr as 'Prenom',el.GenreAr as 'الجنس',el.Moyennecc as'معدل الدورة',el.Moyenne_Exam as'معدل إمتحان موحد',el.Moyenne_ses as 'معدل الأسدس',el.distance as 'المسافة',el.situation_fam as'الوضعية العائلية',ec.NOM_ETABA as'المؤسسة'from eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer  and ce.nomcer='" + comboBox1.Text + "' order by el.Moyennecc desc");
            Program.cmd.Connection = Program.cn;
            SqlDataReader dr1 = Program.cmd.ExecuteReader();

            dt.Load(dr1);
            dataGridView1.DataSource = dt;
            dr1.Close();
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
             this.dt = new DataTable();
                Program.cn.Open();
                Program.cmd.CommandText = ("select el.codeEleve as'رمز التلميد',el.nomEleve as'الإسم العائلي',el.prenomEleve as'الإسم الشخصي',el.nomElevefr as 'Nom',el.prenomElevefr as 'Prenom',el.GenreAr as 'الجنس',el.Moyennecc as'معدل الدورة',el.Moyenne_Exam as'معدل إمتحان موحد',el.Moyenne_ses as 'معدل الأسدس',el.distance as 'المسافة',el.situation_fam as'الوضعية العائلية',ec.NOM_ETABA as'المؤسسة'from eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer and co.LA_COM ='" + comboBox2.Text + "' order by el.Moyennecc desc");
                Program.cmd.Connection = Program.cn;
                SqlDataReader dr1 = Program.cmd.ExecuteReader();
            dt.Load(dr1);
            dataGridView1.DataSource = dt;

            dr1.Close();
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
             this.dt = new DataTable();
            Program.cn.Open();
            Program.cmd.CommandText = (" select el.codeEleve as'رمز التلميد',el.nomEleve as'الإسم العائلي',el.prenomEleve as'الإسم الشخصي',el.nomElevefr as 'Nom',el.prenomElevefr as 'Prenom',el.GenreAr as 'الجنس',el.Moyennecc as'معدل الدورة',el.Moyenne_Exam as'معدل إمتحان موحد',el.Moyenne_ses as 'معدل الأسدس',el.distance as 'المسافة',el.situation_fam as'الوضعية العائلية',ec.NOM_ETABA as'المؤسسة'from eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer and ec.NOM_ETABA='" + comboBox3.Text + "' order by el.Moyennecc desc");
            Program.cmd.Connection = Program.cn;
            SqlDataReader dr1 = Program.cmd.ExecuteReader();
            dt.Load(dr1);
            dataGridView1.DataSource = dt;

            dr1.Close();
            Program.cn.Close();
            comboBox2.Items.Clear();
        }

        private void Form8_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 gg = new Form3();
            gg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Refresh();
        }
    }
}
