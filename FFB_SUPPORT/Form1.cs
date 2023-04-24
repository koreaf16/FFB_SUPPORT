using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.Net;
using System.Net.Sockets;

using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using Microsoft.Win32;

using NLog;
using NLog.Config;
using NLog.Windows.Forms;
using NLog.Targets.Wrappers;

using ArduinoUploader;
using ArduinoUploader.Hardware;
using FFB_SUPPORT;

using SharpDX.DirectInput;
using EXTERN = EXTERNAL;

using Newtonsoft.Json.Linq;

using F4SharedMem;
using F4SharedMem.Headers;

using Microsoft.FlightSimulator.SimConnect;

namespace FFB_SUPPORT
{

    public partial class FFB_SUPPORT : Form
    {
        public int X { get { return _x; } set { _x = value; OnPropertyChanged("X"); } }
        public int Y { get { return _y; } set { _y = value; OnPropertyChanged("Y"); } }
        public int Z { get { return _z; } set { _z = value; OnPropertyChanged("Z"); } }
        public int ForceX { get { return _forceX; } set { _forceX = value; OnPropertyChanged("ForceX"); } }
        public int ForceY { get { return _forceY; } set { _forceY = value; OnPropertyChanged("ForceY"); } }
        public int ForceZ { get { return _forceZ; } set { _forceZ = value; OnPropertyChanged("ForceZ"); } }
        public int TorqueX { get { return _torqueX; } set { _torqueX = value; OnPropertyChanged("TorqueX"); } }
        public int TorqueY { get { return _torqueY; } set { _torqueY = value; OnPropertyChanged("TorqueY"); } }
        public int TorqueZ { get { return _torqueZ; } set { _torqueZ = value; OnPropertyChanged("TorqueZ"); } }
        public int ForceSliders0 { get { return _forceSliders0; } set { _forceSliders0 = value; OnPropertyChanged("ForceSliders0"); } }
        public int ForceSliders1 { get { return _forceSliders1; } set { _forceSliders1 = value; OnPropertyChanged("ForceSliders1"); } }
        public int PointOfViewControllers0 { get { return _pointOfViewControllers0; } set { _pointOfViewControllers0 = value; OnPropertyChanged("PointOfViewControllers0"); } }
        public int PointOfViewControllers1 { get { return _pointOfViewControllers1; } set { _pointOfViewControllers1 = value; OnPropertyChanged("PointOfViewControllers1"); } }
        public int PointOfViewControllers2 { get { return _pointOfViewControllers2; } set { _pointOfViewControllers2 = value; OnPropertyChanged("PointOfViewControllers2"); } }
        public int PointOfViewControllers3 { get { return _pointOfViewControllers3; } set { _pointOfViewControllers3 = value; OnPropertyChanged("PointOfViewControllers3"); } }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        private int _pointOfViewControllers0;
        private int _pointOfViewControllers1;
        private int _pointOfViewControllers2;
        private int _pointOfViewControllers3;
        private int _x;
        private int _y;
        private int _z;
        private int _forceX;
        private int _forceY;
        private int _forceZ;
        private int _torqueX;
        private int _torqueY;
        private int _torqueZ;
        private int _forceSliders0;
        private int _forceSliders1;
        private int _x_trim_offset;
        private int _y_trim_offset;
        private int x_last = 0;
        private int y_last = 0;

        string BEFORE_X_AXIS;
        string BEFORE_Y_AXIS;

        Thread joystickThread;
        ThreadStart joystickThreadStart;
        Joystick joystick;
        Guid joystickGuid;
        bool activeThread;
        bool ComboLock;

        private delegate void UpdateUiTextDelegate(string text);
        string RxString;
        string RxString_line;
        string path = System.Reflection.Assembly.GetExecutingAssembly().Location;


        // UDP데이터 GET 쓰레드
        Thread UdpThread;
        ThreadStart UdpThreadStart;
        bool activeThread_udp;

        // 진폭값 계산 쓰레드
        Thread ACCS_THREAD;
        ThreadStart ACCS_THREAD_START;
        bool ACTIVE_ACCS_THREAD;

        // 패널진동 쓰레드
        Thread PANEL_THREAD;
        ThreadStart PANEL_THREAD_START;
        bool ACTIVE_PANEL_THREAD;

        // AOA 쓰레드
        Thread AOA_THREAD;
        ThreadStart AOA_THREAD_START;
        bool ACTIVE_AOA_THREAD;

        // 스피드브레이크 쓰레드
        Thread SPDBREAK_THREAD;
        ThreadStart SPDBREAK_THREAD_START;
        bool ACTIVE_SPDBREAK_THREAD;

        // 랜딩기어 쓰레드
        Thread GEAR_THREAD;
        ThreadStart GEAR_THREAD_START;
        bool ACTIVE_GEAR_THREAD;

        // 기총발사 쓰레드
        Thread GUN_THREAD;
        ThreadStart GUN_THREAD_START;
        bool ACTIVE_GUN_THREAD;

        // PAYLOAD 쓰레드 (무장발사 장착)
        Thread PAYLOAD_THREAD;
        ThreadStart PAYLOAD_THREAD_START;
        bool ACTIVE_PAYLOAD_THREAD;

        // 채프, 플레어 쓰레드
        Thread FLARECHAFF_THREAD;
        ThreadStart FLARECHAFF_THREAD_START;
        bool ACTIVE_FLARECHAFF_THREAD;

        // 유효 전이양력
        Thread HELI_THREAD;
        ThreadStart HELI_THREAD_START;
        bool ACTIVE_HELI_THREAD;

        // UDP 처리
        public UdpClient srv;
        public IPEndPoint remoteEP;
        DateTime lastData_Time;



        public StringBuilder ini_joy_name = new StringBuilder();
        public StringBuilder ini_set_mode = new StringBuilder();
        public StringBuilder ini_multiply = new StringBuilder();
        public StringBuilder ini_min_vibration = new StringBuilder();
        public StringBuilder ini_max_vibration = new StringBuilder();

        public StringBuilder ini_Trim_Key = new StringBuilder();
        public StringBuilder ini_Reset_Trim_Key = new StringBuilder();

        public StringBuilder ini_program_mode = new StringBuilder();

        public StringBuilder ini_plane_setup = new StringBuilder();


        private int trimKey = 0;
        private int Reset_trimKey = 0;

        private static NLog.Logger logger = LogManager.GetCurrentClassLogger();
        public FFB_SUPPORT()
        {
            InitializeComponent();
            this.refreshComPorts();
            RichTextBoxTarget.ReInitializeAllTextboxes(this);

        }
        private void detectPorts_Click(object sender, EventArgs e)
        {
            this.refreshComPorts();

        }
        private void refreshComPorts()
        {
            string FFBSUPPORT_PORT = null;
            string FFBSUPPORT_VALUE = null;
            List<string> names = ComPortNames("2341", "7583");
            if (names.Count > 0)
            {
                foreach (String s in SerialPort.GetPortNames())
                {
                    if (names.Contains(s))
                    {
                        Console.WriteLine("My Arduino port is " + s);
                        FFBSUPPORT_PORT = s;
                    }
                }
            }
            else
                Console.WriteLine("No COM ports found");


            string[] portnames = SerialPort.GetPortNames();
            var comparer = new StringIntsComparer();
            Array.Sort(portnames, comparer);

            this.comboPorts.Items.Clear();
            bool selectedPortFound = false;

            foreach (string port in portnames)
            {
                if (FFBSUPPORT_PORT == port)
                {
                    this.comboPorts.Items.Add(port + "-FFB SUPPORT");
                    FFBSUPPORT_VALUE = port + "-FFB SUPPORT";
                }
                else
                {
                    this.comboPorts.Items.Add(port);
                }
            }

            if (!selectedPortFound)
            {
                this.comboPorts.SelectedIndex = portnames.Length - 1;
            }

            if (FFBSUPPORT_VALUE != null) this.comboPorts.Text = FFBSUPPORT_VALUE;
        }


        List<string> ComPortNames(String VID, String PID)
        {
            String pattern = String.Format("^VID_{0}.PID_{1}", VID, PID);
            Regex _rx = new Regex(pattern, RegexOptions.IgnoreCase);
            List<string> comports = new List<string>();
            RegistryKey rk1 = Registry.LocalMachine;
            RegistryKey rk2 = rk1.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum");
            foreach (String s3 in rk2.GetSubKeyNames())
            {
                RegistryKey rk3 = rk2.OpenSubKey(s3);
                foreach (String s in rk3.GetSubKeyNames())
                {
                    if (_rx.Match(s).Success)
                    {
                        RegistryKey rk4 = rk3.OpenSubKey(s);
                        foreach (String s2 in rk4.GetSubKeyNames())
                        {
                            RegistryKey rk5 = rk4.OpenSubKey(s2);
                            RegistryKey rk6 = rk5.OpenSubKey("Device Parameters");
                            comports.Add((string)rk6.GetValue("PortName"));
                        }
                    }
                }
            }
            return comports;
        }




