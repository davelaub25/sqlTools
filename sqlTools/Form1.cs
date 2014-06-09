using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlTools
{
    public partial class Form1 : Form
    {
        bool userFlag = false;

        string conn = "user id=dlaub; password=pooper1; server=10.10.10.10; Trusted_Connection=yes; connection timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Console.WriteLine("Button Clicked");
            DataTable schema = DAL.getMetaData(conn);
            populateTableList(schema);
        }

        private void populateTableList(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                    tableList.Items.Add(row[table.Columns.IndexOf("TABLE_NAME")]);
            }
        }
        private void populateServerList(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {   
                serverList.Update();
                if (!serverList.Items.Contains(row[table.Columns.IndexOf("ServerName")])) { }
                {
                    serverList.Items.Add(row[table.Columns.IndexOf("ServerName")]);
                }    
            }
        }
        private void populateDbaseList(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    dbaseList.Items.Add(row[table.Columns.IndexOf("TABLE_CATALOG")]);
                }
            }
        }
        private void userText_GotFocus(object sender, EventArgs e)
        {
            if (!userFlag)
            {
                userText.Clear();
            }
        }

        private void userText_TextChanged(object sender, EventArgs e)
        {
            userFlag = true;
        }

        private void refreshServerListButton_Click(object sender, EventArgs e)
        {
            populateServerList(DAL.getServerList());
        }

        private void serverList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable schema = DAL.getMetaData(conn);
            populateDbaseList(schema);
        }
        private void buildConnString(String username, String pass, String serverName)
        {

        }
        private void buildConnString(String username, String pass, String serverName, String dbaseName)
        {

        }
    }
}
