using System;
using System.Windows.Forms;

namespace LoadDisplayData
{
    public partial class frmEntry : Form
    {
        public frmEntry()
        {
            InitializeComponent();
        }

        private void bntOkButton_Click(object sender, EventArgs e)
        {
            string language = cboLanguage.SelectedItem.ToString();
            string cultureInfo;
            switch (language)
            {
                /*  Supported Language
                    English
                    French
                */

                case "French":
                    cultureInfo = "fr";
                    break;
               
                    
                default:
                    cultureInfo = "en-US";
                    break;
            }
            frmMain secondForm = new frmMain();
            secondForm.SetCultureInfo(cultureInfo);
            secondForm.Show();
            this.Visible = false;
        }

        private void frmEntry_Load(object sender, EventArgs e)
        {
            //default to English
            cboLanguage.SelectedIndex = 0;
        }
    }
}
