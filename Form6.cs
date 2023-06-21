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
    public partial class emp_leave : Form
    {
        public emp_leave()
        {
            InitializeComponent();
            comfill();
            toolTip1_backhome.SetToolTip(btn_backhome, "move to Home page");
            toolTip1_cox.SetToolTip(cbox_id, "selete data from combobox");
            toolTip1_apply.SetToolTip(btn_apply, "insert levae data into database");
            toolTip1_display.SetToolTip(btn_display, "display employee all leavses data into table fromat");

        }
        public String type;
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
        private void cbox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
           //get employee name
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "select Ename from Employee where Eid= @Eid ";
            SqlCommand cmd = new SqlCommand(q1, con);
            cmd.Parameters.AddWithValue("@Eid", cbox_id.SelectedItem.ToString());
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            txt_empname.Text = sdr[0].ToString();
            con.Close();

            // get rol name
            String q2 = "select post from emp_post where id= (select Roleid from Employee where Eid=@Eid)";
            SqlCommand cmd1 = new SqlCommand(q2, con);
            cmd1.Parameters.AddWithValue("@Eid", cbox_id.SelectedItem.ToString());
            con.Open();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            sdr1.Read();
            txt_role.Text = sdr1[0].ToString();
            con.Close();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_empname_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_type_Click(object sender, EventArgs e)
        {

        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "insert into Leave values(@Eid,@type,@From,@To)";
            SqlCommand cmd = new SqlCommand(q1, con);
            cmd.Parameters.AddWithValue("@Eid", cbox_id.SelectedItem.ToString());
           cmd.Parameters.AddWithValue("@type",type);
            cmd.Parameters.AddWithValue("@From",date1_lfrom.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@To", date2_lto.Value.ToShortDateString());
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

        private void radiob1_sick_CheckedChanged(object sender, EventArgs e)
        {
            type = radiob1_sick.Text.ToString(); 
        }

        private void radiob2_Maternity_CheckedChanged(object sender, EventArgs e)
        {
            type = radiob2_Maternity.Text.ToString();
        }

        private void radio4_vacation_CheckedChanged(object sender, EventArgs e)
        {
            type=radio4_vacation.Text.ToString();
        }

        private void radioB3_other_CheckedChanged(object sender, EventArgs e)
        {
            type=radioB3_other.Text.ToString();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "Select * from Leave Where Eid=@Eid";

            SqlCommand cmd = new SqlCommand(q1, con);
            cmd.Parameters.AddWithValue("@Eid", cbox_id.SelectedItem.ToString());
            SqlDataAdapter sda=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dataGridView1_display.DataSource = dt;

        }

        private void btn_backhome_Click(object sender, EventArgs e)
        {
            emp_Home f1 = new emp_Home();
            f1.Show();
            this.Hide();
        }

        private void txt_role_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
