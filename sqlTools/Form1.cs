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
            StoredProcedureOrder sp = new StoredProcedureOrder();
            int counter = 0;
            foreach (FieldInfo property in sp.GetType().GetFields())
            {
                //storedProcedureOrderGridView.Columns.Add(property.Name, property.Name);
                if (property.FieldType.Name.ToString() == "Boolean")
                {
                    DataGridViewCheckBoxColumn chkBoxCol = new DataGridViewCheckBoxColumn();
                    storedProcedureOrderGridView.Columns.Insert(counter, chkBoxCol);
                    storedProcedureOrderGridView.Columns[counter].ValueType = property.FieldType;
                    storedProcedureOrderGridView.Columns[counter].HeaderText = property.Name;
                    storedProcedureOrderGridView.Columns[counter].DefaultCellStyle.ForeColor.Equals(Color.DarkGray);
                    storedProcedureOrderGridView.Columns[counter].DefaultCellStyle.BackColor.Equals(Color.DimGray);
                }
                else
                {
                    storedProcedureOrderGridView.Columns[storedProcedureOrderGridView.Columns.Add(property.Name, property.Name)].ValueType = property.FieldType;
                    storedProcedureOrderGridView.Columns[counter].DefaultCellStyle.ForeColor.Equals(Color.DarkGray);
                    storedProcedureOrderGridView.Columns[counter].DefaultCellStyle.BackColor.Equals(Color.DimGray);
                }

                //storedProcedureOrderGridView.
                counter++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StoredProcedureOrder spo = new StoredProcedureOrder("DTAMM", "user_system", "test procedure", true, new ArrayList(2), new ArrayList(2), "Create", false, null, "ID", "USERS");
            List<StoredProcedureOrder> spoList = new List<StoredProcedureOrder>();
            spoList.Add(spo);
            storedProcedureOrderGridView.DataSource = GetDataTableFromObjects(spoList);
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
        public static DataTable GetDataTableFromObjects(List<StoredProcedureOrder> spo)
        {
            DataTable dt = new DataTable();
            dt.TableName = "StoredProcedureOrder";
            for (int i = 0; i < spo.Count; i++)
            {
                foreach (FieldInfo property in spo[i].GetType().GetFields())
                {
                    dt.Columns.Add(new DataColumn(property.Name, property.FieldType));
                }
                DataRow newRow = dt.NewRow();
                foreach (FieldInfo property in spo[i].GetType().GetFields())
                {
                    newRow[property.Name] = spo[i].GetType().GetField(property.Name).GetValue(spo[i]);
                }
                dt.Rows.Add(newRow);
            }
            return dt;
        }

        private void tableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            storedProcedureOrderGridView.Enabled = true;
        }


    }
}
