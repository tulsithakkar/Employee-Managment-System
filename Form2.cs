using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Managment_System_case_study
{
    public partial class emp_Home : Form
    {
        public emp_Home()
        {
            InitializeComponent();
            toolTip1_emp.SetToolTip(pic_employee,"insert data for Employees");
            toolTip1_update.SetToolTip(pictureBox1,"Update & delete data for Employees");
            toolTip1_details.SetToolTip(pic_details,"Display all details of employees");
            toolTip1_salary.SetToolTip(pic_sal, "insert and display salary of employees");
            toolTip1_leave.SetToolTip(pic, "leave managment of employees");
            toolTip1_logout.SetToolTip(btn_logout, "warning! you will logout from the system ");
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            emp_leave f1 = new emp_leave();
            f1.Show();
            this.Hide();
        }

        private void pic_employee_Click(object sender, EventArgs e)
        {
            // employee form will open 
            emp_employee f1 = new emp_employee();
            f1.Show();
            this.Hide();
        }

        private void pic_details_Click(object sender, EventArgs e)
        {
            emp_details f2= new emp_details();
            f2.Show();
            this.Hide();


        }

        private void emp_Home_Load(object sender, EventArgs e)
        {

        }

        private void pic_sal_Click(object sender, EventArgs e)
        {
            emp_salary f3 = new emp_salary();
            f3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            emp_update f4= new emp_update();
            f4.Show();
            this.Hide();

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            emp_login f5= new emp_login();
            f5.Show();
            this.Hide();

        }
    }
}
