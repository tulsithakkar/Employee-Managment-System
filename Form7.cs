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
    public partial class emp_update : Form
    {
        public emp_update()
        {
            InitializeComponent();
            comfill();
            toolTip1_backhome.SetToolTip(btn_backhome, "move to Home page");
            toolTip1_cbox.SetToolTip(cbox_id, "selete Id from combobox");
            toolTip1_rol.SetToolTip(cbox_role, "selete Role from combobox");
            toolTip1_updaet.SetToolTip(btn_Updtae, "Pleace varify you enetred correct data!");
            toolTip1_delete.SetToolTip(btn_delete, "delete data from database");
            MessageBox.Show("please first select Employee id!!");
        }
        public int j;
        public void comfill()
        {
            cbox_id.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "select Eid from Employee";
            SqlCommand cmd = new SqlCommand(q1, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cbox_id.Items.Add(sdr[0].ToString());
            }
            con.Close();
            String q2 = "select post from emp_post";
            SqlCommand cmd1 = new SqlCommand(q2, con);
           
            con.Open();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            while (sdr1.Read())
            {
                cbox_role.Items.Add(sdr1[0].ToString());
            }
            con.Close();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_backhome_Click(object sender, EventArgs e)
        {
            emp_Home f1 = new emp_Home();
            f1.Show();
            this.Hide();
        }
        public String id;
        private void cbox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String q1 = "select * from Employee where Eid= @Eid";
            SqlCommand cmd = new SqlCommand(q1, con);
            cmd.Parameters.AddWithValue("@Eid", cbox_id.SelectedItem.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            txt_empname.Text = ds.Tables[0].Rows[0][1].ToString();
            txt_gender.Text = ds.Tables[0].Rows[0][2].ToString();
            date1_dob.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][3]);
            txt_add.Text = ds.Tables[0].Rows[0][4].ToString();
            txt_city.Text = ds.Tables[0].Rows[0][5].ToString();
            id=ds.Tables[0].Rows[0][6].ToString();
            txt_mail.Text = ds.Tables[0].Rows[0][7].ToString();
            txt_cno.Text = ds.Tables[0].Rows[0][8].ToString();
            date2_join.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][3]);
            String q2 = "select post from emp_post where id=@id";
            SqlCommand cmd2 = new SqlCommand(q2, con);
            cmd2.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            con.Open();
            SqlDataReader sdr = cmd2.ExecuteReader();
            if (sdr.Read())
                cbox_role.Text = sdr[0].ToString();
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String msg = "Do you want to delete this Employee Details?";
            String caption = "Form closing";
            var res = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                this.Close();
            }
            // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "delete from Employee where Eid=@Eid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Eid", Convert.ToInt32(cbox_id.SelectedItem));
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
                MessageBox.Show("Delete data Successfully.");
            comfill();
        }

        private void btn_Updtae_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSCIT-SEM5\.net\case study\Employee Managment System-case study-20220927T153931Z-001\Employee Managment System-case study\Emp.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "Update Employee set Ename=@Ename,Gender=@Gender,DOB=@DOB,Address=@Address,City=@City,Roleid=@Role,Email=@Email,Contact_no=@contact_no,j_date=@j_date where Eid=@Eid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Eid", Convert.ToInt32(cbox_id.SelectedItem));
            cmd.Parameters.AddWithValue("@Ename",txt_empname.Text);
            cmd.Parameters.AddWithValue("@Gender", txt_gender.Text);
            cmd.Parameters.AddWithValue("@DOB", date1_dob.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@Address", txt_add.Text);

            cmd.Parameters.AddWithValue("@City", txt_city.Text);
            cmd.Parameters.AddWithValue("@Role", j);
            cmd.Parameters.AddWithValue("@Email", txt_mail.Text);
            cmd.Parameters.AddWithValue("@contact_no", Convert.ToInt64(txt_cno.Text));
            cmd.Parameters.AddWithValue("@j_date", date2_join.Value.ToShortDateString());
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
                MessageBox.Show("update data Successfully.");
            //update call is remain
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

        private void emp_update_Load(object sender, EventArgs e)
        {

        }
    }
}
