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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 tt = new Form3();
            tt.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Program.cn.Open();
            Program.cmd = new SqlCommand("select nomcer from cercle", Program.cn);

            Program.dr = Program.cmd.ExecuteReader();
            while (Program.dr.Read())
            {
                comboBox1.Items.Add(Program.dr[0]);

            }

            Program.dr.Close();
            Program.cn.Close();
            //combo 3
            Program.cn.Open();
            Program.cmd = new SqlCommand("select nomcer from cercle", Program.cn);

            Program.dr = Program.cmd.ExecuteReader();
            while (Program.dr.Read())
            {
                comboBox3.Items.Add(Program.dr[0]);

            }

            Program.dr.Close();
            Program.cn.Close();
        }
        DataTable dt = new DataTable();

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("إدخال عدد المقاعد"); }
            else
            { 
            this.dt = new DataTable();
            Program.cn.Open();
            Program.cmd.CommandText = ("select top " + textBox1.Text + " el.codeEleve as'رمز التلميد',el.nomEleve as'الإسم العائلي',el.prenomEleve as'الإسم الشخصي',el.nomElevefr as 'Nom',el.prenomElevefr as 'Prenom',el.GenreAr as 'الجنس',el.Moyennecc as'معدل الدورة',el.Moyenne_Exam as'معدل إمتحان موحد',el.Moyenne_ses as 'معدل الأسدس',el.distance as 'المسافة',el.situation_fam as'الوضعية العائلية',ec.NOM_ETABA as'المؤسسة'from eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer and el.GenreAr='ذكر' and co.LA_COM ='" + comboBox2.Text + "' order by el.Moyennecc desc");
            Program.cmd.Connection = Program.cn;
            SqlDataReader dr1 = Program.cmd.ExecuteReader();
            dt.Load(dr1);
            dataGridView1.DataSource = dt;

            dr1.Close();
            Program.cn.Close();

           }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dt = new DataTable();
            Program.cn.Open();
            Program.cmd.CommandText = ("select   el.codeEleve as'رمز التلميد',el.nomEleve as'الإسم العائلي',el.prenomEleve as'الإسم الشخصي',el.nomElevefr as 'Nom',el.prenomElevefr as 'Prenom',el.GenreAr as 'الجنس',el.Moyennecc as'معدل الدورة',el.Moyenne_Exam as'معدل إمتحان موحد',el.Moyenne_ses as 'معدل الأسدس',el.distance as 'المسافة',el.situation_fam as'الوضعية العائلية',ec.NOM_ETABA as'المؤسسة'from eleve el,cercle ce,coumun co,ecole ec where  el.RATT=ec.RATT and ec.CD_COM=co.CD_COM and co.idcer=ce.idcer and el.GenreAr='ذكر'  and ce.nomcer='" + comboBox1.Text + "' order by el.Moyennecc desc");
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.cn.Open();
            Program.cmd = new SqlCommand("select c.LA_COM from coumun c , cercle cu where c.idcer=cu.idcer and nomcer='" + comboBox3.Text + "'", Program.cn);

            Program.dr = Program.cmd.ExecuteReader();
            while (Program.dr.Read())
            {
                comboBox4.Items.Add(Program.dr[0]);

            }
            Program.dr.Close();
            Program.cn.Close();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.cn.Open();
            Program.cmd = new SqlCommand("select c.nom_colg from colg c , coumun cu where c.CD_COM =cu.CD_COM  and cu.LA_COM ='" + comboBox4.Text + "'", Program.cn);

            Program.dr = Program.cmd.ExecuteReader();
            while (Program.dr.Read())
            {
                comboBox5.Items.Add(Program.dr[0]);

            }
            Program.dr.Close();
            Program.cn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int j = 0;
                Program.cmd.CommandType = CommandType.Text;
                Program.cmd.Connection = Program.cn;
                Program.cn.Open();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    Program.cmd.CommandText = "insert into bourse(codeEleve,nomEleve,prenomEleve,nomElevefr,prenomElevefr,GenreAr,Moyennecc,Moyenne_Exam,Moyenne_ses,distance,situation_fam,nom_colg)values('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value + "','" + dataGridView1.Rows[i].Cells[9].Value + "','" + dataGridView1.Rows[i].Cells[10].Value + "','" + comboBox5.Text + "')";
                    j=Program.cmd.ExecuteNonQuery();
                }
                if (j != 0) { MessageBox.Show("تمة العملية بنجاح"); }
            }
            catch (Exception ex) { MessageBox.Show(" "+ex.Message); }
            finally
            {
                Program.cn.Close();
            }
          
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
      
    }
}
