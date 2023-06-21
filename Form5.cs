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

namespace Employee_Managment_System_case_study
{
    public partial class emp_salary : Form
    {
        public emp_salary()
        {
            InitializeComponent();
            toolTip1_backhome.SetToolTip(btn_backhome, "move to Home page");
            toolTip1_cox.SetToolTip(cbox_id, "selete data from combobox");
            toolTip1_insert.SetToolTip(btn_insal, "insert  employee salary in to database");
            toolTip2_display.SetToolTip(btn_display, "display salary of employee");
            comfill();

        }
        public void comfill()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "select Eid from Employee";
            SqlCommand cmd = new SqlCommand(q1, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cbox_id.Items.Add(sdr[0].ToString());
            }
            MessageBox.Show("First select Employee id please");
        }
        private void btn_backhome_Click(object sender, EventArgs e)
        {
            emp_Home f1 = new emp_Home();
            f1.Show();
            this.Hide();
        }

        private void cbox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_esal.Text = "";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "select Ename from Employee where Eid= @Eid";
            SqlCommand cmd = new SqlCommand(q1, con);
            cmd.Parameters.AddWithValue("@Eid", cbox_id.SelectedItem.ToString());
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            txt_empname.Text = sdr[0].ToString();
            txt_name.Text = sdr[0].ToString();  
            con.Close();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "select esal from Esalary where Eid= @Eid";
            SqlCommand cmd = new SqlCommand(q1, con);
            cmd.Parameters.AddWithValue("@Eid", cbox_id.SelectedItem.ToString());
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            txt_sal.Text = sdr[0].ToString();
           
            con.Close();
        }

        private void btn_insal_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "insert into Esalary values(@Eid,@Ename,@esal)";
            SqlCommand cmd = new SqlCommand(q1, con);
            cmd.Parameters.AddWithValue("@Eid", cbox_id.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Ename", txt_empname.Text);
            cmd.Parameters.AddWithValue("@esal", Convert.ToInt32(txt_esal.Text));
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                MessageBox.Show("inserted successfully");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }



        }

        private void pic_home_Click(object sender, EventArgs e)
        {

        }

        private void txt_empname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
