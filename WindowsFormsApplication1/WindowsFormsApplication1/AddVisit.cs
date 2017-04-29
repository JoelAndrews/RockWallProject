using MySql.Data.MySqlClient;
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
    public partial class AddVisit : Form
    {
        public AddVisit()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Must enter a value for ID number");
                return;
            }
            MySqlConnection sql = new MySqlConnection(connectionstring.CS);
            string test = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd HH:mm:ss");


            MySqlDataAdapter sqlDA = new MySqlDataAdapter("INSERT INTO Visit(PatronID, DateofVisit) VALUES ('" + textBox1.Text + "', '" + test + "')", sql);

            DataTable table = new DataTable();
            sqlDA.Fill(table);
            DataRowCollection rowColl = table.Rows;

            MessageBox.Show("Worked!");

        }
    }
}
