using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXWindowsApp.StudentForms
{
    public partial class BasicHomeKey1 : Form
    {
        private DateTime _start;
        public BasicHomeKey1()
        {
            InitializeComponent();
            _start = DateTime.Now;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            TimeSpan duration = DateTime.Now - _start;
            label3.Text = duration.ToString(@"mm\:ss");
        }
    }
}
