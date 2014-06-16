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
    public partial class SelectionWindow : Form
    {
        private DataTable dataTable;
        private string filterString;
        private string selectedTable;
        private string returnType;
        private DataGridView requestingGrid;
        private int gridRow;
        private int gridCol;

        public SelectionWindow(DataTable dt, string filter, string currentTable, string dataType, DataGridView requestor, int row, int col)
        {
            InitializeComponent();
            dataTable = dt;
            filterString = filter;
            selectedTable = currentTable;
            returnType = dataType;
            requestingGrid = requestor;
            gridRow = row;
            gridCol = col;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow[1].ToString().Equals(filterString) && dataRow[2].ToString().Equals(selectedTable))
                {
                    if (gridCol == 6)
                    {
                        string t = dataRow[dataTable.Columns.IndexOf(returnType)].ToString();
                        string[] s = t.Split('_');
                        string tableName = requestingGrid.Rows[gridRow].Cells[2].Value.ToString().ToLower();
                        if (s[0].ToLower().Equals(tableName)) //Check if field name is prefixed with table name
                        {
                            selectionListBox.Items.Add(s[1] + " " +
                                                       dataRow[dataTable.Columns.IndexOf("DATA_TYPE")].ToString()
                                                       + "(" +
                                                       dataRow[dataTable.Columns.IndexOf("CHARACTER_MAXIMUM_LENGTH")]
                                                           .ToString() + ") ,");
                                //If it is remove table name for parameter
                        }
                        else
                        {
                            selectionListBox.Items.Add(dataRow[dataTable.Columns.IndexOf(returnType)].ToString() + " " +
                                                   dataRow[dataTable.Columns.IndexOf("DATA_TYPE")].ToString()
                                                   + "(" +
                                                   dataRow[dataTable.Columns.IndexOf("CHARACTER_MAXIMUM_LENGTH")]
                                                       .ToString() + ") ,");    
                        }
                        
                    }
                    else
                    {
                        selectionListBox.Items.Add(dataRow[dataTable.Columns.IndexOf(returnType)] + ",");    
                    }
                    
                }
            }

        }
        private void acceptButton_Click(object sender, EventArgs e)
        {

            DataGridViewComboBoxCell comboBox = new DataGridViewComboBoxCell();

            foreach (string selection in selectionListBox.CheckedItems)
            {
                if (gridCol.Equals(6))
                {
                    string[] s = selection.Split('_');
                    if (s[0].ToLower().Equals(requestingGrid.Rows[gridRow].Cells[2].Value.ToString().ToLower())) //Check if field name is prefixed with table name
                    {
                        string newSelection = s[1];
                        comboBox.Items.Add("@" + newSelection);                                            //If it is remove table name for parameter
                    }
                    else
                    {
                        comboBox.Items.Add("@" + selection);                                                //Otherwise add an @ sign and leave it be
                    }
                }
                else
                {
                    comboBox.Items.Add(selection);
                }
                
            }
            Form1.storedProcedureOrderGridView.Rows[gridRow].Cells[gridCol-1] = comboBox;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskButton_Click(object sender, EventArgs e){
            String mask = maskTextBox.Text;
            List<int> hashLocations = new List<int>();
            for (int i = 0; i < mask.Length; i++)
            {
                if (mask[i].Equals('#'))
                {
                    hashLocations.Add(i);
                }
            }
            List<string> newItems = new List<string>();
            for (int i = 0; i < selectionListBox.Items.Count; i++){
                string origItem = selectionListBox.Items[i].ToString();
                string tempItem = "";
                string tempHash = "";
                for (int j = 0; j < selectionListBox.Items[i].ToString().Length; j++){
                    if (hashLocations.Contains(j)){
                        tempHash = tempHash + "#";
                    }
                    else{
                        tempHash = tempHash + "*";
                    }
                }
                for (int j = 0; j < tempHash.Length; j++){
                    if (tempHash[j] == ('#')){}
                    else{
                        tempItem = tempItem + origItem[j];
                    }
                }
                newItems.Add(tempItem);
            }
            selectionListBox.Items.Clear();
            foreach (string replacement in newItems){
                selectionListBox.Items.Add(replacement);
            }
        }
    }
}
