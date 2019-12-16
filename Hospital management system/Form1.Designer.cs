namespace Hospital_management_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slideinpanel = new System.Windows.Forms.Panel();
            this.btnslideout = new System.Windows.Forms.Button();
            this.btnslidein = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnchanneldoc = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnpatientreg = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homereceptionist1 = new Hospital_management_system.Homereceptionist();
            this.channeldoctorRes1 = new Hospital_management_system.channeldoctorRes();
            this.patientregistration2 = new Hospital_management_system.patientregistration();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.patientregistration1 = new Hospital_management_system.patientregistration();
            this.patientdetails_reg1 = new Hospital_management_system.patientdetails_reg();
            this.slideinpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slideinpanel
            // 
            this.slideinpanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.slideinpanel.Controls.Add(this.btnslideout);
            this.slideinpanel.Controls.Add(this.btnslidein);
            this.slideinpanel.Controls.Add(this.btnlogout);
            this.slideinpanel.Controls.Add(this.button2);
            this.slideinpanel.Controls.Add(this.button1);
            this.slideinpanel.Controls.Add(this.btnchanneldoc);
            this.slideinpanel.Controls.Add(this.btnhome);
            this.slideinpanel.Controls.Add(this.btnpatientreg);
            this.slideinpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slideinpanel.Location = new System.Drawing.Point(0, 0);
            this.slideinpanel.Name = "slideinpanel";
            this.slideinpanel.Size = new System.Drawing.Size(240, 687);
            this.slideinpanel.TabIndex = 0;
            this.slideinpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.slideinpanel_Paint);
            // 
            // btnslideout
            // 
            this.btnslideout.BackColor = System.Drawing.Color.Transparent;
            this.btnslideout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnslideout.BackgroundImage")));
            this.btnslideout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnslideout.FlatAppearance.BorderSize = 0;
            this.btnslideout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnslideout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnslideout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnslideout.Location = new System.Drawing.Point(202, 11);
            this.btnslideout.Name = "btnslideout";
            this.btnslideout.Size = new System.Drawing.Size(39, 36);
            this.btnslideout.TabIndex = 0;
            this.btnslideout.UseVisualStyleBackColor = false;
            this.btnslideout.Click += new System.EventHandler(this.btnslideout_Click);
            // 
            // btnslidein
            // 
            this.btnslidein.BackColor = System.Drawing.Color.Transparent;
            this.btnslidein.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnslidein.BackgroundImage")));
            this.btnslidein.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnslidein.FlatAppearance.BorderSize = 0;
            this.btnslidein.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnslidein.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnslidein.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnslidein.Location = new System.Drawing.Point(7, 12);
            this.btnslidein.Name = "btnslidein";
            this.btnslidein.Size = new System.Drawing.Size(39, 36);
            this.btnslidein.TabIndex = 0;
            this.btnslidein.UseVisualStyleBackColor = false;
            this.btnslidein.Click += new System.EventHandler(this.btnslidein_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(0, 376);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(240, 50);
            this.btnlogout.TabIndex = 0;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Logging Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Patient Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnchanneldoc
            // 
            this.btnchanneldoc.BackColor = System.Drawing.Color.Transparent;
            this.btnchanneldoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnchanneldoc.FlatAppearance.BorderSize = 0;
            this.btnchanneldoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnchanneldoc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnchanneldoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchanneldoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchanneldoc.Location = new System.Drawing.Point(1, 203);
            this.btnchanneldoc.Name = "btnchanneldoc";
            this.btnchanneldoc.Size = new System.Drawing.Size(239, 50);
            this.btnchanneldoc.TabIndex = 0;
            this.btnchanneldoc.Text = "Channel Doctor";
            this.btnchanneldoc.UseVisualStyleBackColor = false;
            this.btnchanneldoc.Click += new System.EventHandler(this.btnchanneldoc_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(0, 108);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(240, 50);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "HOME";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnpatientreg
            // 
            this.btnpatientreg.BackColor = System.Drawing.Color.Transparent;
            this.btnpatientreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnpatientreg.FlatAppearance.BorderSize = 0;
            this.btnpatientreg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpatientreg.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnpatientreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpatientreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpatientreg.Location = new System.Drawing.Point(5, 153);
            this.btnpatientreg.Name = "btnpatientreg";
            this.btnpatientreg.Size = new System.Drawing.Size(236, 50);
            this.btnpatientreg.TabIndex = 0;
            this.btnpatientreg.Text = " Patient Registration";
            this.btnpatientreg.UseVisualStyleBackColor = false;
            this.btnpatientreg.Click += new System.EventHandler(this.btnpatientreg_Click);
            // 
            // toppanel
            // 
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(240, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1006, 23);
            this.toppanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homereceptionist1);
            this.panel1.Controls.Add(this.channeldoctorRes1);
            this.panel1.Controls.Add(this.patientregistration2);
            this.panel1.Controls.Add(this.patientdetails_reg1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(240, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 664);
            this.panel1.TabIndex = 3;
            // 
            // homereceptionist1
            // 
            this.homereceptionist1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homereceptionist1.Location = new System.Drawing.Point(0, 0);
            this.homereceptionist1.Name = "homereceptionist1";
            this.homereceptionist1.Size = new System.Drawing.Size(1003, 627);
            this.homereceptionist1.TabIndex = 3;
            this.homereceptionist1.Load += new System.EventHandler(this.homereceptionist1_Load_1);
            // 
            // channeldoctorRes1
            // 
            this.channeldoctorRes1.AutoScroll = true;
            this.channeldoctorRes1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.channeldoctorRes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channeldoctorRes1.Location = new System.Drawing.Point(0, 0);
            this.channeldoctorRes1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.channeldoctorRes1.Name = "channeldoctorRes1";
            this.channeldoctorRes1.Size = new System.Drawing.Size(1103, 681);
            this.channeldoctorRes1.TabIndex = 2;
            // 
            // patientregistration2
            // 
            this.patientregistration2.AutoScroll = true;
            this.patientregistration2.AutoSize = true;
            this.patientregistration2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientregistration2.Location = new System.Drawing.Point(0, 0);
            this.patientregistration2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientregistration2.Name = "patientregistration2";
            this.patientregistration2.Size = new System.Drawing.Size(985, 683);
            this.patientregistration2.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // patientregistration1
            // 
            this.patientregistration1.AutoScroll = true;
            this.patientregistration1.AutoSize = true;
            this.patientregistration1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientregistration1.Location = new System.Drawing.Point(-1, 0);
            this.patientregistration1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientregistration1.Name = "patientregistration1";
            this.patientregistration1.Size = new System.Drawing.Size(1111, 690);
            this.patientregistration1.TabIndex = 1;
            // 
            // patientdetails_reg1
            // 
            this.patientdetails_reg1.Location = new System.Drawing.Point(0, 0);
            this.patientdetails_reg1.Name = "patientdetails_reg1";
            this.patientdetails_reg1.Size = new System.Drawing.Size(1003, 661);
            this.patientdetails_reg1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1246, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.slideinpanel);
            this.MaximumSize = new System.Drawing.Size(1262, 768);
            this.MinimumSize = new System.Drawing.Size(1262, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.slideinpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel slideinpanel;
        private System.Windows.Forms.Button btnslidein;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button btnslideout;
        private System.Windows.Forms.Button btnpatientreg;
        private System.Windows.Forms.Button btnchanneldoc;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private patientregistration patientregistration1;
        private channeldoctorRes channeldoctorRes1;
        private Homereceptionist homereceptionist1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private patientregistration patientregistration2;
       private adminpanelthing.patientdetails patientdetails1;
        private System.Windows.Forms.Button btnlogout;
        private patientdetails_reg patientdetails_reg1;
    }
}

