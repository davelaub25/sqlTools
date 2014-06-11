using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlTools
{
    public class StoredProcedureOrder
    {
        public String dbase;
        public String schema;
        public String name;
        public bool newProcedure;
        public ArrayList parameters;    
        public ArrayList fields;
        public String type;
        public bool doBy;
        public String doByParameter;
        public String output;
        public String tableName;

        public StoredProcedureOrder(String dbaseIn, String schemaIn, String nameIn, bool newProcedureIn, ArrayList parametersIn, ArrayList fieldsIn, String typeIn, bool doByIn, String doByParameterIn, String outputIn, String tableNameIn)
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
        public void setParameters(ArrayList parametersIn)
        {
            this.parameters = parametersIn;
        }
        public void setFields(ArrayList fieldsIn)
        {
            this.fields = fieldsIn;
        }
        public void setType(String typeIn)
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
        public ArrayList getParameters()
        {
            return this.parameters;
        }
        public ArrayList getFields()
        {
            return this.fields;
        }
        public String getType()
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
    }
}
