namespace Hospital_management_system.doctorpanel
{
    partial class patientrecfordoctor
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
            this.rbpid = new System.Windows.Forms.RadioButton();
            this.rbln = new System.Windows.Forms.RadioButton();
            this.rbfn = new System.Windows.Forms.RadioButton();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgwpatientinfo = new System.Windows.Forms.DataGridView();
            this.rbphoneno = new System.Windows.Forms.RadioButton();
            this.rbnid = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwpatientinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // rbpid
            // 
            this.rbpid.AutoSize = true;
            this.rbpid.Location = new System.Drawing.Point(291, 87);
            this.rbpid.Name = "rbpid";
            this.rbpid.Size = new System.Drawing.Size(72, 17);
            this.rbpid.TabIndex = 11;
            this.rbpid.TabStop = true;
            this.rbpid.Text = "Patient ID";
            this.rbpid.UseVisualStyleBackColor = true;
            // 
            // rbln
            // 
            this.rbln.AutoSize = true;
            this.rbln.Location = new System.Drawing.Point(189, 87);
            this.rbln.Name = "rbln";
            this.rbln.Size = new System.Drawing.Size(76, 17);
            this.rbln.TabIndex = 10;
            this.rbln.TabStop = true;
            this.rbln.Text = "Last Name";
            this.rbln.UseVisualStyleBackColor = true;
            // 
            // rbfn
            // 
            this.rbfn.AutoSize = true;
            this.rbfn.Location = new System.Drawing.Point(86, 87);
            this.rbfn.Name = "rbfn";
            this.rbfn.Size = new System.Drawing.Size(75, 17);
            this.rbfn.TabIndex = 9;
            this.rbfn.TabStop = true;
            this.rbfn.Text = "First Name";
            this.rbfn.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(201, 146);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(181, 29);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(84, 45);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(443, 20);
            this.txtsearch.TabIndex = 7;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dgwpatientinfo
            // 
            this.dgwpatientinfo.AllowUserToAddRows = false;
            this.dgwpatientinfo.AllowUserToDeleteRows = false;
            this.dgwpatientinfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwpatientinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwpatientinfo.Location = new System.Drawing.Point(62, 275);
            this.dgwpatientinfo.Name = "dgwpatientinfo";
            this.dgwpatientinfo.ReadOnly = true;
            this.dgwpatientinfo.Size = new System.Drawing.Size(676, 131);
            this.dgwpatientinfo.TabIndex = 6;
            // 
            // rbphoneno
            // 
            this.rbphoneno.AutoSize = true;
            this.rbphoneno.Location = new System.Drawing.Point(428, 87);
            this.rbphoneno.Name = "rbphoneno";
            this.rbphoneno.Size = new System.Drawing.Size(73, 17);
            this.rbphoneno.TabIndex = 12;
            this.rbphoneno.TabStop = true;
            this.rbphoneno.Text = "Mobile No";
            this.rbphoneno.UseVisualStyleBackColor = true;
            // 
            // rbnid
            // 
            this.rbnid.AutoSize = true;
            this.rbnid.Location = new System.Drawing.Point(371, 87);
            this.rbnid.Name = "rbnid";
            this.rbnid.Size = new System.Drawing.Size(44, 17);
            this.rbnid.TabIndex = 13;
            this.rbnid.TabStop = true;
            this.rbnid.Text = "NID";
            this.rbnid.UseVisualStyleBackColor = true;
            // 
            // patientrecfordoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbphoneno);
            this.Controls.Add(this.rbnid);
            this.Controls.Add(this.rbpid);
            this.Controls.Add(this.rbln);
            this.Controls.Add(this.rbfn);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgwpatientinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "patientrecfordoctor";
            this.Text = "patientrecfordoctor";
            this.Load += new System.EventHandler(this.patientrecfordoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwpatientinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbpid;
        private System.Windows.Forms.RadioButton rbln;
        private System.Windows.Forms.RadioButton rbfn;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgwpatientinfo;
        private System.Windows.Forms.RadioButton rbphoneno;
        private System.Windows.Forms.RadioButton rbnid;
    }
}