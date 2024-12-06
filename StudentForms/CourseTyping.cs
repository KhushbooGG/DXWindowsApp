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
    public partial class CourseTyping : Form
    {
        public CourseTyping()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(treeView1.SelectedNode.Text);

            if(treeView1.SelectedNode.Text == "Basic home key 1 74%(Accuracy)")
            {
                this.Hide();
                BasicHomeKey1 bhk1 = new BasicHomeKey1();
                bhk1.Show();
            }
            if (treeView1.SelectedNode.Text == "Basic home key 2 74%(Accuracy)")
            {
                this.Hide();
                //BasicHomeKey2 bhk2 = new BasicHomeKey2();
                //bhk2.Show();
            }
        }
    }
}
