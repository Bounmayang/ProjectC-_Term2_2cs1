using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)


        {
            if(UserN.Text == "" || Password.Text == "" )
            {
                MessageBox.Show("ກະລຸນາກວດຄືນຊື່ ແລະ ລະຫັດຜ່ານ");

            }
            else if(UserN.Text == "Admin" && Password.Text == "Admin123")
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("ຊື່ ຫລືລະຫັດຜູ້ໃຊ້ບໍ່ຖືກ");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
