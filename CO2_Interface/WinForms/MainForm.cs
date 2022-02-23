using System;
using System.IO.Ports;
using System.Data;
using System.Windows.Forms;

namespace CO2_Interface
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();

            SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataHandler.Reception.ReceptionHandler);

            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.ID);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.BinaryData);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.NbrBytes);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Type);
        }            
        private void button_COM_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort.Open();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);   
            }

            if (SerialPort.IsOpen) ConnexionStatus_Label.Text = "Open";
            else ConnexionStatus_Label.Text = "Close";
        }

        private void button_DataTreatment_Click(object sender, EventArgs e)
        {
            SerialDataHandler.Treatment.DataTreatment(Data.Tables.DataFromSensor, ObjectsGrid);
        }
    }
}
