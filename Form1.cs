using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace _179controllerinterface
{
    public partial class Form1 : Form
    {

        private Thread cpuThread;
        private double[] co2array = new double[200];
        private string data;
        bool datastream = true;

        bool acidValve;
        bool sampleValve;
        bool aIValve;
        bool wasteValve;
        bool detectValve;
        bool airPump;
        bool sample2valve;


        string serial_input;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            //comboBox1.SelectedIndex = 0;
            button2.Enabled = false;
            //serialPort1.WriteLine("1");
            //serialPort1.WriteLine("3");
            //serialPort1.WriteLine("5");
            //serialPort1.WriteLine("7");
            //serialPort1.WriteLine("9");

        }

        // open port
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Serial port opening error!!");
            }
        }

        // close port
        private void button2_Click(object sender, EventArgs e) 
        {
            button1.Enabled = true;
            button2.Enabled = false;

            try
            {
                serialPort1.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Serial port closing error!!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sampleValvebtn_Click(object sender, EventArgs e)
        {

            if (sampleValve == false)
            {
                try
                {
                    serialPort1.WriteLine("2");
                    sampleValvebtn.Text = "Open";
                    sampleValvebtn.BackColor = Color.LimeGreen;
                    sampleValve = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("sample valve opening error");
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("3");
                    sampleValvebtn.Text = "Closed";
                    sampleValvebtn.BackColor = Color.LightGray;
                    sampleValve = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("sample valve closing error");
                }
            }
        }

        private void acidValvebtn_Click(object sender, EventArgs e)
        {
            if (detectValve == true) {
                try
                {
                    serialPort1.WriteLine("0");
                    //acidValvebtn.Text = "Open";
                    //acidValvebtn.BackColor = Color.LimeGreen;
                    //acidValve = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("acid pump error");
                }
            }
        }

        private void airPumpbtn_Click(object sender, EventArgs e)
        {
            if (airPump == false)
            {
                try
                {
                    serialPort1.WriteLine("a");
                    airPumpbtn.Text = "on";
                    airPumpbtn.BackColor = Color.LimeGreen;
                    airPump = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("air pump turning ON error");
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("b");
                    airPumpbtn.Text = "off";
                    airPumpbtn.BackColor = Color.LightGray;
                    airPump = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("air pump turning OFF error");
                }
            }
        }

        private void airInValvebtn_Click(object sender, EventArgs e)
        {
            if (aIValve == false)
            {
                try
                {
                    serialPort1.WriteLine("4");
                    airInValvebtn.Text = "Open";
                    airInValvebtn.BackColor = Color.LimeGreen;
                    aIValve = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("air inlet valve opening error");
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("5");
                    airInValvebtn.Text = "Closed";
                    airInValvebtn.BackColor = Color.LightGray;
                    aIValve = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("air inlet valve closing error");
                }
            }
        }

        private void wasteValvebtn_Click(object sender, EventArgs e)
        {
            if (wasteValve == false)
            {
                try
                {
                    serialPort1.WriteLine("6");
                    wasteValvebtn.Text = "Open";
                    wasteValvebtn.BackColor = Color.LimeGreen;
                    wasteValve = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("waste valve opening error");
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("7");
                    wasteValvebtn.Text = "Closed";
                    wasteValvebtn.BackColor = Color.LightGray;
                    wasteValve = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("waste valve closing error");
                }
            }
        }
        
        // aka detect CO2 out valve
        private void samOutValvebtn_Click(object sender, EventArgs e)
        {
            if (detectValve == false)
            {
                try
                {
                    serialPort1.WriteLine("8");
                    samOutValvebtn.Text = "Open";
                    samOutValvebtn.BackColor = Color.LimeGreen;
                    detectValve = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("detect valve opening error");
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("9");
                    samOutValvebtn.Text = "Closed";
                    samOutValvebtn.BackColor = Color.LightGray;
                    detectValve = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("detect valve closing error");
                }
            }
        }

        private void primePumpbtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("g");
            }
            catch (Exception)
            {
                MessageBox.Show("prime pump error");
            }
        }

        private void sample2valvebtn_Click(object sender, EventArgs e)
        {
            if (sample2valve == false)
            {
                try
                {
                    
                    serialPort1.WriteLine("c");
                    sample2valvebtn.Text = "Open";
                    sample2valvebtn.BackColor = Color.LimeGreen;
                    sample2valve = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("sample2 valve opening error");
                }
            }
            else
            {
                try
                {
                    serialPort1.WriteLine("d");
                    sample2valvebtn.Text = "Closed";
                    sample2valvebtn.BackColor = Color.LightGray;
                    sample2valve = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("sample2 valve closing error");
                }
            }
        }

        private void pumpForwardbtn_Click(object sender, EventArgs e)
        {
            if (sample2valve == true && detectValve == true)
            {
                try
                {

                    serialPort1.WriteLine("e");

                    //while (serial_input != "a")
                    //{
                    //    serial_input = serialPort1.ReadLine();
                    //    pumpForwardbtn.BackColor = Color.LimeGreen;
                    //    pumpForwardbtn.Text = "pushing";
                    //}
                    //pumpForwardbtn.Text = "start";
                    //serialPort1.WriteLine(pumpForwardTxtBx.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("runpumpforward error");
                }
            }
            else
            {
                MessageBox.Show("open samplevalve 2 and co2 detect valve!");
            }
        }

        private void pumpBackwardsbtn_Click(object sender, EventArgs e)
        {
            if (sampleValve == true) {
                try
                {
                    serialPort1.WriteLine("f");
                    //while (serial_input != "b")
                    //{
                    //    serial_input = serialPort1.ReadLine();
                    //    pumpBackwardsbtn.BackColor = Color.LimeGreen;
                    //    pumpBackwardsbtn.Text = "pulling";
                    //}
                    //pumpBackwardsbtn.Text = "start";
                    //Thread.Sleep(500);
                    //serialPort1.WriteLine(pumpBackwardsTxtBx.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("runpumpbackward error");
                }
            }
            else
            {
                MessageBox.Show("open sample valve 1!");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //read k30 and display to textBox1
        private void button3_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        serialPort1.WriteLine("h");
            //        textBox1.Text = serialPort1.ReadLine();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("getReading k30 error");
            //    }
        }

        // update co2 reading
        private void button4_Click(object sender, EventArgs e)
        {
           
            //textBox1.Text = serialPort1.ReadLine();
            
        }

        // initialize close all valves and air pump
        private void initializebtn_Click(object sender, EventArgs e)
        {
            acidValve = false;
            sampleValve = false;
            aIValve = false;
            wasteValve = false;
            detectValve = false;
            airPump = false;
            sample2valve = false;
            serialPort1.WriteLine("1");
            serialPort1.WriteLine("3");
            serialPort1.WriteLine("5");
            serialPort1.WriteLine("7");
            serialPort1.WriteLine("9");
            serialPort1.WriteLine("b");

            sampleValvebtn.Text = "Closed";
            sampleValvebtn.BackColor = Color.LightGray;

            airPumpbtn.Text = "off";
            airPumpbtn.BackColor = Color.LightGray;

            airInValvebtn.Text = "Closed";
            airInValvebtn.BackColor = Color.LightGray;

            wasteValvebtn.Text = "Closed";
            wasteValvebtn.BackColor = Color.LightGray;

            sample2valvebtn.Text = "Closed";
            sample2valvebtn.BackColor = Color.LightGray;

            samOutValvebtn.Text = "Closed";
            samOutValvebtn.BackColor = Color.LightGray;        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void getK30data()
        {

            while (datastream)
            {
                data = serialPort1.ReadLine();
                int d = Int32.Parse(data);
                co2array[co2array.Length - 1] = d;

                Array.Copy(co2array, 1, co2array, 0, co2array.Length - 1);

                if (chart1.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateChart(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(1000);
            }
        }

        private void UpdateChart()
        {
            chart1.Series["Series1"].Points.Clear();

            for (int i = 0; i < co2array.Length - 1; ++i)
            {
                chart1.Series["Series1"].Points.AddY(co2array[i]);
                chart1.ChartAreas[0].RecalculateAxesScale();
            }
        }

        private void measureBtn_Click(object sender, EventArgs e)
        {
            datastream = true;
            serialPort1.WriteLine("m"); //change in arduino
            cpuThread = new Thread(new ThreadStart(this.getK30data));
            cpuThread.IsBackground = true;
            cpuThread.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            serialPort1.WriteLine("z");
            datastream = false;
        }
    }
}
