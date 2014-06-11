using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
//            StoredProcedureOrder spo = new StoredProcedureOrder("DTAMM", "user_system", "test procedure", true, new ArrayList(2), new ArrayList(2), "Create", false, null, "ID", "USERS");
//            Object[] o = {spo};
//            DataTable dt = GetDataTableFromObjects(o);
//            storedProcedureOrderGridView.DataSource = dt;
            System.Windows.Forms.DataGridViewTextBoxColumn Title = new DataGridViewTextBoxColumn();
            System.Windows.Forms.DataGridViewTextBoxColumn Author = new DataGridViewTextBoxColumn();
            System.Windows.Forms.DataGridViewTextBoxColumn Publisher = new DataGridViewTextBoxColumn();
            System.Windows.Forms.DataGridViewTextBoxColumn City = new DataGridViewTextBoxColumn();
            System.Windows.Forms.DataGridViewTextBoxColumn Year = new DataGridViewTextBoxColumn();
            storedProcedureOrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Title,
            Author,
            Publisher,
            City,
            Year});
            string[] row0 = { "C# 3.0 Pocket Reference", "Albahari", "O'Reilly", "Sebastopol, CA", "2008" };
            storedProcedureOrderGridView.Rows.Add(row0);
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
            progressBar1.Value = 100;
        }
        private void populateDbaseList(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                 dbaseList.Items.Add(row[table.Columns.IndexOf("database_name")]);
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
            dbaseList.Items.Clear();
            DataTable schema = DAL.getDbaseMetaData(DAL.buildConnString(userText.Text,passwordText.Text,serverList.Text));
            populateDbaseList(schema);
        }

        private void dbaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableList.Items.Clear();
            DataTable schema = DAL.getTableMetaData(DAL.buildConnString(userText.Text, passwordText.Text, serverList.Text, dbaseList.Text));
            populateTableList(schema);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static DataTable GetDataTableFromObjects(object[] objects)
        {
            if (objects != null && objects.Length > 0)
            {
                Type t = objects[0].GetType();
                DataTable dt = new DataTable(t.Name);
                foreach (PropertyInfo pi in t.GetProperties())
                {
                    dt.Columns.Add(new DataColumn(pi.Name));
                }
                foreach (var o in objects)
                {
                    DataRow dr = dt.NewRow();
                    foreach (DataColumn dc in dt.Columns)
                    {
                        dr[dc.ColumnName] = o.GetType().GetProperty(dc.ColumnName).GetValue(o, null);
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            return null;
        }
    }
}
