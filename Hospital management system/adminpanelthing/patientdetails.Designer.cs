namespace Hospital_management_system.adminpanelthing
{
    partial class patientdetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgwpatientinfo = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.rbfn = new System.Windows.Forms.RadioButton();
            this.rbln = new System.Windows.Forms.RadioButton();
            this.rbnid = new System.Windows.Forms.RadioButton();
            this.rbphoneno = new System.Windows.Forms.RadioButton();
            this.rbpid = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwpatientinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwpatientinfo
            // 
            this.dgwpatientinfo.AllowUserToAddRows = false;
            this.dgwpatientinfo.AllowUserToDeleteRows = false;
            this.dgwpatientinfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwpatientinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwpatientinfo.Location = new System.Drawing.Point(60, 271);
            this.dgwpatientinfo.Name = "dgwpatientinfo";
            this.dgwpatientinfo.ReadOnly = true;
            this.dgwpatientinfo.Size = new System.Drawing.Size(676, 131);
            this.dgwpatientinfo.TabIndex = 0;
            this.dgwpatientinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwpatientinfo_CellClick);
            this.dgwpatientinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwpatientinfo_CellContentClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(82, 41);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(443, 27);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtfname_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(199, 142);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(181, 29);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // rbfn
            // 
            this.rbfn.AutoSize = true;
            this.rbfn.Location = new System.Drawing.Point(84, 83);
            this.rbfn.Name = "rbfn";
            this.rbfn.Size = new System.Drawing.Size(97, 23);
            this.rbfn.TabIndex = 3;
            this.rbfn.TabStop = true;
            this.rbfn.Text = "First Name";
            this.rbfn.UseVisualStyleBackColor = true;
            // 
            // rbln
            // 
            this.rbln.AutoSize = true;
            this.rbln.Location = new System.Drawing.Point(187, 83);
            this.rbln.Name = "rbln";
            this.rbln.Size = new System.Drawing.Size(96, 23);
            this.rbln.TabIndex = 4;
            this.rbln.TabStop = true;
            this.rbln.Text = "Last Name";
            this.rbln.UseVisualStyleBackColor = true;
            // 
            // rbnid
            // 
            this.rbnid.AutoSize = true;
            this.rbnid.Location = new System.Drawing.Point(386, 83);
            this.rbnid.Name = "rbnid";
            this.rbnid.Size = new System.Drawing.Size(51, 23);
            this.rbnid.TabIndex = 4;
            this.rbnid.TabStop = true;
            this.rbnid.Text = "NID";
            this.rbnid.UseVisualStyleBackColor = true;
            // 
            // rbphoneno
            // 
            this.rbphoneno.AutoSize = true;
            this.rbphoneno.Location = new System.Drawing.Point(443, 83);
            this.rbphoneno.Name = "rbphoneno";
            this.rbphoneno.Size = new System.Drawing.Size(94, 23);
            this.rbphoneno.TabIndex = 4;
            this.rbphoneno.TabStop = true;
            this.rbphoneno.Text = "Mobile No";
            this.rbphoneno.UseVisualStyleBackColor = true;
            // 
            // rbpid
            // 
            this.rbpid.AutoSize = true;
            this.rbpid.Location = new System.Drawing.Point(289, 83);
            this.rbpid.Name = "rbpid";
            this.rbpid.Size = new System.Drawing.Size(91, 23);
            this.rbpid.TabIndex = 5;
            this.rbpid.TabStop = true;
            this.rbpid.Text = "Patient ID";
            this.rbpid.UseVisualStyleBackColor = true;
            // 
            // patientdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.rbpid);
            this.Controls.Add(this.rbphoneno);
            this.Controls.Add(this.rbnid);
            this.Controls.Add(this.rbln);
            this.Controls.Add(this.rbfn);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgwpatientinfo);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "patientdetails";
            this.Size = new System.Drawing.Size(789, 512);
            this.Load += new System.EventHandler(this.patientdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwpatientinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwpatientinfo;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.RadioButton rbfn;
        private System.Windows.Forms.RadioButton rbln;
        private System.Windows.Forms.RadioButton rbnid;
        private System.Windows.Forms.RadioButton rbphoneno;
        private System.Windows.Forms.RadioButton rbpid;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
