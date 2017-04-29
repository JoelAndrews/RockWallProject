using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class RockWallManager : Form
    {
       public int level = -1;
        public string UserName;
        public string PassWord;



        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string query = "SELECT count(*) from visit where Date(DateofVisit) = Current_Date";



            MySqlConnection conn = new MySqlConnection(connectionstring.CS);
            //    MySqlDataReader rdr = null;
            MySqlDataAdapter adapter;

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            DataTable dataset = new DataTable();

            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataset);

            lblVisitors.Text = dataset.Rows[0][0].ToString();
            conn.Close();
        }



        public RockWallManager(int a, string userName, string passWord)
        {
            InitializeComponent();

            UserName = userName;
            this.PassWord = passWord;
            this.level = a;
            if(a == 3)
            {
                this.Text = "Rock Wall Manager Pro - Admin";
            }
            else if (a == 2)
            {
                this.Text = "Rock Wall Manager Pro - Manager";
                // this.manageManagersStripMenu.Enabled = false;
                this.manageAdminsToolStripMenuItem.Enabled = false;

            }
            else if(a == 1)
            {
                this.Text = "Rock Wall Manager Pro - Employee";
                this.manageManagersStripMenu.Enabled = false;
                this.manageEmployeesStripMenu.Enabled = false;
                this.manageAdminsToolStripMenuItem.Enabled = false;
                this.btnBackup.Enabled = false;
                this.generateReportsToolStripMenuItem.Enabled = false;

            }

            this.lblDate.Text = DateTime.Now.ToString("MM-dd-yyyy");

            InitTimer();

            string query = "SELECT count(*) from visit where Date(DateofVisit) = Current_Date";



            MySqlConnection conn = new MySqlConnection(connectionstring.CS);
            //    MySqlDataReader rdr = null;
            MySqlDataAdapter adapter;

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            DataTable dataset = new DataTable();

            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataset);

            lblVisitors.Text = dataset.Rows[0][0].ToString();

            conn.Close();


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
            GenerateReports form3 = new GenerateReports(level);
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
            ManageManagers MA = new ManageManagers(UserName, PassWord, level);
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

        private void manageAdminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAdmins ma = new ManageAdmins();
            ma.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
           using (var form = new ChangePassword(PassWord, UserName))
            {
                var result = form.ShowDialog();
                if(result == DialogResult.Cancel)
                {
                    PassWord = form.CurrentPassword;

                }

            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            //var x = ConfigurationSettings.AppSettings;



            //// read backup folder from config file ("C:/temp/")
            //var backupFolder = x[0];

            //var sqlConStrBuilder = new SqlConnectionStringBuilder(connectionstring.CS);
            //string db = "RockWallDB";
            //// set backupfilename (you will get something like: "C:/temp/MyDatabase-2013-12-07.bak")
            //var backupFileName = String.Format("{0}{1}-{2}.bak",
            //    backupFolder, db,
            //    DateTime.Now.ToString("yyyy-MM-dd"));

            //using (var connection = new MySqlConnection(connectionstring.CS))
            //{
            //    var query = String.Format("BACKUP DATABASE {0} TO DISK='{1}'",
            //        "RockWall", backupFileName);

            //    using (var command = new MySqlCommand(query, connection))
            //    {
            //        connection.Open();
            //        command.ExecuteNonQuery();
            //    }
            //}

            //https://mysqlbackupnet.codeplex.com/ is where i got this from
            string constring = "server=localhost;user=root;database=rockwall;";

            // Important Additional Connection Options
            constring += "charset=utf8;convertzerodatetime=true;";

            string file = "C:\\backup\\" + DateTime.Now.ToString("yyyy-MM-dd") + "backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();

                        MessageBox.Show("Backup Successful to C://Backup");
                        
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    MessageBox.Show("Local IP address is " + ip.ToString());
                }
            }

        }
    }
}
