using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Managment_System_case_study
{
    public partial class emp_login : Form
    {
        public emp_login()
        {
            InitializeComponent();
            toolTip1_login.SetToolTip(btn_login,"check username and password again!");
            toolTip1_reset.SetToolTip(btn_cancle, "clear username and password");
        }

        private void emp_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Emp.mdf;Integrated Security=True;Connect Timeout=30");

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");

            String q = " select * from Login";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr;
            con.Open();
            dr= cmd.ExecuteReader();
            dr.Read();

            if (dr[1].Equals(txt_uname.Text) && dr[2].Equals(txt_pass.Text))
            {
                //MessageBox.Show("login succsefully");
                emp_Home f1 = new emp_Home();
                f1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid login credential");
            }
            con.Close();

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            txt_pass.Text = txt_uname.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {

        }
    }
}
