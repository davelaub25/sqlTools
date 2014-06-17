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
    public partial class MultiSelectionWindow : Form
    {
        private DataTable _requestingTable;
        private string _tableName;
        private string _schema;
        private int _sendingRow;
        private int _parameterCBRow = 11;

        public MultiSelectionWindow(DataTable dt, string schema, string tableName, int sendingRowIn)
        {
            InitializeComponent();
            _requestingTable = dt;
            _tableName = tableName;
            _schema = schema;
            _sendingRow = sendingRowIn;

            Console.WriteLine("Window Initialized");
            DataGridViewComboBoxCell cb1 = new DataGridViewComboBoxCell();
            DataGridViewComboBoxCell cb2 = new DataGridViewComboBoxCell();
            foreach (DataRow dataRow in dt.Rows)
            {
                if (dataRow[1].ToString().Equals(schema) && dataRow[2].ToString().Equals(tableName))
                {
                    String t = dataRow[dt.Columns.IndexOf("COLUMN_NAME")].ToString();
                    String[] s = t.Split('_');
                    if (s[0].ToLower().Equals(tableName.ToLower())) //Check if field name is prefixed with table name
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
            multiSelectionGridView.Rows.Add(new DataGridViewRow());
            multiSelectionGridView.Rows[0].Cells[0] = cb1;
            multiSelectionGridView.Rows[0].Cells[1].Value = "=";
            multiSelectionGridView.Rows[0].Cells[2] = cb2;
        }

        private void MultiSelectionWindow_Load(object sender, EventArgs e)
        {

        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            int newRowIndex = multiSelectionGridView.Rows.Add();
            DataGridViewComboBoxCell cb1 = new DataGridViewComboBoxCell();
            DataGridViewComboBoxCell cb2 = new DataGridViewComboBoxCell();
            foreach (DataRow dataRow in _requestingTable.Rows)
            {
                if (dataRow[1].ToString().Equals(_schema) && dataRow[2].ToString().Equals(_tableName))
                {
                    String t = dataRow[_requestingTable.Columns.IndexOf("COLUMN_NAME")].ToString();
                    String[] s = t.Split('_');
                    if (s[0].ToLower().Equals(_tableName.ToLower())) //Check if field name is prefixed with table name
                    {
                        string newSelection = "@" + s[1];
                        cb1.Items.Add(newSelection);                                                                   //If it is remove table name for parameter
                    }
                    else
                    {
                        cb1.Items.Add(dataRow[_requestingTable.Columns.IndexOf("COLUMN_NAME")]);
                    }
                    cb2.Items.Add(dataRow[_requestingTable.Columns.IndexOf("COLUMN_NAME")]);
                }
            }
            multiSelectionGridView.Rows[newRowIndex].Cells[0] = cb1;
            multiSelectionGridView.Rows[newRowIndex].Cells[1].Value = "=";
            multiSelectionGridView.Rows[newRowIndex].Cells[2] = cb2;
        }

        private void maskButton_Click(object sender, EventArgs e)
        {
            for (int h = 0; h < multiSelectionGridView.Rows.Count; h++)
            {
                int selectedIndex = ((DataGridViewComboBoxCell) multiSelectionGridView.Rows[h].Cells[0]).Items.IndexOf(
                    multiSelectionGridView.Rows[h].Cells[0].Value);
                DataGridViewComboBoxCell cbCell = new DataGridViewComboBoxCell();
                for (int i = 0; i < ((DataGridViewComboBoxCell)multiSelectionGridView.Rows[h].Cells[0]).Items.Count; i++)
                {
                    string cellValue = ((DataGridViewComboBoxCell) multiSelectionGridView.Rows[h].Cells[0]).Items[i].ToString();
                    cbCell.Items.Add(maskTextString(cellValue, maskTextBox.Text));
                }
                cbCell.Value = cbCell.Items[selectedIndex];
                multiSelectionGridView.Rows[h].Cells[0] = cbCell;
            }
        }

        private string maskTextString(string inputText, string inputMask)
        {
            List<int> hashLocations = new List<int>();
            for (int i = 0; i < inputMask.Length; i++)
            {
                if (inputMask[i].Equals('#'))
                {
                    hashLocations.Add(i+1);
                }
            }
            List<string> newItems = new List<string>();

            string origItem = inputText;
            string tempItem = "";
            string tempHash = "";
            for (int j = 1; j < inputText.Length-1; j++)
            {
                if (hashLocations.Contains(j))
                {
                    tempHash = tempHash + "#";
                }
                else
                {
                    tempHash = tempHash + "*";
                }
            }
            for (int j = 0; j < tempHash.Length; j++)
            {
                if (tempHash[j] == ('#'))
                {
                }
                else
                {
                    tempItem = tempItem + origItem[j+1];
                }
            }
            return "@" + tempItem;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell comboBox = new DataGridViewComboBoxCell();

            foreach (DataGridViewRow row in multiSelectionGridView.Rows)
            {
                string col1Text = row.Cells[0].Value.ToString();
                string col2Text = row.Cells[1].Value.ToString();
                string col3Text = row.Cells[2].Value.ToString();
                comboBox.Items.Add(col1Text + " " + col2Text + " " + col3Text);

            }
            comboBox.FlatStyle = FlatStyle.Standard;
            Form1.storedProcedureOrderGridView.Rows[_sendingRow].Cells[_parameterCBRow] = comboBox; 
            this.Close();
        }
    }
}
