using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXWindowsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void login1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // For Student Login
            if (username == "admin" && password == "admin123")
            {
                // Redirect to another form
                this.Hide();
                StudentDeshBoard deshboard = new StudentDeshBoard();
                deshboard.Show();
            }
            else 
            {
             string message = "Invalid Username or Password";
             label3.Text = message;  
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        
    }
}
