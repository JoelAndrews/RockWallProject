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
    public partial class ChangePassword : Form
    {
        public string CurrentPassword;
        public string CurrentUserName;
        public ChangePassword(string cp, string cu)
        {
            InitializeComponent();
            this.CurrentPassword = cp;
            this.CurrentUserName = cu;
            this.label4.Text = cu;
        }


        private void btnchangepass_Click_1(object sender, EventArgs e)
        {
            if (currPass.Text != this.CurrentPassword)
            {
                String message = "Password entered for current password is incorrect.";
                // message += this.CurrentPassword;
                MessageBox.Show(message);
                return;
            }


            MySqlConnection sql = new MySqlConnection(connectionstring.CS);


            MySqlDataAdapter sqlDA = new MySqlDataAdapter("SELECT * FROM Login", sql);

            DataTable table = new DataTable();
            sqlDA.Fill(table);
            DataRowCollection rowColl = table.Rows;


            for (int i = 0; i < rowColl.Count; i++)
            {
                DataRow row1 = rowColl[i];

                var three = row1.ItemArray[1];
                var one = row1.ItemArray[0];
                //  var two = row1.ItemArray[1];

                if (three.ToString() == this.CurrentPassword && one.ToString() == this.CurrentUserName)
                {



                    MySqlCommandBuilder cb;



                    table.Rows[i].BeginEdit();
                    //row1.ItemArray[3] = belayBox.Checked;
                    table.Rows[i][1] = newPass.Text;

                    //belayBox.Checked = (bool)four;
                    table.Rows[i].EndEdit();

                    cb = new MySqlCommandBuilder(sqlDA);
                    //sqlDA.DeleteCommand = cb.GetDeleteCommand(true);
                    //sqlDA.UpdateCommand = cb.GetUpdateCommand(true);
                    //sqlDA.InsertCommand = cb.GetInsertCommand(true);
                    //sqlDA.UpdateCommand = true;
                    sqlDA.UpdateCommand = cb.GetUpdateCommand();



                    sqlDA.Update(table);

                    String message = "Password successfully changed!";
                    MessageBox.Show(message);
                    this.CurrentPassword = newPass.Text;

                }


            }
            sql.Close();
        }
    }
}