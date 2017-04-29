using MySql.Data.MySqlClient;
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
    public partial class GenerateReports : Form
    {
        
        public GenerateReports(int level)
        {
            InitializeComponent();
            if (level > 1)
            {

                ListViewItem item = new ListViewItem("Export Unread Incident Reports");
                listView1.Items.Add(item);
                item = new ListViewItem("Export Suspensions");
                listView1.Items.Add(item);
                item = new ListViewItem("Export Patron Information");
                listView1.Items.Add(item);

            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //
        //found this on http://stackoverflow.com/questions/8580591/export-sql-to-excel
        //
        private void SQLToCSV(string query, string Filename, int report)
        {



            MySqlConnection sql = new MySqlConnection(connectionstring.CS);
            sql.Open();
            MySqlCommand cmd = new MySqlCommand(query, sql);
            MySqlDataReader dr = cmd.ExecuteReader();

            using (System.IO.StreamWriter fs = new System.IO.StreamWriter(Filename))
            {
                switch (report) {
                    case 0: fs.WriteLine("All visits in last {0} days", numericUpDown1.Value);
                        break;
                    case 1: fs.WriteLine("Count of Unique visitors in last {0} days", numericUpDown1.Value);
                        break;
                    case 2: fs.WriteLine("List of Unique visitors in last {0} days", numericUpDown1.Value);
                        break;
                    case 3: fs.WriteLine("Count of number of times rock wall accessed in last {0} days", numericUpDown1.Value);
                        break;
                    case 4:
                        fs.WriteLine("Unread Incident Reports");
                        break;
                    case 5:
                        fs.WriteLine("All Suspensions");
                        break;
                    case 6:
                        fs.WriteLine("All Patron Information");
                        break;
                    
                }


                // Loop through the fields and add headers
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    
                    string name = dr.GetName(i);
                    if (name.Contains(","))
                        name = "\"" + name + "\"";

                    fs.Write(name + ",");
                }
                fs.WriteLine();

                // Loop through the rows and output the data
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(","))
                            value = "\"" + value + "\"";

                        fs.Write(value + ",");
                    }
                    fs.WriteLine();
                }

                fs.Close();
                sql.Close();
                MessageBox.Show("Successfully Exported Report");
            }
        }

        private bool CheckUI()
        {
            if(currfolder.Text == "" || txtfilename.Text == "")
            {
                return false;
            }


            return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckUI())
                return;
            ListViewItem item = listView1.FocusedItem;
            int x = item.Index;

            if(x >= 0 && x <= 3)
            {
                if(numericUpDown1.Value == 0)
                {
                    numericUpDown1.Value = 7;
                }
            }

            string q;

            string file = this.currfolder.Text + "\\" + this.txtfilename.Text + ".csv";

            DateTime dt = DateTime.Now;
            DateTime nt = dt.AddDays(-(double)numericUpDown1.Value);

            switch (x)
            {
                //get entire visit table for last X days
                case 0: q = "SELECT visit.PatronID, visit.DateofVisit, STUDENT.FName, STUDENT.LName FROM VISIT Inner join student on visit.PatronID = STUDENT.ID WHERE DATEOFVISIT BETWEEN '" + nt.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "' order by visit.dateofvisit desc;";
                    SQLToCSV(q, file, x);
                    break;
                    //distinct count of users in the last x days
                case 1: q = "SELECT COUNT(DISTINCT(PATRONID)) AS Nunber_Distinct_Visitors FROM VISIT WHERE DATEOFVISIT BETWEEN '" + nt.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                    SQLToCSV(q, file, x);
                    break;
                    //unique users in the last X days
                case 2: q = "SELECT distinct(visit.PatronID) AS NUM_PATRONS, STUDENT.FNAME, STUDENT.LNAME FROM VISIT Inner join student on visit.PatronID = STUDENT.ID WHERE DATEOFVISIT BETWEEN '" + nt.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                    SQLToCSV(q, file, x);
                    break;
                    //count of how many times wall accessed in last x days
                case 3:
                    q = "SELECT Count(PATRONID) AS Nunber_Visitors FROM VISIT WHERE DATEOFVISIT BETWEEN '" + nt.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                    SQLToCSV(q, file, x);
                    break;
                case 4:
                    q = "SELECT ID AS Student_ID, incident FROM student where adminseenincident = '0'";
                    SQLToCSV(q, file, x);

                    DialogResult dialogResult = MessageBox.Show("Mark all unread incident reports as read?", "Incident Reports", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MySqlConnection sql = new MySqlConnection(connectionstring.CS);


                        MySqlDataAdapter sqlDA = new MySqlDataAdapter("Update student set adminSeenIncident = 1 where adminSeenIncident = 0", sql);


                        DataTable table = new DataTable();
                        sqlDA.Fill(table);
                        DataRowCollection rowColl = table.Rows;
                        sql.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }


                    break;
                case 5:
                    q = "Select * from susp";
                    SQLToCSV(q, file, x);
                    break;
                case 6:
                    q = "Select * from student";
                    SQLToCSV(q, file, x);
                    break;



            }
        }

        private void get_folder()
        {

            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();

            // Set initial selected folder
           // Fld.SelectedPath = curfolder.Text;

            // Show the "Make new folder" button
            Fld.ShowNewFolderButton = true;

            if (Fld.ShowDialog() == DialogResult.OK)
            {
                currfolder.Text = Fld.SelectedPath;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            get_folder();
        }
    }
}
