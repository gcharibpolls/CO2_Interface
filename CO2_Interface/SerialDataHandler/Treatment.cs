using System.Windows.Forms;
using System.Data;

namespace CO2_Interface.SerialDataHandler
{
    internal static  class Treatment
    {
        internal static void DataTreatment(DataTable dt, DataGridView dg)
        {
            int BytesNbr = Data.Collections.SerialBuffer.Count;    // Fix value to avoid changes in for loop

            Data.FromSensor.Base obj = new Data.FromSensor.Measure();

            for (int i = 0; i < BytesNbr; i++)
            {
                //The following data's shall be extracted from Queue List
                if (Data.Collections.SerialBuffer.Count > 4)
                {
                    obj.ID = Data.Collections.SerialBuffer.Dequeue();
                    obj.BinaryData = Data.Collections.SerialBuffer.Dequeue();
                    obj.NbrBytes = Data.Collections.SerialBuffer.Dequeue();
                    obj.Type = Data.Collections.SerialBuffer.Dequeue();
                }
                //This part shall be modified once rules have been defined 
            }

            ObjToList(obj, dt, dg);

        }
        internal static void ObjToList(Data.FromSensor.Base obj, DataTable dt, DataGridView dg)
        {
            Data.Collections.ObjectList.Add(obj);

            dt.Rows.Add(new object[] { obj.ID, obj.BinaryData, obj.NbrBytes, obj.Type });
            dg.DataSource = dt;
        }
    }
}
