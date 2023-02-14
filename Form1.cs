using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Management;
using System.Threading;
using System.Resources;
using OpenHardwareMonitor.Hardware;
using Hardware.Info;
using System.Numerics;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        public void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
        public static List<int> Monitor_W = new List<int>();
        public static List<int> Monitor_H = new List<int>();
        int BrojMonitora =0;
        int BrojMonitoraClick =0;

        static Computer computer = new Computer()
        {
            
            GPUEnabled = true,
            CPUEnabled = true,
            RAMEnabled = true, 
            HDDEnabled = true,
        };

        PerformanceCounter CpuCounter;
        HardwareInfo hardware;
        private void Form1_Load(object sender, EventArgs e)
        {
            BrojMonitora = Screen.AllScreens.Length;
            this.Location = Screen.AllScreens[BrojMonitoraClick].WorkingArea.Location;

            CpuCounter = new PerformanceCounter();
            CpuCounter.CategoryName = "Processor";
            CpuCounter.CounterName = "% Processor Time";
            CpuCounter.InstanceName = "_Total";

            hardware = new HardwareInfo();
            hardware.RefreshCPUList();

            this.Focus();
            this.TopMost = true;

            computer.Open();

            foreach (var hardware in computer.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    CpuTitle.Text += string.Concat(": ", hardware.Name);
                }
                else if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAti)
                {
                    string[] words = hardware.Name.Split(' ');
                    string[] outputWords = words.Where(word => word != "NVIDIA").ToArray();
                    string output = string.Join(" ", outputWords);
                    GpuTitle.Text += string.Concat(": ", output);
                }
            }

            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BrojMonitoraClick++;
            if (BrojMonitoraClick >= BrojMonitora)
            {
                BrojMonitoraClick = 0;
            }
            this.Location = Screen.AllScreens[BrojMonitoraClick].WorkingArea.Location;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int GpuTemp = 0,RamUsage=0;

            foreach (var hardware in computer.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("CPU Total"))
                        {
                            GpuTemp = (int)sensor.Value;
                            CpuUtilCircularProgressBar.Value = GpuTemp;
                            CpuUtilCircularProgressBar.Text = GpuTemp.ToString();
                        }
                        
                         if(sensor.SensorType == SensorType.Temperature)
                        {
                            GpuTemp = (int)sensor.Value.GetValueOrDefault();
                            CpuTempCircularProgressBar.Value = GpuTemp;
                            CpuTempCircularProgressBar.Text = GpuTemp.ToString();
                        }
                    }
                }
                else if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAti)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            GpuTemp = (int)sensor.Value.GetValueOrDefault();
                            GpuTempCircularProgressBar.Value = GpuTemp;
                            GpuTempCircularProgressBar.Text = GpuTemp.ToString();
                        }

                        else if (sensor.SensorType == SensorType.Fan)
                        {
                            GpuTemp = (int)sensor.Value;
                            GpuFanCircularProgressBar.Value = GpuTemp;
                            GpuFanCircularProgressBar.Text = GpuTemp.ToString();
                        }

                        else if(sensor.SensorType == SensorType.Load)
                        {
                            GpuTemp = (int)sensor.Value;
                            GpuUtilCircularProgressBar.Value = GpuTemp;
                            GpuUtilCircularProgressBar.Text = GpuTemp.ToString();
                        }

                        else if(sensor.SensorType == SensorType.Clock)
                        {
                            GpuTemp = (int)sensor.Value;
                            GpuSpeedCircularProgressBar.Value = GpuTemp;
                            GpuSpeedCircularProgressBar.Text = GpuTemp.ToString();
                        }
                    }
                }
                else if (hardware.HardwareType == HardwareType.RAM)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            RamUsage = (int)sensor.Value.GetValueOrDefault();
                            RamUsageCircularProgressBar.Value = RamUsage;
                            RamUsageCircularProgressBar.Text = RamUsage.ToString();
                        }
                    }
                }
            }

            DriveInfo drive = new DriveInfo("C");
            long totalSize = drive.TotalSize;
            long freeSpace = drive.TotalFreeSpace;

            double utilization = (double)(totalSize - freeSpace) / totalSize * 100;
            DiskUtilCircularProgressBar.Value = (int)utilization;
            DiskUtilCircularProgressBar.Text = (100-(int)utilization).ToString();
            Console.WriteLine(DiskUtilCircularProgressBar.Text);

            CDriveSpaceTextBox.Text = 
            string.Concat("(C:) free/total", Environment.NewLine, BytesToGigabytes(freeSpace),"/",BytesToGigabytes(totalSize - freeSpace)," Gb");

            Microsoft.VisualBasic.Devices.ComputerInfo computerInfo = new Microsoft.VisualBasic.Devices.ComputerInfo();
            long totalRamInBytes = (long)computerInfo.TotalPhysicalMemory;
            double totalRamInGB = (double)totalRamInBytes / 1073741824;

            totalRamInGB = Math.Round(totalRamInGB);


            RamTotalTextBox.Text =
            string.Concat("kur free/total",Environment.NewLine, totalRamInGB * (RamUsage / 100f),"/", totalRamInGB, " Gb");

            TimeSpan uptime = TimeSpan.FromMilliseconds(Environment.TickCount);
            UtilTimeTextBox.Text = ("Uptime: " + uptime.ToString(@"d\d\ hh\h\ mm\m\ ss\s"));

        }
        int BytesToGigabytes(double bytes)
        {
            double gibibytes = bytes / (1000000000);
            return (int)gibibytes;
        }
    }
}

   
