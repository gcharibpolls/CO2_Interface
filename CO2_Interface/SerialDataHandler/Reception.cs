
using System.IO.Ports;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CO2_Interface.SerialDataHandler
{
    internal static  class Reception
    {
        internal static void ReceptionHandler(object sender,SerialDataReceivedEventArgs e)
        { 
            SerialPort sp = (SerialPort)sender;
            byte[] ByteArray = new byte[sp.BytesToRead];

            sp.Read(ByteArray, 0, sp.BytesToRead);
          MessageBox.Show(ByteArray.ToString());
            for (int i = 0; i < ByteArray.Length; i++) Data.Collections.SerialBuffer.Enqueue(ByteArray[i]);    
            
        }
    }
}
