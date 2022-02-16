using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO2_Interface.Data
{
    internal class FromSensor
    {
        internal class Base
        {
            internal byte ID;
            internal UInt32 BinaryData;
            internal byte NbrBytes;
            internal byte Type;
            internal Base(byte id, UInt32 data, byte nbrbytes, byte type)
            {
                ID = id;
                BinaryData = data;
                NbrBytes = nbrbytes;
                Type = type;
            }
        }
        internal class Measure : Base
        {
            internal Int32 LowLimit;
            internal Int32 HighLimit;
            internal Int32 ConvertedData;
            internal UInt32 AlarmMaxPeriod;
            internal static class AlarmMin
            {
                internal static Int32 Warning;         //User Alarm
                internal static Int32 Critical;         //User Alarm
            }
            internal static class AlarmMax
            {
                internal static Int32 Warning;         //User Alarm
                internal static Int32 Critical;         //User Alarm
            }
            internal Measure() : base(0, 0, 0, 0)
            {
                LowLimit = 0;
                HighLimit = 0;
                ConvertedData = 0;
                AlarmMaxPeriod = 0;
                AlarmMin.Warning = 0;
                AlarmMin.Critical = 0;
                AlarmMax.Warning = 0;
                AlarmMax.Critical = 0;
            }
        }
    }
}
