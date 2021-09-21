
namespace LoadDisplayData
{
    partial class frmEntry
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
            this.bntOkButton = new System.Windows.Forms.Button();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntOkButton
            // 
            this.bntOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntOkButton.Location = new System.Drawing.Point(49, 115);
            this.bntOkButton.Name = "bntOkButton";
            this.bntOkButton.Size = new System.Drawing.Size(212, 28);
            this.bntOkButton.TabIndex = 7;
            this.bntOkButton.Text = "OK";
            this.bntOkButton.UseVisualStyleBackColor = true;
            this.bntOkButton.Click += new System.EventHandler(this.bntOkButton_Click);
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "English",
            "French"});
            this.cboLanguage.Location = new System.Drawing.Point(49, 71);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(212, 28);
            this.cboLanguage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Language";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntOkButton);
            this.Controls.Add(this.cboLanguage);
            this.MaximizeBox = false;
            this.Name = "frmEntry";
            this.Text = "Load CSV File";
            this.Load += new System.EventHandler(this.frmEntry_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntOkButton;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label label1;
    }
}