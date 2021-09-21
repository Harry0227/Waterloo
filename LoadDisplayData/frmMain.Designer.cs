
namespace LoadDisplayData
{
    partial class frmMain
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
            this.gbDisplayData = new System.Windows.Forms.GroupBox();
            this.btnRowColumnSwitch = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.dgvLoadCSVFile = new System.Windows.Forms.DataGridView();
            this.cmdCSVFile = new System.Windows.Forms.Button();
            this.txtDataCSVFile = new System.Windows.Forms.TextBox();
            this.lblDataCSV = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboIDName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComboCsvFile = new System.Windows.Forms.Button();
            this.txtComboCsvFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowSelectedId = new System.Windows.Forms.Button();
            this.gbDisplayData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadCSVFile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDisplayData
            // 
            this.gbDisplayData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDisplayData.Controls.Add(this.btnRowColumnSwitch);
            this.gbDisplayData.Controls.Add(this.btnReplace);
            this.gbDisplayData.Controls.Add(this.dgvLoadCSVFile);
            this.gbDisplayData.Controls.Add(this.cmdCSVFile);
            this.gbDisplayData.Controls.Add(this.txtDataCSVFile);
            this.gbDisplayData.Controls.Add(this.lblDataCSV);
            this.gbDisplayData.Location = new System.Drawing.Point(12, 21);
            this.gbDisplayData.Name = "gbDisplayData";
            this.gbDisplayData.Size = new System.Drawing.Size(746, 280);
            this.gbDisplayData.TabIndex = 110;
            this.gbDisplayData.TabStop = false;
            this.gbDisplayData.Text = "Display Data CSV File";
            // 
            // btnRowColumnSwitch
            // 
            this.btnRowColumnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRowColumnSwitch.Location = new System.Drawing.Point(638, 98);
            this.btnRowColumnSwitch.Name = "btnRowColumnSwitch";
            this.btnRowColumnSwitch.Size = new System.Drawing.Size(102, 57);
            this.btnRowColumnSwitch.TabIndex = 118;
            this.btnRowColumnSwitch.Text = "Full Column Select";
            this.btnRowColumnSwitch.UseVisualStyleBackColor = true;
            this.btnRowColumnSwitch.Click += new System.EventHandler(this.btnRowColumnSwitch_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace.Location = new System.Drawing.Point(638, 204);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(100, 67);
            this.btnReplace.TabIndex = 117;
            this.btnReplace.Text = "Replace \'a\' with @ for the selected grid column";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // dgvLoadCSVFile
            // 
            this.dgvLoadCSVFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoadCSVFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadCSVFile.Location = new System.Drawing.Point(16, 67);
            this.dgvLoadCSVFile.Name = "dgvLoadCSVFile";
            this.dgvLoadCSVFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoadCSVFile.Size = new System.Drawing.Size(594, 198);
            this.dgvLoadCSVFile.TabIndex = 116;
            // 
            // cmdCSVFile
            // 
            this.cmdCSVFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCSVFile.Location = new System.Drawing.Point(638, 25);
            this.cmdCSVFile.Name = "cmdCSVFile";
            this.cmdCSVFile.Size = new System.Drawing.Size(100, 38);
            this.cmdCSVFile.TabIndex = 115;
            this.cmdCSVFile.Text = "Browse/Load to Data Grid";
            this.cmdCSVFile.UseVisualStyleBackColor = true;
            this.cmdCSVFile.Click += new System.EventHandler(this.cmdCSVFile_Click);
            // 
            // txtDataCSVFile
            // 
            this.txtDataCSVFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataCSVFile.BackColor = System.Drawing.Color.LightYellow;
            this.txtDataCSVFile.Location = new System.Drawing.Point(156, 31);
            this.txtDataCSVFile.Name = "txtDataCSVFile";
            this.txtDataCSVFile.Size = new System.Drawing.Size(454, 20);
            this.txtDataCSVFile.TabIndex = 3;
            // 
            // lblDataCSV
            // 
            this.lblDataCSV.AutoSize = true;
            this.lblDataCSV.Location = new System.Drawing.Point(13, 31);
            this.lblDataCSV.Name = "lblDataCSV";
            this.lblDataCSV.Size = new System.Drawing.Size(76, 13);
            this.lblDataCSV.TabIndex = 2;
            this.lblDataCSV.Text = "Data CSV File:";
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(683, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 111;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboIDName
            // 
            this.cboIDName.FormattingEnabled = true;
            this.cboIDName.Location = new System.Drawing.Point(16, 19);
            this.cboIDName.Name = "cboIDName";
            this.cboIDName.Size = new System.Drawing.Size(126, 21);
            this.cboIDName.TabIndex = 112;
            this.cboIDName.SelectedIndexChanged += new System.EventHandler(this.cboIDName_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnComboCsvFile);
            this.groupBox1.Controls.Add(this.txtComboCsvFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnShowSelectedId);
            this.groupBox1.Controls.Add(this.cboIDName);
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 96);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Combobox";
            // 
            // btnComboCsvFile
            // 
            this.btnComboCsvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComboCsvFile.Location = new System.Drawing.Point(638, 20);
            this.btnComboCsvFile.Name = "btnComboCsvFile";
            this.btnComboCsvFile.Size = new System.Drawing.Size(100, 52);
            this.btnComboCsvFile.TabIndex = 118;
            this.btnComboCsvFile.Text = "Browse/Load to ComboBox";
            this.btnComboCsvFile.UseVisualStyleBackColor = true;
            this.btnComboCsvFile.Click += new System.EventHandler(this.btnComboCsvFile_Click);
            // 
            // txtComboCsvFile
            // 
            this.txtComboCsvFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComboCsvFile.BackColor = System.Drawing.Color.LightYellow;
            this.txtComboCsvFile.Location = new System.Drawing.Point(311, 20);
            this.txtComboCsvFile.Name = "txtComboCsvFile";
            this.txtComboCsvFile.Size = new System.Drawing.Size(299, 20);
            this.txtComboCsvFile.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "ComboBox CSV File:";
            // 
            // btnShowSelectedId
            // 
            this.btnShowSelectedId.Location = new System.Drawing.Point(16, 57);
            this.btnShowSelectedId.Name = "btnShowSelectedId";
            this.btnShowSelectedId.Size = new System.Drawing.Size(112, 33);
            this.btnShowSelectedId.TabIndex = 113;
            this.btnShowSelectedId.Text = "Show Selected Id";
            this.btnShowSelectedId.UseVisualStyleBackColor = true;
            this.btnShowSelectedId.Click += new System.EventHandler(this.btnShowSelectedId_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbDisplayData);
            this.Name = "frmMain";
            this.Text = "Load and Display CSV Data";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbDisplayData.ResumeLayout(false);
            this.gbDisplayData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadCSVFile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbDisplayData;
        internal System.Windows.Forms.Button cmdCSVFile;
        private System.Windows.Forms.TextBox txtDataCSVFile;
        private System.Windows.Forms.Label lblDataCSV;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboIDName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowSelectedId;
        private System.Windows.Forms.DataGridView dgvLoadCSVFile;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnRowColumnSwitch;
        internal System.Windows.Forms.Button btnComboCsvFile;
        private System.Windows.Forms.TextBox txtComboCsvFile;
        private System.Windows.Forms.Label label1;
    }
}

