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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SERVAN1121\BOUNMA1121;Initial Catalog=MyEmployeeDb;Integrated Security=True");
        private void fetchempdata()
        {
            if(EmpidTb.Text == "")
            {
                MessageBox.Show("ກະລຸນາໃສ່ລະຫັດຂອງພະນັກງານທີ່ຕ້ອງການເບິ່ງລາຍລະອຽດ");
            }else
            {

                Con.Open();
                string query = "select * from EmployeeTb where EmpID = '" + EmpidTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Empidlbl.Text = dr["EmpID"].ToString();
                    EmpName.Text = dr["EmpName"].ToString();
                    EmpGens.Text = dr["EmpGen"].ToString();
                    EmpDOBs.Text = dr["EmpDOB"].ToString();
                    EmpPos.Text = dr["EmPos"].ToString();
                    EmpAdd.Text = dr["EmpAdd"].ToString();
                    EmpPho.Text = dr["EmpPhone"].ToString();
                    EmpEdus.Text = dr["EmpEdu"].ToString();
                    Empidlbl.Visible = true;
                    EmpName.Visible = true;
                    EmpGens.Visible = true;
                    EmpDOBs.Visible = true;
                    EmpPos.Visible = true;
                    EmpAdd.Visible = true;
                    EmpPho.Visible = true;
                    EmpEdus.Visible = true;
                }
                Con.Close();

            }
            

        }
        private void label9_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPD.ShowDialog() == DialogResult.OK)
            {
                printD.Print();
            }
        }

        private void printPD_Load(object sender, EventArgs e)
        {

        }

        private void printD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("********EMPLOYEE SUMMARY********",new Font("Century Gothic",25,FontStyle.Bold),Brushes.Red,new Point(180));
            e.Graphics.DrawString("ລະຫັດພະນັກງານ :  " + Empidlbl.Text + "\n\nຊື່ພະນັກງານ :  " + EmpName.Text + "\n\nທີ່ຢູ່ : " + EmpAdd.Text + "\n\nວັນເດືອນປີເກີດ : " + EmpDOBs.Text + "\n\nເພດ :  " + EmpGens.Text + "\n\nຕຳແຫນ່ງ : " + EmpPos.Text + "\n\nເບີຕິດຕໍ່ :  " + EmpPho.Text + "\n\nລະດັບການສຶກສາ : " + EmpEdus.Text, new Font("Saysettha OT", 18, FontStyle.Bold), Brushes.Blue, new Point(80, 100));


        }
    }
}
