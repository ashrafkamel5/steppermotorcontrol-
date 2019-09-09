using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Stepper_Motor_control
{
    public partial class Form1 : Form
    {
        private SynchronizationContext MainThread;
        SerialPort myport;
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            MainThread = SynchronizationContext.Current;
            if (MainThread == null) MainThread = new SynchronizationContext();
            backgroundWorker1.RunWorkerAsync();
        }

        void loadImage(PictureBox obj,string imageName)
        {
            bmp = (Bitmap)Bitmap.FromFile("E:\\code\\C#\\Stepper Motor control\\Stepper Motor control\\"
                + imageName);
            obj.SizeMode = PictureBoxSizeMode.AutoSize;
            obj.Image = bmp;
            obj.Show();
        }

        void getAvailableports()
        {
            String[] ports = SerialPort.GetPortNames();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            String chosenCom = portsComboBox.Text.ToString();
            try
            {
                myport = new SerialPort(chosenCom, 9600, Parity.None, 8, StopBits.One);
                if (myport.IsOpen == false)
                {
                    myport.Open();
                    myport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    myport.Write("STARTING NOW/r/n");
                    try
                    {
                        if (myport.ReadLine().Equals("STARTING YEAH"))
                        {
                            statusLabel.Text = "Valid";
                            statusLabel.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            statusLabel.Text = "InValid";
                            statusLabel.ForeColor = System.Drawing.Color.Red;
                            myport.Dispose();
                        }
                    }
                    catch (System.TimeoutException)
                    {
                        statusLabel.Text = "InValid";
                        statusLabel.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    statusLabel.Text = "InValid";
                    statusLabel.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("The PortName cannot be empty."
                    , "Warning"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
            catch (System.IO.IOException) 
            {
                MessageBox.Show("The port \""+chosenCom+"\" does not exist."
                    , "Warning"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
            
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                myport = (SerialPort)sender;
                String w = myport.ReadLine();
            }
            catch (System.TimeoutException)
            {
                MessageBox.Show("Check your device! \nand reconnect it"
                    , "Time out"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        private void motorMove1_Click(object sender, EventArgs e)
        {
            if (statusLabel.Text == "Valid")
            {
                if (motorcombo1.SelectedIndex == -1)
                    motorcombo1.SelectedIndex = 0;
                if (motorcombo1.Text.ToString() == "clockwise rotation")
                {
                    loadImage(pictureBox1, "rotate right.gif");
                }
                else if (motorcombo1.Text.ToString() == "counter clockwise rotation")
                {
                    loadImage(pictureBox1, "rotate left.gif");
                }
            }
            else
            {
                MessageBox.Show("Select a valid port first!"
                    , "critical"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        private void motorStop1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

        private void motorMove2_Click(object sender, EventArgs e)
        {
            if (statusLabel.Text == "Valid")
            {
                if (motorcombo2.SelectedIndex == -1)
                    motorcombo2.SelectedIndex = 0;
                if (motorcombo2.Text.ToString() == "clockwise rotation")
                {
                    loadImage(pictureBox2, "rotate right.gif");
                }
                else if (motorcombo2.Text.ToString() == "counter clockwise rotation")
                {
                    loadImage(pictureBox2, "rotate left.gif");
                }
            }
            else
            {
                MessageBox.Show("Select a valid port first!"
                    , "critical"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        private void motorStop2_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
        }

        private void motorMove3_Click(object sender, EventArgs e)
        {
            if (statusLabel.Text == "Valid")
            {
                if (motorcombo3.SelectedIndex == -1)
                    motorcombo3.SelectedIndex = 0;
                if (motorcombo3.Text.ToString() == "clockwise rotation")
                {
                    loadImage(pictureBox3, "rotate right.gif");
                }
                else if (motorcombo3.Text.ToString() == "counter clockwise rotation")
                {
                    loadImage(pictureBox3, "rotate left.gif");
                }
            }
            else
            {
                MessageBox.Show("Select a valid port first!"
                    , "critical"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        private void motorMove4_Click(object sender, EventArgs e)
        {
            if (statusLabel.Text == "Valid")
            {
                if (motorcombo4.SelectedIndex == -1)
                    motorcombo4.SelectedIndex = 0;
                if (motorcombo4.Text.ToString() == "clockwise rotation")
                {
                    loadImage(pictureBox4, "rotate right.gif");
                }
                else if (motorcombo4.Text.ToString() == "counter clockwise rotation")
                {
                    loadImage(pictureBox4, "rotate left.gif");
                }
            }
            else
            {
                MessageBox.Show("Select a valid port first!"
                    , "critical"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        private void motorStop3_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
        }

        private void motorStop4_Click(object sender, EventArgs e)
        {
            pictureBox4.Hide();
        }

        private void moveAll_B_Click(object sender, EventArgs e)
        {
            if (statusLabel.Text == "Valid")
            {
                if (motorcombo1.SelectedIndex == -1)
                    motorcombo1.SelectedIndex = 0;
                if (motorcombo2.SelectedIndex == -1)
                    motorcombo2.SelectedIndex = 0;
                if (motorcombo3.SelectedIndex == -1)
                    motorcombo3.SelectedIndex = 0;
                if (motorcombo4.SelectedIndex == -1)
                    motorcombo4.SelectedIndex = -0;

                if (motorcombo4.Text.ToString() == "clockwise rotation")
                {
                    loadImage(pictureBox4, "rotate right.gif");
                }
                else if (motorcombo4.Text.ToString() == "counter clockwise rotation")
                {
                    loadImage(pictureBox4, "rotate left.gif");
                }

                if (motorcombo3.Text.ToString() == "clockwise rotation")
                {
                    loadImage(pictureBox3, "rotate right.gif");
                }
                else if (motorcombo3.Text.ToString() == "counter clockwise rotation")
                {
                    loadImage(pictureBox3, "rotate left.gif");
                }
                if (motorcombo2.Text.ToString() == "clockwise rotation")
                {
                    loadImage(pictureBox2, "rotate right.gif");
                }
                else if (motorcombo2.Text.ToString() == "counter clockwise rotation")
                {
                    loadImage(pictureBox2, "rotate left.gif");
                }
                if (motorcombo1.Text.ToString() == "clockwise rotation")
                {
                    loadImage(pictureBox1, "rotate right.gif");
                }
                else if (motorcombo1.Text.ToString() == "counter clockwise rotation")
                {
                    loadImage(pictureBox1, "rotate left.gif");
                }
            }
            else
            {
                MessageBox.Show("Select a valid port first!"
                    ,"critical"
                    ,MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        private void stopAll_B_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }


        private void checkSerialPorts_DoWork(object sender, DoWorkEventArgs e)
        {
            String[] previousPorts = SerialPort.GetPortNames();
            MainThread.Post((object state) =>
                    {
                        portsComboBox.Items.AddRange(previousPorts);
                    }, null);
            while (true)
            {
                String[] ports = SerialPort.GetPortNames();
                if (!ports .SequenceEqual( previousPorts))
                {
                    var items = ports.Except(previousPorts);
                    MainThread.Post((object state) =>
                    {
                        portsComboBox.Items.AddRange(items.ToArray());
                        
                    }, null);
                    items = previousPorts.Except(ports);
                    MainThread.Post((object state) =>
                    {
                        portsComboBox.Items.Remove(items.ToString());

                    }, null);
                    previousPorts = ports;
                }
                // check every 100ms
                Thread.Sleep(1000);
            }
        }
    }
}
