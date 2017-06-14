namespace WifiCatBuilder
{
    partial class BrandList
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
            this.lb_brands = new System.Windows.Forms.ListBox();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_clear = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_brands
            // 
            this.lb_brands.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_brands.FormattingEnabled = true;
            this.lb_brands.Items.AddRange(new object[] {
            "Acer",
            "Asus",
            "AT&T",
            "Audi AG",
            "Bang & Olufsen",
            "BenQ",
            "Best Buy",
            "Bigben",
            "BlackBerry",
            "Blaupunkt",
            "British Telecom",
            "Casio",
            "Cherry Mobile",
            "Cisco",
            "Dell",
            "Fairphone",
            "Fujitsu",
            "Garmin",
            "Gigabyte",
            "Gigaset",
            "Google",
            "Honda",
            "HP",
            "HTC",
            "Huawei",
            "Intel",
            "Kodak",
            "Lenovo",
            "LGE",
            "Logitech",
            "Medion",
            "Motorola",
            "Motorola Solutions",
            "MotorolaSolutionsInc.",
            "MSI",
            "NEC",
            "Nextbit",
            "Nikon",
            "Nokia",
            "NVidia",
            "NVIDIA",
            "Odys",
            "OnePlus",
            "Oppo",
            "Orange",
            "Panasonic",
            "Philips",
            "Pioneer",
            "Razer",
            "Samsung",
            "Sharp",
            "Sony",
            "Sony Ericsson",
            "Sprint",
            "T-Mobile",
            "Technicolor",
            "Thomson",
            "Toshiba",
            "Trekstor",
            "VAIO",
            "Vestel",
            "ViewSonic",
            "Vivo",
            "Vodafone",
            "WACOM",
            "Wiko",
            "Xiaomi",
            "YotaPhone",
            "ZTE"});
            this.lb_brands.Location = new System.Drawing.Point(0, 0);
            this.lb_brands.Name = "lb_brands";
            this.lb_brands.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_brands.Size = new System.Drawing.Size(520, 529);
            this.lb_brands.Sorted = true;
            this.lb_brands.TabIndex = 0;
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(529, 12);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(121, 23);
            this.b_delete.TabIndex = 1;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_clear
            // 
            this.b_clear.Location = new System.Drawing.Point(529, 41);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(121, 23);
            this.b_clear.TabIndex = 3;
            this.b_clear.Text = "Clear";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(529, 107);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(121, 23);
            this.b_add.TabIndex = 5;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_close
            // 
            this.b_close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_close.Location = new System.Drawing.Point(529, 494);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(121, 23);
            this.b_close.TabIndex = 6;
            this.b_close.Text = "Save and Close";
            this.b_close.UseVisualStyleBackColor = true;
            // 
            // BrandList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 529);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.lb_brands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrandList";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lb_brands;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_close;
    }
}