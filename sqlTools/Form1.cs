using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace sqlTools
{
    public partial class Form1 : Form
    {
        bool userFlag = false;

        public Form1()
        {
            InitializeComponent();
            populateServerList(DAL.getServerList());
        }

        private void tableOfContents()
        {
            button1_Click(null,null);
            populateTableList(null);
            populateSchemaList(null);
            populateServerList(null);
            populateDbaseList(null);
            userText_GotFocus(null, null);
            userText_TextChanged(null, null);
            refreshServerListButton_Click(null, null);
            serverList_SelectedIndexChanged(null, null);
            dbaseList_SelectedIndexChanged(null, null);
            tableList_SelectedIndexChanged(null, null);
            storedProcedureOrderGridView_cellClick(null, null);
            storedProcedureOrderGridView_cellEdit(null, null);
            datgridViewToSPO(null);
            addRowButton_Click(null, null);
            populateTableCB();
            listBox1_SelectedIndexChanged(null, null);
            fillParameterCB(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowlList = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in storedProcedureOrderGridView.Rows)
            {
                rowlList.Add(row);
            }
            List<StoredProcedureOrder> spoList = new List<StoredProcedureOrder>();
            spoList.Equals(datgridViewToSPO(rowlList));
            Console.WriteLine("Test");
        }

        private void populateTableList(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                    tableList.Items.Add(row[table.Columns.IndexOf("TABLE_NAME")]);
            }
        }
        private void populateSchemaList(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                if (!schemaList.Items.Contains(row[table.Columns.IndexOf("TABLE_SCHEMA")]))
                {
                    schemaList.Items.Add(row[table.Columns.IndexOf("TABLE_SCHEMA")]);
                }
            }
        }
        private void populateServerList(System.Data.DataTable table)
        {
            
            foreach (System.Data.DataRow row in table.Rows)
            {   
                serverList.Update();

                string s = serverList.Items.ToString();
                string t = row[table.Columns.IndexOf("ServerName")].ToString();
                if (s.ToString().Contains(t.ToString())) { }
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
            schemaList.Items.Clear();
            DataTable schema = DAL.getSchemaMetaData(DAL.buildConnString(userText.Text, passwordText.Text, serverList.Text, dbaseList.Text));
            populateSchemaList(schema);
        }

        private void tableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            storedProcedureOrderGridView.Enabled = true;
        }
        private void storedProcedureOrderGridView_cellClick(object sender, EventArgs e)
        {
            DataGridView sendingGridView = (DataGridView)sender;
            DataGridViewCellEventArgs argument = (DataGridViewCellEventArgs) e;
            if (storedProcedureOrderGridView.Columns[argument.ColumnIndex].GetType() ==
                typeof (DataGridViewButtonColumn))
            {
                if (argument.ColumnIndex == 6)
                {
                    fillParameterCB(sendingGridView, argument);
                }
                if (argument.ColumnIndex == 8)
                {
                    fillParameterCB(sendingGridView, argument);
                }
                if (argument.ColumnIndex == 13)
                {
                    fillParameterCB(sendingGridView, argument);
                }
            }
            
            
        }

        private void storedProcedureOrderGridView_cellEdit(object sender, EventArgs e)
        {
            DataGridView sendingGridView = (DataGridView)sender;
            DataGridViewCellEventArgs argument = (DataGridViewCellEventArgs)e;
            try
            {
                if (argument.ColumnIndex == 2 &&
                    !sendingGridView.Rows[argument.RowIndex].Cells[argument.ColumnIndex].Value.Equals(null))
                {
                    string connString = DAL.buildConnString(userText.Text, passwordText.Text, serverList.Text, dbaseList.Text);
                    DataTable dt = DAL.getColumnMetaData(connString, schemaList.Text);
                    DataGridViewComboBoxCell cb1 = new DataGridViewComboBoxCell();
                    DataGridViewComboBoxCell cb2 = new DataGridViewComboBoxCell();
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        string tableName = sendingGridView.Rows[argument.RowIndex].Cells[2].Value.ToString();
                        if (dataRow[1].ToString().Equals(schemaList.Text) && dataRow[2].ToString().Equals(tableName))
                        {
                            String t = dataRow[dt.Columns.IndexOf("COLUMN_NAME")].ToString();
                            String[] s = t.Split('_');
                            if (s[0].ToLower().Equals(sendingGridView.Rows[argument.RowIndex].Cells[2].Value.ToString().ToLower())) //Check if field name is prefixed with table name
                            {
                                string newSelection = "@" + s[1];
                                cb1.Items.Add(newSelection);                                                                   //If it is remove table name for parameter
                            }
                            else
                            {
                                cb1.Items.Add(dataRow[dt.Columns.IndexOf("COLUMN_NAME")]);    
                            }
                            cb2.Items.Add(dataRow[dt.Columns.IndexOf("COLUMN_NAME")]);
                        }
                    }
                    storedProcedureOrderGridView.Rows[argument.RowIndex].Cells[11] = cb1;
                    storedProcedureOrderGridView.Rows[argument.RowIndex].Cells[12] = cb2;
                }
            }
            catch (NullReferenceException)
            {
                
            }
        }

        private List <StoredProcedureOrder> datgridViewToSPO(List<DataGridViewRow> gridViewRowList)
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
                        if (cell.ColumnIndex == 5 || cell.ColumnIndex == 7 || cell.ColumnIndex == 12)  //These cells use a combo box to hold multiple selected values
                        {                                                                              //Because of that they need to be pulled into a list before passed.
                            List<string> valueList = new List<string>();
                            DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)cell;
                            foreach (string value in comboBoxCell.Items)
                            {
                                valueList.Add(value);
                            }
                            spo.setFieldValue(cell.DataGridView.Columns[cell.ColumnIndex].Name, valueList);
                        }
                        else
                        {
                            spo.setFieldValue(cell.DataGridView.Columns[cell.ColumnIndex].Name, cell.Value);    
                        }
                    }
                }
                spoList.Add(spo);

            }
            
            return spoList;

        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            int rowIndex = storedProcedureOrderGridView.Rows.Add();
            storedProcedureOrderGridView.Rows[rowIndex].Cells[0].Value = dbaseList.Text;  // Pull DB from DB list
            storedProcedureOrderGridView.Rows[rowIndex].Cells[1].Value = schemaList.Text; // Pull schema from schema list
            storedProcedureOrderGridView.Rows[rowIndex].Cells[2] = populateTableCB(); // Populate table cb from schema selection
            
        }

        private DataGridViewComboBoxCell populateTableCB()
        {
            DataGridViewComboBoxCell CBCell = new DataGridViewComboBoxCell();
            DataTable schema = DAL.getTableMetaData(DAL.buildConnString(userText.Text, passwordText.Text, serverList.Text, dbaseList.Text));
            foreach (System.Data.DataRow row in schema.Rows)
            {
                object o = schemaList.Text;
                object t = row[schema.Columns.IndexOf("TABLE_SCHEMA")];
                if (t.ToString().Equals(o.ToString()))
                {
                    CBCell.Items.Add(row[schema.Columns.IndexOf("TABLE_NAME")]);

                }
            }
            return CBCell;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillParameterCB(DataGridView gridView, DataGridViewCellEventArgs argument)
        {
            string connString = DAL.buildConnString(userText.Text, passwordText.Text, serverList.Text, dbaseList.Text);
            DataTable dt = DAL.getColumnMetaData(connString, schemaList.Text);
            try
            {
                string selectedTable = gridView.Rows[argument.RowIndex].Cells[2].Value.ToString();
                SelectionWindow sw = new SelectionWindow(dt, schemaList.Text, selectedTable, "COLUMN_NAME", gridView, argument.RowIndex, argument.ColumnIndex);
                sw.Visible = true;
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show("Please select a table first!", "SQL Tools", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
            }
        }
    }
}
