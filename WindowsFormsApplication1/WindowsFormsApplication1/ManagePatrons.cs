using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ManagePatrons : Form
    {
        public ManagePatrons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if(this.fNameBox.ToString() == "" && this.lNameBox.ToString() == "" && this.iDNumberBox.ToString() == "")
            {
                return;
            }

            SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\joela\Documents\test.mdf; Integrated Security = True; Connect Timeout = 30;");

            //sql.Open();

          //  SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter("Select Count(*) From NotTable where UserName = '" + userNameText.Text + "' and Password = '" + Password.Text + "'", sql);


            //DataTable myDataTable = new DataTable();
            //mySqlDataAdapter.Fill(myDataTable);

            //if (myDataTable.Rows[0][0].ToString() == "1")
            //{

                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM STUDENT", sql);

                DataTable table = new DataTable();
                sqlDA.Fill(table);
                DataRowCollection rowColl = table.Rows;

            for (int i = 0; i < rowColl.Count; i++)
            {
                DataRow row1 = rowColl[i];

                var one = row1.ItemArray[0];
                var two = row1.ItemArray[1];
                var id = row1.ItemArray[2];

                if (one.ToString().ToUpper() == fNameBox.Text.ToUpper() && two.ToString().ToUpper() == lNameBox.Text.ToUpper())
                {
                    var three = row1.ItemArray[2];
                    var four = row1.ItemArray[3];
                    var five = row1.ItemArray[4];

                    string[] array = new string[5] { one.ToString(), two.ToString(), three.ToString(), four.ToString(), five.ToString() };




                    ListViewItem item = new ListViewItem(array);
                    listView1.Items.Add(item);



                }
                else if (id.ToString() == this.iDNumberBox.Text)
                {
                    DataSet studentTable = new DataSet();
                    SqlConnection nsql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\joela\Documents\test.mdf; Integrated Security = True; Connect Timeout = 30;");

                    //sql.Open();

                    SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter("Select Count(*) From STUDENT where ID = '" + iDNumberBox.Text + "'", nsql);


                    DataTable myDataTable = new DataTable();
                    mySqlDataAdapter.Fill(myDataTable);



                    if (myDataTable.Rows[0][0].ToString() == "1")
                    {

                        SqlDataAdapter nsqlDA = new SqlDataAdapter("SELECT * FROM STUDENT", sql);

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


                                var four = nrow1.ItemArray[3];
                                var five = nrow1.ItemArray[4];

                                string[] array = new string[5] { none.ToString(), ntwo.ToString(), three.ToString(), four.ToString(), five.ToString() };
                                ListViewItem item = new ListViewItem(array);
                                listView1.Items.Add(item);

                            }
                        }
                    }
                }
                else if (one.ToString().ToUpper() == fNameBox.Text.ToUpper() && lNameBox.Text == "")
                {
                    var three = row1.ItemArray[2];
                    var four = row1.ItemArray[3];
                    var five = row1.ItemArray[4];

                    string[] array = new string[5] { one.ToString(), two.ToString(), three.ToString(), four.ToString(), five.ToString() };




                    ListViewItem item = new ListViewItem(array);
                    listView1.Items.Add(item);

                }
                else if(fNameBox.Text == "" &&  lNameBox.Text.ToUpper() == two.ToString().ToUpper())
                {
                    var three = row1.ItemArray[2];
                    var four = row1.ItemArray[3];
                    var five = row1.ItemArray[4];

                    string[] array = new string[5] { one.ToString(), two.ToString(), three.ToString(), four.ToString(), five.ToString() };




                    ListViewItem item = new ListViewItem(array);
                    listView1.Items.Add(item);

                }

            }
                
            



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = listView1.FocusedItem;
            ListViewItem.ListViewSubItemCollection that = item.SubItems;
            label8.Text = listView1.Items[0].SubItems[0].Text;
            label10.Text = listView1.Items[0].SubItems[1].Text;
            label6.Text = listView1.Items[0].SubItems[1].Text;
        }
    }
}