        private void uLoadFirmware_Click(object sender, EventArgs e)
        {
            string[] port_list = comboPorts.Text.Split('-');

            this.uploadProgressBar.Visible = true;

            var progress = new Progress<double>(
                p => UpdateProgress(p));
            var options = new ArduinoSketchUploaderOptions()
            {
                FileName = Path.Combine(AppContext.BaseDirectory, "Fino.ino.hex"),

                PortName = port_list[0],
                ArduinoModel = ArduinoModel.Micro
            };

            var uploader = new ArduinoSketchUploader(
                options,
                new FormArduinoUploaderLogger(logger),
                progress);

            var thread = new Thread(() =>
            {
                try
                {
                    uploader.UploadSketch();
                    logger.Info("Uploaded to Arduino. Please click on 'Detect Ports' just in case the Arduino device has changed ports");
                }
                catch (Exception ex)
                {
                    logger.Error(ex, ex.Message);
                }
            });
            thread.Start();
        }
        public void UpdateProgress(double progress)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.uploadProgressBar.InvokeRequired)
            {
                SetProgressCallback d = new SetProgressCallback(UpdateProgress);
                this.Invoke(d, new object[] { progress });
            }
            else
            {
                int as_pct = (int)Math.Round(progress * 100);
                this.uploadProgressBar.Value = as_pct;
            }
        }
        delegate void SetProgressCallback(double progress);

        private void FFB_SUPPORT_FormClosed(object sender, FormClosedEventArgs e)
        {
            activeThread = false;
            serialPort1.Close();
            Mbar.Enabled = false;
            Vbar.Enabled = false;
            Dbar.Enabled = false;
            SetCombo.Enabled = false;
            Trim_key.Enabled = false;
            Reset_Trim_key.Enabled = false;
            Del_Trim_key.Enabled = false;
            Del_Reset_Trim_key.Enabled = false;

            activeThread_udp = false;
            ACTIVE_ACCS_THREAD = false;
            ACTIVE_PANEL_THREAD = false;
            ACTIVE_AOA_THREAD = false;
            ACTIVE_SPDBREAK_THREAD = false;
            ACTIVE_GEAR_THREAD = false;
            ACTIVE_GUN_THREAD = false;
            ACTIVE_PAYLOAD_THREAD = false;
            ACTIVE_FLARECHAFF_THREAD = false;
            ACTIVE_HELI_THREAD = false;

            if (srv != null)
            {
                srv.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logger.Info("Init");

            plane_list_update();
            plane_list_update_wt();
            LUA_INSTALL_OPENBETA();
            LUA_INSTALL();

            this.SetCombo.Items.Add("X,Y 축");
            this.SetCombo.Items.Add("X 축");
            this.SetCombo.Items.Add("Y 축");

            // 조이스틱 셋팅
            var directInput = new DirectInput();

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
            {
                this.JoyCombo.Items.Add(deviceInstance.ProductName.ToString());
                //this.JoyCombo.Items.Add(deviceInstance.ProductName.ToString() + ":" + deviceInstance.InstanceGuid);
            }

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Flight, DeviceEnumerationFlags.AllDevices))
            {
                this.JoyCombo.Items.Add(deviceInstance.ProductName.ToString());
            }

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
            {
                this.JoyCombo.Items.Add(deviceInstance.ProductName.ToString());
            }

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.FirstPerson, DeviceEnumerationFlags.AllDevices))
            {
                this.JoyCombo.Items.Add(deviceInstance.ProductName.ToString());
            }


            try
            {
                GetPrivateProfileString("Joystick", "Name", null, ini_joy_name, 32, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                GetPrivateProfileString("Trim_Key", "Trim_Key", null, ini_Trim_Key, 32, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                GetPrivateProfileString("Trim_Key", "Reset_Trim_key", null, ini_Reset_Trim_Key, 32, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");

                GetPrivateProfileString("PROGRAM", "MODE", null, ini_program_mode, 32, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");

            }
            catch { }


            for (int i = 0; i < this.JoyCombo.Items.Count; i++)
            {
                if (this.JoyCombo.Items[i].ToString() == ini_joy_name.ToString())
                {
                    this.JoyCombo.SelectedIndex = i;
                }
            }


            SetCombo.SelectedIndex = 0;
            Mbar.Value = 1;
            Vbar.Value = 100;
            Dbar.Value = 3000;
            Vbar_label.Text = Vbar.Value.ToString();
            Mbar_label.Text = Mbar.Value.ToString();
            Dbar_label.Text = Dbar.Value.ToString();

            Trim_key_label.Text = ini_Trim_Key.ToString();
            Reset_Trim_key_label.Text = ini_Reset_Trim_Key.ToString();
            tabControl1.SelectedIndex = Int32.Parse(ini_program_mode.ToString());

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeThread = false;
            serialPort1.Close();
            Mbar.Enabled = false;
            Vbar.Enabled = false;
            Dbar.Enabled = false;
            SetCombo.Enabled = false;
            Trim_key.Enabled = false;
            Reset_Trim_key.Enabled = false;
            Del_Trim_key.Enabled = false;
            Del_Reset_Trim_key.Enabled = false;
            Connect.Text = "Connect";
            getpos_timer1.Stop();
            joypos_timer1.Stop();


            activeThread_udp = false;
            ACTIVE_ACCS_THREAD = false;
            ACTIVE_PANEL_THREAD = false;
            ACTIVE_AOA_THREAD = false;
            ACTIVE_SPDBREAK_THREAD = false;
            ACTIVE_GEAR_THREAD = false;
            ACTIVE_GUN_THREAD = false;
            ACTIVE_PAYLOAD_THREAD = false;
            ACTIVE_FLARECHAFF_THREAD = false;
            ACTIVE_HELI_THREAD = false;
            PLANE_LIST_COMBO.Enabled = true;

            ACC_VIB.Text = "0";
            PANEL_VIB.Text = "0";
            AOA_VIB.Text = "0";
            GEAR_VIB.Text = "0";
            GUN_VIB.Text = "0";
            PAYLOAD_VIB.Text = "0";
            FLARE_VIB.Text = "0";
            CHAFF_VIB.Text = "0";
            SPDBREAK_VIB.Text = "0";
            HELI_VIB.Text = "0";

            if (srv != null)
            {
                srv.Close();
            }
            vib_timer1.Stop();
            Connect_DCS.Text = "Connect";


            ACTIVE_WARTHUNDER_GET_THREAD = false;
            ACTIVE_WARTHUNDER_ACCS_THREAD = false;
            ACTIVE_WARTHUNDER_AOA_THREAD = false;
            ACTIVE_WARTHUNDER_GEAR_THREAD = false;
            ACTIVE_WARTHUNDER_FLAP_BREAK_THREAD = false;
            ACTIVE_WARTHUNDER_GUN_THREAD = false;
            ACTIVE_WARTHUNDER_WEP_THREAD = false;
            PLANE_LIST_COMBO_WT.Enabled = true;

            Connect_WT.Text = "Connect";
            WT_AOS_VIB_OUT.Text = "0";
            WT_NY_VIB_OUT.Text = "0";
            WT_WX_VIB_OUT.Text = "0";
            WT_AOA_VIB_OUT.Text = "0";
            WT_FLAP_VIB_OUT.Text = "0";
            WT_GEAR_VIB_OUT.Text = "0";
            WT_AIRBREAK_VIB_OUT.Text = "0";
            WT_GUN_VIB_OUT.Text = "0";
            WT_WEP_VIB_OUT.Text = "0";
            vib_timer2.Stop();


            ACTIVE_FALCON_ACCS_THREAD = false;
            ACTIVE_FALCON_AOA_THREAD = false;
            ACTIVE_FALCON_GUN_THREAD = false;
            ACTIVE_FALCON_PAYLOAD_THREAD = false;
            ACTIVE_FALCON_GEAR_THREAD = false;
            ACTIVE_FALCON_AIRBREAK_THREAD = false;
            ACTIVE_FALCON_CHFL_THREAD = false;
            ACTIVE_FALCON_DAMAGE_THREAD = false;
            ACTIVE_FALCON_BUNNER_THREAD = false;

            FALCON_PITCH_VIB_OUT.Text = "0";
            FALCON_ROLL_VIB_OUT.Text = "0";
            FALCON_YAW_VIB_OUT.Text = "0";
            FALCON_AOA_VIB_OUT.Text = "0";
            FALCON_BUNNER_VIB_OUT.Text = "0";
            FALCON_GUN_VIB_OUT.Text = "0";
            FALCON_PAYLOAD_VIB_OUT.Text = "0";
            FALCON_GEAR_VIB_OUT.Text = "0";
            FALCON_AIRBREAK_VIB_OUT.Text = "0";
            FALCON_CHFL_VIB_OUT.Text = "0";
            FALCON_DAMAGE_VIB_OUT.Text = "0";
            Connect_FALCON.Text = "Connect";
            get_falcon_timer.Stop();
            vib_timer3.Stop();

            ACTIVE_FS_ACCS_THREAD = false;
            ACTIVE_FS_AOA_THREAD = false;
            ACTIVE_FS_GEAR_THREAD = false;
            ACTIVE_FS_FLAP_THREAD = false;
            ACTIVE_FS_WARNING_THREAD = false;


            FS_ACC_VIB.Text = "0";
            FS_AOA_VIB.Text = "0";
            FS_GEAR_VIB.Text = "0";
            FS_FLAP_VIB.Text = "0";
            FS_SPOILER_VIB.Text = "0";
            FS_STALL_VIB.Text = "0";
            FS_OVERSPEED_VIB.Text = "0";
            FS_VIB_OUT.Text = "0";

            Connect_FS2020.Text = "Connect";
            if (simconnect != null)
            {
                // Dispose serves the same purpose as SimConnect_Close()
                simconnect.Dispose();
                simconnect = null;
                Console.WriteLine("Connection closed");
            }
            get_fs2020_timer.Stop();
            vib_timer4.Stop();


            if (serialPort1.IsOpen)
            {

                serialPort1.WriteLine("V0");
                serialPort1.Close();
            }

            WritePrivateProfileString("PROGRAM", "MODE", tabControl1.SelectedIndex.ToString(), System.IO.Path.GetDirectoryName(path) + "\\Setup.ini"); ;
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            if (Connect.Text == "Connect")
            {
                if (guid.Text == "")
                {
                    MessageBox.Show("조이스틱을 선택 하세요");
                    return;
                }
                else
                {
                    try
                    {
                        string[] port_list = comboPorts.Text.Split('-');
                        Console.WriteLine(port_list[0]);

                        serialPort1.PortName = port_list[0];
                        if (!serialPort1.IsOpen)
                        {
                            serialPort1.Open();
                            if (Power_Check.Checked)
                            {
                                serialPort1.WriteLine("E");
                            }
                            else
                            {
                                serialPort1.WriteLine("R");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("아두이노가 연결되지 않았습니다.");
                        return;
                    }

                    getpos_timer1.Start();
                    joypos_timer1.Start();

                    var directInput = new DirectInput();

                    joystickThreadStart = new ThreadStart(GetJoystickInput);
                    joystickThread = new Thread(joystickThreadStart);
                    activeThread = true;

                    joystick = new Joystick(directInput, joystickGuid);

                    // Query all suported ForceFeedback effects
                    var allEffects = joystick.GetEffects();
                    foreach (var effectInfo in allEffects)
                        Console.WriteLine("Effect available {0}", effectInfo.Name);

                    joystick.Properties.BufferSize = 128;
                    joystick.Acquire();
                    joystickThread.Start();

                    Connect.Text = "Disconnect";
                    Mbar.Enabled = true;
                    Vbar.Enabled = true;
                    Dbar.Enabled = true;
                    SetCombo.Enabled = true;

                    Trim_key.Enabled = true;
                    Reset_Trim_key.Enabled = true;
                    Del_Trim_key.Enabled = true;
                    Del_Reset_Trim_key.Enabled = true;
                    try
                    {
                        GetPrivateProfileString("Force_Setup", "setmode", null, ini_set_mode, 32, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                        GetPrivateProfileString("Force_Setup", "multiply", null, ini_multiply, 32, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                        GetPrivateProfileString("Force_Setup", "min_vibration", null, ini_min_vibration, 32, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                        GetPrivateProfileString("Force_Setup", "max_vibration", null, ini_max_vibration, 32, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");

                        SetCombo.SelectedIndex = Int32.Parse(ini_set_mode.ToString());
                        Mbar.Value = Int32.Parse(ini_multiply.ToString());
                        Vbar.Value = Int32.Parse(ini_min_vibration.ToString());
                        Dbar.Value = Int32.Parse(ini_max_vibration.ToString());
                        Vbar_label.Text = Vbar.Value.ToString();
                        Mbar_label.Text = Mbar.Value.ToString();
                        Dbar_label.Text = Dbar.Value.ToString();
                        PutSetupdata();
                    }
                    catch { }
                }
            }
            else if (Connect.Text == "Disconnect")
            {
                activeThread = false;
                serialPort1.Close();
                Mbar.Enabled = false;
                Vbar.Enabled = false;
                Dbar.Enabled = false;
                SetCombo.Enabled = false;
                Trim_key.Enabled = false;
                Reset_Trim_key.Enabled = false;
                Del_Trim_key.Enabled = false;
                Del_Reset_Trim_key.Enabled = false;
                Connect.Text = "Connect";
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            Mbar_label.Text = Mbar.Value.ToString();
            PutSetupdata();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Vbar_label.Text = Vbar.Value.ToString();
            PutSetupdata();
        }
        private void Dbar_Scroll(object sender, EventArgs e)
        {
            Dbar_label.Text = Dbar.Value.ToString();
            PutSetupdata();
        }
        private void JoyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var directInput = new DirectInput();
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
            {
                if (deviceInstance.InstanceName == JoyCombo.SelectedItem.ToString())
                {
                    joystickGuid = deviceInstance.InstanceGuid;
                    guid.Text = joystickGuid.ToString();

                    WritePrivateProfileString("Joystick", "Name", JoyCombo.Text, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                }
            }
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
            {
                if (deviceInstance.InstanceName == JoyCombo.SelectedItem.ToString())
                {
                    joystickGuid = deviceInstance.InstanceGuid;
                    guid.Text = joystickGuid.ToString();

                    WritePrivateProfileString("Joystick", "Name", JoyCombo.Text, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                }
            }
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.FirstPerson, DeviceEnumerationFlags.AllDevices))
            {
                if (deviceInstance.InstanceName == JoyCombo.SelectedItem.ToString())
                {
                    joystickGuid = deviceInstance.InstanceGuid;
                    guid.Text = joystickGuid.ToString();

                    WritePrivateProfileString("Joystick", "Name", JoyCombo.Text, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                }
            }

        }
        private void GetJoystickInput()
        {

            // Poll events from joystick
            while (activeThread)
            {
                joystick.Poll();
                var datas = joystick.GetBufferedData();

                foreach (var state in datas)
                {
                    ConvertJoystickData(state);
                }

                Thread.Sleep(1);
            }
        }
        private void ConvertJoystickData(JoystickUpdate state)
        {
            try
            {
                switch (state.Offset)
                {
                    case JoystickOffset.X: X = state.Value - 32767; break;
                    case JoystickOffset.Y: Y = state.Value - 32767; break;
                    case JoystickOffset.ForceX: ForceX = state.Value; break;
                    case JoystickOffset.ForceY: ForceY = state.Value; break;
                    case JoystickOffset.ForceZ: ForceZ = state.Value; break;

                    case JoystickOffset.TorqueX: TorqueX = state.Value; break;
                    case JoystickOffset.TorqueY: TorqueY = state.Value; break;
                    case JoystickOffset.TorqueZ: TorqueZ = state.Value; break;

                    case JoystickOffset.ForceSliders0: ForceSliders0 = state.Value; break;
                    case JoystickOffset.ForceSliders1: ForceSliders1 = state.Value; break;

                    case JoystickOffset.PointOfViewControllers0: PointOfViewControllers0 = state.Value; break;
                    case JoystickOffset.PointOfViewControllers1: PointOfViewControllers1 = state.Value; break;
                    case JoystickOffset.PointOfViewControllers2: PointOfViewControllers2 = state.Value; break;
                    case JoystickOffset.PointOfViewControllers3: PointOfViewControllers3 = state.Value; break;
                }
                this.Invoke(new MethodInvoker(delegate ()
                {


                    if (state.Offset.ToString().Length >= 22)
                    {
                        if (trimKey == 0 && state.Offset.ToString() + state.Value.ToString() == Trim_key_label.Text)
                        {
                            _x_trim_offset = int.Parse(X_AXIS.Text);
                            _y_trim_offset = int.Parse(Y_AXIS.Text);

                            x_axis_offset.Text = _x_trim_offset.ToString();
                            y_axis_offset.Text = _y_trim_offset.ToString();

                        }

                        if (trimKey == 0 && state.Offset.ToString() + state.Value.ToString() == Reset_Trim_key_label.Text)
                        {
                            _x_trim_offset = 0;
                            _y_trim_offset = 0;
                            x_axis_offset.Text = _x_trim_offset.ToString();
                            y_axis_offset.Text = _y_trim_offset.ToString();
                        }


                        if (trimKey == 1 && state.Offset.ToString().Substring(0, 22) == "PointOfViewControllers")
                        {
                            Trim_key_label.Text = state.Offset.ToString() + state.Value.ToString();
                            WritePrivateProfileString("Trim_Key", "Trim_Key", state.Offset.ToString() + state.Value.ToString(), System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                            trimKey = 0;
                        }
                        if (Reset_trimKey == 1 && state.Offset.ToString().Substring(0, 22) == "PointOfViewControllers")
                        {
                            Reset_Trim_key_label.Text = state.Offset.ToString() + state.Value.ToString();
                            WritePrivateProfileString("Trim_Key", "Reset_Trim_key", state.Offset.ToString() + state.Value.ToString(), System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                            Reset_trimKey = 0;
                        }

                    }
                    else if (state.Offset.ToString().Length >= 7)
                    {

                        if (trimKey == 0 && state.Offset.ToString() == Trim_key_label.Text && state.Value == 128)
                        {
                            _x_trim_offset = int.Parse(X_AXIS.Text);
                            _y_trim_offset = int.Parse(Y_AXIS.Text);

                            x_axis_offset.Text = _x_trim_offset.ToString();
                            y_axis_offset.Text = _y_trim_offset.ToString();

                        }

                        if (trimKey == 0 && state.Offset.ToString() == Reset_Trim_key_label.Text && state.Value == 128)
                        {
                            _x_trim_offset = 0;
                            _y_trim_offset = 0;
                            x_axis_offset.Text = _x_trim_offset.ToString();
                            y_axis_offset.Text = _y_trim_offset.ToString();

                        }


                        if (trimKey == 1 && state.Offset.ToString().Substring(0, 7) == "Buttons")
                        {
                            Trim_key_label.Text = state.Offset.ToString();
                            WritePrivateProfileString("Trim_Key", "Trim_Key", state.Offset.ToString(), System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                            trimKey = 0;
                        }
                        if (Reset_trimKey == 1 && state.Offset.ToString().Substring(0, 7) == "Buttons")
                        {
                            Reset_Trim_key_label.Text = state.Offset.ToString();
                            WritePrivateProfileString("Trim_Key", "Reset_Trim_key", state.Offset.ToString(), System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                            Reset_trimKey = 0;
                        }
                    }



                    if (_x_trim_offset > 32767) _x_trim_offset = 32767;
                    if (_y_trim_offset > 32767) _y_trim_offset = 32767;

                    x_last = X + _x_trim_offset;
                    y_last = Y + _y_trim_offset;

                    if (x_last > 32767) x_last = 32767;
                    if (y_last > 32767) y_last = 32767;

                    if (x_last < -32767) x_last = -32767;
                    if (y_last < -32767) y_last = -32767;


                    X_AXIS.Text = x_last.ToString();
                    Y_AXIS.Text = y_last.ToString();

                }));
            }
            catch { }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private void joypos_timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (BEFORE_X_AXIS != X_AXIS.Text || BEFORE_Y_AXIS != Y_AXIS.Text)
                {
                    serialPort1.WriteLine("P" + X_AXIS.Text + "," + Y_AXIS.Text);
                    BEFORE_X_AXIS = X_AXIS.Text;
                    BEFORE_Y_AXIS = Y_AXIS.Text;
                }
            }
        }
        private void SetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboLock == false)
            {
                PutSetupdata();
            }

        }
        private void getpos_timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                RxString = serialPort1.ReadExisting();

                Debug.WriteLine(RxString);

                for (int i = 0; i < RxString.Length; i++)
                {
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(RxString.Substring(i, 1));

                    string imsi = BitConverter.ToString(asciiBytes, 0);

                    if (imsi == "0D")
                    {
                        try
                        {
                            if (RxString_line != null)
                            {
                                string[] aduino_data = RxString_line.Split('|');


                                if (aduino_data[0] == "D")
                                {
                                    X_FOS.Text = aduino_data[1];
                                    Y_FOS.Text = aduino_data[2];
                                    X_VIB.Text = aduino_data[5];
                                    Y_VIB.Text = aduino_data[6];


                                    double xpersent = double.Parse(aduino_data[7]);
                                    double ypersent = double.Parse(aduino_data[8]);


                                    xpersent = Math.Round((xpersent / 255) * 100);
                                    ypersent = Math.Round((ypersent / 255) * 100);


                                    X_VIB_M.Text = xpersent.ToString() + "%";
                                    Y_VIB_M.Text = xpersent.ToString() + "%";
                                }
                                if (aduino_data[0] == "H")
                                {
                                    string[] get_comports = RxString_line.Split('|');

                                    serialPort1.Close();

                                }
                            }
                        }
                        catch { }
                        RxString_line = null;
                    }

                    if (imsi == "0D" || imsi == "0A")
                    {
                    }
                    else
                    {
                        RxString_line += RxString.Substring(i, 1);
                    }
                }

            }
        }
        private void PutSetupdata()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("K");
                serialPort1.WriteLine("W" + SetCombo.SelectedIndex + "," + Mbar.Value + "." + Vbar.Value + ":" + Dbar.Value);
                try
                {
                    WritePrivateProfileString("Force_Setup", "setmode", SetCombo.SelectedIndex.ToString(), System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                    WritePrivateProfileString("Force_Setup", "multiply", Mbar.Value.ToString(), System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                    WritePrivateProfileString("Force_Setup", "min_vibration", Vbar.Value.ToString(), System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                    WritePrivateProfileString("Force_Setup", "max_vibration", Dbar.Value.ToString(), System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                }
                catch { }
            }
        }
        private void Trim_key_Click(object sender, EventArgs e)
        {
            trimKey = 1;
        }
        private void Reset_Trim_key_Click(object sender, EventArgs e)
        {
            Reset_trimKey = 1;
        }
        private void Del_Trim_key_Click(object sender, EventArgs e)
        {
            Trim_key_label.Text = "";
            WritePrivateProfileString("Trim_Key", "Trim_key", null, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
        }
        private void Del_Reset_Trim_key_Click(object sender, EventArgs e)
        {
            Reset_Trim_key_label.Text = "";
            WritePrivateProfileString("Trim_Key", "Reset_Trim_key", null, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // DCS 전용 작업
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        string Rxdata_line;
        bool Heli_mode = false;

        private void Connect_DCS_Click(object sender, EventArgs e)
        {
            if (Connect_DCS.Text == "Connect")
            {
                try
                {
                    string[] port_list = comboPorts.Text.Split('-');
                    serialPort1.PortName = port_list[0];

                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                        serialPort1.WriteLine("L");
                        if (Power_Check.Checked)
                        {
                            serialPort1.WriteLine("E");
                        }
                        else
                        {
                            serialPort1.WriteLine("R");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("아두이노가 연결되지 않았습니다.");
                    return;
                }

                // UDP데이터 GET
                srv = new UdpClient(41230);
                remoteEP = new IPEndPoint(IPAddress.Any, 0);
                UdpThreadStart = new ThreadStart(GetUDPData);
                UdpThread = new Thread(UdpThreadStart);
                activeThread_udp = true;
                UdpThread.Start();

                //가속도 계산
                ACCS_THREAD_START = new ThreadStart(GET_ACCS_VIBRATION);
                ACCS_THREAD = new Thread(ACCS_THREAD_START);
                ACTIVE_ACCS_THREAD = true;
                ACCS_THREAD.Start();


                //판넬 진폭 계산
                PANEL_THREAD_START = new ThreadStart(GET_PANEL_VIBRATION);
                PANEL_THREAD = new Thread(PANEL_THREAD_START);
                ACTIVE_PANEL_THREAD = true;
                PANEL_THREAD.Start();

                //AOA 진폭 계산
                AOA_THREAD_START = new ThreadStart(GET_AOA_VIBRATION);
                AOA_THREAD = new Thread(AOA_THREAD_START);
                ACTIVE_AOA_THREAD = true;
                AOA_THREAD.Start();

                //스피드브레이크 
                SPDBREAK_THREAD_START = new ThreadStart(GET_SPDBREAK_VIBRATION);
                SPDBREAK_THREAD = new Thread(SPDBREAK_THREAD_START);
                ACTIVE_SPDBREAK_THREAD = true;
                SPDBREAK_THREAD.Start();

                //랜딩기어 
                GEAR_THREAD_START = new ThreadStart(GET_GEAR_VIBRATION);
                GEAR_THREAD = new Thread(GEAR_THREAD_START);
                ACTIVE_GEAR_THREAD = true;
                GEAR_THREAD.Start();

                //기총 
                GUN_THREAD_START = new ThreadStart(GET_GUN_VIBRATION);
                GUN_THREAD = new Thread(GUN_THREAD_START);
                ACTIVE_GUN_THREAD = true;
                GUN_THREAD.Start();


                //Payload , 미사일 
                PAYLOAD_THREAD_START = new ThreadStart(GET_PAYLOAD_VIBRATION);
                PAYLOAD_THREAD = new Thread(PAYLOAD_THREAD_START);
                ACTIVE_PAYLOAD_THREAD = true;
                PAYLOAD_THREAD.Start();

                //채프, 플레어 
                FLARECHAFF_THREAD_START = new ThreadStart(GET_FLARECHAFF_VIBRATION);
                FLARECHAFF_THREAD = new Thread(FLARECHAFF_THREAD_START);
                ACTIVE_FLARECHAFF_THREAD = true;
                FLARECHAFF_THREAD.Start();

                //유효전이양력
                HELI_THREAD_START = new ThreadStart(GET_HELI_VIBRATION);
                HELI_THREAD = new Thread(HELI_THREAD_START);
                ACTIVE_HELI_THREAD = true;
                HELI_THREAD.Start();


                // 데이터 전송가동
                vib_timer1.Start();
                PLANE_LIST_COMBO.Enabled = false;
                Connect_DCS.Text = "Disconnect";

            }
            else
            {
                srv.Close();
                activeThread_udp = false;
                ACTIVE_ACCS_THREAD = false;
                ACTIVE_PANEL_THREAD = false;
                ACTIVE_AOA_THREAD = false;
                ACTIVE_SPDBREAK_THREAD = false;
                ACTIVE_GEAR_THREAD = false;
                ACTIVE_GUN_THREAD = false;
                ACTIVE_PAYLOAD_THREAD = false;
                ACTIVE_FLARECHAFF_THREAD = false;
                ACTIVE_HELI_THREAD = false;

                Connect_DCS.Text = "Connect";
                ACC_VIB.Text = "0";
                PANEL_VIB.Text = "0";
                AOA_VIB.Text = "0";
                GEAR_VIB.Text = "0";
                GUN_VIB.Text = "0";
                PAYLOAD_VIB.Text = "0";
                FLARE_VIB.Text = "0";
                CHAFF_VIB.Text = "0";
                SPDBREAK_VIB.Text = "0";
                HELI_VIB.Text = "0";
                VIB_OUT.Text = "0";

                serialPort1.WriteLine("V0");
                serialPort1.Close();
                vib_timer1.Stop();
                PLANE_LIST_COMBO.Enabled = true;
            }
        }
        private void GetUDPData()
        {
            Console.WriteLine("STARTTHREAD");
            while (activeThread_udp)
            {
                byte[] Rxdata = new byte[8192];
                string stringData;
                try
                {
                    Rxdata = srv.Receive(ref remoteEP);
                }
                catch (Exception ex) { }

                stringData = Encoding.UTF8.GetString(Rxdata);
                for (int i = 0; i < stringData.Length; i++)
                {
                    if (stringData.Substring(i, 1) == "|")
                    {
                        lastData_Time = DateTime.Now;

                        string[] Lua_data = Rxdata_line.Split(';');

                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            if (DCS_PLANE_NAME.Text != Lua_data[1])
                            {
                                DCS_PLANE_NAME.Text = Lua_data[1];
                                PLANE_LIST_COMBO.Text = Lua_data[1].ToString();

                                GetPrivateProfileString("DCS_PLANE", DCS_PLANE_NAME.Text, null, ini_plane_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");

                                if (ini_plane_setup.Length == 0)
                                {
                                    WritePrivateProfileString("DCS_PLANE", Lua_data[1].ToString(), "13,25,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,1", System.IO.Path.GetDirectoryName(path) + "\\Setup.ini"); ;
                                    GetPrivateProfileString("DCS_PLANE", DCS_PLANE_NAME.Text, null, ini_plane_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                                    LOAD_INI(ini_plane_setup.ToString());
                                    ACC_CHK.Enabled = true;
                                    PANEL_CHK.Enabled = true;
                                    AOA_CHK.Enabled = true;
                                    SPDBREAK_CHK.Enabled = true;
                                    GEAR_CHK.Enabled = true;
                                    GUN_CHK.Enabled = true;
                                    FLARE_CHK.Enabled = true;
                                    CHAFF_CHK.Enabled = true;
                                    PAYLOAD_CHK.Enabled = true;
                                    HELI_CHK.Enabled = true;

                                    ACC_VIB_PER.Enabled = true;
                                    PANEL_VIB_PER.Enabled = true;
                                    AOA_VIB_PER.Enabled = true;
                                    SPDBREAK_VIB_PER.Enabled = true;
                                    GEAR_VIB_PER.Enabled = true;
                                    GUN_VIB_PER.Enabled = true;
                                    FLARE_VIB_PER.Enabled = true;
                                    CHAFF_VIB_PER.Enabled = true;
                                    PAYLOAD_VIB_PER.Enabled = true;
                                    HELI_VIB_PER.Enabled = true;

                                    AOA_S_COMBO.Enabled = true;
                                    AOA_M_COMBO.Enabled = true;

                                    ACC_VIB_MIN.Enabled = true;
                                    PANEL_VIB_MIN.Enabled = true;


                                    if (DCS_PLANE_NAME.Text == "SA342M" || DCS_PLANE_NAME.Text == "SA342L" || DCS_PLANE_NAME.Text == "SA342Mistral" || DCS_PLANE_NAME.Text == "SA342Minigun" || DCS_PLANE_NAME.Text == "Ka-50" || DCS_PLANE_NAME.Text == "UH-1H" || DCS_PLANE_NAME.Text == "Mi-8MT" || DCS_PLANE_NAME.Text == "AH-64D_BLK_II")
                                    {
                                        Heli_mode = true;
                                        HELI_VIB_PER.Enabled = true;
                                        HELI_CHK.Enabled = true;
                                    }
                                    else
                                    {
                                        Heli_mode = false;
                                        HELI_VIB_PER.Enabled = false;
                                        HELI_CHK.Enabled = false;
                                        HELI_CHK.Checked = false;
                                    }
                                }
                                else
                                {
                                    LOAD_INI(ini_plane_setup.ToString());
                                    if (DCS_PLANE_NAME.Text == "SA342M" || DCS_PLANE_NAME.Text == "SA342L" || DCS_PLANE_NAME.Text == "SA342Mistral" || DCS_PLANE_NAME.Text == "SA342Minigun" || DCS_PLANE_NAME.Text == "Ka-50" || DCS_PLANE_NAME.Text == "UH-1H" || DCS_PLANE_NAME.Text == "Mi-8MT" || DCS_PLANE_NAME.Text == "AH-64D_BLK_II")
                                    {
                                        Heli_mode = true;
                                        HELI_VIB_PER.Enabled = true;
                                        HELI_CHK.Enabled = true;
                                    }
                                    else
                                    {
                                        Heli_mode = false;
                                        HELI_VIB_PER.Enabled = false;
                                        HELI_CHK.Enabled = false;
                                        HELI_CHK.Checked = false;
                                    }
                                }
                                plane_list_update();
                            }

                            DCS_ACCS_X.Text = Lua_data[2];
                            DCS_ACCS_Y.Text = Lua_data[3];
                            DCS_ACCS_Z.Text = Lua_data[4];
                            DCS_AOA.Text = Lua_data[5];
                            DCS_GUN.Text = Lua_data[6];
                            DCS_GEAR.Text = Lua_data[7];
                            DCS_SPDBREAK.Text = Lua_data[8];
                            DCS_FLARE.Text = Lua_data[9];
                            DCS_CHAFF.Text = Lua_data[10];
                            DCS_PAYLOAD.Text = Lua_data[11];


                            string[] Panel_Shake = Lua_data[12].Split(',');
                            DCS_PANEL_1.Text = (double.Parse(Panel_Shake[0]) * 2000).ToString();

                            if (Panel_Shake.Length >= 2)
                            {
                                DCS_PANEL_2.Text = (double.Parse(Panel_Shake[1]) * 2000).ToString();
                            }
                            else if (Panel_Shake.Length >= 3)
                            {
                                DCS_PANEL_3.Text = (double.Parse(Panel_Shake[2]) * 2000).ToString();
                            }
                            else if (Panel_Shake.Length >= 4)
                            {
                                DCS_PANEL_4.Text = (double.Parse(Panel_Shake[3]) * 2000).ToString();
                            }
                            else if (Panel_Shake.Length >= 5)
                            {
                                label31.Text = (double.Parse(Panel_Shake[4]) * 2000).ToString();
                            }


                            string[] Engine_RPM = Lua_data[13].Split(',');
                            DCS_ENG_1.Text = (double.Parse(Engine_RPM[0])).ToString();

                            if (Engine_RPM.Length >= 2)
                            {
                                DCS_ENG_2.Text = (double.Parse(Engine_RPM[1])).ToString();
                            }

                            DCS_IAS.Text = (double.Parse(Lua_data[14]) * 1.943844).ToString();

                        }));
                        Rxdata_line = null;
                    }

                    if (stringData.Substring(i, 1) == "|")
                    {
                    }
                    else
                    {
                        Rxdata_line += stringData.Substring(i, 1);
                    }
                }
            }
        }


        private void GET_ACCS_VIBRATION()
        {
            double before_accs_x = 0;
            double before_accs_y = 0;
            double before_accs_z = 0;
            double[] vib = new double[3];


            while (ACTIVE_ACCS_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double x_vib = before_accs_x - double.Parse(DCS_ACCS_X.Text);
                    double y_vib = before_accs_y - double.Parse(DCS_ACCS_Y.Text);
                    double z_vib = before_accs_z - double.Parse(DCS_ACCS_Z.Text);


                    if (x_vib < 0) x_vib = x_vib * -1;
                    if (y_vib < 0) y_vib = y_vib * -1;
                    if (z_vib < 0) z_vib = z_vib * -1;

                    x_vib = Math.Round(x_vib, 0);
                    y_vib = Math.Round(y_vib, 0);
                    z_vib = Math.Round(z_vib, 0);


                    before_accs_x = double.Parse(DCS_ACCS_X.Text);
                    before_accs_y = double.Parse(DCS_ACCS_Y.Text);
                    before_accs_z = double.Parse(DCS_ACCS_Z.Text);

                    vib[0] = x_vib;
                    vib[1] = y_vib;
                    vib[2] = z_vib;

                    ACC_VIB.Text = vib.Max().ToString();
                }));
                Thread.Sleep(100);
            }
        }




        private void GET_PANEL_VIBRATION()
        {
            double before_panel_vib_1 = 0;
            double before_panel_vib_2 = 0;
            double before_panel_vib_3 = 0;
            double before_panel_vib_4 = 0;
            double before_panel_vib_5 = 0;

            double[] vib = new double[5];

            while (ACTIVE_PANEL_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (DCS_PANEL_1.Text == "000")
                    {

                    }
                    else
                    {
                        double vib1 = before_panel_vib_1 - double.Parse(DCS_PANEL_1.Text);
                        double vib2 = before_panel_vib_2 - double.Parse(DCS_PANEL_2.Text);
                        double vib3 = before_panel_vib_3 - double.Parse(DCS_PANEL_3.Text);
                        double vib4 = before_panel_vib_4 - double.Parse(DCS_PANEL_4.Text);
                        double vib5 = before_panel_vib_5 - double.Parse(DCS_PANEL_5.Text);


                        if (vib1 < 0) vib1 = vib1 * -1 / 2;
                        if (vib2 < 0) vib1 = vib2 * -1 / 2;
                        if (vib3 < 0) vib1 = vib3 * -1 / 2;
                        if (vib4 < 0) vib1 = vib4 * -1 / 2;
                        if (vib5 < 0) vib1 = vib5 * -1 / 2;

                        vib1 = Math.Round(vib1, 0);
                        vib2 = Math.Round(vib2, 0);
                        vib3 = Math.Round(vib3, 0);
                        vib4 = Math.Round(vib4, 0);
                        vib5 = Math.Round(vib5, 0);


                        before_panel_vib_1 = double.Parse(DCS_PANEL_1.Text);
                        before_panel_vib_2 = double.Parse(DCS_PANEL_2.Text);
                        before_panel_vib_3 = double.Parse(DCS_PANEL_3.Text);
                        before_panel_vib_4 = double.Parse(DCS_PANEL_4.Text);
                        before_panel_vib_5 = double.Parse(DCS_PANEL_5.Text);

                        vib[0] = vib1;
                        vib[1] = vib2;
                        vib[2] = vib3;
                        vib[3] = vib4;
                        vib[4] = vib5;

                        PANEL_VIB.Text = vib.Max().ToString();


                    }
                }));
                Thread.Sleep(100);
            }
        }


        private void GET_AOA_VIBRATION()
        {
            while (ACTIVE_AOA_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double AOA_MIN = double.Parse(AOA_S_COMBO.Text);
                    double AOA_MAX = double.Parse(AOA_M_COMBO.Text);
                    double VIB = 0;

                    if (double.Parse(DCS_AOA.Text) > AOA_MIN)
                    {
                        VIB = (((double.Parse(DCS_AOA.Text) - AOA_MIN) / (AOA_MAX - AOA_MIN)) * 255);
                        AOA_VIB.Text = VIB.ToString();

                    }
                    else
                    {
                        AOA_VIB.Text = "0";
                    }
                }));
                Thread.Sleep(100);
            }
        }


        private void GET_SPDBREAK_VIBRATION()
        {
            while (ACTIVE_SPDBREAK_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double IAS_DATA = 0;
                    double VIB_PER = 0;
                    IAS_DATA = double.Parse(DCS_IAS.Text);

                    if (IAS_DATA < 50)
                    {
                        VIB_PER = 0;
                    }
                    else if (IAS_DATA < 150)
                    {
                        VIB_PER = (IAS_DATA - 50) / 100;
                        if (VIB_PER > 1) VIB_PER = 1;
                    }
                    else
                    {
                        VIB_PER = 1;
                    }

                    if (double.Parse(DCS_SPDBREAK.Text) > 0)
                    {
                        double VIB = (255 * double.Parse(DCS_SPDBREAK.Text) / 2) * VIB_PER;

                        int VIB_INT = Convert.ToInt32(VIB);

                        SPDBREAK_VIB.Text = VIB_INT.ToString();

                    }
                    else
                    {
                        SPDBREAK_VIB.Text = "0";
                    }


                }));
                Thread.Sleep(100);
            }
        }


        private void GET_GEAR_VIBRATION()
        {
            string BEFORE_GEAR = "0";
            while (ACTIVE_GEAR_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    if (BEFORE_GEAR != DCS_GEAR.Text)
                    {
                        GEAR_VIB.Text = "80";
                    }
                    else
                    {
                        GEAR_VIB.Text = "0";
                    }
                    BEFORE_GEAR = DCS_GEAR.Text;
                }));

                Thread.Sleep(100);
            }
        }
        private void GET_GUN_VIBRATION()
        {
            string BEFORE_GUN = "0";
            while (ACTIVE_GUN_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    if (BEFORE_GUN != DCS_GUN.Text)
                    {
                        GUN_VIB.Text = "200";
                    }
                    else
                    {
                        GUN_VIB.Text = "0";
                    }
                    BEFORE_GUN = DCS_GUN.Text;
                }));
                Thread.Sleep(100);
            }
        }

        private void GET_PAYLOAD_VIBRATION()
        {
            string BEFORE_PAYLOAD = "0";

            while (ACTIVE_PAYLOAD_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (BEFORE_PAYLOAD != DCS_PAYLOAD.Text)
                    {
                        PAYLOAD_VIB.Text = "255";
                    }
                    else
                    {
                        PAYLOAD_VIB.Text = "0";
                    }
                    BEFORE_PAYLOAD = DCS_PAYLOAD.Text;
                }));
                Thread.Sleep(400);
            }
        }

        private void GET_FLARECHAFF_VIBRATION()
        {
            string BEFORE_FLARE = "0";
            string BEFORE_CHAFF = "0";

            while (ACTIVE_FLARECHAFF_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    if (BEFORE_FLARE != DCS_FLARE.Text)
                    {
                        FLARE_VIB.Text = "200";
                    }
                    else
                    {
                        FLARE_VIB.Text = "0";
                    }
                    BEFORE_FLARE = DCS_FLARE.Text;

                    if (BEFORE_CHAFF != DCS_CHAFF.Text)
                    {
                        CHAFF_VIB.Text = "200";
                    }
                    else
                    {
                        CHAFF_VIB.Text = "0";
                    }
                    BEFORE_CHAFF = DCS_CHAFF.Text;
                }));
                Thread.Sleep(200);
            }
        }



        private void GET_HELI_VIBRATION()
        {

            while (ACTIVE_HELI_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (Heli_mode == true)
                    {
                        if (double.Parse(DCS_IAS.Text) >= 10 && double.Parse(DCS_IAS.Text) <= 25)
                        {
                            double VIB = (double.Parse(DCS_IAS.Text) - 10) / 15 * 100;
                            HELI_VIB.Text = VIB.ToString();
                        }
                        else if (double.Parse(DCS_IAS.Text) <= 40 && double.Parse(DCS_IAS.Text) > 20)
                        {
                            double VIB = (double.Parse(DCS_IAS.Text) - 40) / 15 * 100;
                            VIB = VIB * -1;
                            HELI_VIB.Text = VIB.ToString();
                        }
                        else
                        {
                            double VIB = 0;
                            HELI_VIB.Text = VIB.ToString();
                        }
                    }
                    else
                    {
                        HELI_VIB.Text = "0";
                        HELI_VIB_OUT.Text = "0";
                    }
                }));


                Thread.Sleep(100);
            }
        }


        private void plane_list_update()
        {
            EXTERN.GET_PLANE EXT = new EXTERN.GET_PLANE();

            byte[] PLANE_BYES = EXT.get_plane_list();
            string PLANE_RAW_LIST = Encoding.ASCII.GetString(PLANE_BYES, 0, 32767);
            PLANE_RAW_LIST = Encoding.ASCII.GetString(PLANE_BYES, 0, 32767);
            string[] PLANE_LIST = PLANE_RAW_LIST.Split('\0');

            PLANE_LIST_COMBO.Items.Clear();

            for (int i = 0; i < PLANE_LIST.Length; i++)
            {
                if (PLANE_LIST[i] != "") PLANE_LIST_COMBO.Items.Add(PLANE_LIST[i]);
            }

        }

        private void vib_timer1_Tick(object sender, EventArgs e)
        {
            double[] VIBRATION = new double[10];
            TimeSpan dateDiff = DateTime.Now - lastData_Time;
            int diffSecond = dateDiff.Seconds;

            if (diffSecond > 1)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine("V0");
                }
            }
            else
            {
                // 255 이상은 의미 없기때문에 고정함
                if (double.Parse(ACC_VIB.Text) * (double.Parse(ACC_VIB_PER.Text) / 100) > 255)
                {
                    ACC_VIB_OUT.Text = "255";
                }
                else
                {
                    if (double.Parse(ACC_VIB.Text) > double.Parse(ACC_VIB_MIN.Text))
                    {
                        ACC_VIB_OUT.Text = (double.Parse(ACC_VIB.Text) * (double.Parse(ACC_VIB_PER.Text) / 100)).ToString();
                    }
                    else
                    {
                        ACC_VIB_OUT.Text = "0";
                    }
                }
                if ((double.Parse(PANEL_VIB.Text) * (double.Parse(PANEL_VIB_PER.Text) / 100)) > 255)
                {
                    PANEL_VIB_OUT.Text = "255";
                }
                else
                {
                    if (double.Parse(PANEL_VIB.Text) > double.Parse(PANEL_VIB_MIN.Text))
                    {
                        PANEL_VIB_OUT.Text = (double.Parse(PANEL_VIB.Text) * (double.Parse(PANEL_VIB_PER.Text) / 100)).ToString();
                    }
                    else
                    {
                        PANEL_VIB_OUT.Text = "0";
                    }
                }
                if ((double.Parse(AOA_VIB.Text) * (double.Parse(AOA_VIB_PER.Text) / 100)) > 255)
                {
                    AOA_VIB_OUT.Text = "255";
                }
                else
                {
                    AOA_VIB_OUT.Text = (double.Parse(AOA_VIB.Text) * (double.Parse(AOA_VIB_PER.Text) / 100)).ToString();
                }
                if ((double.Parse(GEAR_VIB.Text) * (double.Parse(GEAR_VIB_PER.Text) / 100)) > 255)
                {
                    GEAR_VIB_OUT.Text = "255";
                }
                else
                {
                    GEAR_VIB_OUT.Text = (double.Parse(GEAR_VIB.Text) * (double.Parse(GEAR_VIB_PER.Text) / 100)).ToString();
                }
                if ((double.Parse(GUN_VIB_OUT.Text) * (double.Parse(GUN_VIB_PER.Text) / 100)) > 255)
                {
                    GUN_VIB_OUT.Text = "255";
                }
                else
                {
                    GUN_VIB_OUT.Text = (double.Parse(GUN_VIB.Text) * (double.Parse(GUN_VIB_PER.Text) / 100)).ToString();
                }
                if ((double.Parse(PAYLOAD_VIB.Text) * (double.Parse(PAYLOAD_VIB_PER.Text) / 100)) > 255)
                {
                    PAYLOAD_VIB_OUT.Text = "255";
                }
                else
                {
                    PAYLOAD_VIB_OUT.Text = (double.Parse(PAYLOAD_VIB.Text) * (double.Parse(PAYLOAD_VIB_PER.Text) / 100)).ToString();
                }
                if ((double.Parse(FLARE_VIB.Text) * (double.Parse(FLARE_VIB_PER.Text) / 100)) > 255)
                {
                    FLARE_VIB_OUT.Text = "255";
                }
                else
                {
                    FLARE_VIB_OUT.Text = (double.Parse(FLARE_VIB.Text) * (double.Parse(FLARE_VIB_PER.Text) / 100)).ToString();
                }
                if ((double.Parse(CHAFF_VIB.Text) * (double.Parse(CHAFF_VIB_PER.Text) / 100)) > 255)
                {
                    CHAFF_VIB_OUT.Text = "255";
                }
                else
                {
                    CHAFF_VIB_OUT.Text = (double.Parse(CHAFF_VIB.Text) * (double.Parse(CHAFF_VIB_PER.Text) / 100)).ToString();
                }
                if ((double.Parse(SPDBREAK_VIB.Text) * (double.Parse(SPDBREAK_VIB_PER.Text) / 100)) > 255)
                {
                    SPDBREAK_VIB_OUT.Text = "255";
                }
                else
                {
                    SPDBREAK_VIB_OUT.Text = (double.Parse(SPDBREAK_VIB.Text) * (double.Parse(SPDBREAK_VIB_PER.Text) / 100)).ToString();
                }
                if ((double.Parse(HELI_VIB.Text) * (double.Parse(HELI_VIB_PER.Text) / 100)) > 255)
                {
                    HELI_VIB_OUT.Text = "255";
                }
                else
                {
                    HELI_VIB_OUT.Text = (double.Parse(HELI_VIB.Text) * (double.Parse(HELI_VIB_PER.Text) / 100)).ToString();
                }


                if (ACC_CHK.Checked == true) VIBRATION[0] = double.Parse(ACC_VIB_OUT.Text); else VIBRATION[0] = 0;
                if (PANEL_CHK.Checked == true) VIBRATION[1] = double.Parse(PANEL_VIB_OUT.Text); else VIBRATION[1] = 0;
                if (AOA_CHK.Checked == true) VIBRATION[2] = double.Parse(AOA_VIB_OUT.Text); else VIBRATION[2] = 0;
                if (GEAR_CHK.Checked == true) VIBRATION[3] = double.Parse(GEAR_VIB_OUT.Text); else VIBRATION[3] = 0;
                if (GUN_CHK.Checked == true) VIBRATION[4] = double.Parse(GUN_VIB_OUT.Text); else VIBRATION[4] = 0;
                if (PAYLOAD_CHK.Checked == true) VIBRATION[5] = double.Parse(PAYLOAD_VIB_OUT.Text); else VIBRATION[5] = 0;
                if (FLARE_CHK.Checked == true) VIBRATION[6] = double.Parse(FLARE_VIB_OUT.Text); else VIBRATION[6] = 0;
                if (CHAFF_CHK.Checked == true) VIBRATION[7] = double.Parse(CHAFF_VIB_OUT.Text); else VIBRATION[7] = 0;
                if (SPDBREAK_CHK.Checked == true) VIBRATION[8] = double.Parse(SPDBREAK_VIB_OUT.Text); else VIBRATION[8] = 0;
                if (HELI_CHK.Checked == true) VIBRATION[9] = double.Parse(HELI_VIB_OUT.Text); else VIBRATION[9] = 0;



                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine("V" + VIBRATION.Max().ToString());
                    VIB_OUT.Text = VIBRATION.Max().ToString();
                }
            }
        }

        private void LOAD_INI(string INI_DATA)
        {
            string[] ini_data = INI_DATA.Split(',');
            AOA_S_COMBO.Text = ini_data[0];
            AOA_M_COMBO.Text = ini_data[1];

            if (ini_data[2] == "1") ACC_CHK.Checked = true; else ACC_CHK.Checked = false;
            ACC_VIB_PER.Text = ini_data[3];
            if (ini_data[4] == "1") PANEL_CHK.Checked = true; else PANEL_CHK.Checked = false;
            PANEL_VIB_PER.Text = ini_data[5];
            if (ini_data[6] == "1") AOA_CHK.Checked = true; else AOA_CHK.Checked = false;
            AOA_VIB_PER.Text = ini_data[7];
            if (ini_data[8] == "1") SPDBREAK_CHK.Checked = true; else SPDBREAK_CHK.Checked = false;
            SPDBREAK_VIB_PER.Text = ini_data[9];
            if (ini_data[10] == "1") GEAR_CHK.Checked = true; else GEAR_CHK.Checked = false;
            GEAR_VIB_PER.Text = ini_data[11];
            if (ini_data[12] == "1") GUN_CHK.Checked = true; else GUN_CHK.Checked = false;
            GUN_VIB_PER.Text = ini_data[13];
            if (ini_data[14] == "1") FLARE_CHK.Checked = true; else FLARE_CHK.Checked = false;
            FLARE_VIB_PER.Text = ini_data[15];
            if (ini_data[16] == "1") CHAFF_CHK.Checked = true; else CHAFF_CHK.Checked = false;
            CHAFF_VIB_PER.Text = ini_data[17];
            if (ini_data[18] == "1") PAYLOAD_CHK.Checked = true; else PAYLOAD_CHK.Checked = false;
            PAYLOAD_VIB_PER.Text = ini_data[19];
            if (ini_data[20] == "1") HELI_CHK.Checked = true; else HELI_CHK.Checked = false;
            HELI_VIB_PER.Text = ini_data[21];
            ACC_VIB_MIN.Text = ini_data[22];
            PANEL_VIB_MIN.Text = ini_data[23];


        }
        private void SAVE_INI()
        {
            string ini_data = null;

            ini_data += AOA_S_COMBO.Text + "," + AOA_M_COMBO.Text + ",";

            if (ACC_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += ACC_VIB_PER.Text + ",";
            if (PANEL_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += PANEL_VIB_PER.Text + ",";
            if (AOA_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += AOA_VIB_PER.Text + ",";
            if (SPDBREAK_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += SPDBREAK_VIB_PER.Text + ",";
            if (GEAR_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += GEAR_VIB_PER.Text + ",";
            if (GUN_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += GUN_VIB_PER.Text + ",";
            if (FLARE_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FLARE_VIB_PER.Text + ",";
            if (CHAFF_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += CHAFF_VIB_PER.Text + ",";
            if (PAYLOAD_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += PAYLOAD_VIB_PER.Text + ",";
            if (HELI_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += HELI_VIB_PER.Text;
            ini_data += "," + ACC_VIB_MIN.Text;
            ini_data += "," + PANEL_VIB_MIN.Text;

            WritePrivateProfileString("DCS_PLANE", PLANE_LIST_COMBO.Text, ini_data, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
        }


        private void DEFAULT_SETUP_Click(object sender, EventArgs e)
        {
            ACC_CHK.Checked = true;
            PANEL_CHK.Checked = true;
            AOA_CHK.Checked = true;
            SPDBREAK_CHK.Checked = true;
            GEAR_CHK.Checked = true;
            GUN_CHK.Checked = true;
            FLARE_CHK.Checked = true;
            CHAFF_CHK.Checked = true;
            PAYLOAD_CHK.Checked = true;
            HELI_CHK.Checked = true;

            ACC_VIB_PER.Text = "100";
            PANEL_VIB_PER.Text = "100";
            AOA_VIB_PER.Text = "100";
            SPDBREAK_VIB_PER.Text = "100";
            GEAR_VIB_PER.Text = "100";
            GUN_VIB_PER.Text = "100";
            FLARE_VIB_PER.Text = "100";
            CHAFF_VIB_PER.Text = "100";
            PAYLOAD_VIB_PER.Text = "100";
            HELI_VIB_PER.Text = "100";

            AOA_S_COMBO.Text = "13";
            AOA_M_COMBO.Text = "25";
            ACC_VIB_MIN.Text = "1";
            PANEL_VIB_MIN.Text = "1";

        }

        private void ACC_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void PANEL_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void AOA_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void SPDBREAK_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void GEAR_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void GUN_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void FLARE_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void CHAFF_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void PAYLOAD_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void ACC_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void PANEL_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void AOA_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void SPDBREAK_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void GEAR_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void GUN_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void FLARE_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void CHAFF_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void PAYLOAD_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void AOA_S_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }

        private void AOA_M_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }
        private void HELI_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }
        private void HELI_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }
        private void ACC_VIB_MIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }
        private void PANEL_VIB_MIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI();
        }


        private void PLANE_LIST_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PLANE_LIST_COMBO.Text != null)
            {
                ACC_CHK.Enabled = true;
                PANEL_CHK.Enabled = true;
                AOA_CHK.Enabled = true;
                SPDBREAK_CHK.Enabled = true;
                GEAR_CHK.Enabled = true;
                GUN_CHK.Enabled = true;
                FLARE_CHK.Enabled = true;
                CHAFF_CHK.Enabled = true;
                PAYLOAD_CHK.Enabled = true;
                HELI_CHK.Enabled = true;

                ACC_VIB_PER.Enabled = true;
                PANEL_VIB_PER.Enabled = true;
                AOA_VIB_PER.Enabled = true;
                SPDBREAK_VIB_PER.Enabled = true;
                GEAR_VIB_PER.Enabled = true;
                GUN_VIB_PER.Enabled = true;
                FLARE_VIB_PER.Enabled = true;
                CHAFF_VIB_PER.Enabled = true;
                PAYLOAD_VIB_PER.Enabled = true;
                HELI_VIB_PER.Enabled = true;

                AOA_S_COMBO.Enabled = true;
                AOA_M_COMBO.Enabled = true;
                ACC_VIB_MIN.Enabled = true;
                PANEL_VIB_MIN.Enabled = true;



                GetPrivateProfileString("DCS_PLANE", PLANE_LIST_COMBO.Text, null, ini_plane_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                LOAD_INI(ini_plane_setup.ToString());

                if (DCS_PLANE_NAME.Text == "SA342M" || DCS_PLANE_NAME.Text == "SA342L" || DCS_PLANE_NAME.Text == "SA342Mistral" || DCS_PLANE_NAME.Text == "SA342Minigun" || DCS_PLANE_NAME.Text == "Ka-50" || DCS_PLANE_NAME.Text == "UH-1H" || DCS_PLANE_NAME.Text == "Mi-8MT" || DCS_PLANE_NAME.Text == "AH-64D_BLK_II")
                {
                    Heli_mode = true;
                    HELI_VIB_PER.Enabled = true;
                    HELI_CHK.Enabled = true;
                }
                else
                {
                    Heli_mode = false;
                    HELI_VIB_PER.Enabled = false;
                    HELI_CHK.Enabled = false;
                    HELI_CHK.Checked = false;
                }
            }
        }

        private void PLANE_LIST_COMBO_TextUpdate(object sender, EventArgs e)
        {
            if (PLANE_LIST_COMBO.Text != null)
            {
                ACC_CHK.Enabled = true;
                PANEL_CHK.Enabled = true;
                AOA_CHK.Enabled = true;
                SPDBREAK_CHK.Enabled = true;
                GEAR_CHK.Enabled = true;
                GUN_CHK.Enabled = true;
                FLARE_CHK.Enabled = true;
                CHAFF_CHK.Enabled = true;
                PAYLOAD_CHK.Enabled = true;

                ACC_VIB_PER.Enabled = true;
                PANEL_VIB_PER.Enabled = true;
                AOA_VIB_PER.Enabled = true;
                SPDBREAK_VIB_PER.Enabled = true;
                GEAR_VIB_PER.Enabled = true;
                GUN_VIB_PER.Enabled = true;
                FLARE_VIB_PER.Enabled = true;
                CHAFF_VIB_PER.Enabled = true;
                PAYLOAD_VIB_PER.Enabled = true;

                AOA_S_COMBO.Enabled = true;
                AOA_M_COMBO.Enabled = true;

                GetPrivateProfileString("DCS_PLANE", PLANE_LIST_COMBO.Text, null, ini_plane_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                LOAD_INI(ini_plane_setup.ToString());

            }
        }


        private void LUA_INSTALL_OPENBETA()
        {
            string DCSPATH = null;
            RegistryKey reg = Registry.CurrentUser;
            reg = reg.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Folders", true);

            if (reg != null)
            {
                Object locvalue = reg.GetValue("{4C5C32FF-BB9D-43b0-B5B4-2D72E54EAAA4}");
                if (null != locvalue)
                {
                    DCSPATH = locvalue.ToString();
                }
                else
                {
                    MessageBox.Show("DCS LUA가 정상적으로 설치되지 않습니다. (Saved Games 찾지 못함)");
                }
            }

            DCSPATH = DCSPATH + "\\DCS.openbeta\\Scripts";


            string PATH = AppContext.BaseDirectory;
            string EXPORT_DATA;
            DirectoryInfo CR_DIR = new DirectoryInfo(DCSPATH + "\\FFBSUPPORT");
            CR_DIR.Create();
            System.IO.File.Copy(PATH + "FFBSUPPORT.lua", DCSPATH + "\\FFBSUPPORT\\FFBSUPPORT.lua", true);

            int CHK = 0;

            if (File.Exists(DCSPATH + "\\Export.lua"))
            {

                foreach (string line in System.IO.File.ReadLines(DCSPATH + "\\Export.lua"))
                {
                    System.Console.WriteLine(line);
                    if (line == "local FFBSlfs=require('lfs'); dofile(FFBSlfs.writedir()..'Scripts/FFBSUPPORT/FFBSUPPORT.lua')")
                    {
                        CHK = 1;
                    }
                }

                if (CHK != 1)
                {
                    EXPORT_DATA = System.IO.File.ReadAllText(DCSPATH + "\\Export.lua");
                    EXPORT_DATA += "\n";
                    EXPORT_DATA += "local FFBSlfs=require('lfs'); dofile(FFBSlfs.writedir()..'Scripts/FFBSUPPORT/FFBSUPPORT.lua')";

                    System.IO.File.WriteAllText(DCSPATH + "\\Export.lua", EXPORT_DATA, new UTF8Encoding(false));
                }
            }
            else
            {
                System.IO.File.WriteAllText(DCSPATH + "\\Export.lua", "local FFBSlfs=require('lfs'); dofile(FFBSlfs.writedir()..'Scripts/FFBSUPPORT/FFBSUPPORT.lua')", Encoding.Default);
            }
        }

        private void LUA_INSTALL()
        {
            string DCSPATH = null;
            RegistryKey reg = Registry.CurrentUser;
            reg = reg.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Folders", true);

            if (reg != null)
            {
                Object locvalue = reg.GetValue("{4C5C32FF-BB9D-43b0-B5B4-2D72E54EAAA4}");
                if (null != locvalue)
                {
                    DCSPATH = locvalue.ToString();
                }
                else
                {
                    MessageBox.Show("DCS LUA가 정상적으로 설치되지 않습니다. (Saved Games 찾지 못함)");
                }
            }

            DCSPATH = DCSPATH + "\\DCS\\Scripts";



            string PATH = AppContext.BaseDirectory;
            string EXPORT_DATA;
            DirectoryInfo CR_DIR = new DirectoryInfo(DCSPATH + "\\FFBSUPPORT");
            CR_DIR.Create();
            System.IO.File.Copy(PATH + "FFBSUPPORT.lua", DCSPATH + "\\FFBSUPPORT\\FFBSUPPORT.lua", true);

            int CHK = 0;

            if (File.Exists(DCSPATH + "\\Export.lua"))
            {

                foreach (string line in System.IO.File.ReadLines(DCSPATH + "\\Export.lua"))
                {
                    System.Console.WriteLine(line);
                    if (line == "local FFBSlfs=require('lfs'); dofile(FFBSlfs.writedir()..'Scripts/FFBSUPPORT/FFBSUPPORT.lua')")
                    {
                        CHK = 1;
                    }
                }

                if (CHK != 1)
                {
                    EXPORT_DATA = System.IO.File.ReadAllText(DCSPATH + "\\Export.lua");
                    EXPORT_DATA += "\n";
                    EXPORT_DATA += "local FFBSlfs=require('lfs'); dofile(FFBSlfs.writedir()..'Scripts/FFBSUPPORT/FFBSUPPORT.lua')";

                    System.IO.File.WriteAllText(DCSPATH + "\\Export.lua", EXPORT_DATA, new UTF8Encoding(false));
                }
            }
            else
            {
                System.IO.File.WriteAllText(DCSPATH + "\\Export.lua", "local FFBSlfs=require('lfs'); dofile(FFBSlfs.writedir()..'Scripts/FFBSUPPORT/FFBSUPPORT.lua')", Encoding.Default);
            }
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // WARTHUNDER 전용 작업
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        // 워썬더 데이터 추출 쓰레드
        Thread WARTHUNDER_GET_THREAD;
        ThreadStart WARTHUNDER_GET_THREAD_START;
        bool ACTIVE_WARTHUNDER_GET_THREAD;

        // 워썬더 가속도 추출 쓰레드
        Thread WARTHUNDER_ACCS_THREAD;
        ThreadStart WARTHUNDER_ACCS_THREAD_START;
        bool ACTIVE_WARTHUNDER_ACCS_THREAD;

        // 워썬더 AOA 추출 쓰레드
        Thread WARTHUNDER_AOA_THREAD;
        ThreadStart WARTHUNDER_AOA_THREAD_START;
        bool ACTIVE_WARTHUNDER_AOA_THREAD;

        // 워썬더 기어/플랩 추출 쓰레드
        Thread WARTHUNDER_GEAR_THREAD;
        ThreadStart WARTHUNDER_GEAR_THREAD_START;
        bool ACTIVE_WARTHUNDER_GEAR_THREAD;

        // 워썬더 기어/플랩 추출 쓰레드
        Thread WARTHUNDER_FLAP_BREAK_THREAD;
        ThreadStart WARTHUNDER_FLAP_BREAK_THREAD_START;
        bool ACTIVE_WARTHUNDER_FLAP_BREAK_THREAD;

        // 워썬더 무장발사 추출 쓰레드
        Thread WARTHUNDER_GUN_THREAD;
        ThreadStart WARTHUNDER_GUN_THREAD_START;
        bool ACTIVE_WARTHUNDER_GUN_THREAD;

        // 워썬더 무장발사 추출 쓰레드
        Thread WARTHUNDER_WEP_THREAD;
        ThreadStart WARTHUNDER_WEP_THREAD_START;
        bool ACTIVE_WARTHUNDER_WEP_THREAD;

        private void Connect_WT_Click(object sender, EventArgs e)
        {
            if (Connect_WT.Text == "Connect")
            {
                try
                {
                    string[] port_list = comboPorts.Text.Split('-');
                    serialPort1.PortName = port_list[0];

                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                        serialPort1.WriteLine("L");
                        if (Power_Check.Checked)
                        {
                            serialPort1.WriteLine("E");
                        }
                        else
                        {
                            serialPort1.WriteLine("R");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("아두이노가 연결되지 않았습니다.");
                    return;
                }

                // 워썬더 데이터 추출 
                WARTHUNDER_GET_THREAD_START = new ThreadStart(GET_WARTHUNDER_DATA);
                WARTHUNDER_GET_THREAD = new Thread(WARTHUNDER_GET_THREAD_START);
                ACTIVE_WARTHUNDER_GET_THREAD = true;
                WARTHUNDER_GET_THREAD.Start();

                // 워썬더 가속도 추출 
                WARTHUNDER_ACCS_THREAD_START = new ThreadStart(WT_GET_ACCS_VIBRATION);
                WARTHUNDER_ACCS_THREAD = new Thread(WARTHUNDER_ACCS_THREAD_START);
                ACTIVE_WARTHUNDER_ACCS_THREAD = true;
                WARTHUNDER_ACCS_THREAD.Start();

                // 워썬더 AOA 추출 
                WARTHUNDER_AOA_THREAD_START = new ThreadStart(WT_GET_AOA_VIBRATION);
                WARTHUNDER_AOA_THREAD = new Thread(WARTHUNDER_AOA_THREAD_START);
                ACTIVE_WARTHUNDER_AOA_THREAD = true;
                WARTHUNDER_AOA_THREAD.Start();

                // 워썬더 기어 추출 
                WARTHUNDER_GEAR_THREAD_START = new ThreadStart(WT_GET_GEAR_VIBRATION);
                WARTHUNDER_GEAR_THREAD = new Thread(WARTHUNDER_GEAR_THREAD_START);
                ACTIVE_WARTHUNDER_GEAR_THREAD = true;
                WARTHUNDER_GEAR_THREAD.Start();

                // 워썬더 플랩/브레이크 추출 
                WARTHUNDER_FLAP_BREAK_THREAD_START = new ThreadStart(WT_FLAP_BREAK_VIBRATION);
                WARTHUNDER_FLAP_BREAK_THREAD = new Thread(WARTHUNDER_FLAP_BREAK_THREAD_START);
                ACTIVE_WARTHUNDER_FLAP_BREAK_THREAD = true;
                WARTHUNDER_FLAP_BREAK_THREAD.Start();

                // 무장발사 추출 
                WARTHUNDER_GUN_THREAD_START = new ThreadStart(WT_GUN_VIBRATION);
                WARTHUNDER_GUN_THREAD = new Thread(WARTHUNDER_GUN_THREAD_START);
                ACTIVE_WARTHUNDER_GUN_THREAD = true;
                WARTHUNDER_GUN_THREAD.Start();

                // WEP / BUNNER 추출 
                WARTHUNDER_WEP_THREAD_START = new ThreadStart(WT_WEP_VIBRATION);
                WARTHUNDER_WEP_THREAD = new Thread(WARTHUNDER_WEP_THREAD_START);
                ACTIVE_WARTHUNDER_WEP_THREAD = true;
                WARTHUNDER_WEP_THREAD.Start();

                vib_timer2.Start();
                PLANE_LIST_COMBO_WT.Enabled = false;
                Connect_WT.Text = "Disconnect";
            }
            else
            {
                ACTIVE_WARTHUNDER_GET_THREAD = false;
                ACTIVE_WARTHUNDER_ACCS_THREAD = false;
                ACTIVE_WARTHUNDER_AOA_THREAD = false;
                ACTIVE_WARTHUNDER_GEAR_THREAD = false;
                ACTIVE_WARTHUNDER_FLAP_BREAK_THREAD = false;
                ACTIVE_WARTHUNDER_GUN_THREAD = false;
                ACTIVE_WARTHUNDER_WEP_THREAD = false;


                Connect_WT.Text = "Connect";
                WT_AOS_VIB_OUT.Text = "0";
                WT_NY_VIB_OUT.Text = "0";
                WT_WX_VIB_OUT.Text = "0";
                WT_AOA_VIB_OUT.Text = "0";
                WT_FLAP_VIB_OUT.Text = "0";
                WT_GEAR_VIB_OUT.Text = "0";
                WT_AIRBREAK_VIB_OUT.Text = "0";
                WT_GUN_VIB_OUT.Text = "0";
                WT_WEP_VIB_OUT.Text = "0";

                serialPort1.WriteLine("V0");
                serialPort1.Close();
                vib_timer2.Stop();
                PLANE_LIST_COMBO_WT.Enabled = true;
            }

        }

        private void GET_WARTHUNDER_DATA()
        {
            while (ACTIVE_WARTHUNDER_GET_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    try
                    {

                        string indi_uri = "http://127.0.0.1:8111/indicators";
                        string stat_uri = "http://127.0.0.1:8111/state";
                        WebClient webClient = new WebClient();
                        Stream stream = webClient.OpenRead(indi_uri);
                        string INDI_JSON = new StreamReader(stream).ReadToEnd();

                        stream = webClient.OpenRead(stat_uri);
                        string STAT_JSON = new StreamReader(stream).ReadToEnd();

                        JObject indi = JObject.Parse(INDI_JSON);
                        JObject stat = JObject.Parse(STAT_JSON);

                        string aa = indi["valid"].ToString();

                        if (indi["valid"].ToString() == "True" && stat["valid"].ToString() == "True")
                        {

                            if (indi.ContainsKey("type") && WT_PLANE_NAME.Text != indi["type"].ToString())
                            {
                                PLANE_LIST_COMBO_WT.Enabled = false;
                                WT_PLANE_NAME.Text = indi["type"].ToString();
                                PLANE_LIST_COMBO_WT.Text = indi["type"].ToString();

                                GetPrivateProfileString("WARTHUNDER_PLANE", WT_PLANE_NAME.Text, null, ini_plane_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");

                                if (ini_plane_setup.Length == 0)
                                {
                                    WritePrivateProfileString("WARTHUNDER_PLANE", WT_PLANE_NAME.Text, "13,25,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,1,1", System.IO.Path.GetDirectoryName(path) + "\\Setup.ini"); ;
                                    GetPrivateProfileString("WARTHUNDER_PLANE", WT_PLANE_NAME.Text, null, ini_plane_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                                    LOAD_INI_WT(ini_plane_setup.ToString());
                                    WT_AOS_CHK.Enabled = true;
                                    WT_AOS_VIB_PER.Enabled = true;
                                    WT_NY_CHK.Enabled = true;
                                    WT_NY_VIB_PER.Enabled = true;
                                    WT_WX_CHK.Enabled = true;
                                    WT_WX_VIB_PER.Enabled = true;
                                    WT_AOA_CHK.Enabled = true;
                                    WT_AOA_VIB_PER.Enabled = true;
                                    WT_FLAP_CHK.Enabled = true;
                                    WT_FLAP_VIB_PER.Enabled = true;
                                    WT_GEAR_CHK.Enabled = true;
                                    WT_GEAR_VIB_PER.Enabled = true;
                                    WT_AIRBREAK_CHK.Enabled = true;
                                    WT_AIRBREAK_VIB_PER.Enabled = true;
                                    WT_GUN_CHK.Enabled = true;
                                    WT_GUN_VIB_PER.Enabled = true;
                                    WT_WEP_CHK.Enabled = true;
                                    WT_WEP_VIB_PER.Enabled = true;
                                    WT_AOA_S_COMBO.Enabled = true;
                                    WT_AOA_M_COMBO.Enabled = true;
                                    WT_AOS_VIB_MIN.Enabled = true;
                                    WT_NY_VIB_MIN.Enabled = true;
                                    WT_WX_VIB_MIN.Enabled = true;

                                }
                                else
                                {
                                    LOAD_INI_WT(ini_plane_setup.ToString());
                                }
                                plane_list_update_wt();
                            }


                            if (indi.ContainsKey("weapon1")) WT_WEAPON1.Text = indi["weapon1"].ToString();
                            if (indi.ContainsKey("weapon2")) WT_WEAPON2.Text = indi["weapon2"].ToString();
                            if (indi.ContainsKey("weapon3")) WT_WEAPON3.Text = indi["weapon3"].ToString();

                            if (stat.ContainsKey("IAS, km/h")) WT_IAS.Text = stat["IAS, km/h"].ToString();
                            if (stat.ContainsKey("TAS, km/h")) WT_TAS.Text = stat["TAS, km/h"].ToString();
                            if (stat.ContainsKey("AoS")) WT_TAS.Text = stat["AoS"].ToString();
                            if (stat.ContainsKey("AoA, deg")) WT_AOA.Text = stat["AoA, deg"].ToString();
                            if (stat.ContainsKey("AoS, deg")) WT_AOS.Text = stat["AoS, deg"].ToString();
                            if (stat.ContainsKey("Ny")) WT_NY.Text = stat["Ny"].ToString();
                            if (stat.ContainsKey("Wx, deg/s")) WT_WX.Text = stat["Wx, deg/s"].ToString();
                            if (stat.ContainsKey("gear, %")) WT_GEAR.Text = stat["gear, %"].ToString();
                            if (stat.ContainsKey("flaps, %")) WT_FLAP.Text = stat["flaps, %"].ToString();
                            if (stat.ContainsKey("airbrake, %")) WT_AIRBREAK.Text = stat["airbrake, %"].ToString();
                            if (stat.ContainsKey("throttle 1, %")) WT_THROTTLE1.Text = stat["throttle 1, %"].ToString();
                            if (stat.ContainsKey("throttle 2, %")) WT_THROTTLE2.Text = stat["throttle 2, %"].ToString();
                        }
                        else
                        {
                            WT_PLANE_NAME.Text = "-";
                            WT_WEAPON1.Text = "0";
                            WT_WEAPON2.Text = "0";
                            WT_WEAPON3.Text = "0";
                            WT_GEAR.Text = "0";
                            WT_FLAP.Text = "0";
                            WT_AIRBREAK.Text = "0";
                            WT_IAS.Text = "0";
                            WT_TAS.Text = "0";
                            WT_AOA.Text = "0";
                            WT_AOS.Text = "0";
                            WT_NY.Text = "0";
                            WT_THROTTLE1.Text = "0";
                            WT_THROTTLE2.Text = "0";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("워썬더가 실행중이지 않습니다.");
                        ACTIVE_WARTHUNDER_GET_THREAD = false;
                        ACTIVE_WARTHUNDER_ACCS_THREAD = false;
                        ACTIVE_WARTHUNDER_AOA_THREAD = false;
                        ACTIVE_WARTHUNDER_GEAR_THREAD = false;
                        ACTIVE_WARTHUNDER_FLAP_BREAK_THREAD = false;
                        ACTIVE_WARTHUNDER_GUN_THREAD = false;
                        ACTIVE_WARTHUNDER_WEP_THREAD = false;
                        PLANE_LIST_COMBO_WT.Enabled = true;

                        Connect_WT.Text = "Connect";
                        WT_AOS_VIB_OUT.Text = "0";
                        WT_NY_VIB_OUT.Text = "0";
                        WT_WX_VIB_OUT.Text = "0";
                        WT_AOA_VIB_OUT.Text = "0";
                        WT_FLAP_VIB_OUT.Text = "0";
                        WT_GEAR_VIB_OUT.Text = "0";
                        WT_AIRBREAK_VIB_OUT.Text = "0";
                        WT_GUN_VIB_OUT.Text = "0";
                        WT_WEP_VIB_OUT.Text = "0";
                        vib_timer2.Stop();

                        if (serialPort1.IsOpen)
                        {

                            serialPort1.WriteLine("V0");
                            serialPort1.Close();
                        }
                        return;
                    }

                }));
                Thread.Sleep(20);
            }
        }


        private void WT_GET_ACCS_VIBRATION()
        {
            double before_accs_x = 0;
            double before_accs_y = 0;
            double before_accs_z = 0;
            double[] vib = new double[3];


            while (ACTIVE_WARTHUNDER_ACCS_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double x_vib = before_accs_x - double.Parse(WT_AOS.Text);
                    double y_vib = before_accs_y - double.Parse(WT_NY.Text);
                    double z_vib = before_accs_z - double.Parse(WT_WX.Text);

                    if (x_vib < 0) x_vib = x_vib * -1;
                    if (y_vib < 0) y_vib = y_vib * -1;
                    if (z_vib < 0) z_vib = z_vib * -1;

                    x_vib = x_vib * 15;
                    y_vib = y_vib * 45;
                    z_vib = z_vib * 15;

                    x_vib = Math.Round(x_vib, 0);
                    y_vib = Math.Round(y_vib, 0);
                    z_vib = Math.Round(z_vib, 0);

                    before_accs_x = double.Parse(WT_AOS.Text);
                    before_accs_y = double.Parse(WT_NY.Text);
                    before_accs_z = double.Parse(WT_WX.Text);

                    WT_AOS_VIB.Text = x_vib.ToString();
                    WT_NY_VIB.Text = y_vib.ToString();
                    WT_WX_VIB.Text = z_vib.ToString();
                }));
                Thread.Sleep(100);
            }
        }

        private void WT_GET_AOA_VIBRATION()
        {
            while (ACTIVE_WARTHUNDER_AOA_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double AOA_MIN = double.Parse(WT_AOA_S_COMBO.Text);
                    double AOA_MAX = double.Parse(WT_AOA_M_COMBO.Text);
                    double VIB = 0;

                    if (double.Parse(WT_AOA.Text) > AOA_MIN && double.Parse(WT_IAS.Text) > 50)
                    {
                        VIB = (((double.Parse(WT_AOA.Text) - AOA_MIN) / (AOA_MAX - AOA_MIN)) * 255);
                        WT_AOA_VIB.Text = VIB.ToString();

                    }
                    else
                    {
                        WT_AOA_VIB.Text = "0";
                    }
                }));
                Thread.Sleep(100);
            }
        }

        private void WT_GET_GEAR_VIBRATION()
        {
            string BEFORE_GEAR = "0";
            while (ACTIVE_WARTHUNDER_GEAR_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    if (BEFORE_GEAR != WT_GEAR.Text)
                    {
                        WT_GEAR_VIB.Text = "80";
                    }
                    else
                    {
                        WT_GEAR_VIB.Text = "0";
                    }
                    BEFORE_GEAR = WT_GEAR.Text;
                }));

                Thread.Sleep(100);
            }
        }

        private void WT_FLAP_BREAK_VIBRATION()
        {
            while (ACTIVE_WARTHUNDER_FLAP_BREAK_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double IAS_DATA = 0;
                    double VIB_PER = 0;

                    IAS_DATA = double.Parse(WT_IAS.Text);
                    if (double.Parse(WT_IAS.Text) > 150) IAS_DATA = 150;
                    if (double.Parse(WT_IAS.Text) < 50) IAS_DATA = 50;

                    VIB_PER = (IAS_DATA - 50) / 100;


                    if (double.Parse(WT_AIRBREAK.Text) > 0)
                    {
                        double VIB = (255 * double.Parse(WT_AIRBREAK.Text) / 100) * VIB_PER;

                        int VIB_INT = Convert.ToInt32(VIB);

                        WT_AIRBREAK_VIB.Text = VIB_INT.ToString();

                    }
                    else
                    {
                        WT_AIRBREAK_VIB.Text = "0";
                    }


                    if (double.Parse(WT_FLAP.Text) > 0)
                    {
                        double VIB = (255 * double.Parse(WT_FLAP.Text) / 100) * VIB_PER;

                        int VIB_INT = Convert.ToInt32(VIB);

                        WT_FLAP_VIB.Text = VIB_INT.ToString();

                    }
                    else
                    {
                        WT_FLAP_VIB.Text = "0";
                    }
                }));
                Thread.Sleep(100);
            }

        }

        private void WT_GUN_VIBRATION()
        {
            while (ACTIVE_WARTHUNDER_GUN_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (WT_WEAPON1.Text == "1" || WT_WEAPON2.Text == "1" || WT_WEAPON3.Text == "1")
                    {
                        WT_GUN_VIB.Text = "200";
                    }
                    else
                    {
                        WT_GUN_VIB.Text = "0";
                    }
                }));
                Thread.Sleep(100);
            }
        }

        private void WT_WEP_VIBRATION()
        {
            while (ACTIVE_WARTHUNDER_WEP_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double WEP1 = 0;
                    double WEP2 = 0;
                    double WEP_LAST = 0;

                    if (double.Parse(WT_THROTTLE1.Text) > 100) WEP1 = double.Parse(WT_THROTTLE1.Text);
                    if (double.Parse(WT_THROTTLE2.Text) > 100) WEP2 = double.Parse(WT_THROTTLE1.Text);

                    if (WEP1 > 0 || WEP2 > 0)
                    {
                        WEP_LAST = WEP1;
                        if (WEP1 < WEP2) WEP_LAST = WEP2;

                        double VIB = 128 * ((WEP_LAST - 100) / 10);

                        WT_WEP_VIB.Text = VIB.ToString();
                    }
                    else
                    {
                        WT_WEP_VIB.Text = "0";
                    }

                }));
                Thread.Sleep(100);
            }
        }

        private void vib_timer2_Tick(object sender, EventArgs e)
        {
            double[] VIBRATION = new double[9];

            // 255 이상은 의미 없기때문에 고정함
            if (double.Parse(WT_AOS_VIB.Text) * (double.Parse(WT_AOS_VIB_PER.Text) / 100) > 255)
            {
                WT_AOS_VIB_OUT.Text = "255";
            }
            else
            {
                if (double.Parse(WT_AOS_VIB.Text) > double.Parse(WT_AOS_VIB_MIN.Text))
                {
                    WT_AOS_VIB_OUT.Text = (double.Parse(WT_AOS_VIB.Text) * (double.Parse(WT_AOS_VIB_PER.Text) / 100)).ToString();
                }
                else
                {
                    WT_AOS_VIB_OUT.Text = "0";
                }
            }

            if ((double.Parse(WT_NY_VIB.Text) * (double.Parse(WT_NY_VIB_PER.Text) / 100)) > 255)
            {
                WT_NY_VIB_OUT.Text = "255";
            }
            else
            {
                if (double.Parse(WT_NY_VIB.Text) > double.Parse(WT_NY_VIB_MIN.Text))
                {
                    WT_NY_VIB_OUT.Text = (double.Parse(WT_NY_VIB.Text) * (double.Parse(WT_NY_VIB_PER.Text) / 100)).ToString();
                }
                else
                {
                    WT_NY_VIB_OUT.Text = "0";
                }
            }

            if ((double.Parse(WT_WX_VIB.Text) * (double.Parse(WT_WX_VIB_PER.Text) / 100)) > 255)
            {
                WT_WX_VIB_OUT.Text = "255";
            }
            else
            {
                if (double.Parse(WT_WX_VIB.Text) > double.Parse(WT_WX_VIB_MIN.Text))
                {
                    WT_WX_VIB_OUT.Text = (double.Parse(WT_WX_VIB.Text) * (double.Parse(WT_WX_VIB_PER.Text) / 100)).ToString();
                }
                else
                {
                    WT_WX_VIB_OUT.Text = "0";
                }
            }

            if ((double.Parse(WT_AOA_VIB.Text) * (double.Parse(WT_AOA_VIB_PER.Text) / 100)) > 255)
            {
                WT_AOA_VIB_OUT.Text = "255";
            }
            else
            {
                WT_AOA_VIB_OUT.Text = (double.Parse(WT_AOA_VIB.Text) * (double.Parse(WT_AOA_VIB_PER.Text) / 100)).ToString();
            }

            if ((double.Parse(WT_FLAP_VIB.Text) * (double.Parse(WT_FLAP_VIB_PER.Text) / 100)) > 255)
            {
                WT_FLAP_VIB_OUT.Text = "255";
            }
            else
            {
                WT_FLAP_VIB_OUT.Text = (double.Parse(WT_FLAP_VIB.Text) * (double.Parse(WT_FLAP_VIB_PER.Text) / 100)).ToString();
            }


            if ((double.Parse(WT_GEAR_VIB.Text) * (double.Parse(WT_GEAR_VIB_PER.Text) / 100)) > 255)
            {
                WT_GEAR_VIB_OUT.Text = "255";
            }
            else
            {
                WT_GEAR_VIB_OUT.Text = (double.Parse(WT_GEAR_VIB.Text) * (double.Parse(WT_GEAR_VIB_PER.Text) / 100)).ToString();
            }

            if ((double.Parse(WT_AIRBREAK_VIB.Text) * (double.Parse(WT_AIRBREAK_VIB_PER.Text) / 100)) > 255)
            {
                WT_AIRBREAK_VIB_OUT.Text = "255";
            }
            else
            {
                WT_AIRBREAK_VIB_OUT.Text = (double.Parse(WT_AIRBREAK_VIB.Text) * (double.Parse(WT_AIRBREAK_VIB_PER.Text) / 100)).ToString();
            }

            if ((double.Parse(WT_GUN_VIB.Text) * (double.Parse(WT_GUN_VIB_PER.Text) / 100)) > 255)
            {
                WT_GUN_VIB_OUT.Text = "255";
            }
            else
            {
                WT_GUN_VIB_OUT.Text = (double.Parse(WT_GUN_VIB.Text) * (double.Parse(WT_GUN_VIB_PER.Text) / 100)).ToString();
            }

            if ((double.Parse(WT_WEP_VIB.Text) * (double.Parse(WT_WEP_VIB_PER.Text) / 100)) > 255)
            {
                WT_WEP_VIB_OUT.Text = "255";
            }
            else
            {
                WT_WEP_VIB_OUT.Text = (double.Parse(WT_WEP_VIB.Text) * (double.Parse(WT_WEP_VIB_PER.Text) / 100)).ToString();
            }

            if (WT_AOS_CHK.Checked == true) VIBRATION[0] = double.Parse(WT_AOS_VIB_OUT.Text); else VIBRATION[0] = 0;
            if (WT_NY_CHK.Checked == true) VIBRATION[1] = double.Parse(WT_NY_VIB_OUT.Text); else VIBRATION[1] = 0;
            if (WT_WX_CHK.Checked == true) VIBRATION[2] = double.Parse(WT_WX_VIB_OUT.Text); else VIBRATION[2] = 0;
            if (WT_AOA_CHK.Checked == true) VIBRATION[3] = double.Parse(WT_AOA_VIB_OUT.Text); else VIBRATION[3] = 0;
            if (WT_FLAP_CHK.Checked == true) VIBRATION[4] = double.Parse(WT_FLAP_VIB_OUT.Text); else VIBRATION[4] = 0;
            if (WT_GEAR_CHK.Checked == true) VIBRATION[5] = double.Parse(WT_GEAR_VIB_OUT.Text); else VIBRATION[5] = 0;
            if (WT_AIRBREAK_CHK.Checked == true) VIBRATION[6] = double.Parse(WT_AIRBREAK_VIB_OUT.Text); else VIBRATION[6] = 0;
            if (WT_GUN_CHK.Checked == true) VIBRATION[7] = double.Parse(WT_GUN_VIB_OUT.Text); else VIBRATION[7] = 0;
            if (WT_WEP_CHK.Checked == true) VIBRATION[8] = double.Parse(WT_WEP_VIB_OUT.Text); else VIBRATION[8] = 0;


            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("V" + VIBRATION.Max().ToString());
                WT_VIB_OUT.Text = VIBRATION.Max().ToString();
            }
        }

        private void plane_list_update_wt()
        {
            EXTERN.GET_PLANE EXT = new EXTERN.GET_PLANE();

            byte[] PLANE_BYES = EXT.get_plane_list_wt();
            string PLANE_RAW_LIST = Encoding.ASCII.GetString(PLANE_BYES, 0, 32767);
            PLANE_RAW_LIST = Encoding.ASCII.GetString(PLANE_BYES, 0, 32767);
            string[] PLANE_LIST = PLANE_RAW_LIST.Split('\0');

            PLANE_LIST_COMBO_WT.Items.Clear();

            for (int i = 0; i < PLANE_LIST.Length; i++)
            {
                if (PLANE_LIST[i] != "") PLANE_LIST_COMBO_WT.Items.Add(PLANE_LIST[i]);
            }

        }



        private void LOAD_INI_WT(string INI_DATA)
        {
            string[] ini_data = INI_DATA.Split(',');
            WT_AOA_S_COMBO.Text = ini_data[0];
            WT_AOA_M_COMBO.Text = ini_data[1];

            if (ini_data[2] == "1") WT_AOS_CHK.Checked = true; else WT_AOS_CHK.Checked = false;
            WT_AOS_VIB_PER.Text = ini_data[3];
            if (ini_data[4] == "1") WT_NY_CHK.Checked = true; else WT_NY_CHK.Checked = false;
            WT_NY_VIB_PER.Text = ini_data[5];
            if (ini_data[6] == "1") WT_WX_CHK.Checked = true; else WT_WX_CHK.Checked = false;
            WT_WX_VIB_PER.Text = ini_data[7];
            if (ini_data[8] == "1") WT_AOA_CHK.Checked = true; else WT_AOA_CHK.Checked = false;
            WT_AOA_VIB_PER.Text = ini_data[9];
            if (ini_data[10] == "1") WT_FLAP_CHK.Checked = true; else WT_FLAP_CHK.Checked = false;
            WT_FLAP_VIB_PER.Text = ini_data[11];
            if (ini_data[12] == "1") WT_GEAR_CHK.Checked = true; else WT_GEAR_CHK.Checked = false;
            WT_GEAR_VIB_PER.Text = ini_data[13];
            if (ini_data[14] == "1") WT_AIRBREAK_CHK.Checked = true; else WT_AIRBREAK_CHK.Checked = false;
            WT_AIRBREAK_VIB_PER.Text = ini_data[15];
            if (ini_data[16] == "1") WT_GUN_CHK.Checked = true; else WT_GUN_CHK.Checked = false;
            WT_GUN_VIB_PER.Text = ini_data[17];
            if (ini_data[18] == "1") WT_WEP_CHK.Checked = true; else WT_WEP_CHK.Checked = false;
            WT_WEP_VIB_PER.Text = ini_data[19];
            WT_AOS_VIB_MIN.Text = ini_data[20];
            WT_NY_VIB_MIN.Text = ini_data[21];
            WT_WX_VIB_MIN.Text = ini_data[22];

        }
        private void SAVE_INI_WT()
        {
            string ini_data = null;

            ini_data += WT_AOA_S_COMBO.Text + "," + WT_AOA_M_COMBO.Text + ",";

            if (WT_AOS_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += WT_AOS_VIB_PER.Text + ",";
            if (WT_NY_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += WT_NY_VIB_PER.Text + ",";
            if (WT_WX_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += WT_WX_VIB_PER.Text + ",";
            if (WT_AOA_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += WT_AOA_VIB_PER.Text + ",";
            if (WT_FLAP_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += WT_FLAP_VIB_PER.Text + ",";
            if (WT_GEAR_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += WT_GEAR_VIB_PER.Text + ",";
            if (WT_AIRBREAK_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += WT_AIRBREAK_VIB_PER.Text + ",";
            if (WT_GUN_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += WT_GUN_VIB_PER.Text + ",";
            if (WT_WEP_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += WT_WEP_VIB_PER.Text + ",";
            ini_data += WT_AOS_VIB_MIN.Text + ",";
            ini_data += WT_NY_VIB_MIN.Text + ",";
            ini_data += WT_WX_VIB_MIN.Text;

            WritePrivateProfileString("WARTHUNDER_PLANE", PLANE_LIST_COMBO_WT.Text, ini_data, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
        }

        private void WT_AOS_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_NY_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_WX_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_AOA_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_FLAP_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_GEAR_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_AIRBREAK_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_GUN_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_WEP_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_AOS_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_NY_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_WX_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_AOA_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_FLAP_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_GEAR_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_AIRBREAK_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_GUN_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_WEP_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_AOA_S_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_AOA_M_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_AOS_VIB_MIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_NY_VIB_MIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void WT_WX_VIB_MIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_WT();
        }

        private void DEFAULT_SETUP_WT_Click(object sender, EventArgs e)
        {
            WT_AOS_CHK.Checked = true;
            WT_NY_CHK.Checked = true;
            WT_WX_CHK.Checked = true;
            WT_AOA_CHK.Checked = true;
            WT_FLAP_CHK.Checked = true;
            WT_GEAR_CHK.Checked = true;
            WT_AIRBREAK_CHK.Checked = true;
            WT_GUN_CHK.Checked = true;
            WT_WEP_CHK.Checked = true;

            WT_AOS_VIB_PER.Text = "100";
            WT_NY_VIB_PER.Text = "100";
            WT_WX_VIB_PER.Text = "100";
            WT_AOA_VIB_PER.Text = "100";
            WT_FLAP_VIB_PER.Text = "100";
            WT_GEAR_VIB_PER.Text = "100";
            WT_AIRBREAK_VIB_PER.Text = "100";
            WT_GUN_VIB_PER.Text = "100";
            WT_WEP_VIB_PER.Text = "100";

            WT_AOA_S_COMBO.Text = "13";
            WT_AOA_M_COMBO.Text = "25";

            WT_AOS_VIB_MIN.Text = "1";
            WT_NY_VIB_MIN.Text = "1";
            WT_WX_VIB_MIN.Text = "1";
        }

        private void PLANE_LIST_COMBO_WT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PLANE_LIST_COMBO_WT.Text != null)
            {
                WT_AOS_CHK.Enabled = true;
                WT_AOS_VIB_PER.Enabled = true;
                WT_NY_CHK.Enabled = true;
                WT_NY_VIB_PER.Enabled = true;
                WT_WX_CHK.Enabled = true;
                WT_WX_VIB_PER.Enabled = true;
                WT_AOA_CHK.Enabled = true;
                WT_AOA_VIB_PER.Enabled = true;
                WT_FLAP_CHK.Enabled = true;
                WT_FLAP_VIB_PER.Enabled = true;
                WT_GEAR_CHK.Enabled = true;
                WT_GEAR_VIB_PER.Enabled = true;
                WT_AIRBREAK_CHK.Enabled = true;
                WT_AIRBREAK_VIB_PER.Enabled = true;
                WT_GUN_CHK.Enabled = true;
                WT_GUN_VIB_PER.Enabled = true;
                WT_WEP_CHK.Enabled = true;
                WT_WEP_VIB_PER.Enabled = true;
                WT_AOA_S_COMBO.Enabled = true;
                WT_AOA_M_COMBO.Enabled = true;
                WT_AOS_VIB_MIN.Enabled = true;
                WT_NY_VIB_MIN.Enabled = true;
                WT_WX_VIB_MIN.Enabled = true;
                GetPrivateProfileString("WARTHUNDER_PLANE", PLANE_LIST_COMBO_WT.Text, null, ini_plane_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                LOAD_INI_WT(ini_plane_setup.ToString());
            }
        }

        private void PLANE_LIST_COMBO_WT_TextUpdate(object sender, EventArgs e)
        {
            if (PLANE_LIST_COMBO_WT.Text != null)
            {
                WT_AOS_CHK.Enabled = true;
                WT_AOS_VIB_PER.Enabled = true;
                WT_NY_CHK.Enabled = true;
                WT_NY_VIB_PER.Enabled = true;
                WT_WX_CHK.Enabled = true;
                WT_WX_VIB_PER.Enabled = true;
                WT_AOA_CHK.Enabled = true;
                WT_AOA_VIB_PER.Enabled = true;
                WT_FLAP_CHK.Enabled = true;
                WT_FLAP_VIB_PER.Enabled = true;
                WT_GEAR_CHK.Enabled = true;
                WT_GEAR_VIB_PER.Enabled = true;
                WT_AIRBREAK_CHK.Enabled = true;
                WT_AIRBREAK_VIB_PER.Enabled = true;
                WT_GUN_CHK.Enabled = true;
                WT_GUN_VIB_PER.Enabled = true;
                WT_WEP_CHK.Enabled = true;
                WT_WEP_VIB_PER.Enabled = true;
                WT_AOA_S_COMBO.Enabled = true;
                WT_AOA_M_COMBO.Enabled = true;
                WT_AOS_VIB_MIN.Enabled = true;
                WT_NY_VIB_MIN.Enabled = true;
                WT_WX_VIB_MIN.Enabled = true;
                GetPrivateProfileString("WARTHUNDER_PLANE", PLANE_LIST_COMBO_WT.Text, null, ini_plane_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                LOAD_INI_WT(ini_plane_setup.ToString());
            }
        }











        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // FALCON BMS 전용 작업
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // FALCON 가속도 추출 쓰레드
        Thread FALCON_ACCS_THREAD;
        ThreadStart FALCON_ACCS_THREAD_START;
        bool ACTIVE_FALCON_ACCS_THREAD;

        // FALCON AOA 추출 쓰레드
        Thread FALCON_AOA_THREAD;
        ThreadStart FALCON_AOA_THREAD_START;
        bool ACTIVE_FALCON_AOA_THREAD;

        // FALCON GUN 추출 쓰레드
        Thread FALCON_GUN_THREAD;
        ThreadStart FALCON_GUN_THREAD_START;
        bool ACTIVE_FALCON_GUN_THREAD;

        // FALCON PAYLOAD 추출 쓰레드
        Thread FALCON_PAYLOAD_THREAD;
        ThreadStart FALCON_PAYLOAD_THREAD_START;
        bool ACTIVE_FALCON_PAYLOAD_THREAD;

        // FALCON GEAR 추출 쓰레드
        Thread FALCON_GEAR_THREAD;
        ThreadStart FALCON_GEAR_THREAD_START;
        bool ACTIVE_FALCON_GEAR_THREAD;

        // FALCON BUNNER 추출 쓰레드
        Thread FALCON_BUNNER_THREAD;
        ThreadStart FALCON_BUNNER_THREAD_START;
        bool ACTIVE_FALCON_BUNNER_THREAD;

        // FALCON AIRBREAK 추출 쓰레드
        Thread FALCON_AIRBREAK_THREAD;
        ThreadStart FALCON_AIRBREAK_THREAD_START;
        bool ACTIVE_FALCON_AIRBREAK_THREAD;

        // FALCON CHAFF/FLARE 추출 쓰레드
        Thread FALCON_CHFL_THREAD;
        ThreadStart FALCON_CHFL_THREAD_START;
        bool ACTIVE_FALCON_CHFL_THREAD;

        // FALCON DAMAGE 추출 쓰레드
        Thread FALCON_DAMAGE_THREAD;
        ThreadStart FALCON_DAMAGE_THREAD_START;
        bool ACTIVE_FALCON_DAMAGE_THREAD;

        public StringBuilder ini_falcon_setup = new StringBuilder();

        private void Connect_FALCON_Click(object sender, EventArgs e)
        {
            if (Connect_FALCON.Text == "Connect")
            {
                try
                {
                    string[] port_list = comboPorts.Text.Split('-');
                    serialPort1.PortName = port_list[0];

                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                        serialPort1.WriteLine("L");
                        if (Power_Check.Checked)
                        {
                            serialPort1.WriteLine("E");
                        }
                        else
                        {
                            serialPort1.WriteLine("R");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("아두이노가 연결되지 않았습니다.");
                    return;
                }

                FALCON_ACCS_THREAD_START = new ThreadStart(FALCON_GET_ACCS_VIBRATION);
                FALCON_ACCS_THREAD = new Thread(FALCON_ACCS_THREAD_START);
                ACTIVE_FALCON_ACCS_THREAD = true;
                FALCON_ACCS_THREAD.Start();

                FALCON_AOA_THREAD_START = new ThreadStart(FALCON_GET_AOA_VIBRATION);
                FALCON_AOA_THREAD = new Thread(FALCON_AOA_THREAD_START);
                ACTIVE_FALCON_AOA_THREAD = true;
                FALCON_AOA_THREAD.Start();

                FALCON_GUN_THREAD_START = new ThreadStart(FALCON_GET_GUN_VIBRATION);
                FALCON_GUN_THREAD = new Thread(FALCON_GUN_THREAD_START);
                ACTIVE_FALCON_GUN_THREAD = true;
                FALCON_GUN_THREAD.Start();

                FALCON_PAYLOAD_THREAD_START = new ThreadStart(FALCON_GET_PAYLOAD_VIBRATION);
                FALCON_PAYLOAD_THREAD = new Thread(FALCON_PAYLOAD_THREAD_START);
                ACTIVE_FALCON_PAYLOAD_THREAD = true;
                FALCON_PAYLOAD_THREAD.Start();

                FALCON_GEAR_THREAD_START = new ThreadStart(FALCON_GET_GEAR_VIBRATION);
                FALCON_GEAR_THREAD = new Thread(FALCON_GEAR_THREAD_START);
                ACTIVE_FALCON_GEAR_THREAD = true;
                FALCON_GEAR_THREAD.Start();

                FALCON_AIRBREAK_THREAD_START = new ThreadStart(FALCON_GET_AIRBREAK_GEAR_VIBRATION);
                FALCON_AIRBREAK_THREAD = new Thread(FALCON_AIRBREAK_THREAD_START);
                ACTIVE_FALCON_AIRBREAK_THREAD = true;
                FALCON_AIRBREAK_THREAD.Start();

                FALCON_BUNNER_THREAD_START = new ThreadStart(FALCON_GET_BUNNER_VIBRATION);
                FALCON_BUNNER_THREAD = new Thread(FALCON_BUNNER_THREAD_START);
                ACTIVE_FALCON_BUNNER_THREAD = true;
                FALCON_BUNNER_THREAD.Start();

                FALCON_CHFL_THREAD_START = new ThreadStart(FALCON_GET_CHFL_VIBRATION);
                FALCON_CHFL_THREAD = new Thread(FALCON_CHFL_THREAD_START);
                ACTIVE_FALCON_CHFL_THREAD = true;
                FALCON_CHFL_THREAD.Start();

                FALCON_DAMAGE_THREAD_START = new ThreadStart(FALCON_GET_DAMAGE_VIBRATION);
                FALCON_DAMAGE_THREAD = new Thread(FALCON_DAMAGE_THREAD_START);
                ACTIVE_FALCON_DAMAGE_THREAD = true;
                FALCON_DAMAGE_THREAD.Start();

                GetPrivateProfileString("FALCON_BMS", "VIB_SETUP", null, ini_falcon_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");

                if (ini_falcon_setup.Length == 0)
                {
                    WritePrivateProfileString("FALCON_BMS", "VIB_SETUP", "13,25,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1,1,1", System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                    GetPrivateProfileString("FALCON_BMS", "VIB_SETUP", null, ini_falcon_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                    LOAD_INI_FALCON(ini_falcon_setup.ToString());
                }
                else
                {
                    LOAD_INI_FALCON(ini_falcon_setup.ToString());
                }

                Connect_FALCON.Text = "Disconnect";
                vib_timer3.Start();
                get_falcon_timer.Start();
            }
            else
            {
                ACTIVE_FALCON_ACCS_THREAD = false;
                ACTIVE_FALCON_AOA_THREAD = false;
                ACTIVE_FALCON_GUN_THREAD = false;
                ACTIVE_FALCON_PAYLOAD_THREAD = false;
                ACTIVE_FALCON_GEAR_THREAD = false;
                ACTIVE_FALCON_AIRBREAK_THREAD = false;
                ACTIVE_FALCON_CHFL_THREAD = false;
                ACTIVE_FALCON_DAMAGE_THREAD = false;
                ACTIVE_FALCON_BUNNER_THREAD = false;

                FALCON_PITCH_VIB_OUT.Text = "0";
                FALCON_ROLL_VIB_OUT.Text = "0";
                FALCON_YAW_VIB_OUT.Text = "0";
                FALCON_AOA_VIB_OUT.Text = "0";
                FALCON_BUNNER_VIB_OUT.Text = "0";
                FALCON_GUN_VIB_OUT.Text = "0";
                FALCON_PAYLOAD_VIB_OUT.Text = "0";
                FALCON_GEAR_VIB_OUT.Text = "0";
                FALCON_AIRBREAK_VIB_OUT.Text = "0";
                FALCON_CHFL_VIB_OUT.Text = "0";
                FALCON_DAMAGE_VIB_OUT.Text = "0";
                FALCON_VIB_OUT.Text = "0";

                Connect_FALCON.Text = "Connect";
                serialPort1.WriteLine("V0");
                serialPort1.Close();
                get_falcon_timer.Stop();
                vib_timer3.Stop();
            }
        }




        private void get_falcon_timer_Tick(object sender, EventArgs e)
        {
            Reader Myreader = new Reader();

            try
            {
                if (Myreader.IsFalconRunning)
                {
                    FlightData mysharedmem = Myreader.GetCurrentData();
                    FALCON_IAS.Text = mysharedmem.kias.ToString();
                    FALCON_X.Text = mysharedmem.pitch.ToString();
                    FALCON_Y.Text = mysharedmem.roll.ToString();
                    FALCON_Z.Text = mysharedmem.yaw.ToString();
                    FALCON_AOA.Text = mysharedmem.alpha.ToString();
                    FALCON_NOZZLE.Text = mysharedmem.nozzlePos.ToString();

                    FALCON_FIREGUN.Text = mysharedmem.IntellivibeData.IsFiringGun.ToString();
                    FALCON_AA.Text = mysharedmem.IntellivibeData.AAMissileFired.ToString();
                    FALCON_AG.Text = mysharedmem.IntellivibeData.AGMissileFired.ToString();
                    FALCON_BOMB.Text = mysharedmem.IntellivibeData.BombDropped.ToString();

                    FALCON_GEAR.Text = mysharedmem.gearPos.ToString();
                    FALCON_BREAK.Text = mysharedmem.speedBrake.ToString();

                    FALCON_CHAFF.Text = mysharedmem.IntellivibeData.ChaffDropped.ToString();
                    FALCON_FLARE.Text = mysharedmem.IntellivibeData.FlareDropped.ToString();

                    FALCON_DAMAGE.Text = mysharedmem.IntellivibeData.whendamage.ToString();
                    FALCON_DAMAGE_F.Text = mysharedmem.IntellivibeData.damageforce.ToString();
                    FALCON_INGAME.Text = mysharedmem.IntellivibeData.In3D.ToString();



                }
            }
            catch {
                MessageBox.Show("오류발생");
            }
        }


        private void FALCON_GET_ACCS_VIBRATION()
        {
            double before_accs_x = 0;
            double before_accs_y = 0;
            double before_accs_z = 0;
            double[] vib = new double[3];


            while (ACTIVE_FALCON_ACCS_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double x_vib = before_accs_x - double.Parse(FALCON_X.Text);
                    double y_vib = before_accs_y - double.Parse(FALCON_Y.Text);
                    double z_vib = before_accs_z - double.Parse(FALCON_Z.Text);

                    if (x_vib < 0) x_vib = x_vib * -1 * 5000;
                    if (y_vib < 0) y_vib = y_vib * -1 * 1000;
                    if (z_vib < 0) z_vib = z_vib * -1 * 1000;

                    x_vib = Math.Round(x_vib, 0);
                    y_vib = Math.Round(y_vib, 0);
                    z_vib = Math.Round(z_vib, 0);

                    before_accs_x = double.Parse(FALCON_X.Text);
                    before_accs_y = double.Parse(FALCON_Y.Text);
                    before_accs_z = double.Parse(FALCON_Z.Text);

                    FALCON_PITCH_VIB.Text = x_vib.ToString();
                    FALCON_ROLL_VIB.Text = y_vib.ToString();
                    FALCON_YAW_VIB.Text = z_vib.ToString();
                }));
                Thread.Sleep(100);
            }
        }

        private void FALCON_GET_AOA_VIBRATION()
        {
            while (ACTIVE_FALCON_AOA_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double AOA_MIN = double.Parse(FALCON_AOA_S_COMBO.Text);
                    double AOA_MAX = double.Parse(FALCON_AOA_M_COMBO.Text);
                    double VIB = 0;

                    if (double.Parse(FALCON_AOA.Text) > AOA_MIN && double.Parse(FALCON_IAS.Text) > 50)
                    {
                        VIB = (((double.Parse(FALCON_AOA.Text) - AOA_MIN) / (AOA_MAX - AOA_MIN)) * 255);
                        FALCON_AOA_VIB.Text = VIB.ToString();

                    }
                    else
                    {
                        FALCON_AOA_VIB.Text = "0";
                    }
                }));
                Thread.Sleep(100);
            }
        }

        private void FALCON_GET_GUN_VIBRATION()
        {
            while (ACTIVE_FALCON_GUN_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    if (FALCON_FIREGUN.Text == "True")
                    {
                        FALCON_GUN_VIB.Text = "80";
                    }
                    else
                    {
                        FALCON_GUN_VIB.Text = "0";
                    }
                }));

                Thread.Sleep(100);
            }
        }

        private void FALCON_GET_PAYLOAD_VIBRATION()
        {
            string BEFORE_PAYLOAD1 = "0";
            string BEFORE_PAYLOAD2 = "0";
            string BEFORE_PAYLOAD3 = "0";

            while (ACTIVE_FALCON_PAYLOAD_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (BEFORE_PAYLOAD1 != FALCON_AA.Text || BEFORE_PAYLOAD2 != FALCON_AG.Text || BEFORE_PAYLOAD3 != FALCON_BOMB.Text)
                    {
                        FALCON_PAYLOAD_VIB.Text = "255";
                        Thread.Sleep(300);
                    }
                    else
                    {
                        FALCON_PAYLOAD_VIB.Text = "0";
                    }
                    BEFORE_PAYLOAD1 = FALCON_AA.Text;
                    BEFORE_PAYLOAD2 = FALCON_AG.Text;
                    BEFORE_PAYLOAD3 = FALCON_BOMB.Text;
                }));
                Thread.Sleep(100);
            }
        }

        private void FALCON_GET_GEAR_VIBRATION()
        {
            string BEFORE_GEAR = "0";
            while (ACTIVE_FALCON_GEAR_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    if (BEFORE_GEAR != FALCON_GEAR.Text)
                    {
                        FALCON_GEAR_VIB.Text = "80";
                    }
                    else
                    {
                        FALCON_GEAR_VIB.Text = "0";
                    }
                    BEFORE_GEAR = FALCON_GEAR.Text;
                }));

                Thread.Sleep(100);
            }
        }

        private void FALCON_GET_AIRBREAK_GEAR_VIBRATION()
        {
            while (ACTIVE_FALCON_AIRBREAK_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double IAS_DATA = 0;
                    double VIB_PER = 0;
                    IAS_DATA = double.Parse(FALCON_IAS.Text);


                    if (IAS_DATA < 50)
                    {
                        VIB_PER = 0;
                    }
                    else if (IAS_DATA < 150)
                    {
                        VIB_PER = (IAS_DATA - 50) / 100;
                        if (VIB_PER > 1) VIB_PER = 1;
                    }
                    else
                    {
                        VIB_PER = 1;
                    }


                    if (double.Parse(FALCON_BREAK.Text) > 0)
                    {
                        double VIB = (255 * double.Parse(FALCON_BREAK.Text) / 2) * VIB_PER;

                        int VIB_INT = Convert.ToInt32(VIB);

                        FALCON_AIRBREAK_VIB.Text = VIB_INT.ToString();

                    }
                    else
                    {
                        FALCON_AIRBREAK_VIB.Text = "0";
                    }


                }));
                Thread.Sleep(100);
            }
        }

        private void FALCON_GET_CHFL_VIBRATION()
        {
            string BEFORE_PAYLOAD1 = "0";
            string BEFORE_PAYLOAD2 = "0";

            while (ACTIVE_FALCON_CHFL_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (BEFORE_PAYLOAD1 != FALCON_CHAFF.Text || BEFORE_PAYLOAD2 != FALCON_FLARE.Text)
                    {
                        FALCON_CHFL_VIB.Text = "150";
                    }
                    else
                    {
                        FALCON_CHFL_VIB.Text = "0";
                    }
                    BEFORE_PAYLOAD1 = FALCON_CHAFF.Text;
                    BEFORE_PAYLOAD2 = FALCON_FLARE.Text;
                }));
                Thread.Sleep(100);
            }
        }

        private void FALCON_GET_DAMAGE_VIBRATION()
        {
            string BEFORE_DAMAGE = "0";

            while (ACTIVE_FALCON_DAMAGE_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (BEFORE_DAMAGE != FALCON_DAMAGE.Text)
                    {
                        FALCON_DAMAGE_VIB.Text = (Int32.Parse(FALCON_DAMAGE_F.Text) * 5).ToString();
                        Thread.Sleep(300);
                    }
                    else
                    {
                        FALCON_DAMAGE_VIB.Text = "0";
                    }
                    BEFORE_DAMAGE = FALCON_DAMAGE.Text;

                }));
                Thread.Sleep(100);
            }
        }
        private void FALCON_GET_BUNNER_VIBRATION()
        {
            while (ACTIVE_FALCON_BUNNER_THREAD)
            {
                Thread.Sleep(100);
            }
        }


        private void vib_timer3_Tick(object sender, EventArgs e)
        {
            double[] VIBRATION = new double[11];

            if (double.Parse(FALCON_PITCH_VIB.Text) * (double.Parse(FALCON_PITCH_VIB_PER.Text) / 100) > 255)
            {
                FALCON_PITCH_VIB_OUT.Text = "255";
            }
            else
            {
                if (double.Parse(FALCON_PITCH_VIB.Text) > double.Parse(FALCON_PITCH_VIB_MIN.Text))
                {
                    FALCON_PITCH_VIB_OUT.Text = (double.Parse(FALCON_PITCH_VIB.Text) * (double.Parse(FALCON_PITCH_VIB_PER.Text) / 100)).ToString();
                }
                else
                {
                    FALCON_PITCH_VIB_OUT.Text = "0";
                }
            }

            if (double.Parse(FALCON_ROLL_VIB.Text) * (double.Parse(FALCON_ROLL_VIB_PER.Text) / 100) > 255)
            {
                FALCON_ROLL_VIB_OUT.Text = "255";
            }
            else
            {
                if (double.Parse(FALCON_ROLL_VIB.Text) > double.Parse(FALCON_ROLL_VIB_MIN.Text))
                {
                    FALCON_ROLL_VIB_OUT.Text = (double.Parse(FALCON_ROLL_VIB.Text) * (double.Parse(FALCON_ROLL_VIB_PER.Text) / 100)).ToString();
                }
                else
                {
                    FALCON_ROLL_VIB_OUT.Text = "0";
                }

            }

            if (double.Parse(FALCON_YAW_VIB.Text) * (double.Parse(FALCON_YAW_VIB_PER.Text) / 100) > 255)
            {
                FALCON_YAW_VIB_OUT.Text = "255";
            }
            else
            {
                if (double.Parse(FALCON_YAW_VIB.Text) > double.Parse(FALCON_YAW_VIB_MIN.Text))
                {
                    FALCON_YAW_VIB_OUT.Text = (double.Parse(FALCON_YAW_VIB.Text) * (double.Parse(FALCON_YAW_VIB_PER.Text) / 100)).ToString();
                }
                else
                {
                    FALCON_YAW_VIB_OUT.Text = "0";
                }
            }

            if (double.Parse(FALCON_AOA_VIB.Text) * (double.Parse(FALCON_AOA_VIB_PER.Text) / 100) > 255)
            {
                FALCON_AOA_VIB_OUT.Text = "255";
            }
            else
            {
                FALCON_AOA_VIB_OUT.Text = (double.Parse(FALCON_AOA_VIB.Text) * (double.Parse(FALCON_AOA_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FALCON_BUNNER_VIB.Text) * (double.Parse(FALCON_BUNNER_VIB_PER.Text) / 100) > 255)
            {
                FALCON_BUNNER_VIB_OUT.Text = "255";
            }
            else
            {
                FALCON_BUNNER_VIB_OUT.Text = (double.Parse(FALCON_BUNNER_VIB.Text) * (double.Parse(FALCON_BUNNER_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FALCON_GUN_VIB.Text) * (double.Parse(FALCON_GUN_VIB_PER.Text) / 100) > 255)
            {
                FALCON_GUN_VIB_OUT.Text = "255";
            }
            else
            {
                FALCON_GUN_VIB_OUT.Text = (double.Parse(FALCON_GUN_VIB.Text) * (double.Parse(FALCON_GUN_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FALCON_PAYLOAD_VIB.Text) * (double.Parse(FALCON_PAYLOAD_VIB_PER.Text) / 100) > 255)
            {
                FALCON_PAYLOAD_VIB_OUT.Text = "255";
            }
            else
            {
                FALCON_PAYLOAD_VIB_OUT.Text = (double.Parse(FALCON_PAYLOAD_VIB.Text) * (double.Parse(FALCON_PAYLOAD_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FALCON_GEAR_VIB.Text) * (double.Parse(FALCON_GEAR_VIB_PER.Text) / 100) > 255)
            {
                FALCON_GEAR_VIB_OUT.Text = "255";
            }
            else
            {
                FALCON_GEAR_VIB_OUT.Text = (double.Parse(FALCON_GEAR_VIB.Text) * (double.Parse(FALCON_GEAR_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FALCON_AIRBREAK_VIB.Text) * (double.Parse(FALCON_AIRBREAK_VIB_PER.Text) / 100) > 255)
            {
                FALCON_AIRBREAK_VIB_OUT.Text = "255";
            }
            else
            {
                FALCON_AIRBREAK_VIB_OUT.Text = (double.Parse(FALCON_AIRBREAK_VIB.Text) * (double.Parse(FALCON_AIRBREAK_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FALCON_CHFL_VIB.Text) * (double.Parse(FALCON_CHFL_VIB_PER.Text) / 100) > 255)
            {
                FALCON_CHFL_VIB_OUT.Text = "255";
            }
            else
            {
                FALCON_CHFL_VIB_OUT.Text = (double.Parse(FALCON_CHFL_VIB.Text) * (double.Parse(FALCON_CHFL_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FALCON_DAMAGE_VIB.Text) * (double.Parse(FALCON_DAMAGE_VIB_PER.Text) / 100) > 255)
            {
                FALCON_DAMAGE_VIB_OUT.Text = "255";
            }
            else
            {
                FALCON_DAMAGE_VIB_OUT.Text = (double.Parse(FALCON_DAMAGE_VIB.Text) * (double.Parse(FALCON_DAMAGE_VIB_PER.Text) / 100)).ToString();
            }

            if (FALCON_PITCH_CHK.Checked == true) VIBRATION[0] = double.Parse(FALCON_PITCH_VIB_OUT.Text); else VIBRATION[0] = 0;
            if (FALCON_ROLL_CHK.Checked == true) VIBRATION[1] = double.Parse(FALCON_ROLL_VIB_OUT.Text); else VIBRATION[1] = 0;
            if (FALCON_YAW_CHK.Checked == true) VIBRATION[2] = double.Parse(FALCON_YAW_VIB_OUT.Text); else VIBRATION[2] = 0;
            if (FALCON_AOA_CHK.Checked == true) VIBRATION[3] = double.Parse(FALCON_AOA_VIB_OUT.Text); else VIBRATION[3] = 0;
            if (FALCON_BUNNER_CHK.Checked == true) VIBRATION[4] = double.Parse(FALCON_BUNNER_VIB_OUT.Text); else VIBRATION[4] = 0;
            if (FALCON_GUN_CHK.Checked == true) VIBRATION[5] = double.Parse(FALCON_GUN_VIB_OUT.Text); else VIBRATION[5] = 0;
            if (FALCON_PAYLOAD_CHK.Checked == true) VIBRATION[6] = double.Parse(FALCON_PAYLOAD_VIB_OUT.Text); else VIBRATION[6] = 0;
            if (FALCON_GEAR_CHK.Checked == true) VIBRATION[7] = double.Parse(FALCON_GEAR_VIB_OUT.Text); else VIBRATION[7] = 0;
            if (FALCON_AIRBREAK_CHK.Checked == true) VIBRATION[8] = double.Parse(FALCON_AIRBREAK_VIB_OUT.Text); else VIBRATION[8] = 0;
            if (FALCON_CHFL_CHK.Checked == true) VIBRATION[9] = double.Parse(FALCON_CHFL_VIB_OUT.Text); else VIBRATION[9] = 0;
            if (FALCON_DAMAGE_CHK.Checked == true) VIBRATION[10] = double.Parse(FALCON_DAMAGE_VIB_OUT.Text); else VIBRATION[10] = 0;

            if (serialPort1.IsOpen)
            {
                if (FALCON_INGAME.Text == "True")
                {
                    serialPort1.WriteLine("V" + VIBRATION.Max().ToString());
                    FALCON_VIB_OUT.Text = VIBRATION.Max().ToString();
                }
                else
                {
                    serialPort1.WriteLine("V0");
                    FALCON_VIB_OUT.Text = "0";
                }
            }
        }

        private void Power_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Power_Check.Checked)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine("E");
                }
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine("R");
                }
            }
        }

        private void LOAD_INI_FALCON(string INI_DATA)
        {
            string[] ini_data = INI_DATA.Split(',');
            FALCON_AOA_S_COMBO.Text = ini_data[0];
            FALCON_AOA_M_COMBO.Text = ini_data[1];

            if (ini_data[2] == "1") FALCON_PITCH_CHK.Checked = true; else FALCON_PITCH_CHK.Checked = false;
            FALCON_PITCH_VIB_PER.Text = ini_data[3];
            if (ini_data[4] == "1") FALCON_ROLL_CHK.Checked = true; else FALCON_ROLL_CHK.Checked = false;
            FALCON_ROLL_VIB_PER.Text = ini_data[5];
            if (ini_data[6] == "1") FALCON_YAW_CHK.Checked = true; else FALCON_YAW_CHK.Checked = false;
            FALCON_YAW_VIB_PER.Text = ini_data[7];
            if (ini_data[8] == "1") FALCON_AOA_CHK.Checked = true; else FALCON_AOA_CHK.Checked = false;
            FALCON_AOA_VIB_PER.Text = ini_data[9];
            if (ini_data[10] == "1") FALCON_BUNNER_CHK.Checked = true; else FALCON_BUNNER_CHK.Checked = false;
            FALCON_BUNNER_VIB_PER.Text = ini_data[11];
            if (ini_data[12] == "1") FALCON_GUN_CHK.Checked = true; else FALCON_GUN_CHK.Checked = false;
            FALCON_GUN_VIB_PER.Text = ini_data[13];
            if (ini_data[14] == "1") FALCON_PAYLOAD_CHK.Checked = true; else FALCON_PAYLOAD_CHK.Checked = false;
            FALCON_PAYLOAD_VIB_PER.Text = ini_data[15];
            if (ini_data[16] == "1") FALCON_GEAR_CHK.Checked = true; else FALCON_GEAR_CHK.Checked = false;
            FALCON_GEAR_VIB_PER.Text = ini_data[17];
            if (ini_data[18] == "1") FALCON_AIRBREAK_CHK.Checked = true; else FALCON_AIRBREAK_CHK.Checked = false;
            FALCON_AIRBREAK_VIB_PER.Text = ini_data[19];
            if (ini_data[20] == "1") FALCON_CHFL_CHK.Checked = true; else FALCON_CHFL_CHK.Checked = false;
            FALCON_CHFL_VIB_PER.Text = ini_data[21];
            if (ini_data[22] == "1") FALCON_DAMAGE_CHK.Checked = true; else FALCON_DAMAGE_CHK.Checked = false;
            FALCON_DAMAGE_VIB_PER.Text = ini_data[23];
            FALCON_PITCH_VIB_MIN.Text = ini_data[24];
            FALCON_ROLL_VIB_MIN.Text = ini_data[25];
            FALCON_YAW_VIB_MIN.Text = ini_data[26];



        }
        private void SAVE_INI_FALCON()
        {
            string ini_data = null;

            ini_data += FALCON_AOA_S_COMBO.Text + "," + FALCON_AOA_M_COMBO.Text + ",";

            if (FALCON_PITCH_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FALCON_PITCH_VIB_PER.Text + ",";
            if (FALCON_ROLL_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FALCON_ROLL_VIB_PER.Text + ",";
            if (FALCON_YAW_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FALCON_YAW_VIB_PER.Text + ",";
            if (FALCON_AOA_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FALCON_AOA_VIB_PER.Text + ",";
            if (FALCON_BUNNER_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FALCON_BUNNER_VIB_PER.Text + ",";
            if (FALCON_GUN_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FALCON_GUN_VIB_PER.Text + ",";
            if (FALCON_PAYLOAD_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FALCON_PAYLOAD_VIB_PER.Text + ",";
            if (FALCON_GEAR_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FALCON_GEAR_VIB_PER.Text + ",";
            if (FALCON_AIRBREAK_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FALCON_AIRBREAK_VIB_PER.Text + ",";
            if (FALCON_CHFL_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FALCON_CHFL_VIB_PER.Text + ",";
            if (FALCON_DAMAGE_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FALCON_DAMAGE_VIB_PER.Text + ",";
            ini_data += FALCON_PITCH_VIB_MIN.Text + ",";
            ini_data += FALCON_ROLL_VIB_MIN.Text + ",";
            ini_data += FALCON_YAW_VIB_MIN.Text;

            WritePrivateProfileString("FALCON_BMS", "VIB_SETUP", ini_data, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
        }

        private void FALCON_PITCH_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_ROLL_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_YAW_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_AOA_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_BUNNER_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_GUN_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_PAYLOAD_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_GEAR_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_AIRBREAK_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_CHFL_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_DAMAGE_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_PITCH_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_ROLL_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_YAW_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_AOA_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_BUNNER_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_GUN_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_PAYLOAD_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_GEAR_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_AIRBREAK_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_CHFL_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_DAMAGE_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_AOA_S_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_AOA_M_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_PITCH_VIB_MIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_ROLL_VIB_MIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void FALCON_YAW_VIB_MIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_FALCON();
        }

        private void DEFAULT_SETUP_FALCON_Click(object sender, EventArgs e)
        {
            FALCON_AOA_S_COMBO.Text = "13";
            FALCON_AOA_M_COMBO.Text = "25";
            FALCON_PITCH_CHK.Checked = true;
            FALCON_ROLL_CHK.Checked = true;
            FALCON_YAW_CHK.Checked = true;
            FALCON_AOA_CHK.Checked = true;
            FALCON_BUNNER_CHK.Checked = true;
            FALCON_GUN_CHK.Checked = true;
            FALCON_PAYLOAD_CHK.Checked = true;
            FALCON_GEAR_CHK.Checked = true;
            FALCON_AIRBREAK_CHK.Checked = true;
            FALCON_CHFL_CHK.Checked = true;
            FALCON_DAMAGE_CHK.Checked = true;

            FALCON_PITCH_VIB_MIN.Text = "1";
            FALCON_ROLL_VIB_MIN.Text = "1";
            FALCON_YAW_VIB_MIN.Text = "1";

            FALCON_PITCH_VIB_PER.Text = "100";
            FALCON_ROLL_VIB_PER.Text = "100";
            FALCON_YAW_VIB_PER.Text = "100";
            FALCON_AOA_VIB_PER.Text = "100";
            FALCON_BUNNER_VIB_PER.Text = "100";
            FALCON_GUN_VIB_PER.Text = "100";
            FALCON_PAYLOAD_VIB_PER.Text = "100";
            FALCON_GEAR_VIB_PER.Text = "100";
            FALCON_AIRBREAK_VIB_PER.Text = "100";
            FALCON_CHFL_VIB_PER.Text = "100";
            FALCON_DAMAGE_VIB_PER.Text = "100";
        }












        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // MSFS2020 전용 작업
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public StringBuilder ini_fs2020_setup = new StringBuilder();

        // FS2020 가속도 추출 쓰레드
        Thread FS_ACCS_THREAD;
        ThreadStart FS_ACCS_THREAD_START;
        bool ACTIVE_FS_ACCS_THREAD;

        // FS2020 AOA 추출 쓰레드
        Thread FS_AOA_THREAD;
        ThreadStart FS_AOA_THREAD_START;
        bool ACTIVE_FS_AOA_THREAD;

        // FS2020 GEAR 추출 쓰레드
        Thread FS_GEAR_THREAD;
        ThreadStart FS_GEAR_THREAD_START;
        bool ACTIVE_FS_GEAR_THREAD;

        // FS2020 FLAP 추출 쓰레드
        Thread FS_FLAP_THREAD;
        ThreadStart FS_FLAP_THREAD_START;
        bool ACTIVE_FS_FLAP_THREAD;

        // FS2020 SPOILER 추출 쓰레드
        Thread FS_SPOILER_THREAD;
        ThreadStart FS_SPOILER_THREAD_START;
        bool ACTIVE_FS_SPOILER_THREAD;

        // FS2020 WARNING 추출 쓰레드
        Thread FS_WARNING_THREAD;
        ThreadStart FS_WARNING_THREAD_START;
        bool ACTIVE_FS_WARNING_THREAD;

        // User-defined win32 event
        const int WM_USER_SIMCONNECT = 0x0402;

        // SimConnect object
        SimConnect simconnect = null;

        enum DEFINITIONS
        {
            Struct1,
        }

        enum DATA_REQUESTS
        {
            REQUEST_1,
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Struct1
        {
            // this is how you declare a fixed size string
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public String title;
            public double acc_x;
            public double acc_y;
            public double acc_z;
            public double ias;
            public double aoa;
            public double spoiler_l;
            public double spoiler_r;
            public double gear;
            public double flaps;
            public bool stall;
            public bool overspeed;
            public bool autopilot;
            public bool reverse;

        };

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                if (simconnect != null)
                {
                    simconnect.ReceiveMessage();
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }


        private void Connect_FS2020_Click(object sender, EventArgs e)
        {
            if (Connect_FS2020.Text == "Connect")
            {
                try
                {
                    string[] port_list = comboPorts.Text.Split('-');
                    serialPort1.PortName = port_list[0];

                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                        serialPort1.WriteLine("L");
                        if (Power_Check.Checked)
                        {
                            serialPort1.WriteLine("E");
                        }
                        else
                        {
                            serialPort1.WriteLine("R");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("아두이노가 연결되지 않았습니다.");
                    return;
                }
                if (simconnect == null)
                {
                    try
                    {
                        // the constructor is similar to SimConnect_Open in the native API
                        simconnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);


                    }
                    catch (COMException ex)
                    {
                        MessageBox.Show("FS2020이 실행중이지 않습니다.");
                        serialPort1.Close();
                        return;
                    }

                    simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(simconnect_OnRecvOpen);
                    simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(simconnect_OnRecvQuit);
                    simconnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(SimConnect_OnRecvException);

                    // define a data structure
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "ACCELERATION BODY X", "feet/second", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "ACCELERATION BODY Y", "feet/second", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "ACCELERATION BODY Z", "feet/second", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "AIRSPEED INDICATED", "knots", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "INCIDENCE ALPHA", "Radians", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "SPOILERS LEFT POSITION", "percent over 100", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "SPOILERS RIGHT POSITION", "percent over 100", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "GEAR POSITION", "enum", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "TRAILING EDGE FLAPS LEFT PERCENT", "percent over 100", SIMCONNECT_DATATYPE.FLOAT64, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "STALL WARNING", "bool", SIMCONNECT_DATATYPE.INT32, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "OVERSPEED WARNING", "bool", SIMCONNECT_DATATYPE.INT32, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "AUTOPILOT DISENGAGED", "bool", SIMCONNECT_DATATYPE.INT32, 0, SimConnect.SIMCONNECT_UNUSED);
                    simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "GENERAL ENG REVERSE THRUST ENGAGED", "bool", SIMCONNECT_DATATYPE.INT32, 0, SimConnect.SIMCONNECT_UNUSED);

                    simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);

                    // catch a simobject data request
                    simconnect.OnRecvSimobjectDataBytype += new SimConnect.RecvSimobjectDataBytypeEventHandler(SimConnect_OnRecvSimobjectDataBytype);


                    FS_ACCS_THREAD_START = new ThreadStart(FS_GET_ACCS_VIBRATION);
                    FS_ACCS_THREAD = new Thread(FS_ACCS_THREAD_START);
                    ACTIVE_FS_ACCS_THREAD = true;
                    FS_ACCS_THREAD.Start();

                    FS_AOA_THREAD_START = new ThreadStart(FS_GET_AOA_VIBRATION);
                    FS_AOA_THREAD = new Thread(FS_AOA_THREAD_START);
                    ACTIVE_FS_AOA_THREAD = true;
                    FS_AOA_THREAD.Start();

                    FS_GEAR_THREAD_START = new ThreadStart(FS_GET_GEAR_VIBRATION);
                    FS_GEAR_THREAD = new Thread(FS_GEAR_THREAD_START);
                    ACTIVE_FS_GEAR_THREAD = true;
                    FS_GEAR_THREAD.Start();

                    FS_FLAP_THREAD_START = new ThreadStart(FS_GET_FLAP_VIBRATION);
                    FS_FLAP_THREAD = new Thread(FS_FLAP_THREAD_START);
                    ACTIVE_FS_FLAP_THREAD = true;
                    FS_FLAP_THREAD.Start();

                    FS_SPOILER_THREAD_START = new ThreadStart(FS_GET_SPOILER_VIBRATION);
                    FS_SPOILER_THREAD = new Thread(FS_SPOILER_THREAD_START);
                    ACTIVE_FS_SPOILER_THREAD = true;
                    FS_SPOILER_THREAD.Start();

                    FS_WARNING_THREAD_START = new ThreadStart(FS_GET_WARNING_VIBRATION);
                    FS_WARNING_THREAD = new Thread(FS_WARNING_THREAD_START);
                    ACTIVE_FS_WARNING_THREAD = true;
                    FS_WARNING_THREAD.Start();



                    GetPrivateProfileString("MSFS2020", "VIB_SETUP", null, ini_fs2020_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");

                    if (ini_fs2020_setup.Length == 0)
                    {
                        WritePrivateProfileString("MSFS2020", "VIB_SETUP", "13,25,1,100,1,100,1,100,1,100,1,100,1,100,1,100,1", System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                        GetPrivateProfileString("MSFS2020", "VIB_SETUP", null, ini_fs2020_setup, 100, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
                        LOAD_INI_MSFS2020(ini_fs2020_setup.ToString());
                    }
                    else
                    {
                        LOAD_INI_MSFS2020(ini_fs2020_setup.ToString());
                    }

                    Connect_FS2020.Text = "Disconnect";
                    get_fs2020_timer.Start();
                    vib_timer4.Start();
                }
            }
            else
            {
                ACTIVE_FS_ACCS_THREAD = false;
                ACTIVE_FS_AOA_THREAD = false;
                ACTIVE_FS_GEAR_THREAD = false;
                ACTIVE_FS_FLAP_THREAD = false;
                ACTIVE_FS_WARNING_THREAD = false;


                FS_ACC_VIB.Text = "0";
                FS_AOA_VIB.Text = "0";
                FS_GEAR_VIB.Text = "0";
                FS_FLAP_VIB.Text = "0";
                FS_SPOILER_VIB.Text = "0";
                FS_STALL_VIB.Text = "0";
                FS_OVERSPEED_VIB.Text = "0";
                FS_VIB_OUT.Text = "0";  

                Connect_FS2020.Text = "Connect";
                serialPort1.WriteLine("V0");
                serialPort1.Close();
                simconnect.Dispose();
                simconnect = null;
                get_fs2020_timer.Stop();
                vib_timer4.Stop();
            }
        }
        void simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            Console.WriteLine("Connected to Prepar3D");
        }
        void simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            Console.WriteLine("Prepar3D has exited");
            if (simconnect != null)
            {
                // Dispose serves the same purpose as SimConnect_Close()
                simconnect.Dispose();
                simconnect = null;
                Console.WriteLine("Connection closed");
            }
        }
        private void SimConnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            SIMCONNECT_EXCEPTION eException = (SIMCONNECT_EXCEPTION)data.dwException;
            Console.WriteLine("SimConnect_OnRecvException: " + eException.ToString());
        }


        private void SimConnect_OnRecvSimobjectDataBytype(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {
            Console.WriteLine("SimConnect_OnRecvSimobjectDataBytype");

            Struct1 result = (Struct1)data.dwData[0];
            FS_PLANE_NAME.Text = result.title;
            FS_ACC_X.Text = result.acc_x.ToString();
            FS_ACC_Y.Text = result.acc_y.ToString();
            FS_ACC_Z.Text = result.acc_z.ToString();
            FS_IAS.Text = result.ias.ToString();
            FS_AOA.Text = (result.aoa * 57.27958).ToString();
            FS_SPOILER_L.Text = result.spoiler_l.ToString();
            FS_SPOILER_R.Text = result.spoiler_r.ToString();
            FS_GEAR.Text = result.gear.ToString();
            FS_FLAP.Text = result.flaps.ToString();
            FS_STALL.Text = result.stall.ToString();
            FS_OVERSPEED.Text = result.overspeed.ToString();
        }
        private void get_fs2020_timer_Tick(object sender, EventArgs e)
        {
            simconnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
        }




        private void FS_GET_ACCS_VIBRATION()
        {
            double before_accs_x = 0;
            double before_accs_y = 0;
            double before_accs_z = 0;
            double[] vib = new double[3];


            while (ACTIVE_FS_ACCS_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double x_vib = before_accs_x - double.Parse(FS_ACC_X.Text);
                    double y_vib = before_accs_y - double.Parse(FS_ACC_Y.Text);
                    double z_vib = before_accs_z - double.Parse(FS_ACC_Z.Text);


                    if (x_vib < 0) x_vib = x_vib * -1 * 50;
                    if (y_vib < 0) y_vib = y_vib * -1 * 50;
                    //if (z_vib < 0) z_vib = z_vib * -1 * 50;

                    x_vib = Math.Round(x_vib, 0);
                    y_vib = Math.Round(y_vib, 0);
                    //z_vib = Math.Round(z_vib, 0);

                    before_accs_x = double.Parse(FS_ACC_X.Text);
                    before_accs_y = double.Parse(FS_ACC_Y.Text);
                    //before_accs_z = double.Parse(FS_ACC_Z.Text);

                    vib[0] = x_vib;
                    vib[1] = y_vib;
                    //vib[2] = z_vib;

                    FS_ACC_VIB.Text = vib.Max().ToString();

                }));
                Thread.Sleep(100);
            }
        }


        private void FS_GET_AOA_VIBRATION()
        {
            while (ACTIVE_FS_AOA_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double AOA_MIN = double.Parse(FS_AOA_S_COMBO.Text);
                    double AOA_MAX = double.Parse(FS_AOA_M_COMBO.Text);
                    double VIB = 0;

                    if (double.Parse(FS_AOA.Text) > AOA_MIN && double.Parse(FS_IAS.Text) > 50)
                    {
                        VIB = (((double.Parse(FS_AOA.Text) - AOA_MIN) / (AOA_MAX - AOA_MIN)) * 255);
                        FS_AOA_VIB.Text = VIB.ToString();

                    }
                    else
                    {
                        FS_AOA_VIB.Text = "0";
                    }
                }));
                Thread.Sleep(100);
            }
        }

        private void FS_GET_GEAR_VIBRATION()
        {
            string BEFORE_GEAR = "0";
            while (ACTIVE_FS_GEAR_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    if (BEFORE_GEAR != FS_GEAR.Text)
                    {
                        FS_GEAR_VIB.Text = "100";
                    }
                    else
                    {
                        FS_GEAR_VIB.Text = "0";
                    }
                    BEFORE_GEAR = FS_GEAR.Text;
                }));

                Thread.Sleep(100);
            }
        }

        private void FS_GET_FLAP_VIBRATION()
        {
            string BEFORE_FLAP = "0";
            while (ACTIVE_FS_FLAP_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    if (BEFORE_FLAP != FS_FLAP.Text)
                    {
                        FS_FLAP_VIB.Text = "80";
                    }
                    else
                    {
                        FS_FLAP_VIB.Text = "0";
                    }
                    BEFORE_FLAP = FS_FLAP.Text;
                }));

                Thread.Sleep(100);
            }
        }


        private void FS_GET_SPOILER_VIBRATION()
        {
            while (ACTIVE_FS_SPOILER_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    double IAS_DATA = 0;
                    double VIB_PER = 0;
                    double VIB = 0;
                    IAS_DATA = double.Parse(FS_IAS.Text);

                    if (IAS_DATA < 80)
                    {
                        VIB_PER = 0;
                    }
                    else if (IAS_DATA < 180)
                    {
                        VIB_PER = (IAS_DATA - 80) / 100;
                        if (VIB_PER > 1) VIB_PER = 1;
                    }
                    else
                    {
                        VIB_PER = 1;
                    }


                    if (double.Parse(FS_SPOILER_L.Text) > 0 || double.Parse(FS_SPOILER_R.Text) > 0)
                    {

                        double VIB1 = (255 * double.Parse(FS_SPOILER_L.Text)) * VIB_PER;
                        double VIB2 = (255 * double.Parse(FS_SPOILER_R.Text)) * VIB_PER;

                        if (VIB1 >= VIB2)
                        {
                            VIB = VIB1;
                        }
                        else
                        {
                            VIB = VIB2;
                        }
                        int VIB_INT = Convert.ToInt32(VIB);
                        FS_SPOILER_VIB.Text = VIB_INT.ToString();

                    }
                    else
                    {
                        FS_SPOILER_VIB.Text = "0";
                    }


                }));
                Thread.Sleep(100);
            }
        }

        private void FS_GET_WARNING_VIBRATION()
        {
            while (ACTIVE_FS_WARNING_THREAD)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    if (FS_STALL.Text == "True")
                    {
                        FS_STALL_VIB.Text = "255";
                    }
                    else
                    {
                        FS_STALL_VIB.Text = "0";
                    }


                    if (FS_OVERSPEED.Text == "True")
                    {
                        FS_OVERSPEED_VIB.Text = "255";
                    }
                    else
                    {
                        FS_OVERSPEED_VIB.Text = "0";
                    }

                }));

                Thread.Sleep(100);
            }
        }


        private void vib_timer4_Tick(object sender, EventArgs e)
        {

            double[] VIBRATION = new double[11];

            if (double.Parse(FS_ACC_VIB.Text) * (double.Parse(FS_ACC_VIB_PER.Text) / 100) > 255)
            {
                FS_ACC_VIB_OUT.Text = "255";
            }
            else
            {
                if (double.Parse(FS_ACC_VIB.Text) > double.Parse(FS_ACC_VIB_MIN.Text))
                {
                    FS_ACC_VIB_OUT.Text = (double.Parse(FS_ACC_VIB.Text) * (double.Parse(FS_ACC_VIB_PER.Text) / 100)).ToString();
                }
                else
                {
                    FS_ACC_VIB_OUT.Text = "0";
                }
            }

            if (double.Parse(FS_AOA_VIB.Text) * (double.Parse(FS_AOA_VIB_PER.Text) / 100) > 255)
            {
                FS_AOA_VIB_OUT.Text = "255";
            }
            else
            {
                FS_AOA_VIB_OUT.Text = (double.Parse(FS_AOA_VIB.Text) * (double.Parse(FS_AOA_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FS_GEAR_VIB.Text) * (double.Parse(FS_GEAR_VIB_PER.Text) / 100) > 255)
            {
                FS_GEAR_VIB_OUT.Text = "255";
            }
            else
            {
                FS_GEAR_VIB_OUT.Text = (double.Parse(FS_GEAR_VIB.Text) * (double.Parse(FS_GEAR_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FS_FLAP_VIB.Text) * (double.Parse(FS_FLAP_VIB_PER.Text) / 100) > 255)
            {
                FS_FLAP_VIB_OUT.Text = "255";
            }
            else
            {
                FS_FLAP_VIB_OUT.Text = (double.Parse(FS_FLAP_VIB.Text) * (double.Parse(FS_FLAP_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FS_SPOILER_VIB.Text) * (double.Parse(FS_SPOILER_VIB_PER.Text) / 100) > 255)
            {
                FS_SPOILER_VIB_OUT.Text = "255";
            }
            else
            {
                FS_SPOILER_VIB_OUT.Text = (double.Parse(FS_SPOILER_VIB.Text) * (double.Parse(FS_SPOILER_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FS_STALL_VIB.Text) * (double.Parse(FS_STALL_VIB_PER.Text) / 100) > 255)
            {
                FS_STALL_VIB_OUT.Text = "255";
            }
            else
            {
                FS_STALL_VIB_OUT.Text = (double.Parse(FS_STALL_VIB.Text) * (double.Parse(FS_STALL_VIB_PER.Text) / 100)).ToString();
            }

            if (double.Parse(FS_OVERSPEED_VIB.Text) * (double.Parse(FS_OVERSPEED_VIB_PER.Text) / 100) > 255)
            {
                FS_OVERSPEED_VIB_OUT.Text = "255";
            }
            else
            {
                FS_OVERSPEED_VIB_OUT.Text = (double.Parse(FS_OVERSPEED_VIB.Text) * (double.Parse(FS_OVERSPEED_VIB_PER.Text) / 100)).ToString();
            }

            if (FS_ACC_CHK.Checked == true) VIBRATION[0] = double.Parse(FS_ACC_VIB_OUT.Text); else VIBRATION[0] = 0;
            if (FS_AOA_CHK.Checked == true) VIBRATION[1] = double.Parse(FS_AOA_VIB_OUT.Text); else VIBRATION[1] = 0;
            if (FS_GEAR_CHK.Checked == true) VIBRATION[2] = double.Parse(FS_GEAR_VIB_OUT.Text); else VIBRATION[2] = 0;
            if (FS_FLAP_CHK.Checked == true) VIBRATION[3] = double.Parse(FS_FLAP_VIB_OUT.Text); else VIBRATION[3] = 0;
            if (FS_SPOILER_CHK.Checked == true) VIBRATION[4] = double.Parse(FS_SPOILER_VIB_OUT.Text); else VIBRATION[4] = 0;
            if (FS_STALL_CHK.Checked == true) VIBRATION[5] = double.Parse(FS_STALL_VIB_OUT.Text); else VIBRATION[5] = 0;
            if (FS_OVERSPEED_CHK.Checked == true) VIBRATION[6] = double.Parse(FS_OVERSPEED_VIB_OUT.Text); else VIBRATION[6] = 0;

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("V" + VIBRATION.Max().ToString());
                FS_VIB_OUT.Text = VIBRATION.Max().ToString();
            }
        }

        private void DEFAULT_SETUP_FS_Click(object sender, EventArgs e)
        {
            FS_ACC_VIB_MIN.Text = "1";
            FS_ACC_CHK.Checked = true;
            FS_AOA_CHK.Checked = true;
            FS_GEAR_CHK.Checked = true;
            FS_FLAP_CHK.Checked = true;
            FS_SPOILER_CHK.Checked = true;
            FS_STALL_CHK.Checked = true;
            FS_OVERSPEED_CHK.Checked = true;

            FS_ACC_VIB_PER.Text = "100";
            FS_AOA_VIB_PER.Text = "100";
            FS_GEAR_VIB_PER.Text = "100";
            FS_FLAP_VIB_PER.Text = "100";
            FS_SPOILER_VIB_PER.Text = "100";
            FS_STALL_VIB_PER.Text = "100";
            FS_OVERSPEED_VIB_PER.Text = "100";

            FS_AOA_S_COMBO.Text = "13";
            FS_AOA_M_COMBO.Text = "25";
        }

        private void LOAD_INI_MSFS2020(string INI_DATA)
        {
            string[] ini_data = INI_DATA.Split(',');
            FS_AOA_S_COMBO.Text = ini_data[0];
            FS_AOA_M_COMBO.Text = ini_data[1];

            if (ini_data[2] == "1") FS_ACC_CHK.Checked = true; else FS_ACC_CHK.Checked = false;
            FS_ACC_VIB_PER.Text = ini_data[3];
            if (ini_data[4] == "1") FS_AOA_CHK.Checked = true; else FS_AOA_CHK.Checked = false;
            FS_AOA_VIB_PER.Text = ini_data[5];
            if (ini_data[6] == "1") FS_GEAR_CHK.Checked = true; else FS_GEAR_CHK.Checked = false;
            FS_GEAR_VIB_PER.Text = ini_data[7];
            if (ini_data[8] == "1") FS_FLAP_CHK.Checked = true; else FS_FLAP_CHK.Checked = false;
            FS_FLAP_VIB_PER.Text = ini_data[9];
            if (ini_data[10] == "1") FS_SPOILER_CHK.Checked = true; else FS_SPOILER_CHK.Checked = false;
            FS_SPOILER_VIB_PER.Text = ini_data[11];
            if (ini_data[12] == "1") FS_STALL_CHK.Checked = true; else FS_STALL_CHK.Checked = false;
            FS_STALL_VIB_PER.Text = ini_data[13];
            if (ini_data[14] == "1") FS_OVERSPEED_CHK.Checked = true; else FS_OVERSPEED_CHK.Checked = false;
            FS_OVERSPEED_VIB_PER.Text = ini_data[15];
            FS_ACC_VIB_MIN.Text = ini_data[16];
        }


        private void SAVE_INI_MSFS2020()
        {
            string ini_data = null;

            ini_data += FS_AOA_S_COMBO.Text + "," + FS_AOA_M_COMBO.Text + ",";
            if (FS_ACC_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FS_ACC_VIB_PER.Text + ",";
            if (FS_AOA_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FS_AOA_VIB_PER.Text + ",";
            if (FS_GEAR_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FS_GEAR_VIB_PER.Text + ",";
            if (FS_FLAP_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FS_FLAP_VIB_PER.Text + ",";
            if (FS_SPOILER_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FS_SPOILER_VIB_PER.Text + ",";
            if (FS_STALL_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FS_STALL_VIB_PER.Text + ",";
            if (FS_OVERSPEED_CHK.Checked == true) ini_data += "1,"; else ini_data += "0,";
            ini_data += FS_OVERSPEED_VIB_PER.Text + ",";
            ini_data += FS_ACC_VIB_MIN.Text;

            WritePrivateProfileString("MSFS2020", "VIB_SETUP", ini_data, System.IO.Path.GetDirectoryName(path) + "\\Setup.ini");
        }

        private void FS_ACC_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_AOA_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_GEAR_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_FLAP_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_SPOILER_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_STALL_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_OVERSPEED_CHK_CheckedChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_ACC_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_AOA_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_GEAR_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_FLAP_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_SPOILER_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_STALL_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_OVERSPEED_VIB_PER_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_ACC_VIB_MIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_AOA_S_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }

        private void FS_AOA_M_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            SAVE_INI_MSFS2020();
        }
    }
}