namespace WifiCatBuilder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_wifi = new System.Windows.Forms.TabPage();
            this.gb_enterprise = new System.Windows.Forms.GroupBox();
            this.cb_phase2 = new System.Windows.Forms.ComboBox();
            this.c_client_cert = new System.Windows.Forms.CheckBox();
            this.l_phase2 = new System.Windows.Forms.Label();
            this.l_client_cert = new System.Windows.Forms.Label();
            this.tb_outer_id = new System.Windows.Forms.TextBox();
            this.tb_subj_alt_match = new System.Windows.Forms.TextBox();
            this.l_outer_id = new System.Windows.Forms.Label();
            this.l_subj_alt_match = new System.Windows.Forms.Label();
            this.l_dns_suffix = new System.Windows.Forms.Label();
            this.tb_dns_suffix = new System.Windows.Forms.TextBox();
            this.l_cacert = new System.Windows.Forms.Label();
            this.b_cacert = new System.Windows.Forms.Button();
            this.tb_cacert = new System.Windows.Forms.TextBox();
            this.l_eapmethod = new System.Windows.Forms.Label();
            this.cb_eapmethod = new System.Windows.Forms.ComboBox();
            this.gb_wificonfig = new System.Windows.Forms.GroupBox();
            this.l_ssid_del = new System.Windows.Forms.Label();
            this.tb_ssid_del = new System.Windows.Forms.TextBox();
            this.l_protocol = new System.Windows.Forms.Label();
            this.cb_protocol = new System.Windows.Forms.ComboBox();
            this.l_group = new System.Windows.Forms.Label();
            this.cb_group = new System.Windows.Forms.ComboBox();
            this.cb_pairwise = new System.Windows.Forms.ComboBox();
            this.l_pairwise = new System.Windows.Forms.Label();
            this.l_ssid = new System.Windows.Forms.Label();
            this.tb_ssid = new System.Windows.Forms.TextBox();
            this.tabPage_applications = new System.Windows.Forms.TabPage();
            this.gb_application_path = new System.Windows.Forms.GroupBox();
            this.b_web_path = new System.Windows.Forms.Button();
            this.b_android_path = new System.Windows.Forms.Button();
            this.b_windows_path = new System.Windows.Forms.Button();
            this.l_web_path = new System.Windows.Forms.Label();
            this.l_android_path = new System.Windows.Forms.Label();
            this.tb_web_path = new System.Windows.Forms.TextBox();
            this.tb_android_path = new System.Windows.Forms.TextBox();
            this.tb_windows_path = new System.Windows.Forms.TextBox();
            this.l_windows_path = new System.Windows.Forms.Label();
            this.gb_app_settings = new System.Windows.Forms.GroupBox();
            this.p_color_scheme = new System.Windows.Forms.Panel();
            this.b_color_accent = new System.Windows.Forms.Button();
            this.l_color_scheme = new System.Windows.Forms.Label();
            this.p_color_primary = new System.Windows.Forms.Panel();
            this.l_color_primary = new System.Windows.Forms.Label();
            this.p_color_primary_dark = new System.Windows.Forms.Panel();
            this.l_color_primary_dark = new System.Windows.Forms.Label();
            this.p_color_accent = new System.Windows.Forms.Panel();
            this.l_color_accent = new System.Windows.Forms.Label();
            this.b_color_primary_dark = new System.Windows.Forms.Button();
            this.b_color_primary = new System.Windows.Forms.Button();
            this.tb_dl_url = new System.Windows.Forms.TextBox();
            this.l_dl_url = new System.Windows.Forms.Label();
            this.l_edit_brand_list = new System.Windows.Forms.LinkLabel();
            this.c_req_brand = new System.Windows.Forms.CheckBox();
            this.c_req_lock = new System.Windows.Forms.CheckBox();
            this.c_no_root = new System.Windows.Forms.CheckBox();
            this.b_app_logo = new System.Windows.Forms.Button();
            this.pb_app_logo = new System.Windows.Forms.PictureBox();
            this.l_app_logo = new System.Windows.Forms.Label();
            this.tabPage_build = new System.Windows.Forms.TabPage();
            this.gb_sign = new System.Windows.Forms.GroupBox();
            this.l_signing_cert_cn = new System.Windows.Forms.Label();
            this.c_sign_apple = new System.Windows.Forms.CheckBox();
            this.c_sign_windows = new System.Windows.Forms.CheckBox();
            this.c_sign_android = new System.Windows.Forms.CheckBox();
            this.l_signing_cert = new System.Windows.Forms.Label();
            this.b_signing_cert = new System.Windows.Forms.Button();
            this.tb_signing_cert = new System.Windows.Forms.TextBox();
            this.tt_cacert = new System.Windows.Forms.ToolTip(this.components);
            this.ofd_cacert = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fbd_android = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd_windows = new System.Windows.Forms.OpenFileDialog();
            this.fbd_webpage = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd_siging_cert = new System.Windows.Forms.OpenFileDialog();
            this.gb_build = new System.Windows.Forms.GroupBox();
            this.tb_build = new System.Windows.Forms.TextBox();
            this.b_build = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage_wifi.SuspendLayout();
            this.gb_enterprise.SuspendLayout();
            this.gb_wificonfig.SuspendLayout();
            this.tabPage_applications.SuspendLayout();
            this.gb_application_path.SuspendLayout();
            this.gb_app_settings.SuspendLayout();
            this.p_color_scheme.SuspendLayout();
            this.p_color_primary.SuspendLayout();
            this.p_color_primary_dark.SuspendLayout();
            this.p_color_accent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_app_logo)).BeginInit();
            this.tabPage_build.SuspendLayout();
            this.gb_sign.SuspendLayout();
            this.gb_build.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_wifi);
            this.tabControl.Controls.Add(this.tabPage_applications);
            this.tabControl.Controls.Add(this.tabPage_build);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(538, 477);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_wifi
            // 
            this.tabPage_wifi.Controls.Add(this.gb_enterprise);
            this.tabPage_wifi.Controls.Add(this.gb_wificonfig);
            this.tabPage_wifi.Location = new System.Drawing.Point(4, 22);
            this.tabPage_wifi.Name = "tabPage_wifi";
            this.tabPage_wifi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_wifi.Size = new System.Drawing.Size(530, 451);
            this.tabPage_wifi.TabIndex = 0;
            this.tabPage_wifi.Text = "Wifi Settings";
            this.tabPage_wifi.UseVisualStyleBackColor = true;
            // 
            // gb_enterprise
            // 
            this.gb_enterprise.Controls.Add(this.cb_phase2);
            this.gb_enterprise.Controls.Add(this.c_client_cert);
            this.gb_enterprise.Controls.Add(this.l_phase2);
            this.gb_enterprise.Controls.Add(this.l_client_cert);
            this.gb_enterprise.Controls.Add(this.tb_outer_id);
            this.gb_enterprise.Controls.Add(this.tb_subj_alt_match);
            this.gb_enterprise.Controls.Add(this.l_outer_id);
            this.gb_enterprise.Controls.Add(this.l_subj_alt_match);
            this.gb_enterprise.Controls.Add(this.l_dns_suffix);
            this.gb_enterprise.Controls.Add(this.tb_dns_suffix);
            this.gb_enterprise.Controls.Add(this.l_cacert);
            this.gb_enterprise.Controls.Add(this.b_cacert);
            this.gb_enterprise.Controls.Add(this.tb_cacert);
            this.gb_enterprise.Controls.Add(this.l_eapmethod);
            this.gb_enterprise.Controls.Add(this.cb_eapmethod);
            this.gb_enterprise.Location = new System.Drawing.Point(9, 185);
            this.gb_enterprise.Name = "gb_enterprise";
            this.gb_enterprise.Size = new System.Drawing.Size(513, 258);
            this.gb_enterprise.TabIndex = 1;
            this.gb_enterprise.TabStop = false;
            this.gb_enterprise.Text = "Enterprise Config";
            // 
            // cb_phase2
            // 
            this.cb_phase2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_phase2.FormattingEnabled = true;
            this.cb_phase2.Items.AddRange(new object[] {
            "GTC",
            "MSCHAP",
            "MSCHAPv2",
            "PAP"});
            this.cb_phase2.Location = new System.Drawing.Point(255, 184);
            this.cb_phase2.Name = "cb_phase2";
            this.cb_phase2.Size = new System.Drawing.Size(188, 21);
            this.cb_phase2.TabIndex = 22;
            // 
            // c_client_cert
            // 
            this.c_client_cert.AutoSize = true;
            this.c_client_cert.Enabled = false;
            this.c_client_cert.Location = new System.Drawing.Point(255, 161);
            this.c_client_cert.Name = "c_client_cert";
            this.c_client_cert.Size = new System.Drawing.Size(45, 17);
            this.c_client_cert.TabIndex = 21;
            this.c_client_cert.Text = "Use";
            this.c_client_cert.UseVisualStyleBackColor = true;
            // 
            // l_phase2
            // 
            this.l_phase2.AutoSize = true;
            this.l_phase2.Location = new System.Drawing.Point(62, 187);
            this.l_phase2.Name = "l_phase2";
            this.l_phase2.Size = new System.Drawing.Size(85, 13);
            this.l_phase2.TabIndex = 20;
            this.l_phase2.Text = "Phase 2 Method";
            // 
            // l_client_cert
            // 
            this.l_client_cert.AutoSize = true;
            this.l_client_cert.Enabled = false;
            this.l_client_cert.Location = new System.Drawing.Point(62, 162);
            this.l_client_cert.Name = "l_client_cert";
            this.l_client_cert.Size = new System.Drawing.Size(83, 13);
            this.l_client_cert.TabIndex = 19;
            this.l_client_cert.Text = "Client Certificate";
            // 
            // tb_outer_id
            // 
            this.tb_outer_id.Location = new System.Drawing.Point(255, 135);
            this.tb_outer_id.Name = "tb_outer_id";
            this.tb_outer_id.Size = new System.Drawing.Size(188, 20);
            this.tb_outer_id.TabIndex = 18;
            // 
            // tb_subj_alt_match
            // 
            this.tb_subj_alt_match.Location = new System.Drawing.Point(255, 109);
            this.tb_subj_alt_match.Name = "tb_subj_alt_match";
            this.tb_subj_alt_match.Size = new System.Drawing.Size(188, 20);
            this.tb_subj_alt_match.TabIndex = 17;
            // 
            // l_outer_id
            // 
            this.l_outer_id.AutoSize = true;
            this.l_outer_id.Location = new System.Drawing.Point(62, 138);
            this.l_outer_id.Name = "l_outer_id";
            this.l_outer_id.Size = new System.Drawing.Size(134, 13);
            this.l_outer_id.TabIndex = 16;
            this.l_outer_id.Text = "Outer (Anonymous) Identity";
            // 
            // l_subj_alt_match
            // 
            this.l_subj_alt_match.AutoSize = true;
            this.l_subj_alt_match.Location = new System.Drawing.Point(62, 112);
            this.l_subj_alt_match.Name = "l_subj_alt_match";
            this.l_subj_alt_match.Size = new System.Drawing.Size(152, 13);
            this.l_subj_alt_match.TabIndex = 15;
            this.l_subj_alt_match.Text = "Subject Alternate Name Match";
            // 
            // l_dns_suffix
            // 
            this.l_dns_suffix.AutoSize = true;
            this.l_dns_suffix.Location = new System.Drawing.Point(62, 86);
            this.l_dns_suffix.Name = "l_dns_suffix";
            this.l_dns_suffix.Size = new System.Drawing.Size(92, 13);
            this.l_dns_suffix.TabIndex = 14;
            this.l_dns_suffix.Text = "DNS Suffix Match";
            // 
            // tb_dns_suffix
            // 
            this.tb_dns_suffix.Location = new System.Drawing.Point(255, 83);
            this.tb_dns_suffix.Name = "tb_dns_suffix";
            this.tb_dns_suffix.Size = new System.Drawing.Size(188, 20);
            this.tb_dns_suffix.TabIndex = 13;
            // 
            // l_cacert
            // 
            this.l_cacert.AutoSize = true;
            this.l_cacert.Location = new System.Drawing.Point(62, 60);
            this.l_cacert.Name = "l_cacert";
            this.l_cacert.Size = new System.Drawing.Size(97, 13);
            this.l_cacert.TabIndex = 12;
            this.l_cacert.Text = "CA Root Certificate";
            // 
            // b_cacert
            // 
            this.b_cacert.Location = new System.Drawing.Point(414, 57);
            this.b_cacert.Name = "b_cacert";
            this.b_cacert.Size = new System.Drawing.Size(29, 20);
            this.b_cacert.TabIndex = 11;
            this.b_cacert.Text = "...";
            this.b_cacert.UseVisualStyleBackColor = true;
            this.b_cacert.Click += new System.EventHandler(this.b_cacert_Click);
            // 
            // tb_cacert
            // 
            this.tb_cacert.Location = new System.Drawing.Point(255, 57);
            this.tb_cacert.Name = "tb_cacert";
            this.tb_cacert.Size = new System.Drawing.Size(153, 20);
            this.tb_cacert.TabIndex = 10;
            this.tt_cacert.SetToolTip(this.tb_cacert, "No Certificate Selected");
            // 
            // l_eapmethod
            // 
            this.l_eapmethod.AutoSize = true;
            this.l_eapmethod.Location = new System.Drawing.Point(62, 33);
            this.l_eapmethod.Name = "l_eapmethod";
            this.l_eapmethod.Size = new System.Drawing.Size(67, 13);
            this.l_eapmethod.TabIndex = 9;
            this.l_eapmethod.Text = "EAP Method";
            // 
            // cb_eapmethod
            // 
            this.cb_eapmethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_eapmethod.FormattingEnabled = true;
            this.cb_eapmethod.Items.AddRange(new object[] {
            "PEAP",
            "TLS",
            "TTLS"});
            this.cb_eapmethod.Location = new System.Drawing.Point(255, 30);
            this.cb_eapmethod.Name = "cb_eapmethod";
            this.cb_eapmethod.Size = new System.Drawing.Size(188, 21);
            this.cb_eapmethod.TabIndex = 8;
            // 
            // gb_wificonfig
            // 
            this.gb_wificonfig.Controls.Add(this.l_ssid_del);
            this.gb_wificonfig.Controls.Add(this.tb_ssid_del);
            this.gb_wificonfig.Controls.Add(this.l_protocol);
            this.gb_wificonfig.Controls.Add(this.cb_protocol);
            this.gb_wificonfig.Controls.Add(this.l_group);
            this.gb_wificonfig.Controls.Add(this.cb_group);
            this.gb_wificonfig.Controls.Add(this.cb_pairwise);
            this.gb_wificonfig.Controls.Add(this.l_pairwise);
            this.gb_wificonfig.Controls.Add(this.l_ssid);
            this.gb_wificonfig.Controls.Add(this.tb_ssid);
            this.gb_wificonfig.Location = new System.Drawing.Point(8, 6);
            this.gb_wificonfig.Name = "gb_wificonfig";
            this.gb_wificonfig.Size = new System.Drawing.Size(514, 173);
            this.gb_wificonfig.TabIndex = 0;
            this.gb_wificonfig.TabStop = false;
            this.gb_wificonfig.Text = "Wifi Configuration";
            // 
            // l_ssid_del
            // 
            this.l_ssid_del.AutoSize = true;
            this.l_ssid_del.Location = new System.Drawing.Point(63, 150);
            this.l_ssid_del.Name = "l_ssid_del";
            this.l_ssid_del.Size = new System.Drawing.Size(76, 13);
            this.l_ssid_del.TabIndex = 11;
            this.l_ssid_del.Text = "SSID to delete";
            // 
            // tb_ssid_del
            // 
            this.tb_ssid_del.Location = new System.Drawing.Point(256, 147);
            this.tb_ssid_del.Name = "tb_ssid_del";
            this.tb_ssid_del.Size = new System.Drawing.Size(188, 20);
            this.tb_ssid_del.TabIndex = 10;
            // 
            // l_protocol
            // 
            this.l_protocol.AutoSize = true;
            this.l_protocol.Location = new System.Drawing.Point(63, 113);
            this.l_protocol.Name = "l_protocol";
            this.l_protocol.Size = new System.Drawing.Size(46, 13);
            this.l_protocol.TabIndex = 9;
            this.l_protocol.Text = "Protocol";
            // 
            // cb_protocol
            // 
            this.cb_protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_protocol.FormattingEnabled = true;
            this.cb_protocol.Items.AddRange(new object[] {
            "RSN",
            "WPA"});
            this.cb_protocol.Location = new System.Drawing.Point(256, 110);
            this.cb_protocol.Name = "cb_protocol";
            this.cb_protocol.Size = new System.Drawing.Size(188, 21);
            this.cb_protocol.TabIndex = 8;
            // 
            // l_group
            // 
            this.l_group.AutoSize = true;
            this.l_group.Location = new System.Drawing.Point(63, 86);
            this.l_group.Name = "l_group";
            this.l_group.Size = new System.Drawing.Size(69, 13);
            this.l_group.TabIndex = 7;
            this.l_group.Text = "Group Chiper";
            // 
            // cb_group
            // 
            this.cb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_group.FormattingEnabled = true;
            this.cb_group.Items.AddRange(new object[] {
            "CCMP",
            "TKIP"});
            this.cb_group.Location = new System.Drawing.Point(256, 83);
            this.cb_group.Name = "cb_group";
            this.cb_group.Size = new System.Drawing.Size(188, 21);
            this.cb_group.TabIndex = 6;
            // 
            // cb_pairwise
            // 
            this.cb_pairwise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pairwise.FormattingEnabled = true;
            this.cb_pairwise.Items.AddRange(new object[] {
            "CCMP",
            "TKIP"});
            this.cb_pairwise.Location = new System.Drawing.Point(256, 56);
            this.cb_pairwise.Name = "cb_pairwise";
            this.cb_pairwise.Size = new System.Drawing.Size(188, 21);
            this.cb_pairwise.TabIndex = 5;
            // 
            // l_pairwise
            // 
            this.l_pairwise.AutoSize = true;
            this.l_pairwise.Location = new System.Drawing.Point(63, 59);
            this.l_pairwise.Name = "l_pairwise";
            this.l_pairwise.Size = new System.Drawing.Size(79, 13);
            this.l_pairwise.TabIndex = 2;
            this.l_pairwise.Text = "Pairwise Chiper";
            // 
            // l_ssid
            // 
            this.l_ssid.AutoSize = true;
            this.l_ssid.Location = new System.Drawing.Point(63, 27);
            this.l_ssid.Name = "l_ssid";
            this.l_ssid.Size = new System.Drawing.Size(32, 13);
            this.l_ssid.TabIndex = 1;
            this.l_ssid.Text = "SSID";
            // 
            // tb_ssid
            // 
            this.tb_ssid.Location = new System.Drawing.Point(256, 24);
            this.tb_ssid.Name = "tb_ssid";
            this.tb_ssid.Size = new System.Drawing.Size(188, 20);
            this.tb_ssid.TabIndex = 0;
            // 
            // tabPage_applications
            // 
            this.tabPage_applications.Controls.Add(this.gb_application_path);
            this.tabPage_applications.Controls.Add(this.gb_app_settings);
            this.tabPage_applications.Location = new System.Drawing.Point(4, 22);
            this.tabPage_applications.Name = "tabPage_applications";
            this.tabPage_applications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_applications.Size = new System.Drawing.Size(530, 451);
            this.tabPage_applications.TabIndex = 1;
            this.tabPage_applications.Text = "Application Settings";
            this.tabPage_applications.UseVisualStyleBackColor = true;
            // 
            // gb_application_path
            // 
            this.gb_application_path.Controls.Add(this.b_web_path);
            this.gb_application_path.Controls.Add(this.b_android_path);
            this.gb_application_path.Controls.Add(this.b_windows_path);
            this.gb_application_path.Controls.Add(this.l_web_path);
            this.gb_application_path.Controls.Add(this.l_android_path);
            this.gb_application_path.Controls.Add(this.tb_web_path);
            this.gb_application_path.Controls.Add(this.tb_android_path);
            this.gb_application_path.Controls.Add(this.tb_windows_path);
            this.gb_application_path.Controls.Add(this.l_windows_path);
            this.gb_application_path.Location = new System.Drawing.Point(8, 254);
            this.gb_application_path.Name = "gb_application_path";
            this.gb_application_path.Size = new System.Drawing.Size(514, 189);
            this.gb_application_path.TabIndex = 1;
            this.gb_application_path.TabStop = false;
            this.gb_application_path.Text = "Application Paths";
            // 
            // b_web_path
            // 
            this.b_web_path.Location = new System.Drawing.Point(453, 146);
            this.b_web_path.Name = "b_web_path";
            this.b_web_path.Size = new System.Drawing.Size(29, 20);
            this.b_web_path.TabIndex = 12;
            this.b_web_path.Text = "...";
            this.b_web_path.UseVisualStyleBackColor = true;
            // 
            // b_android_path
            // 
            this.b_android_path.Location = new System.Drawing.Point(453, 95);
            this.b_android_path.Name = "b_android_path";
            this.b_android_path.Size = new System.Drawing.Size(29, 20);
            this.b_android_path.TabIndex = 11;
            this.b_android_path.Text = "...";
            this.b_android_path.UseVisualStyleBackColor = true;
            // 
            // b_windows_path
            // 
            this.b_windows_path.Location = new System.Drawing.Point(453, 46);
            this.b_windows_path.Name = "b_windows_path";
            this.b_windows_path.Size = new System.Drawing.Size(29, 20);
            this.b_windows_path.TabIndex = 13;
            this.b_windows_path.Text = "...";
            this.b_windows_path.UseVisualStyleBackColor = true;
            // 
            // l_web_path
            // 
            this.l_web_path.AutoSize = true;
            this.l_web_path.Location = new System.Drawing.Point(29, 130);
            this.l_web_path.Name = "l_web_path";
            this.l_web_path.Size = new System.Drawing.Size(79, 13);
            this.l_web_path.TabIndex = 5;
            this.l_web_path.Text = "Webpage Path";
            // 
            // l_android_path
            // 
            this.l_android_path.AutoSize = true;
            this.l_android_path.Location = new System.Drawing.Point(29, 79);
            this.l_android_path.Name = "l_android_path";
            this.l_android_path.Size = new System.Drawing.Size(137, 13);
            this.l_android_path.TabIndex = 4;
            this.l_android_path.Text = "Android Studio Project Path";
            // 
            // tb_web_path
            // 
            this.tb_web_path.Location = new System.Drawing.Point(32, 146);
            this.tb_web_path.Name = "tb_web_path";
            this.tb_web_path.Size = new System.Drawing.Size(412, 20);
            this.tb_web_path.TabIndex = 3;
            // 
            // tb_android_path
            // 
            this.tb_android_path.Location = new System.Drawing.Point(32, 95);
            this.tb_android_path.Name = "tb_android_path";
            this.tb_android_path.Size = new System.Drawing.Size(412, 20);
            this.tb_android_path.TabIndex = 2;
            // 
            // tb_windows_path
            // 
            this.tb_windows_path.Location = new System.Drawing.Point(32, 46);
            this.tb_windows_path.Name = "tb_windows_path";
            this.tb_windows_path.Size = new System.Drawing.Size(412, 20);
            this.tb_windows_path.TabIndex = 1;
            // 
            // l_windows_path
            // 
            this.l_windows_path.AutoSize = true;
            this.l_windows_path.Location = new System.Drawing.Point(29, 30);
            this.l_windows_path.Name = "l_windows_path";
            this.l_windows_path.Size = new System.Drawing.Size(117, 13);
            this.l_windows_path.TabIndex = 0;
            this.l_windows_path.Text = "Windows Solution Path";
            // 
            // gb_app_settings
            // 
            this.gb_app_settings.Controls.Add(this.p_color_scheme);
            this.gb_app_settings.Controls.Add(this.tb_dl_url);
            this.gb_app_settings.Controls.Add(this.l_dl_url);
            this.gb_app_settings.Controls.Add(this.l_edit_brand_list);
            this.gb_app_settings.Controls.Add(this.c_req_brand);
            this.gb_app_settings.Controls.Add(this.c_req_lock);
            this.gb_app_settings.Controls.Add(this.c_no_root);
            this.gb_app_settings.Controls.Add(this.b_app_logo);
            this.gb_app_settings.Controls.Add(this.pb_app_logo);
            this.gb_app_settings.Controls.Add(this.l_app_logo);
            this.gb_app_settings.Location = new System.Drawing.Point(8, 6);
            this.gb_app_settings.Name = "gb_app_settings";
            this.gb_app_settings.Size = new System.Drawing.Size(514, 242);
            this.gb_app_settings.TabIndex = 0;
            this.gb_app_settings.TabStop = false;
            this.gb_app_settings.Text = "Application Settings";
            // 
            // p_color_scheme
            // 
            this.p_color_scheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_color_scheme.Controls.Add(this.b_color_accent);
            this.p_color_scheme.Controls.Add(this.l_color_scheme);
            this.p_color_scheme.Controls.Add(this.p_color_primary);
            this.p_color_scheme.Controls.Add(this.p_color_primary_dark);
            this.p_color_scheme.Controls.Add(this.p_color_accent);
            this.p_color_scheme.Controls.Add(this.b_color_primary_dark);
            this.p_color_scheme.Controls.Add(this.b_color_primary);
            this.p_color_scheme.Location = new System.Drawing.Point(172, 22);
            this.p_color_scheme.Name = "p_color_scheme";
            this.p_color_scheme.Size = new System.Drawing.Size(322, 106);
            this.p_color_scheme.TabIndex = 17;
            // 
            // b_color_accent
            // 
            this.b_color_accent.Location = new System.Drawing.Point(280, 77);
            this.b_color_accent.Name = "b_color_accent";
            this.b_color_accent.Size = new System.Drawing.Size(29, 20);
            this.b_color_accent.TabIndex = 9;
            this.b_color_accent.Text = "...";
            this.b_color_accent.UseVisualStyleBackColor = true;
            this.b_color_accent.Click += new System.EventHandler(this.b_color_accent_Click);
            // 
            // l_color_scheme
            // 
            this.l_color_scheme.AutoSize = true;
            this.l_color_scheme.Location = new System.Drawing.Point(6, 3);
            this.l_color_scheme.Name = "l_color_scheme";
            this.l_color_scheme.Size = new System.Drawing.Size(118, 13);
            this.l_color_scheme.TabIndex = 3;
            this.l_color_scheme.Text = "Color Scheme (Android)";
            // 
            // p_color_primary
            // 
            this.p_color_primary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.p_color_primary.Controls.Add(this.l_color_primary);
            this.p_color_primary.Location = new System.Drawing.Point(9, 19);
            this.p_color_primary.Name = "p_color_primary";
            this.p_color_primary.Size = new System.Drawing.Size(262, 20);
            this.p_color_primary.TabIndex = 4;
            // 
            // l_color_primary
            // 
            this.l_color_primary.AutoSize = true;
            this.l_color_primary.BackColor = System.Drawing.Color.White;
            this.l_color_primary.Location = new System.Drawing.Point(111, 4);
            this.l_color_primary.Name = "l_color_primary";
            this.l_color_primary.Size = new System.Drawing.Size(41, 13);
            this.l_color_primary.TabIndex = 7;
            this.l_color_primary.Text = "Primary";
            // 
            // p_color_primary_dark
            // 
            this.p_color_primary_dark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.p_color_primary_dark.Controls.Add(this.l_color_primary_dark);
            this.p_color_primary_dark.Location = new System.Drawing.Point(9, 48);
            this.p_color_primary_dark.Name = "p_color_primary_dark";
            this.p_color_primary_dark.Size = new System.Drawing.Size(262, 20);
            this.p_color_primary_dark.TabIndex = 5;
            // 
            // l_color_primary_dark
            // 
            this.l_color_primary_dark.AutoSize = true;
            this.l_color_primary_dark.BackColor = System.Drawing.Color.White;
            this.l_color_primary_dark.Location = new System.Drawing.Point(98, 4);
            this.l_color_primary_dark.Name = "l_color_primary_dark";
            this.l_color_primary_dark.Size = new System.Drawing.Size(67, 13);
            this.l_color_primary_dark.TabIndex = 8;
            this.l_color_primary_dark.Text = "Primary Dark";
            // 
            // p_color_accent
            // 
            this.p_color_accent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(64)))));
            this.p_color_accent.Controls.Add(this.l_color_accent);
            this.p_color_accent.Location = new System.Drawing.Point(9, 77);
            this.p_color_accent.Name = "p_color_accent";
            this.p_color_accent.Size = new System.Drawing.Size(262, 20);
            this.p_color_accent.TabIndex = 6;
            // 
            // l_color_accent
            // 
            this.l_color_accent.AutoSize = true;
            this.l_color_accent.BackColor = System.Drawing.Color.White;
            this.l_color_accent.Location = new System.Drawing.Point(111, 4);
            this.l_color_accent.Name = "l_color_accent";
            this.l_color_accent.Size = new System.Drawing.Size(41, 13);
            this.l_color_accent.TabIndex = 9;
            this.l_color_accent.Text = "Accent";
            // 
            // b_color_primary_dark
            // 
            this.b_color_primary_dark.Location = new System.Drawing.Point(280, 48);
            this.b_color_primary_dark.Name = "b_color_primary_dark";
            this.b_color_primary_dark.Size = new System.Drawing.Size(29, 20);
            this.b_color_primary_dark.TabIndex = 8;
            this.b_color_primary_dark.Text = "...";
            this.b_color_primary_dark.UseVisualStyleBackColor = true;
            this.b_color_primary_dark.Click += new System.EventHandler(this.b_color_primary_dark_Click);
            // 
            // b_color_primary
            // 
            this.b_color_primary.Location = new System.Drawing.Point(280, 19);
            this.b_color_primary.Name = "b_color_primary";
            this.b_color_primary.Size = new System.Drawing.Size(29, 20);
            this.b_color_primary.TabIndex = 10;
            this.b_color_primary.Text = "...";
            this.b_color_primary.UseVisualStyleBackColor = true;
            this.b_color_primary.Click += new System.EventHandler(this.b_color_primary_Click);
            // 
            // tb_dl_url
            // 
            this.tb_dl_url.Location = new System.Drawing.Point(181, 216);
            this.tb_dl_url.Name = "tb_dl_url";
            this.tb_dl_url.Size = new System.Drawing.Size(313, 20);
            this.tb_dl_url.TabIndex = 16;
            this.tb_dl_url.Text = "http://quickconnect.example.com/files";
            // 
            // l_dl_url
            // 
            this.l_dl_url.AutoSize = true;
            this.l_dl_url.Location = new System.Drawing.Point(33, 219);
            this.l_dl_url.Name = "l_dl_url";
            this.l_dl_url.Size = new System.Drawing.Size(142, 13);
            this.l_dl_url.TabIndex = 15;
            this.l_dl_url.Text = "Download URL for Windows";
            // 
            // l_edit_brand_list
            // 
            this.l_edit_brand_list.AutoSize = true;
            this.l_edit_brand_list.Enabled = false;
            this.l_edit_brand_list.Location = new System.Drawing.Point(450, 181);
            this.l_edit_brand_list.Name = "l_edit_brand_list";
            this.l_edit_brand_list.Size = new System.Drawing.Size(44, 13);
            this.l_edit_brand_list.TabIndex = 14;
            this.l_edit_brand_list.TabStop = true;
            this.l_edit_brand_list.Text = "Edit List";
            this.l_edit_brand_list.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_edit_brand_list_LinkClicked);
            // 
            // c_req_brand
            // 
            this.c_req_brand.AutoSize = true;
            this.c_req_brand.Location = new System.Drawing.Point(181, 180);
            this.c_req_brand.Name = "c_req_brand";
            this.c_req_brand.Size = new System.Drawing.Size(263, 17);
            this.c_req_brand.TabIndex = 13;
            this.c_req_brand.Text = "Require Reputable Device Manufacturer (Android)";
            this.c_req_brand.UseVisualStyleBackColor = true;
            this.c_req_brand.CheckedChanged += new System.EventHandler(this.c_req_brand_CheckedChanged);
            // 
            // c_req_lock
            // 
            this.c_req_lock.AutoSize = true;
            this.c_req_lock.Location = new System.Drawing.Point(181, 157);
            this.c_req_lock.Name = "c_req_lock";
            this.c_req_lock.Size = new System.Drawing.Size(139, 17);
            this.c_req_lock.TabIndex = 12;
            this.c_req_lock.Text = "Require Locked Device";
            this.c_req_lock.UseVisualStyleBackColor = true;
            // 
            // c_no_root
            // 
            this.c_no_root.AutoSize = true;
            this.c_no_root.Location = new System.Drawing.Point(181, 134);
            this.c_no_root.Name = "c_no_root";
            this.c_no_root.Size = new System.Drawing.Size(190, 17);
            this.c_no_root.TabIndex = 11;
            this.c_no_root.Text = "Disallow Rooted Devices (Android)";
            this.c_no_root.UseVisualStyleBackColor = true;
            // 
            // b_app_logo
            // 
            this.b_app_logo.Location = new System.Drawing.Point(32, 144);
            this.b_app_logo.Name = "b_app_logo";
            this.b_app_logo.Size = new System.Drawing.Size(100, 23);
            this.b_app_logo.TabIndex = 2;
            this.b_app_logo.Text = "Change";
            this.b_app_logo.UseVisualStyleBackColor = true;
            // 
            // pb_app_logo
            // 
            this.pb_app_logo.BackColor = System.Drawing.Color.LightGray;
            this.pb_app_logo.Location = new System.Drawing.Point(32, 38);
            this.pb_app_logo.Name = "pb_app_logo";
            this.pb_app_logo.Size = new System.Drawing.Size(100, 100);
            this.pb_app_logo.TabIndex = 1;
            this.pb_app_logo.TabStop = false;
            // 
            // l_app_logo
            // 
            this.l_app_logo.AutoSize = true;
            this.l_app_logo.Location = new System.Drawing.Point(29, 22);
            this.l_app_logo.Name = "l_app_logo";
            this.l_app_logo.Size = new System.Drawing.Size(86, 13);
            this.l_app_logo.TabIndex = 0;
            this.l_app_logo.Text = "Application Logo";
            // 
            // tabPage_build
            // 
            this.tabPage_build.Controls.Add(this.gb_build);
            this.tabPage_build.Controls.Add(this.gb_sign);
            this.tabPage_build.Location = new System.Drawing.Point(4, 22);
            this.tabPage_build.Name = "tabPage_build";
            this.tabPage_build.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_build.Size = new System.Drawing.Size(530, 451);
            this.tabPage_build.TabIndex = 2;
            this.tabPage_build.Text = "Build";
            this.tabPage_build.UseVisualStyleBackColor = true;
            // 
            // gb_sign
            // 
            this.gb_sign.Controls.Add(this.l_signing_cert_cn);
            this.gb_sign.Controls.Add(this.c_sign_apple);
            this.gb_sign.Controls.Add(this.c_sign_windows);
            this.gb_sign.Controls.Add(this.c_sign_android);
            this.gb_sign.Controls.Add(this.l_signing_cert);
            this.gb_sign.Controls.Add(this.b_signing_cert);
            this.gb_sign.Controls.Add(this.tb_signing_cert);
            this.gb_sign.Location = new System.Drawing.Point(8, 6);
            this.gb_sign.Name = "gb_sign";
            this.gb_sign.Size = new System.Drawing.Size(514, 123);
            this.gb_sign.TabIndex = 0;
            this.gb_sign.TabStop = false;
            this.gb_sign.Text = "Signage Settings";
            // 
            // l_signing_cert_cn
            // 
            this.l_signing_cert_cn.AutoSize = true;
            this.l_signing_cert_cn.Location = new System.Drawing.Point(9, 64);
            this.l_signing_cert_cn.Name = "l_signing_cert_cn";
            this.l_signing_cert_cn.Size = new System.Drawing.Size(116, 13);
            this.l_signing_cert_cn.TabIndex = 19;
            this.l_signing_cert_cn.Text = "No Certificate Selected";
            // 
            // c_sign_apple
            // 
            this.c_sign_apple.AutoSize = true;
            this.c_sign_apple.Location = new System.Drawing.Point(312, 83);
            this.c_sign_apple.Name = "c_sign_apple";
            this.c_sign_apple.Size = new System.Drawing.Size(110, 17);
            this.c_sign_apple.TabIndex = 18;
            this.c_sign_apple.Text = "Sign Apple Config";
            this.c_sign_apple.UseVisualStyleBackColor = true;
            // 
            // c_sign_windows
            // 
            this.c_sign_windows.AutoSize = true;
            this.c_sign_windows.Location = new System.Drawing.Point(147, 83);
            this.c_sign_windows.Name = "c_sign_windows";
            this.c_sign_windows.Size = new System.Drawing.Size(136, 17);
            this.c_sign_windows.TabIndex = 17;
            this.c_sign_windows.Text = "Sign Windows Program";
            this.c_sign_windows.UseVisualStyleBackColor = true;
            // 
            // c_sign_android
            // 
            this.c_sign_android.AutoSize = true;
            this.c_sign_android.Location = new System.Drawing.Point(9, 83);
            this.c_sign_android.Name = "c_sign_android";
            this.c_sign_android.Size = new System.Drawing.Size(108, 17);
            this.c_sign_android.TabIndex = 16;
            this.c_sign_android.Text = "Sign Android App";
            this.c_sign_android.UseVisualStyleBackColor = true;
            // 
            // l_signing_cert
            // 
            this.l_signing_cert.AutoSize = true;
            this.l_signing_cert.Location = new System.Drawing.Point(6, 21);
            this.l_signing_cert.Name = "l_signing_cert";
            this.l_signing_cert.Size = new System.Drawing.Size(92, 13);
            this.l_signing_cert.TabIndex = 15;
            this.l_signing_cert.Text = "Signing Certificate";
            // 
            // b_signing_cert
            // 
            this.b_signing_cert.Location = new System.Drawing.Point(479, 37);
            this.b_signing_cert.Name = "b_signing_cert";
            this.b_signing_cert.Size = new System.Drawing.Size(29, 20);
            this.b_signing_cert.TabIndex = 14;
            this.b_signing_cert.Text = "...";
            this.b_signing_cert.UseVisualStyleBackColor = true;
            this.b_signing_cert.Click += new System.EventHandler(this.b_signing_cert_Click);
            // 
            // tb_signing_cert
            // 
            this.tb_signing_cert.Location = new System.Drawing.Point(6, 37);
            this.tb_signing_cert.Name = "tb_signing_cert";
            this.tb_signing_cert.Size = new System.Drawing.Size(467, 20);
            this.tb_signing_cert.TabIndex = 0;
            // 
            // tt_cacert
            // 
            this.tt_cacert.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_cacert.ToolTipTitle = "CA Certificate";
            // 
            // ofd_cacert
            // 
            this.ofd_cacert.Filter = "Certificate File|*.p12;*.p7;*.crt;*.pem;*.cert;*.der";
            this.ofd_cacert.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_cacert_FileOk);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // fbd_android
            // 
            this.fbd_android.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ofd_windows
            // 
            this.ofd_windows.Filter = "Solution File|*.sln";
            // 
            // fbd_webpage
            // 
            this.fbd_webpage.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ofd_siging_cert
            // 
            this.ofd_siging_cert.Filter = "Certificate File|*.p12;*.p7;*.crt;*.pem;*.cert;*.der";
            this.ofd_siging_cert.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_siging_cert_FileOk);
            // 
            // gb_build
            // 
            this.gb_build.Controls.Add(this.b_build);
            this.gb_build.Controls.Add(this.tb_build);
            this.gb_build.Location = new System.Drawing.Point(8, 135);
            this.gb_build.Name = "gb_build";
            this.gb_build.Size = new System.Drawing.Size(514, 308);
            this.gb_build.TabIndex = 1;
            this.gb_build.TabStop = false;
            this.gb_build.Text = "Build";
            // 
            // tb_build
            // 
            this.tb_build.Location = new System.Drawing.Point(6, 19);
            this.tb_build.Multiline = true;
            this.tb_build.Name = "tb_build";
            this.tb_build.ReadOnly = true;
            this.tb_build.Size = new System.Drawing.Size(502, 246);
            this.tb_build.TabIndex = 0;
            // 
            // b_build
            // 
            this.b_build.Location = new System.Drawing.Point(6, 279);
            this.b_build.Name = "b_build";
            this.b_build.Size = new System.Drawing.Size(502, 23);
            this.b_build.TabIndex = 1;
            this.b_build.Text = "Build";
            this.b_build.UseVisualStyleBackColor = true;
            this.b_build.Click += new System.EventHandler(this.b_build_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 477);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "WifiCAT Building Tool";
            this.tabControl.ResumeLayout(false);
            this.tabPage_wifi.ResumeLayout(false);
            this.gb_enterprise.ResumeLayout(false);
            this.gb_enterprise.PerformLayout();
            this.gb_wificonfig.ResumeLayout(false);
            this.gb_wificonfig.PerformLayout();
            this.tabPage_applications.ResumeLayout(false);
            this.gb_application_path.ResumeLayout(false);
            this.gb_application_path.PerformLayout();
            this.gb_app_settings.ResumeLayout(false);
            this.gb_app_settings.PerformLayout();
            this.p_color_scheme.ResumeLayout(false);
            this.p_color_scheme.PerformLayout();
            this.p_color_primary.ResumeLayout(false);
            this.p_color_primary.PerformLayout();
            this.p_color_primary_dark.ResumeLayout(false);
            this.p_color_primary_dark.PerformLayout();
            this.p_color_accent.ResumeLayout(false);
            this.p_color_accent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_app_logo)).EndInit();
            this.tabPage_build.ResumeLayout(false);
            this.gb_sign.ResumeLayout(false);
            this.gb_sign.PerformLayout();
            this.gb_build.ResumeLayout(false);
            this.gb_build.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_wifi;
        private System.Windows.Forms.GroupBox gb_enterprise;
        private System.Windows.Forms.GroupBox gb_wificonfig;
        private System.Windows.Forms.ComboBox cb_group;
        private System.Windows.Forms.ComboBox cb_pairwise;
        private System.Windows.Forms.Label l_pairwise;
        private System.Windows.Forms.Label l_ssid;
        private System.Windows.Forms.TextBox tb_ssid;
        private System.Windows.Forms.TabPage tabPage_applications;
        private System.Windows.Forms.Label l_outer_id;
        private System.Windows.Forms.Label l_subj_alt_match;
        private System.Windows.Forms.Label l_dns_suffix;
        private System.Windows.Forms.TextBox tb_dns_suffix;
        private System.Windows.Forms.Label l_cacert;
        private System.Windows.Forms.Button b_cacert;
        private System.Windows.Forms.TextBox tb_cacert;
        private System.Windows.Forms.Label l_eapmethod;
        private System.Windows.Forms.ComboBox cb_eapmethod;
        private System.Windows.Forms.Label l_protocol;
        private System.Windows.Forms.ComboBox cb_protocol;
        private System.Windows.Forms.Label l_group;
        private System.Windows.Forms.ToolTip tt_cacert;
        private System.Windows.Forms.OpenFileDialog ofd_cacert;
        private System.Windows.Forms.ComboBox cb_phase2;
        private System.Windows.Forms.CheckBox c_client_cert;
        private System.Windows.Forms.Label l_phase2;
        private System.Windows.Forms.Label l_client_cert;
        private System.Windows.Forms.TextBox tb_outer_id;
        private System.Windows.Forms.TextBox tb_subj_alt_match;
        private System.Windows.Forms.GroupBox gb_application_path;
        private System.Windows.Forms.GroupBox gb_app_settings;
        private System.Windows.Forms.LinkLabel l_edit_brand_list;
        private System.Windows.Forms.CheckBox c_req_brand;
        private System.Windows.Forms.CheckBox c_req_lock;
        private System.Windows.Forms.CheckBox c_no_root;
        private System.Windows.Forms.Button b_color_primary;
        private System.Windows.Forms.Button b_color_accent;
        private System.Windows.Forms.Button b_color_primary_dark;
        private System.Windows.Forms.Panel p_color_accent;
        private System.Windows.Forms.Label l_color_accent;
        private System.Windows.Forms.Panel p_color_primary_dark;
        private System.Windows.Forms.Label l_color_primary_dark;
        private System.Windows.Forms.Panel p_color_primary;
        private System.Windows.Forms.Label l_color_primary;
        private System.Windows.Forms.Label l_color_scheme;
        private System.Windows.Forms.Button b_app_logo;
        private System.Windows.Forms.PictureBox pb_app_logo;
        private System.Windows.Forms.Label l_app_logo;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel p_color_scheme;
        private System.Windows.Forms.TextBox tb_dl_url;
        private System.Windows.Forms.Label l_dl_url;
        private System.Windows.Forms.FolderBrowserDialog fbd_android;
        private System.Windows.Forms.OpenFileDialog ofd_windows;
        private System.Windows.Forms.Label l_ssid_del;
        private System.Windows.Forms.TextBox tb_ssid_del;
        private System.Windows.Forms.Label l_windows_path;
        private System.Windows.Forms.Button b_web_path;
        private System.Windows.Forms.Button b_android_path;
        private System.Windows.Forms.Button b_windows_path;
        private System.Windows.Forms.Label l_web_path;
        private System.Windows.Forms.Label l_android_path;
        private System.Windows.Forms.TextBox tb_web_path;
        private System.Windows.Forms.TextBox tb_android_path;
        private System.Windows.Forms.TextBox tb_windows_path;
        private System.Windows.Forms.FolderBrowserDialog fbd_webpage;
        private System.Windows.Forms.TabPage tabPage_build;
        private System.Windows.Forms.GroupBox gb_sign;
        private System.Windows.Forms.TextBox tb_signing_cert;
        private System.Windows.Forms.Label l_signing_cert;
        private System.Windows.Forms.Button b_signing_cert;
        private System.Windows.Forms.Label l_signing_cert_cn;
        private System.Windows.Forms.CheckBox c_sign_apple;
        private System.Windows.Forms.CheckBox c_sign_windows;
        private System.Windows.Forms.CheckBox c_sign_android;
        private System.Windows.Forms.OpenFileDialog ofd_siging_cert;
        private System.Windows.Forms.GroupBox gb_build;
        private System.Windows.Forms.Button b_build;
        private System.Windows.Forms.TextBox tb_build;
    }
}

