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

namespace Lab_sheet_06
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C# module\Lab sheet\Lab sheet 06\Lab sheet 06\Lab sheet 06\Database1.mdf"";Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = Nametxt.Text;
            string UserName = Usernametxt.Text;
            string DOB = DOBtxt.Text;
            string Password = Passwordtxt.Text;

            string query = $"INSERT INTO Employee(UserNmae, Name, DOB, Password)VALUES('{UserName}' , '{Name}' , '{DOB}' , '{Password}')";

            SqlCommand cmd1 = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User Registration Successful !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }


        public void Clearfields()
        {
            Nametxt.Text = "";
            Usernametxt.Text = "";
            DOBtxt.Text = "";
            Passwordtxt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clearfields();
        }
    }
}

    