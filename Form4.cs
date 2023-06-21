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
    public partial class emp_details : Form
    {
        public emp_details()
        {
            InitializeComponent();
            comfill();
            toolTip1_backhome.SetToolTip(btn_backhome, "move to Home page");
            toolTip1_cbox.SetToolTip(cbox_id, "selete data from combobox");
        }
        public void comfill()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "select Eid from Employee";
            SqlCommand cmd= new SqlCommand(q1, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
           while(sdr.Read())
            {
                cbox_id.Items.Add(sdr[0].ToString());
            }

           sdr.Close();
            MessageBox.Show("First select Employee id please");
        }
        //private void cbox_gender_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //private void cbox_role_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
        public String id;
        private void cbox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "select * from Employee where Eid= @Eid";
            SqlCommand cmd = new SqlCommand(q1, con);
            cmd.Parameters.AddWithValue("@Eid",cbox_id.SelectedItem.ToString());
            SqlDataAdapter sda= new SqlDataAdapter(cmd);
            
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            txt_empname.Text= ds.Tables[0].Rows[0][1].ToString();
            txt_gender.Text= ds.Tables[0].Rows[0][2].ToString();
            date1_dob.Value= Convert.ToDateTime(ds.Tables[0].Rows[0][3]);
            txt_add.Text= ds.Tables[0].Rows[0][4].ToString();
            txt_city.Text= ds.Tables[0].Rows[0][5].ToString();
            id = ds.Tables[0].Rows[0][6].ToString();
            txt_mail.Text= ds.Tables[0].Rows[0][7].ToString();
            txt_cno.Text= ds.Tables[0].Rows[0][8].ToString();
            date2_join.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][3]);

            String q2 = "select post from emp_post where id=@id";
            SqlCommand cmd2 = new SqlCommand(q2, con);
            cmd2.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            con.Open();
            SqlDataReader sdr = cmd2.ExecuteReader();
            if (sdr.Read())
            txt_role.Text = sdr[0].ToString();
            con.Close();
        }

        private void btn_backhome_Click(object sender, EventArgs e)
        {
            emp_Home f1 = new emp_Home();
            f1.Show();
            this.Hide();
        }

        private void txt_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
