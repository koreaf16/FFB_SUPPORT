namespace FFB_SUPPORT
{
    partial class FFB_SUPPORT
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFB_SUPPORT));
            this.joypos_timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uploadProgressBar = new System.Windows.Forms.ProgressBar();
            this.uLoadFirmware = new System.Windows.Forms.Button();
            this.detectPorts = new System.Windows.Forms.Button();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.getpos_timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FFB = new System.Windows.Forms.TabPage();
            this.TrimGroup = new System.Windows.Forms.GroupBox();
            this.Del_Reset_Trim_key = new System.Windows.Forms.Button();
            this.Del_Trim_key = new System.Windows.Forms.Button();
            this.Reset_Trim_key_label = new System.Windows.Forms.Label();
            this.Reset_Trim_key = new System.Windows.Forms.Button();
            this.Trim_key_label = new System.Windows.Forms.Label();
            this.Trim_key = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Connect = new System.Windows.Forms.Button();
            this.JoyCombo = new System.Windows.Forms.ComboBox();
            this.guid = new System.Windows.Forms.Label();
            this.Setup = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Dbar_label = new System.Windows.Forms.Label();
            this.Dbar = new System.Windows.Forms.TrackBar();
            this.SetCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mbar_label = new System.Windows.Forms.Label();
            this.Vbar_label = new System.Windows.Forms.Label();
            this.Mbar = new System.Windows.Forms.TrackBar();
            this.Vbar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.x_axis_offset = new System.Windows.Forms.Label();
            this.y_axis_offset = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.X_VIB_M = new System.Windows.Forms.Label();
            this.Y_VIB_M = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.X_AXIS = new System.Windows.Forms.Label();
            this.Y_AXIS = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.X_FOS = new System.Windows.Forms.Label();
            this.X_VIB = new System.Windows.Forms.Label();
            this.Y_VIB = new System.Windows.Forms.Label();
            this.Y_FOS = new System.Windows.Forms.Label();
            this.DCS = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.VIB_OUT = new System.Windows.Forms.Label();
            this.Groupbox10 = new System.Windows.Forms.GroupBox();
            this.HELI_VIB_OUT = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.HELI_VIB_PER = new System.Windows.Forms.ComboBox();
            this.HELI_CHK = new System.Windows.Forms.CheckBox();
            this.HELI_VIB = new System.Windows.Forms.Label();
            this.PANEL_VIB_MIN = new System.Windows.Forms.ComboBox();
            this.label90 = new System.Windows.Forms.Label();
            this.ACC_VIB_MIN = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.DEFAULT_SETUP = new System.Windows.Forms.Button();
            this.PAYLOAD_VIB_OUT = new System.Windows.Forms.Label();
            this.CHAFF_VIB_OUT = new System.Windows.Forms.Label();
            this.FLARE_VIB_OUT = new System.Windows.Forms.Label();
            this.GUN_VIB_OUT = new System.Windows.Forms.Label();
            this.SPDBREAK_VIB_OUT = new System.Windows.Forms.Label();
            this.AOA_VIB_OUT = new System.Windows.Forms.Label();
            this.PANEL_VIB_OUT = new System.Windows.Forms.Label();
            this.GEAR_VIB_OUT = new System.Windows.Forms.Label();
            this.ACC_VIB_OUT = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.PAYLOAD_VIB_PER = new System.Windows.Forms.ComboBox();
            this.CHAFF_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FLARE_VIB_PER = new System.Windows.Forms.ComboBox();
            this.GUN_VIB_PER = new System.Windows.Forms.ComboBox();
            this.GEAR_VIB_PER = new System.Windows.Forms.ComboBox();
            this.SPDBREAK_VIB_PER = new System.Windows.Forms.ComboBox();
            this.AOA_VIB_PER = new System.Windows.Forms.ComboBox();
            this.PANEL_VIB_PER = new System.Windows.Forms.ComboBox();
            this.ACC_VIB_PER = new System.Windows.Forms.ComboBox();
            this.AOA_M_COMBO = new System.Windows.Forms.ComboBox();
            this.AOA_S_COMBO = new System.Windows.Forms.ComboBox();
            this.PLANE_LIST_COMBO = new System.Windows.Forms.ComboBox();
            this.PAYLOAD_CHK = new System.Windows.Forms.CheckBox();
            this.CHAFF_CHK = new System.Windows.Forms.CheckBox();
            this.FLARE_CHK = new System.Windows.Forms.CheckBox();
            this.GUN_CHK = new System.Windows.Forms.CheckBox();
            this.GEAR_CHK = new System.Windows.Forms.CheckBox();
            this.SPDBREAK_CHK = new System.Windows.Forms.CheckBox();
            this.AOA_CHK = new System.Windows.Forms.CheckBox();
            this.PANEL_CHK = new System.Windows.Forms.CheckBox();
            this.ACC_CHK = new System.Windows.Forms.CheckBox();
            this.PAYLOAD_VIB = new System.Windows.Forms.Label();
            this.CHAFF_VIB = new System.Windows.Forms.Label();
            this.FLARE_VIB = new System.Windows.Forms.Label();
            this.GUN_VIB = new System.Windows.Forms.Label();
            this.SPDBREAK_VIB = new System.Windows.Forms.Label();
            this.AOA_VIB = new System.Windows.Forms.Label();
            this.PANEL_VIB = new System.Windows.Forms.Label();
            this.GEAR_VIB = new System.Windows.Forms.Label();
            this.ACC_VIB = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.DCS_IAS = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.DCS_ENG_2 = new System.Windows.Forms.Label();
            this.DCS_ENG_1 = new System.Windows.Forms.Label();
            this.DCS_PANEL_5 = new System.Windows.Forms.Label();
            this.DCS_PANEL_4 = new System.Windows.Forms.Label();
            this.DCS_PANEL_3 = new System.Windows.Forms.Label();
            this.DCS_PANEL_2 = new System.Windows.Forms.Label();
            this.DCS_PANEL_1 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.DCS_PAYLOAD = new System.Windows.Forms.Label();
            this.DCS_CHAFF = new System.Windows.Forms.Label();
            this.DCS_FLARE = new System.Windows.Forms.Label();
            this.DCS_SPDBREAK = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.DCS_GEAR = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DCS_GUN = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DCS_PLANE_NAME = new System.Windows.Forms.Label();
            this.DCS_ACCS_Z = new System.Windows.Forms.Label();
            this.DCS_ACCS_X = new System.Windows.Forms.Label();
            this.DCS_ACCS_Y = new System.Windows.Forms.Label();
            this.DCS_AOA = new System.Windows.Forms.Label();
            this.Connect_DCS = new System.Windows.Forms.Button();
            this.FALCON = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.FALCON_VIB_OUT = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.FALCON_YAW_VIB_MIN = new System.Windows.Forms.ComboBox();
            this.FALCON_ROLL_VIB_MIN = new System.Windows.Forms.ComboBox();
            this.label93 = new System.Windows.Forms.Label();
            this.FALCON_PITCH_VIB_MIN = new System.Windows.Forms.ComboBox();
            this.FALCON_ROLL_VIB_OUT = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.FALCON_ROLL_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FALCON_ROLL_CHK = new System.Windows.Forms.CheckBox();
            this.FALCON_ROLL_VIB = new System.Windows.Forms.Label();
            this.FALCON_PITCH_VIB_OUT = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.FALCON_PITCH_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FALCON_PITCH_CHK = new System.Windows.Forms.CheckBox();
            this.FALCON_PITCH_VIB = new System.Windows.Forms.Label();
            this.FALCON_DAMAGE_VIB_OUT = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.FALCON_DAMAGE_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FALCON_DAMAGE_CHK = new System.Windows.Forms.CheckBox();
            this.FALCON_DAMAGE_VIB = new System.Windows.Forms.Label();
            this.FALCON_CHFL_VIB_OUT = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.FALCON_CHFL_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FALCON_CHFL_CHK = new System.Windows.Forms.CheckBox();
            this.FALCON_CHFL_VIB = new System.Windows.Forms.Label();
            this.FALCON_AIRBREAK_VIB_OUT = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.FALCON_AIRBREAK_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FALCON_AIRBREAK_CHK = new System.Windows.Forms.CheckBox();
            this.FALCON_AIRBREAK_VIB = new System.Windows.Forms.Label();
            this.FALCON_GEAR_VIB_OUT = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.FALCON_GEAR_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FALCON_GEAR_CHK = new System.Windows.Forms.CheckBox();
            this.FALCON_GEAR_VIB = new System.Windows.Forms.Label();
            this.FALCON_PAYLOAD_VIB_OUT = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.FALCON_PAYLOAD_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FALCON_PAYLOAD_CHK = new System.Windows.Forms.CheckBox();
            this.FALCON_PAYLOAD_VIB = new System.Windows.Forms.Label();
            this.FALCON_GUN_VIB_OUT = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.FALCON_GUN_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FALCON_GUN_CHK = new System.Windows.Forms.CheckBox();
            this.FALCON_GUN_VIB = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.DEFAULT_SETUP_FALCON = new System.Windows.Forms.Button();
            this.FALCON_BUNNER_VIB_OUT = new System.Windows.Forms.Label();
            this.FALCON_AOA_VIB_OUT = new System.Windows.Forms.Label();
            this.FALCON_YAW_VIB_OUT = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.FALCON_BUNNER_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FALCON_AOA_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FALCON_YAW_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FALCON_AOA_M_COMBO = new System.Windows.Forms.ComboBox();
            this.FALCON_AOA_S_COMBO = new System.Windows.Forms.ComboBox();
            this.FALCON_BUNNER_CHK = new System.Windows.Forms.CheckBox();
            this.FALCON_AOA_CHK = new System.Windows.Forms.CheckBox();
            this.FALCON_YAW_CHK = new System.Windows.Forms.CheckBox();
            this.FALCON_BUNNER_VIB = new System.Windows.Forms.Label();
            this.FALCON_AOA_VIB = new System.Windows.Forms.Label();
            this.FALCON_YAW_VIB = new System.Windows.Forms.Label();
            this.Connect_FALCON = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label97 = new System.Windows.Forms.Label();
            this.FALCON_INGAME = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.FALCON_DAMAGE = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.FALCON_IAS = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.FALCON_NOZZLE = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.FALCON_FLARE = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.FALCON_CHAFF = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.FALCON_BOMB = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.FALCON_AG = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.FALCON_DAMAGE_F = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.FALCON_AA = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.FALCON_FIREGUN = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.FALCON_AOA = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.FALCON_BREAK = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.FALCON_GEAR = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.FALCON_X = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.FALCON_Y = new System.Windows.Forms.Label();
            this.FALCON_Z = new System.Windows.Forms.Label();
            this.WARTHUNDER = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.WT_VIB_OUT = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.WT_WX_VIB_MIN = new System.Windows.Forms.ComboBox();
            this.WT_NY_VIB_MIN = new System.Windows.Forms.ComboBox();
            this.label94 = new System.Windows.Forms.Label();
            this.WT_AOS_VIB_MIN = new System.Windows.Forms.ComboBox();
            this.WT_WEP_VIB_OUT = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.WT_WEP_VIB_PER = new System.Windows.Forms.ComboBox();
            this.WT_WEP_CHK = new System.Windows.Forms.CheckBox();
            this.WT_WEP_VIB = new System.Windows.Forms.Label();
            this.WT_GUN_VIB_OUT = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.WT_GUN_VIB_PER = new System.Windows.Forms.ComboBox();
            this.WT_GUN_CHK = new System.Windows.Forms.CheckBox();
            this.WT_GUN_VIB = new System.Windows.Forms.Label();
            this.WT_AIRBREAK_VIB_OUT = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.WT_AIRBREAK_VIB_PER = new System.Windows.Forms.ComboBox();
            this.WT_AIRBREAK_CHK = new System.Windows.Forms.CheckBox();
            this.WT_AIRBREAK_VIB = new System.Windows.Forms.Label();
            this.WT_GEAR_VIB_OUT = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.WT_GEAR_VIB_PER = new System.Windows.Forms.ComboBox();
            this.WT_GEAR_CHK = new System.Windows.Forms.CheckBox();
            this.WT_GEAR_VIB = new System.Windows.Forms.Label();
            this.WT_FLAP_VIB_OUT = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.WT_FLAP_VIB_PER = new System.Windows.Forms.ComboBox();
            this.WT_FLAP_CHK = new System.Windows.Forms.CheckBox();
            this.WT_FLAP_VIB = new System.Windows.Forms.Label();
            this.WT_AOA_VIB_OUT = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.WT_AOA_VIB_PER = new System.Windows.Forms.ComboBox();
            this.WT_AOA_CHK = new System.Windows.Forms.CheckBox();
            this.WT_AOA_VIB = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.DEFAULT_SETUP_WT = new System.Windows.Forms.Button();
            this.WT_WX_VIB_OUT = new System.Windows.Forms.Label();
            this.WT_NY_VIB_OUT = new System.Windows.Forms.Label();
            this.WT_AOS_VIB_OUT = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.WT_WX_VIB_PER = new System.Windows.Forms.ComboBox();
            this.WT_NY_VIB_PER = new System.Windows.Forms.ComboBox();
            this.WT_AOS_VIB_PER = new System.Windows.Forms.ComboBox();
            this.WT_AOA_M_COMBO = new System.Windows.Forms.ComboBox();
            this.WT_AOA_S_COMBO = new System.Windows.Forms.ComboBox();
            this.PLANE_LIST_COMBO_WT = new System.Windows.Forms.ComboBox();
            this.WT_WX_CHK = new System.Windows.Forms.CheckBox();
            this.WT_NY_CHK = new System.Windows.Forms.CheckBox();
            this.WT_AOS_CHK = new System.Windows.Forms.CheckBox();
            this.WT_WX_VIB = new System.Windows.Forms.Label();
            this.WT_NY_VIB = new System.Windows.Forms.Label();
            this.WT_AOS_VIB = new System.Windows.Forms.Label();
            this.Connect_WT = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.WT_WX = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.WT_AIRBREAK = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.WT_FLAP = new System.Windows.Forms.Label();
            this.WT_GEAR = new System.Windows.Forms.Label();
            this.WT_WEAPON3 = new System.Windows.Forms.Label();
            this.WT_WEAPON1 = new System.Windows.Forms.Label();
            this.WT_WEAPON2 = new System.Windows.Forms.Label();
            this.WT_THROTTLE2 = new System.Windows.Forms.Label();
            this.WT_THROTTLE1 = new System.Windows.Forms.Label();
            this.WT_NY = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.WT_AOS = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.WT_PLANE_NAME = new System.Windows.Forms.Label();
            this.WT_AOA = new System.Windows.Forms.Label();
            this.WT_IAS = new System.Windows.Forms.Label();
            this.WT_TAS = new System.Windows.Forms.Label();
            this.FS2020 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.FS_VIB_OUT = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label106 = new System.Windows.Forms.Label();
            this.FS_ACC_VIB_MIN = new System.Windows.Forms.ComboBox();
            this.FS_AOA_VIB_OUT = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.FS_AOA_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FS_AOA_CHK = new System.Windows.Forms.CheckBox();
            this.FS_AOA_VIB = new System.Windows.Forms.Label();
            this.FS_ACC_VIB_OUT = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.FS_ACC_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FS_ACC_CHK = new System.Windows.Forms.CheckBox();
            this.FS_ACC_VIB = new System.Windows.Forms.Label();
            this.FS_OVERSPEED_VIB_OUT = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.FS_OVERSPEED_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FS_OVERSPEED_CHK = new System.Windows.Forms.CheckBox();
            this.FS_OVERSPEED_VIB = new System.Windows.Forms.Label();
            this.FS_STALL_VIB_OUT = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.FS_STALL_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FS_STALL_CHK = new System.Windows.Forms.CheckBox();
            this.FS_STALL_VIB = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.DEFAULT_SETUP_FS = new System.Windows.Forms.Button();
            this.FS_SPOILER_VIB_OUT = new System.Windows.Forms.Label();
            this.FS_FLAP_VIB_OUT = new System.Windows.Forms.Label();
            this.FS_GEAR_VIB_OUT = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.FS_SPOILER_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FS_FLAP_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FS_GEAR_VIB_PER = new System.Windows.Forms.ComboBox();
            this.FS_AOA_M_COMBO = new System.Windows.Forms.ComboBox();
            this.FS_AOA_S_COMBO = new System.Windows.Forms.ComboBox();
            this.FS_SPOILER_CHK = new System.Windows.Forms.CheckBox();
            this.FS_FLAP_CHK = new System.Windows.Forms.CheckBox();
            this.FS_GEAR_CHK = new System.Windows.Forms.CheckBox();
            this.FS_SPOILER_VIB = new System.Windows.Forms.Label();
            this.FS_FLAP_VIB = new System.Windows.Forms.Label();
            this.FS_GEAR_VIB = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.FS_OVERSPEED = new System.Windows.Forms.Label();
            this.FS_STALL = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.FS_FLAP = new System.Windows.Forms.Label();
            this.FS_GEAR = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.FS_AOA = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.FS_SPOILER_R = new System.Windows.Forms.Label();
            this.FS_IAS = new System.Windows.Forms.Label();
            this.FS_SPOILER_L = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.FS_PLANE_NAME = new System.Windows.Forms.Label();
            this.FS_ACC_Z = new System.Windows.Forms.Label();
            this.FS_ACC_X = new System.Windows.Forms.Label();
            this.FS_ACC_Y = new System.Windows.Forms.Label();
            this.Connect_FS2020 = new System.Windows.Forms.Button();
            this.vib_timer1 = new System.Windows.Forms.Timer(this.components);
            this.vib_timer2 = new System.Windows.Forms.Timer(this.components);
            this.Power_Check = new System.Windows.Forms.CheckBox();
            this.get_falcon_timer = new System.Windows.Forms.Timer(this.components);
            this.vib_timer3 = new System.Windows.Forms.Timer(this.components);
            this.vib_timer4 = new System.Windows.Forms.Timer(this.components);
            this.get_fs2020_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.FFB.SuspendLayout();
            this.TrimGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Setup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vbar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.DCS.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Groupbox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.FALCON.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.WARTHUNDER.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.FS2020.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // joypos_timer1
            // 
            this.joypos_timer1.Interval = 2;
            this.joypos_timer1.Tick += new System.EventHandler(this.joypos_timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uploadProgressBar);
            this.groupBox1.Controls.Add(this.uLoadFirmware);
            this.groupBox1.Controls.Add(this.detectPorts);
            this.groupBox1.Controls.Add(this.comboPorts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "아두이노";
            // 
            // uploadProgressBar
            // 
            this.uploadProgressBar.Location = new System.Drawing.Point(15, 81);
            this.uploadProgressBar.Name = "uploadProgressBar";
            this.uploadProgressBar.Size = new System.Drawing.Size(435, 15);
            this.uploadProgressBar.TabIndex = 4;
            // 
            // uLoadFirmware
            // 
            this.uLoadFirmware.Location = new System.Drawing.Point(365, 27);
            this.uLoadFirmware.Name = "uLoadFirmware";
            this.uLoadFirmware.Size = new System.Drawing.Size(85, 35);
            this.uLoadFirmware.TabIndex = 3;
            this.uLoadFirmware.Text = "Upload Firmware";
            this.uLoadFirmware.UseVisualStyleBackColor = true;
            this.uLoadFirmware.Click += new System.EventHandler(this.uLoadFirmware_Click);
            // 
            // detectPorts
            // 
            this.detectPorts.Location = new System.Drawing.Point(274, 27);
            this.detectPorts.Name = "detectPorts";
            this.detectPorts.Size = new System.Drawing.Size(85, 35);
            this.detectPorts.TabIndex = 2;
            this.detectPorts.Text = "Detect Ports";
            this.detectPorts.UseVisualStyleBackColor = true;
            this.detectPorts.Click += new System.EventHandler(this.detectPorts_Click);
            // 
            // comboPorts
            // 
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(56, 35);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(212, 20);
            this.comboPorts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DtrEnable = true;
            this.serialPort1.RtsEnable = true;
            // 
            // getpos_timer1
            // 
            this.getpos_timer1.Tick += new System.EventHandler(this.getpos_timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FFB);
            this.tabControl1.Controls.Add(this.DCS);
            this.tabControl1.Controls.Add(this.FALCON);
            this.tabControl1.Controls.Add(this.WARTHUNDER);
            this.tabControl1.Controls.Add(this.FS2020);
            this.tabControl1.Location = new System.Drawing.Point(12, 127);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 700);
            this.tabControl1.TabIndex = 28;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // FFB
            // 
            this.FFB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FFB.Controls.Add(this.TrimGroup);
            this.FFB.Controls.Add(this.groupBox3);
            this.FFB.Controls.Add(this.Setup);
            this.FFB.Controls.Add(this.groupBox2);
            this.FFB.Location = new System.Drawing.Point(4, 22);
            this.FFB.Name = "FFB";
            this.FFB.Padding = new System.Windows.Forms.Padding(3);
            this.FFB.Size = new System.Drawing.Size(463, 674);
            this.FFB.TabIndex = 0;
            this.FFB.Text = "포스피드백";
            // 
            // TrimGroup
            // 
            this.TrimGroup.Controls.Add(this.Del_Reset_Trim_key);
            this.TrimGroup.Controls.Add(this.Del_Trim_key);
            this.TrimGroup.Controls.Add(this.Reset_Trim_key_label);
            this.TrimGroup.Controls.Add(this.Reset_Trim_key);
            this.TrimGroup.Controls.Add(this.Trim_key_label);
            this.TrimGroup.Controls.Add(this.Trim_key);
            this.TrimGroup.Location = new System.Drawing.Point(21, 584);
            this.TrimGroup.Name = "TrimGroup";
            this.TrimGroup.Size = new System.Drawing.Size(425, 76);
            this.TrimGroup.TabIndex = 28;
            this.TrimGroup.TabStop = false;
            this.TrimGroup.Text = "하드웨어트림";
            // 
            // Del_Reset_Trim_key
            // 
            this.Del_Reset_Trim_key.Enabled = false;
            this.Del_Reset_Trim_key.Location = new System.Drawing.Point(316, 45);
            this.Del_Reset_Trim_key.Name = "Del_Reset_Trim_key";
            this.Del_Reset_Trim_key.Size = new System.Drawing.Size(98, 19);
            this.Del_Reset_Trim_key.TabIndex = 30;
            this.Del_Reset_Trim_key.Text = "리셋트림키삭제";
            this.Del_Reset_Trim_key.UseVisualStyleBackColor = true;
            this.Del_Reset_Trim_key.Click += new System.EventHandler(this.Del_Reset_Trim_key_Click);
            // 
            // Del_Trim_key
            // 
            this.Del_Trim_key.Enabled = false;
            this.Del_Trim_key.Location = new System.Drawing.Point(316, 20);
            this.Del_Trim_key.Name = "Del_Trim_key";
            this.Del_Trim_key.Size = new System.Drawing.Size(98, 19);
            this.Del_Trim_key.TabIndex = 29;
            this.Del_Trim_key.Text = "트림키삭제";
            this.Del_Trim_key.UseVisualStyleBackColor = true;
            this.Del_Trim_key.Click += new System.EventHandler(this.Del_Trim_key_Click);
            // 
            // Reset_Trim_key_label
            // 
            this.Reset_Trim_key_label.Location = new System.Drawing.Point(115, 45);
            this.Reset_Trim_key_label.Name = "Reset_Trim_key_label";
            this.Reset_Trim_key_label.Size = new System.Drawing.Size(195, 19);
            this.Reset_Trim_key_label.TabIndex = 28;
            this.Reset_Trim_key_label.Text = "설정값 없음";
            // 
            // Reset_Trim_key
            // 
            this.Reset_Trim_key.Enabled = false;
            this.Reset_Trim_key.Location = new System.Drawing.Point(14, 45);
            this.Reset_Trim_key.Name = "Reset_Trim_key";
            this.Reset_Trim_key.Size = new System.Drawing.Size(87, 19);
            this.Reset_Trim_key.TabIndex = 27;
            this.Reset_Trim_key.Text = "리셋트림키";
            this.Reset_Trim_key.UseVisualStyleBackColor = true;
            this.Reset_Trim_key.Click += new System.EventHandler(this.Reset_Trim_key_Click);
            // 
            // Trim_key_label
            // 
            this.Trim_key_label.Location = new System.Drawing.Point(115, 23);
            this.Trim_key_label.Name = "Trim_key_label";
            this.Trim_key_label.Size = new System.Drawing.Size(195, 19);
            this.Trim_key_label.TabIndex = 26;
            this.Trim_key_label.Text = "설정값 없음";
            // 
            // Trim_key
            // 
            this.Trim_key.Enabled = false;
            this.Trim_key.Location = new System.Drawing.Point(14, 20);
            this.Trim_key.Name = "Trim_key";
            this.Trim_key.Size = new System.Drawing.Size(87, 19);
            this.Trim_key.TabIndex = 25;
            this.Trim_key.Text = "트림";
            this.Trim_key.UseVisualStyleBackColor = true;
            this.Trim_key.Click += new System.EventHandler(this.Trim_key_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Connect);
            this.groupBox3.Controls.Add(this.JoyCombo);
            this.groupBox3.Controls.Add(this.guid);
            this.groupBox3.Location = new System.Drawing.Point(22, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 79);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "조이스틱";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(329, 20);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(84, 44);
            this.Connect.TabIndex = 31;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // JoyCombo
            // 
            this.JoyCombo.FormattingEnabled = true;
            this.JoyCombo.Location = new System.Drawing.Point(13, 20);
            this.JoyCombo.Name = "JoyCombo";
            this.JoyCombo.Size = new System.Drawing.Size(196, 20);
            this.JoyCombo.TabIndex = 12;
            this.JoyCombo.SelectedIndexChanged += new System.EventHandler(this.JoyCombo_SelectedIndexChanged);
            // 
            // guid
            // 
            this.guid.AutoSize = true;
            this.guid.Location = new System.Drawing.Point(11, 55);
            this.guid.Name = "guid";
            this.guid.Size = new System.Drawing.Size(0, 12);
            this.guid.TabIndex = 14;
            // 
            // Setup
            // 
            this.Setup.Controls.Add(this.label42);
            this.Setup.Controls.Add(this.label41);
            this.Setup.Controls.Add(this.label40);
            this.Setup.Controls.Add(this.label14);
            this.Setup.Controls.Add(this.Dbar_label);
            this.Setup.Controls.Add(this.Dbar);
            this.Setup.Controls.Add(this.SetCombo);
            this.Setup.Controls.Add(this.label4);
            this.Setup.Controls.Add(this.label3);
            this.Setup.Controls.Add(this.label2);
            this.Setup.Controls.Add(this.Mbar_label);
            this.Setup.Controls.Add(this.Vbar_label);
            this.Setup.Controls.Add(this.Mbar);
            this.Setup.Controls.Add(this.Vbar);
            this.Setup.Location = new System.Drawing.Point(22, 265);
            this.Setup.Name = "Setup";
            this.Setup.Size = new System.Drawing.Size(424, 313);
            this.Setup.TabIndex = 4;
            this.Setup.TabStop = false;
            this.Setup.Text = "설정";
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(278, 29);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(141, 14);
            this.label42.TabIndex = 17;
            this.label42.Text = "권장값";
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(278, 70);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(141, 14);
            this.label41.TabIndex = 16;
            this.label41.Text = "IL-2 : 최소 1, 최대 200";
            // 
            // label40
            // 
            this.label40.Location = new System.Drawing.Point(278, 52);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(141, 14);
            this.label40.TabIndex = 15;
            this.label40.Text = "DCS : 최소 1, 최대 6000";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(14, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 21);
            this.label14.TabIndex = 14;
            this.label14.Text = "진동이 최대가 되는 진폭";
            // 
            // Dbar_label
            // 
            this.Dbar_label.Location = new System.Drawing.Point(335, 256);
            this.Dbar_label.Name = "Dbar_label";
            this.Dbar_label.Size = new System.Drawing.Size(43, 15);
            this.Dbar_label.TabIndex = 13;
            this.Dbar_label.Text = "0";
            // 
            // Dbar
            // 
            this.Dbar.Enabled = false;
            this.Dbar.LargeChange = 1000;
            this.Dbar.Location = new System.Drawing.Point(15, 256);
            this.Dbar.Maximum = 10000;
            this.Dbar.Minimum = 100;
            this.Dbar.Name = "Dbar";
            this.Dbar.Size = new System.Drawing.Size(313, 45);
            this.Dbar.TabIndex = 12;
            this.Dbar.Value = 1000;
            this.Dbar.Scroll += new System.EventHandler(this.Dbar_Scroll);
            // 
            // SetCombo
            // 
            this.SetCombo.Enabled = false;
            this.SetCombo.FormattingEnabled = true;
            this.SetCombo.Location = new System.Drawing.Point(102, 44);
            this.SetCombo.Name = "SetCombo";
            this.SetCombo.Size = new System.Drawing.Size(151, 20);
            this.SetCombo.TabIndex = 5;
            this.SetCombo.SelectedIndexChanged += new System.EventHandler(this.SetCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "진동적용범위";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "진동이 시작되는 최소진폭";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "진폭 배수";
            // 
            // Mbar_label
            // 
            this.Mbar_label.Location = new System.Drawing.Point(334, 100);
            this.Mbar_label.Name = "Mbar_label";
            this.Mbar_label.Size = new System.Drawing.Size(43, 10);
            this.Mbar_label.TabIndex = 8;
            this.Mbar_label.Text = "0";
            // 
            // Vbar_label
            // 
            this.Vbar_label.Location = new System.Drawing.Point(335, 165);
            this.Vbar_label.Name = "Vbar_label";
            this.Vbar_label.Size = new System.Drawing.Size(43, 15);
            this.Vbar_label.TabIndex = 7;
            this.Vbar_label.Text = "0";
            // 
            // Mbar
            // 
            this.Mbar.Enabled = false;
            this.Mbar.LargeChange = 1;
            this.Mbar.Location = new System.Drawing.Point(15, 100);
            this.Mbar.Minimum = 1;
            this.Mbar.Name = "Mbar";
            this.Mbar.Size = new System.Drawing.Size(313, 45);
            this.Mbar.TabIndex = 6;
            this.Mbar.Value = 1;
            this.Mbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Vbar
            // 
            this.Vbar.Enabled = false;
            this.Vbar.LargeChange = 100;
            this.Vbar.Location = new System.Drawing.Point(15, 165);
            this.Vbar.Maximum = 765;
            this.Vbar.Minimum = 1;
            this.Vbar.Name = "Vbar";
            this.Vbar.Size = new System.Drawing.Size(313, 45);
            this.Vbar.TabIndex = 5;
            this.Vbar.Value = 2;
            this.Vbar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.x_axis_offset);
            this.groupBox2.Controls.Add(this.y_axis_offset);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.X_VIB_M);
            this.groupBox2.Controls.Add(this.Y_VIB_M);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.X_AXIS);
            this.groupBox2.Controls.Add(this.Y_AXIS);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.X_FOS);
            this.groupBox2.Controls.Add(this.X_VIB);
            this.groupBox2.Controls.Add(this.Y_VIB);
            this.groupBox2.Controls.Add(this.Y_FOS);
            this.groupBox2.Location = new System.Drawing.Point(22, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 157);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "출력값";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(175, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "조이스틱 Y축 트림";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(175, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "조이스틱 X축 트림";
            // 
            // x_axis_offset
            // 
            this.x_axis_offset.AutoSize = true;
            this.x_axis_offset.Location = new System.Drawing.Point(315, 30);
            this.x_axis_offset.Name = "x_axis_offset";
            this.x_axis_offset.Size = new System.Drawing.Size(11, 12);
            this.x_axis_offset.TabIndex = 19;
            this.x_axis_offset.Text = "0";
            // 
            // y_axis_offset
            // 
            this.y_axis_offset.AutoSize = true;
            this.y_axis_offset.Location = new System.Drawing.Point(315, 47);
            this.y_axis_offset.Name = "y_axis_offset";
            this.y_axis_offset.Size = new System.Drawing.Size(11, 12);
            this.y_axis_offset.TabIndex = 20;
            this.y_axis_offset.Text = "0";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(13, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "조이스틱 Y축";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(13, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "조이스틱 X축";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(175, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "X축 진동 출력값";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(175, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Y축 진동 출력값";
            // 
            // X_VIB_M
            // 
            this.X_VIB_M.Location = new System.Drawing.Point(315, 104);
            this.X_VIB_M.Name = "X_VIB_M";
            this.X_VIB_M.Size = new System.Drawing.Size(62, 17);
            this.X_VIB_M.TabIndex = 9;
            this.X_VIB_M.Text = "0";
            // 
            // Y_VIB_M
            // 
            this.Y_VIB_M.Location = new System.Drawing.Point(315, 121);
            this.Y_VIB_M.Name = "Y_VIB_M";
            this.Y_VIB_M.Size = new System.Drawing.Size(62, 17);
            this.Y_VIB_M.TabIndex = 10;
            this.Y_VIB_M.Text = "0";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "X축 포스";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "X축 진폭";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Y축 진폭";
            // 
            // X_AXIS
            // 
            this.X_AXIS.AutoSize = true;
            this.X_AXIS.Location = new System.Drawing.Point(113, 30);
            this.X_AXIS.Name = "X_AXIS";
            this.X_AXIS.Size = new System.Drawing.Size(11, 12);
            this.X_AXIS.TabIndex = 15;
            this.X_AXIS.Text = "0";
            // 
            // Y_AXIS
            // 
            this.Y_AXIS.AutoSize = true;
            this.Y_AXIS.Location = new System.Drawing.Point(113, 47);
            this.Y_AXIS.Name = "Y_AXIS";
            this.Y_AXIS.Size = new System.Drawing.Size(11, 12);
            this.Y_AXIS.TabIndex = 16;
            this.Y_AXIS.Text = "0";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Y축 포스";
            // 
            // X_FOS
            // 
            this.X_FOS.Location = new System.Drawing.Point(113, 70);
            this.X_FOS.Name = "X_FOS";
            this.X_FOS.Size = new System.Drawing.Size(58, 17);
            this.X_FOS.TabIndex = 0;
            this.X_FOS.Text = "0";
            // 
            // X_VIB
            // 
            this.X_VIB.Location = new System.Drawing.Point(113, 104);
            this.X_VIB.Name = "X_VIB";
            this.X_VIB.Size = new System.Drawing.Size(58, 17);
            this.X_VIB.TabIndex = 3;
            this.X_VIB.Text = "0";
            // 
            // Y_VIB
            // 
            this.Y_VIB.Location = new System.Drawing.Point(113, 121);
            this.Y_VIB.Name = "Y_VIB";
            this.Y_VIB.Size = new System.Drawing.Size(58, 17);
            this.Y_VIB.TabIndex = 4;
            this.Y_VIB.Text = "0";
            // 
            // Y_FOS
            // 
            this.Y_FOS.Location = new System.Drawing.Point(113, 87);
            this.Y_FOS.Name = "Y_FOS";
            this.Y_FOS.Size = new System.Drawing.Size(58, 17);
            this.Y_FOS.TabIndex = 1;
            this.Y_FOS.Text = "0";
            // 
            // DCS
            // 
            this.DCS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DCS.Controls.Add(this.groupBox5);
            this.DCS.Controls.Add(this.Groupbox10);
            this.DCS.Controls.Add(this.groupBox4);
            this.DCS.Controls.Add(this.Connect_DCS);
            this.DCS.Location = new System.Drawing.Point(4, 22);
            this.DCS.Name = "DCS";
            this.DCS.Padding = new System.Windows.Forms.Padding(3);
            this.DCS.Size = new System.Drawing.Size(463, 674);
            this.DCS.TabIndex = 1;
            this.DCS.Text = "DCS";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.VIB_OUT);
            this.groupBox5.Location = new System.Drawing.Point(12, 552);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(432, 78);
            this.groupBox5.TabIndex = 69;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "최종출력";
            // 
            // VIB_OUT
            // 
            this.VIB_OUT.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VIB_OUT.Location = new System.Drawing.Point(15, 29);
            this.VIB_OUT.Name = "VIB_OUT";
            this.VIB_OUT.Size = new System.Drawing.Size(219, 31);
            this.VIB_OUT.TabIndex = 122;
            this.VIB_OUT.Text = "0";
            // 
            // Groupbox10
            // 
            this.Groupbox10.Controls.Add(this.HELI_VIB_OUT);
            this.Groupbox10.Controls.Add(this.label98);
            this.Groupbox10.Controls.Add(this.HELI_VIB_PER);
            this.Groupbox10.Controls.Add(this.HELI_CHK);
            this.Groupbox10.Controls.Add(this.HELI_VIB);
            this.Groupbox10.Controls.Add(this.PANEL_VIB_MIN);
            this.Groupbox10.Controls.Add(this.label90);
            this.Groupbox10.Controls.Add(this.ACC_VIB_MIN);
            this.Groupbox10.Controls.Add(this.label46);
            this.Groupbox10.Controls.Add(this.label45);
            this.Groupbox10.Controls.Add(this.label44);
            this.Groupbox10.Controls.Add(this.label43);
            this.Groupbox10.Controls.Add(this.DEFAULT_SETUP);
            this.Groupbox10.Controls.Add(this.PAYLOAD_VIB_OUT);
            this.Groupbox10.Controls.Add(this.CHAFF_VIB_OUT);
            this.Groupbox10.Controls.Add(this.FLARE_VIB_OUT);
            this.Groupbox10.Controls.Add(this.GUN_VIB_OUT);
            this.Groupbox10.Controls.Add(this.SPDBREAK_VIB_OUT);
            this.Groupbox10.Controls.Add(this.AOA_VIB_OUT);
            this.Groupbox10.Controls.Add(this.PANEL_VIB_OUT);
            this.Groupbox10.Controls.Add(this.GEAR_VIB_OUT);
            this.Groupbox10.Controls.Add(this.ACC_VIB_OUT);
            this.Groupbox10.Controls.Add(this.label39);
            this.Groupbox10.Controls.Add(this.label30);
            this.Groupbox10.Controls.Add(this.label20);
            this.Groupbox10.Controls.Add(this.label21);
            this.Groupbox10.Controls.Add(this.label22);
            this.Groupbox10.Controls.Add(this.label23);
            this.Groupbox10.Controls.Add(this.label24);
            this.Groupbox10.Controls.Add(this.label25);
            this.Groupbox10.Controls.Add(this.label26);
            this.Groupbox10.Controls.Add(this.label27);
            this.Groupbox10.Controls.Add(this.label28);
            this.Groupbox10.Controls.Add(this.PAYLOAD_VIB_PER);
            this.Groupbox10.Controls.Add(this.CHAFF_VIB_PER);
            this.Groupbox10.Controls.Add(this.FLARE_VIB_PER);
            this.Groupbox10.Controls.Add(this.GUN_VIB_PER);
            this.Groupbox10.Controls.Add(this.GEAR_VIB_PER);
            this.Groupbox10.Controls.Add(this.SPDBREAK_VIB_PER);
            this.Groupbox10.Controls.Add(this.AOA_VIB_PER);
            this.Groupbox10.Controls.Add(this.PANEL_VIB_PER);
            this.Groupbox10.Controls.Add(this.ACC_VIB_PER);
            this.Groupbox10.Controls.Add(this.AOA_M_COMBO);
            this.Groupbox10.Controls.Add(this.AOA_S_COMBO);
            this.Groupbox10.Controls.Add(this.PLANE_LIST_COMBO);
            this.Groupbox10.Controls.Add(this.PAYLOAD_CHK);
            this.Groupbox10.Controls.Add(this.CHAFF_CHK);
            this.Groupbox10.Controls.Add(this.FLARE_CHK);
            this.Groupbox10.Controls.Add(this.GUN_CHK);
            this.Groupbox10.Controls.Add(this.GEAR_CHK);
            this.Groupbox10.Controls.Add(this.SPDBREAK_CHK);
            this.Groupbox10.Controls.Add(this.AOA_CHK);
            this.Groupbox10.Controls.Add(this.PANEL_CHK);
            this.Groupbox10.Controls.Add(this.ACC_CHK);
            this.Groupbox10.Controls.Add(this.PAYLOAD_VIB);
            this.Groupbox10.Controls.Add(this.CHAFF_VIB);
            this.Groupbox10.Controls.Add(this.FLARE_VIB);
            this.Groupbox10.Controls.Add(this.GUN_VIB);
            this.Groupbox10.Controls.Add(this.SPDBREAK_VIB);
            this.Groupbox10.Controls.Add(this.AOA_VIB);
            this.Groupbox10.Controls.Add(this.PANEL_VIB);
            this.Groupbox10.Controls.Add(this.GEAR_VIB);
            this.Groupbox10.Controls.Add(this.ACC_VIB);
            this.Groupbox10.Location = new System.Drawing.Point(12, 206);
            this.Groupbox10.Name = "Groupbox10";
            this.Groupbox10.Size = new System.Drawing.Size(432, 340);
            this.Groupbox10.TabIndex = 68;
            this.Groupbox10.TabStop = false;
            this.Groupbox10.Text = "진동출력설정";
            // 
            // HELI_VIB_OUT
            // 
            this.HELI_VIB_OUT.Enabled = false;
            this.HELI_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HELI_VIB_OUT.Location = new System.Drawing.Point(347, 284);
            this.HELI_VIB_OUT.Name = "HELI_VIB_OUT";
            this.HELI_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.HELI_VIB_OUT.TabIndex = 134;
            this.HELI_VIB_OUT.Text = "0";
            // 
            // label98
            // 
            this.label98.Enabled = false;
            this.label98.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label98.Location = new System.Drawing.Point(239, 283);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(15, 15);
            this.label98.TabIndex = 133;
            this.label98.Text = "%";
            // 
            // HELI_VIB_PER
            // 
            this.HELI_VIB_PER.Enabled = false;
            this.HELI_VIB_PER.FormattingEnabled = true;
            this.HELI_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.HELI_VIB_PER.Location = new System.Drawing.Point(180, 279);
            this.HELI_VIB_PER.Name = "HELI_VIB_PER";
            this.HELI_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.HELI_VIB_PER.TabIndex = 132;
            this.HELI_VIB_PER.Text = "100";
            this.HELI_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.HELI_VIB_PER_SelectedIndexChanged);
            // 
            // HELI_CHK
            // 
            this.HELI_CHK.AutoSize = true;
            this.HELI_CHK.Checked = true;
            this.HELI_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HELI_CHK.Enabled = false;
            this.HELI_CHK.Location = new System.Drawing.Point(17, 283);
            this.HELI_CHK.Name = "HELI_CHK";
            this.HELI_CHK.Size = new System.Drawing.Size(104, 16);
            this.HELI_CHK.TabIndex = 131;
            this.HELI_CHK.Text = "유효전이양력 :";
            this.HELI_CHK.UseVisualStyleBackColor = true;
            this.HELI_CHK.CheckedChanged += new System.EventHandler(this.HELI_CHK_CheckedChanged);
            // 
            // HELI_VIB
            // 
            this.HELI_VIB.Enabled = false;
            this.HELI_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HELI_VIB.Location = new System.Drawing.Point(140, 284);
            this.HELI_VIB.Name = "HELI_VIB";
            this.HELI_VIB.Size = new System.Drawing.Size(40, 15);
            this.HELI_VIB.TabIndex = 130;
            this.HELI_VIB.Text = "0";
            // 
            // PANEL_VIB_MIN
            // 
            this.PANEL_VIB_MIN.Enabled = false;
            this.PANEL_VIB_MIN.FormattingEnabled = true;
            this.PANEL_VIB_MIN.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.PANEL_VIB_MIN.Location = new System.Drawing.Point(260, 103);
            this.PANEL_VIB_MIN.Name = "PANEL_VIB_MIN";
            this.PANEL_VIB_MIN.Size = new System.Drawing.Size(53, 20);
            this.PANEL_VIB_MIN.TabIndex = 129;
            this.PANEL_VIB_MIN.Text = "1";
            this.PANEL_VIB_MIN.SelectedIndexChanged += new System.EventHandler(this.PANEL_VIB_MIN_SelectedIndexChanged);
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label90.Location = new System.Drawing.Point(257, 60);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(77, 13);
            this.label90.TabIndex = 128;
            this.label90.Text = "진동시작값";
            // 
            // ACC_VIB_MIN
            // 
            this.ACC_VIB_MIN.Enabled = false;
            this.ACC_VIB_MIN.FormattingEnabled = true;
            this.ACC_VIB_MIN.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.ACC_VIB_MIN.Location = new System.Drawing.Point(260, 81);
            this.ACC_VIB_MIN.Name = "ACC_VIB_MIN";
            this.ACC_VIB_MIN.Size = new System.Drawing.Size(53, 20);
            this.ACC_VIB_MIN.TabIndex = 126;
            this.ACC_VIB_MIN.Text = "1";
            this.ACC_VIB_MIN.SelectedIndexChanged += new System.EventHandler(this.ACC_VIB_MIN_SelectedIndexChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label46.Location = new System.Drawing.Point(346, 60);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(63, 13);
            this.label46.TabIndex = 125;
            this.label46.Text = "최종진동";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label45.Location = new System.Drawing.Point(177, 60);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(63, 13);
            this.label45.TabIndex = 124;
            this.label45.Text = "진동보정";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label44.Location = new System.Drawing.Point(129, 60);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 13);
            this.label44.TabIndex = 123;
            this.label44.Text = "진동";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label43.Location = new System.Drawing.Point(16, 60);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(35, 13);
            this.label43.TabIndex = 122;
            this.label43.Text = "항목";
            // 
            // DEFAULT_SETUP
            // 
            this.DEFAULT_SETUP.Location = new System.Drawing.Point(277, 20);
            this.DEFAULT_SETUP.Name = "DEFAULT_SETUP";
            this.DEFAULT_SETUP.Size = new System.Drawing.Size(144, 22);
            this.DEFAULT_SETUP.TabIndex = 121;
            this.DEFAULT_SETUP.Text = "기본값";
            this.DEFAULT_SETUP.UseVisualStyleBackColor = true;
            this.DEFAULT_SETUP.Click += new System.EventHandler(this.DEFAULT_SETUP_Click);
            // 
            // PAYLOAD_VIB_OUT
            // 
            this.PAYLOAD_VIB_OUT.Enabled = false;
            this.PAYLOAD_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PAYLOAD_VIB_OUT.Location = new System.Drawing.Point(347, 262);
            this.PAYLOAD_VIB_OUT.Name = "PAYLOAD_VIB_OUT";
            this.PAYLOAD_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.PAYLOAD_VIB_OUT.TabIndex = 120;
            this.PAYLOAD_VIB_OUT.Text = "0";
            // 
            // CHAFF_VIB_OUT
            // 
            this.CHAFF_VIB_OUT.Enabled = false;
            this.CHAFF_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CHAFF_VIB_OUT.Location = new System.Drawing.Point(347, 240);
            this.CHAFF_VIB_OUT.Name = "CHAFF_VIB_OUT";
            this.CHAFF_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.CHAFF_VIB_OUT.TabIndex = 117;
            this.CHAFF_VIB_OUT.Text = "0";
            // 
            // FLARE_VIB_OUT
            // 
            this.FLARE_VIB_OUT.Enabled = false;
            this.FLARE_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FLARE_VIB_OUT.Location = new System.Drawing.Point(347, 218);
            this.FLARE_VIB_OUT.Name = "FLARE_VIB_OUT";
            this.FLARE_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FLARE_VIB_OUT.TabIndex = 115;
            this.FLARE_VIB_OUT.Text = "0";
            // 
            // GUN_VIB_OUT
            // 
            this.GUN_VIB_OUT.Enabled = false;
            this.GUN_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GUN_VIB_OUT.Location = new System.Drawing.Point(347, 196);
            this.GUN_VIB_OUT.Name = "GUN_VIB_OUT";
            this.GUN_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.GUN_VIB_OUT.TabIndex = 114;
            this.GUN_VIB_OUT.Text = "0";
            // 
            // SPDBREAK_VIB_OUT
            // 
            this.SPDBREAK_VIB_OUT.Enabled = false;
            this.SPDBREAK_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SPDBREAK_VIB_OUT.Location = new System.Drawing.Point(347, 152);
            this.SPDBREAK_VIB_OUT.Name = "SPDBREAK_VIB_OUT";
            this.SPDBREAK_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.SPDBREAK_VIB_OUT.TabIndex = 119;
            this.SPDBREAK_VIB_OUT.Text = "0";
            // 
            // AOA_VIB_OUT
            // 
            this.AOA_VIB_OUT.Enabled = false;
            this.AOA_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AOA_VIB_OUT.Location = new System.Drawing.Point(347, 130);
            this.AOA_VIB_OUT.Name = "AOA_VIB_OUT";
            this.AOA_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.AOA_VIB_OUT.TabIndex = 118;
            this.AOA_VIB_OUT.Text = "0";
            // 
            // PANEL_VIB_OUT
            // 
            this.PANEL_VIB_OUT.Enabled = false;
            this.PANEL_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PANEL_VIB_OUT.Location = new System.Drawing.Point(347, 108);
            this.PANEL_VIB_OUT.Name = "PANEL_VIB_OUT";
            this.PANEL_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.PANEL_VIB_OUT.TabIndex = 116;
            this.PANEL_VIB_OUT.Text = "0";
            // 
            // GEAR_VIB_OUT
            // 
            this.GEAR_VIB_OUT.Enabled = false;
            this.GEAR_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GEAR_VIB_OUT.Location = new System.Drawing.Point(347, 174);
            this.GEAR_VIB_OUT.Name = "GEAR_VIB_OUT";
            this.GEAR_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.GEAR_VIB_OUT.TabIndex = 113;
            this.GEAR_VIB_OUT.Text = "0";
            // 
            // ACC_VIB_OUT
            // 
            this.ACC_VIB_OUT.Enabled = false;
            this.ACC_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ACC_VIB_OUT.Location = new System.Drawing.Point(347, 88);
            this.ACC_VIB_OUT.Name = "ACC_VIB_OUT";
            this.ACC_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.ACC_VIB_OUT.TabIndex = 112;
            this.ACC_VIB_OUT.Text = "0";
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label39.Location = new System.Drawing.Point(200, 313);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(102, 15);
            this.label39.TabIndex = 111;
            this.label39.Text = "최대진동 AOA";
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.Location = new System.Drawing.Point(14, 313);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(102, 15);
            this.label30.TabIndex = 110;
            this.label30.Text = "진동시작 AOA";
            // 
            // label20
            // 
            this.label20.Enabled = false;
            this.label20.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(239, 261);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 15);
            this.label20.TabIndex = 109;
            this.label20.Text = "%";
            // 
            // label21
            // 
            this.label21.Enabled = false;
            this.label21.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(239, 239);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 15);
            this.label21.TabIndex = 106;
            this.label21.Text = "%";
            // 
            // label22
            // 
            this.label22.Enabled = false;
            this.label22.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(239, 217);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 15);
            this.label22.TabIndex = 104;
            this.label22.Text = "%";
            // 
            // label23
            // 
            this.label23.Enabled = false;
            this.label23.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(239, 195);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 15);
            this.label23.TabIndex = 103;
            this.label23.Text = "%";
            // 
            // label24
            // 
            this.label24.Enabled = false;
            this.label24.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(239, 151);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 15);
            this.label24.TabIndex = 108;
            this.label24.Text = "%";
            // 
            // label25
            // 
            this.label25.Enabled = false;
            this.label25.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(239, 129);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 15);
            this.label25.TabIndex = 107;
            this.label25.Text = "%";
            // 
            // label26
            // 
            this.label26.Enabled = false;
            this.label26.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.Location = new System.Drawing.Point(239, 107);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(15, 15);
            this.label26.TabIndex = 105;
            this.label26.Text = "%";
            // 
            // label27
            // 
            this.label27.Enabled = false;
            this.label27.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.Location = new System.Drawing.Point(239, 173);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(15, 15);
            this.label27.TabIndex = 102;
            this.label27.Text = "%";
            // 
            // label28
            // 
            this.label28.Enabled = false;
            this.label28.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.Location = new System.Drawing.Point(239, 87);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(15, 15);
            this.label28.TabIndex = 101;
            this.label28.Text = "%";
            // 
            // PAYLOAD_VIB_PER
            // 
            this.PAYLOAD_VIB_PER.Enabled = false;
            this.PAYLOAD_VIB_PER.FormattingEnabled = true;
            this.PAYLOAD_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.PAYLOAD_VIB_PER.Location = new System.Drawing.Point(180, 257);
            this.PAYLOAD_VIB_PER.Name = "PAYLOAD_VIB_PER";
            this.PAYLOAD_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.PAYLOAD_VIB_PER.TabIndex = 100;
            this.PAYLOAD_VIB_PER.Text = "100";
            this.PAYLOAD_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.PAYLOAD_VIB_PER_SelectedIndexChanged);
            // 
            // CHAFF_VIB_PER
            // 
            this.CHAFF_VIB_PER.Enabled = false;
            this.CHAFF_VIB_PER.FormattingEnabled = true;
            this.CHAFF_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.CHAFF_VIB_PER.Location = new System.Drawing.Point(180, 235);
            this.CHAFF_VIB_PER.Name = "CHAFF_VIB_PER";
            this.CHAFF_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.CHAFF_VIB_PER.TabIndex = 99;
            this.CHAFF_VIB_PER.Text = "100";
            this.CHAFF_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.CHAFF_VIB_PER_SelectedIndexChanged);
            // 
            // FLARE_VIB_PER
            // 
            this.FLARE_VIB_PER.Enabled = false;
            this.FLARE_VIB_PER.FormattingEnabled = true;
            this.FLARE_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FLARE_VIB_PER.Location = new System.Drawing.Point(180, 213);
            this.FLARE_VIB_PER.Name = "FLARE_VIB_PER";
            this.FLARE_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FLARE_VIB_PER.TabIndex = 98;
            this.FLARE_VIB_PER.Text = "100";
            this.FLARE_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FLARE_VIB_PER_SelectedIndexChanged);
            // 
            // GUN_VIB_PER
            // 
            this.GUN_VIB_PER.Enabled = false;
            this.GUN_VIB_PER.FormattingEnabled = true;
            this.GUN_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.GUN_VIB_PER.Location = new System.Drawing.Point(180, 191);
            this.GUN_VIB_PER.Name = "GUN_VIB_PER";
            this.GUN_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.GUN_VIB_PER.TabIndex = 97;
            this.GUN_VIB_PER.Text = "100";
            this.GUN_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.GUN_VIB_PER_SelectedIndexChanged);
            // 
            // GEAR_VIB_PER
            // 
            this.GEAR_VIB_PER.Enabled = false;
            this.GEAR_VIB_PER.FormattingEnabled = true;
            this.GEAR_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.GEAR_VIB_PER.Location = new System.Drawing.Point(180, 169);
            this.GEAR_VIB_PER.Name = "GEAR_VIB_PER";
            this.GEAR_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.GEAR_VIB_PER.TabIndex = 96;
            this.GEAR_VIB_PER.Text = "100";
            this.GEAR_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.GEAR_VIB_PER_SelectedIndexChanged);
            // 
            // SPDBREAK_VIB_PER
            // 
            this.SPDBREAK_VIB_PER.Enabled = false;
            this.SPDBREAK_VIB_PER.FormattingEnabled = true;
            this.SPDBREAK_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.SPDBREAK_VIB_PER.Location = new System.Drawing.Point(180, 147);
            this.SPDBREAK_VIB_PER.Name = "SPDBREAK_VIB_PER";
            this.SPDBREAK_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.SPDBREAK_VIB_PER.TabIndex = 95;
            this.SPDBREAK_VIB_PER.Text = "100";
            this.SPDBREAK_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.SPDBREAK_VIB_PER_SelectedIndexChanged);
            // 
            // AOA_VIB_PER
            // 
            this.AOA_VIB_PER.Enabled = false;
            this.AOA_VIB_PER.FormattingEnabled = true;
            this.AOA_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.AOA_VIB_PER.Location = new System.Drawing.Point(180, 125);
            this.AOA_VIB_PER.Name = "AOA_VIB_PER";
            this.AOA_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.AOA_VIB_PER.TabIndex = 94;
            this.AOA_VIB_PER.Text = "100";
            this.AOA_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.AOA_VIB_PER_SelectedIndexChanged);
            // 
            // PANEL_VIB_PER
            // 
            this.PANEL_VIB_PER.Enabled = false;
            this.PANEL_VIB_PER.FormattingEnabled = true;
            this.PANEL_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.PANEL_VIB_PER.Location = new System.Drawing.Point(180, 103);
            this.PANEL_VIB_PER.Name = "PANEL_VIB_PER";
            this.PANEL_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.PANEL_VIB_PER.TabIndex = 93;
            this.PANEL_VIB_PER.Text = "100";
            this.PANEL_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.PANEL_VIB_PER_SelectedIndexChanged);
            // 
            // ACC_VIB_PER
            // 
            this.ACC_VIB_PER.Enabled = false;
            this.ACC_VIB_PER.FormattingEnabled = true;
            this.ACC_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.ACC_VIB_PER.Location = new System.Drawing.Point(180, 81);
            this.ACC_VIB_PER.Name = "ACC_VIB_PER";
            this.ACC_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.ACC_VIB_PER.TabIndex = 92;
            this.ACC_VIB_PER.Text = "100";
            this.ACC_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.ACC_VIB_PER_SelectedIndexChanged);
            // 
            // AOA_M_COMBO
            // 
            this.AOA_M_COMBO.Enabled = false;
            this.AOA_M_COMBO.FormattingEnabled = true;
            this.AOA_M_COMBO.Items.AddRange(new object[] {
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.AOA_M_COMBO.Location = new System.Drawing.Point(308, 308);
            this.AOA_M_COMBO.Name = "AOA_M_COMBO";
            this.AOA_M_COMBO.Size = new System.Drawing.Size(53, 20);
            this.AOA_M_COMBO.TabIndex = 91;
            this.AOA_M_COMBO.Text = "25";
            this.AOA_M_COMBO.SelectedIndexChanged += new System.EventHandler(this.AOA_M_COMBO_SelectedIndexChanged);
            // 
            // AOA_S_COMBO
            // 
            this.AOA_S_COMBO.Enabled = false;
            this.AOA_S_COMBO.FormattingEnabled = true;
            this.AOA_S_COMBO.Items.AddRange(new object[] {
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5"});
            this.AOA_S_COMBO.Location = new System.Drawing.Point(122, 308);
            this.AOA_S_COMBO.Name = "AOA_S_COMBO";
            this.AOA_S_COMBO.Size = new System.Drawing.Size(53, 20);
            this.AOA_S_COMBO.TabIndex = 69;
            this.AOA_S_COMBO.Text = "13";
            this.AOA_S_COMBO.SelectedIndexChanged += new System.EventHandler(this.AOA_S_COMBO_SelectedIndexChanged);
            // 
            // PLANE_LIST_COMBO
            // 
            this.PLANE_LIST_COMBO.FormattingEnabled = true;
            this.PLANE_LIST_COMBO.Location = new System.Drawing.Point(17, 22);
            this.PLANE_LIST_COMBO.Name = "PLANE_LIST_COMBO";
            this.PLANE_LIST_COMBO.Size = new System.Drawing.Size(216, 20);
            this.PLANE_LIST_COMBO.TabIndex = 90;
            this.PLANE_LIST_COMBO.SelectedIndexChanged += new System.EventHandler(this.PLANE_LIST_COMBO_SelectedIndexChanged);
            this.PLANE_LIST_COMBO.TextUpdate += new System.EventHandler(this.PLANE_LIST_COMBO_TextUpdate);
            // 
            // PAYLOAD_CHK
            // 
            this.PAYLOAD_CHK.AutoSize = true;
            this.PAYLOAD_CHK.Checked = true;
            this.PAYLOAD_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PAYLOAD_CHK.Enabled = false;
            this.PAYLOAD_CHK.Location = new System.Drawing.Point(17, 261);
            this.PAYLOAD_CHK.Name = "PAYLOAD_CHK";
            this.PAYLOAD_CHK.Size = new System.Drawing.Size(110, 16);
            this.PAYLOAD_CHK.TabIndex = 89;
            this.PAYLOAD_CHK.Text = "무장변경/발사 :";
            this.PAYLOAD_CHK.UseVisualStyleBackColor = true;
            this.PAYLOAD_CHK.CheckedChanged += new System.EventHandler(this.PAYLOAD_CHK_CheckedChanged);
            // 
            // CHAFF_CHK
            // 
            this.CHAFF_CHK.AutoSize = true;
            this.CHAFF_CHK.Checked = true;
            this.CHAFF_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHAFF_CHK.Enabled = false;
            this.CHAFF_CHK.Location = new System.Drawing.Point(17, 239);
            this.CHAFF_CHK.Name = "CHAFF_CHK";
            this.CHAFF_CHK.Size = new System.Drawing.Size(80, 16);
            this.CHAFF_CHK.TabIndex = 88;
            this.CHAFF_CHK.Text = "채프사출 :";
            this.CHAFF_CHK.UseVisualStyleBackColor = true;
            this.CHAFF_CHK.CheckedChanged += new System.EventHandler(this.CHAFF_CHK_CheckedChanged);
            // 
            // FLARE_CHK
            // 
            this.FLARE_CHK.AutoSize = true;
            this.FLARE_CHK.Checked = true;
            this.FLARE_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FLARE_CHK.Enabled = false;
            this.FLARE_CHK.Location = new System.Drawing.Point(17, 217);
            this.FLARE_CHK.Name = "FLARE_CHK";
            this.FLARE_CHK.Size = new System.Drawing.Size(92, 16);
            this.FLARE_CHK.TabIndex = 87;
            this.FLARE_CHK.Text = "플레어사출 :";
            this.FLARE_CHK.UseVisualStyleBackColor = true;
            this.FLARE_CHK.CheckedChanged += new System.EventHandler(this.FLARE_CHK_CheckedChanged);
            // 
            // GUN_CHK
            // 
            this.GUN_CHK.AutoSize = true;
            this.GUN_CHK.Checked = true;
            this.GUN_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GUN_CHK.Enabled = false;
            this.GUN_CHK.Location = new System.Drawing.Point(17, 195);
            this.GUN_CHK.Name = "GUN_CHK";
            this.GUN_CHK.Size = new System.Drawing.Size(56, 16);
            this.GUN_CHK.TabIndex = 86;
            this.GUN_CHK.Text = "기총 :";
            this.GUN_CHK.UseVisualStyleBackColor = true;
            this.GUN_CHK.CheckedChanged += new System.EventHandler(this.GUN_CHK_CheckedChanged);
            // 
            // GEAR_CHK
            // 
            this.GEAR_CHK.AutoSize = true;
            this.GEAR_CHK.Checked = true;
            this.GEAR_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GEAR_CHK.Enabled = false;
            this.GEAR_CHK.Location = new System.Drawing.Point(17, 173);
            this.GEAR_CHK.Name = "GEAR_CHK";
            this.GEAR_CHK.Size = new System.Drawing.Size(80, 16);
            this.GEAR_CHK.TabIndex = 85;
            this.GEAR_CHK.Text = "랜딩기어 :";
            this.GEAR_CHK.UseVisualStyleBackColor = true;
            this.GEAR_CHK.CheckedChanged += new System.EventHandler(this.GEAR_CHK_CheckedChanged);
            // 
            // SPDBREAK_CHK
            // 
            this.SPDBREAK_CHK.AutoSize = true;
            this.SPDBREAK_CHK.Checked = true;
            this.SPDBREAK_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SPDBREAK_CHK.Enabled = false;
            this.SPDBREAK_CHK.Location = new System.Drawing.Point(17, 151);
            this.SPDBREAK_CHK.Name = "SPDBREAK_CHK";
            this.SPDBREAK_CHK.Size = new System.Drawing.Size(116, 16);
            this.SPDBREAK_CHK.TabIndex = 84;
            this.SPDBREAK_CHK.Text = "스피드브레이크 :";
            this.SPDBREAK_CHK.UseVisualStyleBackColor = true;
            this.SPDBREAK_CHK.CheckedChanged += new System.EventHandler(this.SPDBREAK_CHK_CheckedChanged);
            // 
            // AOA_CHK
            // 
            this.AOA_CHK.AutoSize = true;
            this.AOA_CHK.Checked = true;
            this.AOA_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AOA_CHK.Enabled = false;
            this.AOA_CHK.Location = new System.Drawing.Point(17, 129);
            this.AOA_CHK.Name = "AOA_CHK";
            this.AOA_CHK.Size = new System.Drawing.Size(57, 16);
            this.AOA_CHK.TabIndex = 83;
            this.AOA_CHK.Text = "AOA :";
            this.AOA_CHK.UseVisualStyleBackColor = true;
            this.AOA_CHK.CheckedChanged += new System.EventHandler(this.AOA_CHK_CheckedChanged);
            // 
            // PANEL_CHK
            // 
            this.PANEL_CHK.AutoSize = true;
            this.PANEL_CHK.Checked = true;
            this.PANEL_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PANEL_CHK.Enabled = false;
            this.PANEL_CHK.Location = new System.Drawing.Point(17, 107);
            this.PANEL_CHK.Name = "PANEL_CHK";
            this.PANEL_CHK.Size = new System.Drawing.Size(80, 16);
            this.PANEL_CHK.TabIndex = 82;
            this.PANEL_CHK.Text = "패널진동 :";
            this.PANEL_CHK.UseVisualStyleBackColor = true;
            this.PANEL_CHK.CheckedChanged += new System.EventHandler(this.PANEL_CHK_CheckedChanged);
            // 
            // ACC_CHK
            // 
            this.ACC_CHK.AutoSize = true;
            this.ACC_CHK.Checked = true;
            this.ACC_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ACC_CHK.Enabled = false;
            this.ACC_CHK.Location = new System.Drawing.Point(17, 87);
            this.ACC_CHK.Name = "ACC_CHK";
            this.ACC_CHK.Size = new System.Drawing.Size(68, 16);
            this.ACC_CHK.TabIndex = 81;
            this.ACC_CHK.Text = "가속도 :";
            this.ACC_CHK.UseVisualStyleBackColor = true;
            this.ACC_CHK.CheckedChanged += new System.EventHandler(this.ACC_CHK_CheckedChanged);
            // 
            // PAYLOAD_VIB
            // 
            this.PAYLOAD_VIB.Enabled = false;
            this.PAYLOAD_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PAYLOAD_VIB.Location = new System.Drawing.Point(140, 262);
            this.PAYLOAD_VIB.Name = "PAYLOAD_VIB";
            this.PAYLOAD_VIB.Size = new System.Drawing.Size(40, 15);
            this.PAYLOAD_VIB.TabIndex = 75;
            this.PAYLOAD_VIB.Text = "0";
            // 
            // CHAFF_VIB
            // 
            this.CHAFF_VIB.Enabled = false;
            this.CHAFF_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CHAFF_VIB.Location = new System.Drawing.Point(140, 240);
            this.CHAFF_VIB.Name = "CHAFF_VIB";
            this.CHAFF_VIB.Size = new System.Drawing.Size(40, 15);
            this.CHAFF_VIB.TabIndex = 71;
            this.CHAFF_VIB.Text = "0";
            // 
            // FLARE_VIB
            // 
            this.FLARE_VIB.Enabled = false;
            this.FLARE_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FLARE_VIB.Location = new System.Drawing.Point(140, 218);
            this.FLARE_VIB.Name = "FLARE_VIB";
            this.FLARE_VIB.Size = new System.Drawing.Size(40, 15);
            this.FLARE_VIB.TabIndex = 70;
            this.FLARE_VIB.Text = "0";
            // 
            // GUN_VIB
            // 
            this.GUN_VIB.Enabled = false;
            this.GUN_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GUN_VIB.Location = new System.Drawing.Point(140, 196);
            this.GUN_VIB.Name = "GUN_VIB";
            this.GUN_VIB.Size = new System.Drawing.Size(40, 15);
            this.GUN_VIB.TabIndex = 69;
            this.GUN_VIB.Text = "0";
            // 
            // SPDBREAK_VIB
            // 
            this.SPDBREAK_VIB.Enabled = false;
            this.SPDBREAK_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SPDBREAK_VIB.Location = new System.Drawing.Point(140, 152);
            this.SPDBREAK_VIB.Name = "SPDBREAK_VIB";
            this.SPDBREAK_VIB.Size = new System.Drawing.Size(40, 15);
            this.SPDBREAK_VIB.TabIndex = 73;
            this.SPDBREAK_VIB.Text = "0";
            // 
            // AOA_VIB
            // 
            this.AOA_VIB.Enabled = false;
            this.AOA_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AOA_VIB.Location = new System.Drawing.Point(140, 130);
            this.AOA_VIB.Name = "AOA_VIB";
            this.AOA_VIB.Size = new System.Drawing.Size(40, 15);
            this.AOA_VIB.TabIndex = 71;
            this.AOA_VIB.Text = "0";
            // 
            // PANEL_VIB
            // 
            this.PANEL_VIB.Enabled = false;
            this.PANEL_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PANEL_VIB.Location = new System.Drawing.Point(140, 108);
            this.PANEL_VIB.Name = "PANEL_VIB";
            this.PANEL_VIB.Size = new System.Drawing.Size(40, 15);
            this.PANEL_VIB.TabIndex = 70;
            this.PANEL_VIB.Text = "0";
            // 
            // GEAR_VIB
            // 
            this.GEAR_VIB.Enabled = false;
            this.GEAR_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GEAR_VIB.Location = new System.Drawing.Point(140, 174);
            this.GEAR_VIB.Name = "GEAR_VIB";
            this.GEAR_VIB.Size = new System.Drawing.Size(40, 15);
            this.GEAR_VIB.TabIndex = 62;
            this.GEAR_VIB.Text = "0";
            // 
            // ACC_VIB
            // 
            this.ACC_VIB.Enabled = false;
            this.ACC_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ACC_VIB.Location = new System.Drawing.Point(140, 88);
            this.ACC_VIB.Name = "ACC_VIB";
            this.ACC_VIB.Size = new System.Drawing.Size(40, 15);
            this.ACC_VIB.TabIndex = 54;
            this.ACC_VIB.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Controls.Add(this.DCS_IAS);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.DCS_ENG_2);
            this.groupBox4.Controls.Add(this.DCS_ENG_1);
            this.groupBox4.Controls.Add(this.DCS_PANEL_5);
            this.groupBox4.Controls.Add(this.DCS_PANEL_4);
            this.groupBox4.Controls.Add(this.DCS_PANEL_3);
            this.groupBox4.Controls.Add(this.DCS_PANEL_2);
            this.groupBox4.Controls.Add(this.DCS_PANEL_1);
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.DCS_PAYLOAD);
            this.groupBox4.Controls.Add(this.DCS_CHAFF);
            this.groupBox4.Controls.Add(this.DCS_FLARE);
            this.groupBox4.Controls.Add(this.DCS_SPDBREAK);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.DCS_GEAR);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.DCS_GUN);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.DCS_PLANE_NAME);
            this.groupBox4.Controls.Add(this.DCS_ACCS_Z);
            this.groupBox4.Controls.Add(this.DCS_ACCS_X);
            this.groupBox4.Controls.Add(this.DCS_ACCS_Y);
            this.groupBox4.Controls.Add(this.DCS_AOA);
            this.groupBox4.Location = new System.Drawing.Point(12, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 182);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DCS 출력값";
            // 
            // label52
            // 
            this.label52.Location = new System.Drawing.Point(14, 47);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(60, 16);
            this.label52.TabIndex = 70;
            this.label52.Text = "IAS :";
            // 
            // DCS_IAS
            // 
            this.DCS_IAS.Location = new System.Drawing.Point(110, 47);
            this.DCS_IAS.Name = "DCS_IAS";
            this.DCS_IAS.Size = new System.Drawing.Size(82, 16);
            this.DCS_IAS.TabIndex = 69;
            this.DCS_IAS.Text = "0";
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(199, 110);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 16);
            this.label29.TabIndex = 68;
            this.label29.Text = "RPM :";
            // 
            // DCS_ENG_2
            // 
            this.DCS_ENG_2.Location = new System.Drawing.Point(311, 110);
            this.DCS_ENG_2.Name = "DCS_ENG_2";
            this.DCS_ENG_2.Size = new System.Drawing.Size(30, 16);
            this.DCS_ENG_2.TabIndex = 67;
            this.DCS_ENG_2.Text = "0";
            // 
            // DCS_ENG_1
            // 
            this.DCS_ENG_1.Location = new System.Drawing.Point(275, 110);
            this.DCS_ENG_1.Name = "DCS_ENG_1";
            this.DCS_ENG_1.Size = new System.Drawing.Size(30, 16);
            this.DCS_ENG_1.TabIndex = 51;
            this.DCS_ENG_1.Text = "0";
            // 
            // DCS_PANEL_5
            // 
            this.DCS_PANEL_5.Location = new System.Drawing.Point(290, 158);
            this.DCS_PANEL_5.Name = "DCS_PANEL_5";
            this.DCS_PANEL_5.Size = new System.Drawing.Size(82, 16);
            this.DCS_PANEL_5.TabIndex = 50;
            this.DCS_PANEL_5.Text = "0";
            // 
            // DCS_PANEL_4
            // 
            this.DCS_PANEL_4.Location = new System.Drawing.Point(246, 158);
            this.DCS_PANEL_4.Name = "DCS_PANEL_4";
            this.DCS_PANEL_4.Size = new System.Drawing.Size(82, 16);
            this.DCS_PANEL_4.TabIndex = 49;
            this.DCS_PANEL_4.Text = "0";
            // 
            // DCS_PANEL_3
            // 
            this.DCS_PANEL_3.Location = new System.Drawing.Point(196, 158);
            this.DCS_PANEL_3.Name = "DCS_PANEL_3";
            this.DCS_PANEL_3.Size = new System.Drawing.Size(82, 16);
            this.DCS_PANEL_3.TabIndex = 48;
            this.DCS_PANEL_3.Text = "0";
            // 
            // DCS_PANEL_2
            // 
            this.DCS_PANEL_2.Location = new System.Drawing.Point(150, 158);
            this.DCS_PANEL_2.Name = "DCS_PANEL_2";
            this.DCS_PANEL_2.Size = new System.Drawing.Size(82, 16);
            this.DCS_PANEL_2.TabIndex = 47;
            this.DCS_PANEL_2.Text = "0";
            // 
            // DCS_PANEL_1
            // 
            this.DCS_PANEL_1.Location = new System.Drawing.Point(110, 158);
            this.DCS_PANEL_1.Name = "DCS_PANEL_1";
            this.DCS_PANEL_1.Size = new System.Drawing.Size(82, 16);
            this.DCS_PANEL_1.TabIndex = 40;
            this.DCS_PANEL_1.Text = "0";
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(14, 158);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(90, 16);
            this.label38.TabIndex = 46;
            this.label38.Text = "패널떨림 :";
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(198, 94);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(60, 16);
            this.label37.TabIndex = 45;
            this.label37.Text = "Payload :";
            // 
            // DCS_PAYLOAD
            // 
            this.DCS_PAYLOAD.Location = new System.Drawing.Point(275, 94);
            this.DCS_PAYLOAD.Name = "DCS_PAYLOAD";
            this.DCS_PAYLOAD.Size = new System.Drawing.Size(82, 16);
            this.DCS_PAYLOAD.TabIndex = 41;
            this.DCS_PAYLOAD.Text = "0";
            // 
            // DCS_CHAFF
            // 
            this.DCS_CHAFF.Location = new System.Drawing.Point(275, 78);
            this.DCS_CHAFF.Name = "DCS_CHAFF";
            this.DCS_CHAFF.Size = new System.Drawing.Size(82, 16);
            this.DCS_CHAFF.TabIndex = 42;
            this.DCS_CHAFF.Text = "0";
            // 
            // DCS_FLARE
            // 
            this.DCS_FLARE.Location = new System.Drawing.Point(275, 62);
            this.DCS_FLARE.Name = "DCS_FLARE";
            this.DCS_FLARE.Size = new System.Drawing.Size(82, 16);
            this.DCS_FLARE.TabIndex = 43;
            this.DCS_FLARE.Text = "0";
            // 
            // DCS_SPDBREAK
            // 
            this.DCS_SPDBREAK.Location = new System.Drawing.Point(110, 142);
            this.DCS_SPDBREAK.Name = "DCS_SPDBREAK";
            this.DCS_SPDBREAK.Size = new System.Drawing.Size(82, 16);
            this.DCS_SPDBREAK.TabIndex = 44;
            this.DCS_SPDBREAK.Text = "0";
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(198, 79);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 16);
            this.label32.TabIndex = 39;
            this.label32.Text = "채프 :";
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(198, 63);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(60, 16);
            this.label33.TabIndex = 38;
            this.label33.Text = "플레어 :";
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(13, 142);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(90, 16);
            this.label34.TabIndex = 37;
            this.label34.Text = "에어브레이크 :";
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(14, 126);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(90, 16);
            this.label35.TabIndex = 36;
            this.label35.Text = "랜딩기어 :";
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(198, 47);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(60, 16);
            this.label36.TabIndex = 35;
            this.label36.Text = "기총 :";
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(13, 110);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 16);
            this.label31.TabIndex = 34;
            this.label31.Text = "AOA :";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(13, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 16);
            this.label19.TabIndex = 33;
            this.label19.Text = "가속도_Z :";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(14, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "가속도_Y :";
            // 
            // DCS_GEAR
            // 
            this.DCS_GEAR.Location = new System.Drawing.Point(110, 126);
            this.DCS_GEAR.Name = "DCS_GEAR";
            this.DCS_GEAR.Size = new System.Drawing.Size(82, 16);
            this.DCS_GEAR.TabIndex = 35;
            this.DCS_GEAR.Text = "0";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(13, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "가속도_X :";
            // 
            // DCS_GUN
            // 
            this.DCS_GUN.Location = new System.Drawing.Point(275, 47);
            this.DCS_GUN.Name = "DCS_GUN";
            this.DCS_GUN.Size = new System.Drawing.Size(82, 16);
            this.DCS_GUN.TabIndex = 34;
            this.DCS_GUN.Text = "0";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(13, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "현재항공기 :";
            // 
            // DCS_PLANE_NAME
            // 
            this.DCS_PLANE_NAME.Location = new System.Drawing.Point(110, 25);
            this.DCS_PLANE_NAME.Name = "DCS_PLANE_NAME";
            this.DCS_PLANE_NAME.Size = new System.Drawing.Size(82, 16);
            this.DCS_PLANE_NAME.TabIndex = 29;
            this.DCS_PLANE_NAME.Text = "-";
            // 
            // DCS_ACCS_Z
            // 
            this.DCS_ACCS_Z.Location = new System.Drawing.Point(110, 94);
            this.DCS_ACCS_Z.Name = "DCS_ACCS_Z";
            this.DCS_ACCS_Z.Size = new System.Drawing.Size(82, 16);
            this.DCS_ACCS_Z.TabIndex = 32;
            this.DCS_ACCS_Z.Text = "0";
            // 
            // DCS_ACCS_X
            // 
            this.DCS_ACCS_X.Location = new System.Drawing.Point(110, 63);
            this.DCS_ACCS_X.Name = "DCS_ACCS_X";
            this.DCS_ACCS_X.Size = new System.Drawing.Size(82, 15);
            this.DCS_ACCS_X.TabIndex = 30;
            this.DCS_ACCS_X.Text = "0";
            // 
            // DCS_ACCS_Y
            // 
            this.DCS_ACCS_Y.Location = new System.Drawing.Point(110, 78);
            this.DCS_ACCS_Y.Name = "DCS_ACCS_Y";
            this.DCS_ACCS_Y.Size = new System.Drawing.Size(82, 16);
            this.DCS_ACCS_Y.TabIndex = 31;
            this.DCS_ACCS_Y.Text = "0";
            // 
            // DCS_AOA
            // 
            this.DCS_AOA.Location = new System.Drawing.Point(110, 110);
            this.DCS_AOA.Name = "DCS_AOA";
            this.DCS_AOA.Size = new System.Drawing.Size(82, 16);
            this.DCS_AOA.TabIndex = 33;
            this.DCS_AOA.Text = "0";
            // 
            // Connect_DCS
            // 
            this.Connect_DCS.Location = new System.Drawing.Point(337, 636);
            this.Connect_DCS.Name = "Connect_DCS";
            this.Connect_DCS.Size = new System.Drawing.Size(109, 32);
            this.Connect_DCS.TabIndex = 0;
            this.Connect_DCS.Text = "Connect";
            this.Connect_DCS.UseVisualStyleBackColor = true;
            this.Connect_DCS.Click += new System.EventHandler(this.Connect_DCS_Click);
            // 
            // FALCON
            // 
            this.FALCON.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FALCON.Controls.Add(this.groupBox12);
            this.FALCON.Controls.Add(this.groupBox11);
            this.FALCON.Controls.Add(this.Connect_FALCON);
            this.FALCON.Controls.Add(this.groupBox9);
            this.FALCON.Location = new System.Drawing.Point(4, 22);
            this.FALCON.Name = "FALCON";
            this.FALCON.Size = new System.Drawing.Size(463, 674);
            this.FALCON.TabIndex = 3;
            this.FALCON.Text = "FALCON BMS";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.FALCON_VIB_OUT);
            this.groupBox12.Location = new System.Drawing.Point(12, 545);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(432, 78);
            this.groupBox12.TabIndex = 71;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "최종출력";
            // 
            // FALCON_VIB_OUT
            // 
            this.FALCON_VIB_OUT.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_VIB_OUT.Location = new System.Drawing.Point(15, 29);
            this.FALCON_VIB_OUT.Name = "FALCON_VIB_OUT";
            this.FALCON_VIB_OUT.Size = new System.Drawing.Size(219, 31);
            this.FALCON_VIB_OUT.TabIndex = 122;
            this.FALCON_VIB_OUT.Text = "0";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.FALCON_YAW_VIB_MIN);
            this.groupBox11.Controls.Add(this.FALCON_ROLL_VIB_MIN);
            this.groupBox11.Controls.Add(this.label93);
            this.groupBox11.Controls.Add(this.FALCON_PITCH_VIB_MIN);
            this.groupBox11.Controls.Add(this.FALCON_ROLL_VIB_OUT);
            this.groupBox11.Controls.Add(this.label95);
            this.groupBox11.Controls.Add(this.FALCON_ROLL_VIB_PER);
            this.groupBox11.Controls.Add(this.FALCON_ROLL_CHK);
            this.groupBox11.Controls.Add(this.FALCON_ROLL_VIB);
            this.groupBox11.Controls.Add(this.FALCON_PITCH_VIB_OUT);
            this.groupBox11.Controls.Add(this.label91);
            this.groupBox11.Controls.Add(this.FALCON_PITCH_VIB_PER);
            this.groupBox11.Controls.Add(this.FALCON_PITCH_CHK);
            this.groupBox11.Controls.Add(this.FALCON_PITCH_VIB);
            this.groupBox11.Controls.Add(this.FALCON_DAMAGE_VIB_OUT);
            this.groupBox11.Controls.Add(this.label99);
            this.groupBox11.Controls.Add(this.FALCON_DAMAGE_VIB_PER);
            this.groupBox11.Controls.Add(this.FALCON_DAMAGE_CHK);
            this.groupBox11.Controls.Add(this.FALCON_DAMAGE_VIB);
            this.groupBox11.Controls.Add(this.FALCON_CHFL_VIB_OUT);
            this.groupBox11.Controls.Add(this.label105);
            this.groupBox11.Controls.Add(this.FALCON_CHFL_VIB_PER);
            this.groupBox11.Controls.Add(this.FALCON_CHFL_CHK);
            this.groupBox11.Controls.Add(this.FALCON_CHFL_VIB);
            this.groupBox11.Controls.Add(this.FALCON_AIRBREAK_VIB_OUT);
            this.groupBox11.Controls.Add(this.label108);
            this.groupBox11.Controls.Add(this.FALCON_AIRBREAK_VIB_PER);
            this.groupBox11.Controls.Add(this.FALCON_AIRBREAK_CHK);
            this.groupBox11.Controls.Add(this.FALCON_AIRBREAK_VIB);
            this.groupBox11.Controls.Add(this.FALCON_GEAR_VIB_OUT);
            this.groupBox11.Controls.Add(this.label111);
            this.groupBox11.Controls.Add(this.FALCON_GEAR_VIB_PER);
            this.groupBox11.Controls.Add(this.FALCON_GEAR_CHK);
            this.groupBox11.Controls.Add(this.FALCON_GEAR_VIB);
            this.groupBox11.Controls.Add(this.FALCON_PAYLOAD_VIB_OUT);
            this.groupBox11.Controls.Add(this.label114);
            this.groupBox11.Controls.Add(this.FALCON_PAYLOAD_VIB_PER);
            this.groupBox11.Controls.Add(this.FALCON_PAYLOAD_CHK);
            this.groupBox11.Controls.Add(this.FALCON_PAYLOAD_VIB);
            this.groupBox11.Controls.Add(this.FALCON_GUN_VIB_OUT);
            this.groupBox11.Controls.Add(this.label117);
            this.groupBox11.Controls.Add(this.FALCON_GUN_VIB_PER);
            this.groupBox11.Controls.Add(this.FALCON_GUN_CHK);
            this.groupBox11.Controls.Add(this.FALCON_GUN_VIB);
            this.groupBox11.Controls.Add(this.label119);
            this.groupBox11.Controls.Add(this.label120);
            this.groupBox11.Controls.Add(this.label121);
            this.groupBox11.Controls.Add(this.label122);
            this.groupBox11.Controls.Add(this.DEFAULT_SETUP_FALCON);
            this.groupBox11.Controls.Add(this.FALCON_BUNNER_VIB_OUT);
            this.groupBox11.Controls.Add(this.FALCON_AOA_VIB_OUT);
            this.groupBox11.Controls.Add(this.FALCON_YAW_VIB_OUT);
            this.groupBox11.Controls.Add(this.label126);
            this.groupBox11.Controls.Add(this.label127);
            this.groupBox11.Controls.Add(this.label128);
            this.groupBox11.Controls.Add(this.label129);
            this.groupBox11.Controls.Add(this.label130);
            this.groupBox11.Controls.Add(this.FALCON_BUNNER_VIB_PER);
            this.groupBox11.Controls.Add(this.FALCON_AOA_VIB_PER);
            this.groupBox11.Controls.Add(this.FALCON_YAW_VIB_PER);
            this.groupBox11.Controls.Add(this.FALCON_AOA_M_COMBO);
            this.groupBox11.Controls.Add(this.FALCON_AOA_S_COMBO);
            this.groupBox11.Controls.Add(this.FALCON_BUNNER_CHK);
            this.groupBox11.Controls.Add(this.FALCON_AOA_CHK);
            this.groupBox11.Controls.Add(this.FALCON_YAW_CHK);
            this.groupBox11.Controls.Add(this.FALCON_BUNNER_VIB);
            this.groupBox11.Controls.Add(this.FALCON_AOA_VIB);
            this.groupBox11.Controls.Add(this.FALCON_YAW_VIB);
            this.groupBox11.Location = new System.Drawing.Point(11, 206);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(432, 323);
            this.groupBox11.TabIndex = 70;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "진동출력설정";
            // 
            // FALCON_YAW_VIB_MIN
            // 
            this.FALCON_YAW_VIB_MIN.FormattingEnabled = true;
            this.FALCON_YAW_VIB_MIN.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.FALCON_YAW_VIB_MIN.Location = new System.Drawing.Point(263, 86);
            this.FALCON_YAW_VIB_MIN.Name = "FALCON_YAW_VIB_MIN";
            this.FALCON_YAW_VIB_MIN.Size = new System.Drawing.Size(53, 20);
            this.FALCON_YAW_VIB_MIN.TabIndex = 169;
            this.FALCON_YAW_VIB_MIN.Text = "1";
            this.FALCON_YAW_VIB_MIN.SelectedIndexChanged += new System.EventHandler(this.FALCON_YAW_VIB_MIN_SelectedIndexChanged);
            // 
            // FALCON_ROLL_VIB_MIN
            // 
            this.FALCON_ROLL_VIB_MIN.FormattingEnabled = true;
            this.FALCON_ROLL_VIB_MIN.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.FALCON_ROLL_VIB_MIN.Location = new System.Drawing.Point(263, 64);
            this.FALCON_ROLL_VIB_MIN.Name = "FALCON_ROLL_VIB_MIN";
            this.FALCON_ROLL_VIB_MIN.Size = new System.Drawing.Size(53, 20);
            this.FALCON_ROLL_VIB_MIN.TabIndex = 168;
            this.FALCON_ROLL_VIB_MIN.Text = "1";
            this.FALCON_ROLL_VIB_MIN.SelectedIndexChanged += new System.EventHandler(this.FALCON_ROLL_VIB_MIN_SelectedIndexChanged);
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label93.Location = new System.Drawing.Point(260, 26);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(77, 13);
            this.label93.TabIndex = 167;
            this.label93.Text = "진동시작값";
            // 
            // FALCON_PITCH_VIB_MIN
            // 
            this.FALCON_PITCH_VIB_MIN.FormattingEnabled = true;
            this.FALCON_PITCH_VIB_MIN.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.FALCON_PITCH_VIB_MIN.Location = new System.Drawing.Point(263, 42);
            this.FALCON_PITCH_VIB_MIN.Name = "FALCON_PITCH_VIB_MIN";
            this.FALCON_PITCH_VIB_MIN.Size = new System.Drawing.Size(53, 20);
            this.FALCON_PITCH_VIB_MIN.TabIndex = 166;
            this.FALCON_PITCH_VIB_MIN.Text = "1";
            this.FALCON_PITCH_VIB_MIN.SelectedIndexChanged += new System.EventHandler(this.FALCON_PITCH_VIB_MIN_SelectedIndexChanged);
            // 
            // FALCON_ROLL_VIB_OUT
            // 
            this.FALCON_ROLL_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_ROLL_VIB_OUT.Location = new System.Drawing.Point(348, 71);
            this.FALCON_ROLL_VIB_OUT.Name = "FALCON_ROLL_VIB_OUT";
            this.FALCON_ROLL_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FALCON_ROLL_VIB_OUT.TabIndex = 165;
            this.FALCON_ROLL_VIB_OUT.Text = "0";
            // 
            // label95
            // 
            this.label95.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label95.Location = new System.Drawing.Point(242, 70);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(15, 15);
            this.label95.TabIndex = 164;
            this.label95.Text = "%";
            // 
            // FALCON_ROLL_VIB_PER
            // 
            this.FALCON_ROLL_VIB_PER.FormattingEnabled = true;
            this.FALCON_ROLL_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FALCON_ROLL_VIB_PER.Location = new System.Drawing.Point(183, 64);
            this.FALCON_ROLL_VIB_PER.Name = "FALCON_ROLL_VIB_PER";
            this.FALCON_ROLL_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FALCON_ROLL_VIB_PER.TabIndex = 163;
            this.FALCON_ROLL_VIB_PER.Text = "100";
            this.FALCON_ROLL_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FALCON_ROLL_VIB_PER_SelectedIndexChanged);
            // 
            // FALCON_ROLL_CHK
            // 
            this.FALCON_ROLL_CHK.AutoSize = true;
            this.FALCON_ROLL_CHK.Checked = true;
            this.FALCON_ROLL_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FALCON_ROLL_CHK.Location = new System.Drawing.Point(20, 70);
            this.FALCON_ROLL_CHK.Name = "FALCON_ROLL_CHK";
            this.FALCON_ROLL_CHK.Size = new System.Drawing.Size(63, 16);
            this.FALCON_ROLL_CHK.TabIndex = 162;
            this.FALCON_ROLL_CHK.Text = "ROLL :";
            this.FALCON_ROLL_CHK.UseVisualStyleBackColor = true;
            this.FALCON_ROLL_CHK.CheckedChanged += new System.EventHandler(this.FALCON_ROLL_CHK_CheckedChanged);
            // 
            // FALCON_ROLL_VIB
            // 
            this.FALCON_ROLL_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_ROLL_VIB.Location = new System.Drawing.Point(143, 71);
            this.FALCON_ROLL_VIB.Name = "FALCON_ROLL_VIB";
            this.FALCON_ROLL_VIB.Size = new System.Drawing.Size(40, 15);
            this.FALCON_ROLL_VIB.TabIndex = 161;
            this.FALCON_ROLL_VIB.Text = "0";
            // 
            // FALCON_PITCH_VIB_OUT
            // 
            this.FALCON_PITCH_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_PITCH_VIB_OUT.Location = new System.Drawing.Point(348, 49);
            this.FALCON_PITCH_VIB_OUT.Name = "FALCON_PITCH_VIB_OUT";
            this.FALCON_PITCH_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FALCON_PITCH_VIB_OUT.TabIndex = 160;
            this.FALCON_PITCH_VIB_OUT.Text = "0";
            // 
            // label91
            // 
            this.label91.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label91.Location = new System.Drawing.Point(242, 48);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(15, 15);
            this.label91.TabIndex = 159;
            this.label91.Text = "%";
            // 
            // FALCON_PITCH_VIB_PER
            // 
            this.FALCON_PITCH_VIB_PER.FormattingEnabled = true;
            this.FALCON_PITCH_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FALCON_PITCH_VIB_PER.Location = new System.Drawing.Point(183, 42);
            this.FALCON_PITCH_VIB_PER.Name = "FALCON_PITCH_VIB_PER";
            this.FALCON_PITCH_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FALCON_PITCH_VIB_PER.TabIndex = 158;
            this.FALCON_PITCH_VIB_PER.Text = "100";
            this.FALCON_PITCH_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FALCON_PITCH_VIB_PER_SelectedIndexChanged);
            // 
            // FALCON_PITCH_CHK
            // 
            this.FALCON_PITCH_CHK.AutoSize = true;
            this.FALCON_PITCH_CHK.Checked = true;
            this.FALCON_PITCH_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FALCON_PITCH_CHK.Location = new System.Drawing.Point(20, 48);
            this.FALCON_PITCH_CHK.Name = "FALCON_PITCH_CHK";
            this.FALCON_PITCH_CHK.Size = new System.Drawing.Size(68, 16);
            this.FALCON_PITCH_CHK.TabIndex = 157;
            this.FALCON_PITCH_CHK.Text = "PITCH :";
            this.FALCON_PITCH_CHK.UseVisualStyleBackColor = true;
            this.FALCON_PITCH_CHK.CheckedChanged += new System.EventHandler(this.FALCON_PITCH_CHK_CheckedChanged);
            // 
            // FALCON_PITCH_VIB
            // 
            this.FALCON_PITCH_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_PITCH_VIB.Location = new System.Drawing.Point(143, 49);
            this.FALCON_PITCH_VIB.Name = "FALCON_PITCH_VIB";
            this.FALCON_PITCH_VIB.Size = new System.Drawing.Size(40, 15);
            this.FALCON_PITCH_VIB.TabIndex = 156;
            this.FALCON_PITCH_VIB.Text = "0";
            // 
            // FALCON_DAMAGE_VIB_OUT
            // 
            this.FALCON_DAMAGE_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_DAMAGE_VIB_OUT.Location = new System.Drawing.Point(348, 266);
            this.FALCON_DAMAGE_VIB_OUT.Name = "FALCON_DAMAGE_VIB_OUT";
            this.FALCON_DAMAGE_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FALCON_DAMAGE_VIB_OUT.TabIndex = 155;
            this.FALCON_DAMAGE_VIB_OUT.Text = "0";
            // 
            // label99
            // 
            this.label99.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label99.Location = new System.Drawing.Point(242, 265);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(15, 15);
            this.label99.TabIndex = 154;
            this.label99.Text = "%";
            // 
            // FALCON_DAMAGE_VIB_PER
            // 
            this.FALCON_DAMAGE_VIB_PER.FormattingEnabled = true;
            this.FALCON_DAMAGE_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FALCON_DAMAGE_VIB_PER.Location = new System.Drawing.Point(183, 261);
            this.FALCON_DAMAGE_VIB_PER.Name = "FALCON_DAMAGE_VIB_PER";
            this.FALCON_DAMAGE_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FALCON_DAMAGE_VIB_PER.TabIndex = 153;
            this.FALCON_DAMAGE_VIB_PER.Text = "100";
            this.FALCON_DAMAGE_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FALCON_DAMAGE_VIB_PER_SelectedIndexChanged);
            // 
            // FALCON_DAMAGE_CHK
            // 
            this.FALCON_DAMAGE_CHK.AutoSize = true;
            this.FALCON_DAMAGE_CHK.Checked = true;
            this.FALCON_DAMAGE_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FALCON_DAMAGE_CHK.Location = new System.Drawing.Point(20, 265);
            this.FALCON_DAMAGE_CHK.Name = "FALCON_DAMAGE_CHK";
            this.FALCON_DAMAGE_CHK.Size = new System.Drawing.Size(92, 16);
            this.FALCON_DAMAGE_CHK.TabIndex = 152;
            this.FALCON_DAMAGE_CHK.Text = "기체데미지 :";
            this.FALCON_DAMAGE_CHK.UseVisualStyleBackColor = true;
            this.FALCON_DAMAGE_CHK.CheckedChanged += new System.EventHandler(this.FALCON_DAMAGE_CHK_CheckedChanged);
            // 
            // FALCON_DAMAGE_VIB
            // 
            this.FALCON_DAMAGE_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_DAMAGE_VIB.Location = new System.Drawing.Point(143, 266);
            this.FALCON_DAMAGE_VIB.Name = "FALCON_DAMAGE_VIB";
            this.FALCON_DAMAGE_VIB.Size = new System.Drawing.Size(40, 15);
            this.FALCON_DAMAGE_VIB.TabIndex = 151;
            this.FALCON_DAMAGE_VIB.Text = "0";
            // 
            // FALCON_CHFL_VIB_OUT
            // 
            this.FALCON_CHFL_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_CHFL_VIB_OUT.Location = new System.Drawing.Point(348, 245);
            this.FALCON_CHFL_VIB_OUT.Name = "FALCON_CHFL_VIB_OUT";
            this.FALCON_CHFL_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FALCON_CHFL_VIB_OUT.TabIndex = 150;
            this.FALCON_CHFL_VIB_OUT.Text = "0";
            // 
            // label105
            // 
            this.label105.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label105.Location = new System.Drawing.Point(242, 244);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(15, 15);
            this.label105.TabIndex = 149;
            this.label105.Text = "%";
            // 
            // FALCON_CHFL_VIB_PER
            // 
            this.FALCON_CHFL_VIB_PER.FormattingEnabled = true;
            this.FALCON_CHFL_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FALCON_CHFL_VIB_PER.Location = new System.Drawing.Point(183, 240);
            this.FALCON_CHFL_VIB_PER.Name = "FALCON_CHFL_VIB_PER";
            this.FALCON_CHFL_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FALCON_CHFL_VIB_PER.TabIndex = 148;
            this.FALCON_CHFL_VIB_PER.Text = "100";
            this.FALCON_CHFL_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FALCON_CHFL_VIB_PER_SelectedIndexChanged);
            // 
            // FALCON_CHFL_CHK
            // 
            this.FALCON_CHFL_CHK.AutoSize = true;
            this.FALCON_CHFL_CHK.Checked = true;
            this.FALCON_CHFL_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FALCON_CHFL_CHK.Location = new System.Drawing.Point(20, 244);
            this.FALCON_CHFL_CHK.Name = "FALCON_CHFL_CHK";
            this.FALCON_CHFL_CHK.Size = new System.Drawing.Size(98, 16);
            this.FALCON_CHFL_CHK.TabIndex = 147;
            this.FALCON_CHFL_CHK.Text = "채프/플레어 :";
            this.FALCON_CHFL_CHK.UseVisualStyleBackColor = true;
            this.FALCON_CHFL_CHK.CheckedChanged += new System.EventHandler(this.FALCON_CHFL_CHK_CheckedChanged);
            // 
            // FALCON_CHFL_VIB
            // 
            this.FALCON_CHFL_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_CHFL_VIB.Location = new System.Drawing.Point(143, 245);
            this.FALCON_CHFL_VIB.Name = "FALCON_CHFL_VIB";
            this.FALCON_CHFL_VIB.Size = new System.Drawing.Size(40, 15);
            this.FALCON_CHFL_VIB.TabIndex = 146;
            this.FALCON_CHFL_VIB.Text = "0";
            // 
            // FALCON_AIRBREAK_VIB_OUT
            // 
            this.FALCON_AIRBREAK_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_AIRBREAK_VIB_OUT.Location = new System.Drawing.Point(348, 224);
            this.FALCON_AIRBREAK_VIB_OUT.Name = "FALCON_AIRBREAK_VIB_OUT";
            this.FALCON_AIRBREAK_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FALCON_AIRBREAK_VIB_OUT.TabIndex = 145;
            this.FALCON_AIRBREAK_VIB_OUT.Text = "0";
            // 
            // label108
            // 
            this.label108.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label108.Location = new System.Drawing.Point(242, 223);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(15, 15);
            this.label108.TabIndex = 144;
            this.label108.Text = "%";
            // 
            // FALCON_AIRBREAK_VIB_PER
            // 
            this.FALCON_AIRBREAK_VIB_PER.FormattingEnabled = true;
            this.FALCON_AIRBREAK_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FALCON_AIRBREAK_VIB_PER.Location = new System.Drawing.Point(183, 219);
            this.FALCON_AIRBREAK_VIB_PER.Name = "FALCON_AIRBREAK_VIB_PER";
            this.FALCON_AIRBREAK_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FALCON_AIRBREAK_VIB_PER.TabIndex = 143;
            this.FALCON_AIRBREAK_VIB_PER.Text = "100";
            this.FALCON_AIRBREAK_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FALCON_AIRBREAK_VIB_PER_SelectedIndexChanged);
            // 
            // FALCON_AIRBREAK_CHK
            // 
            this.FALCON_AIRBREAK_CHK.AutoSize = true;
            this.FALCON_AIRBREAK_CHK.Checked = true;
            this.FALCON_AIRBREAK_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FALCON_AIRBREAK_CHK.Location = new System.Drawing.Point(20, 223);
            this.FALCON_AIRBREAK_CHK.Name = "FALCON_AIRBREAK_CHK";
            this.FALCON_AIRBREAK_CHK.Size = new System.Drawing.Size(116, 16);
            this.FALCON_AIRBREAK_CHK.TabIndex = 142;
            this.FALCON_AIRBREAK_CHK.Text = "스피드브레이크 :";
            this.FALCON_AIRBREAK_CHK.UseVisualStyleBackColor = true;
            this.FALCON_AIRBREAK_CHK.CheckedChanged += new System.EventHandler(this.FALCON_AIRBREAK_CHK_CheckedChanged);
            // 
            // FALCON_AIRBREAK_VIB
            // 
            this.FALCON_AIRBREAK_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_AIRBREAK_VIB.Location = new System.Drawing.Point(143, 224);
            this.FALCON_AIRBREAK_VIB.Name = "FALCON_AIRBREAK_VIB";
            this.FALCON_AIRBREAK_VIB.Size = new System.Drawing.Size(40, 15);
            this.FALCON_AIRBREAK_VIB.TabIndex = 141;
            this.FALCON_AIRBREAK_VIB.Text = "0";
            // 
            // FALCON_GEAR_VIB_OUT
            // 
            this.FALCON_GEAR_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_GEAR_VIB_OUT.Location = new System.Drawing.Point(348, 202);
            this.FALCON_GEAR_VIB_OUT.Name = "FALCON_GEAR_VIB_OUT";
            this.FALCON_GEAR_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FALCON_GEAR_VIB_OUT.TabIndex = 140;
            this.FALCON_GEAR_VIB_OUT.Text = "0";
            // 
            // label111
            // 
            this.label111.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label111.Location = new System.Drawing.Point(242, 201);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(15, 15);
            this.label111.TabIndex = 139;
            this.label111.Text = "%";
            // 
            // FALCON_GEAR_VIB_PER
            // 
            this.FALCON_GEAR_VIB_PER.FormattingEnabled = true;
            this.FALCON_GEAR_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FALCON_GEAR_VIB_PER.Location = new System.Drawing.Point(183, 197);
            this.FALCON_GEAR_VIB_PER.Name = "FALCON_GEAR_VIB_PER";
            this.FALCON_GEAR_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FALCON_GEAR_VIB_PER.TabIndex = 138;
            this.FALCON_GEAR_VIB_PER.Text = "100";
            this.FALCON_GEAR_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FALCON_GEAR_VIB_PER_SelectedIndexChanged);
            // 
            // FALCON_GEAR_CHK
            // 
            this.FALCON_GEAR_CHK.AutoSize = true;
            this.FALCON_GEAR_CHK.Checked = true;
            this.FALCON_GEAR_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FALCON_GEAR_CHK.Location = new System.Drawing.Point(20, 201);
            this.FALCON_GEAR_CHK.Name = "FALCON_GEAR_CHK";
            this.FALCON_GEAR_CHK.Size = new System.Drawing.Size(80, 16);
            this.FALCON_GEAR_CHK.TabIndex = 137;
            this.FALCON_GEAR_CHK.Text = "랜딩기어 :";
            this.FALCON_GEAR_CHK.UseVisualStyleBackColor = true;
            this.FALCON_GEAR_CHK.CheckedChanged += new System.EventHandler(this.FALCON_GEAR_CHK_CheckedChanged);
            // 
            // FALCON_GEAR_VIB
            // 
            this.FALCON_GEAR_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_GEAR_VIB.Location = new System.Drawing.Point(143, 202);
            this.FALCON_GEAR_VIB.Name = "FALCON_GEAR_VIB";
            this.FALCON_GEAR_VIB.Size = new System.Drawing.Size(40, 15);
            this.FALCON_GEAR_VIB.TabIndex = 136;
            this.FALCON_GEAR_VIB.Text = "0";
            // 
            // FALCON_PAYLOAD_VIB_OUT
            // 
            this.FALCON_PAYLOAD_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_PAYLOAD_VIB_OUT.Location = new System.Drawing.Point(348, 180);
            this.FALCON_PAYLOAD_VIB_OUT.Name = "FALCON_PAYLOAD_VIB_OUT";
            this.FALCON_PAYLOAD_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FALCON_PAYLOAD_VIB_OUT.TabIndex = 135;
            this.FALCON_PAYLOAD_VIB_OUT.Text = "0";
            // 
            // label114
            // 
            this.label114.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label114.Location = new System.Drawing.Point(242, 179);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(15, 15);
            this.label114.TabIndex = 134;
            this.label114.Text = "%";
            // 
            // FALCON_PAYLOAD_VIB_PER
            // 
            this.FALCON_PAYLOAD_VIB_PER.FormattingEnabled = true;
            this.FALCON_PAYLOAD_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FALCON_PAYLOAD_VIB_PER.Location = new System.Drawing.Point(183, 175);
            this.FALCON_PAYLOAD_VIB_PER.Name = "FALCON_PAYLOAD_VIB_PER";
            this.FALCON_PAYLOAD_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FALCON_PAYLOAD_VIB_PER.TabIndex = 133;
            this.FALCON_PAYLOAD_VIB_PER.Text = "100";
            this.FALCON_PAYLOAD_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FALCON_PAYLOAD_VIB_PER_SelectedIndexChanged);
            // 
            // FALCON_PAYLOAD_CHK
            // 
            this.FALCON_PAYLOAD_CHK.AutoSize = true;
            this.FALCON_PAYLOAD_CHK.Checked = true;
            this.FALCON_PAYLOAD_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FALCON_PAYLOAD_CHK.Location = new System.Drawing.Point(20, 179);
            this.FALCON_PAYLOAD_CHK.Name = "FALCON_PAYLOAD_CHK";
            this.FALCON_PAYLOAD_CHK.Size = new System.Drawing.Size(98, 16);
            this.FALCON_PAYLOAD_CHK.TabIndex = 132;
            this.FALCON_PAYLOAD_CHK.Text = "미사일/폭탄 :";
            this.FALCON_PAYLOAD_CHK.UseVisualStyleBackColor = true;
            this.FALCON_PAYLOAD_CHK.CheckedChanged += new System.EventHandler(this.FALCON_PAYLOAD_CHK_CheckedChanged);
            // 
            // FALCON_PAYLOAD_VIB
            // 
            this.FALCON_PAYLOAD_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_PAYLOAD_VIB.Location = new System.Drawing.Point(143, 180);
            this.FALCON_PAYLOAD_VIB.Name = "FALCON_PAYLOAD_VIB";
            this.FALCON_PAYLOAD_VIB.Size = new System.Drawing.Size(40, 15);
            this.FALCON_PAYLOAD_VIB.TabIndex = 131;
            this.FALCON_PAYLOAD_VIB.Text = "0";
            // 
            // FALCON_GUN_VIB_OUT
            // 
            this.FALCON_GUN_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_GUN_VIB_OUT.Location = new System.Drawing.Point(348, 158);
            this.FALCON_GUN_VIB_OUT.Name = "FALCON_GUN_VIB_OUT";
            this.FALCON_GUN_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FALCON_GUN_VIB_OUT.TabIndex = 130;
            this.FALCON_GUN_VIB_OUT.Text = "0";
            // 
            // label117
            // 
            this.label117.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label117.Location = new System.Drawing.Point(242, 157);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(15, 15);
            this.label117.TabIndex = 129;
            this.label117.Text = "%";
            // 
            // FALCON_GUN_VIB_PER
            // 
            this.FALCON_GUN_VIB_PER.FormattingEnabled = true;
            this.FALCON_GUN_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FALCON_GUN_VIB_PER.Location = new System.Drawing.Point(183, 153);
            this.FALCON_GUN_VIB_PER.Name = "FALCON_GUN_VIB_PER";
            this.FALCON_GUN_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FALCON_GUN_VIB_PER.TabIndex = 128;
            this.FALCON_GUN_VIB_PER.Text = "100";
            this.FALCON_GUN_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FALCON_GUN_VIB_PER_SelectedIndexChanged);
            // 
            // FALCON_GUN_CHK
            // 
            this.FALCON_GUN_CHK.AutoSize = true;
            this.FALCON_GUN_CHK.Checked = true;
            this.FALCON_GUN_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FALCON_GUN_CHK.Location = new System.Drawing.Point(20, 157);
            this.FALCON_GUN_CHK.Name = "FALCON_GUN_CHK";
            this.FALCON_GUN_CHK.Size = new System.Drawing.Size(56, 16);
            this.FALCON_GUN_CHK.TabIndex = 127;
            this.FALCON_GUN_CHK.Text = "기총 :";
            this.FALCON_GUN_CHK.UseVisualStyleBackColor = true;
            this.FALCON_GUN_CHK.CheckedChanged += new System.EventHandler(this.FALCON_GUN_CHK_CheckedChanged);
            // 
            // FALCON_GUN_VIB
            // 
            this.FALCON_GUN_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_GUN_VIB.Location = new System.Drawing.Point(143, 158);
            this.FALCON_GUN_VIB.Name = "FALCON_GUN_VIB";
            this.FALCON_GUN_VIB.Size = new System.Drawing.Size(40, 15);
            this.FALCON_GUN_VIB.TabIndex = 126;
            this.FALCON_GUN_VIB.Text = "0";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label119.Location = new System.Drawing.Point(347, 26);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(63, 13);
            this.label119.TabIndex = 125;
            this.label119.Text = "최종진동";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label120.Location = new System.Drawing.Point(180, 26);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(63, 13);
            this.label120.TabIndex = 124;
            this.label120.Text = "진동보정";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label121.Location = new System.Drawing.Point(132, 26);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(35, 13);
            this.label121.TabIndex = 123;
            this.label121.Text = "진동";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label122.Location = new System.Drawing.Point(19, 26);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(35, 13);
            this.label122.TabIndex = 122;
            this.label122.Text = "항목";
            // 
            // DEFAULT_SETUP_FALCON
            // 
            this.DEFAULT_SETUP_FALCON.Location = new System.Drawing.Point(368, 292);
            this.DEFAULT_SETUP_FALCON.Name = "DEFAULT_SETUP_FALCON";
            this.DEFAULT_SETUP_FALCON.Size = new System.Drawing.Size(62, 25);
            this.DEFAULT_SETUP_FALCON.TabIndex = 121;
            this.DEFAULT_SETUP_FALCON.Text = "기본값";
            this.DEFAULT_SETUP_FALCON.UseVisualStyleBackColor = true;
            this.DEFAULT_SETUP_FALCON.Click += new System.EventHandler(this.DEFAULT_SETUP_FALCON_Click);
            // 
            // FALCON_BUNNER_VIB_OUT
            // 
            this.FALCON_BUNNER_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_BUNNER_VIB_OUT.Location = new System.Drawing.Point(348, 135);
            this.FALCON_BUNNER_VIB_OUT.Name = "FALCON_BUNNER_VIB_OUT";
            this.FALCON_BUNNER_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FALCON_BUNNER_VIB_OUT.TabIndex = 118;
            this.FALCON_BUNNER_VIB_OUT.Text = "0";
            // 
            // FALCON_AOA_VIB_OUT
            // 
            this.FALCON_AOA_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_AOA_VIB_OUT.Location = new System.Drawing.Point(348, 113);
            this.FALCON_AOA_VIB_OUT.Name = "FALCON_AOA_VIB_OUT";
            this.FALCON_AOA_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FALCON_AOA_VIB_OUT.TabIndex = 116;
            this.FALCON_AOA_VIB_OUT.Text = "0";
            // 
            // FALCON_YAW_VIB_OUT
            // 
            this.FALCON_YAW_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_YAW_VIB_OUT.Location = new System.Drawing.Point(348, 93);
            this.FALCON_YAW_VIB_OUT.Name = "FALCON_YAW_VIB_OUT";
            this.FALCON_YAW_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FALCON_YAW_VIB_OUT.TabIndex = 112;
            this.FALCON_YAW_VIB_OUT.Text = "0";
            // 
            // label126
            // 
            this.label126.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label126.Location = new System.Drawing.Point(188, 300);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(102, 15);
            this.label126.TabIndex = 111;
            this.label126.Text = "최대진동 AOA";
            // 
            // label127
            // 
            this.label127.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label127.Location = new System.Drawing.Point(21, 300);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(102, 15);
            this.label127.TabIndex = 110;
            this.label127.Text = "진동시작 AOA";
            // 
            // label128
            // 
            this.label128.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label128.Location = new System.Drawing.Point(242, 134);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(15, 15);
            this.label128.TabIndex = 107;
            this.label128.Text = "%";
            // 
            // label129
            // 
            this.label129.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label129.Location = new System.Drawing.Point(242, 112);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(15, 15);
            this.label129.TabIndex = 105;
            this.label129.Text = "%";
            // 
            // label130
            // 
            this.label130.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label130.Location = new System.Drawing.Point(242, 92);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(15, 15);
            this.label130.TabIndex = 101;
            this.label130.Text = "%";
            // 
            // FALCON_BUNNER_VIB_PER
            // 
            this.FALCON_BUNNER_VIB_PER.FormattingEnabled = true;
            this.FALCON_BUNNER_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FALCON_BUNNER_VIB_PER.Location = new System.Drawing.Point(183, 130);
            this.FALCON_BUNNER_VIB_PER.Name = "FALCON_BUNNER_VIB_PER";
            this.FALCON_BUNNER_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FALCON_BUNNER_VIB_PER.TabIndex = 94;
            this.FALCON_BUNNER_VIB_PER.Text = "100";
            this.FALCON_BUNNER_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FALCON_BUNNER_VIB_PER_SelectedIndexChanged);
            // 
            // FALCON_AOA_VIB_PER
            // 
            this.FALCON_AOA_VIB_PER.FormattingEnabled = true;
            this.FALCON_AOA_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FALCON_AOA_VIB_PER.Location = new System.Drawing.Point(183, 108);
            this.FALCON_AOA_VIB_PER.Name = "FALCON_AOA_VIB_PER";
            this.FALCON_AOA_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FALCON_AOA_VIB_PER.TabIndex = 93;
            this.FALCON_AOA_VIB_PER.Text = "100";
            this.FALCON_AOA_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FALCON_AOA_VIB_PER_SelectedIndexChanged);
            // 
            // FALCON_YAW_VIB_PER
            // 
            this.FALCON_YAW_VIB_PER.FormattingEnabled = true;
            this.FALCON_YAW_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FALCON_YAW_VIB_PER.Location = new System.Drawing.Point(183, 86);
            this.FALCON_YAW_VIB_PER.Name = "FALCON_YAW_VIB_PER";
            this.FALCON_YAW_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FALCON_YAW_VIB_PER.TabIndex = 92;
            this.FALCON_YAW_VIB_PER.Text = "100";
            this.FALCON_YAW_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FALCON_YAW_VIB_PER_SelectedIndexChanged);
            // 
            // FALCON_AOA_M_COMBO
            // 
            this.FALCON_AOA_M_COMBO.FormattingEnabled = true;
            this.FALCON_AOA_M_COMBO.Items.AddRange(new object[] {
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.FALCON_AOA_M_COMBO.Location = new System.Drawing.Point(297, 295);
            this.FALCON_AOA_M_COMBO.Name = "FALCON_AOA_M_COMBO";
            this.FALCON_AOA_M_COMBO.Size = new System.Drawing.Size(53, 20);
            this.FALCON_AOA_M_COMBO.TabIndex = 91;
            this.FALCON_AOA_M_COMBO.Text = "25";
            this.FALCON_AOA_M_COMBO.SelectedIndexChanged += new System.EventHandler(this.FALCON_AOA_M_COMBO_SelectedIndexChanged);
            // 
            // FALCON_AOA_S_COMBO
            // 
            this.FALCON_AOA_S_COMBO.FormattingEnabled = true;
            this.FALCON_AOA_S_COMBO.Items.AddRange(new object[] {
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5"});
            this.FALCON_AOA_S_COMBO.Location = new System.Drawing.Point(129, 295);
            this.FALCON_AOA_S_COMBO.Name = "FALCON_AOA_S_COMBO";
            this.FALCON_AOA_S_COMBO.Size = new System.Drawing.Size(53, 20);
            this.FALCON_AOA_S_COMBO.TabIndex = 69;
            this.FALCON_AOA_S_COMBO.Text = "13";
            this.FALCON_AOA_S_COMBO.SelectedIndexChanged += new System.EventHandler(this.FALCON_AOA_S_COMBO_SelectedIndexChanged);
            // 
            // FALCON_BUNNER_CHK
            // 
            this.FALCON_BUNNER_CHK.AutoSize = true;
            this.FALCON_BUNNER_CHK.Checked = true;
            this.FALCON_BUNNER_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FALCON_BUNNER_CHK.Location = new System.Drawing.Point(20, 134);
            this.FALCON_BUNNER_CHK.Name = "FALCON_BUNNER_CHK";
            this.FALCON_BUNNER_CHK.Size = new System.Drawing.Size(92, 16);
            this.FALCON_BUNNER_CHK.TabIndex = 83;
            this.FALCON_BUNNER_CHK.Text = "애프터버너 :";
            this.FALCON_BUNNER_CHK.UseVisualStyleBackColor = true;
            this.FALCON_BUNNER_CHK.CheckedChanged += new System.EventHandler(this.FALCON_BUNNER_CHK_CheckedChanged);
            // 
            // FALCON_AOA_CHK
            // 
            this.FALCON_AOA_CHK.AutoSize = true;
            this.FALCON_AOA_CHK.Checked = true;
            this.FALCON_AOA_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FALCON_AOA_CHK.Location = new System.Drawing.Point(20, 112);
            this.FALCON_AOA_CHK.Name = "FALCON_AOA_CHK";
            this.FALCON_AOA_CHK.Size = new System.Drawing.Size(57, 16);
            this.FALCON_AOA_CHK.TabIndex = 82;
            this.FALCON_AOA_CHK.Text = "AOA :";
            this.FALCON_AOA_CHK.UseVisualStyleBackColor = true;
            this.FALCON_AOA_CHK.CheckedChanged += new System.EventHandler(this.FALCON_AOA_CHK_CheckedChanged);
            // 
            // FALCON_YAW_CHK
            // 
            this.FALCON_YAW_CHK.AutoSize = true;
            this.FALCON_YAW_CHK.Checked = true;
            this.FALCON_YAW_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FALCON_YAW_CHK.Location = new System.Drawing.Point(20, 92);
            this.FALCON_YAW_CHK.Name = "FALCON_YAW_CHK";
            this.FALCON_YAW_CHK.Size = new System.Drawing.Size(58, 16);
            this.FALCON_YAW_CHK.TabIndex = 81;
            this.FALCON_YAW_CHK.Text = "YAW :";
            this.FALCON_YAW_CHK.UseVisualStyleBackColor = true;
            this.FALCON_YAW_CHK.CheckedChanged += new System.EventHandler(this.FALCON_YAW_CHK_CheckedChanged);
            // 
            // FALCON_BUNNER_VIB
            // 
            this.FALCON_BUNNER_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_BUNNER_VIB.Location = new System.Drawing.Point(143, 135);
            this.FALCON_BUNNER_VIB.Name = "FALCON_BUNNER_VIB";
            this.FALCON_BUNNER_VIB.Size = new System.Drawing.Size(40, 15);
            this.FALCON_BUNNER_VIB.TabIndex = 71;
            this.FALCON_BUNNER_VIB.Text = "0";
            // 
            // FALCON_AOA_VIB
            // 
            this.FALCON_AOA_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_AOA_VIB.Location = new System.Drawing.Point(143, 113);
            this.FALCON_AOA_VIB.Name = "FALCON_AOA_VIB";
            this.FALCON_AOA_VIB.Size = new System.Drawing.Size(40, 15);
            this.FALCON_AOA_VIB.TabIndex = 70;
            this.FALCON_AOA_VIB.Text = "0";
            // 
            // FALCON_YAW_VIB
            // 
            this.FALCON_YAW_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FALCON_YAW_VIB.Location = new System.Drawing.Point(143, 93);
            this.FALCON_YAW_VIB.Name = "FALCON_YAW_VIB";
            this.FALCON_YAW_VIB.Size = new System.Drawing.Size(40, 15);
            this.FALCON_YAW_VIB.TabIndex = 54;
            this.FALCON_YAW_VIB.Text = "0";
            // 
            // Connect_FALCON
            // 
            this.Connect_FALCON.Location = new System.Drawing.Point(337, 629);
            this.Connect_FALCON.Name = "Connect_FALCON";
            this.Connect_FALCON.Size = new System.Drawing.Size(109, 32);
            this.Connect_FALCON.TabIndex = 3;
            this.Connect_FALCON.Text = "Connect";
            this.Connect_FALCON.UseVisualStyleBackColor = true;
            this.Connect_FALCON.Click += new System.EventHandler(this.Connect_FALCON_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label97);
            this.groupBox9.Controls.Add(this.FALCON_INGAME);
            this.groupBox9.Controls.Add(this.label85);
            this.groupBox9.Controls.Add(this.FALCON_DAMAGE);
            this.groupBox9.Controls.Add(this.label78);
            this.groupBox9.Controls.Add(this.FALCON_IAS);
            this.groupBox9.Controls.Add(this.label96);
            this.groupBox9.Controls.Add(this.FALCON_NOZZLE);
            this.groupBox9.Controls.Add(this.label92);
            this.groupBox9.Controls.Add(this.FALCON_FLARE);
            this.groupBox9.Controls.Add(this.label89);
            this.groupBox9.Controls.Add(this.FALCON_CHAFF);
            this.groupBox9.Controls.Add(this.label80);
            this.groupBox9.Controls.Add(this.FALCON_BOMB);
            this.groupBox9.Controls.Add(this.label73);
            this.groupBox9.Controls.Add(this.FALCON_AG);
            this.groupBox9.Controls.Add(this.label81);
            this.groupBox9.Controls.Add(this.FALCON_DAMAGE_F);
            this.groupBox9.Controls.Add(this.label82);
            this.groupBox9.Controls.Add(this.FALCON_AA);
            this.groupBox9.Controls.Add(this.label88);
            this.groupBox9.Controls.Add(this.FALCON_FIREGUN);
            this.groupBox9.Controls.Add(this.label87);
            this.groupBox9.Controls.Add(this.FALCON_AOA);
            this.groupBox9.Controls.Add(this.label79);
            this.groupBox9.Controls.Add(this.FALCON_BREAK);
            this.groupBox9.Controls.Add(this.label74);
            this.groupBox9.Controls.Add(this.FALCON_GEAR);
            this.groupBox9.Controls.Add(this.label63);
            this.groupBox9.Controls.Add(this.FALCON_X);
            this.groupBox9.Controls.Add(this.label101);
            this.groupBox9.Controls.Add(this.label103);
            this.groupBox9.Controls.Add(this.FALCON_Y);
            this.groupBox9.Controls.Add(this.FALCON_Z);
            this.groupBox9.Location = new System.Drawing.Point(12, 18);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(434, 173);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "FALCON BMS 출력값";
            // 
            // label97
            // 
            this.label97.Location = new System.Drawing.Point(199, 154);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(90, 16);
            this.label97.TabIndex = 114;
            this.label97.Text = "INGAME :";
            // 
            // FALCON_INGAME
            // 
            this.FALCON_INGAME.Location = new System.Drawing.Point(295, 154);
            this.FALCON_INGAME.Name = "FALCON_INGAME";
            this.FALCON_INGAME.Size = new System.Drawing.Size(82, 16);
            this.FALCON_INGAME.TabIndex = 113;
            this.FALCON_INGAME.Text = "0";
            // 
            // label85
            // 
            this.label85.Location = new System.Drawing.Point(199, 122);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(90, 16);
            this.label85.TabIndex = 112;
            this.label85.Text = "DAMEGE :";
            // 
            // FALCON_DAMAGE
            // 
            this.FALCON_DAMAGE.Location = new System.Drawing.Point(295, 122);
            this.FALCON_DAMAGE.Name = "FALCON_DAMAGE";
            this.FALCON_DAMAGE.Size = new System.Drawing.Size(82, 16);
            this.FALCON_DAMAGE.TabIndex = 111;
            this.FALCON_DAMAGE.Text = "0";
            // 
            // label78
            // 
            this.label78.Location = new System.Drawing.Point(199, 26);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(90, 16);
            this.label78.TabIndex = 110;
            this.label78.Text = "IAS :";
            // 
            // FALCON_IAS
            // 
            this.FALCON_IAS.Location = new System.Drawing.Point(295, 26);
            this.FALCON_IAS.Name = "FALCON_IAS";
            this.FALCON_IAS.Size = new System.Drawing.Size(82, 16);
            this.FALCON_IAS.TabIndex = 109;
            this.FALCON_IAS.Text = "0";
            // 
            // label96
            // 
            this.label96.Location = new System.Drawing.Point(14, 89);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(90, 16);
            this.label96.TabIndex = 108;
            this.label96.Text = "NOZZLE :";
            // 
            // FALCON_NOZZLE
            // 
            this.FALCON_NOZZLE.Location = new System.Drawing.Point(110, 89);
            this.FALCON_NOZZLE.Name = "FALCON_NOZZLE";
            this.FALCON_NOZZLE.Size = new System.Drawing.Size(82, 16);
            this.FALCON_NOZZLE.TabIndex = 107;
            this.FALCON_NOZZLE.Text = "0";
            // 
            // label92
            // 
            this.label92.Location = new System.Drawing.Point(199, 90);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(90, 16);
            this.label92.TabIndex = 104;
            this.label92.Text = "DROP FLARE :";
            // 
            // FALCON_FLARE
            // 
            this.FALCON_FLARE.Location = new System.Drawing.Point(295, 90);
            this.FALCON_FLARE.Name = "FALCON_FLARE";
            this.FALCON_FLARE.Size = new System.Drawing.Size(82, 16);
            this.FALCON_FLARE.TabIndex = 103;
            this.FALCON_FLARE.Text = "0";
            // 
            // label89
            // 
            this.label89.Location = new System.Drawing.Point(199, 74);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(90, 16);
            this.label89.TabIndex = 102;
            this.label89.Text = "DROP CHAFF :";
            // 
            // FALCON_CHAFF
            // 
            this.FALCON_CHAFF.Location = new System.Drawing.Point(295, 74);
            this.FALCON_CHAFF.Name = "FALCON_CHAFF";
            this.FALCON_CHAFF.Size = new System.Drawing.Size(82, 16);
            this.FALCON_CHAFF.TabIndex = 101;
            this.FALCON_CHAFF.Text = "0";
            // 
            // label80
            // 
            this.label80.Location = new System.Drawing.Point(15, 154);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(90, 16);
            this.label80.TabIndex = 100;
            this.label80.Text = "FIRE_BOMB :";
            // 
            // FALCON_BOMB
            // 
            this.FALCON_BOMB.Location = new System.Drawing.Point(111, 154);
            this.FALCON_BOMB.Name = "FALCON_BOMB";
            this.FALCON_BOMB.Size = new System.Drawing.Size(82, 16);
            this.FALCON_BOMB.TabIndex = 99;
            this.FALCON_BOMB.Text = "0";
            // 
            // label73
            // 
            this.label73.Location = new System.Drawing.Point(14, 138);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(90, 16);
            this.label73.TabIndex = 98;
            this.label73.Text = "FIRE_AG :";
            // 
            // FALCON_AG
            // 
            this.FALCON_AG.Location = new System.Drawing.Point(111, 138);
            this.FALCON_AG.Name = "FALCON_AG";
            this.FALCON_AG.Size = new System.Drawing.Size(82, 16);
            this.FALCON_AG.TabIndex = 97;
            this.FALCON_AG.Text = "0";
            // 
            // label81
            // 
            this.label81.Location = new System.Drawing.Point(199, 106);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(90, 16);
            this.label81.TabIndex = 96;
            this.label81.Text = "DAMEGE_F :";
            // 
            // FALCON_DAMAGE_F
            // 
            this.FALCON_DAMAGE_F.Location = new System.Drawing.Point(295, 106);
            this.FALCON_DAMAGE_F.Name = "FALCON_DAMAGE_F";
            this.FALCON_DAMAGE_F.Size = new System.Drawing.Size(82, 16);
            this.FALCON_DAMAGE_F.TabIndex = 95;
            this.FALCON_DAMAGE_F.Text = "0";
            // 
            // label82
            // 
            this.label82.Location = new System.Drawing.Point(15, 122);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(90, 16);
            this.label82.TabIndex = 92;
            this.label82.Text = "FIRE_AA :";
            // 
            // FALCON_AA
            // 
            this.FALCON_AA.Location = new System.Drawing.Point(111, 122);
            this.FALCON_AA.Name = "FALCON_AA";
            this.FALCON_AA.Size = new System.Drawing.Size(82, 16);
            this.FALCON_AA.TabIndex = 91;
            this.FALCON_AA.Text = "0";
            // 
            // label88
            // 
            this.label88.Location = new System.Drawing.Point(15, 106);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(90, 16);
            this.label88.TabIndex = 90;
            this.label88.Text = "FIRE_GUN :";
            // 
            // FALCON_FIREGUN
            // 
            this.FALCON_FIREGUN.Location = new System.Drawing.Point(111, 106);
            this.FALCON_FIREGUN.Name = "FALCON_FIREGUN";
            this.FALCON_FIREGUN.Size = new System.Drawing.Size(82, 16);
            this.FALCON_FIREGUN.TabIndex = 89;
            this.FALCON_FIREGUN.Text = "False";
            // 
            // label87
            // 
            this.label87.Location = new System.Drawing.Point(15, 73);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(90, 16);
            this.label87.TabIndex = 88;
            this.label87.Text = "AOA :";
            // 
            // FALCON_AOA
            // 
            this.FALCON_AOA.Location = new System.Drawing.Point(111, 73);
            this.FALCON_AOA.Name = "FALCON_AOA";
            this.FALCON_AOA.Size = new System.Drawing.Size(82, 16);
            this.FALCON_AOA.TabIndex = 87;
            this.FALCON_AOA.Text = "0";
            // 
            // label79
            // 
            this.label79.Location = new System.Drawing.Point(199, 58);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(90, 16);
            this.label79.TabIndex = 80;
            this.label79.Text = "AIRBREAK :";
            // 
            // FALCON_BREAK
            // 
            this.FALCON_BREAK.Location = new System.Drawing.Point(295, 58);
            this.FALCON_BREAK.Name = "FALCON_BREAK";
            this.FALCON_BREAK.Size = new System.Drawing.Size(82, 16);
            this.FALCON_BREAK.TabIndex = 79;
            this.FALCON_BREAK.Text = "0";
            // 
            // label74
            // 
            this.label74.Location = new System.Drawing.Point(199, 42);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(90, 16);
            this.label74.TabIndex = 78;
            this.label74.Text = "GEAR :";
            // 
            // FALCON_GEAR
            // 
            this.FALCON_GEAR.Location = new System.Drawing.Point(295, 42);
            this.FALCON_GEAR.Name = "FALCON_GEAR";
            this.FALCON_GEAR.Size = new System.Drawing.Size(82, 16);
            this.FALCON_GEAR.TabIndex = 77;
            this.FALCON_GEAR.Text = "0";
            // 
            // label63
            // 
            this.label63.Location = new System.Drawing.Point(15, 26);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(60, 16);
            this.label63.TabIndex = 70;
            this.label63.Text = "X :";
            // 
            // FALCON_X
            // 
            this.FALCON_X.Location = new System.Drawing.Point(111, 26);
            this.FALCON_X.Name = "FALCON_X";
            this.FALCON_X.Size = new System.Drawing.Size(82, 16);
            this.FALCON_X.TabIndex = 69;
            this.FALCON_X.Text = "0";
            // 
            // label101
            // 
            this.label101.Location = new System.Drawing.Point(15, 57);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(90, 16);
            this.label101.TabIndex = 32;
            this.label101.Text = "Z :";
            // 
            // label103
            // 
            this.label103.Location = new System.Drawing.Point(14, 42);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(90, 16);
            this.label103.TabIndex = 31;
            this.label103.Text = "Y :";
            // 
            // FALCON_Y
            // 
            this.FALCON_Y.Location = new System.Drawing.Point(111, 42);
            this.FALCON_Y.Name = "FALCON_Y";
            this.FALCON_Y.Size = new System.Drawing.Size(82, 15);
            this.FALCON_Y.TabIndex = 30;
            this.FALCON_Y.Text = "0";
            // 
            // FALCON_Z
            // 
            this.FALCON_Z.Location = new System.Drawing.Point(111, 57);
            this.FALCON_Z.Name = "FALCON_Z";
            this.FALCON_Z.Size = new System.Drawing.Size(82, 16);
            this.FALCON_Z.TabIndex = 31;
            this.FALCON_Z.Text = "0";
            // 
            // WARTHUNDER
            // 
            this.WARTHUNDER.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WARTHUNDER.Controls.Add(this.groupBox8);
            this.WARTHUNDER.Controls.Add(this.groupBox7);
            this.WARTHUNDER.Controls.Add(this.Connect_WT);
            this.WARTHUNDER.Controls.Add(this.groupBox6);
            this.WARTHUNDER.Location = new System.Drawing.Point(4, 22);
            this.WARTHUNDER.Name = "WARTHUNDER";
            this.WARTHUNDER.Size = new System.Drawing.Size(463, 674);
            this.WARTHUNDER.TabIndex = 2;
            this.WARTHUNDER.Text = "WARTHUNDER";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.WT_VIB_OUT);
            this.groupBox8.Location = new System.Drawing.Point(12, 545);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(432, 78);
            this.groupBox8.TabIndex = 70;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "최종출력";
            // 
            // WT_VIB_OUT
            // 
            this.WT_VIB_OUT.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_VIB_OUT.Location = new System.Drawing.Point(15, 29);
            this.WT_VIB_OUT.Name = "WT_VIB_OUT";
            this.WT_VIB_OUT.Size = new System.Drawing.Size(219, 31);
            this.WT_VIB_OUT.TabIndex = 122;
            this.WT_VIB_OUT.Text = "0";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.WT_WX_VIB_MIN);
            this.groupBox7.Controls.Add(this.WT_NY_VIB_MIN);
            this.groupBox7.Controls.Add(this.label94);
            this.groupBox7.Controls.Add(this.WT_AOS_VIB_MIN);
            this.groupBox7.Controls.Add(this.WT_WEP_VIB_OUT);
            this.groupBox7.Controls.Add(this.label75);
            this.groupBox7.Controls.Add(this.WT_WEP_VIB_PER);
            this.groupBox7.Controls.Add(this.WT_WEP_CHK);
            this.groupBox7.Controls.Add(this.WT_WEP_VIB);
            this.groupBox7.Controls.Add(this.WT_GUN_VIB_OUT);
            this.groupBox7.Controls.Add(this.label71);
            this.groupBox7.Controls.Add(this.WT_GUN_VIB_PER);
            this.groupBox7.Controls.Add(this.WT_GUN_CHK);
            this.groupBox7.Controls.Add(this.WT_GUN_VIB);
            this.groupBox7.Controls.Add(this.WT_AIRBREAK_VIB_OUT);
            this.groupBox7.Controls.Add(this.label69);
            this.groupBox7.Controls.Add(this.WT_AIRBREAK_VIB_PER);
            this.groupBox7.Controls.Add(this.WT_AIRBREAK_CHK);
            this.groupBox7.Controls.Add(this.WT_AIRBREAK_VIB);
            this.groupBox7.Controls.Add(this.WT_GEAR_VIB_OUT);
            this.groupBox7.Controls.Add(this.label66);
            this.groupBox7.Controls.Add(this.WT_GEAR_VIB_PER);
            this.groupBox7.Controls.Add(this.WT_GEAR_CHK);
            this.groupBox7.Controls.Add(this.WT_GEAR_VIB);
            this.groupBox7.Controls.Add(this.WT_FLAP_VIB_OUT);
            this.groupBox7.Controls.Add(this.label65);
            this.groupBox7.Controls.Add(this.WT_FLAP_VIB_PER);
            this.groupBox7.Controls.Add(this.WT_FLAP_CHK);
            this.groupBox7.Controls.Add(this.WT_FLAP_VIB);
            this.groupBox7.Controls.Add(this.WT_AOA_VIB_OUT);
            this.groupBox7.Controls.Add(this.label64);
            this.groupBox7.Controls.Add(this.WT_AOA_VIB_PER);
            this.groupBox7.Controls.Add(this.WT_AOA_CHK);
            this.groupBox7.Controls.Add(this.WT_AOA_VIB);
            this.groupBox7.Controls.Add(this.label48);
            this.groupBox7.Controls.Add(this.label60);
            this.groupBox7.Controls.Add(this.label61);
            this.groupBox7.Controls.Add(this.label62);
            this.groupBox7.Controls.Add(this.DEFAULT_SETUP_WT);
            this.groupBox7.Controls.Add(this.WT_WX_VIB_OUT);
            this.groupBox7.Controls.Add(this.WT_NY_VIB_OUT);
            this.groupBox7.Controls.Add(this.WT_AOS_VIB_OUT);
            this.groupBox7.Controls.Add(this.label76);
            this.groupBox7.Controls.Add(this.label77);
            this.groupBox7.Controls.Add(this.label83);
            this.groupBox7.Controls.Add(this.label84);
            this.groupBox7.Controls.Add(this.label86);
            this.groupBox7.Controls.Add(this.WT_WX_VIB_PER);
            this.groupBox7.Controls.Add(this.WT_NY_VIB_PER);
            this.groupBox7.Controls.Add(this.WT_AOS_VIB_PER);
            this.groupBox7.Controls.Add(this.WT_AOA_M_COMBO);
            this.groupBox7.Controls.Add(this.WT_AOA_S_COMBO);
            this.groupBox7.Controls.Add(this.PLANE_LIST_COMBO_WT);
            this.groupBox7.Controls.Add(this.WT_WX_CHK);
            this.groupBox7.Controls.Add(this.WT_NY_CHK);
            this.groupBox7.Controls.Add(this.WT_AOS_CHK);
            this.groupBox7.Controls.Add(this.WT_WX_VIB);
            this.groupBox7.Controls.Add(this.WT_NY_VIB);
            this.groupBox7.Controls.Add(this.WT_AOS_VIB);
            this.groupBox7.Location = new System.Drawing.Point(12, 206);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(432, 333);
            this.groupBox7.TabIndex = 69;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "진동출력설정";
            // 
            // WT_WX_VIB_MIN
            // 
            this.WT_WX_VIB_MIN.Enabled = false;
            this.WT_WX_VIB_MIN.FormattingEnabled = true;
            this.WT_WX_VIB_MIN.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.WT_WX_VIB_MIN.Location = new System.Drawing.Point(261, 135);
            this.WT_WX_VIB_MIN.Name = "WT_WX_VIB_MIN";
            this.WT_WX_VIB_MIN.Size = new System.Drawing.Size(53, 20);
            this.WT_WX_VIB_MIN.TabIndex = 173;
            this.WT_WX_VIB_MIN.Text = "1";
            this.WT_WX_VIB_MIN.SelectedIndexChanged += new System.EventHandler(this.WT_WX_VIB_MIN_SelectedIndexChanged);
            // 
            // WT_NY_VIB_MIN
            // 
            this.WT_NY_VIB_MIN.Enabled = false;
            this.WT_NY_VIB_MIN.FormattingEnabled = true;
            this.WT_NY_VIB_MIN.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.WT_NY_VIB_MIN.Location = new System.Drawing.Point(261, 113);
            this.WT_NY_VIB_MIN.Name = "WT_NY_VIB_MIN";
            this.WT_NY_VIB_MIN.Size = new System.Drawing.Size(53, 20);
            this.WT_NY_VIB_MIN.TabIndex = 172;
            this.WT_NY_VIB_MIN.Text = "1";
            this.WT_NY_VIB_MIN.SelectedIndexChanged += new System.EventHandler(this.WT_NY_VIB_MIN_SelectedIndexChanged);
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label94.Location = new System.Drawing.Point(258, 71);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(77, 13);
            this.label94.TabIndex = 171;
            this.label94.Text = "진동시작값";
            // 
            // WT_AOS_VIB_MIN
            // 
            this.WT_AOS_VIB_MIN.Enabled = false;
            this.WT_AOS_VIB_MIN.FormattingEnabled = true;
            this.WT_AOS_VIB_MIN.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.WT_AOS_VIB_MIN.Location = new System.Drawing.Point(261, 91);
            this.WT_AOS_VIB_MIN.Name = "WT_AOS_VIB_MIN";
            this.WT_AOS_VIB_MIN.Size = new System.Drawing.Size(53, 20);
            this.WT_AOS_VIB_MIN.TabIndex = 170;
            this.WT_AOS_VIB_MIN.Text = "1";
            this.WT_AOS_VIB_MIN.SelectedIndexChanged += new System.EventHandler(this.WT_AOS_VIB_MIN_SelectedIndexChanged);
            // 
            // WT_WEP_VIB_OUT
            // 
            this.WT_WEP_VIB_OUT.Enabled = false;
            this.WT_WEP_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_WEP_VIB_OUT.Location = new System.Drawing.Point(347, 272);
            this.WT_WEP_VIB_OUT.Name = "WT_WEP_VIB_OUT";
            this.WT_WEP_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.WT_WEP_VIB_OUT.TabIndex = 155;
            this.WT_WEP_VIB_OUT.Text = "0";
            // 
            // label75
            // 
            this.label75.Enabled = false;
            this.label75.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label75.Location = new System.Drawing.Point(240, 271);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(15, 15);
            this.label75.TabIndex = 154;
            this.label75.Text = "%";
            // 
            // WT_WEP_VIB_PER
            // 
            this.WT_WEP_VIB_PER.Enabled = false;
            this.WT_WEP_VIB_PER.FormattingEnabled = true;
            this.WT_WEP_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.WT_WEP_VIB_PER.Location = new System.Drawing.Point(181, 267);
            this.WT_WEP_VIB_PER.Name = "WT_WEP_VIB_PER";
            this.WT_WEP_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.WT_WEP_VIB_PER.TabIndex = 153;
            this.WT_WEP_VIB_PER.Text = "100";
            this.WT_WEP_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.WT_WEP_VIB_PER_SelectedIndexChanged);
            // 
            // WT_WEP_CHK
            // 
            this.WT_WEP_CHK.AutoSize = true;
            this.WT_WEP_CHK.Checked = true;
            this.WT_WEP_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WT_WEP_CHK.Enabled = false;
            this.WT_WEP_CHK.Location = new System.Drawing.Point(18, 271);
            this.WT_WEP_CHK.Name = "WT_WEP_CHK";
            this.WT_WEP_CHK.Size = new System.Drawing.Size(114, 16);
            this.WT_WEP_CHK.TabIndex = 152;
            this.WT_WEP_CHK.Text = "WEP/BUNNER :";
            this.WT_WEP_CHK.UseVisualStyleBackColor = true;
            this.WT_WEP_CHK.CheckedChanged += new System.EventHandler(this.WT_WEP_CHK_CheckedChanged);
            // 
            // WT_WEP_VIB
            // 
            this.WT_WEP_VIB.Enabled = false;
            this.WT_WEP_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_WEP_VIB.Location = new System.Drawing.Point(141, 272);
            this.WT_WEP_VIB.Name = "WT_WEP_VIB";
            this.WT_WEP_VIB.Size = new System.Drawing.Size(40, 15);
            this.WT_WEP_VIB.TabIndex = 151;
            this.WT_WEP_VIB.Text = "0";
            // 
            // WT_GUN_VIB_OUT
            // 
            this.WT_GUN_VIB_OUT.Enabled = false;
            this.WT_GUN_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_GUN_VIB_OUT.Location = new System.Drawing.Point(347, 251);
            this.WT_GUN_VIB_OUT.Name = "WT_GUN_VIB_OUT";
            this.WT_GUN_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.WT_GUN_VIB_OUT.TabIndex = 150;
            this.WT_GUN_VIB_OUT.Text = "0";
            // 
            // label71
            // 
            this.label71.Enabled = false;
            this.label71.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label71.Location = new System.Drawing.Point(240, 250);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(15, 15);
            this.label71.TabIndex = 149;
            this.label71.Text = "%";
            // 
            // WT_GUN_VIB_PER
            // 
            this.WT_GUN_VIB_PER.Enabled = false;
            this.WT_GUN_VIB_PER.FormattingEnabled = true;
            this.WT_GUN_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.WT_GUN_VIB_PER.Location = new System.Drawing.Point(181, 246);
            this.WT_GUN_VIB_PER.Name = "WT_GUN_VIB_PER";
            this.WT_GUN_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.WT_GUN_VIB_PER.TabIndex = 148;
            this.WT_GUN_VIB_PER.Text = "100";
            this.WT_GUN_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.WT_GUN_VIB_PER_SelectedIndexChanged);
            // 
            // WT_GUN_CHK
            // 
            this.WT_GUN_CHK.AutoSize = true;
            this.WT_GUN_CHK.Checked = true;
            this.WT_GUN_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WT_GUN_CHK.Enabled = false;
            this.WT_GUN_CHK.Location = new System.Drawing.Point(18, 250);
            this.WT_GUN_CHK.Name = "WT_GUN_CHK";
            this.WT_GUN_CHK.Size = new System.Drawing.Size(56, 16);
            this.WT_GUN_CHK.TabIndex = 147;
            this.WT_GUN_CHK.Text = "기총 :";
            this.WT_GUN_CHK.UseVisualStyleBackColor = true;
            this.WT_GUN_CHK.CheckedChanged += new System.EventHandler(this.WT_GUN_CHK_CheckedChanged);
            // 
            // WT_GUN_VIB
            // 
            this.WT_GUN_VIB.Enabled = false;
            this.WT_GUN_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_GUN_VIB.Location = new System.Drawing.Point(141, 251);
            this.WT_GUN_VIB.Name = "WT_GUN_VIB";
            this.WT_GUN_VIB.Size = new System.Drawing.Size(40, 15);
            this.WT_GUN_VIB.TabIndex = 146;
            this.WT_GUN_VIB.Text = "0";
            // 
            // WT_AIRBREAK_VIB_OUT
            // 
            this.WT_AIRBREAK_VIB_OUT.Enabled = false;
            this.WT_AIRBREAK_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_AIRBREAK_VIB_OUT.Location = new System.Drawing.Point(347, 230);
            this.WT_AIRBREAK_VIB_OUT.Name = "WT_AIRBREAK_VIB_OUT";
            this.WT_AIRBREAK_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.WT_AIRBREAK_VIB_OUT.TabIndex = 145;
            this.WT_AIRBREAK_VIB_OUT.Text = "0";
            // 
            // label69
            // 
            this.label69.Enabled = false;
            this.label69.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label69.Location = new System.Drawing.Point(240, 229);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(15, 15);
            this.label69.TabIndex = 144;
            this.label69.Text = "%";
            // 
            // WT_AIRBREAK_VIB_PER
            // 
            this.WT_AIRBREAK_VIB_PER.Enabled = false;
            this.WT_AIRBREAK_VIB_PER.FormattingEnabled = true;
            this.WT_AIRBREAK_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.WT_AIRBREAK_VIB_PER.Location = new System.Drawing.Point(181, 225);
            this.WT_AIRBREAK_VIB_PER.Name = "WT_AIRBREAK_VIB_PER";
            this.WT_AIRBREAK_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.WT_AIRBREAK_VIB_PER.TabIndex = 143;
            this.WT_AIRBREAK_VIB_PER.Text = "100";
            this.WT_AIRBREAK_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.WT_AIRBREAK_VIB_PER_SelectedIndexChanged);
            // 
            // WT_AIRBREAK_CHK
            // 
            this.WT_AIRBREAK_CHK.AutoSize = true;
            this.WT_AIRBREAK_CHK.Checked = true;
            this.WT_AIRBREAK_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WT_AIRBREAK_CHK.Enabled = false;
            this.WT_AIRBREAK_CHK.Location = new System.Drawing.Point(18, 229);
            this.WT_AIRBREAK_CHK.Name = "WT_AIRBREAK_CHK";
            this.WT_AIRBREAK_CHK.Size = new System.Drawing.Size(116, 16);
            this.WT_AIRBREAK_CHK.TabIndex = 142;
            this.WT_AIRBREAK_CHK.Text = "스피드브레이크 :";
            this.WT_AIRBREAK_CHK.UseVisualStyleBackColor = true;
            this.WT_AIRBREAK_CHK.CheckedChanged += new System.EventHandler(this.WT_AIRBREAK_CHK_CheckedChanged);
            // 
            // WT_AIRBREAK_VIB
            // 
            this.WT_AIRBREAK_VIB.Enabled = false;
            this.WT_AIRBREAK_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_AIRBREAK_VIB.Location = new System.Drawing.Point(141, 230);
            this.WT_AIRBREAK_VIB.Name = "WT_AIRBREAK_VIB";
            this.WT_AIRBREAK_VIB.Size = new System.Drawing.Size(40, 15);
            this.WT_AIRBREAK_VIB.TabIndex = 141;
            this.WT_AIRBREAK_VIB.Text = "0";
            // 
            // WT_GEAR_VIB_OUT
            // 
            this.WT_GEAR_VIB_OUT.Enabled = false;
            this.WT_GEAR_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_GEAR_VIB_OUT.Location = new System.Drawing.Point(347, 208);
            this.WT_GEAR_VIB_OUT.Name = "WT_GEAR_VIB_OUT";
            this.WT_GEAR_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.WT_GEAR_VIB_OUT.TabIndex = 140;
            this.WT_GEAR_VIB_OUT.Text = "0";
            // 
            // label66
            // 
            this.label66.Enabled = false;
            this.label66.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label66.Location = new System.Drawing.Point(240, 207);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(15, 15);
            this.label66.TabIndex = 139;
            this.label66.Text = "%";
            // 
            // WT_GEAR_VIB_PER
            // 
            this.WT_GEAR_VIB_PER.Enabled = false;
            this.WT_GEAR_VIB_PER.FormattingEnabled = true;
            this.WT_GEAR_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.WT_GEAR_VIB_PER.Location = new System.Drawing.Point(181, 203);
            this.WT_GEAR_VIB_PER.Name = "WT_GEAR_VIB_PER";
            this.WT_GEAR_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.WT_GEAR_VIB_PER.TabIndex = 138;
            this.WT_GEAR_VIB_PER.Text = "100";
            this.WT_GEAR_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.WT_GEAR_VIB_PER_SelectedIndexChanged);
            // 
            // WT_GEAR_CHK
            // 
            this.WT_GEAR_CHK.AutoSize = true;
            this.WT_GEAR_CHK.Checked = true;
            this.WT_GEAR_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WT_GEAR_CHK.Enabled = false;
            this.WT_GEAR_CHK.Location = new System.Drawing.Point(18, 207);
            this.WT_GEAR_CHK.Name = "WT_GEAR_CHK";
            this.WT_GEAR_CHK.Size = new System.Drawing.Size(80, 16);
            this.WT_GEAR_CHK.TabIndex = 137;
            this.WT_GEAR_CHK.Text = "랜딩기어 :";
            this.WT_GEAR_CHK.UseVisualStyleBackColor = true;
            this.WT_GEAR_CHK.CheckedChanged += new System.EventHandler(this.WT_GEAR_CHK_CheckedChanged);
            // 
            // WT_GEAR_VIB
            // 
            this.WT_GEAR_VIB.Enabled = false;
            this.WT_GEAR_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_GEAR_VIB.Location = new System.Drawing.Point(141, 208);
            this.WT_GEAR_VIB.Name = "WT_GEAR_VIB";
            this.WT_GEAR_VIB.Size = new System.Drawing.Size(40, 15);
            this.WT_GEAR_VIB.TabIndex = 136;
            this.WT_GEAR_VIB.Text = "0";
            // 
            // WT_FLAP_VIB_OUT
            // 
            this.WT_FLAP_VIB_OUT.Enabled = false;
            this.WT_FLAP_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_FLAP_VIB_OUT.Location = new System.Drawing.Point(347, 186);
            this.WT_FLAP_VIB_OUT.Name = "WT_FLAP_VIB_OUT";
            this.WT_FLAP_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.WT_FLAP_VIB_OUT.TabIndex = 135;
            this.WT_FLAP_VIB_OUT.Text = "0";
            // 
            // label65
            // 
            this.label65.Enabled = false;
            this.label65.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label65.Location = new System.Drawing.Point(240, 185);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(15, 15);
            this.label65.TabIndex = 134;
            this.label65.Text = "%";
            // 
            // WT_FLAP_VIB_PER
            // 
            this.WT_FLAP_VIB_PER.Enabled = false;
            this.WT_FLAP_VIB_PER.FormattingEnabled = true;
            this.WT_FLAP_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.WT_FLAP_VIB_PER.Location = new System.Drawing.Point(181, 181);
            this.WT_FLAP_VIB_PER.Name = "WT_FLAP_VIB_PER";
            this.WT_FLAP_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.WT_FLAP_VIB_PER.TabIndex = 133;
            this.WT_FLAP_VIB_PER.Text = "100";
            this.WT_FLAP_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.WT_FLAP_VIB_PER_SelectedIndexChanged);
            // 
            // WT_FLAP_CHK
            // 
            this.WT_FLAP_CHK.AutoSize = true;
            this.WT_FLAP_CHK.Checked = true;
            this.WT_FLAP_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WT_FLAP_CHK.Enabled = false;
            this.WT_FLAP_CHK.Location = new System.Drawing.Point(18, 185);
            this.WT_FLAP_CHK.Name = "WT_FLAP_CHK";
            this.WT_FLAP_CHK.Size = new System.Drawing.Size(56, 16);
            this.WT_FLAP_CHK.TabIndex = 132;
            this.WT_FLAP_CHK.Text = "플랩 :";
            this.WT_FLAP_CHK.UseVisualStyleBackColor = true;
            this.WT_FLAP_CHK.CheckedChanged += new System.EventHandler(this.WT_FLAP_CHK_CheckedChanged);
            // 
            // WT_FLAP_VIB
            // 
            this.WT_FLAP_VIB.Enabled = false;
            this.WT_FLAP_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_FLAP_VIB.Location = new System.Drawing.Point(141, 186);
            this.WT_FLAP_VIB.Name = "WT_FLAP_VIB";
            this.WT_FLAP_VIB.Size = new System.Drawing.Size(40, 15);
            this.WT_FLAP_VIB.TabIndex = 131;
            this.WT_FLAP_VIB.Text = "0";
            // 
            // WT_AOA_VIB_OUT
            // 
            this.WT_AOA_VIB_OUT.Enabled = false;
            this.WT_AOA_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_AOA_VIB_OUT.Location = new System.Drawing.Point(347, 164);
            this.WT_AOA_VIB_OUT.Name = "WT_AOA_VIB_OUT";
            this.WT_AOA_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.WT_AOA_VIB_OUT.TabIndex = 130;
            this.WT_AOA_VIB_OUT.Text = "0";
            // 
            // label64
            // 
            this.label64.Enabled = false;
            this.label64.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label64.Location = new System.Drawing.Point(240, 163);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(15, 15);
            this.label64.TabIndex = 129;
            this.label64.Text = "%";
            // 
            // WT_AOA_VIB_PER
            // 
            this.WT_AOA_VIB_PER.Enabled = false;
            this.WT_AOA_VIB_PER.FormattingEnabled = true;
            this.WT_AOA_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.WT_AOA_VIB_PER.Location = new System.Drawing.Point(181, 159);
            this.WT_AOA_VIB_PER.Name = "WT_AOA_VIB_PER";
            this.WT_AOA_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.WT_AOA_VIB_PER.TabIndex = 128;
            this.WT_AOA_VIB_PER.Text = "100";
            this.WT_AOA_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.WT_AOA_VIB_PER_SelectedIndexChanged);
            // 
            // WT_AOA_CHK
            // 
            this.WT_AOA_CHK.AutoSize = true;
            this.WT_AOA_CHK.Checked = true;
            this.WT_AOA_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WT_AOA_CHK.Enabled = false;
            this.WT_AOA_CHK.Location = new System.Drawing.Point(18, 163);
            this.WT_AOA_CHK.Name = "WT_AOA_CHK";
            this.WT_AOA_CHK.Size = new System.Drawing.Size(57, 16);
            this.WT_AOA_CHK.TabIndex = 127;
            this.WT_AOA_CHK.Text = "AOA :";
            this.WT_AOA_CHK.UseVisualStyleBackColor = true;
            this.WT_AOA_CHK.CheckedChanged += new System.EventHandler(this.WT_AOA_CHK_CheckedChanged);
            // 
            // WT_AOA_VIB
            // 
            this.WT_AOA_VIB.Enabled = false;
            this.WT_AOA_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_AOA_VIB.Location = new System.Drawing.Point(141, 164);
            this.WT_AOA_VIB.Name = "WT_AOA_VIB";
            this.WT_AOA_VIB.Size = new System.Drawing.Size(40, 15);
            this.WT_AOA_VIB.TabIndex = 126;
            this.WT_AOA_VIB.Text = "0";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label48.Location = new System.Drawing.Point(346, 71);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(63, 13);
            this.label48.TabIndex = 125;
            this.label48.Text = "최종진동";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label60.Location = new System.Drawing.Point(178, 71);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(63, 13);
            this.label60.TabIndex = 124;
            this.label60.Text = "진동보정";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label61.Location = new System.Drawing.Point(130, 71);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(35, 13);
            this.label61.TabIndex = 123;
            this.label61.Text = "진동";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label62.Location = new System.Drawing.Point(17, 71);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(35, 13);
            this.label62.TabIndex = 122;
            this.label62.Text = "항목";
            // 
            // DEFAULT_SETUP_WT
            // 
            this.DEFAULT_SETUP_WT.Location = new System.Drawing.Point(278, 27);
            this.DEFAULT_SETUP_WT.Name = "DEFAULT_SETUP_WT";
            this.DEFAULT_SETUP_WT.Size = new System.Drawing.Size(144, 22);
            this.DEFAULT_SETUP_WT.TabIndex = 121;
            this.DEFAULT_SETUP_WT.Text = "기본값";
            this.DEFAULT_SETUP_WT.UseVisualStyleBackColor = true;
            this.DEFAULT_SETUP_WT.Click += new System.EventHandler(this.DEFAULT_SETUP_WT_Click);
            // 
            // WT_WX_VIB_OUT
            // 
            this.WT_WX_VIB_OUT.Enabled = false;
            this.WT_WX_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_WX_VIB_OUT.Location = new System.Drawing.Point(347, 141);
            this.WT_WX_VIB_OUT.Name = "WT_WX_VIB_OUT";
            this.WT_WX_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.WT_WX_VIB_OUT.TabIndex = 118;
            this.WT_WX_VIB_OUT.Text = "0";
            // 
            // WT_NY_VIB_OUT
            // 
            this.WT_NY_VIB_OUT.Enabled = false;
            this.WT_NY_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_NY_VIB_OUT.Location = new System.Drawing.Point(347, 119);
            this.WT_NY_VIB_OUT.Name = "WT_NY_VIB_OUT";
            this.WT_NY_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.WT_NY_VIB_OUT.TabIndex = 116;
            this.WT_NY_VIB_OUT.Text = "0";
            // 
            // WT_AOS_VIB_OUT
            // 
            this.WT_AOS_VIB_OUT.Enabled = false;
            this.WT_AOS_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_AOS_VIB_OUT.Location = new System.Drawing.Point(347, 99);
            this.WT_AOS_VIB_OUT.Name = "WT_AOS_VIB_OUT";
            this.WT_AOS_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.WT_AOS_VIB_OUT.TabIndex = 112;
            this.WT_AOS_VIB_OUT.Text = "0";
            // 
            // label76
            // 
            this.label76.Enabled = false;
            this.label76.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label76.Location = new System.Drawing.Point(203, 305);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(102, 15);
            this.label76.TabIndex = 111;
            this.label76.Text = "최대진동 AOA";
            // 
            // label77
            // 
            this.label77.Enabled = false;
            this.label77.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label77.Location = new System.Drawing.Point(15, 305);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(102, 15);
            this.label77.TabIndex = 110;
            this.label77.Text = "진동시작 AOA";
            // 
            // label83
            // 
            this.label83.Enabled = false;
            this.label83.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label83.Location = new System.Drawing.Point(240, 140);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(15, 15);
            this.label83.TabIndex = 107;
            this.label83.Text = "%";
            // 
            // label84
            // 
            this.label84.Enabled = false;
            this.label84.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label84.Location = new System.Drawing.Point(240, 118);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(15, 15);
            this.label84.TabIndex = 105;
            this.label84.Text = "%";
            // 
            // label86
            // 
            this.label86.Enabled = false;
            this.label86.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label86.Location = new System.Drawing.Point(240, 98);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(15, 15);
            this.label86.TabIndex = 101;
            this.label86.Text = "%";
            // 
            // WT_WX_VIB_PER
            // 
            this.WT_WX_VIB_PER.Enabled = false;
            this.WT_WX_VIB_PER.FormattingEnabled = true;
            this.WT_WX_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.WT_WX_VIB_PER.Location = new System.Drawing.Point(181, 136);
            this.WT_WX_VIB_PER.Name = "WT_WX_VIB_PER";
            this.WT_WX_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.WT_WX_VIB_PER.TabIndex = 94;
            this.WT_WX_VIB_PER.Text = "100";
            this.WT_WX_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.WT_WX_VIB_PER_SelectedIndexChanged);
            // 
            // WT_NY_VIB_PER
            // 
            this.WT_NY_VIB_PER.Enabled = false;
            this.WT_NY_VIB_PER.FormattingEnabled = true;
            this.WT_NY_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.WT_NY_VIB_PER.Location = new System.Drawing.Point(181, 114);
            this.WT_NY_VIB_PER.Name = "WT_NY_VIB_PER";
            this.WT_NY_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.WT_NY_VIB_PER.TabIndex = 93;
            this.WT_NY_VIB_PER.Text = "100";
            this.WT_NY_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.WT_NY_VIB_PER_SelectedIndexChanged);
            // 
            // WT_AOS_VIB_PER
            // 
            this.WT_AOS_VIB_PER.Enabled = false;
            this.WT_AOS_VIB_PER.FormattingEnabled = true;
            this.WT_AOS_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.WT_AOS_VIB_PER.Location = new System.Drawing.Point(181, 92);
            this.WT_AOS_VIB_PER.Name = "WT_AOS_VIB_PER";
            this.WT_AOS_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.WT_AOS_VIB_PER.TabIndex = 92;
            this.WT_AOS_VIB_PER.Text = "100";
            this.WT_AOS_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.WT_AOS_VIB_PER_SelectedIndexChanged);
            // 
            // WT_AOA_M_COMBO
            // 
            this.WT_AOA_M_COMBO.Enabled = false;
            this.WT_AOA_M_COMBO.FormattingEnabled = true;
            this.WT_AOA_M_COMBO.Items.AddRange(new object[] {
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.WT_AOA_M_COMBO.Location = new System.Drawing.Point(311, 303);
            this.WT_AOA_M_COMBO.Name = "WT_AOA_M_COMBO";
            this.WT_AOA_M_COMBO.Size = new System.Drawing.Size(53, 20);
            this.WT_AOA_M_COMBO.TabIndex = 91;
            this.WT_AOA_M_COMBO.Text = "25";
            this.WT_AOA_M_COMBO.SelectedIndexChanged += new System.EventHandler(this.WT_AOA_M_COMBO_SelectedIndexChanged);
            // 
            // WT_AOA_S_COMBO
            // 
            this.WT_AOA_S_COMBO.Enabled = false;
            this.WT_AOA_S_COMBO.FormattingEnabled = true;
            this.WT_AOA_S_COMBO.Items.AddRange(new object[] {
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5"});
            this.WT_AOA_S_COMBO.Location = new System.Drawing.Point(123, 303);
            this.WT_AOA_S_COMBO.Name = "WT_AOA_S_COMBO";
            this.WT_AOA_S_COMBO.Size = new System.Drawing.Size(53, 20);
            this.WT_AOA_S_COMBO.TabIndex = 69;
            this.WT_AOA_S_COMBO.Text = "13";
            this.WT_AOA_S_COMBO.SelectedIndexChanged += new System.EventHandler(this.WT_AOA_S_COMBO_SelectedIndexChanged);
            // 
            // PLANE_LIST_COMBO_WT
            // 
            this.PLANE_LIST_COMBO_WT.FormattingEnabled = true;
            this.PLANE_LIST_COMBO_WT.Location = new System.Drawing.Point(18, 29);
            this.PLANE_LIST_COMBO_WT.Name = "PLANE_LIST_COMBO_WT";
            this.PLANE_LIST_COMBO_WT.Size = new System.Drawing.Size(216, 20);
            this.PLANE_LIST_COMBO_WT.TabIndex = 90;
            this.PLANE_LIST_COMBO_WT.SelectedIndexChanged += new System.EventHandler(this.PLANE_LIST_COMBO_WT_SelectedIndexChanged);
            this.PLANE_LIST_COMBO_WT.TextUpdate += new System.EventHandler(this.PLANE_LIST_COMBO_WT_TextUpdate);
            // 
            // WT_WX_CHK
            // 
            this.WT_WX_CHK.AutoSize = true;
            this.WT_WX_CHK.Checked = true;
            this.WT_WX_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WT_WX_CHK.Enabled = false;
            this.WT_WX_CHK.Location = new System.Drawing.Point(18, 140);
            this.WT_WX_CHK.Name = "WT_WX_CHK";
            this.WT_WX_CHK.Size = new System.Drawing.Size(108, 16);
            this.WT_WX_CHK.TabIndex = 83;
            this.WT_WX_CHK.Text = "WX(롤링진동) :";
            this.WT_WX_CHK.UseVisualStyleBackColor = true;
            this.WT_WX_CHK.CheckedChanged += new System.EventHandler(this.WT_WX_CHK_CheckedChanged);
            // 
            // WT_NY_CHK
            // 
            this.WT_NY_CHK.AutoSize = true;
            this.WT_NY_CHK.Checked = true;
            this.WT_NY_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WT_NY_CHK.Enabled = false;
            this.WT_NY_CHK.Location = new System.Drawing.Point(18, 118);
            this.WT_NY_CHK.Name = "WT_NY_CHK";
            this.WT_NY_CHK.Size = new System.Drawing.Size(119, 16);
            this.WT_NY_CHK.TabIndex = 82;
            this.WT_NY_CHK.Text = "NY(위아래진동) :";
            this.WT_NY_CHK.UseVisualStyleBackColor = true;
            this.WT_NY_CHK.CheckedChanged += new System.EventHandler(this.WT_NY_CHK_CheckedChanged);
            // 
            // WT_AOS_CHK
            // 
            this.WT_AOS_CHK.AutoSize = true;
            this.WT_AOS_CHK.Checked = true;
            this.WT_AOS_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WT_AOS_CHK.Enabled = false;
            this.WT_AOS_CHK.Location = new System.Drawing.Point(18, 98);
            this.WT_AOS_CHK.Name = "WT_AOS_CHK";
            this.WT_AOS_CHK.Size = new System.Drawing.Size(115, 16);
            this.WT_AOS_CHK.TabIndex = 81;
            this.WT_AOS_CHK.Text = "AOS(좌우진동) :";
            this.WT_AOS_CHK.UseVisualStyleBackColor = true;
            this.WT_AOS_CHK.CheckedChanged += new System.EventHandler(this.WT_AOS_CHK_CheckedChanged);
            // 
            // WT_WX_VIB
            // 
            this.WT_WX_VIB.Enabled = false;
            this.WT_WX_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_WX_VIB.Location = new System.Drawing.Point(141, 141);
            this.WT_WX_VIB.Name = "WT_WX_VIB";
            this.WT_WX_VIB.Size = new System.Drawing.Size(40, 15);
            this.WT_WX_VIB.TabIndex = 71;
            this.WT_WX_VIB.Text = "0";
            // 
            // WT_NY_VIB
            // 
            this.WT_NY_VIB.Enabled = false;
            this.WT_NY_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_NY_VIB.Location = new System.Drawing.Point(141, 119);
            this.WT_NY_VIB.Name = "WT_NY_VIB";
            this.WT_NY_VIB.Size = new System.Drawing.Size(40, 15);
            this.WT_NY_VIB.TabIndex = 70;
            this.WT_NY_VIB.Text = "0";
            // 
            // WT_AOS_VIB
            // 
            this.WT_AOS_VIB.Enabled = false;
            this.WT_AOS_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WT_AOS_VIB.Location = new System.Drawing.Point(141, 99);
            this.WT_AOS_VIB.Name = "WT_AOS_VIB";
            this.WT_AOS_VIB.Size = new System.Drawing.Size(40, 15);
            this.WT_AOS_VIB.TabIndex = 54;
            this.WT_AOS_VIB.Text = "0";
            // 
            // Connect_WT
            // 
            this.Connect_WT.Location = new System.Drawing.Point(337, 629);
            this.Connect_WT.Name = "Connect_WT";
            this.Connect_WT.Size = new System.Drawing.Size(109, 32);
            this.Connect_WT.TabIndex = 3;
            this.Connect_WT.Text = "Connect";
            this.Connect_WT.UseVisualStyleBackColor = true;
            this.Connect_WT.Click += new System.EventHandler(this.Connect_WT_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.WT_WX);
            this.groupBox6.Controls.Add(this.label59);
            this.groupBox6.Controls.Add(this.WT_AIRBREAK);
            this.groupBox6.Controls.Add(this.label53);
            this.groupBox6.Controls.Add(this.WT_FLAP);
            this.groupBox6.Controls.Add(this.WT_GEAR);
            this.groupBox6.Controls.Add(this.WT_WEAPON3);
            this.groupBox6.Controls.Add(this.WT_WEAPON1);
            this.groupBox6.Controls.Add(this.WT_WEAPON2);
            this.groupBox6.Controls.Add(this.WT_THROTTLE2);
            this.groupBox6.Controls.Add(this.WT_THROTTLE1);
            this.groupBox6.Controls.Add(this.WT_NY);
            this.groupBox6.Controls.Add(this.label57);
            this.groupBox6.Controls.Add(this.label58);
            this.groupBox6.Controls.Add(this.label55);
            this.groupBox6.Controls.Add(this.label56);
            this.groupBox6.Controls.Add(this.label54);
            this.groupBox6.Controls.Add(this.label51);
            this.groupBox6.Controls.Add(this.label50);
            this.groupBox6.Controls.Add(this.label49);
            this.groupBox6.Controls.Add(this.WT_AOS);
            this.groupBox6.Controls.Add(this.label47);
            this.groupBox6.Controls.Add(this.label67);
            this.groupBox6.Controls.Add(this.label68);
            this.groupBox6.Controls.Add(this.label70);
            this.groupBox6.Controls.Add(this.label72);
            this.groupBox6.Controls.Add(this.WT_PLANE_NAME);
            this.groupBox6.Controls.Add(this.WT_AOA);
            this.groupBox6.Controls.Add(this.WT_IAS);
            this.groupBox6.Controls.Add(this.WT_TAS);
            this.groupBox6.Location = new System.Drawing.Point(12, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(434, 182);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "워썬더 출력값";
            // 
            // WT_WX
            // 
            this.WT_WX.Location = new System.Drawing.Point(112, 123);
            this.WT_WX.Name = "WT_WX";
            this.WT_WX.Size = new System.Drawing.Size(82, 16);
            this.WT_WX.TabIndex = 68;
            this.WT_WX.Text = "0";
            // 
            // label59
            // 
            this.label59.Location = new System.Drawing.Point(17, 123);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(90, 16);
            this.label59.TabIndex = 67;
            this.label59.Text = "Wx :";
            // 
            // WT_AIRBREAK
            // 
            this.WT_AIRBREAK.Location = new System.Drawing.Point(325, 140);
            this.WT_AIRBREAK.Name = "WT_AIRBREAK";
            this.WT_AIRBREAK.Size = new System.Drawing.Size(82, 16);
            this.WT_AIRBREAK.TabIndex = 66;
            this.WT_AIRBREAK.Text = "0";
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(237, 141);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(89, 17);
            this.label53.TabIndex = 65;
            this.label53.Text = "AIRBREAK :";
            // 
            // WT_FLAP
            // 
            this.WT_FLAP.Location = new System.Drawing.Point(325, 122);
            this.WT_FLAP.Name = "WT_FLAP";
            this.WT_FLAP.Size = new System.Drawing.Size(82, 16);
            this.WT_FLAP.TabIndex = 64;
            this.WT_FLAP.Text = "0";
            // 
            // WT_GEAR
            // 
            this.WT_GEAR.Location = new System.Drawing.Point(325, 105);
            this.WT_GEAR.Name = "WT_GEAR";
            this.WT_GEAR.Size = new System.Drawing.Size(82, 16);
            this.WT_GEAR.TabIndex = 63;
            this.WT_GEAR.Text = "0";
            // 
            // WT_WEAPON3
            // 
            this.WT_WEAPON3.Location = new System.Drawing.Point(325, 71);
            this.WT_WEAPON3.Name = "WT_WEAPON3";
            this.WT_WEAPON3.Size = new System.Drawing.Size(82, 16);
            this.WT_WEAPON3.TabIndex = 61;
            this.WT_WEAPON3.Text = "0";
            // 
            // WT_WEAPON1
            // 
            this.WT_WEAPON1.Location = new System.Drawing.Point(325, 40);
            this.WT_WEAPON1.Name = "WT_WEAPON1";
            this.WT_WEAPON1.Size = new System.Drawing.Size(82, 15);
            this.WT_WEAPON1.TabIndex = 59;
            this.WT_WEAPON1.Text = "0";
            // 
            // WT_WEAPON2
            // 
            this.WT_WEAPON2.Location = new System.Drawing.Point(325, 55);
            this.WT_WEAPON2.Name = "WT_WEAPON2";
            this.WT_WEAPON2.Size = new System.Drawing.Size(82, 16);
            this.WT_WEAPON2.TabIndex = 60;
            this.WT_WEAPON2.Text = "0";
            // 
            // WT_THROTTLE2
            // 
            this.WT_THROTTLE2.Location = new System.Drawing.Point(112, 160);
            this.WT_THROTTLE2.Name = "WT_THROTTLE2";
            this.WT_THROTTLE2.Size = new System.Drawing.Size(82, 16);
            this.WT_THROTTLE2.TabIndex = 58;
            this.WT_THROTTLE2.Text = "0";
            // 
            // WT_THROTTLE1
            // 
            this.WT_THROTTLE1.Location = new System.Drawing.Point(112, 142);
            this.WT_THROTTLE1.Name = "WT_THROTTLE1";
            this.WT_THROTTLE1.Size = new System.Drawing.Size(82, 16);
            this.WT_THROTTLE1.TabIndex = 57;
            this.WT_THROTTLE1.Text = "0";
            // 
            // WT_NY
            // 
            this.WT_NY.Location = new System.Drawing.Point(112, 106);
            this.WT_NY.Name = "WT_NY";
            this.WT_NY.Size = new System.Drawing.Size(82, 16);
            this.WT_NY.TabIndex = 56;
            this.WT_NY.Text = "0";
            // 
            // label57
            // 
            this.label57.Location = new System.Drawing.Point(237, 123);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(89, 17);
            this.label57.TabIndex = 55;
            this.label57.Text = "FLAP :";
            // 
            // label58
            // 
            this.label58.Location = new System.Drawing.Point(237, 106);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(89, 17);
            this.label58.TabIndex = 54;
            this.label58.Text = "GEAR :";
            // 
            // label55
            // 
            this.label55.Location = new System.Drawing.Point(17, 58);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(89, 17);
            this.label55.TabIndex = 53;
            this.label55.Text = "TAS :";
            // 
            // label56
            // 
            this.label56.Location = new System.Drawing.Point(17, 41);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(89, 17);
            this.label56.TabIndex = 52;
            this.label56.Text = "IAS :";
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(17, 159);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(89, 17);
            this.label54.TabIndex = 51;
            this.label54.Text = "THROTTLE2 :";
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(237, 72);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(90, 16);
            this.label51.TabIndex = 48;
            this.label51.Text = "WEAPON3 :";
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(237, 56);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(90, 16);
            this.label50.TabIndex = 47;
            this.label50.Text = "WEAPON2 :";
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(237, 40);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(90, 16);
            this.label49.TabIndex = 46;
            this.label49.Text = "WEAPON1 :";
            // 
            // WT_AOS
            // 
            this.WT_AOS.Location = new System.Drawing.Point(112, 88);
            this.WT_AOS.Name = "WT_AOS";
            this.WT_AOS.Size = new System.Drawing.Size(82, 16);
            this.WT_AOS.TabIndex = 45;
            this.WT_AOS.Text = "0";
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(17, 142);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(89, 17);
            this.label47.TabIndex = 44;
            this.label47.Text = "THROTTLE1 :";
            // 
            // label67
            // 
            this.label67.Location = new System.Drawing.Point(17, 106);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(90, 16);
            this.label67.TabIndex = 33;
            this.label67.Text = "Ny :";
            // 
            // label68
            // 
            this.label68.Location = new System.Drawing.Point(18, 90);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(90, 16);
            this.label68.TabIndex = 32;
            this.label68.Text = "AOS :";
            // 
            // label70
            // 
            this.label70.Location = new System.Drawing.Point(17, 75);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(90, 16);
            this.label70.TabIndex = 31;
            this.label70.Text = "AOA :";
            // 
            // label72
            // 
            this.label72.Location = new System.Drawing.Point(17, 25);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(82, 16);
            this.label72.TabIndex = 30;
            this.label72.Text = "현재항공기 :";
            // 
            // WT_PLANE_NAME
            // 
            this.WT_PLANE_NAME.Location = new System.Drawing.Point(112, 25);
            this.WT_PLANE_NAME.Name = "WT_PLANE_NAME";
            this.WT_PLANE_NAME.Size = new System.Drawing.Size(82, 16);
            this.WT_PLANE_NAME.TabIndex = 29;
            this.WT_PLANE_NAME.Text = "-";
            // 
            // WT_AOA
            // 
            this.WT_AOA.Location = new System.Drawing.Point(112, 72);
            this.WT_AOA.Name = "WT_AOA";
            this.WT_AOA.Size = new System.Drawing.Size(82, 16);
            this.WT_AOA.TabIndex = 32;
            this.WT_AOA.Text = "0";
            // 
            // WT_IAS
            // 
            this.WT_IAS.Location = new System.Drawing.Point(112, 41);
            this.WT_IAS.Name = "WT_IAS";
            this.WT_IAS.Size = new System.Drawing.Size(82, 15);
            this.WT_IAS.TabIndex = 30;
            this.WT_IAS.Text = "0";
            // 
            // WT_TAS
            // 
            this.WT_TAS.Location = new System.Drawing.Point(112, 56);
            this.WT_TAS.Name = "WT_TAS";
            this.WT_TAS.Size = new System.Drawing.Size(82, 16);
            this.WT_TAS.TabIndex = 31;
            this.WT_TAS.Text = "0";
            // 
            // FS2020
            // 
            this.FS2020.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FS2020.Controls.Add(this.groupBox15);
            this.FS2020.Controls.Add(this.groupBox14);
            this.FS2020.Controls.Add(this.groupBox13);
            this.FS2020.Controls.Add(this.Connect_FS2020);
            this.FS2020.Location = new System.Drawing.Point(4, 22);
            this.FS2020.Name = "FS2020";
            this.FS2020.Size = new System.Drawing.Size(463, 674);
            this.FS2020.TabIndex = 4;
            this.FS2020.Text = "FS2020";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.FS_VIB_OUT);
            this.groupBox15.Location = new System.Drawing.Point(14, 511);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(432, 78);
            this.groupBox15.TabIndex = 72;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "최종출력";
            // 
            // FS_VIB_OUT
            // 
            this.FS_VIB_OUT.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_VIB_OUT.Location = new System.Drawing.Point(15, 29);
            this.FS_VIB_OUT.Name = "FS_VIB_OUT";
            this.FS_VIB_OUT.Size = new System.Drawing.Size(219, 31);
            this.FS_VIB_OUT.TabIndex = 122;
            this.FS_VIB_OUT.Text = "0";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label106);
            this.groupBox14.Controls.Add(this.FS_ACC_VIB_MIN);
            this.groupBox14.Controls.Add(this.FS_AOA_VIB_OUT);
            this.groupBox14.Controls.Add(this.label109);
            this.groupBox14.Controls.Add(this.FS_AOA_VIB_PER);
            this.groupBox14.Controls.Add(this.FS_AOA_CHK);
            this.groupBox14.Controls.Add(this.FS_AOA_VIB);
            this.groupBox14.Controls.Add(this.FS_ACC_VIB_OUT);
            this.groupBox14.Controls.Add(this.label118);
            this.groupBox14.Controls.Add(this.FS_ACC_VIB_PER);
            this.groupBox14.Controls.Add(this.FS_ACC_CHK);
            this.groupBox14.Controls.Add(this.FS_ACC_VIB);
            this.groupBox14.Controls.Add(this.FS_OVERSPEED_VIB_OUT);
            this.groupBox14.Controls.Add(this.label144);
            this.groupBox14.Controls.Add(this.FS_OVERSPEED_VIB_PER);
            this.groupBox14.Controls.Add(this.FS_OVERSPEED_CHK);
            this.groupBox14.Controls.Add(this.FS_OVERSPEED_VIB);
            this.groupBox14.Controls.Add(this.FS_STALL_VIB_OUT);
            this.groupBox14.Controls.Add(this.label147);
            this.groupBox14.Controls.Add(this.FS_STALL_VIB_PER);
            this.groupBox14.Controls.Add(this.FS_STALL_CHK);
            this.groupBox14.Controls.Add(this.FS_STALL_VIB);
            this.groupBox14.Controls.Add(this.label155);
            this.groupBox14.Controls.Add(this.label156);
            this.groupBox14.Controls.Add(this.label157);
            this.groupBox14.Controls.Add(this.label158);
            this.groupBox14.Controls.Add(this.DEFAULT_SETUP_FS);
            this.groupBox14.Controls.Add(this.FS_SPOILER_VIB_OUT);
            this.groupBox14.Controls.Add(this.FS_FLAP_VIB_OUT);
            this.groupBox14.Controls.Add(this.FS_GEAR_VIB_OUT);
            this.groupBox14.Controls.Add(this.label162);
            this.groupBox14.Controls.Add(this.label163);
            this.groupBox14.Controls.Add(this.label164);
            this.groupBox14.Controls.Add(this.label165);
            this.groupBox14.Controls.Add(this.label166);
            this.groupBox14.Controls.Add(this.FS_SPOILER_VIB_PER);
            this.groupBox14.Controls.Add(this.FS_FLAP_VIB_PER);
            this.groupBox14.Controls.Add(this.FS_GEAR_VIB_PER);
            this.groupBox14.Controls.Add(this.FS_AOA_M_COMBO);
            this.groupBox14.Controls.Add(this.FS_AOA_S_COMBO);
            this.groupBox14.Controls.Add(this.FS_SPOILER_CHK);
            this.groupBox14.Controls.Add(this.FS_FLAP_CHK);
            this.groupBox14.Controls.Add(this.FS_GEAR_CHK);
            this.groupBox14.Controls.Add(this.FS_SPOILER_VIB);
            this.groupBox14.Controls.Add(this.FS_FLAP_VIB);
            this.groupBox14.Controls.Add(this.FS_GEAR_VIB);
            this.groupBox14.Location = new System.Drawing.Point(14, 182);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(432, 312);
            this.groupBox14.TabIndex = 71;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "진동출력설정";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label106.Location = new System.Drawing.Point(260, 26);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(77, 13);
            this.label106.TabIndex = 167;
            this.label106.Text = "진동시작값";
            // 
            // FS_ACC_VIB_MIN
            // 
            this.FS_ACC_VIB_MIN.FormattingEnabled = true;
            this.FS_ACC_VIB_MIN.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.FS_ACC_VIB_MIN.Location = new System.Drawing.Point(263, 51);
            this.FS_ACC_VIB_MIN.Name = "FS_ACC_VIB_MIN";
            this.FS_ACC_VIB_MIN.Size = new System.Drawing.Size(53, 20);
            this.FS_ACC_VIB_MIN.TabIndex = 166;
            this.FS_ACC_VIB_MIN.Text = "1";
            this.FS_ACC_VIB_MIN.SelectedIndexChanged += new System.EventHandler(this.FS_ACC_VIB_MIN_SelectedIndexChanged);
            // 
            // FS_AOA_VIB_OUT
            // 
            this.FS_AOA_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_AOA_VIB_OUT.Location = new System.Drawing.Point(348, 80);
            this.FS_AOA_VIB_OUT.Name = "FS_AOA_VIB_OUT";
            this.FS_AOA_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FS_AOA_VIB_OUT.TabIndex = 165;
            this.FS_AOA_VIB_OUT.Text = "0";
            // 
            // label109
            // 
            this.label109.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label109.Location = new System.Drawing.Point(242, 79);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(15, 15);
            this.label109.TabIndex = 164;
            this.label109.Text = "%";
            // 
            // FS_AOA_VIB_PER
            // 
            this.FS_AOA_VIB_PER.FormattingEnabled = true;
            this.FS_AOA_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FS_AOA_VIB_PER.Location = new System.Drawing.Point(183, 73);
            this.FS_AOA_VIB_PER.Name = "FS_AOA_VIB_PER";
            this.FS_AOA_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FS_AOA_VIB_PER.TabIndex = 163;
            this.FS_AOA_VIB_PER.Text = "100";
            this.FS_AOA_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FS_AOA_VIB_PER_SelectedIndexChanged);
            // 
            // FS_AOA_CHK
            // 
            this.FS_AOA_CHK.AutoSize = true;
            this.FS_AOA_CHK.Checked = true;
            this.FS_AOA_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FS_AOA_CHK.Location = new System.Drawing.Point(20, 79);
            this.FS_AOA_CHK.Name = "FS_AOA_CHK";
            this.FS_AOA_CHK.Size = new System.Drawing.Size(57, 16);
            this.FS_AOA_CHK.TabIndex = 162;
            this.FS_AOA_CHK.Text = "AOA :";
            this.FS_AOA_CHK.UseVisualStyleBackColor = true;
            this.FS_AOA_CHK.CheckedChanged += new System.EventHandler(this.FS_AOA_CHK_CheckedChanged);
            // 
            // FS_AOA_VIB
            // 
            this.FS_AOA_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_AOA_VIB.Location = new System.Drawing.Point(143, 80);
            this.FS_AOA_VIB.Name = "FS_AOA_VIB";
            this.FS_AOA_VIB.Size = new System.Drawing.Size(40, 15);
            this.FS_AOA_VIB.TabIndex = 161;
            this.FS_AOA_VIB.Text = "0";
            // 
            // FS_ACC_VIB_OUT
            // 
            this.FS_ACC_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_ACC_VIB_OUT.Location = new System.Drawing.Point(348, 58);
            this.FS_ACC_VIB_OUT.Name = "FS_ACC_VIB_OUT";
            this.FS_ACC_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FS_ACC_VIB_OUT.TabIndex = 160;
            this.FS_ACC_VIB_OUT.Text = "0";
            // 
            // label118
            // 
            this.label118.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label118.Location = new System.Drawing.Point(242, 57);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(15, 15);
            this.label118.TabIndex = 159;
            this.label118.Text = "%";
            // 
            // FS_ACC_VIB_PER
            // 
            this.FS_ACC_VIB_PER.FormattingEnabled = true;
            this.FS_ACC_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FS_ACC_VIB_PER.Location = new System.Drawing.Point(183, 51);
            this.FS_ACC_VIB_PER.Name = "FS_ACC_VIB_PER";
            this.FS_ACC_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FS_ACC_VIB_PER.TabIndex = 158;
            this.FS_ACC_VIB_PER.Text = "100";
            this.FS_ACC_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FS_ACC_VIB_PER_SelectedIndexChanged);
            // 
            // FS_ACC_CHK
            // 
            this.FS_ACC_CHK.AutoSize = true;
            this.FS_ACC_CHK.Checked = true;
            this.FS_ACC_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FS_ACC_CHK.Location = new System.Drawing.Point(20, 57);
            this.FS_ACC_CHK.Name = "FS_ACC_CHK";
            this.FS_ACC_CHK.Size = new System.Drawing.Size(68, 16);
            this.FS_ACC_CHK.TabIndex = 157;
            this.FS_ACC_CHK.Text = "가속도 :";
            this.FS_ACC_CHK.UseVisualStyleBackColor = true;
            this.FS_ACC_CHK.CheckedChanged += new System.EventHandler(this.FS_ACC_CHK_CheckedChanged);
            // 
            // FS_ACC_VIB
            // 
            this.FS_ACC_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_ACC_VIB.Location = new System.Drawing.Point(143, 58);
            this.FS_ACC_VIB.Name = "FS_ACC_VIB";
            this.FS_ACC_VIB.Size = new System.Drawing.Size(40, 15);
            this.FS_ACC_VIB.TabIndex = 156;
            this.FS_ACC_VIB.Text = "0";
            // 
            // FS_OVERSPEED_VIB_OUT
            // 
            this.FS_OVERSPEED_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_OVERSPEED_VIB_OUT.Location = new System.Drawing.Point(348, 189);
            this.FS_OVERSPEED_VIB_OUT.Name = "FS_OVERSPEED_VIB_OUT";
            this.FS_OVERSPEED_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FS_OVERSPEED_VIB_OUT.TabIndex = 145;
            this.FS_OVERSPEED_VIB_OUT.Text = "0";
            // 
            // label144
            // 
            this.label144.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label144.Location = new System.Drawing.Point(242, 188);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(15, 15);
            this.label144.TabIndex = 144;
            this.label144.Text = "%";
            // 
            // FS_OVERSPEED_VIB_PER
            // 
            this.FS_OVERSPEED_VIB_PER.FormattingEnabled = true;
            this.FS_OVERSPEED_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FS_OVERSPEED_VIB_PER.Location = new System.Drawing.Point(183, 184);
            this.FS_OVERSPEED_VIB_PER.Name = "FS_OVERSPEED_VIB_PER";
            this.FS_OVERSPEED_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FS_OVERSPEED_VIB_PER.TabIndex = 143;
            this.FS_OVERSPEED_VIB_PER.Text = "100";
            this.FS_OVERSPEED_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FS_OVERSPEED_VIB_PER_SelectedIndexChanged);
            // 
            // FS_OVERSPEED_CHK
            // 
            this.FS_OVERSPEED_CHK.AutoSize = true;
            this.FS_OVERSPEED_CHK.Checked = true;
            this.FS_OVERSPEED_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FS_OVERSPEED_CHK.Location = new System.Drawing.Point(20, 188);
            this.FS_OVERSPEED_CHK.Name = "FS_OVERSPEED_CHK";
            this.FS_OVERSPEED_CHK.Size = new System.Drawing.Size(120, 16);
            this.FS_OVERSPEED_CHK.TabIndex = 142;
            this.FS_OVERSPEED_CHK.Text = "오버스피드 경고 :";
            this.FS_OVERSPEED_CHK.UseVisualStyleBackColor = true;
            this.FS_OVERSPEED_CHK.CheckedChanged += new System.EventHandler(this.FS_OVERSPEED_CHK_CheckedChanged);
            // 
            // FS_OVERSPEED_VIB
            // 
            this.FS_OVERSPEED_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_OVERSPEED_VIB.Location = new System.Drawing.Point(143, 189);
            this.FS_OVERSPEED_VIB.Name = "FS_OVERSPEED_VIB";
            this.FS_OVERSPEED_VIB.Size = new System.Drawing.Size(40, 15);
            this.FS_OVERSPEED_VIB.TabIndex = 141;
            this.FS_OVERSPEED_VIB.Text = "0";
            // 
            // FS_STALL_VIB_OUT
            // 
            this.FS_STALL_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_STALL_VIB_OUT.Location = new System.Drawing.Point(348, 167);
            this.FS_STALL_VIB_OUT.Name = "FS_STALL_VIB_OUT";
            this.FS_STALL_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FS_STALL_VIB_OUT.TabIndex = 140;
            this.FS_STALL_VIB_OUT.Text = "0";
            // 
            // label147
            // 
            this.label147.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label147.Location = new System.Drawing.Point(242, 166);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(15, 15);
            this.label147.TabIndex = 139;
            this.label147.Text = "%";
            // 
            // FS_STALL_VIB_PER
            // 
            this.FS_STALL_VIB_PER.FormattingEnabled = true;
            this.FS_STALL_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FS_STALL_VIB_PER.Location = new System.Drawing.Point(183, 162);
            this.FS_STALL_VIB_PER.Name = "FS_STALL_VIB_PER";
            this.FS_STALL_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FS_STALL_VIB_PER.TabIndex = 138;
            this.FS_STALL_VIB_PER.Text = "100";
            this.FS_STALL_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FS_STALL_VIB_PER_SelectedIndexChanged);
            // 
            // FS_STALL_CHK
            // 
            this.FS_STALL_CHK.AutoSize = true;
            this.FS_STALL_CHK.Checked = true;
            this.FS_STALL_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FS_STALL_CHK.Location = new System.Drawing.Point(20, 166);
            this.FS_STALL_CHK.Name = "FS_STALL_CHK";
            this.FS_STALL_CHK.Size = new System.Drawing.Size(80, 16);
            this.FS_STALL_CHK.TabIndex = 137;
            this.FS_STALL_CHK.Text = "스톨경보 :";
            this.FS_STALL_CHK.UseVisualStyleBackColor = true;
            this.FS_STALL_CHK.CheckedChanged += new System.EventHandler(this.FS_STALL_CHK_CheckedChanged);
            // 
            // FS_STALL_VIB
            // 
            this.FS_STALL_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_STALL_VIB.Location = new System.Drawing.Point(143, 167);
            this.FS_STALL_VIB.Name = "FS_STALL_VIB";
            this.FS_STALL_VIB.Size = new System.Drawing.Size(40, 15);
            this.FS_STALL_VIB.TabIndex = 136;
            this.FS_STALL_VIB.Text = "0";
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label155.Location = new System.Drawing.Point(347, 26);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(63, 13);
            this.label155.TabIndex = 125;
            this.label155.Text = "최종진동";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label156.Location = new System.Drawing.Point(180, 26);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(63, 13);
            this.label156.TabIndex = 124;
            this.label156.Text = "진동보정";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label157.Location = new System.Drawing.Point(132, 26);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(35, 13);
            this.label157.TabIndex = 123;
            this.label157.Text = "진동";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label158.Location = new System.Drawing.Point(19, 26);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(35, 13);
            this.label158.TabIndex = 122;
            this.label158.Text = "항목";
            // 
            // DEFAULT_SETUP_FS
            // 
            this.DEFAULT_SETUP_FS.Location = new System.Drawing.Point(364, 252);
            this.DEFAULT_SETUP_FS.Name = "DEFAULT_SETUP_FS";
            this.DEFAULT_SETUP_FS.Size = new System.Drawing.Size(62, 25);
            this.DEFAULT_SETUP_FS.TabIndex = 121;
            this.DEFAULT_SETUP_FS.Text = "기본값";
            this.DEFAULT_SETUP_FS.UseVisualStyleBackColor = true;
            this.DEFAULT_SETUP_FS.Click += new System.EventHandler(this.DEFAULT_SETUP_FS_Click);
            // 
            // FS_SPOILER_VIB_OUT
            // 
            this.FS_SPOILER_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_SPOILER_VIB_OUT.Location = new System.Drawing.Point(348, 144);
            this.FS_SPOILER_VIB_OUT.Name = "FS_SPOILER_VIB_OUT";
            this.FS_SPOILER_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FS_SPOILER_VIB_OUT.TabIndex = 118;
            this.FS_SPOILER_VIB_OUT.Text = "0";
            // 
            // FS_FLAP_VIB_OUT
            // 
            this.FS_FLAP_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_FLAP_VIB_OUT.Location = new System.Drawing.Point(348, 122);
            this.FS_FLAP_VIB_OUT.Name = "FS_FLAP_VIB_OUT";
            this.FS_FLAP_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FS_FLAP_VIB_OUT.TabIndex = 116;
            this.FS_FLAP_VIB_OUT.Text = "0";
            // 
            // FS_GEAR_VIB_OUT
            // 
            this.FS_GEAR_VIB_OUT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_GEAR_VIB_OUT.Location = new System.Drawing.Point(348, 102);
            this.FS_GEAR_VIB_OUT.Name = "FS_GEAR_VIB_OUT";
            this.FS_GEAR_VIB_OUT.Size = new System.Drawing.Size(40, 15);
            this.FS_GEAR_VIB_OUT.TabIndex = 112;
            this.FS_GEAR_VIB_OUT.Text = "0";
            // 
            // label162
            // 
            this.label162.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label162.Location = new System.Drawing.Point(184, 260);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(102, 15);
            this.label162.TabIndex = 111;
            this.label162.Text = "최대진동 AOA";
            // 
            // label163
            // 
            this.label163.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label163.Location = new System.Drawing.Point(17, 260);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(102, 15);
            this.label163.TabIndex = 110;
            this.label163.Text = "진동시작 AOA";
            // 
            // label164
            // 
            this.label164.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label164.Location = new System.Drawing.Point(242, 143);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(15, 15);
            this.label164.TabIndex = 107;
            this.label164.Text = "%";
            // 
            // label165
            // 
            this.label165.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label165.Location = new System.Drawing.Point(242, 121);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(15, 15);
            this.label165.TabIndex = 105;
            this.label165.Text = "%";
            // 
            // label166
            // 
            this.label166.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label166.Location = new System.Drawing.Point(242, 101);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(15, 15);
            this.label166.TabIndex = 101;
            this.label166.Text = "%";
            // 
            // FS_SPOILER_VIB_PER
            // 
            this.FS_SPOILER_VIB_PER.FormattingEnabled = true;
            this.FS_SPOILER_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FS_SPOILER_VIB_PER.Location = new System.Drawing.Point(183, 139);
            this.FS_SPOILER_VIB_PER.Name = "FS_SPOILER_VIB_PER";
            this.FS_SPOILER_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FS_SPOILER_VIB_PER.TabIndex = 94;
            this.FS_SPOILER_VIB_PER.Text = "100";
            this.FS_SPOILER_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FS_SPOILER_VIB_PER_SelectedIndexChanged);
            // 
            // FS_FLAP_VIB_PER
            // 
            this.FS_FLAP_VIB_PER.FormattingEnabled = true;
            this.FS_FLAP_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FS_FLAP_VIB_PER.Location = new System.Drawing.Point(183, 117);
            this.FS_FLAP_VIB_PER.Name = "FS_FLAP_VIB_PER";
            this.FS_FLAP_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FS_FLAP_VIB_PER.TabIndex = 93;
            this.FS_FLAP_VIB_PER.Text = "100";
            this.FS_FLAP_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FS_FLAP_VIB_PER_SelectedIndexChanged);
            // 
            // FS_GEAR_VIB_PER
            // 
            this.FS_GEAR_VIB_PER.FormattingEnabled = true;
            this.FS_GEAR_VIB_PER.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.FS_GEAR_VIB_PER.Location = new System.Drawing.Point(183, 95);
            this.FS_GEAR_VIB_PER.Name = "FS_GEAR_VIB_PER";
            this.FS_GEAR_VIB_PER.Size = new System.Drawing.Size(53, 20);
            this.FS_GEAR_VIB_PER.TabIndex = 92;
            this.FS_GEAR_VIB_PER.Text = "100";
            this.FS_GEAR_VIB_PER.SelectedIndexChanged += new System.EventHandler(this.FS_GEAR_VIB_PER_SelectedIndexChanged);
            // 
            // FS_AOA_M_COMBO
            // 
            this.FS_AOA_M_COMBO.FormattingEnabled = true;
            this.FS_AOA_M_COMBO.Items.AddRange(new object[] {
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.FS_AOA_M_COMBO.Location = new System.Drawing.Point(293, 255);
            this.FS_AOA_M_COMBO.Name = "FS_AOA_M_COMBO";
            this.FS_AOA_M_COMBO.Size = new System.Drawing.Size(53, 20);
            this.FS_AOA_M_COMBO.TabIndex = 91;
            this.FS_AOA_M_COMBO.Text = "25";
            this.FS_AOA_M_COMBO.SelectedIndexChanged += new System.EventHandler(this.FS_AOA_M_COMBO_SelectedIndexChanged);
            // 
            // FS_AOA_S_COMBO
            // 
            this.FS_AOA_S_COMBO.FormattingEnabled = true;
            this.FS_AOA_S_COMBO.Items.AddRange(new object[] {
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5"});
            this.FS_AOA_S_COMBO.Location = new System.Drawing.Point(125, 255);
            this.FS_AOA_S_COMBO.Name = "FS_AOA_S_COMBO";
            this.FS_AOA_S_COMBO.Size = new System.Drawing.Size(53, 20);
            this.FS_AOA_S_COMBO.TabIndex = 69;
            this.FS_AOA_S_COMBO.Text = "13";
            this.FS_AOA_S_COMBO.SelectedIndexChanged += new System.EventHandler(this.FS_AOA_S_COMBO_SelectedIndexChanged);
            // 
            // FS_SPOILER_CHK
            // 
            this.FS_SPOILER_CHK.AutoSize = true;
            this.FS_SPOILER_CHK.Checked = true;
            this.FS_SPOILER_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FS_SPOILER_CHK.Location = new System.Drawing.Point(20, 143);
            this.FS_SPOILER_CHK.Name = "FS_SPOILER_CHK";
            this.FS_SPOILER_CHK.Size = new System.Drawing.Size(80, 16);
            this.FS_SPOILER_CHK.TabIndex = 83;
            this.FS_SPOILER_CHK.Text = "스포일러 :";
            this.FS_SPOILER_CHK.UseVisualStyleBackColor = true;
            this.FS_SPOILER_CHK.CheckedChanged += new System.EventHandler(this.FS_SPOILER_CHK_CheckedChanged);
            // 
            // FS_FLAP_CHK
            // 
            this.FS_FLAP_CHK.AutoSize = true;
            this.FS_FLAP_CHK.Checked = true;
            this.FS_FLAP_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FS_FLAP_CHK.Location = new System.Drawing.Point(20, 121);
            this.FS_FLAP_CHK.Name = "FS_FLAP_CHK";
            this.FS_FLAP_CHK.Size = new System.Drawing.Size(90, 16);
            this.FS_FLAP_CHK.TabIndex = 82;
            this.FS_FLAP_CHK.Text = "FLAP 가동 :";
            this.FS_FLAP_CHK.UseVisualStyleBackColor = true;
            this.FS_FLAP_CHK.CheckedChanged += new System.EventHandler(this.FS_FLAP_CHK_CheckedChanged);
            // 
            // FS_GEAR_CHK
            // 
            this.FS_GEAR_CHK.AutoSize = true;
            this.FS_GEAR_CHK.Checked = true;
            this.FS_GEAR_CHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FS_GEAR_CHK.Location = new System.Drawing.Point(20, 101);
            this.FS_GEAR_CHK.Name = "FS_GEAR_CHK";
            this.FS_GEAR_CHK.Size = new System.Drawing.Size(93, 16);
            this.FS_GEAR_CHK.TabIndex = 81;
            this.FS_GEAR_CHK.Text = "GEAR 가동 :";
            this.FS_GEAR_CHK.UseVisualStyleBackColor = true;
            this.FS_GEAR_CHK.CheckedChanged += new System.EventHandler(this.FS_GEAR_CHK_CheckedChanged);
            // 
            // FS_SPOILER_VIB
            // 
            this.FS_SPOILER_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_SPOILER_VIB.Location = new System.Drawing.Point(143, 144);
            this.FS_SPOILER_VIB.Name = "FS_SPOILER_VIB";
            this.FS_SPOILER_VIB.Size = new System.Drawing.Size(40, 15);
            this.FS_SPOILER_VIB.TabIndex = 71;
            this.FS_SPOILER_VIB.Text = "0";
            // 
            // FS_FLAP_VIB
            // 
            this.FS_FLAP_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_FLAP_VIB.Location = new System.Drawing.Point(143, 122);
            this.FS_FLAP_VIB.Name = "FS_FLAP_VIB";
            this.FS_FLAP_VIB.Size = new System.Drawing.Size(40, 15);
            this.FS_FLAP_VIB.TabIndex = 70;
            this.FS_FLAP_VIB.Text = "0";
            // 
            // FS_GEAR_VIB
            // 
            this.FS_GEAR_VIB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FS_GEAR_VIB.Location = new System.Drawing.Point(143, 102);
            this.FS_GEAR_VIB.Name = "FS_GEAR_VIB";
            this.FS_GEAR_VIB.Size = new System.Drawing.Size(40, 15);
            this.FS_GEAR_VIB.TabIndex = 54;
            this.FS_GEAR_VIB.Text = "0";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label123);
            this.groupBox13.Controls.Add(this.label124);
            this.groupBox13.Controls.Add(this.FS_OVERSPEED);
            this.groupBox13.Controls.Add(this.FS_STALL);
            this.groupBox13.Controls.Add(this.label113);
            this.groupBox13.Controls.Add(this.label115);
            this.groupBox13.Controls.Add(this.FS_FLAP);
            this.groupBox13.Controls.Add(this.FS_GEAR);
            this.groupBox13.Controls.Add(this.label110);
            this.groupBox13.Controls.Add(this.FS_AOA);
            this.groupBox13.Controls.Add(this.label100);
            this.groupBox13.Controls.Add(this.label102);
            this.groupBox13.Controls.Add(this.label104);
            this.groupBox13.Controls.Add(this.FS_SPOILER_R);
            this.groupBox13.Controls.Add(this.FS_IAS);
            this.groupBox13.Controls.Add(this.FS_SPOILER_L);
            this.groupBox13.Controls.Add(this.label125);
            this.groupBox13.Controls.Add(this.label131);
            this.groupBox13.Controls.Add(this.label140);
            this.groupBox13.Controls.Add(this.label141);
            this.groupBox13.Controls.Add(this.FS_PLANE_NAME);
            this.groupBox13.Controls.Add(this.FS_ACC_Z);
            this.groupBox13.Controls.Add(this.FS_ACC_X);
            this.groupBox13.Controls.Add(this.FS_ACC_Y);
            this.groupBox13.Location = new System.Drawing.Point(12, 14);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(434, 162);
            this.groupBox13.TabIndex = 5;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "FS2020 출력값";
            // 
            // label123
            // 
            this.label123.Location = new System.Drawing.Point(223, 106);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(89, 17);
            this.label123.TabIndex = 69;
            this.label123.Text = "STALL : ";
            // 
            // label124
            // 
            this.label124.Location = new System.Drawing.Point(223, 123);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(90, 16);
            this.label124.TabIndex = 66;
            this.label124.Text = "OVERSPEED :";
            // 
            // FS_OVERSPEED
            // 
            this.FS_OVERSPEED.Location = new System.Drawing.Point(318, 122);
            this.FS_OVERSPEED.Name = "FS_OVERSPEED";
            this.FS_OVERSPEED.Size = new System.Drawing.Size(82, 16);
            this.FS_OVERSPEED.TabIndex = 68;
            this.FS_OVERSPEED.Text = "0";
            // 
            // FS_STALL
            // 
            this.FS_STALL.Location = new System.Drawing.Point(318, 106);
            this.FS_STALL.Name = "FS_STALL";
            this.FS_STALL.Size = new System.Drawing.Size(82, 16);
            this.FS_STALL.TabIndex = 67;
            this.FS_STALL.Text = "0";
            // 
            // label113
            // 
            this.label113.Location = new System.Drawing.Point(223, 73);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(89, 17);
            this.label113.TabIndex = 65;
            this.label113.Text = "GEAR : ";
            // 
            // label115
            // 
            this.label115.Location = new System.Drawing.Point(223, 90);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(90, 16);
            this.label115.TabIndex = 62;
            this.label115.Text = "FLAP :";
            // 
            // FS_FLAP
            // 
            this.FS_FLAP.Location = new System.Drawing.Point(318, 89);
            this.FS_FLAP.Name = "FS_FLAP";
            this.FS_FLAP.Size = new System.Drawing.Size(82, 16);
            this.FS_FLAP.TabIndex = 64;
            this.FS_FLAP.Text = "0";
            // 
            // FS_GEAR
            // 
            this.FS_GEAR.Location = new System.Drawing.Point(318, 73);
            this.FS_GEAR.Name = "FS_GEAR";
            this.FS_GEAR.Size = new System.Drawing.Size(82, 16);
            this.FS_GEAR.TabIndex = 63;
            this.FS_GEAR.Text = "0";
            // 
            // label110
            // 
            this.label110.Location = new System.Drawing.Point(17, 108);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(89, 17);
            this.label110.TabIndex = 61;
            this.label110.Text = "AOA :";
            // 
            // FS_AOA
            // 
            this.FS_AOA.Location = new System.Drawing.Point(112, 108);
            this.FS_AOA.Name = "FS_AOA";
            this.FS_AOA.Size = new System.Drawing.Size(82, 15);
            this.FS_AOA.TabIndex = 60;
            this.FS_AOA.Text = "0";
            // 
            // label100
            // 
            this.label100.Location = new System.Drawing.Point(223, 41);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(89, 17);
            this.label100.TabIndex = 59;
            this.label100.Text = "SPOILER L : ";
            // 
            // label102
            // 
            this.label102.Location = new System.Drawing.Point(17, 91);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(89, 17);
            this.label102.TabIndex = 58;
            this.label102.Text = "IAS :";
            // 
            // label104
            // 
            this.label104.Location = new System.Drawing.Point(223, 58);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(90, 16);
            this.label104.TabIndex = 55;
            this.label104.Text = "SPOILER R :";
            // 
            // FS_SPOILER_R
            // 
            this.FS_SPOILER_R.Location = new System.Drawing.Point(318, 57);
            this.FS_SPOILER_R.Name = "FS_SPOILER_R";
            this.FS_SPOILER_R.Size = new System.Drawing.Size(82, 16);
            this.FS_SPOILER_R.TabIndex = 57;
            this.FS_SPOILER_R.Text = "0";
            // 
            // FS_IAS
            // 
            this.FS_IAS.Location = new System.Drawing.Point(112, 91);
            this.FS_IAS.Name = "FS_IAS";
            this.FS_IAS.Size = new System.Drawing.Size(82, 15);
            this.FS_IAS.TabIndex = 54;
            this.FS_IAS.Text = "0";
            // 
            // FS_SPOILER_L
            // 
            this.FS_SPOILER_L.Location = new System.Drawing.Point(318, 41);
            this.FS_SPOILER_L.Name = "FS_SPOILER_L";
            this.FS_SPOILER_L.Size = new System.Drawing.Size(82, 16);
            this.FS_SPOILER_L.TabIndex = 56;
            this.FS_SPOILER_L.Text = "0";
            // 
            // label125
            // 
            this.label125.Location = new System.Drawing.Point(17, 58);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(89, 17);
            this.label125.TabIndex = 53;
            this.label125.Text = "ACC_Y :";
            // 
            // label131
            // 
            this.label131.Location = new System.Drawing.Point(17, 41);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(89, 17);
            this.label131.TabIndex = 52;
            this.label131.Text = "ACC_X :";
            // 
            // label140
            // 
            this.label140.Location = new System.Drawing.Point(17, 75);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(90, 16);
            this.label140.TabIndex = 31;
            this.label140.Text = "ACC_Z :";
            // 
            // label141
            // 
            this.label141.Location = new System.Drawing.Point(17, 25);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(82, 16);
            this.label141.TabIndex = 30;
            this.label141.Text = "현재항공기 :";
            // 
            // FS_PLANE_NAME
            // 
            this.FS_PLANE_NAME.Location = new System.Drawing.Point(112, 25);
            this.FS_PLANE_NAME.Name = "FS_PLANE_NAME";
            this.FS_PLANE_NAME.Size = new System.Drawing.Size(295, 16);
            this.FS_PLANE_NAME.TabIndex = 29;
            this.FS_PLANE_NAME.Text = "-";
            // 
            // FS_ACC_Z
            // 
            this.FS_ACC_Z.Location = new System.Drawing.Point(112, 72);
            this.FS_ACC_Z.Name = "FS_ACC_Z";
            this.FS_ACC_Z.Size = new System.Drawing.Size(82, 16);
            this.FS_ACC_Z.TabIndex = 32;
            this.FS_ACC_Z.Text = "0";
            // 
            // FS_ACC_X
            // 
            this.FS_ACC_X.Location = new System.Drawing.Point(112, 41);
            this.FS_ACC_X.Name = "FS_ACC_X";
            this.FS_ACC_X.Size = new System.Drawing.Size(82, 15);
            this.FS_ACC_X.TabIndex = 30;
            this.FS_ACC_X.Text = "0";
            // 
            // FS_ACC_Y
            // 
            this.FS_ACC_Y.Location = new System.Drawing.Point(112, 56);
            this.FS_ACC_Y.Name = "FS_ACC_Y";
            this.FS_ACC_Y.Size = new System.Drawing.Size(82, 16);
            this.FS_ACC_Y.TabIndex = 31;
            this.FS_ACC_Y.Text = "0";
            // 
            // Connect_FS2020
            // 
            this.Connect_FS2020.Location = new System.Drawing.Point(337, 620);
            this.Connect_FS2020.Name = "Connect_FS2020";
            this.Connect_FS2020.Size = new System.Drawing.Size(109, 32);
            this.Connect_FS2020.TabIndex = 4;
            this.Connect_FS2020.Text = "Connect";
            this.Connect_FS2020.UseVisualStyleBackColor = true;
            this.Connect_FS2020.Click += new System.EventHandler(this.Connect_FS2020_Click);
            // 
            // vib_timer1
            // 
            this.vib_timer1.Tick += new System.EventHandler(this.vib_timer1_Tick);
            // 
            // vib_timer2
            // 
            this.vib_timer2.Tick += new System.EventHandler(this.vib_timer2_Tick);
            // 
            // Power_Check
            // 
            this.Power_Check.AutoSize = true;
            this.Power_Check.Location = new System.Drawing.Point(13, 833);
            this.Power_Check.Name = "Power_Check";
            this.Power_Check.Size = new System.Drawing.Size(128, 16);
            this.Power_Check.TabIndex = 82;
            this.Power_Check.Text = "보조전원 사용 여부";
            this.Power_Check.UseVisualStyleBackColor = true;
            this.Power_Check.CheckedChanged += new System.EventHandler(this.Power_Check_CheckedChanged);
            // 
            // get_falcon_timer
            // 
            this.get_falcon_timer.Tick += new System.EventHandler(this.get_falcon_timer_Tick);
            // 
            // vib_timer3
            // 
            this.vib_timer3.Tick += new System.EventHandler(this.vib_timer3_Tick);
            // 
            // vib_timer4
            // 
            this.vib_timer4.Tick += new System.EventHandler(this.vib_timer4_Tick);
            // 
            // get_fs2020_timer
            // 
            this.get_fs2020_timer.Tick += new System.EventHandler(this.get_fs2020_timer_Tick);
            // 
            // FFB_SUPPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 854);
            this.Controls.Add(this.Power_Check);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FFB_SUPPORT";
            this.Text = " FFBSUPPORT 5.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FFB_SUPPORT_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.FFB.ResumeLayout(false);
            this.TrimGroup.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Setup.ResumeLayout(false);
            this.Setup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vbar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DCS.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.Groupbox10.ResumeLayout(false);
            this.Groupbox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.FALCON.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.WARTHUNDER.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.FS2020.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar uploadProgressBar;
        private System.Windows.Forms.Button uLoadFirmware;
        private System.Windows.Forms.Button detectPorts;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer getpos_timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FFB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label x_axis_offset;
        private System.Windows.Forms.Label y_axis_offset;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label X_VIB_M;
        private System.Windows.Forms.Label Y_VIB_M;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label X_AXIS;
        private System.Windows.Forms.Label Y_AXIS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label X_FOS;
        private System.Windows.Forms.Label X_VIB;
        private System.Windows.Forms.Label Y_VIB;
        private System.Windows.Forms.Label Y_FOS;
        private System.Windows.Forms.TabPage DCS;
        private System.Windows.Forms.GroupBox Setup;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Dbar_label;
        private System.Windows.Forms.TrackBar Dbar;
        private System.Windows.Forms.ComboBox SetCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mbar_label;
        private System.Windows.Forms.Label Vbar_label;
        private System.Windows.Forms.TrackBar Mbar;
        private System.Windows.Forms.TrackBar Vbar;
        private System.Windows.Forms.GroupBox TrimGroup;
        private System.Windows.Forms.Button Del_Reset_Trim_key;
        private System.Windows.Forms.Button Del_Trim_key;
        private System.Windows.Forms.Label Reset_Trim_key_label;
        private System.Windows.Forms.Button Reset_Trim_key;
        private System.Windows.Forms.Label Trim_key_label;
        private System.Windows.Forms.Button Trim_key;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox JoyCombo;
        private System.Windows.Forms.Label guid;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Connect_DCS;
        private System.Windows.Forms.Label DCS_PLANE_NAME;
        private System.Windows.Forms.Label DCS_ACCS_X;
        private System.Windows.Forms.Label DCS_ACCS_Y;
        private System.Windows.Forms.Label DCS_ACCS_Z;
        private System.Windows.Forms.Label DCS_AOA;
        private System.Windows.Forms.Label DCS_GUN;
        private System.Windows.Forms.Label DCS_GEAR;
        private System.Windows.Forms.Label DCS_FLARE;
        private System.Windows.Forms.Label DCS_CHAFF;
        private System.Windows.Forms.Label DCS_PAYLOAD;
        private System.Windows.Forms.Label DCS_PANEL_1;
        private System.Windows.Forms.Label DCS_SPDBREAK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label DCS_PANEL_5;
        private System.Windows.Forms.Label DCS_PANEL_4;
        private System.Windows.Forms.Label DCS_PANEL_3;
        private System.Windows.Forms.Label DCS_PANEL_2;
        private System.Windows.Forms.Label ACC_VIB;
        private System.Windows.Forms.Timer vib_timer1;
        private System.Windows.Forms.Label GEAR_VIB;
        private System.Windows.Forms.Label DCS_ENG_1;
        private System.Windows.Forms.Label DCS_ENG_2;
        private System.Windows.Forms.GroupBox Groupbox10;
        private System.Windows.Forms.Label PAYLOAD_VIB;
        private System.Windows.Forms.Label CHAFF_VIB;
        private System.Windows.Forms.Label FLARE_VIB;
        private System.Windows.Forms.Label GUN_VIB;
        private System.Windows.Forms.Label SPDBREAK_VIB;
        private System.Windows.Forms.Label AOA_VIB;
        private System.Windows.Forms.Label PANEL_VIB;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox PAYLOAD_CHK;
        private System.Windows.Forms.CheckBox CHAFF_CHK;
        private System.Windows.Forms.CheckBox FLARE_CHK;
        private System.Windows.Forms.CheckBox GUN_CHK;
        private System.Windows.Forms.CheckBox GEAR_CHK;
        private System.Windows.Forms.CheckBox SPDBREAK_CHK;
        private System.Windows.Forms.CheckBox AOA_CHK;
        private System.Windows.Forms.CheckBox PANEL_CHK;
        private System.Windows.Forms.CheckBox ACC_CHK;
        private System.Windows.Forms.ComboBox PAYLOAD_VIB_PER;
        private System.Windows.Forms.ComboBox CHAFF_VIB_PER;
        private System.Windows.Forms.ComboBox FLARE_VIB_PER;
        private System.Windows.Forms.ComboBox GUN_VIB_PER;
        private System.Windows.Forms.ComboBox GEAR_VIB_PER;
        private System.Windows.Forms.ComboBox SPDBREAK_VIB_PER;
        private System.Windows.Forms.ComboBox AOA_VIB_PER;
        private System.Windows.Forms.ComboBox PANEL_VIB_PER;
        private System.Windows.Forms.ComboBox ACC_VIB_PER;
        private System.Windows.Forms.ComboBox AOA_M_COMBO;
        private System.Windows.Forms.ComboBox AOA_S_COMBO;
        private System.Windows.Forms.ComboBox PLANE_LIST_COMBO;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label PAYLOAD_VIB_OUT;
        private System.Windows.Forms.Label CHAFF_VIB_OUT;
        private System.Windows.Forms.Label FLARE_VIB_OUT;
        private System.Windows.Forms.Label GUN_VIB_OUT;
        private System.Windows.Forms.Label SPDBREAK_VIB_OUT;
        private System.Windows.Forms.Label AOA_VIB_OUT;
        private System.Windows.Forms.Label PANEL_VIB_OUT;
        private System.Windows.Forms.Label GEAR_VIB_OUT;
        private System.Windows.Forms.Label ACC_VIB_OUT;
        private System.Windows.Forms.Button DEFAULT_SETUP;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label VIB_OUT;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TabPage WARTHUNDER;
        private System.Windows.Forms.Button Connect_WT;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label WT_AOS;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label WT_PLANE_NAME;
        private System.Windows.Forms.Label WT_AOA;
        private System.Windows.Forms.Label WT_IAS;
        private System.Windows.Forms.Label WT_TAS;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label WT_FLAP;
        private System.Windows.Forms.Label WT_GEAR;
        private System.Windows.Forms.Label WT_WEAPON3;
        private System.Windows.Forms.Label WT_WEAPON1;
        private System.Windows.Forms.Label WT_WEAPON2;
        private System.Windows.Forms.Label WT_THROTTLE2;
        private System.Windows.Forms.Label WT_THROTTLE1;
        private System.Windows.Forms.Label WT_NY;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label WT_AIRBREAK;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label WT_WX;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Button DEFAULT_SETUP_WT;
        private System.Windows.Forms.Label WT_WX_VIB_OUT;
        private System.Windows.Forms.Label WT_NY_VIB_OUT;
        private System.Windows.Forms.Label WT_AOS_VIB_OUT;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.ComboBox WT_WX_VIB_PER;
        private System.Windows.Forms.ComboBox WT_NY_VIB_PER;
        private System.Windows.Forms.ComboBox WT_AOS_VIB_PER;
        private System.Windows.Forms.ComboBox WT_AOA_M_COMBO;
        private System.Windows.Forms.ComboBox WT_AOA_S_COMBO;
        private System.Windows.Forms.ComboBox PLANE_LIST_COMBO_WT;
        private System.Windows.Forms.CheckBox WT_WX_CHK;
        private System.Windows.Forms.CheckBox WT_NY_CHK;
        private System.Windows.Forms.CheckBox WT_AOS_CHK;
        private System.Windows.Forms.Label WT_WX_VIB;
        private System.Windows.Forms.Label WT_NY_VIB;
        private System.Windows.Forms.Label WT_AOS_VIB;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label WT_VIB_OUT;
        private System.Windows.Forms.Timer vib_timer2;
        private System.Windows.Forms.Label WT_AOA_VIB_OUT;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.ComboBox WT_AOA_VIB_PER;
        private System.Windows.Forms.CheckBox WT_AOA_CHK;
        private System.Windows.Forms.Label WT_AOA_VIB;
        private System.Windows.Forms.Label WT_GEAR_VIB_OUT;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.ComboBox WT_GEAR_VIB_PER;
        private System.Windows.Forms.CheckBox WT_GEAR_CHK;
        private System.Windows.Forms.Label WT_GEAR_VIB;
        private System.Windows.Forms.Label WT_FLAP_VIB_OUT;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox WT_FLAP_VIB_PER;
        private System.Windows.Forms.CheckBox WT_FLAP_CHK;
        private System.Windows.Forms.Label WT_FLAP_VIB;
        private System.Windows.Forms.Label WT_AIRBREAK_VIB_OUT;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.ComboBox WT_AIRBREAK_VIB_PER;
        private System.Windows.Forms.CheckBox WT_AIRBREAK_CHK;
        private System.Windows.Forms.Label WT_AIRBREAK_VIB;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label DCS_IAS;
        private System.Windows.Forms.Label WT_WEP_VIB_OUT;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.ComboBox WT_WEP_VIB_PER;
        private System.Windows.Forms.CheckBox WT_WEP_CHK;
        private System.Windows.Forms.Label WT_WEP_VIB;
        private System.Windows.Forms.Label WT_GUN_VIB_OUT;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.ComboBox WT_GUN_VIB_PER;
        private System.Windows.Forms.CheckBox WT_GUN_CHK;
        private System.Windows.Forms.Label WT_GUN_VIB;
        private System.Windows.Forms.Timer joypos_timer1;
        private System.Windows.Forms.CheckBox Power_Check;
        private System.Windows.Forms.TabPage FALCON;
        private System.Windows.Forms.Button Connect_FALCON;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label FALCON_X;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label FALCON_Y;
        private System.Windows.Forms.Label FALCON_Z;
        private System.Windows.Forms.Timer get_falcon_timer;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label FALCON_GEAR;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label FALCON_BREAK;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label FALCON_AOA;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label FALCON_FIREGUN;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label FALCON_AA;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label FALCON_DAMAGE_F;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label FALCON_VIB_OUT;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label FALCON_DAMAGE_VIB_OUT;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.ComboBox FALCON_DAMAGE_VIB_PER;
        private System.Windows.Forms.CheckBox FALCON_DAMAGE_CHK;
        private System.Windows.Forms.Label FALCON_DAMAGE_VIB;
        private System.Windows.Forms.Label FALCON_CHFL_VIB_OUT;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.ComboBox FALCON_CHFL_VIB_PER;
        private System.Windows.Forms.CheckBox FALCON_CHFL_CHK;
        private System.Windows.Forms.Label FALCON_CHFL_VIB;
        private System.Windows.Forms.Label FALCON_AIRBREAK_VIB_OUT;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.ComboBox FALCON_AIRBREAK_VIB_PER;
        private System.Windows.Forms.CheckBox FALCON_AIRBREAK_CHK;
        private System.Windows.Forms.Label FALCON_AIRBREAK_VIB;
        private System.Windows.Forms.Label FALCON_GEAR_VIB_OUT;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.ComboBox FALCON_GEAR_VIB_PER;
        private System.Windows.Forms.CheckBox FALCON_GEAR_CHK;
        private System.Windows.Forms.Label FALCON_GEAR_VIB;
        private System.Windows.Forms.Label FALCON_PAYLOAD_VIB_OUT;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.ComboBox FALCON_PAYLOAD_VIB_PER;
        private System.Windows.Forms.CheckBox FALCON_PAYLOAD_CHK;
        private System.Windows.Forms.Label FALCON_PAYLOAD_VIB;
        private System.Windows.Forms.Label FALCON_GUN_VIB_OUT;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.ComboBox FALCON_GUN_VIB_PER;
        private System.Windows.Forms.CheckBox FALCON_GUN_CHK;
        private System.Windows.Forms.Label FALCON_GUN_VIB;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Button DEFAULT_SETUP_FALCON;
        private System.Windows.Forms.Label FALCON_BUNNER_VIB_OUT;
        private System.Windows.Forms.Label FALCON_AOA_VIB_OUT;
        private System.Windows.Forms.Label FALCON_YAW_VIB_OUT;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.ComboBox FALCON_BUNNER_VIB_PER;
        private System.Windows.Forms.ComboBox FALCON_AOA_VIB_PER;
        private System.Windows.Forms.ComboBox FALCON_YAW_VIB_PER;
        private System.Windows.Forms.ComboBox FALCON_AOA_M_COMBO;
        private System.Windows.Forms.ComboBox FALCON_AOA_S_COMBO;
        private System.Windows.Forms.CheckBox FALCON_BUNNER_CHK;
        private System.Windows.Forms.CheckBox FALCON_AOA_CHK;
        private System.Windows.Forms.CheckBox FALCON_YAW_CHK;
        private System.Windows.Forms.Label FALCON_BUNNER_VIB;
        private System.Windows.Forms.Label FALCON_AOA_VIB;
        private System.Windows.Forms.Label FALCON_YAW_VIB;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label FALCON_NOZZLE;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label FALCON_FLARE;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label FALCON_CHAFF;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label FALCON_BOMB;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label FALCON_AG;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label FALCON_IAS;
        private System.Windows.Forms.Label FALCON_ROLL_VIB_OUT;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.ComboBox FALCON_ROLL_VIB_PER;
        private System.Windows.Forms.CheckBox FALCON_ROLL_CHK;
        private System.Windows.Forms.Label FALCON_ROLL_VIB;
        private System.Windows.Forms.Label FALCON_PITCH_VIB_OUT;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.ComboBox FALCON_PITCH_VIB_PER;
        private System.Windows.Forms.CheckBox FALCON_PITCH_CHK;
        private System.Windows.Forms.Label FALCON_PITCH_VIB;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label FALCON_DAMAGE;
        private System.Windows.Forms.Timer vib_timer3;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.ComboBox ACC_VIB_MIN;
        private System.Windows.Forms.ComboBox PANEL_VIB_MIN;
        private System.Windows.Forms.ComboBox FALCON_YAW_VIB_MIN;
        private System.Windows.Forms.ComboBox FALCON_ROLL_VIB_MIN;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.ComboBox FALCON_PITCH_VIB_MIN;
        private System.Windows.Forms.ComboBox WT_WX_VIB_MIN;
        private System.Windows.Forms.ComboBox WT_NY_VIB_MIN;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.ComboBox WT_AOS_VIB_MIN;
        private System.Windows.Forms.Label HELI_VIB_OUT;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.ComboBox HELI_VIB_PER;
        private System.Windows.Forms.CheckBox HELI_CHK;
        private System.Windows.Forms.Label HELI_VIB;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label FALCON_INGAME;
        private System.Windows.Forms.TabPage FS2020;
        private System.Windows.Forms.Button Connect_FS2020;
        private System.Windows.Forms.Timer vib_timer4;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label FS_PLANE_NAME;
        private System.Windows.Forms.Label FS_ACC_Z;
        private System.Windows.Forms.Label FS_ACC_X;
        private System.Windows.Forms.Label FS_ACC_Y;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label FS_SPOILER_R;
        private System.Windows.Forms.Label FS_IAS;
        private System.Windows.Forms.Label FS_SPOILER_L;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label FS_OVERSPEED;
        private System.Windows.Forms.Label FS_STALL;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label FS_FLAP;
        private System.Windows.Forms.Label FS_GEAR;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label FS_AOA;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label FS_VIB_OUT;
        private System.Windows.Forms.Timer get_fs2020_timer;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.ComboBox FS_ACC_VIB_MIN;
        private System.Windows.Forms.Label FS_AOA_VIB_OUT;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.ComboBox FS_AOA_VIB_PER;
        private System.Windows.Forms.CheckBox FS_AOA_CHK;
        private System.Windows.Forms.Label FS_AOA_VIB;
        private System.Windows.Forms.Label FS_ACC_VIB_OUT;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.ComboBox FS_ACC_VIB_PER;
        private System.Windows.Forms.CheckBox FS_ACC_CHK;
        private System.Windows.Forms.Label FS_ACC_VIB;
        private System.Windows.Forms.Label FS_OVERSPEED_VIB_OUT;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.ComboBox FS_OVERSPEED_VIB_PER;
        private System.Windows.Forms.CheckBox FS_OVERSPEED_CHK;
        private System.Windows.Forms.Label FS_OVERSPEED_VIB;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Button DEFAULT_SETUP_FS;
        private System.Windows.Forms.Label FS_SPOILER_VIB_OUT;
        private System.Windows.Forms.Label FS_FLAP_VIB_OUT;
        private System.Windows.Forms.Label FS_GEAR_VIB_OUT;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.ComboBox FS_SPOILER_VIB_PER;
        private System.Windows.Forms.ComboBox FS_FLAP_VIB_PER;
        private System.Windows.Forms.ComboBox FS_GEAR_VIB_PER;
        private System.Windows.Forms.ComboBox FS_AOA_M_COMBO;
        private System.Windows.Forms.ComboBox FS_AOA_S_COMBO;
        private System.Windows.Forms.CheckBox FS_SPOILER_CHK;
        private System.Windows.Forms.CheckBox FS_FLAP_CHK;
        private System.Windows.Forms.CheckBox FS_GEAR_CHK;
        private System.Windows.Forms.Label FS_SPOILER_VIB;
        private System.Windows.Forms.Label FS_FLAP_VIB;
        private System.Windows.Forms.Label FS_GEAR_VIB;
        private System.Windows.Forms.Label FS_STALL_VIB_OUT;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.ComboBox FS_STALL_VIB_PER;
        private System.Windows.Forms.CheckBox FS_STALL_CHK;
        private System.Windows.Forms.Label FS_STALL_VIB;
    }
}

