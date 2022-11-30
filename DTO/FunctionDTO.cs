using System;
using System.Data;

namespace DTO
{
    public class FunctionDTO
    {
        private string functionID;
        private string functionName;

        public FunctionDTO() { }

        public FunctionDTO(string functionID, string functionName)
        {
            this.functionID = functionID;
            this.functionName = functionName;
        }

        public FunctionDTO(DataRow dr)
        {
            this.functionID = dr["FunctionID"].ToString();
            this.functionName = dr["FunctionName"].ToString();
        }

        public string FunctionID { get => functionID; set => this.FunctionID = value; }
        public string FunctionName { get => functionName; set => functionName = value; }
    }
}
