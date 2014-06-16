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

        public MultiSelectionWindow(DataTable dt, string schema, string tableName)
        {
            InitializeComponent();
            _requestingTable = dt;
            _tableName = tableName;
            _schema = schema;

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
    }
}
