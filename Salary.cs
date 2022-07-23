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

namespace WindowsFormsApp1
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SERVAN1121\BOUNMA1121;Initial Catalog=MyEmployeeDb;Integrated Security=True");
    
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private  void fetchempdata()
        {
            if(EmpidTb.Text == "")
            {
                MessageBox.Show("ກະລຸນາປ້ອນລະຫັດພະນັກງານ");
            }
            else
            {
                Con.Open();
                string query = "select * from EmployeeTb where EmpID = '" + EmpidTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    EmpidTb.Text = dr["EmpID"].ToString();
                    EmpNameTb.Text = dr["EmpName"].ToString();
                    EmpPosTb.Text = dr["EmPos"].ToString();

                }
                Con.Close();

            }
        

        }
        private void Salary_Load(object sender, EventArgs e)
        { 
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmpNameTb_TextChanged(object sender, EventArgs e)
        {

        }
        int Dailybase;
        int total;

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpPosTb.Text == "")
            {
                MessageBox.Show("ກະລຸນາປ້ອນຕຳແໜ່ງພະນັກງານ");

            }
            else if (WorkedTb.Text == "" || Convert.ToInt32(WorkedTb.Text) > 28)
            {
                MessageBox.Show("ກະລຸນາປ້ອນຈຳນວນວັນທີ່ເຮັດວຽກ");

            }
            else
            {
                if (EmpPosTb.Text == "Manager")
                {
                    Dailybase = 5000000;
                }
                else if (EmpPosTb.Text == "Senio Developer")
                {
                    Dailybase = 12000000;
                }
                else if (EmpPosTb.Text == "Junior Developer")
                {
                    Dailybase = 17000000;
                }
                else
                {
                    Dailybase = 1300000;
                }
                total = Dailybase * Convert.ToInt32(WorkedTb.Text);
                SalaryShip.Text = "ລະຫັດພະນັກງານ : " + EmpidTb.Text + "\n" +"ຊື່ພະນັກງານ : "+ EmpNameTb.Text + "\n" +"ຕຳແຫນ່ງ : "+ EmpPosTb.Text + "\n" +"Days worked "+ WorkedTb.Text + "\n" + "ເງິນເດືອນ : " + Dailybase + "\n" +"ຈຳນວນເງິນທັງຫນົດ :  "+ total;

            }
        }

        private void SalaryShip_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPD1.ShowDialog() == DialogResult.OK)
            {
                printD1.Print();
            }
        }

        private void printD1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("********ສະຫລຸບລາຍເດືອນ********", new Font("Saysettha OT", 25, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("ລະຫັດພະນັກງານ :  " + EmpidTb.Text + "\n\nຊື່ພະນັກງານ :  " + EmpNameTb.Text + "\n\nຈຳນວນວັນເຮັດວຽກ :  " + WorkedTb.Text + "\n\nຕຳແຫນ່ງ : " + EmpPosTb.Text, new Font("Saysettha OT", 18, FontStyle.Bold), Brushes.Blue, new Point(80, 100));
        }

        private void printPD1_Load(object sender, EventArgs e)
        {


        }
    }
}
