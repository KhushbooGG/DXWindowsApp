using DXWindowsApp.StudentForms;
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
    public partial class StudentDeshBoard : Form
    {
        public StudentDeshBoard()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void typingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show CourseTyping Form
            CourseTyping courseTyping = new CourseTyping();
            courseTyping.Show();
        }
    }
}
