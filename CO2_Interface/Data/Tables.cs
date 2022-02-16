using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace CO2_Interface.Data
{
    internal class Tables
    {
        internal static DataTable DataFromSensor = new DataTable();
        internal class Columns
        {
            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn BinaryData = new DataColumn("Name");
            internal static DataColumn NbrBytes = new DataColumn("Destroy ID");
            internal static DataColumn Type = new DataColumn("Config Alarms");
        }
    }
   
}
