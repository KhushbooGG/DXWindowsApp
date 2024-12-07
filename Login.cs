using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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
            SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @username AND Password = @password AND IsActive=1", sqlConnection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
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
