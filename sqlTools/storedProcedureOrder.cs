using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlTools
{
    public class StoredProcedureOrder
    {
        private String _dbase;
        private String _schema;
        private String _name;
        private bool _newProcedure;
        private List<String> _parameters;
        private List<String> _fields;
        private String _type;
        private bool _doBy;
        private String _doByParameter;
        private String _doByField;
        private List<String> _output;
        private String _tableName;

        public StoredProcedureOrder(String dbaseIn, String schemaIn, String nameIn, bool newProcedureIn, List<String> parametersIn, List<String> fieldsIn, String typeIn, bool doByIn, String doByParameterIn, String doByFieldin, List<String> outputIn, String tableNameIn)
        {
            this.dbase = dbaseIn;
            this.schema = schemaIn;
            this.name = nameIn;
            this.newProcedure = newProcedureIn;
            this.parameters = parametersIn;
            this.fields = fieldsIn;
            this.type = typeIn;
            this.doBy = doByIn;
            this.doByParameter = doByParameterIn;
            this.doByField = doByFieldin;
            this.output = outputIn;
            this.tableName = tableNameIn;
        }
        public StoredProcedureOrder()
        {
            this.dbase = null;
            this.schema = null;
            this.name = null;
            this.newProcedure = false;
            this.parameters = null;
            this.fields = null;
            this.type = null;
            this.doBy = false;
            this.doByParameter = null;
            this.doByField = null;
            this.output = null;
            this.tableName = null;
        }
        /////////////////////Sets///////////////////////////////////////////////
        public String dbase{

            get
            {
                return _dbase;
                
            }
            set
            {
                _dbase = value;
                
            }
        }
        public String schema
        {

            get
            {
                return _schema;

            }
            set
            {
                _schema = value;

            }
        }
        public String name
        {

            get
            {
                return _name;

            }
            set
            {
                _name = value;

            }
        }
        public bool newProcedure
        {

            get
            {
                return _newProcedure;

            }
            set
            {
                _newProcedure = value;

            }
        }
        public List<string> parameters
        {

            get
            {
                return _parameters;

            }
            set
            {
                _parameters = value;

            }
        }
        public string doByField
        {

            get
            {
                return _doByField;

            }
            set
            {
                _doByField = value;

            }
        }
        public List<string> fields
        {

            get
            {
                return _fields;

            }
            set
            {
                _fields = value;

            }
        }
        public String type
        {

            get
            {
                return _type;

            }
            set
            {
                _type = value;

            }
        }
        public bool doBy
        {

            get
            {
                return _doBy;

            }
            set
            {
                _doBy = value;

            }
        }
        public string doByParameter
        {

            get
            {
                return _doByParameter;

            }
            set
            {
                _doByParameter = value;

            }
        }
        public List<String> output
        {

            get
            {
                return _output;

            }
            set
            {
                _output = value;

            }
        }
        public String tableName
        {

            get
            {
                return _tableName;

            }
            set
            {
                _tableName = value;

            }
        }
        public String getFieldType(String s)
        {

            return this.GetType().GetField(s).GetValue(this).GetType().ToString();

        }

        public void setFieldValue(String fieldName, Object value)
        {
            try
            {
                this.GetType().GetProperty(fieldName).SetValue(this, value);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("\nValue could not be set because " + value.GetType().ToString() + " does not match the target fields type of " + this.GetType().GetField(fieldName).FieldType.ToString() + ".");
            }
        }
    }
}
