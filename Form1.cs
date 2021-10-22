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

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=crudApp;Integrated Security=True");
        private void saveBtn_Click(object sender, EventArgs e)
        {
            int empid = int.Parse(txtempID.Text);
            String empName = txtempName.Text;
            String city = cmbcity.Text;
            double age = double.Parse(txtage.Text);
            String sex;
            DateTime date = DateTime.Parse(joinedDate.Text);
            String contact = txtcontact.Text;

            if(male.Checked == true) 
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }

            con.Open();
            SqlCommand c = new SqlCommand("exec InsertEmpData '"+ empid + "','" + empName + "','" + city + "','" + age + "','" + sex + "','" + date + "','" + contact + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted...!");
            GetEmployeeList();
            con.Close();
        }

        void GetEmployeeList()
        {
            SqlCommand c = new SqlCommand("exec SelectEmpData", con);
            SqlDataAdapter da = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tbl.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmployeeList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Update Btn
            int empid = int.Parse(txtempID.Text);
            String empName = txtempName.Text;
            String city = cmbcity.Text;
            double age = double.Parse(txtage.Text);
            String sex;
            DateTime date = DateTime.Parse(joinedDate.Text);
            String contact = txtcontact.Text;

            if (male.Checked == true)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }

            con.Open();
            SqlCommand c = new SqlCommand("exec UpdateEmpData '" + empid + "','" + empName + "','" + city + "','" + age + "','" + sex + "','" + date + "','" + contact + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated...!");
            GetEmployeeList();
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Delete Btn
            if(MessageBox.Show("Are you sure want to delete...?","Delete Document", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                int empid = int.Parse(txtempID.Text);
                con.Open();
                SqlCommand c = new SqlCommand("exec DeleteEmpData '" + empid + "'", con);
                c.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted...!");
                GetEmployeeList();
                con.Close();
            }
        }
    }
}
