using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp2.Helper;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {
        private string[] receivedDataArray = new string[6];
        private int currentIndex = 0;
        //private MySqlConnection connection;
        //private string connectionString = "server=192.168.1.100;database=curs_work;uid=root;password=root1212;";

        private string username;
        private string password;
        public Form1(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;




        }
        internal void Display_Text(String text)
        {
            textBox1.Clear();
            textBox1.AppendText(text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            button1.Enabled = false;
            button2.Enabled = false;


            try
            {
                DB.EstablishConnection(); // Corrected method name
                Display_Text("Database Connection Successful");
            }
            catch (Exception ex)
            {
                Display_Text("Database not connected");

            };


        }
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)

            {
                // Send your command to the Arduino
                serialPort1.WriteLine("Send Data");
            }
            button2.Enabled = true;


        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.DataReceived += myport_DataReceived;
                serialPort1.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
        void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string in_data = serialPort1.ReadLine();

            Invoke(new Action(() =>
            {
                // Store the received data in the array
                receivedDataArray[currentIndex] = in_data;
                currentIndex++;

                // Check if the array is full
                if (currentIndex >=6)

                {
                    // Display the data
                    textBox1.Clear();
                    textBox1.Lines = receivedDataArray;

                    // Reset the array and index
                    //receivedDataArray = new string[6];
                    currentIndex = 0;
                    serialPort1.DiscardInBuffer();   // Clear the input buffer
                    serialPort1.DiscardOutBuffer();  // Clear the output buffer
                }
            }));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
                DB.CreateTableSensors();
                DB.InsertDataSensors(
                    float.Parse(receivedDataArray[0]),
                    float.Parse(receivedDataArray[1]),
                    float.Parse(receivedDataArray[2]),
                    float.Parse(receivedDataArray[3]),
                    float.Parse(receivedDataArray[4]),
                    float.Parse(receivedDataArray[5]));
                Display_Text("Data inserted");
            }
            catch (Exception ex)
            {
                Display_Text("Data not inserted");

            };
        }

        private void button3_Click(object sender, EventArgs e)

        {
            bool isAdmin = DB.IsAdmin(username, password);
            if (isAdmin)
            {
                
                serialPort1.WriteLine("Polish Plants");
            }
            else
            {
                admin.Visible = true;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)

        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            

            Form2 form2 = new Form2();

            form2.Show(); // Show Form1
            this.Hide();
        }
    }
}
