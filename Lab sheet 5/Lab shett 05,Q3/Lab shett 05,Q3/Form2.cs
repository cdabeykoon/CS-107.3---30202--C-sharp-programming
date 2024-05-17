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
    public partial class Form2 : Form
    {
        private User user;
        public Form2(User user)
        {
            InitializeComponent();
            this.user = user; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "welcome: " + user.FirstName.ToString() + "" + user.LastName.ToString();
            label2.Text = "Username: " + user.UserName.ToString();
            label3.Text = "Email: " + user.Email.ToString();
            label4.Text = "Birth Day " + user.DateOfBirth.ToString();

        }

    }
}
