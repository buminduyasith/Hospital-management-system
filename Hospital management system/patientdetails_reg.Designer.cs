namespace Hospital_management_system
{
    partial class patientdetails_reg
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgwpatientinfo = new System.Windows.Forms.DataGridView();
            this.rbpid = new System.Windows.Forms.RadioButton();
            this.rbphoneno = new System.Windows.Forms.RadioButton();
            this.rbnid = new System.Windows.Forms.RadioButton();
            this.rbln = new System.Windows.Forms.RadioButton();
            this.rbfn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwpatientinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(159, 110);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(181, 29);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(42, 9);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(443, 20);
            this.txtsearch.TabIndex = 6;
            // 
            // dgwpatientinfo
            // 
            this.dgwpatientinfo.AllowUserToAddRows = false;
            this.dgwpatientinfo.AllowUserToDeleteRows = false;
            this.dgwpatientinfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwpatientinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwpatientinfo.Location = new System.Drawing.Point(20, 239);
            this.dgwpatientinfo.Name = "dgwpatientinfo";
            this.dgwpatientinfo.ReadOnly = true;
            this.dgwpatientinfo.Size = new System.Drawing.Size(676, 131);
            this.dgwpatientinfo.TabIndex = 5;
            // 
            // rbpid
            // 
            this.rbpid.AutoSize = true;
            this.rbpid.Location = new System.Drawing.Point(247, 48);
            this.rbpid.Name = "rbpid";
            this.rbpid.Size = new System.Drawing.Size(72, 17);
            this.rbpid.TabIndex = 12;
            this.rbpid.TabStop = true;
            this.rbpid.Text = "Patient ID";
            this.rbpid.UseVisualStyleBackColor = true;
            // 
            // rbphoneno
            // 
            this.rbphoneno.AutoSize = true;
            this.rbphoneno.Location = new System.Drawing.Point(401, 48);
            this.rbphoneno.Name = "rbphoneno";
            this.rbphoneno.Size = new System.Drawing.Size(73, 17);
            this.rbphoneno.TabIndex = 9;
            this.rbphoneno.TabStop = true;
            this.rbphoneno.Text = "Mobile No";
            this.rbphoneno.UseVisualStyleBackColor = true;
            // 
            // rbnid
            // 
            this.rbnid.AutoSize = true;
            this.rbnid.Location = new System.Drawing.Point(344, 48);
            this.rbnid.Name = "rbnid";
            this.rbnid.Size = new System.Drawing.Size(44, 17);
            this.rbnid.TabIndex = 10;
            this.rbnid.TabStop = true;
            this.rbnid.Text = "NID";
            this.rbnid.UseVisualStyleBackColor = true;
            // 
            // rbln
            // 
            this.rbln.AutoSize = true;
            this.rbln.Location = new System.Drawing.Point(145, 48);
            this.rbln.Name = "rbln";
            this.rbln.Size = new System.Drawing.Size(76, 17);
            this.rbln.TabIndex = 11;
            this.rbln.TabStop = true;
            this.rbln.Text = "Last Name";
            this.rbln.UseVisualStyleBackColor = true;
            // 
            // rbfn
            // 
            this.rbfn.AutoSize = true;
            this.rbfn.Location = new System.Drawing.Point(42, 48);
            this.rbfn.Name = "rbfn";
            this.rbfn.Size = new System.Drawing.Size(75, 17);
            this.rbfn.TabIndex = 8;
            this.rbfn.TabStop = true;
            this.rbfn.Text = "First Name";
            this.rbfn.UseVisualStyleBackColor = true;
            // 
            // patientdetails_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbpid);
            this.Controls.Add(this.rbphoneno);
            this.Controls.Add(this.rbnid);
            this.Controls.Add(this.rbln);
            this.Controls.Add(this.rbfn);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgwpatientinfo);
            this.Name = "patientdetails_reg";
            this.Size = new System.Drawing.Size(717, 379);
            this.Load += new System.EventHandler(this.patientdetails_reg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwpatientinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgwpatientinfo;
        private System.Windows.Forms.RadioButton rbpid;
        private System.Windows.Forms.RadioButton rbphoneno;
        private System.Windows.Forms.RadioButton rbnid;
        private System.Windows.Forms.RadioButton rbln;
        private System.Windows.Forms.RadioButton rbfn;
    }
}
