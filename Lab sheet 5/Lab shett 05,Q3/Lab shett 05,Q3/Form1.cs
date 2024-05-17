using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_shett_05_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (validation())
            {
                User newUser = new User
                    
                    {
                        FirstName = textBox1.Text,
                        LastName = textBox2.Text,
                        UserName = textBox3.Text,
                        DateOfBirth = dateTimePicker1.Text,
                        Email = textBox4.Text,
                        Address = textBox5.Text,
                        Password = textBox6.Text,
                        ConfirmPassword = textBox7.Text,

                    };

                Form2 welcom = new Form2(newUser);
                welcom.Show();
                this.Hide();
            }
        }

        public bool validation()
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter Your First name");
                return false;
            }
            return true;
        }

    }
}
