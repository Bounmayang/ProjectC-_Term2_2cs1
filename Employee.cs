using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SERVAN1121\BOUNMA1121;Initial Catalog=MyEmployeeDb;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();

            string query = "select * from EmployeeTb ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet1();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpIDTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("ກະລຸນາປ້ອມຂໍ້ມູນໃສ່");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into EmployeeTb values('" + EmpIDTb.Text + "','" + EmpNameTb.Text + "','" + EmpAddTb.Text + "','" + EmpPosCb.SelectedItem.ToString() + "','" + EmpDob.Value.Date + "','" + EmpPhoneTb.Text + "','" + EmpEduCb.SelectedItem.ToString() + "','" + EmpGenCb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ເພີ່ມຂໍ້ມູນພະນັກງານສຳເລັດແລ້ວ");

                    Con.Close();
                    populate();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EmpIDTb.Text == "")
            {
                MessageBox.Show("ປ້ອນຂໍ້ມູນທີ່ຕ້ອງການລືບຢ່າງຫນ້ອຍຕ້ອງໃສ່ລະຫັດຂອງພະນັກງານ");
            }
            else
            {
                try
                {

                    Con.Open();
                    string query = "delete from EmployeeTb Where Empid = '" + EmpIDTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ລືບຂໍ້ມູນພະນັກງານສຳເລັດແລ້ວ");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpIDTb.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpAddTb.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpEduCb.Text = EmpDGV.SelectedRows[0].Cells[6].Value.ToString();
            EmpPosCb.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhoneTb.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
            EmpGenCb.Text = EmpDGV.SelectedRows[0].Cells[7].Value.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpIDTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("ກະລຸນາປ້ອນຂໍ້ມູນໃສ່");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update EmployeeTb set EmpName = '" + EmpNameTb.Text + "',EmpAdd = '" + EmpAddTb.Text + "',EmPos = '" + EmpPosCb.SelectedItem.ToString() + "',EmpDOB = '" + EmpDob.Value.Date + "',EmpPhone = '" + EmpPhoneTb.Text + "',EmpEdu = '" + EmpEduCb.SelectedItem.ToString() + "',EmpGen = '" + EmpGenCb.SelectedItem.ToString() + "' Where EmpID ='" + EmpIDTb.Text + "';";


                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ອັບເດດຂໍ້ມູນພະນັກງານສຳເລັດແລ້ວ");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
    }
}
