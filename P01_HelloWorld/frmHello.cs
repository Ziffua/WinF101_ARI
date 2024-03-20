using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_HelloWorld
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }



        private void btnMessage_Click(object sender, EventArgs e)
        {
            string name, lastname;

            name = tboxName.Text;
            lastname = tboxLastName.Text;

            lbelMessage.Text = $"Welcome {name} {lastname}";

            //MessageBox.Show($"Welcome {name} {lastname}");
            

           frmMessage frmMessage = new frmMessage();
            frmMessage.Text = "New Message";
            frmMessage.lblMessage.Text = "Welcome " + name + " " +lastname.ToUpper();

            if (frmMessage.ShowDialog() == DialogResult.OK) 
            {
                tboxName.Clear();
                tboxLastName.Clear();
            }
            else
            {
                tboxName.BackColor = Color.Red;
                tboxLastName.BackColor = Color.Green;
            }


            //tboxName.Clear();
            //tboxLastName.Clear();

        }

        private void frmHello_Load(object sender, EventArgs e)
        {
            lbelMessage.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
