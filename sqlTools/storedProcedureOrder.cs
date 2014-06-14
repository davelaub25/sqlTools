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
        public String dbase;
        public String schema;
        public String name;
        public bool newProcedure;
        public List<String> parameters;
        public List<String> fields;
        public String type;
        public bool doBy;
        public String doByParameter;
        public String output;
        public String tableName;

        public StoredProcedureOrder(String dbaseIn, String schemaIn, String nameIn, bool newProcedureIn, List<String> parametersIn, List<String> fieldsIn, String typeIn, bool doByIn, String doByParameterIn, String outputIn, String tableNameIn)
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
            this.output = null;
            this.tableName = null;
        }
        /////////////////////Sets///////////////////////////////////////////////
        public void setDbase(String dbaseIn)
        {
            this.dbase = dbaseIn;
        }
        public void setSchema(String schemaIn)
        {
            this.schema = schemaIn;
        }
        public void setName(String nameIn)
        {
            this.name = nameIn;
        }
        public void setNewProcedure(bool newProcedureIn)
        {
            this.newProcedure = newProcedureIn;
        }
        public void setParameters(List<String> parametersIn)
        {
            this.parameters = parametersIn;
        }
        public void setFields(List<String> fieldsIn)
        {
            this.fields = fieldsIn;
        }
        public void setSpoType(String typeIn)
        {
            this.type = typeIn;
        }
        public void setDoBy(bool doByIn)
        {
            this.doBy = doByIn;
        }
        public void setDoByParameter(String doByParameterIn)
        {
            this.doByParameter = doByParameterIn;
        }
        public void setOutput(String outputIn)
        {
            this.output = outputIn;
        }
        public void setTableName(String tableNameIn)
        {
            this.tableName = tableNameIn;
        }
        ///////////////////Gets//////////////////////////////////////////////
        public String getDbase()
        {
            return this.dbase;
        }
        public String getSchema()
        {
            return this.schema;
        }
        public String getName()
        {
            return this.name;
        }
        public bool getNewProcedure()
        {
            return this.newProcedure;
        }
        public List<String> getParameters()
        {
            return this.parameters;
        }
        public List<string> getFields()
        {
            return this.fields;
        }
        public String getSpoType()
        {
            return this.type;
        }
        public bool getDoBy()
        {
            return this.doBy;
        }
        public String getDoByParameter()
        {
            return this.doByParameter;
        }
        public String getOutput()
        {
            return this.output;
        }
        public String getTableName()
        {
            return this.tableName;
        }

        public String getFieldType(String s)
        {

            return this.GetType().GetField(s).GetValue(this).GetType().ToString();

        }

        public void setFieldValue(String fieldName, Object value)
        {
            try
            {
                this.GetType().GetField(fieldName).SetValue(this, value);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("\nValue could not be set because " + value.GetType().ToString() + " does not match the target fields type of " + this.GetType().GetField(fieldName).FieldType.ToString() + ".");
            }
        }
    }
}
