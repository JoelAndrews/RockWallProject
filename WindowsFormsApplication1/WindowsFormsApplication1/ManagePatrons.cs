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
    public partial class ManagePatrons : Form
    {
        public enum SuspendState
        {
            CanSuspend,
            CanRemove,
            Intial
        }
        public List<string> IncidentStrings = new List<string>();
        public SuspendState susState = SuspendState.Intial;
        public ManagePatrons()
        {
            this.KeyPreview = true;
            InitializeComponent();
            lbldate.Text = DateTime.Now.ToString("M/d/yyyy");
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            btnClrIncidents.Enabled = false;
            btnDeletePatron.Enabled = false;
        }
        // Hot keys handler
        void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S populate from entire table - for debugging
            {
                ClearUI();
                // Do what you want here
                MySqlConnection sql = new MySqlConnection(connectionstring.CS);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("SELECT * FROM STUDENT", sql);

                DataTable table = new DataTable();
                sqlDA.Fill(table);
                DataRowCollection rowColl = table.Rows;

                for (int i = 0; i < rowColl.Count; i++)
                {
                    DataRow row1 = rowColl[i];

                    var one = row1.ItemArray[0];
                    var two = row1.ItemArray[1];

                    var three = row1.ItemArray[2];
                    var four = CheckBoolValue(row1.ItemArray[3].ToString());
                    var five = CheckBoolValue(row1.ItemArray[4].ToString());

                    //incident string
                    var incidentString = row1.ItemArray[5];
                    //flag for has incident
                    var incidentFlag = CheckBoolValue(row1.ItemArray[6].ToString());

                    string[] array = new string[6] { one.ToString(), two.ToString(), three.ToString(), four.ToString(), five.ToString(), incidentFlag.ToString() };
                    IncidentStrings.Add(incidentString.ToString());



                    ListViewItem item = new ListViewItem(array);
                    listView1.Items.Add(item);
                    e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
                    sql.Close();
                }
            }
            else if (e.Control && e.KeyCode == Keys.Z)       // Ctrl-S populate from entire table - for debugging
            {
                AddPatron AddPatron = new AddPatron();
                AddPatron.ShowDialog();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                AddVisit av = new AddVisit();
                av.ShowDialog();
                e.SuppressKeyPress = true;
            }

                

            
        }
        //call me everytime the user searches again
        private void ClearUI()
        {
            susState = SuspendState.Intial;
            btnSuspend.Enabled = false;
            IncidentStrings.Clear();
            listView1.Items.Clear();
            txtincedent.Text = "";
            label8.Text = "";
            label10.Text = "";
            label13.Text = "";
            button2.Enabled = false;
            btnSuspend.Text = "Suspend Patron";
            lblsuspstatus.Text = "Select User";
            suspendTime.Text = DateTime.Now.ToString("M/d/yyyy");
            label6.Text = "";
            btnDeletePatron.Enabled = false;
            btnClrIncidents.Enabled = false;
        }
        private string CheckBoolValue(string boolValue)
        {
            if (boolValue == "1")
                return "True";
            else
                return "False";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearUI();

            if(this.fNameBox.ToString() == "" && this.lNameBox.ToString() == "" && this.iDNumberBox.ToString() == "")
            {
                return;
            }

            MySqlConnection sql = new MySqlConnection(connectionstring.CS);

            //sql.Open();

            //  SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter("Select Count(*) From NotTable where UserName = '" + userNameText.Text + "' and Password = '" + Password.Text + "'", sql);


            //DataTable myDataTable = new DataTable();
            //mySqlDataAdapter.Fill(myDataTable);

            //if (myDataTable.Rows[0][0].ToString() == "1")
            //{

            MySqlDataAdapter sqlDA = new MySqlDataAdapter("SELECT * FROM STUDENT", sql);

                DataTable table = new DataTable();
                sqlDA.Fill(table);
                DataRowCollection rowColl = table.Rows;
            sql.Close();
            for (int i = 0; i < rowColl.Count; i++)
            {
                DataRow row1 = rowColl[i];

                var one = row1.ItemArray[0];
                var two = row1.ItemArray[1];
                var id = row1.ItemArray[2];

                //user is searching with first and last name
                if (one.ToString().ToUpper() == fNameBox.Text.ToUpper() && two.ToString().ToUpper() == lNameBox.Text.ToUpper())
                {
                    var three = row1.ItemArray[2];
                    var four = CheckBoolValue(row1.ItemArray[3].ToString());
                    var five = CheckBoolValue(row1.ItemArray[4].ToString());

                    //incident string
                    var incidentString = row1.ItemArray[5];
                    //flag for has incident
                    var incidentFlag = CheckBoolValue(row1.ItemArray[6].ToString());
                    

                    string[] array = new string[6] { one.ToString(), two.ToString(), three.ToString(), four.ToString(), five.ToString(), incidentFlag.ToString() };
                    IncidentStrings.Add(incidentString.ToString());



                    ListViewItem item = new ListViewItem(array);
                    listView1.Items.Add(item);



                }
                //user searching with only ID number
                else if (id.ToString() == this.iDNumberBox.Text)
                {
                    DataSet studentTable = new DataSet();
                    MySqlConnection nsql = new MySqlConnection(connectionstring.CS);

                    //sql.Open();

                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select Count(*) From STUDENT where ID = '" + iDNumberBox.Text + "'", nsql);


                    DataTable myDataTable = new DataTable();
                    mySqlDataAdapter.Fill(myDataTable);
                    



                    if (myDataTable.Rows[0][0].ToString() == "1")
                    {

                        MySqlDataAdapter nsqlDA = new MySqlDataAdapter("SELECT * FROM STUDENT", nsql);

                        DataTable ntable = new DataTable();
                        nsqlDA.Fill(ntable);
                        DataRowCollection nrowColl = ntable.Rows;

                        for (int ii = 0; ii < nrowColl.Count; ii++)
                        {
                            DataRow nrow1 = nrowColl[ii];

                            var three = nrow1.ItemArray[2];
                            //  var two = row1.ItemArray[1];

                            if (three.ToString() == iDNumberBox.Text)
                            {
                                var none = nrow1.ItemArray[0];
                                var ntwo = nrow1.ItemArray[1];


                                var four = CheckBoolValue(nrow1.ItemArray[3].ToString());
                                var five = CheckBoolValue(nrow1.ItemArray[4].ToString());

                                //get the hasIncident bool
                                var incidentFlag = CheckBoolValue(nrow1.ItemArray[6].ToString());
                                IncidentStrings.Add(nrow1.ItemArray[5].ToString());

                                string[] array = new string[6] { none.ToString(), ntwo.ToString(), three.ToString(), four.ToString(), five.ToString(), incidentFlag.ToString() };
                                ListViewItem item = new ListViewItem(array);
                                listView1.Items.Add(item);

                            }
                        }
                    }
                    nsql.Close();
                }
                //User searches to patron using only the first name
                else if (one.ToString().ToUpper() == fNameBox.Text.ToUpper() && lNameBox.Text == "")
                {
                    var three = row1.ItemArray[2];
                    var four = CheckBoolValue(row1.ItemArray[3].ToString());
                    var five = CheckBoolValue(row1.ItemArray[4].ToString());

                    var incidentFlag = CheckBoolValue(row1.ItemArray[6].ToString());
                    IncidentStrings.Add(row1.ItemArray[5].ToString());

                    string[] array = new string[6] { one.ToString(), two.ToString(), three.ToString(), four.ToString(), five.ToString(), incidentFlag.ToString() };




                    ListViewItem item = new ListViewItem(array);
                    listView1.Items.Add(item);

                }
                //User searches for a patron using only the last name
                else if(fNameBox.Text == "" &&  lNameBox.Text.ToUpper() == two.ToString().ToUpper())
                {
                    var three = row1.ItemArray[2];
                    var four = CheckBoolValue(row1.ItemArray[3].ToString());
                    var five = CheckBoolValue(row1.ItemArray[4].ToString());
                    var incidentFlag = CheckBoolValue(row1.ItemArray[6].ToString());
                    IncidentStrings.Add(row1.ItemArray[5].ToString());

                    string[] array = new string[6] { one.ToString(), two.ToString(), three.ToString(), four.ToString(), five.ToString(), incidentFlag.ToString()};




                    ListViewItem item = new ListViewItem(array);
                    listView1.Items.Add(item);

                }

            }
                
            



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = listView1.FocusedItem;
            int index = item.Index;

            //label8.Text = listView1.Items[0].SubItems[0].Text;
            //label10.Text = listView1.Items[0].SubItems[1].Text;
            //label6.Text = listView1.Items[0].SubItems[1].Text;
            //label13.Text = listView1.Items[0].SubItems[2].Text;

            label8.Text = item.SubItems[0].Text;
            label10.Text = item.SubItems[1].Text;
            label6.Text = item.SubItems[1].Text;
            label13.Text = item.SubItems[2].Text;
            button2.Enabled = true;
            btnClrIncidents.Enabled = true;
            btnDeletePatron.Enabled = true;

            if (item.SubItems[5].Text.ToUpper() == "TRUE")
            {
                txtincedent.Text = IncidentStrings[index];
            }
            else
                txtincedent.Text = "";

            //lets see if this person is suspended 
            MySqlConnection sql = new MySqlConnection(connectionstring.CS);


            MySqlDataAdapter sqlDA = new MySqlDataAdapter("SELECT * From susp WHERE ID = '" + label13.Text + "'", sql);


            DataTable table = new DataTable();
            sqlDA.Fill(table);
            DataRowCollection rowColl = table.Rows;

            if(rowColl.Count != 1)
            {
                lblsuspstatus.Text = "Not Suspended";
                btnSuspend.Enabled = true;
                btnSuspend.Text = "Suspend Patron";
                susState = SuspendState.CanSuspend;
                return;
            }
            else
            {
                DataRow row1 = rowColl[0];
                suspendTime.Text = row1.ItemArray[3].ToString();
               // lblsuspstatus.Text = "Suspended since " + row1.ItemArray[2].ToString();
                lblsuspstatus.Text = "Suspended since " + DateTime.Parse(row1.ItemArray[2].ToString()).ToString("M/d/yyyy");
                btnSuspend.Enabled = true;
                btnSuspend.Text = "Remove Suspension";
                susState = SuspendState.CanRemove;
            }
            sql.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection sql = new MySqlConnection(connectionstring.CS);


            MySqlDataAdapter sqlDA = new MySqlDataAdapter("UPDATE STUDENT SET incident = '" + txtincedent.Text + "' WHERE ID = '" + label13.Text + "'", sql);

            DataTable table = new DataTable();
            sqlDA.Fill(table);
            DataRowCollection rowColl = table.Rows;

            MySqlDataAdapter sqlDB = new MySqlDataAdapter("UPDATE STUDENT SET hasIncident = 1, adminseenincident = 0 WHERE ID = '" + label13.Text + "'", sql);

            table = new DataTable();
            sqlDB.Fill(table);
            rowColl = table.Rows;

            ListViewItem item = listView1.FocusedItem;
            int index = item.Index;

            IncidentStrings[index] = txtincedent.Text;

            item.SubItems[5].Text = "True";

            MessageBox.Show("Successfully added Incident Report!");
            sql.Close();

        }

        private void ToggleState()
        {
            if(susState == SuspendState.CanRemove)
            {
                susState = SuspendState.CanSuspend;
                btnSuspend.Text = "Suspend User";
                lblsuspstatus.Text = "Suspension Removed!";
            }
            else if (susState == SuspendState.CanSuspend)
            {
                susState = SuspendState.CanRemove;
                btnSuspend.Text = "Remove Suspension";
                lblsuspstatus.Text = "Suspension Added";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(susState == SuspendState.Intial)
            {
                return;
            }
            else if(susState == SuspendState.CanRemove)
            {
                MySqlConnection sql = new MySqlConnection(connectionstring.CS);


                MySqlDataAdapter sqlDA = new MySqlDataAdapter("DELETE FROM susp WHERE ID = '" + label13.Text + "'", sql);

                DataTable table = new DataTable();
                sqlDA.Fill(table);
                DataRowCollection rowColl = table.Rows;

                MessageBox.Show("Successfully removed suspension!");
                sql.Close();
                ToggleState();
            }
            else if(susState == SuspendState.CanSuspend)
            {
                MySqlConnection sql = new MySqlConnection(connectionstring.CS);

                string test = DateTime.Parse(lbldate.Text).ToString("yyyy-MM-dd");

                MySqlDataAdapter sqlDA = new MySqlDataAdapter("INSERT INTO susp(ID, suspensionStarted, suspensionEnds) VALUES ('" + label13.Text + "', '" + DateTime.Parse(lbldate.Text).ToString("yyyy-MM-dd") + "','" + DateTime.Parse(suspendTime.Text).ToString("yyyy-MM-dd") + "')", sql);

                DataTable table = new DataTable();
                sqlDA.Fill(table);
                DataRowCollection rowColl = table.Rows;

                MessageBox.Show("Successfully added suspension!");
                sql.Close();

                ToggleState();
            }
        }

        private void btnDeletePatron_Click(object sender, EventArgs e)
        {
            try {
                MySqlConnection sql = new MySqlConnection(connectionstring.CS);


                MySqlDataAdapter sqlDA = new MySqlDataAdapter("DELETE FROM STUDENT WHERE ID = '" + label13.Text + "'", sql);

                DataTable table = new DataTable();
                sqlDA.Fill(table);
                DataRowCollection rowColl = table.Rows;

                MessageBox.Show("Successfully removed patron!");
                sql.Close();

                ClearUI();

            }
            catch(Exception)
            {
                MessageBox.Show("Remove any suspensions before deleting");
            }

        }

        private void btnClrIncidents_Click(object sender, EventArgs e)
        {
            MySqlConnection sql = new MySqlConnection(connectionstring.CS);


            MySqlDataAdapter sqlDA = new MySqlDataAdapter("UPDATE STUDENT SET incident = '' WHERE ID = '" + label13.Text + "'", sql);

            DataTable table = new DataTable();
            sqlDA.Fill(table);
            DataRowCollection rowColl = table.Rows;

            sqlDA = new MySqlDataAdapter("UPDATE STUDENT SET hasIncident = 0, adminseenincident = 1 WHERE ID = '" + label13.Text + "'", sql);

            table = new DataTable();
            sqlDA.Fill(table);
            rowColl = table.Rows;

            ListViewItem item = listView1.FocusedItem;
            int index = item.Index;

            IncidentStrings[index] = "";

            item.SubItems[5].Text = "False";

            txtincedent.Text = "";

            MessageBox.Show("Deleted Incident Report");
            sql.Close();

        }
    }
}
