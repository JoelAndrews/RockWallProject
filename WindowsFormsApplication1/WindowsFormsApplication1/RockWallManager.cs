using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RockWallManager : Form
    {
       public int level = -1;
        public string UserName;
        public string PassWord;
        public RockWallManager(int a, string userName, string passWord)
        {
            InitializeComponent();

            UserName = userName;
            this.PassWord = passWord;

            if(a == 3)
            {
                this.Text = "Rock Wall Manager Pro - Admin";
            }
            else if (a == 2)
            {
                this.Text = "Rock Wall Manager Pro - Manager";
                //this.manageManagersStripMenu.Enabled = false;

            }
            else if(a == 1)
            {
                this.Text = "Rock Wall Manager Pro - Employee";
                this.manageManagersStripMenu.Enabled = false;
                this.manageEmployeesStripMenu.Enabled = false;

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LaptopSignIn form = new LaptopSignIn();
            form.Show();
        }

        private void generateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReports form3 = new GenerateReports();
            form3.ShowDialog();

        }

        private void managePatronsStripMenu_Click(object sender, EventArgs e)
        {
            ManagePatrons MP = new ManagePatrons();
            MP.ShowDialog();
        }

        private void manageEmployeesStripMenu_Click(object sender, EventArgs e)
        {
            ManageEmployees ME = new ManageEmployees();
            ME.ShowDialog();
        }

        private void manageManagersStripMenu_Click(object sender, EventArgs e)
        {
            ManageAdmins MA = new ManageAdmins(UserName, PassWord);
            MA.ShowDialog();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IssueCertificate ic = new IssueCertificate();
            ic.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IssueIncidentReport ics = new IssueIncidentReport();
            ics.ShowDialog();
        }
    }
}
