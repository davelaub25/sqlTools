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

        static string conn = "user id=dlaub; password=pooper1; server=10.10.10.10; Trusted_Connection=yes; connection timeout=30"; //For test purposes only
        
        StoredProcedureOrder testSpo = new StoredProcedureOrder("Test DBase", "Test Schema", "Test Name", true, //For test purposes only
            new List<string>(2), new List<string>(2), "Type in", true, "Test Parameter", 
            "Test Output", "Test Table Name");

        static DataTable _orderTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> dgvrList = new List<DataGridViewRow>();
            dgvrList.Add(storedProcedureOrderGridView.Rows[0]);
            List<StoredProcedureOrder> spoList = datgridViewToSPO(dgvrList);
            Console.WriteLine(spoList[0].dbase);

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
        public static List<DataRow> GetDataTableFromObjects(List<StoredProcedureOrder> spo)
        {
            List<DataRow> dr = new List<DataRow>();
            for (int i = 0; i < spo.Count; i++)
            {
                DataRow newRow = _orderTable.NewRow();
                foreach (FieldInfo property in spo[i].GetType().GetFields())
                {
                    newRow[property.Name] = spo[i].GetType().GetField(property.Name).GetValue(spo[i]);
                }
                dr.Add(newRow);
            }
            return dr;
        }

        private void tableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            storedProcedureOrderGridView.Enabled = true;
        }

        private List<StoredProcedureOrder> datgridViewToSPO(List<DataGridViewRow> gridViewRowList)
        {

            List<StoredProcedureOrder> spoList = new List<StoredProcedureOrder>();

            foreach (DataGridViewRow gridViewRow in gridViewRowList)
            {
                StoredProcedureOrder spo = new StoredProcedureOrder();

                foreach (DataGridViewCell cell in gridViewRow.Cells)
                {
                    String cellColumnHeader = cell.DataGridView.Columns[cell.ColumnIndex].Name;
                    if (!cellColumnHeader.Contains("Button"))
                    {

                        spo.setFieldValue(cell.DataGridView.Columns[cell.ColumnIndex].Name, cell.Value);
                        //spo.GetType().GetProperty(cellColumnHeader).SetValue();
                    }
                }
                spoList.Add(spo);

            }
            
            return spoList;

        } 


    }
}
