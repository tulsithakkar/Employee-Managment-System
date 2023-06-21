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
    public partial class emp_employee : Form
    {
        public emp_employee()
        {
            InitializeComponent();
            cfill();
            toolTip1_backhome.SetToolTip(btn_backhome,"move to Home page");
            toolTip1_role.SetToolTip(cbox_role, "selete Role from combobox");
            toolTip1_insert.SetToolTip(btn_insert, "Pleace varify you enetred correct data!");
            MessageBox.Show("plecse enter all the details before presing insert key!!");
        }
        int j;
        public void cfill()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "select post from emp_post";
            SqlCommand cmd = new SqlCommand(q1, con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cbox_role.Items.Add(sdr[0].ToString());
            }
            con.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q = " insert into Employee values(@Eid,@Ename,@Gender,@DOB,@Address,@City,@Role,@Email,@Contact_no,@j_date)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Eid", Convert.ToInt32(txt_empid.Text));
            cmd.Parameters.AddWithValue("@Ename", txt_empname.Text);
            cmd.Parameters.AddWithValue("@Gender", cbox_gender.SelectedItem);
            cmd.Parameters.AddWithValue("@DOB", date1_dob.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@Address", txt_add.Text);
            cmd.Parameters.AddWithValue("@City", txt_city.Text);
            cmd.Parameters.AddWithValue("@Role", j);
            cmd.Parameters.AddWithValue("@Email", txt_mail.Text);
            cmd.Parameters.AddWithValue("@Contact_no", Convert.ToInt64(txt_cno.Text));   
            cmd.Parameters.AddWithValue("@j_date", date2_join.Value.ToShortDateString());

            con.Open();
            int i= cmd.ExecuteNonQuery();
            con.Close();

            if(i > 0)
            {
                MessageBox.Show("inserted successfully");
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }


        }

     
       

        private void cbox_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "select id from emp_post where post= @post";
            SqlCommand cmd = new SqlCommand(q1, con);
            cmd.Parameters.AddWithValue("@post", cbox_role.SelectedItem.ToString());
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            j = Convert.ToInt32(sdr[0]);
            con.Close();
        }

        private void btn_backhome_Click(object sender, EventArgs e)
        {
            emp_Home f1 = new emp_Home();
            f1.Show();
            this.Hide();
        }

        private void date1_dob_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
